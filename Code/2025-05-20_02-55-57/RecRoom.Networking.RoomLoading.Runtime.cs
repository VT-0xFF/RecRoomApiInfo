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
internal class CLLBKPELOKM : AFPMIDKCBKN<MEAOOFOHDKO>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OEEALFHAEJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OEEALFHAEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6300", Offset = "0x7DA5500", VA = "0x187DA6300")]
		internal object JPIINFBFNLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] JEGNJALKFEK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CLLBKPELOKM NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C2E0", Offset = "0x7D9B4E0", VA = "0x187D9C2E0", Slot = "5")]
	protected override void ELJDILDFPKE(MEAOOFOHDKO BDAAPBJEHGD, IDictionary<object, object> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D9C690", Offset = "0x7D9B890", VA = "0x187D9C690", Slot = "6")]
	public override MEAOOFOHDKO JKAINKAKBPB(IDictionary<object, object> DHAOEHNLNON)
	{
		return default(MEAOOFOHDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D370", Offset = "0x7D9C570", VA = "0x187D9D370")]
	public CLLBKPELOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KFHGIGIDJID
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string GAIAPBJGHDH([NotNull] byte[] MGEJNDCFBJA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct HDBLPNMPBHJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly NKJIBCDLDPD AMCOLMHNLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool BLGJICGJLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T EDHFPJIJLND;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4B0FB20", Offset = "0x4B0ED20", VA = "0x184B0FB20")]
		public static HDBLPNMPBHJ<T> LGKMICOBBCD(MEAOOFOHDKO PNILIJCIHEL, Func<byte[], T> APLFJGHEKCF)
		{
			return default(HDBLPNMPBHJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4B0FDC0", Offset = "0x4B0EFC0", VA = "0x184B0FDC0")]
		public HDBLPNMPBHJ(NKJIBCDLDPD OKFADKAHIBL, T MGEJNDCFBJA, bool MGOPPFEJCBG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4B0FC20", Offset = "0x4B0EE20", VA = "0x184B0FC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OPKEHMBJIPO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MEKGAIOCFJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<MEAOOFOHDKO> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public OPKEHMBJIPO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public MEKGAIOCFJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4D50", Offset = "0x7DA3F50", VA = "0x187DA4D50")]
			internal void KABILLJCJJK(MEAOOFOHDKO msg)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4AA0", Offset = "0x7DA3CA0", VA = "0x187DA4AA0")]
			internal void FNKPAABNCPL(string itemType, long totalStopwatchTicks)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4DC0", Offset = "0x7DA3FC0", VA = "0x187DA4DC0")]
			internal MDCNOHOJOGN MIKOFMGALGO(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FNIPKKCLMNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public string itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public FNIPKKCLMNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D9D900", Offset = "0x7D9CB00", VA = "0x187D9D900")]
			internal object KLLFPELEMFO()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct ICGPFGPGNHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MEAOOFOHDKO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OPKEHMBJIPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private MEKGAIOCFJO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<MEAOOFOHDKO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D9F270", Offset = "0x7D9E470", VA = "0x187D9F270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D9FAE0", Offset = "0x7D9ECE0", VA = "0x187D9FAE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ECEMHIBLHEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public MEOCMMOCKMI sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public ECEMHIBLHEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7D9D450", Offset = "0x7D9C650", VA = "0x187D9D450")]
			internal bool CKKJOIKMIFP(MEAOOFOHDKO bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly OBKGJCEONDL PDDHKIOJLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string AEIOHNDNLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<MEAOOFOHDKO> MKIADFAIPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(string, long totalStopwatchTicks)> PJLLBCAOCKB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LKKCKHPLKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7200", Offset = "0x7DA6400", VA = "0x187DA7200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<MEAOOFOHDKO> NHACCADGPNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7300", Offset = "0x7DA6500", VA = "0x187DA7300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7250", Offset = "0x7DA6450", VA = "0x187DA7250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DA74F0", Offset = "0x7DA66F0", VA = "0x187DA74F0")]
		public OPKEHMBJIPO(OBKGJCEONDL PDDHKIOJLJH, string AEIOHNDNLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7DA73B0", Offset = "0x7DA65B0", VA = "0x187DA73B0")]
		[AsyncStateMachine(typeof(ICGPFGPGNHN))]
		public Task<MEAOOFOHDKO> OLGFCFBCJNK(CancellationToken HCELDNOKOAM, TimeSpan KMMOMBOBGDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7030", Offset = "0x7DA6230", VA = "0x187DA7030")]
		public void FNHMAOPLHPJ(MEAOOFOHDKO BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6FD0", Offset = "0x7DA61D0", VA = "0x187DA6FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DA70E0", Offset = "0x7DA62E0", VA = "0x187DA70E0")]
		public void KGCPNLIPPJA(MEOCMMOCKMI NMFALLJDLMG, Guid MKHHKDJKLDN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HJFAFDCKCMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<MEAOOFOHDKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E820", Offset = "0x7D9DA20", VA = "0x187D9E820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F200", Offset = "0x7D9E400", VA = "0x187D9F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HFHIBOHJKIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<HDBLPNMPBHJ<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D9A0", Offset = "0x7D9CBA0", VA = "0x187D9D9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DD90", Offset = "0x7D9CF90", VA = "0x187D9DD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HEMPFOCGPEN<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<HDBLPNMPBHJ<T>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Func<T, byte[]> serializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public T messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Func<byte[], T> deserializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4B1FEC0", Offset = "0x4B1F0C0", VA = "0x184B1FEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4B202C0", Offset = "0x4B1F4C0", VA = "0x184B202C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HHKBOOLBIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<MEAOOFOHDKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IHKEKBDONBN pauseAfterListeningToken;

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
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DF50", Offset = "0x7D9D150", VA = "0x187D9DF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E7B0", Offset = "0x7D9D9B0", VA = "0x187D9E7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MNGGPFMEDGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Func<bool> hasBlockBeenCompleted;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MNGGPFMEDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5160", Offset = "0x7DA4360", VA = "0x187DA5160")]
		internal bool AKHGDKNGMPF(int currentAttempt, TimeSpan elapsed, TimeSpan globalTimeout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5250", Offset = "0x7DA4450", VA = "0x187DA5250")]
		internal bool FPNBHOIGIJE(int newMasterClientActorNumber)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OHANFEFMADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<MEAOOFOHDKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KFHGIGIDJID <>4__this;

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
		private MNGGPFMEDGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private EFAPEFGONHF <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7DA63B0", Offset = "0x7DA55B0", VA = "0x187DA63B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6F60", Offset = "0x7DA6160", VA = "0x187DA6F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BDPHHHBLIPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<MEAOOFOHDKO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<MEAOOFOHDKO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7D9BD80", Offset = "0x7D9AF80", VA = "0x187D9BD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C1C0", Offset = "0x7D9B3C0", VA = "0x187D9C1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AONHOAONEAB
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
			public AONHOAONEAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7A30", Offset = "0x7DA6C30", VA = "0x187DA7A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7BE0", Offset = "0x7DA6DE0", VA = "0x187DA7BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AONHOAONEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B720", Offset = "0x7D9A920", VA = "0x187D9B720")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> LHPOMPANLHK(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KDIPEOMBAAB : IAsyncStateMachine
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
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IHKEKBDONBN pauseAfterListeningToken;

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
		[Cpp2IlInjected.Address(RVA = "0x7D9FC50", Offset = "0x7D9EE50", VA = "0x187D9FC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FEF0", Offset = "0x7D9F0F0", VA = "0x187D9FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HNGMNJFOOEC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IHKEKBDONBN pauseAfterListeningToken;

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
		[Cpp2IlInjected.Address(RVA = "0x4BAE2D0", Offset = "0x4BAD4D0", VA = "0x184BAE2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4A03EF0", Offset = "0x4A030F0", VA = "0x184A03EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CGENEJFBBEF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<Guid, bool> blockCompletionLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CGENEJFBBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6455340", Offset = "0x6454540", VA = "0x186455340")]
		internal bool BHDLPENEMNO(int newMasterClientActorNumber)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JGKBPKKBEJN<T> : IAsyncStateMachine
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
		public KFHGIGIDJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private CGENEJFBBEF<T> <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IHKEKBDONBN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public IHKEKBDONBN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private bool <isRootMasterBlockSlice>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private BBGOKNFFFML <masterSwitchTokenScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private T <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<HDBLPNMPBHJ<Guid>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4EBCE00", Offset = "0x4EBC000", VA = "0x184EBCE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDF90", Offset = "0x4EBD190", VA = "0x184EBDF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MBOLIABNJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MBOLIABNJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA45A0", Offset = "0x7DA37A0", VA = "0x187DA45A0")]
		internal object KBGLIGNEFEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4550", Offset = "0x7DA3750", VA = "0x187DA4550")]
		internal object EOELMEPEEGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IJOFODEJEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MEOCMMOCKMI sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IJOFODEJEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FBB0", Offset = "0x7D9EDB0", VA = "0x187D9FBB0")]
		internal object BCLDFKPFGDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DFJBOGMJILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public MEOCMMOCKMI sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DFJBOGMJILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D3B0", Offset = "0x7D9C5B0", VA = "0x187D9D3B0")]
		internal object LNPNMJNPCEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LEAFGNJMEJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LEAFGNJMEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DA44E0", Offset = "0x7DA36E0", VA = "0x187DA44E0")]
		internal object NFHMAABMNGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CCPADJOGPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CCPADJOGPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C270", Offset = "0x7D9B470", VA = "0x187D9C270")]
		internal object IGDFNECLBNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IIEKCJFCBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IIEKCJFCBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FB80", Offset = "0x7D9ED80", VA = "0x187D9FB80")]
		internal bool GBBONFPEODK(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NBFJFKFOHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NBFJFKFOHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD36E0", Offset = "0x2DD28E0", VA = "0x182DD36E0")]
		internal bool EIHKLBIDKGH(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BLPMHFDGJLI
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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BLPMHFDGJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C230", Offset = "0x7D9B430", VA = "0x187D9C230")]
		internal bool GPFFAJKFABN(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C230", Offset = "0x7D9B430", VA = "0x187D9C230")]
		internal bool EIEEJOEBBBE(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IDCMBDJNFIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IDCMBDJNFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D9FB50", Offset = "0x7D9ED50", VA = "0x187D9FB50")]
		internal bool CKMKLNAEKGI(HFJPLLGEGPL stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ODJNAGGACKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ODJNAGGACKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6050", Offset = "0x7DA5250", VA = "0x187DA6050")]
		internal object JMEJBPHFDON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5E10", Offset = "0x7DA5010", VA = "0x187DA5E10")]
		internal object GMOGNOFMCPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6290", Offset = "0x7DA5490", VA = "0x187DA6290")]
		internal object LKKAJGFDGGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly GAIAPBJGHDH GNMCLPOADKC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable IFOHHOCICOA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BKJLKPIDHCH FBGLGKJGIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OPKEHMBJIPO DPLFBGCNJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OBKGJCEONDL PDDHKIOJLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NEHMOIAADDF GDDIKKLCMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EFJACBMEPDD OEBAFPDICJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GAIAPBJGHDH KOBLBKFBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DJOMNIEOFJP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan BFHLCLIHPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan AFBNGANMGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte AHCNPBPHKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] EDLGNNKNOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<HFJPLLGEGPL> BIOEIFPLFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NKJIBCDLDPD? ILPGBKOFGJD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly BKJLKPIDHCH BIDDGPDJEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly BKJLKPIDHCH KLAKOOEOAIA;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<MEAOOFOHDKO> EEMONMDDDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DA33B0", Offset = "0x7DA25B0", VA = "0x187DA33B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DA15E0", Offset = "0x7DA07E0", VA = "0x187DA15E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4030", Offset = "0x7DA3230", VA = "0x187DA4030")]
	public KFHGIGIDJID(OBKGJCEONDL PDDHKIOJLJH, NEHMOIAADDF GDDIKKLCMOE, EFJACBMEPDD OEBAFPDICJO, [Optional] TimeSpan? JAJPKDBJOKP, [Optional] GAIAPBJGHDH OFOHOMNGHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38AAF40", Offset = "0x38AA140", VA = "0x1838AAF40")]
	public static KFHGIGIDJID NAOLPLNEOGI<TNetworking>(TNetworking GCMEJOEAFHA, [Optional] TimeSpan? JAJPKDBJOKP, [Optional] GAIAPBJGHDH OFOHOMNGHOE) where TNetworking : OBKGJCEONDL, NEHMOIAADDF, EFJACBMEPDD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1690", Offset = "0x7DA0890", VA = "0x187DA1690")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1F50", Offset = "0x7DA1150", VA = "0x187DA1F50")]
	private byte IMPJIOFMBNJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA26F0", Offset = "0x7DA18F0", VA = "0x187DA26F0")]
	private TimeSpan KNJDALGAADK(TimeSpan? JAJPKDBJOKP, int AILAPDFOCNI = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38AB300", Offset = "0x38AA500", VA = "0x1838AB300")]
	public bool PEIPKPMMGAM<T>(T FCDBDCBEJBO, Func<T, byte[]> BMKNJFOIIEM, bool MGOPPFEJCBG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DA37A0", Offset = "0x7DA29A0", VA = "0x187DA37A0")]
	public bool PEIPKPMMGAM(byte[] FCDBDCBEJBO, int ILEODIPLFDK, bool MGOPPFEJCBG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	private static string GPOLHJEMILK(string BDAAPBJEHGD, string EKKMKLFENBL = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2B50", Offset = "0x7DA1D50", VA = "0x187DA2B50")]
	[AsyncStateMachine(typeof(HJFAFDCKCMF))]
	public Task<MEAOOFOHDKO> MIKPJOOEDEI(CancellationToken HCELDNOKOAM, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] TimeSpan? JAJPKDBJOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3630", Offset = "0x7DA2830", VA = "0x187DA3630")]
	[AsyncStateMachine(typeof(HFHIBOHJKIF))]
	public Task<Guid> ODEHIIHGBBO(Guid DHCADEAIHIC, CancellationToken HCELDNOKOAM, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] TimeSpan? KMMOMBOBGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38AAFE0", Offset = "0x38AA1E0", VA = "0x1838AAFE0")]
	[AsyncStateMachine(typeof(HEMPFOCGPEN<>))]
	public Task<HDBLPNMPBHJ<T>> NDDOFENCDJJ<T>(T FCDBDCBEJBO, Func<T, byte[]> BMKNJFOIIEM, Func<byte[], T> APLFJGHEKCF, CancellationToken HCELDNOKOAM, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] TimeSpan? KMMOMBOBGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3230", Offset = "0x7DA2430", VA = "0x187DA3230")]
	[AsyncStateMachine(typeof(HHKBOOLBIIK))]
	public Task<MEAOOFOHDKO> NDDOFENCDJJ(byte[] FCDBDCBEJBO, CancellationToken HCELDNOKOAM, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] TimeSpan? KMMOMBOBGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2010", Offset = "0x7DA1210", VA = "0x187DA2010")]
	[AsyncStateMachine(typeof(OHANFEFMADI))]
	private Task<MEAOOFOHDKO> JMNAKPMNOOP(byte[] FCDBDCBEJBO, CancellationToken HCELDNOKOAM, IHKEKBDONBN LJNLLAMDPNC, IHKEKBDONBN JPDGLJBHJAN, TimeSpan? JAJPKDBJOKP, Stopwatch JLGABGHBCOD, [Optional] Func<bool> FNCIBAANIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DA17A0", Offset = "0x7DA09A0", VA = "0x187DA17A0")]
	[AsyncStateMachine(typeof(BDPHHHBLIPM))]
	private Task<MEAOOFOHDKO> HECPJGHIMAN(byte[] FCDBDCBEJBO, CancellationToken HCELDNOKOAM, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] TimeSpan? KMMOMBOBGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DA21C0", Offset = "0x7DA13C0", VA = "0x187DA21C0")]
	[AsyncStateMachine(typeof(KDIPEOMBAAB))]
	public Task KFOEPDBIHHH(CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task> HLLFNNAAIJD, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, int FNCDCCBCKOM = 3, [Optional] Func<Guid, bool> OCABJEEPHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38AAAC0", Offset = "0x38A9CC0", VA = "0x1838AAAC0")]
	[AsyncStateMachine(typeof(HNGMNJFOOEC<>))]
	public Task<T> KFOEPDBIHHH<T>(CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task<T>> HLLFNNAAIJD, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, int FNCDCCBCKOM = 3, [Optional] Func<Guid, bool> OCABJEEPHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38AA640", Offset = "0x38A9840", VA = "0x1838AA640")]
	[AsyncStateMachine(typeof(JGKBPKKBEJN<>))]
	private Task<(bool, T)> HJOIFFNJOGE<T>(Guid LOKMKCNFKJN, CancellationToken DMKDGAIEPFB, Func<CancellationToken, Task<T>> HLLFNNAAIJD, [Optional] IHKEKBDONBN LJNLLAMDPNC, [Optional] IHKEKBDONBN JPDGLJBHJAN, [Optional] Func<Guid, bool> OCABJEEPHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA05D0", Offset = "0x7D9F7D0", VA = "0x187DA05D0")]
	public void CDHBHDDMNPE(KOEIHCIJPPL IMPAKIFFNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1470", Offset = "0x7DA0670", VA = "0x187DA1470")]
	public Guid EIAHKMLEMFF(Guid PODNBOOBHJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1910", Offset = "0x7DA0B10", VA = "0x187DA1910")]
	public bool ICINIFDOBOE(MEOCMMOCKMI NMFALLJDLMG, Guid LOKMKCNFKJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DA0FC0", Offset = "0x7DA01C0", VA = "0x187DA0FC0")]
	public void DLPBAAIKPFI(MEOCMMOCKMI NMFALLJDLMG, Guid LOKMKCNFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA21B0", Offset = "0x7DA13B0", VA = "0x187DA21B0")]
	private void KBEHDDNOGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2930", Offset = "0x7DA1B30", VA = "0x187DA2930")]
	internal NKJIBCDLDPD MCMIPHHDBLM(bool BAJCKLHDKEI = false)
	{
		return default(NKJIBCDLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1350", Offset = "0x7DA0550", VA = "0x187DA1350")]
	private HashSet<Guid> ECIEHEFCHFI(MEOCMMOCKMI NMFALLJDLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DA3460", Offset = "0x7DA2660", VA = "0x187DA3460")]
	private void OBKCICLEAMJ(MEOCMMOCKMI NMFALLJDLMG, Guid MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2420", Offset = "0x7DA1620", VA = "0x187DA2420")]
	private void KJENNNIEOAK(MEOCMMOCKMI NMFALLJDLMG, Guid MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1EA0", Offset = "0x7DA10A0", VA = "0x187DA1EA0")]
	public static Func<Guid, bool> ILJHFGFLEDE(Guid MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DA1F60", Offset = "0x7DA1160", VA = "0x187DA1F60")]
	public static Func<Guid, bool> JJODDJKCNDD(Guid MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2320", Offset = "0x7DA1520", VA = "0x187DA2320")]
	public void KGCPNLIPPJA(MEOCMMOCKMI NMFALLJDLMG, Guid BIFPJPMFINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2CB0", Offset = "0x7DA1EB0", VA = "0x187DA2CB0")]
	public void MNCLPPAIDPM(MEOCMMOCKMI NMFALLJDLMG, Func<Guid, bool> MJFPIPCCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DA2A40", Offset = "0x7DA1C40", VA = "0x187DA2A40")]
	private static ExitGames.Client.Photon.Hashtable MGHIDIFIBNA(MEOCMMOCKMI NMFALLJDLMG, Guid NMOIJDAMCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D9FF50", Offset = "0x7D9F150", VA = "0x187D9FF50")]
	private void ANLKDAKLHBI(MEOCMMOCKMI NMFALLJDLMG, Guid NMOIJDAMCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MDCNOHOJOGN : KPAOIMPPAGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private List<(string itemType, long totalStopwatchTicks)> CJDMJDKMIOO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(string itemType, long totalStopwatchTicks)> MNJKHKFIJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4630", Offset = "0x7DA3830", VA = "0x187DA4630")]
	public MDCNOHOJOGN(TimeSpan KMMOMBOBGDN, List<(string itemType, long totalStopwatchTicks)> CJDMJDKMIOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BBGOKNFFFML : EFAPEFGONHF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct PLGGPJBJEON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly Guid JFLPMDGODOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int GBBEFCDGMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly int AMMCDBNAOBC;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA78C0", Offset = "0x7DA6AC0", VA = "0x187DA78C0")]
		public PLGGPJBJEON(Guid OKMBDDMPEBJ, int EFNIOBLADIE, int ANBCLBILCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7600", Offset = "0x7DA6800", VA = "0x187DA7600")]
		public static byte[] CEBCPPBDNIB(PLGGPJBJEON BDAAPBJEHGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7800", Offset = "0x7DA6A00", VA = "0x187DA7800")]
		public static PLGGPJBJEON JKAINKAKBPB(byte[] FONJAIMABAP)
		{
			return default(PLGGPJBJEON);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA76E0", Offset = "0x7DA68E0", VA = "0x187DA76E0")]
		private static byte[] DADJLNBAHIM(int EOIAPGKFGAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7760", Offset = "0x7DA6960", VA = "0x187DA7760")]
		private static int ICNCGMPANIM(byte[] HIPDBNMIKKD, int NIBICIJAIGM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Guid OKMBDDMPEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly KFHGIGIDJID DIPCFLLAADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool DBAJOIHCLPL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BD20", Offset = "0x7D9AF20", VA = "0x187D9BD20")]
	public BBGOKNFFFML(Guid OKMBDDMPEBJ, KFHGIGIDJID DIPCFLLAADD, EFJACBMEPDD GCMEJOEAFHA, CancellationToken DMKDGAIEPFB, [Optional] EMFKMGLBNKF IEKCMKMLDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B9B0", Offset = "0x7D9ABB0", VA = "0x187D9B9B0", Slot = "5")]
	protected override void MHPDBGPMJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7D9BB80", Offset = "0x7D9AD80", VA = "0x187D9BB80", Slot = "6")]
	protected override void OKDENIPDGHF(int NENHDGBCHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D9B830", Offset = "0x7D9AA30", VA = "0x187D9B830")]
	private void EEMONMDDDGB(MEAOOFOHDKO ADDPCDPBMCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MEAOOFOHDKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly NKJIBCDLDPD AMCOLMHNLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly byte BIBAEONOEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly byte HMBALGKOMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool BLGJICGJLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] EDHFPJIJLND;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DA4A40", Offset = "0x7DA3C40", VA = "0x187DA4A40")]
	public MEAOOFOHDKO(NKJIBCDLDPD OKFADKAHIBL, [CanBeNull] byte[] MGEJNDCFBJA, bool MGOPPFEJCBG, byte NBIAKNNOKCG, byte ICCADHHOHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DA48A0", Offset = "0x7DA3AA0", VA = "0x187DA48A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DA46B0", Offset = "0x7DA38B0", VA = "0x187DA46B0")]
	private static void JDEDICOPIPF(byte[] MGEJNDCFBJA, StringBuilder CHGJIFICBNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NKJIBCDLDPD
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MINKAMLAAPA : IEnumerable<HFJPLLGEGPL>, IEnumerable, IEnumerator<HFJPLLGEGPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private HFJPLLGEGPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NKJIBCDLDPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public NKJIBCDLDPD <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private MEOCMMOCKMI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HFJPLLGEGPL System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2199180", Offset = "0x2198380", VA = "0x182199180", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HFJPLLGEGPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5110", Offset = "0x7DA4310", VA = "0x187DA5110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2674050", Offset = "0x2673250", VA = "0x182674050")]
		[DebuggerHidden]
		public MINKAMLAAPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4EA0", Offset = "0x7DA40A0", VA = "0x187DA4EA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA50C0", Offset = "0x7DA42C0", VA = "0x187DA50C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5010", Offset = "0x7DA4210", VA = "0x187DA5010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HFJPLLGEGPL> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5010", Offset = "0x7DA4210", VA = "0x187DA5010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly MEOCMMOCKMI COGDPBEACKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly Guid[] MLCINPFPENC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DA52E0", Offset = "0x7DA44E0", VA = "0x187DA52E0")]
	public static NKJIBCDLDPD DLBMOEJDJKD(MEOCMMOCKMI NMFALLJDLMG, Guid AGNKKGDLPMH)
	{
		return default(NKJIBCDLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5440", Offset = "0x7DA4640", VA = "0x187DA5440")]
	public static NKJIBCDLDPD FABBNLOIBBC(List<HFJPLLGEGPL> GGCIFKBGGFO)
	{
		return default(NKJIBCDLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7DA57B0", Offset = "0x7DA49B0", VA = "0x187DA57B0")]
	public static NKJIBCDLDPD LLFAMKJHMMG(MEOCMMOCKMI MJCDMGKPBDO, Guid[] PCEIDACOLKF)
	{
		return default(NKJIBCDLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5C70", Offset = "0x7DA4E70", VA = "0x187DA5C70")]
	private NKJIBCDLDPD(MEOCMMOCKMI MJCDMGKPBDO, Guid[] PCEIDACOLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DA53C0", Offset = "0x7DA45C0", VA = "0x187DA53C0")]
	[IteratorStateMachine(typeof(MINKAMLAAPA))]
	public IEnumerable<HFJPLLGEGPL> EONHLGGDPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DA5B00", Offset = "0x7DA4D00", VA = "0x187DA5B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class AFPMIDKCBKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A86B30", Offset = "0x4A85D30", VA = "0x184A86B30", Slot = "4")]
	public void DONAGBEDMDJ(T BDAAPBJEHGD, IDictionary<object, object> DHAOEHNLNON, bool OCCLLFGCKDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ELJDILDFPKE(T BDAAPBJEHGD, IDictionary<object, object> DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T JKAINKAKBPB(IDictionary<object, object> DHAOEHNLNON);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected AFPMIDKCBKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EFAPEFGONHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate bool EMFKMGLBNKF(int OPPJEAGECGJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly EFJACBMEPDD FJJGNIKEKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CancellationToken DMKDGAIEPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly CancellationToken LGICPDHPBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly EMFKMGLBNKF IEKCMKMLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly CancellationTokenSource JHLBGKJJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CancellationTokenSource EJMMEIIALMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly int FKDPFIBMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool OIEDIIDGBCH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken BAGAIIJKGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1950F50", Offset = "0x1950150", VA = "0x181950F50")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KKFJNGANIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D580", Offset = "0x7D9C780", VA = "0x187D9D580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D760", Offset = "0x7D9C960", VA = "0x187D9D760")]
	public EFAPEFGONHF(EFJACBMEPDD GCMEJOEAFHA, CancellationToken DMKDGAIEPFB, [Optional] EMFKMGLBNKF IEKCMKMLDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D4C0", Offset = "0x7D9C6C0", VA = "0x187D9D4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D670", Offset = "0x7D9C870", VA = "0x187D9D670", Slot = "5")]
	protected virtual void MHPDBGPMJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D4E0", Offset = "0x7D9C6E0", VA = "0x187D9D4E0")]
	private void EGLNBJMLJNN(KPDBONCIMNC NMAPFLEKNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D610", Offset = "0x7D9C810", VA = "0x187D9D610")]
	protected void LIPDLMALODH(int NENHDGBCHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7D9D740", Offset = "0x7D9C940", VA = "0x187D9D740", Slot = "6")]
	protected virtual void OKDENIPDGHF(int NENHDGBCHLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HFJPLLGEGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly MEOCMMOCKMI CMJMLHDIAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly Guid DNPNFGBLJLH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x50A7990", Offset = "0x50A6B90", VA = "0x1850A7990")]
	public HFJPLLGEGPL(MEOCMMOCKMI NMFALLJDLMG, Guid LOKMKCNFKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DE00", Offset = "0x7D9D000", VA = "0x187D9DE00")]
	public bool EKHAGIJCEHN(HFJPLLGEGPL FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DE60", Offset = "0x7D9D060", VA = "0x187D9DE60", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DF20", Offset = "0x7D9D120", VA = "0x187D9DF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Flags]
public enum MEOCMMOCKMI : byte
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
internal static class POJJPFOJECF
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal static readonly MEOCMMOCKMI[] AKHLNANMBMI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7DA78D0", Offset = "0x7DA6AD0", VA = "0x187DA78D0")]
	public static int MFHEIFACLPG(MEOCMMOCKMI NMFALLJDLMG)
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
