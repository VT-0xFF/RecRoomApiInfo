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
internal class OAFPPNOMIGC : global::FGMFHGDMKOO<PLOGCBHLODG>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NHPIODPNAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NHPIODPNAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6676D10", Offset = "0x6676110", VA = "0x186676D10")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] IJHGGDJBACA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly OAFPPNOMIGC AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6677010", Offset = "0x6676410", VA = "0x186677010", Slot = "5")]
	protected override void HPPGFLNFHCF(PLOGCBHLODG BALNMHDNCIN, IDictionary<object, object> HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6677480", Offset = "0x6676880", VA = "0x186677480", Slot = "6")]
	public override PLOGCBHLODG JDGCKOHAIDJ(IDictionary<object, object> HIDEHJGLNHO)
	{
		return default(PLOGCBHLODG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6678220", Offset = "0x6677620", VA = "0x186678220")]
	public OAFPPNOMIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class HFKOONKIHDN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string PGDMOFJPEIO([NotNull] byte[] GJNIFGAPEDN);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct AELILFMFADF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly BOBHDEJOJAK OGPOHNBNCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool HMJGEKGHJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T EEFKAIKPIBN;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B99280", Offset = "0x2B98680", VA = "0x182B99280")]
		public static AELILFMFADF<T> CCGHALMPKMH(PLOGCBHLODG CKIINAAMBFI, Func<byte[], T> DJJOGIGEKNG)
		{
			return default(AELILFMFADF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B99630", Offset = "0x2B98A30", VA = "0x182B99630")]
		public AELILFMFADF(BOBHDEJOJAK IEDJDBIDMPA, T GJNIFGAPEDN, bool IPBFLDBKNOF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B99490", Offset = "0x2B98890", VA = "0x182B99490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GPPOMFOJLGN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MIKELMJEHIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<PLOGCBHLODG> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public GPPOMFOJLGN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public MIKELMJEHIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6676720", Offset = "0x6675B20", VA = "0x186676720")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6676770", Offset = "0x6675B70", VA = "0x186676770")]
			internal BCEMPKIHNCG <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DCDLGLOEGFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public ADDOPBLDHDH.JDBLNOPBOBL itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public DCDLGLOEGFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x666F0D0", Offset = "0x666E4D0", VA = "0x18666F0D0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct BGANACMLFNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<PLOGCBHLODG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GPPOMFOJLGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private MIKELMJEHIB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<PLOGCBHLODG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x666CB80", Offset = "0x666BF80", VA = "0x18666CB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x666D390", Offset = "0x666C790", VA = "0x18666D390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MNGCHFJNBNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public ELBNKGMODON sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public MNGCHFJNBNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6676BA0", Offset = "0x6675FA0", VA = "0x186676BA0")]
			internal bool <ClearSlice>b__0(PLOGCBHLODG bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LPMJLEAIFHF DPFHDGKIAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string KFENOIBIOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<PLOGCBHLODG> PONAEGOCBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(ADDOPBLDHDH.JDBLNOPBOBL itemType, long totalStopwatchTicks)> HIBBGJLMMPC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KABICLACIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6670A30", Offset = "0x666FE30", VA = "0x186670A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PLOGCBHLODG> KEFADFLDOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6670BB0", Offset = "0x666FFB0", VA = "0x186670BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6670740", Offset = "0x666FB40", VA = "0x186670740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6670C50", Offset = "0x6670050", VA = "0x186670C50")]
		public GPPOMFOJLGN(LPMJLEAIFHF DPFHDGKIAKC, string KFENOIBIOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66708E0", Offset = "0x666FCE0", VA = "0x1866708E0")]
		[AsyncStateMachine(typeof(BGANACMLFNE))]
		public Task<PLOGCBHLODG> FBPIHPCOGHA(CancellationToken OIMNLGJCBEC, TimeSpan AOEGDFNBHBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6670830", Offset = "0x666FC30", VA = "0x186670830")]
		public void EFPIFCJNAJE(PLOGCBHLODG BALNMHDNCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x66707E0", Offset = "0x666FBE0", VA = "0x1866707E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6670A80", Offset = "0x666FE80", VA = "0x186670A80")]
		public void IIKKLLELFKF(ELBNKGMODON LLHBJHACOFE, Guid PKNOIGMENLD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ELMLBFBAIEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<PLOGCBHLODG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public MNALPKGIDEG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x666FAF0", Offset = "0x666EEF0", VA = "0x18666FAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6670440", Offset = "0x666F840", VA = "0x186670440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BJDBIKBBMJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MNALPKGIDEG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<AELILFMFADF<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x666D3E0", Offset = "0x666C7E0", VA = "0x18666D3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x666D790", Offset = "0x666CB90", VA = "0x18666D790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DKIAINJMHKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<PLOGCBHLODG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public MNALPKGIDEG pauseAfterListeningToken;

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
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x666F1A0", Offset = "0x666E5A0", VA = "0x18666F1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x666FAA0", Offset = "0x666EEA0", VA = "0x18666FAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OBAMJLDLKIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OBAMJLDLKIL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BKANKCEONEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<PLOGCBHLODG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private OBAMJLDLKIL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MNALPKGIDEG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private POGILJNMLPD <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x666D7E0", Offset = "0x666CBE0", VA = "0x18666D7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x666E2C0", Offset = "0x666D6C0", VA = "0x18666E2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HIFAOIFKIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<PLOGCBHLODG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public MNALPKGIDEG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<PLOGCBHLODG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x66755E0", Offset = "0x66749E0", VA = "0x1866755E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x66759C0", Offset = "0x6674DC0", VA = "0x1866759C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OFPBHNCABGC
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
			public OFPBHNCABGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6679560", Offset = "0x6678960", VA = "0x186679560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x66796D0", Offset = "0x6678AD0", VA = "0x1866796D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OFPBHNCABGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x66783D0", Offset = "0x66777D0", VA = "0x1866783D0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NJNPPJDEFEL : IAsyncStateMachine
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
		public HFKOONKIHDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MNALPKGIDEG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MNALPKGIDEG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6676DD0", Offset = "0x66761D0", VA = "0x186676DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HGEAKONGNFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HGEAKONGNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6675540", Offset = "0x6674940", VA = "0x186675540")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x66754F0", Offset = "0x66748F0", VA = "0x1866754F0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MMHCKFPDLEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public ELBNKGMODON sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MMHCKFPDLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6676B00", Offset = "0x6675F00", VA = "0x186676B00")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HMOPPAJKDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public ELBNKGMODON sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HMOPPAJKDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6675A10", Offset = "0x6674E10", VA = "0x186675A10")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KKNBNJOIHDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KKNBNJOIHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6675BC0", Offset = "0x6674FC0", VA = "0x186675BC0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BAGCCEBLFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BAGCCEBLFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x666CA90", Offset = "0x666BE90", VA = "0x18666CA90")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ILGBIENBAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ILGBIENBAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6675B30", Offset = "0x6674F30", VA = "0x186675B30")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KPMDCCNIGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public KPMDCCNIGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6675C30", Offset = "0x6675030", VA = "0x186675C30")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GPNDHEGPEEB
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GPNDHEGPEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x66706E0", Offset = "0x666FAE0", VA = "0x1866706E0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6670680", Offset = "0x666FA80", VA = "0x186670680")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GADCGCJLPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GADCGCJLPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6670490", Offset = "0x666F890", VA = "0x186670490")]
		internal bool <ClearSliceIds>b__3(LACFKHJMNGC stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OLMPJGPDFGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OLMPJGPDFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6678860", Offset = "0x6677C60", VA = "0x186678860")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6678AE0", Offset = "0x6677EE0", VA = "0x186678AE0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66787F0", Offset = "0x6677BF0", VA = "0x1866787F0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly PGDMOFJPEIO CEGBOGDACGL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable KJIMGDEFNCD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DMCFMAHOAGP CJJBMKIHELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GPPOMFOJLGN EDBMKCEBJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LPMJLEAIFHF DPFHDGKIAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IPIMGJIMFLO HEPLEALFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JKMAHCLGMKC OIBLJOFLIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PGDMOFJPEIO PLKOGJFDFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool AJCOIBJBODA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan GGLAILMJPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan DBBAHGPKFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte AOOIMNIPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] ABHNGDMFDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<LACFKHJMNGC> CDALAKGCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BOBHDEJOJAK? DKDKJENOJJO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly DMCFMAHOAGP FFJMKJFCBHB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly DMCFMAHOAGP DNKALCFALMF;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<PLOGCBHLODG> DKCAFAGLMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6674750", Offset = "0x6673B50", VA = "0x186674750")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6672730", Offset = "0x6671B30", VA = "0x186672730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6675040", Offset = "0x6674440", VA = "0x186675040")]
	public HFKOONKIHDN(LPMJLEAIFHF DPFHDGKIAKC, IPIMGJIMFLO HEPLEALFCAC, JKMAHCLGMKC OIBLJOFLIFN, [Optional] TimeSpan? MOLDDNLHKEO, [Optional] PGDMOFJPEIO NLNJGIBDCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29F6780", Offset = "0x29F5B80", VA = "0x1829F6780")]
	public static HFKOONKIHDN EIHODGFAGLB<TNetworking>(TNetworking KEHCECCODAM, [Optional] TimeSpan? MOLDDNLHKEO, [Optional] PGDMOFJPEIO NLNJGIBDCLN) where TNetworking : LPMJLEAIFHF, IPIMGJIMFLO, JKMAHCLGMKC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66712B0", Offset = "0x66706B0", VA = "0x1866712B0")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66747F0", Offset = "0x6673BF0", VA = "0x1866747F0")]
	private byte OAKBGDEKEAL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6671AB0", Offset = "0x6670EB0", VA = "0x186671AB0")]
	private TimeSpan EAEDNDDBOEA(TimeSpan? MOLDDNLHKEO, int HINNEMMLEPO = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29F7120", Offset = "0x29F6520", VA = "0x1829F7120")]
	public bool ONIDLDAIKNM<T>(T ODIEBGIHLIG, Func<T, byte[]> BLNCBNBKOBM, bool IPBFLDBKNOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6674800", Offset = "0x6673C00", VA = "0x186674800")]
	public bool ONIDLDAIKNM(byte[] ODIEBGIHLIG, int MCMNCMEPACC, bool IPBFLDBKNOF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7532F0", Offset = "0x7526F0", VA = "0x1807532F0")]
	private static string JGNHCFBGKGB(string BALNMHDNCIN, string HAFGGBNGKBN = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6673710", Offset = "0x6672B10", VA = "0x186673710")]
	[AsyncStateMachine(typeof(ELMLBFBAIEA))]
	public Task<PLOGCBHLODG> JHGMGCJHABF(CancellationToken OIMNLGJCBEC, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, [Optional] TimeSpan? MOLDDNLHKEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66732C0", Offset = "0x66726C0", VA = "0x1866732C0")]
	[AsyncStateMachine(typeof(BJDBIKBBMJP))]
	public Task<Guid> IGMCEGNHLIF(Guid EJPHHGIHOJF, CancellationToken OIMNLGJCBEC, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, [Optional] TimeSpan? AOEGDFNBHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29F6400", Offset = "0x29F5800", VA = "0x1829F6400")]
	[AsyncStateMachine(typeof(EMKMNEIFNPD))]
	public Task<AELILFMFADF<T>> DBJBHDOHOIC<T>(T ODIEBGIHLIG, Func<T, byte[]> BLNCBNBKOBM, Func<byte[], T> DJJOGIGEKNG, CancellationToken OIMNLGJCBEC, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, [Optional] TimeSpan? AOEGDFNBHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6671920", Offset = "0x6670D20", VA = "0x186671920")]
	[AsyncStateMachine(typeof(DKIAINJMHKF))]
	public Task<PLOGCBHLODG> DBJBHDOHOIC(byte[] ODIEBGIHLIG, CancellationToken OIMNLGJCBEC, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, [Optional] TimeSpan? AOEGDFNBHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6673560", Offset = "0x6672960", VA = "0x186673560")]
	[AsyncStateMachine(typeof(BKANKCEONEF))]
	private Task<PLOGCBHLODG> JACILALKGLG(byte[] ODIEBGIHLIG, CancellationToken OIMNLGJCBEC, MNALPKGIDEG OCFHGOCHDGN, MNALPKGIDEG PPDNGMKCBFA, TimeSpan? MOLDDNLHKEO, Stopwatch NFCFGOBOLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6673C60", Offset = "0x6673060", VA = "0x186673C60")]
	[AsyncStateMachine(typeof(HIFAOIFKIBD))]
	private Task<PLOGCBHLODG> LOCEDILJGGN(byte[] ODIEBGIHLIG, CancellationToken OIMNLGJCBEC, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, [Optional] TimeSpan? AOEGDFNBHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6673890", Offset = "0x6672C90", VA = "0x186673890")]
	[AsyncStateMachine(typeof(NJNPPJDEFEL))]
	public Task KJHFDOEPKJI(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task> GCAEGAAGADF, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29F6820", Offset = "0x29F5C20", VA = "0x1829F6820")]
	[AsyncStateMachine(typeof(NLFMCPBHPOI))]
	public Task<T> KJHFDOEPKJI<T>(CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task<T>> GCAEGAAGADF, [Optional] MNALPKGIDEG OCFHGOCHDGN, [Optional] MNALPKGIDEG PPDNGMKCBFA, int BJDFDDMJLMG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29F6CD0", Offset = "0x29F60D0", VA = "0x1829F6CD0")]
	[AsyncStateMachine(typeof(PJJPAEEOGPM))]
	private Task<(bool, T)> NDICDGHOGHH<T>(Guid PJGICPOEFCK, CancellationToken OMMIOIOKBMF, Func<CancellationToken, Task<T>> GCAEGAAGADF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x66727D0", Offset = "0x6671BD0", VA = "0x1866727D0")]
	public void HACKCCDJEEE(byte AHOKOPLCFGL, int EJDEEFFNGFA, object HGAIHPAIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6673A00", Offset = "0x6672E00", VA = "0x186673A00")]
	public Guid LNICLNDDGLD(Guid GNNPEEOLHKL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x66713A0", Offset = "0x66707A0", VA = "0x1866713A0")]
	public bool CANMPGHJKLP(ELBNKGMODON LLHBJHACOFE, Guid PJGICPOEFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6670E00", Offset = "0x6670200", VA = "0x186670E00")]
	public void BAHBBFJBCBO(ELBNKGMODON LLHBJHACOFE, Guid PJGICPOEFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6671CF0", Offset = "0x66710F0", VA = "0x186671CF0")]
	private void EALDMEECNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6672620", Offset = "0x6671A20", VA = "0x186672620")]
	internal BOBHDEJOJAK GIEJJNEBCOE(bool FAHMHLCNALD = false)
	{
		return default(BOBHDEJOJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6674320", Offset = "0x6673720", VA = "0x186674320")]
	private HashSet<Guid> MHHMAPFIDPO(ELBNKGMODON LLHBJHACOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6672450", Offset = "0x6671850", VA = "0x186672450")]
	private void EKJNAEFKGLO(ELBNKGMODON LLHBJHACOFE, Guid PKNOIGMENLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6674460", Offset = "0x6673860", VA = "0x186674460")]
	private void MIGGCEJLOJH(ELBNKGMODON LLHBJHACOFE, Guid PKNOIGMENLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6671200", Offset = "0x6670600", VA = "0x186671200")]
	public static Func<Guid, bool> BAKFJMCECPH(Guid PKNOIGMENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6670D50", Offset = "0x6670150", VA = "0x186670D50")]
	public static Func<Guid, bool> AFDJOPCPCOF(Guid PKNOIGMENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6673450", Offset = "0x6672850", VA = "0x186673450")]
	public void IIKKLLELFKF(ELBNKGMODON LLHBJHACOFE, Guid PBPBFOEECGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6673DF0", Offset = "0x66731F0", VA = "0x186673DF0")]
	public void MGDGELEMADG(ELBNKGMODON LLHBJHACOFE, Func<Guid, bool> EEPGNBJEDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66731A0", Offset = "0x66725A0", VA = "0x1866731A0")]
	private static ExitGames.Client.Photon.Hashtable HKOFPJGMFOK(ELBNKGMODON LLHBJHACOFE, Guid LFNPAPAAPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6671D00", Offset = "0x6671100", VA = "0x186671D00")]
	private void EEMCGNKNIPN(ELBNKGMODON LLHBJHACOFE, Guid LFNPAPAAPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BCEMPKIHNCG : JEOABAKINBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(ADDOPBLDHDH.JDBLNOPBOBL itemType, long totalStopwatchTicks)> LHEFHBFEEGE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(ADDOPBLDHDH.JDBLNOPBOBL itemType, long totalStopwatchTicks)> MKMNABHBPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x765AF0", Offset = "0x764EF0", VA = "0x180765AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x666CB00", Offset = "0x666BF00", VA = "0x18666CB00")]
	public BCEMPKIHNCG(TimeSpan AOEGDFNBHBG, List<(ADDOPBLDHDH.JDBLNOPBOBL itemType, long totalStopwatchTicks)> LHEFHBFEEGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MEMNEFELOJK : POGILJNMLPD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct OLDKPLJEEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid JNGDHPMOGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int BPFCPAMAEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int GMFAMNDEHGF;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x66787E0", Offset = "0x6677BE0", VA = "0x1866787E0")]
		public OLDKPLJEEOP(Guid BJBFLDKHHJG, int PMALIFKLNJC, int PPKPDKDEHCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6678640", Offset = "0x6677A40", VA = "0x186678640")]
		public static byte[] HLHCEBOKDMG(OLDKPLJEEOP BALNMHDNCIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6678720", Offset = "0x6677B20", VA = "0x186678720")]
		public static OLDKPLJEEOP JDGCKOHAIDJ(byte[] EMIAMELGKNF)
		{
			return default(OLDKPLJEEOP);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6678510", Offset = "0x6677910", VA = "0x186678510")]
		private static byte[] DLHBHILBIKG(int FMPGMDDDGFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6678590", Offset = "0x6677990", VA = "0x186678590")]
		private static int HAONKHHPHPM(byte[] HAOKOIPDCAC, int EGNHJGKABLC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid BJBFLDKHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HFKOONKIHDN ALCCAOIDJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool OGEKDMEOBFD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x66766C0", Offset = "0x6675AC0", VA = "0x1866766C0")]
	public MEMNEFELOJK(Guid BJBFLDKHHJG, HFKOONKIHDN ALCCAOIDJBH, JKMAHCLGMKC KEHCECCODAM, CancellationToken OMMIOIOKBMF, [Optional] IHOHBINNKLG AEFJIADFGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6676350", Offset = "0x6675750", VA = "0x186676350", Slot = "5")]
	protected override void HALBKEPPGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6676520", Offset = "0x6675920", VA = "0x186676520", Slot = "6")]
	protected override void LLAAOKMKHAD(int PKIELNKCOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6676130", Offset = "0x6675530", VA = "0x186676130")]
	private void DKCAFAGLMLH(PLOGCBHLODG DOPJDLECMLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PLOGCBHLODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly BOBHDEJOJAK OGPOHNBNCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte JAACJIOACIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte LIOLLHDFLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool HMJGEKGHJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] EEFKAIKPIBN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x66790F0", Offset = "0x66784F0", VA = "0x1866790F0")]
	public PLOGCBHLODG(BOBHDEJOJAK IEDJDBIDMPA, [CanBeNull] byte[] GJNIFGAPEDN, bool IPBFLDBKNOF, byte NPPNIPPHKGO, byte CJJCLKMDJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6678F50", Offset = "0x6678350", VA = "0x186678F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6678D60", Offset = "0x6678160", VA = "0x186678D60")]
	private static void GLEDFFEFIKJ(byte[] GJNIFGAPEDN, StringBuilder IHDOPDPCKJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct BOBHDEJOJAK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LKNLMIPMBFO : IEnumerable<LACFKHJMNGC>, IEnumerable, IEnumerator<LACFKHJMNGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private LACFKHJMNGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BOBHDEJOJAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BOBHDEJOJAK <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ELBNKGMODON[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LACFKHJMNGC System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x258DB80", Offset = "0x258CF80", VA = "0x18258DB80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LACFKHJMNGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x66760E0", Offset = "0x66754E0", VA = "0x1866760E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x913060", Offset = "0x912460", VA = "0x180913060")]
		[DebuggerHidden]
		public LKNLMIPMBFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6675E10", Offset = "0x6675210", VA = "0x186675E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66760A0", Offset = "0x66754A0", VA = "0x1866760A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6676000", Offset = "0x6675400", VA = "0x186676000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LACFKHJMNGC> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6676000", Offset = "0x6675400", VA = "0x186676000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly ELBNKGMODON DCNOEAGEDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] EHKKIDCLCBM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x666E310", Offset = "0x666D710", VA = "0x18666E310")]
	public static BOBHDEJOJAK BCKNBEMBNGF(ELBNKGMODON LLHBJHACOFE, Guid DABOADCDJHM)
	{
		return default(BOBHDEJOJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x666E490", Offset = "0x666D890", VA = "0x18666E490")]
	public static BOBHDEJOJAK MOJJNIMCIKM(List<LACFKHJMNGC> BEJGHNJHJJK)
	{
		return default(BOBHDEJOJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x666E8B0", Offset = "0x666DCB0", VA = "0x18666E8B0")]
	public static BOBHDEJOJAK OKPOLHJCOHE(ELBNKGMODON FKMJIJHPFHE, Guid[] AGICLPEKACJ)
	{
		return default(BOBHDEJOJAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x666EE90", Offset = "0x666E290", VA = "0x18666EE90")]
	private BOBHDEJOJAK(ELBNKGMODON FKMJIJHPFHE, Guid[] AGICLPEKACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x666E410", Offset = "0x666D810", VA = "0x18666E410")]
	[IteratorStateMachine(typeof(LKNLMIPMBFO))]
	public IEnumerable<LACFKHJMNGC> MJHHCGBONLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x666ED10", Offset = "0x666E110", VA = "0x18666ED10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FGMFHGDMKOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2430D40", Offset = "0x2430140", VA = "0x182430D40", Slot = "4")]
	public void EGDLNKEAMLL(T BALNMHDNCIN, IDictionary<object, object> HIDEHJGLNHO, bool HCOJHFKPAKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void HPPGFLNFHCF(T BALNMHDNCIN, IDictionary<object, object> HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T JDGCKOHAIDJ(IDictionary<object, object> HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
	protected FGMFHGDMKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class POGILJNMLPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool IHOHBINNKLG(int OHBIMDCOAJC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly JKMAHCLGMKC HNNBFCJJNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken OMMIOIOKBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken PEKIDPMCGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly IHOHBINNKLG AEFJIADFGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource CFJBHLEMEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource FFBOJKLOAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int MPNJPFOMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HCNAJALEPFK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken OIAEJGCEOLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2800", Offset = "0x1AA1C00", VA = "0x181AA2800")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BEGMFDJNLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6679360", Offset = "0x6678760", VA = "0x186679360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66793B0", Offset = "0x66787B0", VA = "0x1866793B0")]
	public POGILJNMLPD(JKMAHCLGMKC KEHCECCODAM, CancellationToken OMMIOIOKBMF, [Optional] IHOHBINNKLG AEFJIADFGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x66791F0", Offset = "0x66785F0", VA = "0x1866791F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6679210", Offset = "0x6678610", VA = "0x186679210", Slot = "5")]
	protected virtual void HALBKEPPGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6679150", Offset = "0x6678550", VA = "0x186679150")]
	private void DOBECGKOMOJ(IEIHKFAAJEG EPIAGJNEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6679300", Offset = "0x6678700", VA = "0x186679300")]
	protected void MHPIFAKPMBH(int PKIELNKCOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x66792E0", Offset = "0x66786E0", VA = "0x1866792E0", Slot = "6")]
	protected virtual void LLAAOKMKHAD(int PKIELNKCOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LACFKHJMNGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly ELBNKGMODON KBFILIBCHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid KLCIHDLHOHO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D05880", Offset = "0x1D04C80", VA = "0x181D05880")]
	public LACFKHJMNGC(ELBNKGMODON LLHBJHACOFE, Guid PJGICPOEFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6675DB0", Offset = "0x66751B0", VA = "0x186675DB0")]
	public bool MDDDKCHCFCJ(LACFKHJMNGC MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6675CC0", Offset = "0x66750C0", VA = "0x186675CC0", Slot = "0")]
	public override bool Equals(object NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6675D80", Offset = "0x6675180", VA = "0x186675D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum ELBNKGMODON : byte
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
internal static class GMGIDHHOFNC
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly ELBNKGMODON[] BJBMIIPOBCA;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6670530", Offset = "0x666F930", VA = "0x186670530")]
	public static int AOCPJAMLJJH(ELBNKGMODON LLHBJHACOFE)
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
