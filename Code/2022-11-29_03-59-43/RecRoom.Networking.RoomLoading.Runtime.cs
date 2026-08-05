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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public MKLEDNAEFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5E30", Offset = "0x5DB4A30", VA = "0x185DB5E30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DAB240", Offset = "0x5DA9E40", VA = "0x185DAB240", Slot = "5")]
	protected override void KEFNKJKCNMG(FIEFMIEDDKM HDKJDEIGPPL, IDictionary<object, object> JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB6B0", Offset = "0x5DAA2B0", VA = "0x185DAB6B0", Slot = "6")]
	public override FIEFMIEDDKM MNOLKCHHLIP(IDictionary<object, object> JLFCOOGLPMP)
	{
		return default(FIEFMIEDDKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC430", Offset = "0x5DAB030", VA = "0x185DAC430")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E0F10", Offset = "0x27DFB10", VA = "0x1827E0F10")]
		public static OCFHDOCKNJL<T> LEMLCHFIANK(FIEFMIEDDKM PDGGOLEHLKF, Func<byte[], T> LEPEJKJFEJN)
		{
			return default(OCFHDOCKNJL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27E1270", Offset = "0x27DFE70", VA = "0x1827E1270")]
		public OCFHDOCKNJL(FPNKEEMNBEJ FEMJAMGPBCL, T OICHLBNIOCE, bool DOGOBHAEGCN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x27E1190", Offset = "0x27DFD90", VA = "0x1827E1190", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public HMCDNPJGKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB49E0", Offset = "0x5DB35E0", VA = "0x185DB49E0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB4A30", Offset = "0x5DB3630", VA = "0x185DB4A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public OIDCEDGHFFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5FB0", Offset = "0x5DB4BB0", VA = "0x185DB5FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DAA670", Offset = "0x5DA9270", VA = "0x185DAA670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5DAAE80", Offset = "0x5DA9A80", VA = "0x185DAAE80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public CKDCEHBGDGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5DADA20", Offset = "0x5DAC620", VA = "0x185DADA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB5180", Offset = "0x5DB3D80", VA = "0x185DB5180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<FIEFMIEDDKM> MFEJJMOMDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5540", Offset = "0x5DB4140", VA = "0x185DB5540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5370", Offset = "0x5DB3F70", VA = "0x185DB5370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DB55E0", Offset = "0x5DB41E0", VA = "0x185DB55E0")]
		public KBJGCIGNNPG(BNJFENEMBMH LOGPAODPCFL, string HJEIFDKNDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5220", Offset = "0x5DB3E20", VA = "0x185DB5220")]
		[AsyncStateMachine(typeof(AFMJPHIOGCM))]
		public Task<FIEFMIEDDKM> EHAHCBOJHOI(CancellationToken ADCKNELPFOJ, TimeSpan JIIJLIALNIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DB50D0", Offset = "0x5DB3CD0", VA = "0x185DB50D0")]
		public void DEGALJDBKAJ(FIEFMIEDDKM HDKJDEIGPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5DB51D0", Offset = "0x5DB3DD0", VA = "0x185DB51D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5410", Offset = "0x5DB4010", VA = "0x185DB5410")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB6690", Offset = "0x5DB5290", VA = "0x185DB6690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6FB0", Offset = "0x5DB5BB0", VA = "0x185DB6FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB56E0", Offset = "0x5DB42E0", VA = "0x185DB56E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5A90", Offset = "0x5DB4690", VA = "0x185DB5A90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DADB90", Offset = "0x5DAC790", VA = "0x185DADB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE490", Offset = "0x5DAD090", VA = "0x185DAE490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DAC890", Offset = "0x5DAB490", VA = "0x185DAC890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD330", Offset = "0x5DABF30", VA = "0x185DAD330", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB3240", Offset = "0x5DB1E40", VA = "0x185DB3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3620", Offset = "0x5DB2220", VA = "0x185DB3620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB7000", Offset = "0x5DB5C00", VA = "0x185DB7000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7170", Offset = "0x5DB5D70", VA = "0x185DB7170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GOGGHGPBCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DB48A0", Offset = "0x5DB34A0", VA = "0x185DB48A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB5AE0", Offset = "0x5DB46E0", VA = "0x185DB5AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BGNDFNBHBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7F0", Offset = "0x5DAB3F0", VA = "0x185DAC7F0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC7A0", Offset = "0x5DAB3A0", VA = "0x185DAC7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BMHOFPOJJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD7B0", Offset = "0x5DAC3B0", VA = "0x185DAD7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OOBCJHNDBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB65F0", Offset = "0x5DB51F0", VA = "0x185DB65F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LFOKFJHFEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5D20", Offset = "0x5DB4920", VA = "0x185DB5D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BCMNFEDMIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC730", Offset = "0x5DAB330", VA = "0x185DAC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public AJEHBPHMBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAED0", Offset = "0x5DA9AD0", VA = "0x185DAAED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ELPENFDGDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5DB31B0", Offset = "0x5DB1DB0", VA = "0x185DB31B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OGHPNFNJEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5F50", Offset = "0x5DB4B50", VA = "0x185DB5F50")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5EF0", Offset = "0x5DB4AF0", VA = "0x185DB5EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public LIJPNKABEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5D90", Offset = "0x5DB4990", VA = "0x185DB5D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public OMKLHFMCOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB60F0", Offset = "0x5DB4CF0", VA = "0x185DB60F0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6370", Offset = "0x5DB4F70", VA = "0x185DB6370")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6080", Offset = "0x5DB4C80", VA = "0x185DB6080")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB2430", Offset = "0x5DB1030", VA = "0x185DB2430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB22A0", Offset = "0x5DB0EA0", VA = "0x185DB22A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2710", Offset = "0x5DB1310", VA = "0x185DB2710")]
	public CMPGKADDOBE(BNJFENEMBMH LOGPAODPCFL, CPDOJLCJIOI NMHHIPKHEJF, CIDKPIOBPBN NNLGOLMNMIC, [Optional] TimeSpan? CMCPDFOEPFE, [Optional] DCJHABAFCPM CCOFOCDJGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22A0E40", Offset = "0x229FA40", VA = "0x1822A0E40")]
	public static CMPGKADDOBE JMDIOAOJGKB<TNetworking>(TNetworking IJNIKOCLGEN, [Optional] TimeSpan? CMCPDFOEPFE, [Optional] DCJHABAFCPM CCOFOCDJGMJ) where TNetworking : BNJFENEMBMH, CPDOJLCJIOI, CIDKPIOBPBN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2340", Offset = "0x5DB0F40", VA = "0x185DB2340")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB04F0", Offset = "0x5DAF0F0", VA = "0x185DB04F0")]
	private byte KFAPGANHBHH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2060", Offset = "0x5DB0C60", VA = "0x185DB2060")]
	private TimeSpan NPCIMHEIPMD(TimeSpan? CMCPDFOEPFE, int NNOKDBDMOMA = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22A0A10", Offset = "0x229F610", VA = "0x1822A0A10")]
	public bool CKLPOGOEICC<T>(T LFAHOKPKPMI, Func<T, byte[]> HCCBCGGLKDB, bool DOGOBHAEGCN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8B0", Offset = "0x5DAD4B0", VA = "0x185DAE8B0")]
	public bool CKLPOGOEICC(byte[] LFAHOKPKPMI, int HBHMCMAGLGD, bool DOGOBHAEGCN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500")]
	private static string AFIBKPDCJBM(string HDKJDEIGPPL, string OJAMOJPMLEB = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE590", Offset = "0x5DAD190", VA = "0x185DAE590")]
	[AsyncStateMachine(typeof(PLHIAJGBAEL))]
	public Task<FIEFMIEDDKM> BFMJLAPJCMD(CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? CMCPDFOEPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEFB0", Offset = "0x5DADBB0", VA = "0x185DAEFB0")]
	[AsyncStateMachine(typeof(LALJJIHOJNF))]
	public Task<Guid> ECALKJAEIMP(Guid OPOINLLIBDD, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22A0C80", Offset = "0x229F880", VA = "0x1822A0C80")]
	[AsyncStateMachine(typeof(EIPPJFJHABC))]
	public Task<OCFHDOCKNJL<T>> EFFLIBFOLFD<T>(T LFAHOKPKPMI, Func<T, byte[]> HCCBCGGLKDB, Func<byte[], T> LEPEJKJFEJN, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF140", Offset = "0x5DADD40", VA = "0x185DAF140")]
	[AsyncStateMachine(typeof(CKKEFGHNKAH))]
	public Task<FIEFMIEDDKM> EFFLIBFOLFD(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DB07D0", Offset = "0x5DAF3D0", VA = "0x185DB07D0")]
	[AsyncStateMachine(typeof(BLFKNMHPNMO))]
	private Task<FIEFMIEDDKM> KPGMIIELIKN(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, JLMDOPEJOBO LPIEPICCINO, JLMDOPEJOBO GOOILKFCIKF, TimeSpan? CMCPDFOEPFE, Stopwatch FAJMHDLNOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE710", Offset = "0x5DAD310", VA = "0x185DAE710")]
	[AsyncStateMachine(typeof(FIDKAOKOMMA))]
	private Task<FIEFMIEDDKM> BHFBGGFHDLE(byte[] LFAHOKPKPMI, CancellationToken ADCKNELPFOJ, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, [Optional] TimeSpan? JIIJLIALNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DB10B0", Offset = "0x5DAFCB0", VA = "0x185DB10B0")]
	[AsyncStateMachine(typeof(LFDGOJCHJLN))]
	public Task MDHFGPILAKH(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task> PCKLOEHLHEN, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22A0EE0", Offset = "0x229FAE0", VA = "0x1822A0EE0")]
	[AsyncStateMachine(typeof(INGPCBDGADL))]
	public Task<T> MDHFGPILAKH<T>(CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task<T>> PCKLOEHLHEN, [Optional] JLMDOPEJOBO LPIEPICCINO, [Optional] JLMDOPEJOBO GOOILKFCIKF, int MPBLPLKDHHE = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22A1390", Offset = "0x229FF90", VA = "0x1822A1390")]
	[AsyncStateMachine(typeof(BDLFPMAINGJ))]
	private Task<(bool, T)> NPADKLINICL<T>(Guid GFFJOACFPGE, CancellationToken LAKDHEPMDKO, Func<CancellationToken, Task<T>> PCKLOEHLHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1470", Offset = "0x5DB0070", VA = "0x185DB1470")]
	public void MPLONKHBBBD(byte CKEICLLNJFC, int CEHFGPABGFL, object MFPJPJDDOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1E00", Offset = "0x5DB0A00", VA = "0x185DB1E00")]
	public Guid NJFKHMPEIMI(Guid NENKANHPGFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFC90", Offset = "0x5DAE890", VA = "0x185DAFC90")]
	public bool ILIFCBOIPOD(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF7F0", Offset = "0x5DAE3F0", VA = "0x185DAF7F0")]
	public void HMLKBDKNFIK(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8A0", Offset = "0x5DAD4A0", VA = "0x185DAE8A0")]
	private void CKLJELOCBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1360", Offset = "0x5DAFF60", VA = "0x185DB1360")]
	internal FPNKEEMNBEJ MEHKPDKFOAE(bool IAEPMKLPONN = false)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1220", Offset = "0x5DAFE20", VA = "0x185DB1220")]
	private HashSet<Guid> MEFKFCDHONP(OAPNNFFKIMG FHIMJOACDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0500", Offset = "0x5DAF100", VA = "0x185DB0500")]
	private void KNCGAMHFDCI(OAPNNFFKIMG FHIMJOACDLI, Guid GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0210", Offset = "0x5DAEE10", VA = "0x185DB0210")]
	private void JFGKANEAGHD(OAPNNFFKIMG FHIMJOACDLI, Guid GLGEGPNMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFBE0", Offset = "0x5DAE7E0", VA = "0x185DAFBE0")]
	public static Func<Guid, bool> HNIPBGMHGNE(Guid GLGEGPNMJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE4E0", Offset = "0x5DAD0E0", VA = "0x185DAE4E0")]
	public static Func<Guid, bool> BBCKMOKKMKJ(Guid GLGEGPNMJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DB06C0", Offset = "0x5DAF2C0", VA = "0x185DB06C0")]
	public void KOOGLKMBMLP(OAPNNFFKIMG FHIMJOACDLI, Guid AHMJOHFIKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF2D0", Offset = "0x5DADED0", VA = "0x185DAF2D0")]
	public void FKAAOPCIFCB(OAPNNFFKIMG FHIMJOACDLI, Func<Guid, bool> PMHAKMCGLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEE90", Offset = "0x5DADA90", VA = "0x185DAEE90")]
	private static ExitGames.Client.Photon.Hashtable DMNHANOBFMM(OAPNNFFKIMG FHIMJOACDLI, Guid DKCPOEJLOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0980", Offset = "0x5DAF580", VA = "0x185DB0980")]
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
		[Cpp2IlInjected.Address(RVA = "0x67DE20", Offset = "0x67CA20", VA = "0x18067DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4820", Offset = "0x5DB3420", VA = "0x185DB4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DAB230", Offset = "0x5DA9E30", VA = "0x185DAB230")]
		public AKNHHEPEIEH(Guid IODELCJGMCF, int NGKBGCBCFOA, int MGKCCPJBJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAF60", Offset = "0x5DA9B60", VA = "0x185DAAF60")]
		public static byte[] CLPGJOCDFOA(AKNHHEPEIEH HDKJDEIGPPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB0F0", Offset = "0x5DA9CF0", VA = "0x185DAB0F0")]
		public static AKNHHEPEIEH MNOLKCHHLIP(byte[] EHAMCGPFFID)
		{
			return default(AKNHHEPEIEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB1B0", Offset = "0x5DA9DB0", VA = "0x185DAB1B0")]
		private static byte[] PCGDHONDAND(int OJFFKHAMPMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB040", Offset = "0x5DA9C40", VA = "0x185DAB040")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB3150", Offset = "0x5DB1D50", VA = "0x185DB3150")]
	public EAPGPEOCLGH(Guid IODELCJGMCF, CMPGKADDOBE FIAGILNCDCH, CIDKPIOBPBN IJNIKOCLGEN, CancellationToken LAKDHEPMDKO, [Optional] CCDKJEBHOEJ LAEAPABKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2F80", Offset = "0x5DB1B80", VA = "0x185DB2F80", Slot = "5")]
	protected override void PHAPLBBFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2BC0", Offset = "0x5DB17C0", VA = "0x185DB2BC0", Slot = "6")]
	protected override void EAAFFOJFHLJ(int LPKMJJAAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2D60", Offset = "0x5DB1960", VA = "0x185DB2D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB3A00", Offset = "0x5DB2600", VA = "0x185DB3A00")]
	public FIEFMIEDDKM(FPNKEEMNBEJ FEMJAMGPBCL, [CanBeNull] byte[] OICHLBNIOCE, bool DOGOBHAEGCN, byte HCNGNBJJCGB, byte AELGEGFPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3860", Offset = "0x5DB2460", VA = "0x185DB3860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3670", Offset = "0x5DB2270", VA = "0x185DB3670")]
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
			[Cpp2IlInjected.Address(RVA = "0x31093D0", Offset = "0x3107FD0", VA = "0x1831093D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DB5080", Offset = "0x5DB3C80", VA = "0x185DB5080", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAB8140", Offset = "0xAB6D40", VA = "0x180AB8140")]
		[DebuggerHidden]
		public IMAFKJMFCAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4DB0", Offset = "0x5DB39B0", VA = "0x185DB4DB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5040", Offset = "0x5DB3C40", VA = "0x185DB5040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4FA0", Offset = "0x5DB3BA0", VA = "0x185DB4FA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CIBDPJGBDLI> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4FA0", Offset = "0x5DB3BA0", VA = "0x185DB4FA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB4360", Offset = "0x5DB2F60", VA = "0x185DB4360")]
	public static FPNKEEMNBEJ MKILNPJHFPG(OAPNNFFKIMG FHIMJOACDLI, Guid OPGIIAOPEOO)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3AE0", Offset = "0x5DB26E0", VA = "0x185DB3AE0")]
	public static FPNKEEMNBEJ DKDOMPGHJMA(List<CIBDPJGBDLI> LMOIPKGOGEA)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3F00", Offset = "0x5DB2B00", VA = "0x185DB3F00")]
	public static FPNKEEMNBEJ JGFAMDBLNCD(OAPNNFFKIMG FIJKGADOAAF, Guid[] AMOEECIKAON)
	{
		return default(FPNKEEMNBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DB45E0", Offset = "0x5DB31E0", VA = "0x185DB45E0")]
	private FPNKEEMNBEJ(OAPNNFFKIMG FIJKGADOAAF, Guid[] AMOEECIKAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3A60", Offset = "0x5DB2660", VA = "0x185DB3A60")]
	[IteratorStateMachine(typeof(IMAFKJMFCAI))]
	public IEnumerable<CIBDPJGBDLI> CEPCJEDAMOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4460", Offset = "0x5DB3060", VA = "0x185DB4460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CBGNNHAEMGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39BA930", Offset = "0x39B9530", VA = "0x1839BA930", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DAD3D0", Offset = "0x5DABFD0", VA = "0x185DAD3D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCEEELNBJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD380", Offset = "0x5DABF80", VA = "0x185DAD380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD600", Offset = "0x5DAC200", VA = "0x185DAD600")]
	public BMDFDHDDIKA(CIDKPIOBPBN IJNIKOCLGEN, CancellationToken LAKDHEPMDKO, [Optional] CCDKJEBHOEJ LAEAPABKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD3F0", Offset = "0x5DABFF0", VA = "0x185DAD3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD530", Offset = "0x5DAC130", VA = "0x185DAD530", Slot = "5")]
	protected virtual void PHAPLBBFGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD430", Offset = "0x5DAC030", VA = "0x185DAD430")]
	private void GHBHGLJMHCL(HHODDDLIHOO JIHDDJNMGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD4D0", Offset = "0x5DAC0D0", VA = "0x185DAD4D0")]
	protected void OGBOLPIGKMP(int LPKMJJAAOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD410", Offset = "0x5DAC010", VA = "0x185DAD410", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D95CF0", Offset = "0x4D948F0", VA = "0x184D95CF0")]
	public CIBDPJGBDLI(OAPNNFFKIMG FHIMJOACDLI, Guid GFFJOACFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD9C0", Offset = "0x5DAC5C0", VA = "0x185DAD9C0")]
	public bool OKMKGFFNCCL(CIBDPJGBDLI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD8D0", Offset = "0x5DAC4D0", VA = "0x185DAD8D0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD990", Offset = "0x5DAC590", VA = "0x185DAD990", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DAC5E0", Offset = "0x5DAB1E0", VA = "0x185DAC5E0")]
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
