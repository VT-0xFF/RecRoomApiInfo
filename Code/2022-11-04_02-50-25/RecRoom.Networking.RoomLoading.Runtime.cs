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
internal class LMEKNAEFBBA : global::CCOEHBANMEB<IPPHPLIJKGK>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DLHMONCDBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DLHMONCDBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D64BF0", Offset = "0x5D63FF0", VA = "0x185D64BF0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] GPENNCFHFKP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly LMEKNAEFBBA PNBICMAKACI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D68F60", Offset = "0x5D68360", VA = "0x185D68F60", Slot = "5")]
	protected override void OEOHDDHPOMH(IPPHPLIJKGK HKDHNKHPGDP, IDictionary<object, object> HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D68440", Offset = "0x5D67840", VA = "0x185D68440", Slot = "6")]
	public override IPPHPLIJKGK DBBEJMFMHKH(IDictionary<object, object> HANEMGLFJMM)
	{
		return default(IPPHPLIJKGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D69600", Offset = "0x5D68A00", VA = "0x185D69600")]
	public LMEKNAEFBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AFIMMDDEDJL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string EEICBFJHIOE([NotNull] byte[] EGDJKJOHALJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum JNGNBNPKMEI : byte
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
	private readonly struct MIOONAOEPLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly JNGNBNPKMEI IABGAOHHKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid AIFDFCJEION;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4CCBA70", Offset = "0x4CCAE70", VA = "0x184CCBA70")]
		public MIOONAOEPLH(JNGNBNPKMEI HHBNKCPPJKF, Guid CPBJKGNLBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D69F90", Offset = "0x5D69390", VA = "0x185D69F90")]
		public bool KPLPCHPLAID(MIOONAOEPLH BKBGGIICJOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5D69EA0", Offset = "0x5D692A0", VA = "0x185D69EA0", Slot = "0")]
		public override bool Equals(object HKFNIHLBEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D69F60", Offset = "0x5D69360", VA = "0x185D69F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct DMFBNPPKOBE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly bool DEHOAKGNPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly JNGNBNPKMEI IABGAOHHKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Guid[] JBCGEAANNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly T KMDDNICFCGP;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7970", Offset = "0x2FD6D70", VA = "0x182FD7970")]
		public static DMFBNPPKOBE<T> KBDKBLINMCH(IPPHPLIJKGK JPCOGMCBEGI, Func<byte[], T> EFDGBAIBNIN)
		{
			return default(DMFBNPPKOBE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7D50", Offset = "0x2FD7150", VA = "0x182FD7D50")]
		public DMFBNPPKOBE(JNGNBNPKMEI HHBNKCPPJKF, Guid[] JPENNALHDCI, T EGDJKJOHALJ, bool LEOOADFDKPC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7BB0", Offset = "0x2FD6FB0", VA = "0x182FD7BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class PMOIPJIJMAF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HNOPGHHMCKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public TaskCompletionSource<IPPHPLIJKGK> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public PMOIPJIJMAF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public HNOPGHHMCKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5D66A70", Offset = "0x5D65E70", VA = "0x185D66A70")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5D66AC0", Offset = "0x5D65EC0", VA = "0x185D66AC0")]
			internal MJNKIPACLMI <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class BDHBOBONLHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public LFMFMNDELGO.JLKIGGFLFIJ itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public BDHBOBONLHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5D64680", Offset = "0x5D63A80", VA = "0x185D64680")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KBDBAMJKFLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder<IPPHPLIJKGK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public PMOIPJIJMAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private HNOPGHHMCKB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<IPPHPLIJKGK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5D67720", Offset = "0x5D66B20", VA = "0x185D67720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5D67F60", Offset = "0x5D67360", VA = "0x185D67F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MILPNJDOIFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public JNGNBNPKMEI sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public MILPNJDOIFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5D69D30", Offset = "0x5D69130", VA = "0x185D69D30")]
			internal bool <ClearSlice>b__0(IPPHPLIJKGK bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly FKGHABHKEHB IJDBFDOIBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly string LAJDJFBADCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<IPPHPLIJKGK> KEOBGHGFGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private List<(LFMFMNDELGO.JLKIGGFLFIJ itemType, long totalStopwatchTicks)> HJOJKGBLFAJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BGBELPGLKNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B8E0", Offset = "0x5D6ACE0", VA = "0x185D6B8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<IPPHPLIJKGK> PCOICPCPMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B570", Offset = "0x5D6A970", VA = "0x185D6B570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5D6B790", Offset = "0x5D6AB90", VA = "0x185D6B790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BA80", Offset = "0x5D6AE80", VA = "0x185D6BA80")]
		public PMOIPJIJMAF(FKGHABHKEHB IJDBFDOIBNB, string LAJDJFBADCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B930", Offset = "0x5D6AD30", VA = "0x185D6B930")]
		[AsyncStateMachine(typeof(KBDBAMJKFLB))]
		public Task<IPPHPLIJKGK> JADJLPOGINB(CancellationToken BJBDGBAHFDE, TimeSpan DAKLLNONDOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B830", Offset = "0x5D6AC30", VA = "0x185D6B830")]
		public void HFHGCHINDIP(IPPHPLIJKGK HKDHNKHPGDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B610", Offset = "0x5D6AA10", VA = "0x185D6B610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B660", Offset = "0x5D6AA60", VA = "0x185D6B660")]
		public void EDAOAAECKGH(JNGNBNPKMEI HHBNKCPPJKF, Guid FBDAFGPAOAL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HAACHJAEFPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<IPPHPLIJKGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LAPCKNIDAJE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D65F80", Offset = "0x5D65380", VA = "0x185D65F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D668B0", Offset = "0x5D65CB0", VA = "0x185D668B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KMCLCAIPPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LAPCKNIDAJE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<DMFBNPPKOBE<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D67FB0", Offset = "0x5D673B0", VA = "0x185D67FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D68360", Offset = "0x5D67760", VA = "0x185D68360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MPPEKAIOECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<IPPHPLIJKGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LAPCKNIDAJE pauseAfterListeningToken;

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
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6A070", Offset = "0x5D69470", VA = "0x185D6A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6A970", Offset = "0x5D69D70", VA = "0x185D6A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HLGFKPFJFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public HLGFKPFJFJF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct DOPFEOHFGAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<IPPHPLIJKGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private HLGFKPFJFJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LAPCKNIDAJE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private MHDGDDEDNCP <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D64CB0", Offset = "0x5D640B0", VA = "0x185D64CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D65760", Offset = "0x5D64B60", VA = "0x185D65760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OJNILDMEHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<IPPHPLIJKGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LAPCKNIDAJE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<IPPHPLIJKGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B140", Offset = "0x5D6A540", VA = "0x185D6B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B520", Offset = "0x5D6A920", VA = "0x185D6B520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NOEIIJOABLH
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
			public NOEIIJOABLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BB80", Offset = "0x5D6AF80", VA = "0x185D6BB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BCF0", Offset = "0x5D6B0F0", VA = "0x185D6BCF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NOEIIJOABLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B000", Offset = "0x5D6A400", VA = "0x185D6B000")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MFFJICDFLAK : IAsyncStateMachine
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
		public AFIMMDDEDJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LAPCKNIDAJE unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LAPCKNIDAJE pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5D696C0", Offset = "0x5D68AC0", VA = "0x185D696C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CENHHCKEKNA : IEnumerable<(JNGNBNPKMEI, Guid)>, IEnumerable, IEnumerator<(JNGNBNPKMEI, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private (JNGNBNPKMEI sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private JNGNBNPKMEI sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public JNGNBNPKMEI <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private JNGNBNPKMEI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (JNGNBNPKMEI, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3456F50", Offset = "0x3456350", VA = "0x183456F50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((JNGNBNPKMEI, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5D64BA0", Offset = "0x5D63FA0", VA = "0x185D64BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAAD540", VA = "0x180AAE140")]
		[DebuggerHidden]
		public CENHHCKEKNA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D64890", Offset = "0x5D63C90", VA = "0x185D64890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D64B60", Offset = "0x5D63F60", VA = "0x185D64B60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5D64AB0", Offset = "0x5D63EB0", VA = "0x185D64AB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(JNGNBNPKMEI, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5D64AB0", Offset = "0x5D63EB0", VA = "0x185D64AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NIJDPAFBCIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public NIJDPAFBCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D6AFB0", Offset = "0x5D6A3B0", VA = "0x185D6AFB0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CDIDNFFJLEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JNGNBNPKMEI sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public CDIDNFFJLEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D647F0", Offset = "0x5D63BF0", VA = "0x185D647F0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GOEINKMECJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public JNGNBNPKMEI sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public GOEINKMECJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D65EE0", Offset = "0x5D652E0", VA = "0x185D65EE0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FGNCAOLIIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FGNCAOLIIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5D65DB0", Offset = "0x5D651B0", VA = "0x185D65DB0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AMKHGEPCAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AMKHGEPCAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5D64610", Offset = "0x5D63A10", VA = "0x185D64610")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FCNKOHOBMMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FCNKOHOBMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D65D20", Offset = "0x5D65120", VA = "0x185D65D20")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LDMLHMEPEEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public LDMLHMEPEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5D683B0", Offset = "0x5D677B0", VA = "0x185D683B0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FODJJHLPBMN
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public FODJJHLPBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5D65E80", Offset = "0x5D65280", VA = "0x185D65E80")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D65E20", Offset = "0x5D65220", VA = "0x185D65E20")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BMPOGCBJPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BMPOGCBJPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D64750", Offset = "0x5D63B50", VA = "0x185D64750")]
		internal bool <ClearSliceIds>b__3(MIOONAOEPLH stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EIPICDIFBNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public EIPICDIFBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D65820", Offset = "0x5D64C20", VA = "0x185D65820")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D65AA0", Offset = "0x5D64EA0", VA = "0x185D65AA0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D657B0", Offset = "0x5D64BB0", VA = "0x185D657B0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly EEICBFJHIOE OKIIIHLOINB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable IKICAIDGFFA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DBBKKHEJAPM ILJLKHDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PMOIPJIJMAF FBPNPCHLHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FKGHABHKEHB IJDBFDOIBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AIGKOIMKCMK IDHNJIHGJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IOHECIOLNKE KLNGMEFFHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EEICBFJHIOE FCPMKMOKFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KHABLLHIIEN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan KENHDEAMCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan BFKDENFDEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte GFBOIGFHIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly JNGNBNPKMEI[] GBBDENLNAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] ADFDMJBCHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<MIOONAOEPLH> IMKEBGPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (JNGNBNPKMEI combinedSliceType, Guid[] sliceTypeIds)? AKPGDEHHJGA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly DBBKKHEJAPM LKDMOKFOJOF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly DBBKKHEJAPM BDCPIHPHBIF;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<IPPHPLIJKGK> BELNKIIBPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D613B0", Offset = "0x5D607B0", VA = "0x185D613B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D62600", Offset = "0x5D61A00", VA = "0x185D62600")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D64160", Offset = "0x5D63560", VA = "0x185D64160")]
	public AFIMMDDEDJL(FKGHABHKEHB IJDBFDOIBNB, AIGKOIMKCMK IDHNJIHGJBO, IOHECIOLNKE KLNGMEFFHJK, [Optional] TimeSpan? LALMELCKJFN, [Optional] EEICBFJHIOE JILGBNNINLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28282F0", Offset = "0x28276F0", VA = "0x1828282F0")]
	public static AFIMMDDEDJL OFILHCOJECG<TNetworking>(TNetworking MBEKPBENMJL, [Optional] TimeSpan? LALMELCKJFN, [Optional] EEICBFJHIOE JILGBNNINLG) where TNetworking : FKGHABHKEHB, AIGKOIMKCMK, IOHECIOLNKE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FA30", Offset = "0x5D5EE30", VA = "0x185D5FA30")]
	public void ANGPDPCFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D613A0", Offset = "0x5D607A0", VA = "0x185D613A0")]
	private byte GACOFENJLMH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FB20", Offset = "0x5D5EF20", VA = "0x185D5FB20")]
	private TimeSpan BNCFJEDNOHN(TimeSpan? LALMELCKJFN, int IGIKBCCFBIK = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2828390", Offset = "0x2827790", VA = "0x182828390")]
	public bool OOOAMKFHCMA<T>(T KEALDMFBEJI, Func<T, byte[]> MEDLODAPPOO, bool LEOOADFDKPC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D635D0", Offset = "0x5D629D0", VA = "0x185D635D0")]
	public bool OOOAMKFHCMA(byte[] KEALDMFBEJI, int NALNDBNCNKC, bool LEOOADFDKPC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76A500", Offset = "0x769900", VA = "0x18076A500")]
	private static string CACDMMIBAPI(string HKDHNKHPGDP, string GIPDGGFIBAH = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D601C0", Offset = "0x5D5F5C0", VA = "0x185D601C0")]
	[AsyncStateMachine(typeof(HAACHJAEFPP))]
	public Task<IPPHPLIJKGK> CAMPJJNPGOO(CancellationToken BJBDGBAHFDE, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, [Optional] TimeSpan? LALMELCKJFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D61080", Offset = "0x5D60480", VA = "0x185D61080")]
	[AsyncStateMachine(typeof(KMCLCAIPPHI))]
	public Task<Guid> FIMMHPAHCBE(Guid CIAHIPDJDGJ, CancellationToken BJBDGBAHFDE, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, [Optional] TimeSpan? DAKLLNONDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2827670", Offset = "0x2826A70", VA = "0x182827670")]
	[AsyncStateMachine(typeof(EFIIMGHGFCP))]
	public Task<DMFBNPPKOBE<T>> DEFCHOIACCL<T>(T KEALDMFBEJI, Func<T, byte[]> MEDLODAPPOO, Func<byte[], T> EFDGBAIBNIN, CancellationToken BJBDGBAHFDE, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, [Optional] TimeSpan? DAKLLNONDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D60840", Offset = "0x5D5FC40", VA = "0x185D60840")]
	[AsyncStateMachine(typeof(MPPEKAIOECE))]
	public Task<IPPHPLIJKGK> DEFCHOIACCL(byte[] KEALDMFBEJI, CancellationToken BJBDGBAHFDE, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, [Optional] TimeSpan? DAKLLNONDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D60ED0", Offset = "0x5D602D0", VA = "0x185D60ED0")]
	[AsyncStateMachine(typeof(DOPFEOHFGAE))]
	private Task<IPPHPLIJKGK> FBPOGILFHCN(byte[] KEALDMFBEJI, CancellationToken BJBDGBAHFDE, LAPCKNIDAJE ECPEEFLPIGD, LAPCKNIDAJE ILCCIHMPJPI, TimeSpan? LALMELCKJFN, Stopwatch BNKOKKPOLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D61210", Offset = "0x5D60610", VA = "0x185D61210")]
	[AsyncStateMachine(typeof(OJNILDMEHIA))]
	private Task<IPPHPLIJKGK> FLIPADCGOEG(byte[] KEALDMFBEJI, CancellationToken BJBDGBAHFDE, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, [Optional] TimeSpan? DAKLLNONDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D62770", Offset = "0x5D61B70", VA = "0x185D62770")]
	[AsyncStateMachine(typeof(MFFJICDFLAK))]
	public Task MFFNLFBPEGM(CancellationToken DAOHELLFNHN, Func<CancellationToken, Task> ANMMMELMICN, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, int MBIHEPOPCPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2827E40", Offset = "0x2827240", VA = "0x182827E40")]
	[AsyncStateMachine(typeof(GLMJICEHIPF))]
	public Task<T> MFFNLFBPEGM<T>(CancellationToken DAOHELLFNHN, Func<CancellationToken, Task<T>> ANMMMELMICN, [Optional] LAPCKNIDAJE ECPEEFLPIGD, [Optional] LAPCKNIDAJE ILCCIHMPJPI, int MBIHEPOPCPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28279F0", Offset = "0x2826DF0", VA = "0x1828279F0")]
	[AsyncStateMachine(typeof(OCPOKEDJBPP))]
	private Task<(bool, T)> KGFLCOJHPOI<T>(Guid CPBJKGNLBNJ, CancellationToken DAOHELLFNHN, Func<CancellationToken, Task<T>> ANMMMELMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D63420", Offset = "0x5D62820", VA = "0x185D63420")]
	[IteratorStateMachine(typeof(CENHHCKEKNA))]
	internal static IEnumerable<(JNGNBNPKMEI, Guid)> NMFCKCCKJOF(JNGNBNPKMEI AOCGKBDEOPC, Guid[] KCBJANIBIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D62990", Offset = "0x5D61D90", VA = "0x185D62990")]
	public void NHPNKKFJEPE(byte IJFHKLANACP, int COJNJLBAPPG, object CHPBOGKAJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D623A0", Offset = "0x5D617A0", VA = "0x185D623A0")]
	public Guid JPHAKEODHEJ(Guid GGKFOAPLANK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D626A0", Offset = "0x5D61AA0", VA = "0x185D626A0")]
	internal static int LJEHPIIGMHN(JNGNBNPKMEI HHBNKCPPJKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D60350", Offset = "0x5D5F750", VA = "0x185D60350")]
	public bool CLACKMELGGC(JNGNBNPKMEI HHBNKCPPJKF, Guid CPBJKGNLBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D60AE0", Offset = "0x5D5FEE0", VA = "0x185D60AE0")]
	public void ENNKFBIAGNE(JNGNBNPKMEI HHBNKCPPJKF, Guid CPBJKGNLBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D60340", Offset = "0x5D5F740", VA = "0x185D60340")]
	private void CEJKHPACIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D5FD60", Offset = "0x5D5F160", VA = "0x185D5FD60")]
	internal (JNGNBNPKMEI, Guid[]) BPIHIEGGHFP(bool JMOCJEOALOD = false)
	{
		return default((JNGNBNPKMEI, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D63BC0", Offset = "0x5D62FC0", VA = "0x185D63BC0")]
	private HashSet<Guid> PLMLFDEEMOD(JNGNBNPKMEI HHBNKCPPJKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D63D00", Offset = "0x5D63100", VA = "0x185D63D00")]
	private void PMDHPCCFGHM(JNGNBNPKMEI HHBNKCPPJKF, Guid FBDAFGPAOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D61450", Offset = "0x5D60850", VA = "0x185D61450")]
	private void GGMNHPCBIDI(JNGNBNPKMEI HHBNKCPPJKF, Guid FBDAFGPAOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D61730", Offset = "0x5D60B30", VA = "0x185D61730")]
	public static Func<Guid, bool> IEFOIPHOOKF(Guid FBDAFGPAOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D628E0", Offset = "0x5D61CE0", VA = "0x185D628E0")]
	public static Func<Guid, bool> NAOMCOCLHAM(Guid FBDAFGPAOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D609D0", Offset = "0x5D5FDD0", VA = "0x185D609D0")]
	public void EDAOAAECKGH(JNGNBNPKMEI HHBNKCPPJKF, Guid PEABICLHBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D61E80", Offset = "0x5D61280", VA = "0x185D61E80")]
	public void ILNKOHPKBMH(JNGNBNPKMEI HHBNKCPPJKF, Func<Guid, bool> NKDJEOMBBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D634B0", Offset = "0x5D628B0", VA = "0x185D634B0")]
	private static ExitGames.Client.Photon.Hashtable OCGEJINLOHP(JNGNBNPKMEI HHBNKCPPJKF, Guid HACDGHJIDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D617E0", Offset = "0x5D60BE0", VA = "0x185D617E0")]
	private void IHHDJFLEKLA(JNGNBNPKMEI HHBNKCPPJKF, Guid HACDGHJIDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MJNKIPACLMI : KLEBMGHPMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private List<(LFMFMNDELGO.JLKIGGFLFIJ itemType, long totalStopwatchTicks)> EGJOGECCCNF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(LFMFMNDELGO.JLKIGGFLFIJ itemType, long totalStopwatchTicks)> CFKFPANGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x673E20", Offset = "0x673220", VA = "0x180673E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D69FF0", Offset = "0x5D693F0", VA = "0x185D69FF0")]
	public MJNKIPACLMI(TimeSpan DAKLLNONDOL, List<(LFMFMNDELGO.JLKIGGFLFIJ itemType, long totalStopwatchTicks)> EGJOGECCCNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NBGEIEJJLAH : MHDGDDEDNCP
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct IGFCOODBHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Guid FNOEFOMMIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly int KIILGGKDAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly int JBLCMJEBPDP;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D67110", Offset = "0x5D66510", VA = "0x185D67110")]
		public IGFCOODBHEC(Guid CCACMKNDEGL, int HDCEENDICME, int PNKPGCKNKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D66E40", Offset = "0x5D66240", VA = "0x185D66E40")]
		public static byte[] CAOILNKOGOI(IGFCOODBHEC HKDHNKHPGDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D66FD0", Offset = "0x5D663D0", VA = "0x185D66FD0")]
		public static IGFCOODBHEC DBBEJMFMHKH(byte[] OGILIIFBKAD)
		{
			return default(IGFCOODBHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D67090", Offset = "0x5D66490", VA = "0x185D67090")]
		private static byte[] HGPDFEIAJII(int BBOINFMIBOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D66F20", Offset = "0x5D66320", VA = "0x185D66F20")]
		private static int CDFOKJECHMJ(byte[] INHAJEINOPC, int PGFOAHEHPOH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid CCACMKNDEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly AFIMMDDEDJL ADPGBCAGADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool GCBIMKKJJBC;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AF50", Offset = "0x5D6A350", VA = "0x185D6AF50")]
	public NBGEIEJJLAH(Guid CCACMKNDEGL, AFIMMDDEDJL ADPGBCAGADA, IOHECIOLNKE MBEKPBENMJL, CancellationToken DAOHELLFNHN, [Optional] MDBKOIEBAOJ FFKABNJDBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AD80", Offset = "0x5D6A180", VA = "0x185D6AD80", Slot = "5")]
	protected override void MANFLKNBFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ABE0", Offset = "0x5D69FE0", VA = "0x185D6ABE0", Slot = "6")]
	protected override void KDIGKNCAAPJ(int NMHHJNCJNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A9C0", Offset = "0x5D69DC0", VA = "0x185D6A9C0")]
	private void BELNKIIBPEA(IPPHPLIJKGK HPGFNCIEPBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct IPPHPLIJKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte NEAPKJDCPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly byte GEMLMIJDFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool DEHOAKGNPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly AFIMMDDEDJL.JNGNBNPKMEI IABGAOHHKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] JBCGEAANNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly byte[] KMDDNICFCGP;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D676C0", Offset = "0x5D66AC0", VA = "0x185D676C0")]
	public IPPHPLIJKGK(AFIMMDDEDJL.JNGNBNPKMEI HHBNKCPPJKF, [NotNull] Guid[] JPENNALHDCI, [CanBeNull] byte[] EGDJKJOHALJ, bool LEOOADFDKPC, byte DDCLCDBEIDJ, byte EKGHJHAHIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D67310", Offset = "0x5D66710", VA = "0x185D67310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D67120", Offset = "0x5D66520", VA = "0x185D67120")]
	private static void HGKKAHDMLFH(byte[] EGDJKJOHALJ, StringBuilder HKLHBPGNANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class CCOEHBANMEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x30E61D0", Offset = "0x30E55D0", VA = "0x1830E61D0", Slot = "4")]
	public void DIAKGAOFEJF(T HKDHNKHPGDP, IDictionary<object, object> HANEMGLFJMM, bool HIJFPMLJFIH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OEOHDDHPOMH(T HKDHNKHPGDP, IDictionary<object, object> HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T DBBEJMFMHKH(IDictionary<object, object> HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
	protected CCOEHBANMEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MHDGDDEDNCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool MDBKOIEBAOJ(int FMCAJBLJHEP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly IOHECIOLNKE NBPELOPMJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly CancellationToken DAOHELLFNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly CancellationToken FNOFOAAOHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly MDBKOIEBAOJ FFKABNJDBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly CancellationTokenSource GBHCDNNFCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly CancellationTokenSource IKIAIEFIOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly int MDCGCICIFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool JIOOFFMDFCI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken DDBMOONMEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D69920", Offset = "0x5D68D20", VA = "0x185D69920")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LALHFMGOCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D69940", Offset = "0x5D68D40", VA = "0x185D69940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D69B80", Offset = "0x5D68F80", VA = "0x185D69B80")]
	public MHDGDDEDNCP(IOHECIOLNKE MBEKPBENMJL, CancellationToken DAOHELLFNHN, [Optional] MDBKOIEBAOJ FFKABNJDBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D69900", Offset = "0x5D68D00", VA = "0x185D69900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D69A10", Offset = "0x5D68E10", VA = "0x185D69A10", Slot = "5")]
	protected virtual void MANFLKNBFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D69AE0", Offset = "0x5D68EE0", VA = "0x185D69AE0")]
	private void NHOCBCDNBIM(NEDBMOFEKBM KPJIHAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D69990", Offset = "0x5D68D90", VA = "0x185D69990")]
	protected void HCILOCCBGEK(int NMHHJNCJNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D699F0", Offset = "0x5D68DF0", VA = "0x185D699F0", Slot = "6")]
	protected virtual void KDIGKNCAAPJ(int NMHHJNCJNGO)
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
