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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public DLFJLGFDMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C12C30", Offset = "0x5C11C30", VA = "0x185C12C30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C15140", Offset = "0x5C14140", VA = "0x185C15140", Slot = "5")]
	protected override void NGKOIINGJHA(PPHEHMBDBKI GOJKMEMCPDE, IDictionary<object, object> JANIFNADDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C14620", Offset = "0x5C13620", VA = "0x185C14620", Slot = "6")]
	public override PPHEHMBDBKI HJFKJCGGCHL(IDictionary<object, object> JANIFNADDOP)
	{
		return default(PPHEHMBDBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C157E0", Offset = "0x5C147E0", VA = "0x185C157E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x447C860", Offset = "0x447B860", VA = "0x18447C860")]
		public ADMBNPLLDBA(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D750", Offset = "0x5C0C750", VA = "0x185C0D750")]
		public bool CHHJCFLIPIC(ADMBNPLLDBA HNOJKNGFFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D7B0", Offset = "0x5C0C7B0", VA = "0x185C0D7B0", Slot = "0")]
		public override bool Equals(object CCPIHKCBGHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C0D870", Offset = "0x5C0C870", VA = "0x185C0D870", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x35E25E0", Offset = "0x35E15E0", VA = "0x1835E25E0")]
		public static CCOOCPIGFJB<T> GEFIPEPDOIA(PPHEHMBDBKI AKFEINAAGLL, Func<byte[], T> LBEMLHHBODH)
		{
			return default(CCOOCPIGFJB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x35E29C0", Offset = "0x35E19C0", VA = "0x1835E29C0")]
		public CCOOCPIGFJB(DIBHEHCDCPD KHEOGPAEOGJ, Guid[] OPMCHHANJHJ, T DEHKKADBBLP, bool AKCNJNOLMEC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35E2890", Offset = "0x35E1890", VA = "0x1835E2890", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public OPJMHNKBOEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5C181D0", Offset = "0x5C171D0", VA = "0x185C181D0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5C18220", Offset = "0x5C17220", VA = "0x185C18220")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public OLDBMMINMNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5C18040", Offset = "0x5C17040", VA = "0x185C18040")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C0CEC0", Offset = "0x5C0BEC0", VA = "0x185C0CEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5C0D700", Offset = "0x5C0C700", VA = "0x185C0D700", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public DOCPMILPDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5C12CF0", Offset = "0x5C11CF0", VA = "0x185C12CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C17250", Offset = "0x5C16250", VA = "0x185C17250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PPHEHMBDBKI> JAEDNEMMOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5C171B0", Offset = "0x5C161B0", VA = "0x185C171B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5C17110", Offset = "0x5C16110", VA = "0x185C17110")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5C173F0", Offset = "0x5C163F0", VA = "0x185C173F0")]
		public LGOCBNKDHLM(LDNNONIOCEP NDPLNOLDLOB, string IIPFBLIDMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C172A0", Offset = "0x5C162A0", VA = "0x185C172A0")]
		[AsyncStateMachine(typeof(ADHCJGOBMDJ))]
		public Task<PPHEHMBDBKI> PJOHOLMIDLE(CancellationToken GPNLCIOKAPO, TimeSpan AHJIFDNMDHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5C17060", Offset = "0x5C16060", VA = "0x185C17060")]
		public void HHCOHKMNFBL(PPHEHMBDBKI GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5C17010", Offset = "0x5C16010", VA = "0x185C17010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5C16EE0", Offset = "0x5C15EE0", VA = "0x185C16EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C13CA0", Offset = "0x5C12CA0", VA = "0x185C13CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5C145D0", Offset = "0x5C135D0", VA = "0x185C145D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C16170", Offset = "0x5C15170", VA = "0x185C16170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5C16520", Offset = "0x5C15520", VA = "0x185C16520", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C15820", Offset = "0x5C14820", VA = "0x185C15820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5C16120", Offset = "0x5C15120", VA = "0x185C16120", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C12E60", Offset = "0x5C11E60", VA = "0x185C12E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C13910", Offset = "0x5C12910", VA = "0x185C13910", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C17AE0", Offset = "0x5C16AE0", VA = "0x185C17AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5C17EC0", Offset = "0x5C16EC0", VA = "0x185C17EC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C18F40", Offset = "0x5C17F40", VA = "0x185C18F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5C190B0", Offset = "0x5C180B0", VA = "0x185C190B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public GJPAFIOIMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5C13B60", Offset = "0x5C12B60", VA = "0x185C13B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C18700", Offset = "0x5C17700", VA = "0x185C18700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65F320", Offset = "0x65E320", VA = "0x18065F320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2ACAF70", Offset = "0x2AC9F70", VA = "0x182ACAF70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C16880", Offset = "0x5C15880", VA = "0x185C16880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B20", Offset = "0xAB1B20", VA = "0x180AB2B20")]
		[DebuggerHidden]
		public IJFMLMLDLNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5C16570", Offset = "0x5C15570", VA = "0x185C16570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5C16840", Offset = "0x5C15840", VA = "0x185C16840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5C16790", Offset = "0x5C15790", VA = "0x185C16790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DIBHEHCDCPD, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5C16790", Offset = "0x5C15790", VA = "0x185C16790", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public AACCFNDMNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C0CDF0", Offset = "0x5C0BDF0", VA = "0x185C0CDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public DCFPOOOBGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5C12B90", Offset = "0x5C11B90", VA = "0x185C12B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public KAEDJNCHGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C168D0", Offset = "0x5C158D0", VA = "0x185C168D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public PAKBGPGELIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5C18620", Offset = "0x5C17620", VA = "0x185C18620")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public PEKFOAFPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5C18690", Offset = "0x5C17690", VA = "0x185C18690")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public GCGMPKDADLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5C13AD0", Offset = "0x5C12AD0", VA = "0x185C13AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public NOMGNABIBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5C17FB0", Offset = "0x5C16FB0", VA = "0x185C17FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public OMHELMMCDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5C18170", Offset = "0x5C17170", VA = "0x185C18170")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5C18110", Offset = "0x5C17110", VA = "0x185C18110")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public NOGPFOKOIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5C17F10", Offset = "0x5C16F10", VA = "0x185C17F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
		public KDCMLDGNKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5C169E0", Offset = "0x5C159E0", VA = "0x185C169E0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5C16C60", Offset = "0x5C15C60", VA = "0x185C16C60")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5C16970", Offset = "0x5C15970", VA = "0x185C16970")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C0EAF0", Offset = "0x5C0DAF0", VA = "0x185C0EAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C10C10", Offset = "0x5C0FC10", VA = "0x185C10C10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C126E0", Offset = "0x5C116E0", VA = "0x185C126E0")]
	public CNEPFFAJFGO(LDNNONIOCEP NDPLNOLDLOB, IMJIHPPIAKO ODPAKHKDPAG, BKJHIOAPNMM CHMKNIKMBMP, [Optional] TimeSpan? FOHLAHPPDEF, [Optional] FMOPAPGLKMO OHGCINDKBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2299F10", Offset = "0x2298F10", VA = "0x182299F10")]
	public static CNEPFFAJFGO NMJNKFAAEHH<TNetworking>(TNetworking IPDFOMJPIKI, [Optional] TimeSpan? FOHLAHPPDEF, [Optional] FMOPAPGLKMO OHGCINDKBFJ) where TNetworking : LDNNONIOCEP, IMJIHPPIAKO, BKJHIOAPNMM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C10480", Offset = "0x5C0F480", VA = "0x185C10480")]
	public void ICKDJJKFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C10CB0", Offset = "0x5C0FCB0", VA = "0x185C10CB0")]
	private byte JGHHFOGFABK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C100B0", Offset = "0x5C0F0B0", VA = "0x185C100B0")]
	private TimeSpan ELPHHDBMPEG(TimeSpan? FOHLAHPPDEF, int ELAPAINHDIN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22999B0", Offset = "0x22989B0", VA = "0x1822999B0")]
	public bool NDPNIBCDLLD<T>(T MCFLKOOKFMB, Func<T, byte[]> CFPIMFIOLEF, bool AKCNJNOLMEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C11580", Offset = "0x5C10580", VA = "0x185C11580")]
	public bool NDPNIBCDLLD(byte[] MCFLKOOKFMB, int EJGLLHGCMND, bool AKCNJNOLMEC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x737040", Offset = "0x736040", VA = "0x180737040")]
	private static string CCPHKNJCIPP(string GOJKMEMCPDE, string OODGAOEPCCI = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C111C0", Offset = "0x5C101C0", VA = "0x185C111C0")]
	[AsyncStateMachine(typeof(GNBDHPBLMMA))]
	public Task<PPHEHMBDBKI> KJDIDAGFAML(CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? FOHLAHPPDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C113F0", Offset = "0x5C103F0", VA = "0x185C113F0")]
	[AsyncStateMachine(typeof(IDMNPMDDMID))]
	public Task<Guid> MEIONALAMLH(Guid HGCCHMKILPJ, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22993A0", Offset = "0x22983A0", VA = "0x1822993A0")]
	[AsyncStateMachine(typeof(DPPJFOENNAN))]
	public Task<CCOOCPIGFJB<T>> CLJDHGBJBIG<T>(T MCFLKOOKFMB, Func<T, byte[]> CFPIMFIOLEF, Func<byte[], T> LBEMLHHBODH, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F050", Offset = "0x5C0E050", VA = "0x185C0F050")]
	[AsyncStateMachine(typeof(IBPPJILLMLI))]
	public Task<PPHEHMBDBKI> CLJDHGBJBIG(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C12290", Offset = "0x5C11290", VA = "0x185C12290")]
	[AsyncStateMachine(typeof(EBHCFLEDIIB))]
	private Task<PPHEHMBDBKI> PDDFOIILJIA(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, KFENGNLKFLE FKLGHKOMJOB, KFENGNLKFLE NGBNDHHEALK, TimeSpan? FOHLAHPPDEF, Stopwatch JIIKAOOLAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C102F0", Offset = "0x5C0F2F0", VA = "0x185C102F0")]
	[AsyncStateMachine(typeof(NMCLOBJLAAJ))]
	private Task<PPHEHMBDBKI> GDFEAAJDFIL(byte[] MCFLKOOKFMB, CancellationToken GPNLCIOKAPO, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, [Optional] TimeSpan? AHJIFDNMDHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C11B70", Offset = "0x5C10B70", VA = "0x185C11B70")]
	[AsyncStateMachine(typeof(PMFCKGBLKCJ))]
	public Task NHCCGNKOBHG(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task> GHJPKHHPAAH, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2299A60", Offset = "0x2298A60", VA = "0x182299A60")]
	[AsyncStateMachine(typeof(FJPPPAGLMLJ))]
	public Task<T> NHCCGNKOBHG<T>(CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH, [Optional] KFENGNLKFLE FKLGHKOMJOB, [Optional] KFENGNLKFLE NGBNDHHEALK, int KIDBPJKCJMO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2299560", Offset = "0x2298560", VA = "0x182299560")]
	[AsyncStateMachine(typeof(MAGDPDEPFCH))]
	private Task<(bool, T)> JMKAHBKOEGM<T>(Guid ALGKOPADFBP, CancellationToken OAFNKBHDHDC, Func<CancellationToken, Task<T>> GHJPKHHPAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F640", Offset = "0x5C0E640", VA = "0x185C0F640")]
	[IteratorStateMachine(typeof(IJFMLMLDLNH))]
	internal static IEnumerable<(DIBHEHCDCPD, Guid)> CPLGBPGMLOH(DIBHEHCDCPD BKIHPMLEFFB, Guid[] NOCEHHOBFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DFB0", Offset = "0x5C0CFB0", VA = "0x185C0DFB0")]
	public void AGOJDHNCAHI(byte IFOEKECCJIL, int DNKHIDJJODP, object HGENDMPDIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0EDF0", Offset = "0x5C0DDF0", VA = "0x185C0EDF0")]
	public Guid CIOFONLOHKJ(Guid LILJPPICPPN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F6D0", Offset = "0x5C0E6D0", VA = "0x185C0F6D0")]
	internal static int DFJHGHBLHCG(DIBHEHCDCPD KHEOGPAEOGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C10CD0", Offset = "0x5C0FCD0", VA = "0x185C10CD0")]
	public bool KFJANOFDACM(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C11CE0", Offset = "0x5C10CE0", VA = "0x185C11CE0")]
	public void NICLIKDNADG(DIBHEHCDCPD KHEOGPAEOGJ, Guid ALGKOPADFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C10CC0", Offset = "0x5C0FCC0", VA = "0x185C10CC0")]
	private void KEKBCDMDEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F1E0", Offset = "0x5C0E1E0", VA = "0x185C0F1E0")]
	internal (DIBHEHCDCPD, Guid[]) CNAELAFEGIK(bool OJGGILPHFII = false)
	{
		return default((DIBHEHCDCPD, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C0EB90", Offset = "0x5C0DB90", VA = "0x185C0EB90")]
	private HashSet<Guid> BBHJKBEFOAP(DIBHEHCDCPD KHEOGPAEOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C120D0", Offset = "0x5C110D0", VA = "0x185C120D0")]
	private void NPBFDFCJAFK(DIBHEHCDCPD KHEOGPAEOGJ, Guid FCDKMJOKGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F8B0", Offset = "0x5C0E8B0", VA = "0x185C0F8B0")]
	private void EDJJCBBMBAC(DIBHEHCDCPD KHEOGPAEOGJ, Guid FCDKMJOKGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C11340", Offset = "0x5C10340", VA = "0x185C11340")]
	public static Func<Guid, bool> LLBKMEOCBAK(Guid FCDKMJOKGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C0EA40", Offset = "0x5C0DA40", VA = "0x185C0EA40")]
	public static Func<Guid, bool> AIPKBKELEPG(Guid FCDKMJOKGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F7A0", Offset = "0x5C0E7A0", VA = "0x185C0F7A0")]
	public void DGCBMIAKBKD(DIBHEHCDCPD KHEOGPAEOGJ, Guid ADBPGLEFIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FB90", Offset = "0x5C0EB90", VA = "0x185C0FB90")]
	public void EFDAEEMBHGI(DIBHEHCDCPD KHEOGPAEOGJ, Func<Guid, bool> NHNJBDLKFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C0ECD0", Offset = "0x5C0DCD0", VA = "0x185C0ECD0")]
	private static ExitGames.Client.Photon.Hashtable BPNJIEJOJMM(DIBHEHCDCPD KHEOGPAEOGJ, Guid ICMCPKCLKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C10570", Offset = "0x5C0F570", VA = "0x185C10570")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DE20", Offset = "0x65CE20", VA = "0x18065DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C185A0", Offset = "0x5C175A0", VA = "0x185C185A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C0DFA0", Offset = "0x5C0CFA0", VA = "0x185C0DFA0")]
		public BJJODMBMHBB(Guid GJGLHDLJIFD, int LFKALCOIONB, int AFHGHBKAKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DD80", Offset = "0x5C0CD80", VA = "0x185C0DD80")]
		public static byte[] DGAMFOBEJMM(BJJODMBMHBB GOJKMEMCPDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DEE0", Offset = "0x5C0CEE0", VA = "0x185C0DEE0")]
		public static BJJODMBMHBB HJFKJCGGCHL(byte[] HFAIGCGNPJJ)
		{
			return default(BJJODMBMHBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DE60", Offset = "0x5C0CE60", VA = "0x185C0DE60")]
		private static byte[] HGJPDJDOIMA(int HLAPKJLCEDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DCD0", Offset = "0x5C0CCD0", VA = "0x185C0DCD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C17A80", Offset = "0x5C16A80", VA = "0x185C17A80")]
	public MHAPMLMNPBL(Guid GJGLHDLJIFD, CNEPFFAJFGO OINNIBDJDBL, BKJHIOAPNMM IPDFOMJPIKI, CancellationToken OAFNKBHDHDC, [Optional] AAFKANBFFFG PNIPJMCLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5C174F0", Offset = "0x5C164F0", VA = "0x185C174F0", Slot = "5")]
	protected override void EFIMIJPAION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5C176C0", Offset = "0x5C166C0", VA = "0x185C176C0", Slot = "6")]
	protected override void HEBCBDIMMHP(int MHJBAPGAGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5C17860", Offset = "0x5C16860", VA = "0x185C17860")]
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
	[Cpp2IlInjected.Address(RVA = "0x5C18EE0", Offset = "0x5C17EE0", VA = "0x185C18EE0")]
	public PPHEHMBDBKI(CNEPFFAJFGO.DIBHEHCDCPD KHEOGPAEOGJ, [NotNull] Guid[] OPMCHHANJHJ, [CanBeNull] byte[] DEHKKADBBLP, bool AKCNJNOLMEC, byte BLDPJFBNENL, byte FJMGKNECOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5C18B30", Offset = "0x5C17B30", VA = "0x185C18B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5C18940", Offset = "0x5C17940", VA = "0x185C18940")]
	private static void IMIJJOHEMKH(byte[] DEHKKADBBLP, StringBuilder NHDKHCEFNFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class ILBPGEHAPFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x244F7C0", Offset = "0x244E7C0", VA = "0x18244F7C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1075CB0", Offset = "0x1074CB0", VA = "0x181075CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C0DAA0", Offset = "0x5C0CAA0", VA = "0x185C0DAA0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KJLMOOEJKGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0DA50", Offset = "0x5C0CA50", VA = "0x185C0DA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DB20", Offset = "0x5C0CB20", VA = "0x185C0DB20")]
	public BDFPHCNKEIF(BKJHIOAPNMM IPDFOMJPIKI, CancellationToken OAFNKBHDHDC, [Optional] AAFKANBFFFG PNIPJMCLDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D940", Offset = "0x5C0C940", VA = "0x185C0D940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D960", Offset = "0x5C0C960", VA = "0x185C0D960", Slot = "5")]
	protected virtual void EFIMIJPAION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D8A0", Offset = "0x5C0C8A0", VA = "0x185C0D8A0")]
	private void CIKCJACLPAB(NAJNLFAFJGC JDJIPOFHFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DAC0", Offset = "0x5C0CAC0", VA = "0x185C0DAC0")]
	protected void MFOMABCKMMF(int MHJBAPGAGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DA30", Offset = "0x5C0CA30", VA = "0x185C0DA30", Slot = "6")]
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
