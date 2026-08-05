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
internal class HBJBLMANAJA : global::ILBPGEHAPFC<PPHEHMBDBKI>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DLFJLGFDMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DLFJLGFDMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BC8C70", Offset = "0x5BC7A70", VA = "0x185BC8C70")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] ECPIALBGNNL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly HBJBLMANAJA JNHMLOILMCH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB180", Offset = "0x5BC9F80", VA = "0x185BCB180", Slot = "5")]
	protected override void NGKOIINGJHA(PPHEHMBDBKI GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BCA660", Offset = "0x5BC9460", VA = "0x185BCA660", Slot = "6")]
	public override PPHEHMBDBKI HJFKJCGGCHL(IDictionary<object, object> JANIFNADDOP)
	{
		return default(PPHEHMBDBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB820", Offset = "0x5BCA620", VA = "0x185BCB820")]
	public HBJBLMANAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CNEPFFAJFGO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string FMOPAPGLKMO([NotNull] byte[] DEHKKADBBLP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum DIBHEHCDCPD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct ADMBNPLLDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly DIBHEHCDCPD KBPJGIOCPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid AOKFNPBLCFM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4348F90", Offset = "0x4347D90", VA = "0x184348F90")]
		public ADMBNPLLDBA(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3790", Offset = "0x5BC2590", VA = "0x185BC3790")]
		public bool CHHJCFLIPIC(ADMBNPLLDBA HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BC37F0", Offset = "0x5BC25F0", VA = "0x185BC37F0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BC38B0", Offset = "0x5BC26B0", VA = "0x185BC38B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct CCOOCPIGFJB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly bool BICMIPMHNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly DIBHEHCDCPD KBPJGIOCPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Guid[] DLBFNMOOPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly T GGMKJCLGDEI;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3326AA0", Offset = "0x33258A0", VA = "0x183326AA0")]
		public static CCOOCPIGFJB<T> GEFIPEPDOIA(PPHEHMBDBKI AKFEINAAGLL, Func<byte[], T> LBEMLHHBODH)
		{
			return default(CCOOCPIGFJB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3326E80", Offset = "0x3325C80", VA = "0x183326E80")]
		public CCOOCPIGFJB(DIBHEHCDCPD KHEOGPAEOGJ, Guid[] OPMCHHANJHJ, T DEHKKADBBLP, bool AKCNJNOLMEC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3326D50", Offset = "0x3325B50", VA = "0x183326D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LGOCBNKDHLM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OPJMHNKBOEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public TaskCompletionSource<PPHEHMBDBKI> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public LGOCBNKDHLM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public OPJMHNKBOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE210", Offset = "0x5BCD010", VA = "0x185BCE210")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE260", Offset = "0x5BCD060", VA = "0x185BCE260")]
			internal OPNGDGBKINH <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OLDBMMINMNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public NNKDONAICAI.BGFKMFJALGG itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public OLDBMMINMNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE080", Offset = "0x5BCCE80", VA = "0x185BCE080")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct ADHCJGOBMDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder<PPHEHMBDBKI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public LGOCBNKDHLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private OPJMHNKBOEE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<PPHEHMBDBKI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5BC2F00", Offset = "0x5BC1D00", VA = "0x185BC2F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5BC3740", Offset = "0x5BC2540", VA = "0x185BC3740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DOCPMILPDBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public DIBHEHCDCPD sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public DOCPMILPDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BC8D30", Offset = "0x5BC7B30", VA = "0x185BC8D30")]
			internal bool <ClearSlice>b__0(PPHEHMBDBKI bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LDNNONIOCEP NDPLNOLDLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly string IIPFBLIDMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<PPHEHMBDBKI> PGIOFGGAMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private List<(NNKDONAICAI.BGFKMFJALGG itemType, long totalStopwatchTicks)> NDFPOOLBPPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CBKMPGKPIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD290", Offset = "0x5BCC090", VA = "0x185BCD290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PPHEHMBDBKI> JAEDNEMMOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD1F0", Offset = "0x5BCBFF0", VA = "0x185BCD1F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD150", Offset = "0x5BCBF50", VA = "0x185BCD150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD430", Offset = "0x5BCC230", VA = "0x185BCD430")]
		public LGOCBNKDHLM(LDNNONIOCEP NDPLNOLDLOB, string IIPFBLIDMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD2E0", Offset = "0x5BCC0E0", VA = "0x185BCD2E0")]
		[AsyncStateMachine(typeof(ADHCJGOBMDJ))]
		public Task<PPHEHMBDBKI> PJOHOLMIDLE(CancellationToken GPNLCIOKAPO, TimeSpan AHJIFDNMDHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD0A0", Offset = "0x5BCBEA0", VA = "0x185BCD0A0")]
		public void HHCOHKMNFBL(PPHEHMBDBKI GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD050", Offset = "0x5BCBE50", VA = "0x185BCD050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCF20", Offset = "0x5BCBD20", VA = "0x185BCCF20")]
		public void DGCBMIAKBKD(DIBHEHCDCPD KHEOGPAEOGJ, Guid FCDKMJOKGIE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GNBDHPBLMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<PPHEHMBDBKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9CE0", Offset = "0x5BC8AE0", VA = "0x185BC9CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA610", Offset = "0x5BC9410", VA = "0x185BCA610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IDMNPMDDMID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<CCOOCPIGFJB<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC1B0", Offset = "0x5BCAFB0", VA = "0x185BCC1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC560", Offset = "0x5BCB360", VA = "0x185BCC560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IBPPJILLMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<PPHEHMBDBKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB860", Offset = "0x5BCA660", VA = "0x185BCB860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC160", Offset = "0x5BCAF60", VA = "0x185BCC160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FDKBLIEBNGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FDKBLIEBNGD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct EBHCFLEDIIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<PPHEHMBDBKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private FDKBLIEBNGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private BDFPHCNKEIF <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5BC8EA0", Offset = "0x5BC7CA0", VA = "0x185BC8EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9950", Offset = "0x5BC8750", VA = "0x185BC9950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct NMCLOBJLAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<PPHEHMBDBKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<PPHEHMBDBKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDB20", Offset = "0x5BCC920", VA = "0x185BCDB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDF00", Offset = "0x5BCCD00", VA = "0x185BCDF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GJPAFIOIMAL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public GJPAFIOIMAL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5BCEF80", Offset = "0x5BCDD80", VA = "0x185BCEF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5BCF0F0", Offset = "0x5BCDEF0", VA = "0x185BCF0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GJPAFIOIMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9BA0", Offset = "0x5BC89A0", VA = "0x185BC9BA0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PMFCKGBLKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CNEPFFAJFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KFENGNLKFLE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KFENGNLKFLE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE740", Offset = "0x5BCD540", VA = "0x185BCE740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IJFMLMLDLNH : IEnumerable<(DIBHEHCDCPD, Guid)>, IEnumerable, IEnumerator<(DIBHEHCDCPD, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private (DIBHEHCDCPD sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private DIBHEHCDCPD sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DIBHEHCDCPD <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DIBHEHCDCPD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (DIBHEHCDCPD, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x27B33F0", Offset = "0x27B21F0", VA = "0x1827B33F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DIBHEHCDCPD, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC8C0", Offset = "0x5BCB6C0", VA = "0x185BCC8C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8B3770", Offset = "0x8B2570", VA = "0x1808B3770")]
		[DebuggerHidden]
		public IJFMLMLDLNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC5B0", Offset = "0x5BCB3B0", VA = "0x185BCC5B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC880", Offset = "0x5BCB680", VA = "0x185BCC880", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC7D0", Offset = "0x5BCB5D0", VA = "0x185BCC7D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DIBHEHCDCPD, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC7D0", Offset = "0x5BCB5D0", VA = "0x185BCC7D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AACCFNDMNDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public AACCFNDMNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2E30", Offset = "0x5BC1C30", VA = "0x185BC2E30")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DCFPOOOBGEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DIBHEHCDCPD sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public DCFPOOOBGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC8BD0", Offset = "0x5BC79D0", VA = "0x185BC8BD0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KAEDJNCHGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DIBHEHCDCPD sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KAEDJNCHGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC910", Offset = "0x5BCB710", VA = "0x185BCC910")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PAKBGPGELIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PAKBGPGELIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE660", Offset = "0x5BCD460", VA = "0x185BCE660")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PEKFOAFPLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public PEKFOAFPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE6D0", Offset = "0x5BCD4D0", VA = "0x185BCE6D0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GCGMPKDADLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public GCGMPKDADLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9B10", Offset = "0x5BC8910", VA = "0x185BC9B10")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NOMGNABIBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NOMGNABIBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDFF0", Offset = "0x5BCCDF0", VA = "0x185BCDFF0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OMHELMMCDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public OMHELMMCDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE1B0", Offset = "0x5BCCFB0", VA = "0x185BCE1B0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE150", Offset = "0x5BCCF50", VA = "0x185BCE150")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NOGPFOKOIPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public NOGPFOKOIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDF50", Offset = "0x5BCCD50", VA = "0x185BCDF50")]
		internal bool <ClearSliceIds>b__3(ADMBNPLLDBA stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KDCMLDGNKPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public KDCMLDGNKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCA20", Offset = "0x5BCB820", VA = "0x185BCCA20")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCCA0", Offset = "0x5BCBAA0", VA = "0x185BCCCA0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC9B0", Offset = "0x5BCB7B0", VA = "0x185BCC9B0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly FMOPAPGLKMO CNPNPKPEBKO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable ENMGHICGBNH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PAKHLOGANCK BMFOHINIKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LGOCBNKDHLM LKLMOLGBLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LDNNONIOCEP NDPLNOLDLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IMJIHPPIAKO ODPAKHKDPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BKJHIOAPNMM CHMKNIKMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FMOPAPGLKMO AOBABLHGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DGKCCECAGMN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan DNEOFLKHFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan LCNEJLLOPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte KLOKJHDGIMM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly DIBHEHCDCPD[] CMLLFGIKKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] DIEGLHAFOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<ADMBNPLLDBA> OKGILNHAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (DIBHEHCDCPD combinedSliceType, Guid[] sliceTypeIds)? DJDDBNDDBPI;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly PAKHLOGANCK ACHEKBAEFCO;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly PAKHLOGANCK DPGNDKKLAIC;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<PPHEHMBDBKI> KBMNCAKOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4B30", Offset = "0x5BC3930", VA = "0x185BC4B30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BC6C50", Offset = "0x5BC5A50", VA = "0x185BC6C50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8720", Offset = "0x5BC7520", VA = "0x185BC8720")]
	public CNEPFFAJFGO(LDNNONIOCEP NDPLNOLDLOB, IMJIHPPIAKO ODPAKHKDPAG, BKJHIOAPNMM CHMKNIKMBMP, [Optional] TimeSpan? FOHLAHPPDEF, [Optional] FMOPAPGLKMO OHGCINDKBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1F81A30", Offset = "0x1F80830", VA = "0x181F81A30")]
	public static CNEPFFAJFGO NMJNKFAAEHH<TNetworking>(TNetworking IPDFOMJPIKI, [Optional] TimeSpan? FOHLAHPPDEF, [Optional] FMOPAPGLKMO OHGCINDKBFJ) where TNetworking : LDNNONIOCEP, IMJIHPPIAKO, BKJHIOAPNMM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC64C0", Offset = "0x5BC52C0", VA = "0x185BC64C0")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6CF0", Offset = "0x5BC5AF0", VA = "0x185BC6CF0")]
	private byte JGHHFOGFABK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC60F0", Offset = "0x5BC4EF0", VA = "0x185BC60F0")]
	private TimeSpan ELPHHDBMPEG(TimeSpan? FOHLAHPPDEF, int ELAPAINHDIN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F814D0", Offset = "0x1F802D0", VA = "0x181F814D0")]
	public bool NDPNIBCDLLD<T>(T MCFLKOOKFMB, Func<T, byte[]> CFPIMFIOLEF, bool AKCNJNOLMEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC75C0", Offset = "0x5BC63C0", VA = "0x185BC75C0")]
	public bool NDPNIBCDLLD(byte[] MCFLKOOKFMB, int EJGLLHGCMND, bool AKCNJNOLMEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	private static string CCPHKNJCIPP(string GOJKMEMCPDE, string OODGAOEPCCI = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7200", Offset = "0x5BC6000", VA = "0x185BC7200")]
	[AsyncStateMachine(typeof(GNBDHPBLMMA))]
	public Task<PPHEHMBDBKI> KJDIDAGFAML(CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? FOHLAHPPDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7430", Offset = "0x5BC6230", VA = "0x185BC7430")]
	[AsyncStateMachine(typeof(IDMNPMDDMID))]
	public Task<Guid> MEIONALAMLH(Guid HGCCHMKILPJ, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F80EC0", Offset = "0x1F7FCC0", VA = "0x181F80EC0")]
	[AsyncStateMachine(typeof(DPPJFOENNAN))]
	public Task<CCOOCPIGFJB<T>> CLJDHGBJBIG<T>(T MCFLKOOKFMB, Func<T, byte[]> CFPIMFIOLEF, Func<byte[], T> LBEMLHHBODH, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5090", Offset = "0x5BC3E90", VA = "0x185BC5090")]
	[AsyncStateMachine(typeof(IBPPJILLMLI))]
	public Task<PPHEHMBDBKI> CLJDHGBJBIG(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BC82D0", Offset = "0x5BC70D0", VA = "0x185BC82D0")]
	[AsyncStateMachine(typeof(EBHCFLEDIIB))]
	private Task<PPHEHMBDBKI> PDDFOIILJIA(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, KFENGNLKFLE FKLGHKOMJOB, KFENGNLKFLE NGBNDHHEALK, TimeSpan? FOHLAHPPDEF, Stopwatch JIIKAOOLAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6330", Offset = "0x5BC5130", VA = "0x185BC6330")]
	[AsyncStateMachine(typeof(NMCLOBJLAAJ))]
	private Task<PPHEHMBDBKI> GDFEAAJDFIL(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7BB0", Offset = "0x5BC69B0", VA = "0x185BC7BB0")]
	[AsyncStateMachine(typeof(PMFCKGBLKCJ))]
	public Task NHCCGNKOBHG(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task> GHJPKHHPAAH, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F81580", Offset = "0x1F80380", VA = "0x181F81580")]
	[AsyncStateMachine(typeof(FJPPPAGLMLJ))]
	public Task<T> NHCCGNKOBHG<T>(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F81080", Offset = "0x1F7FE80", VA = "0x181F81080")]
	[AsyncStateMachine(typeof(MAGDPDEPFCH))]
	private Task<(bool, T)> JMKAHBKOEGM<T>(Guid ALGKOPADFBP, CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5680", Offset = "0x5BC4480", VA = "0x185BC5680")]
	[IteratorStateMachine(typeof(IJFMLMLDLNH))]
	internal static IEnumerable<(DIBHEHCDCPD, Guid)> CPLGBPGMLOH(DIBHEHCDCPD BKIHPMLEFFB, Guid[] NOCEHHOBFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3FF0", Offset = "0x5BC2DF0", VA = "0x185BC3FF0")]
	public void AGOJDHNCAHI(byte IFOEKECCJIL, int DNKHIDJJODP, object HGENDMPDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4E30", Offset = "0x5BC3C30", VA = "0x185BC4E30")]
	public Guid CIOFONLOHKJ(Guid LILJPPICPPN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5710", Offset = "0x5BC4510", VA = "0x185BC5710")]
	internal static int DFJHGHBLHCG(DIBHEHCDCPD KHEOGPAEOGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6D10", Offset = "0x5BC5B10", VA = "0x185BC6D10")]
	public bool KFJANOFDACM(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7D20", Offset = "0x5BC6B20", VA = "0x185BC7D20")]
	public void NICLIKDNADG(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6D00", Offset = "0x5BC5B00", VA = "0x185BC6D00")]
	private void KEKBCDMDEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5220", Offset = "0x5BC4020", VA = "0x185BC5220")]
	internal (DIBHEHCDCPD, Guid[]) CNAELAFEGIK(bool OJGGILPHFII = false)
	{
		return default((DIBHEHCDCPD, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4BD0", Offset = "0x5BC39D0", VA = "0x185BC4BD0")]
	private HashSet<Guid> BBHJKBEFOAP(DIBHEHCDCPD KHEOGPAEOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8110", Offset = "0x5BC6F10", VA = "0x185BC8110")]
	private void NPBFDFCJAFK(DIBHEHCDCPD KHEOGPAEOGJ, Guid FCDKMJOKGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BC58F0", Offset = "0x5BC46F0", VA = "0x185BC58F0")]
	private void EDJJCBBMBAC(DIBHEHCDCPD KHEOGPAEOGJ, Guid FCDKMJOKGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7380", Offset = "0x5BC6180", VA = "0x185BC7380")]
	public static Func<Guid, bool> LLBKMEOCBAK(Guid FCDKMJOKGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4A80", Offset = "0x5BC3880", VA = "0x185BC4A80")]
	public static Func<Guid, bool> AIPKBKELEPG(Guid FCDKMJOKGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BC57E0", Offset = "0x5BC45E0", VA = "0x185BC57E0")]
	public void DGCBMIAKBKD(DIBHEHCDCPD KHEOGPAEOGJ, Guid ADBPGLEFIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5BD0", Offset = "0x5BC49D0", VA = "0x185BC5BD0")]
	public void EFDAEEMBHGI(DIBHEHCDCPD KHEOGPAEOGJ, Func<Guid, bool> NHNJBDLKFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4D10", Offset = "0x5BC3B10", VA = "0x185BC4D10")]
	private static ExitGames.Client.Photon.Hashtable BPNJIEJOJMM(DIBHEHCDCPD KHEOGPAEOGJ, Guid ICMCPKCLKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC65B0", Offset = "0x5BC53B0", VA = "0x185BC65B0")]
	private void JFBJFKEECBK(DIBHEHCDCPD KHEOGPAEOGJ, Guid ICMCPKCLKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OPNGDGBKINH : GCNCKEFEKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private List<(NNKDONAICAI.BGFKMFJALGG itemType, long totalStopwatchTicks)> NKDHHNNNOED;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(NNKDONAICAI.BGFKMFJALGG itemType, long totalStopwatchTicks)> DIMELNMEGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x705590", Offset = "0x704390", VA = "0x180705590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE5E0", Offset = "0x5BCD3E0", VA = "0x185BCE5E0")]
	public OPNGDGBKINH(TimeSpan AHJIFDNMDHL, List<(NNKDONAICAI.BGFKMFJALGG itemType, long totalStopwatchTicks)> NKDHHNNNOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MHAPMLMNPBL : BDFPHCNKEIF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct BJJODMBMHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Guid DHOCFODLIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly int ILIJLKHFOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly int CDIBJNKAMLP;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3FE0", Offset = "0x5BC2DE0", VA = "0x185BC3FE0")]
		public BJJODMBMHBB(Guid GJGLHDLJIFD, int LFKALCOIONB, int AFHGHBKAKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3DC0", Offset = "0x5BC2BC0", VA = "0x185BC3DC0")]
		public static byte[] DGAMFOBEJMM(BJJODMBMHBB GOJKMEMCPDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3F20", Offset = "0x5BC2D20", VA = "0x185BC3F20")]
		public static BJJODMBMHBB HJFKJCGGCHL(byte[] HFAIGCGNPJJ)
		{
			return default(BJJODMBMHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3EA0", Offset = "0x5BC2CA0", VA = "0x185BC3EA0")]
		private static byte[] HGJPDJDOIMA(int HLAPKJLCEDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3D10", Offset = "0x5BC2B10", VA = "0x185BC3D10")]
		private static int BPEMJIKGPEB(byte[] DCLJLKJJLLN, int AIPHGHFENPJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid GJGLHDLJIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly CNEPFFAJFGO OINNIBDJDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool EMPJDPIDBAN;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5BCDAC0", Offset = "0x5BCC8C0", VA = "0x185BCDAC0")]
	public MHAPMLMNPBL(Guid GJGLHDLJIFD, CNEPFFAJFGO OINNIBDJDBL, BKJHIOAPNMM IPDFOMJPIKI, CancellationToken OAFNKBHDHDC, [Optional] AAFKANBFFFG PNIPJMCLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5BCD530", Offset = "0x5BCC330", VA = "0x185BCD530", Slot = "5")]
	protected override void EFIMIJPAION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5BCD700", Offset = "0x5BCC500", VA = "0x185BCD700", Slot = "6")]
	protected override void HEBCBDIMMHP(int MHJBAPGAGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5BCD8A0", Offset = "0x5BCC6A0", VA = "0x185BCD8A0")]
	private void KBMNCAKOMKH(PPHEHMBDBKI MNFBPOAGLEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct PPHEHMBDBKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte KKHBADFDPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly byte FKFBEKFJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool BICMIPMHNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly CNEPFFAJFGO.DIBHEHCDCPD KBPJGIOCPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] DLBFNMOOPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly byte[] GGMKJCLGDEI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5BCEF20", Offset = "0x5BCDD20", VA = "0x185BCEF20")]
	public PPHEHMBDBKI(CNEPFFAJFGO.DIBHEHCDCPD KHEOGPAEOGJ, [NotNull] Guid[] OPMCHHANJHJ, [CanBeNull] byte[] DEHKKADBBLP, bool AKCNJNOLMEC, byte BLDPJFBNENL, byte FJMGKNECOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5BCEB70", Offset = "0x5BCD970", VA = "0x185BCEB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5BCE980", Offset = "0x5BCD780", VA = "0x185BCE980")]
	private static void IMIJJOHEMKH(byte[] DEHKKADBBLP, StringBuilder NHDKHCEFNFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class ILBPGEHAPFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2137540", Offset = "0x2136340", VA = "0x182137540", Slot = "4")]
	public void GFNCOPKOHJC(T GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP, bool AHKCBABCMLP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void NGKOIINGJHA(T GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T HJFKJCGGCHL(IDictionary<object, object> JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
	protected ILBPGEHAPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BDFPHCNKEIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool AAFKANBFFFG(int GJFHPHNGPDN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NNFHDNBGFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly BKJHIOAPNMM CMLCMGNCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly CancellationToken OAFNKBHDHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly CancellationToken JOAIAPCAJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly AAFKANBFFFG PNIPJMCLDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly CancellationTokenSource DGMKDPADKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly CancellationTokenSource BOKGENECHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly int JDENDGIJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool DONOHOOHIDN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken MBANFGGFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3AE0", Offset = "0x5BC28E0", VA = "0x185BC3AE0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KJLMOOEJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3A90", Offset = "0x5BC2890", VA = "0x185BC3A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3B60", Offset = "0x5BC2960", VA = "0x185BC3B60")]
	public BDFPHCNKEIF(BKJHIOAPNMM IPDFOMJPIKI, CancellationToken OAFNKBHDHDC, [Optional] AAFKANBFFFG PNIPJMCLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3980", Offset = "0x5BC2780", VA = "0x185BC3980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5BC39A0", Offset = "0x5BC27A0", VA = "0x185BC39A0", Slot = "5")]
	protected virtual void EFIMIJPAION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5BC38E0", Offset = "0x5BC26E0", VA = "0x185BC38E0")]
	private void CIKCJACLPAB(NAJNLFAFJGC JDJIPOFHFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3B00", Offset = "0x5BC2900", VA = "0x185BC3B00")]
	protected void MFOMABCKMMF(int MHJBAPGAGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3A70", Offset = "0x5BC2870", VA = "0x185BC3A70", Slot = "6")]
	protected virtual void HEBCBDIMMHP(int MHJBAPGAGLD)
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
