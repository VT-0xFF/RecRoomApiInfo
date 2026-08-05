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
internal class OAAIHCGMADH : FJDANLJBJPP<JFLMJDPGAPD>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HEHEJFBNIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HEHEJFBNIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81D92B0", Offset = "0x81D80B0", VA = "0x1881D92B0")]
		internal object PEMHEGCCBHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] ODHMLGEEIPF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly OAAIHCGMADH ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81DC8F0", Offset = "0x81DB6F0", VA = "0x1881DC8F0", Slot = "5")]
	protected override void MBCFOJJGNND(JFLMJDPGAPD IIHOFBLPONF, IDictionary<object, object> BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81DBE70", Offset = "0x81DAC70", VA = "0x1881DBE70", Slot = "6")]
	public override JFLMJDPGAPD KIDJPDKJMHF(IDictionary<object, object> BOIPFNOKGBJ)
	{
		return default(JFLMJDPGAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81DCEC0", Offset = "0x81DBCC0", VA = "0x1881DCEC0")]
	public OAAIHCGMADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DBHNIBMELEK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string MLJHELNJBNG([NotNull] byte[] OFCPJKNFOPJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct LKAOMGMKNOJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly JGKFNNBHKOK BHKAKEKDEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool IIKIFOBPMEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T NGGDEAHAABC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54897E0", Offset = "0x54885E0", VA = "0x1854897E0")]
		public static LKAOMGMKNOJ<T> IDDKEDFOBNH(JFLMJDPGAPD FIFJLEFBNJA, Func<byte[], T> CCMBJFAKODL)
		{
			return default(LKAOMGMKNOJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5489A70", Offset = "0x5488870", VA = "0x185489A70")]
		public LKAOMGMKNOJ(JGKFNNBHKOK OBOCGKBLHBJ, T OFCPJKNFOPJ, bool MHNNAJJPLHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x54898D0", Offset = "0x54886D0", VA = "0x1854898D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HCHCOIBMKGG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CENHBCOBABJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<JFLMJDPGAPD> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HCHCOIBMKGG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public CENHBCOBABJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x81D2480", Offset = "0x81D1280", VA = "0x1881D2480")]
			internal void BAGAELBCKBB(JFLMJDPGAPD msg)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x81D24F0", Offset = "0x81D12F0", VA = "0x1881D24F0")]
			internal void CHBGPFAIIND(string itemType, long totalStopwatchTicks)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x81D23A0", Offset = "0x81D11A0", VA = "0x1881D23A0")]
			internal HLGJGAKFLFO APODBFBPKJD(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LMIAPAIBLJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public string itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public LMIAPAIBLJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x81DAFD0", Offset = "0x81D9DD0", VA = "0x1881DAFD0")]
			internal object DOFDPMFECOD()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct HDCAFJDJDGM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<JFLMJDPGAPD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HCHCOIBMKGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private CENHBCOBABJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<JFLMJDPGAPD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x81D89D0", Offset = "0x81D77D0", VA = "0x1881D89D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x81D9240", Offset = "0x81D8040", VA = "0x1881D9240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DGGFHLJFPLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CMGBFJOFNFB sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public DGGFHLJFPLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x81D7C40", Offset = "0x81D6A40", VA = "0x1881D7C40")]
			internal bool DHOJIIHDMGJ(JFLMJDPGAPD bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LDHNAFBKDEA FIIAOLNAJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string KFAPPMPJIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<JFLMJDPGAPD> LANCOOPPALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(string, long totalStopwatchTicks)> OFDCOCGHOAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IONOABIFDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x81D85F0", Offset = "0x81D73F0", VA = "0x1881D85F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<JFLMJDPGAPD> LPIOBAFNAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x81D8760", Offset = "0x81D7560", VA = "0x1881D8760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81D83A0", Offset = "0x81D71A0", VA = "0x1881D83A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81D88C0", Offset = "0x81D76C0", VA = "0x1881D88C0")]
		public HCHCOIBMKGG(LDHNAFBKDEA FIIAOLNAJGP, string KFAPPMPJIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81D8450", Offset = "0x81D7250", VA = "0x1881D8450")]
		[AsyncStateMachine(typeof(HDCAFJDJDGM))]
		public Task<JFLMJDPGAPD> DLHACFDEDBJ(CancellationToken HIMDFBHMPLL, TimeSpan DKEAKDFFACG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81D8810", Offset = "0x81D7610", VA = "0x1881D8810")]
		public void ODLNKODKJIA(JFLMJDPGAPD IIHOFBLPONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81D8590", Offset = "0x81D7390", VA = "0x1881D8590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81D8640", Offset = "0x81D7440", VA = "0x1881D8640")]
		public void JINMELFLEDO(CMGBFJOFNFB OANENAJAFNK, Guid PPPFBKMGIMA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NMBOMJGFCIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<JFLMJDPGAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81DB410", Offset = "0x81DA210", VA = "0x1881DB410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81DBE00", Offset = "0x81DAC00", VA = "0x1881DBE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JCEHCJJPKNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<LKAOMGMKNOJ<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81D93E0", Offset = "0x81D81E0", VA = "0x1881D93E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81D97E0", Offset = "0x81D85E0", VA = "0x1881D97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EDPBAONBBHC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<LKAOMGMKNOJ<T>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Func<T, byte[]> serializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public T messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Func<byte[], T> deserializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4810000", Offset = "0x480EE00", VA = "0x184810000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x48107F0", Offset = "0x480F5F0", VA = "0x1848107F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PJHJKEIGIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<JFLMJDPGAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JHDPICMPNBI pauseAfterListeningToken;

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
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81DD450", Offset = "0x81DC250", VA = "0x1881DD450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81DDCB0", Offset = "0x81DCAB0", VA = "0x1881DDCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MCMPMHDBPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Func<bool> hasBlockBeenCompleted;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MCMPMHDBPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81DB110", Offset = "0x81D9F10", VA = "0x1881DB110")]
		internal bool GGIANBIKNPE(int currentAttempt, TimeSpan elapsed, TimeSpan globalTimeout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81DB200", Offset = "0x81DA000", VA = "0x1881DB200")]
		internal bool IBFPMKPFIKF(int newMasterClientActorNumber)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CFOCHLDJDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<JFLMJDPGAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Func<bool> hasBlockBeenCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private MCMPMHDBPKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private LFMFBOGIEKH <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81D27C0", Offset = "0x81D15C0", VA = "0x1881D27C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81D3380", Offset = "0x81D2180", VA = "0x1881D3380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ADDFLGILNBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<JFLMJDPGAPD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<JFLMJDPGAPD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81D1930", Offset = "0x81D0730", VA = "0x1881D1930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81D1D70", Offset = "0x81D0B70", VA = "0x1881D1D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EKNDCGOIKPE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public EKNDCGOIKPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x81DDD20", Offset = "0x81DCB20", VA = "0x1881DDD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81DDED0", Offset = "0x81DCCD0", VA = "0x1881DDED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EKNDCGOIKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81D8290", Offset = "0x81D7090", VA = "0x1881D8290")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> DNANIMAKLIP(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DMDFLEOPFGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Func<Guid, bool> blockCompletionLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81D7CB0", Offset = "0x81D6AB0", VA = "0x1881D7CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81D7F50", Offset = "0x81D6D50", VA = "0x1881D7F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CJMGFDIILNJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<Guid, bool> blockCompletionLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Guid <sliceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Guid> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<(bool, T)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67E8540", Offset = "0x67E7340", VA = "0x1867E8540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D59EF0", Offset = "0x4D58CF0", VA = "0x184D59EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PNMNJLECIGE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<Guid, bool> blockCompletionLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public PNMNJLECIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x59CEE60", Offset = "0x59CDC60", VA = "0x1859CEE60")]
		internal bool CEAJJPNGBHE(int newMasterClientActorNumber)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct COEFHOPKONL<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AsyncTaskMethodBuilder<(bool, T)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<Guid, bool> blockCompletionLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public DBHNIBMELEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private PNMNJLECIGE<T> <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JHDPICMPNBI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JHDPICMPNBI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool <isRootMasterBlockSlice>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private OMEPHCOMDFG <masterSwitchTokenScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private T <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<LKAOMGMKNOJ<Guid>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68E2BF0", Offset = "0x68E19F0", VA = "0x1868E2BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68E3DC0", Offset = "0x68E2BC0", VA = "0x1868E3DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DEKJPKNCKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public DEKJPKNCKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81D7A00", Offset = "0x81D6800", VA = "0x1881D7A00")]
		internal object ELBHNKBNLGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81D7A90", Offset = "0x81D6890", VA = "0x1881D7A90")]
		internal object MGIEALFNJDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MAPCMGPKOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CMGBFJOFNFB sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MAPCMGPKOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81DB070", Offset = "0x81D9E70", VA = "0x1881DB070")]
		internal object KOAHHBDBAKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JIEDLMOFPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CMGBFJOFNFB sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JIEDLMOFPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81DA7C0", Offset = "0x81D95C0", VA = "0x1881DA7C0")]
		internal object DADKOJDCMIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BFGLLECOFPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public BFGLLECOFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81D1DE0", Offset = "0x81D0BE0", VA = "0x1881D1DE0")]
		internal object ENEDALJODCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KBKIKPCBPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KBKIKPCBPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81DA860", Offset = "0x81D9660", VA = "0x1881DA860")]
		internal object ELGBBGIJNEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MKMCPPAGDEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MKMCPPAGDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81DB290", Offset = "0x81DA090", VA = "0x1881DB290")]
		internal bool CFHPCFDOCOD(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ADHBKFKEHOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ADHBKFKEHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E60", Offset = "0x2B95C60", VA = "0x182B96E60")]
		internal bool MNKEDIJBGDC(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CCJEFONEIGE
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

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CCJEFONEIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81D1E50", Offset = "0x81D0C50", VA = "0x1881D1E50")]
		internal bool AFPNGLDPFJB(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81D1E50", Offset = "0x81D0C50", VA = "0x1881D1E50")]
		internal bool NMBGNMFAIFM(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CFGGCKELBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CFGGCKELBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81D2790", Offset = "0x81D1590", VA = "0x1881D2790")]
		internal bool CJIMFMBNOOE(NHNJNMJIIDO stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CDJOAIPLHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CDJOAIPLHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81D1E90", Offset = "0x81D0C90", VA = "0x1881D1E90")]
		internal object DFNENONGGLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81D2150", Offset = "0x81D0F50", VA = "0x1881D2150")]
		internal object NMEBHALAJGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81D20E0", Offset = "0x81D0EE0", VA = "0x1881D20E0")]
		internal object KJNCBKAMIHK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly MLJHELNJBNG NCOGOKKBHAL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable DJDGPPAEEBM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EIIAJLFMPKP HPICIAFECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HCHCOIBMKGG PHNNMMFHFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LDHNAFBKDEA FIIAOLNAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EOJHGHGPFPI EOILKCPJIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JMFPGPLHDPA ACLOPJIHFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MLJHELNJBNG GCJIHOKGOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool FOABPIBDEDN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan ODKGHOAOCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan PFBHCALKAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte HHPHJGACFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] HHIPHCDIAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<NHNJNMJIIDO> JGHJFGLCANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JGKFNNBHKOK? PCCOPPFCKGP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly EIIAJLFMPKP DJJBGBBGFPA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly EIIAJLFMPKP LMDHJBIABBD;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<JFLMJDPGAPD> EJOCKMMGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81D6940", Offset = "0x81D5740", VA = "0x1881D6940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81D3A80", Offset = "0x81D2880", VA = "0x1881D3A80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81D7540", Offset = "0x81D6340", VA = "0x1881D7540")]
	public DBHNIBMELEK(LDHNAFBKDEA FIIAOLNAJGP, EOJHGHGPFPI EOILKCPJIOL, JMFPGPLHDPA ACLOPJIHFNP, [Optional] TimeSpan? COABOAMCLPF, [Optional] MLJHELNJBNG NLJGALKAJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39D87F0", Offset = "0x39D75F0", VA = "0x1839D87F0")]
	public static DBHNIBMELEK CIODPPJNJHG<TNetworking>(TNetworking LEFGLILMCMC, [Optional] TimeSpan? COABOAMCLPF, [Optional] MLJHELNJBNG NLJGALKAJMI) where TNetworking : LDHNAFBKDEA, EOJHGHGPFPI, JMFPGPLHDPA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81D6830", Offset = "0x81D5630", VA = "0x1881D6830")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81D50A0", Offset = "0x81D3EA0", VA = "0x1881D50A0")]
	private byte EBOBGEICPPK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81D6CD0", Offset = "0x81D5AD0", VA = "0x1881D6CD0")]
	private TimeSpan OCIHNJLOKAC(TimeSpan? COABOAMCLPF, int FFHPLAOIAJF = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39D8730", Offset = "0x39D7530", VA = "0x1839D8730")]
	public bool BEBFOAJBIGP<T>(T DLGNPFNLJCP, Func<T, byte[]> MHJAFOGOHPI, bool MHNNAJJPLHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81D4210", Offset = "0x81D3010", VA = "0x1881D4210")]
	public bool BEBFOAJBIGP(byte[] DLGNPFNLJCP, int PAHNBOEBDNG, bool MHNNAJJPLHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	private static string DCLAIADBDDE(string IIHOFBLPONF, string PFKMCINIKNC = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81D40A0", Offset = "0x81D2EA0", VA = "0x1881D40A0")]
	[AsyncStateMachine(typeof(NMBOMJGFCIO))]
	public Task<JFLMJDPGAPD> ALFINJCJODP(CancellationToken HIMDFBHMPLL, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] TimeSpan? COABOAMCLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81D7080", Offset = "0x81D5E80", VA = "0x1881D7080")]
	[AsyncStateMachine(typeof(JCEHCJJPKNP))]
	public Task<Guid> POGFKKOKNFO(Guid JIGOFCCNMMC, CancellationToken HIMDFBHMPLL, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] TimeSpan? DKEAKDFFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39D8890", Offset = "0x39D7690", VA = "0x1839D8890")]
	[AsyncStateMachine(typeof(EDPBAONBBHC<>))]
	public Task<LKAOMGMKNOJ<T>> DNOBFBHKDNI<T>(T DLGNPFNLJCP, Func<T, byte[]> MHJAFOGOHPI, Func<byte[], T> CCMBJFAKODL, CancellationToken HIMDFBHMPLL, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] TimeSpan? DKEAKDFFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81D4F20", Offset = "0x81D3D20", VA = "0x1881D4F20")]
	[AsyncStateMachine(typeof(PJHJKEIGIIK))]
	public Task<JFLMJDPGAPD> DNOBFBHKDNI(byte[] DLGNPFNLJCP, CancellationToken HIMDFBHMPLL, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] TimeSpan? DKEAKDFFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81D62C0", Offset = "0x81D50C0", VA = "0x1881D62C0")]
	[AsyncStateMachine(typeof(CFOCHLDJDLE))]
	private Task<JFLMJDPGAPD> JGNFHDLBEKE(byte[] DLGNPFNLJCP, CancellationToken HIMDFBHMPLL, JHDPICMPNBI OAJDGBKLMEC, JHDPICMPNBI PEDGELLDDJI, TimeSpan? COABOAMCLPF, Stopwatch KECPFJJOPDP, [Optional] Func<bool> DJFKBEOEGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81D6F10", Offset = "0x81D5D10", VA = "0x1881D6F10")]
	[AsyncStateMachine(typeof(ADDFLGILNBG))]
	private Task<JFLMJDPGAPD> PCCGOIHCMKF(byte[] DLGNPFNLJCP, CancellationToken HIMDFBHMPLL, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] TimeSpan? DKEAKDFFACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81D6160", Offset = "0x81D4F60", VA = "0x1881D6160")]
	[AsyncStateMachine(typeof(DMDFLEOPFGF))]
	public Task IPKOECFJFDP(CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task> ACFKBFJDMNP, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, int PAPBCAKEKLI = 3, [Optional] Func<Guid, bool> CCKJKNKJBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39D8FE0", Offset = "0x39D7DE0", VA = "0x1839D8FE0")]
	[AsyncStateMachine(typeof(CJMGFDIILNJ<>))]
	public Task<T> IPKOECFJFDP<T>(CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task<T>> ACFKBFJDMNP, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, int PAPBCAKEKLI = 3, [Optional] Func<Guid, bool> CCKJKNKJBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x39D8B90", Offset = "0x39D7990", VA = "0x1839D8B90")]
	[AsyncStateMachine(typeof(COEFHOPKONL<>))]
	private Task<(bool, T)> GDDLAJLDEPA<T>(Guid ALPNJHDBADE, CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task<T>> ACFKBFJDMNP, [Optional] JHDPICMPNBI OAJDGBKLMEC, [Optional] JHDPICMPNBI PEDGELLDDJI, [Optional] Func<Guid, bool> CCKJKNKJBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81D5760", Offset = "0x81D4560", VA = "0x1881D5760")]
	public void FMGPJJJGALI(BNHAMMLICHE BKMCGGEFFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81D69F0", Offset = "0x81D57F0", VA = "0x1881D69F0")]
	public Guid MDAMHFKILCD(Guid MCOCJDMLFDN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81D3B30", Offset = "0x81D2930", VA = "0x1881D3B30")]
	public bool AGCOOFCMDOF(CMGBFJOFNFB OANENAJAFNK, Guid ALPNJHDBADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81D47A0", Offset = "0x81D35A0", VA = "0x1881D47A0")]
	public void BHFMLFIAHKO(CMGBFJOFNFB OANENAJAFNK, Guid ALPNJHDBADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x81D4200", Offset = "0x81D3000", VA = "0x1881D4200")]
	private void AOOBDFLKCMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81D4C40", Offset = "0x81D3A40", VA = "0x1881D4C40")]
	internal JGKFNNBHKOK DDDPFHFMJOF(bool JPPAFNFGIJM = false)
	{
		return default(JGKFNNBHKOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81D5640", Offset = "0x81D4440", VA = "0x1881D5640")]
	private HashSet<Guid> FDJIDFKGKFL(CMGBFJOFNFB OANENAJAFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81D4D50", Offset = "0x81D3B50", VA = "0x1881D4D50")]
	private void DKGFAKMMBAO(CMGBFJOFNFB OANENAJAFNK, Guid PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81D6460", Offset = "0x81D5260", VA = "0x1881D6460")]
	private void JICCCJEMFBN(CMGBFJOFNFB OANENAJAFNK, Guid PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81D6B70", Offset = "0x81D5970", VA = "0x1881D6B70")]
	public static Func<Guid, bool> MGONKFDKNFD(Guid PPPFBKMGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81D6C20", Offset = "0x81D5A20", VA = "0x1881D6C20")]
	public static Func<Guid, bool> NBHPBPPACBL(Guid PPPFBKMGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81D6730", Offset = "0x81D5530", VA = "0x1881D6730")]
	public void JINMELFLEDO(CMGBFJOFNFB OANENAJAFNK, Guid JNJBEICONKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81D50B0", Offset = "0x81D3EB0", VA = "0x1881D50B0")]
	public void EMEPPOMCANM(CMGBFJOFNFB OANENAJAFNK, Func<Guid, bool> ACHDMOGJNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81D4B30", Offset = "0x81D3930", VA = "0x1881D4B30")]
	private static ExitGames.Client.Photon.Hashtable COKMPMKGJDH(CMGBFJOFNFB OANENAJAFNK, Guid NHCFIBCMALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81D33F0", Offset = "0x81D21F0", VA = "0x1881D33F0")]
	private void ADAJNPCLJGA(CMGBFJOFNFB OANENAJAFNK, Guid NHCFIBCMALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HLGJGAKFLFO : ENDAPMILHKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private List<(string itemType, long totalStopwatchTicks)> JKJMBKJHCMD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(string itemType, long totalStopwatchTicks)> OLHPBPFFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA66680", Offset = "0xA65480", VA = "0x180A66680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x81D9360", Offset = "0x81D8160", VA = "0x1881D9360")]
	public HLGJGAKFLFO(TimeSpan DKEAKDFFACG, List<(string itemType, long totalStopwatchTicks)> JKJMBKJHCMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OMEPHCOMDFG : LFMFBOGIEKH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct DOCGBDBBAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly Guid HLKPFHFICNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int LODPKFGOFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly int CDILFICFIHM;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x81D8280", Offset = "0x81D7080", VA = "0x1881D8280")]
		public DOCGBDBBAPP(Guid BMCFEEEEDOP, int ANHOKCCIKBK, int CIIOMIIIGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81D81A0", Offset = "0x81D6FA0", VA = "0x1881D81A0")]
		public static byte[] NEJFHFKCOKJ(DOCGBDBBAPP IIHOFBLPONF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81D80E0", Offset = "0x81D6EE0", VA = "0x1881D80E0")]
		public static DOCGBDBBAPP KIDJPDKJMHF(byte[] JMAPKDPGDHP)
		{
			return default(DOCGBDBBAPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x81D8060", Offset = "0x81D6E60", VA = "0x1881D8060")]
		private static byte[] JJPMCJODIJB(int BOECAAOIBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81D7FB0", Offset = "0x81D6DB0", VA = "0x1881D7FB0")]
		private static int JCAIHAPLKPB(byte[] AIPMMIIHELF, int CKFKPOAGPKN)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Guid BMCFEEEEDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly DBHNIBMELEK NLKGAJKEDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool BIOPCBEHELG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81DD3F0", Offset = "0x81DC1F0", VA = "0x1881DD3F0")]
	public OMEPHCOMDFG(Guid BMCFEEEEDOP, DBHNIBMELEK NLKGAJKEDDD, JMFPGPLHDPA LEFGLILMCMC, CancellationToken FOJIDEIIGFD, [Optional] EHAJFPDBFOI NMHEFNNDIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x81DD220", Offset = "0x81DC020", VA = "0x1881DD220", Slot = "5")]
	protected override void KIJLEDABBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81DD080", Offset = "0x81DBE80", VA = "0x1881DD080", Slot = "6")]
	protected override void HCGNENMOFGG(int PFJFAIAACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81DCF00", Offset = "0x81DBD00", VA = "0x1881DCF00")]
	private void EJOCKMMGCDA(JFLMJDPGAPD DLIJPMHCCBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct JFLMJDPGAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly JGKFNNBHKOK BHKAKEKDEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly byte KHGFHLIHGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly byte NAIEMHDJCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool IIKIFOBPMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] NGGDEAHAABC;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x81D9BE0", Offset = "0x81D89E0", VA = "0x1881D9BE0")]
	public JFLMJDPGAPD(JGKFNNBHKOK OBOCGKBLHBJ, [CanBeNull] byte[] OFCPJKNFOPJ, bool MHNNAJJPLHB, byte AFIFACAAOGG, byte HHKBPLJGPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x81D9A40", Offset = "0x81D8840", VA = "0x1881D9A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x81D9850", Offset = "0x81D8650", VA = "0x1881D9850")]
	private static void CPEGGKCIEOA(byte[] OFCPJKNFOPJ, StringBuilder CMOCPACEKCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct JGKFNNBHKOK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KDODCEOOIBO : IEnumerable<NHNJNMJIIDO>, IEnumerable, IEnumerator<NHNJNMJIIDO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private NHNJNMJIIDO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public JGKFNNBHKOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public JGKFNNBHKOK <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private CMGBFJOFNFB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NHNJNMJIIDO System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2402690", Offset = "0x2401490", VA = "0x182402690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NHNJNMJIIDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x81DAB40", Offset = "0x81D9940", VA = "0x1881DAB40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x286DA90", Offset = "0x286C890", VA = "0x18286DA90")]
		[DebuggerHidden]
		public KDODCEOOIBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81DA8D0", Offset = "0x81D96D0", VA = "0x1881DA8D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81DAAF0", Offset = "0x81D98F0", VA = "0x1881DAAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x81DAA40", Offset = "0x81D9840", VA = "0x1881DAA40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NHNJNMJIIDO> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81DAA40", Offset = "0x81D9840", VA = "0x1881DAA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly CMGBFJOFNFB EJIPBLBNECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly Guid[] NIHHOLJCNAE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81D9CC0", Offset = "0x81D8AC0", VA = "0x1881D9CC0")]
	public static JGKFNNBHKOK ELJCFNANEAN(CMGBFJOFNFB OANENAJAFNK, Guid BACLBGIALIH)
	{
		return default(JGKFNNBHKOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x81D9DB0", Offset = "0x81D8BB0", VA = "0x1881D9DB0")]
	public static JGKFNNBHKOK OBNMFJPBCNB(List<NHNJNMJIIDO> OBJFKKHPCLA)
	{
		return default(JGKFNNBHKOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x81DA130", Offset = "0x81D8F30", VA = "0x1881DA130")]
	public static JGKFNNBHKOK ONHMNKJGHGK(CMGBFJOFNFB EOLEOEAPBCE, Guid[] IEPDLBLPCAG)
	{
		return default(JGKFNNBHKOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x81DA610", Offset = "0x81D9410", VA = "0x1881DA610")]
	private JGKFNNBHKOK(CMGBFJOFNFB EOLEOEAPBCE, Guid[] IEPDLBLPCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x81D9C40", Offset = "0x81D8A40", VA = "0x1881D9C40")]
	[IteratorStateMachine(typeof(KDODCEOOIBO))]
	public IEnumerable<NHNJNMJIIDO> EKOEILOGOND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81DA490", Offset = "0x81D9290", VA = "0x1881DA490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class FJDANLJBJPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4CB90D0", Offset = "0x4CB7ED0", VA = "0x184CB90D0", Slot = "4")]
	public void BFCONFMNMNN(T IIHOFBLPONF, IDictionary<object, object> BOIPFNOKGBJ, bool ODLHJCFEBJP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MBCFOJJGNND(T IIHOFBLPONF, IDictionary<object, object> BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T KIDJPDKJMHF(IDictionary<object, object> BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected FJDANLJBJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LFMFBOGIEKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate bool EHAJFPDBFOI(int PPOBFGJGGMI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly JMFPGPLHDPA NMCBGJPOJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CancellationToken FOJIDEIIGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly CancellationToken FOOMLBLEALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly EHAJFPDBFOI NMHEFNNDIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly CancellationTokenSource OENGENNKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CancellationTokenSource IFKCBMDCPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly int DIKHENIGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool KEPMFLIOGCP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken HIGLJOOFIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1B52940", Offset = "0x1B51740", VA = "0x181B52940")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IJGPLJBOFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81DAC50", Offset = "0x81D9A50", VA = "0x1881DAC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81DAE30", Offset = "0x81D9C30", VA = "0x1881DAE30")]
	public LFMFBOGIEKH(JMFPGPLHDPA LEFGLILMCMC, CancellationToken FOJIDEIIGFD, [Optional] EHAJFPDBFOI NMHEFNNDIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81DAC30", Offset = "0x81D9A30", VA = "0x1881DAC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81DAD00", Offset = "0x81D9B00", VA = "0x1881DAD00", Slot = "5")]
	protected virtual void KIJLEDABBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81DAB90", Offset = "0x81D9990", VA = "0x1881DAB90")]
	private void CGBHEFOCDEF(CDKFIILELLC LLBLGOOBCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81DADD0", Offset = "0x81D9BD0", VA = "0x1881DADD0")]
	protected void PLIFCLIDEIO(int PFJFAIAACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81DACE0", Offset = "0x81D9AE0", VA = "0x1881DACE0", Slot = "6")]
	protected virtual void HCGNENMOFGG(int PFJFAIAACPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NHNJNMJIIDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly CMGBFJOFNFB BCOEIHJBKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly Guid BNGJLHJBGJK;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x53D5CF0", Offset = "0x53D4AF0", VA = "0x1853D5CF0")]
	public NHNJNMJIIDO(CMGBFJOFNFB OANENAJAFNK, Guid ALPNJHDBADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81DB3B0", Offset = "0x81DA1B0", VA = "0x1881DB3B0")]
	public bool IDJKLHLFCIN(NHNJNMJIIDO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x81DB2C0", Offset = "0x81DA0C0", VA = "0x1881DB2C0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81DB380", Offset = "0x81DA180", VA = "0x1881DB380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Flags]
public enum CMGBFJOFNFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Operation = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RoomLoad = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MasterBlock = 4
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DEMJOINGDEC
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal static readonly CMGBFJOFNFB[] GFBNJKMLIKI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x81D7AE0", Offset = "0x81D68E0", VA = "0x1881D7AE0")]
	public static int KNOBHEHIGGD(CMGBFJOFNFB OANENAJAFNK)
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
