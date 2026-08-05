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
internal class ALMLLBJNFNM : global::CBGNNHAEMGG<FIEFMIEDDKM>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MKLEDNAEFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public MKLEDNAEFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCEE0", Offset = "0x5BCBCE0", VA = "0x185BCCEE0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] BKOGCABHCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ALMLLBJNFNM EBMHMHOHCNI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BC22F0", Offset = "0x5BC10F0", VA = "0x185BC22F0", Slot = "5")]
	protected override void KEFNKJKCNMG(FIEFMIEDDKM HDKJDEIGPPL, IDictionary<object, object> JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BC2760", Offset = "0x5BC1560", VA = "0x185BC2760", Slot = "6")]
	public override FIEFMIEDDKM MNOLKCHHLIP(IDictionary<object, object> JLFCOOGLPMP)
	{
		return default(FIEFMIEDDKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BC34E0", Offset = "0x5BC22E0", VA = "0x185BC34E0")]
	public ALMLLBJNFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CMPGKADDOBE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string DCJHABAFCPM([NotNull] byte[] OICHLBNIOCE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct OCFHDOCKNJL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly FPNKEEMNBEJ MIGAFJIMLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool CJJBALJBBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T BJHNCDPLMNM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C860", Offset = "0x2F0B660", VA = "0x182F0C860")]
		public static OCFHDOCKNJL<T> LEMLCHFIANK(FIEFMIEDDKM PDGGOLEHLKF, Func<byte[], T> LEPEJKJFEJN)
		{
			return default(OCFHDOCKNJL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CBC0", Offset = "0x2F0B9C0", VA = "0x182F0CBC0")]
		public OCFHDOCKNJL(FPNKEEMNBEJ FEMJAMGPBCL, T OICHLBNIOCE, bool DOGOBHAEGCN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2F0CAE0", Offset = "0x2F0B8E0", VA = "0x182F0CAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KBJGCIGNNPG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HMCDNPJGKJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<FIEFMIEDDKM> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public KBJGCIGNNPG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public HMCDNPJGKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCBA90", Offset = "0x5BCA890", VA = "0x185BCBA90")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5BCBAE0", Offset = "0x5BCA8E0", VA = "0x185BCBAE0")]
			internal GGGJANLCFDL <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class OIDCEDGHFFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public JGHGIOFDGEK.GBOEJCDEBLF itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public OIDCEDGHFFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD060", Offset = "0x5BCBE60", VA = "0x185BCD060")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct AFMJPHIOGCM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<FIEFMIEDDKM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KBJGCIGNNPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private HMCDNPJGKJA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<FIEFMIEDDKM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5BC1720", Offset = "0x5BC0520", VA = "0x185BC1720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5BC1F30", Offset = "0x5BC0D30", VA = "0x185BC1F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CKDCEHBGDGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public OAPNNFFKIMG sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public CKDCEHBGDGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4AD0", Offset = "0x5BC38D0", VA = "0x185BC4AD0")]
			internal bool <ClearSlice>b__0(FIEFMIEDDKM bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BNJFENEMBMH LOGPAODPCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string HJEIFDKNDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<FIEFMIEDDKM> KDGJBMIPMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(JGHGIOFDGEK.GBOEJCDEBLF itemType, long totalStopwatchTicks)> GFODDGOPFKI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PLNEDAECJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC230", Offset = "0x5BCB030", VA = "0x185BCC230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<FIEFMIEDDKM> MFEJJMOMDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC5F0", Offset = "0x5BCB3F0", VA = "0x185BCC5F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC420", Offset = "0x5BCB220", VA = "0x185BCC420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC690", Offset = "0x5BCB490", VA = "0x185BCC690")]
		public KBJGCIGNNPG(BNJFENEMBMH LOGPAODPCFL, string HJEIFDKNDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC2D0", Offset = "0x5BCB0D0", VA = "0x185BCC2D0")]
		[AsyncStateMachine(typeof(AFMJPHIOGCM))]
		public Task<FIEFMIEDDKM> EHAHCBOJHOI(CancellationToken ADCKNELPFOJ, TimeSpan JIIJLIALNIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC180", Offset = "0x5BCAF80", VA = "0x185BCC180")]
		public void DEGALJDBKAJ(FIEFMIEDDKM HDKJDEIGPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC280", Offset = "0x5BCB080", VA = "0x185BCC280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC4C0", Offset = "0x5BCB2C0", VA = "0x185BCC4C0")]
		public void KOOGLKMBMLP(OAPNNFFKIMG FHIMJOACDLI, Guid GLGEGPNMJGF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PLHIAJGBAEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<FIEFMIEDDKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JLMDOPEJOBO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD740", Offset = "0x5BCC540", VA = "0x185BCD740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE060", Offset = "0x5BCCE60", VA = "0x185BCE060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LALJJIHOJNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JLMDOPEJOBO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<OCFHDOCKNJL<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC790", Offset = "0x5BCB590", VA = "0x185BCC790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCB40", Offset = "0x5BCB940", VA = "0x185BCCB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CKKEFGHNKAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<FIEFMIEDDKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JLMDOPEJOBO pauseAfterListeningToken;

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
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4C40", Offset = "0x5BC3A40", VA = "0x185BC4C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5540", Offset = "0x5BC4340", VA = "0x185BC5540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class AMGGGPGBCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public AMGGGPGBCKO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BLFKNMHPNMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<FIEFMIEDDKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private AMGGGPGBCKO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JLMDOPEJOBO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private BMDFDHDDIKA <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3940", Offset = "0x5BC2740", VA = "0x185BC3940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5BC43E0", Offset = "0x5BC31E0", VA = "0x185BC43E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FIDKAOKOMMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<FIEFMIEDDKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JLMDOPEJOBO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<FIEFMIEDDKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA2F0", Offset = "0x5BC90F0", VA = "0x185BCA2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA6D0", Offset = "0x5BC94D0", VA = "0x185BCA6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GOGGHGPBCHC
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
			public GOGGHGPBCHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE0B0", Offset = "0x5BCCEB0", VA = "0x185BCE0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE220", Offset = "0x5BCD020", VA = "0x185BCE220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GOGGHGPBCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB950", Offset = "0x5BCA750", VA = "0x185BCB950")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LFDGOJCHJLN : IAsyncStateMachine
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
		public CMPGKADDOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JLMDOPEJOBO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JLMDOPEJOBO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCB90", Offset = "0x5BCB990", VA = "0x185BCCB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BGNDFNBHBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BGNDFNBHBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5BC38A0", Offset = "0x5BC26A0", VA = "0x185BC38A0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3850", Offset = "0x5BC2650", VA = "0x185BC3850")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BMHOFPOJJHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OAPNNFFKIMG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BMHOFPOJJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4860", Offset = "0x5BC3660", VA = "0x185BC4860")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OOBCJHNDBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public OAPNNFFKIMG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OOBCJHNDBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD6A0", Offset = "0x5BCC4A0", VA = "0x185BCD6A0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LFOKFJHFEEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LFOKFJHFEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCDD0", Offset = "0x5BCBBD0", VA = "0x185BCCDD0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BCMNFEDMIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BCMNFEDMIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5BC37E0", Offset = "0x5BC25E0", VA = "0x185BC37E0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AJEHBPHMBLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public AJEHBPHMBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5BC1F80", Offset = "0x5BC0D80", VA = "0x185BC1F80")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ELPENFDGDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ELPENFDGDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA260", Offset = "0x5BC9060", VA = "0x185BCA260")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OGHPNFNJEHM
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OGHPNFNJEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD000", Offset = "0x5BCBE00", VA = "0x185BCD000")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCFA0", Offset = "0x5BCBDA0", VA = "0x185BCCFA0")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LIJPNKABEOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public LIJPNKABEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCCE40", Offset = "0x5BCBC40", VA = "0x185BCCE40")]
		internal bool <ClearSliceIds>b__3(CIBDPJGBDLI stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OMKLHFMCOBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public OMKLHFMCOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD1A0", Offset = "0x5BCBFA0", VA = "0x185BCD1A0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD420", Offset = "0x5BCC220", VA = "0x185BCD420")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD130", Offset = "0x5BCBF30", VA = "0x185BCD130")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DCJHABAFCPM JHPDIBGLOFC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable MOJOMMOLBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GCHBHNIMADI GGOJOIEDIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KBJGCIGNNPG OPKEIGBBCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BNJFENEMBMH LOGPAODPCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CPDOJLCJIOI NMHHIPKHEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CIDKPIOBPBN NNLGOLMNMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DCJHABAFCPM OODCDJFGMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan KHKODKJLLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan MLAJMHJPEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte AKKPNAMNDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] CELGDOJOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<CIBDPJGBDLI> OCPFIEIIGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FPNKEEMNBEJ? BIMOAHHFCLD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly GCHBHNIMADI PFHJEMNLPDA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly GCHBHNIMADI NIKOOOIJCBG;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<FIEFMIEDDKM> LELDPEBICHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BC94E0", Offset = "0x5BC82E0", VA = "0x185BC94E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BC9350", Offset = "0x5BC8150", VA = "0x185BC9350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BC97C0", Offset = "0x5BC85C0", VA = "0x185BC97C0")]
	public CMPGKADDOBE(BNJFENEMBMH LOGPAODPCFL, CPDOJLCJIOI NMHHIPKHEJF, CIDKPIOBPBN NNLGOLMNMIC, [Optional] TimeSpan? CMCPDFOEPFE, [Optional] DCJHABAFCPM CCOFOCDJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2729920", Offset = "0x2728720", VA = "0x182729920")]
	public static CMPGKADDOBE JMDIOAOJGKB<TNetworking>(TNetworking IJNIKOCLGEN, [Optional] TimeSpan? CMCPDFOEPFE, [Optional] DCJHABAFCPM CCOFOCDJGMJ) where TNetworking : BNJFENEMBMH, CPDOJLCJIOI, CIDKPIOBPBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC93F0", Offset = "0x5BC81F0", VA = "0x185BC93F0")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC75A0", Offset = "0x5BC63A0", VA = "0x185BC75A0")]
	private byte KFAPGANHBHH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC9110", Offset = "0x5BC7F10", VA = "0x185BC9110")]
	private TimeSpan NPCIMHEIPMD(TimeSpan? CMCPDFOEPFE, int NNOKDBDMOMA = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27294F0", Offset = "0x27282F0", VA = "0x1827294F0")]
	public bool CKLPOGOEICC<T>(T LFAHOKPKPMI, Func<T, byte[]> HCCBCGGLKDB, bool DOGOBHAEGCN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5960", Offset = "0x5BC4760", VA = "0x185BC5960")]
	public bool CKLPOGOEICC(byte[] LFAHOKPKPMI, int HBHMCMAGLGD, bool DOGOBHAEGCN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0")]
	private static string AFIBKPDCJBM(string HDKJDEIGPPL, string OJAMOJPMLEB = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5640", Offset = "0x5BC4440", VA = "0x185BC5640")]
	[AsyncStateMachine(typeof(PLHIAJGBAEL))]
	public Task<FIEFMIEDDKM> BFMJLAPJCMD(CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? CMCPDFOEPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6060", Offset = "0x5BC4E60", VA = "0x185BC6060")]
	[AsyncStateMachine(typeof(LALJJIHOJNF))]
	public Task<Guid> ECALKJAEIMP(Guid OPOINLLIBDD, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2729760", Offset = "0x2728560", VA = "0x182729760")]
	[AsyncStateMachine(typeof(EIPPJFJHABC))]
	public Task<OCFHDOCKNJL<T>> EFFLIBFOLFD<T>(T LFAHOKPKPMI, Func<T, byte[]> HCCBCGGLKDB, Func<byte[], T> LEPEJKJFEJN, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BC61F0", Offset = "0x5BC4FF0", VA = "0x185BC61F0")]
	[AsyncStateMachine(typeof(CKKEFGHNKAH))]
	public Task<FIEFMIEDDKM> EFFLIBFOLFD(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7880", Offset = "0x5BC6680", VA = "0x185BC7880")]
	[AsyncStateMachine(typeof(BLFKNMHPNMO))]
	private Task<FIEFMIEDDKM> KPGMIIELIKN(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, JLMDOPEJOBO LPIEPICCINO, JLMDOPEJOBO GOOILKFCIKF, TimeSpan? CMCPDFOEPFE, Stopwatch FAJMHDLNOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BC57C0", Offset = "0x5BC45C0", VA = "0x185BC57C0")]
	[AsyncStateMachine(typeof(FIDKAOKOMMA))]
	private Task<FIEFMIEDDKM> BHFBGGFHDLE(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8160", Offset = "0x5BC6F60", VA = "0x185BC8160")]
	[AsyncStateMachine(typeof(LFDGOJCHJLN))]
	public Task MDHFGPILAKH(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task> PCKLOEHLHEN, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27299C0", Offset = "0x27287C0", VA = "0x1827299C0")]
	[AsyncStateMachine(typeof(INGPCBDGADL))]
	public Task<T> MDHFGPILAKH<T>(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task<T>> PCKLOEHLHEN, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2729E70", Offset = "0x2728C70", VA = "0x182729E70")]
	[AsyncStateMachine(typeof(BDLFPMAINGJ))]
	private Task<(bool, T)> NPADKLINICL<T>(Guid GFFJOACFPGE, CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task<T>> PCKLOEHLHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8520", Offset = "0x5BC7320", VA = "0x185BC8520")]
	public void MPLONKHBBBD(byte CKEICLLNJFC, int CEHFGPABGFL, object MFPJPJDDOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8EB0", Offset = "0x5BC7CB0", VA = "0x185BC8EB0")]
	public Guid NJFKHMPEIMI(Guid NENKANHPGFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6D40", Offset = "0x5BC5B40", VA = "0x185BC6D40")]
	public bool ILIFCBOIPOD(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BC68A0", Offset = "0x5BC56A0", VA = "0x185BC68A0")]
	public void HMLKBDKNFIK(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5950", Offset = "0x5BC4750", VA = "0x185BC5950")]
	private void CKLJELOCBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5BC8410", Offset = "0x5BC7210", VA = "0x185BC8410")]
	internal FPNKEEMNBEJ MEHKPDKFOAE(bool IAEPMKLPONN = false)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5BC82D0", Offset = "0x5BC70D0", VA = "0x185BC82D0")]
	private HashSet<Guid> MEFKFCDHONP(OAPNNFFKIMG FHIMJOACDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5BC75B0", Offset = "0x5BC63B0", VA = "0x185BC75B0")]
	private void KNCGAMHFDCI(OAPNNFFKIMG FHIMJOACDLI, Guid GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BC72C0", Offset = "0x5BC60C0", VA = "0x185BC72C0")]
	private void JFGKANEAGHD(OAPNNFFKIMG FHIMJOACDLI, Guid GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6C90", Offset = "0x5BC5A90", VA = "0x185BC6C90")]
	public static Func<Guid, bool> HNIPBGMHGNE(Guid GLGEGPNMJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5590", Offset = "0x5BC4390", VA = "0x185BC5590")]
	public static Func<Guid, bool> BBCKMOKKMKJ(Guid GLGEGPNMJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7770", Offset = "0x5BC6570", VA = "0x185BC7770")]
	public void KOOGLKMBMLP(OAPNNFFKIMG FHIMJOACDLI, Guid AHMJOHFIKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BC6380", Offset = "0x5BC5180", VA = "0x185BC6380")]
	public void FKAAOPCIFCB(OAPNNFFKIMG FHIMJOACDLI, Func<Guid, bool> PMHAKMCGLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BC5F40", Offset = "0x5BC4D40", VA = "0x185BC5F40")]
	private static ExitGames.Client.Photon.Hashtable DMNHANOBFMM(OAPNNFFKIMG FHIMJOACDLI, Guid DKCPOEJLOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BC7A30", Offset = "0x5BC6830", VA = "0x185BC7A30")]
	private void LIKGEFIKGJC(OAPNNFFKIMG FHIMJOACDLI, Guid DKCPOEJLOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GGGJANLCFDL : IGECHFFMGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(JGHGIOFDGEK.GBOEJCDEBLF itemType, long totalStopwatchTicks)> HDFNDFJPBPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(JGHGIOFDGEK.GBOEJCDEBLF itemType, long totalStopwatchTicks)> JBODOHJHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF0", Offset = "0x6F38F0", VA = "0x1806F4AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB8D0", Offset = "0x5BCA6D0", VA = "0x185BCB8D0")]
	public GGGJANLCFDL(TimeSpan JIIJLIALNIC, List<(JGHGIOFDGEK.GBOEJCDEBLF itemType, long totalStopwatchTicks)> HDFNDFJPBPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EAPGPEOCLGH : BMDFDHDDIKA
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct AKNHHEPEIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid LDEAJHDIANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int HKMILKOIMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int AOLKMDPILGE;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5BC22E0", Offset = "0x5BC10E0", VA = "0x185BC22E0")]
		public AKNHHEPEIEH(Guid IODELCJGMCF, int NGKBGCBCFOA, int MGKCCPJBJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2010", Offset = "0x5BC0E10", VA = "0x185BC2010")]
		public static byte[] CLPGJOCDFOA(AKNHHEPEIEH HDKJDEIGPPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5BC21A0", Offset = "0x5BC0FA0", VA = "0x185BC21A0")]
		public static AKNHHEPEIEH MNOLKCHHLIP(byte[] EHAMCGPFFID)
		{
			return default(AKNHHEPEIEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2260", Offset = "0x5BC1060", VA = "0x185BC2260")]
		private static byte[] PCGDHONDAND(int OJFFKHAMPMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5BC20F0", Offset = "0x5BC0EF0", VA = "0x185BC20F0")]
		private static int KHPNNMBJEFH(byte[] KLMJEPBJOCI, int BNNEENLPEFO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid IODELCJGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CMPGKADDOBE FIAGILNCDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool IHKBMJKACPH;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5BCA200", Offset = "0x5BC9000", VA = "0x185BCA200")]
	public EAPGPEOCLGH(Guid IODELCJGMCF, CMPGKADDOBE FIAGILNCDCH, CIDKPIOBPBN IJNIKOCLGEN, CancellationToken LAKDHEPMDKO, [Optional] CCDKJEBHOEJ LAEAPABKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5BCA030", Offset = "0x5BC8E30", VA = "0x185BCA030", Slot = "5")]
	protected override void PHAPLBBFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5BC9C70", Offset = "0x5BC8A70", VA = "0x185BC9C70", Slot = "6")]
	protected override void EAAFFOJFHLJ(int LPKMJJAAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5BC9E10", Offset = "0x5BC8C10", VA = "0x185BC9E10")]
	private void LELDPEBICHD(FIEFMIEDDKM EPIADKILJOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct FIEFMIEDDKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly FPNKEEMNBEJ MIGAFJIMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte KJIHLDIONGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte PNGEFHKDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool CJJBALJBBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] BJHNCDPLMNM;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5BCAAB0", Offset = "0x5BC98B0", VA = "0x185BCAAB0")]
	public FIEFMIEDDKM(FPNKEEMNBEJ FEMJAMGPBCL, [CanBeNull] byte[] OICHLBNIOCE, bool DOGOBHAEGCN, byte HCNGNBJJCGB, byte AELGEGFPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5BCA910", Offset = "0x5BC9710", VA = "0x185BCA910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5BCA720", Offset = "0x5BC9520", VA = "0x185BCA720")]
	private static void NDHLOBNMKKO(byte[] OICHLBNIOCE, StringBuilder HBILMDLCHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct FPNKEEMNBEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IMAFKJMFCAI : IEnumerable<CIBDPJGBDLI>, IEnumerable, IEnumerator<CIBDPJGBDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private CIBDPJGBDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FPNKEEMNBEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public FPNKEEMNBEJ <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private OAPNNFFKIMG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CIBDPJGBDLI System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3165CC0", Offset = "0x3164AC0", VA = "0x183165CC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CIBDPJGBDLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCC130", Offset = "0x5BCAF30", VA = "0x185BCC130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6CF620", Offset = "0x6CE420", VA = "0x1806CF620")]
		[DebuggerHidden]
		public IMAFKJMFCAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BCBE60", Offset = "0x5BCAC60", VA = "0x185BCBE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC0F0", Offset = "0x5BCAEF0", VA = "0x185BCC0F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC050", Offset = "0x5BCAE50", VA = "0x185BCC050", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CIBDPJGBDLI> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC050", Offset = "0x5BCAE50", VA = "0x185BCC050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly OAPNNFFKIMG IIEAGNLACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] JEHANFDFDLD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB410", Offset = "0x5BCA210", VA = "0x185BCB410")]
	public static FPNKEEMNBEJ MKILNPJHFPG(OAPNNFFKIMG FHIMJOACDLI, Guid OPGIIAOPEOO)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5BCAB90", Offset = "0x5BC9990", VA = "0x185BCAB90")]
	public static FPNKEEMNBEJ DKDOMPGHJMA(List<CIBDPJGBDLI> LMOIPKGOGEA)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5BCAFB0", Offset = "0x5BC9DB0", VA = "0x185BCAFB0")]
	public static FPNKEEMNBEJ JGFAMDBLNCD(OAPNNFFKIMG FIJKGADOAAF, Guid[] AMOEECIKAON)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB690", Offset = "0x5BCA490", VA = "0x185BCB690")]
	private FPNKEEMNBEJ(OAPNNFFKIMG FIJKGADOAAF, Guid[] AMOEECIKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5BCAB10", Offset = "0x5BC9910", VA = "0x185BCAB10")]
	[IteratorStateMachine(typeof(IMAFKJMFCAI))]
	public IEnumerable<CIBDPJGBDLI> CEPCJEDAMOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5BCB510", Offset = "0x5BCA310", VA = "0x185BCB510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CBGNNHAEMGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x413DAC0", Offset = "0x413C8C0", VA = "0x18413DAC0", Slot = "4")]
	public void KOEPLBPAMIG(T HDKJDEIGPPL, IDictionary<object, object> JLFCOOGLPMP, bool KABLIADLAKB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KEFNKJKCNMG(T HDKJDEIGPPL, IDictionary<object, object> JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T MNOLKCHHLIP(IDictionary<object, object> JLFCOOGLPMP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected CBGNNHAEMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BMDFDHDDIKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool CCDKJEBHOEJ(int GHPPCOHJCAI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly CIDKPIOBPBN NHHOPOBPKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken LAKDHEPMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken FNLKPAONKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly CCDKJEBHOEJ LAEAPABKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource KLBFAODLFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource BHIEHIMENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int NDNJPABCJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool LEOBGFALEBB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken DBKCDMPJCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4480", Offset = "0x5BC3280", VA = "0x185BC4480")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCEEELNBJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4430", Offset = "0x5BC3230", VA = "0x185BC4430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5BC46B0", Offset = "0x5BC34B0", VA = "0x185BC46B0")]
	public BMDFDHDDIKA(CIDKPIOBPBN IJNIKOCLGEN, CancellationToken LAKDHEPMDKO, [Optional] CCDKJEBHOEJ LAEAPABKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5BC44A0", Offset = "0x5BC32A0", VA = "0x185BC44A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5BC45E0", Offset = "0x5BC33E0", VA = "0x185BC45E0", Slot = "5")]
	protected virtual void PHAPLBBFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5BC44E0", Offset = "0x5BC32E0", VA = "0x185BC44E0")]
	private void GHBHGLJMHCL(HHODDDLIHOO JIHDDJNMGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4580", Offset = "0x5BC3380", VA = "0x185BC4580")]
	protected void OGBOLPIGKMP(int LPKMJJAAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5BC44C0", Offset = "0x5BC32C0", VA = "0x185BC44C0", Slot = "6")]
	protected virtual void EAAFFOJFHLJ(int LPKMJJAAOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct CIBDPJGBDLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly OAPNNFFKIMG KGAPBKAIIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid JMJFACLJOHM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4945360", Offset = "0x4944160", VA = "0x184945360")]
	public CIBDPJGBDLI(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4A70", Offset = "0x5BC3870", VA = "0x185BC4A70")]
	public bool OKMKGFFNCCL(CIBDPJGBDLI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4980", Offset = "0x5BC3780", VA = "0x185BC4980", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5BC4A40", Offset = "0x5BC3840", VA = "0x185BC4A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum OAPNNFFKIMG : byte
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
internal static class AMJOIHNHEDP
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly OAPNNFFKIMG[] DAKKKALPEFI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5BC3690", Offset = "0x5BC2490", VA = "0x185BC3690")]
	public static int BBFMIFIFIED(OAPNNFFKIMG FHIMJOACDLI)
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
