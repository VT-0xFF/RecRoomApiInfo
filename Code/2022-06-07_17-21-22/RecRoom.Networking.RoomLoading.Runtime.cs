using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class AKJHKFEHAAA : global::ACBKEOPIMCG<BIPFKHLFLDC>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class COLENGDABHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public COLENGDABHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E16730", Offset = "0x4E14F30", VA = "0x184E16730")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] IAEBBJJJJGO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly AKJHKFEHAAA GBAAOFDIJNK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E15FF0", Offset = "0x4E147F0", VA = "0x184E15FF0", Slot = "5")]
	protected override void MLLGOKJIOGC(BIPFKHLFLDC LMJMILCCPPB, IDictionary<object, object> JIJMHNDPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E157F0", Offset = "0x4E13FF0", VA = "0x184E157F0", Slot = "6")]
	public override BIPFKHLFLDC GPGJANKJBGF(IDictionary<object, object> JIJMHNDPFCA)
	{
		return default(BIPFKHLFLDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E16560", Offset = "0x4E14D60", VA = "0x184E16560")]
	public AKJHKFEHAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FGHDNNJFCIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string HIBIICMBLOI([NotNull] byte[] LCPCMCBOFNJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum DLBNCGMFICJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct MNLPNGDGBPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly DLBNCGMFICJ INIAAGEBFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Guid GJDPNELAIDO;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x436CBB0", Offset = "0x436B3B0", VA = "0x18436CBB0")]
		public MNLPNGDGBPJ(DLBNCGMFICJ DDIAMMMLKHB, Guid FFCHBIPHJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DB80", Offset = "0x4E1C380", VA = "0x184E1DB80")]
		public bool HHFANCOAJID(MNLPNGDGBPJ GKBKHIIEFAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DA90", Offset = "0x4E1C290", VA = "0x184E1DA90", Slot = "0")]
		public override bool Equals(object OMILIKJDDEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DB50", Offset = "0x4E1C350", VA = "0x184E1DB50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct EOPDFOKLKOJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly bool EJCEDDNJHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly DLBNCGMFICJ INIAAGEBFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly Guid[] FIHIMOPIBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly T ENFFNAGLFCA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x25EA260", Offset = "0x25E8A60", VA = "0x1825EA260")]
		public static EOPDFOKLKOJ<T> PBEHKDCAHCE(BIPFKHLFLDC DCDPFKJKHDC, Func<byte[], T> FIBAOEDBPNG)
		{
			return default(EOPDFOKLKOJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x25EA540", Offset = "0x25E8D40", VA = "0x1825EA540")]
		public EOPDFOKLKOJ(DLBNCGMFICJ DDIAMMMLKHB, Guid[] LAHKMFJEJEF, T LCPCMCBOFNJ, bool NLHEBLHMJMN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x25EA3B0", Offset = "0x25E8BB0", VA = "0x1825EA3B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OBJAMLDFKOO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class IHLDFMBDPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<BIPFKHLFLDC> newMessageTaskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public IHLDFMBDPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C380", Offset = "0x4E1AB80", VA = "0x184E1C380")]
			internal void <AwaitNextMessage>b__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct MGGAFDJKDCN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public AsyncTaskMethodBuilder<BIPFKHLFLDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public OBJAMLDFKOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private IHLDFMBDPIH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<BIPFKHLFLDC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D0B0", Offset = "0x4E1B8B0", VA = "0x184E1D0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D6F0", Offset = "0x4E1BEF0", VA = "0x184E1D6F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MILONCOCEPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public DLBNCGMFICJ sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public MILONCOCEPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D740", Offset = "0x4E1BF40", VA = "0x184E1D740")]
			internal bool <ClearSlice>b__0(BIPFKHLFLDC bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly string DHDIGNDKNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<BIPFKHLFLDC> BJDKPEIBEHO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BCBFICENHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E710", Offset = "0x4E1CF10", VA = "0x184E1E710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<BIPFKHLFLDC> APFMDPBKIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4E1EA80", Offset = "0x4E1D280", VA = "0x184E1EA80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4E1EB20", Offset = "0x4E1D320", VA = "0x184E1EB20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4E1EBC0", Offset = "0x4E1D3C0", VA = "0x184E1EBC0")]
		public OBJAMLDFKOO(string DHDIGNDKNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E940", Offset = "0x4E1D140", VA = "0x184E1E940")]
		[AsyncStateMachine(typeof(MGGAFDJKDCN))]
		public Task<BIPFKHLFLDC> LCEBJNOGDLA(CancellationToken LFOGICEEHBE, TimeSpan IIONOJOHBFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E750", Offset = "0x4E1CF50", VA = "0x184E1E750")]
		public void BCMHPOBIGPO(BIPFKHLFLDC LMJMILCCPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E800", Offset = "0x4E1D000", VA = "0x184E1E800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E850", Offset = "0x4E1D050", VA = "0x184E1E850")]
		public void EEKPPELJGMC(DLBNCGMFICJ DDIAMMMLKHB, Guid DDEJHPOCOHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MBDNNLEJDEK : IEnumerable<(DLBNCGMFICJ, Guid)>, IEnumerable, IEnumerator<(DLBNCGMFICJ, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private (DLBNCGMFICJ, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private DLBNCGMFICJ sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DLBNCGMFICJ <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private DLBNCGMFICJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (DLBNCGMFICJ, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x282DA80", Offset = "0x282C280", VA = "0x18282DA80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DLBNCGMFICJ, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D060", Offset = "0x4E1B860", VA = "0x184E1D060", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8C23F0", Offset = "0x8C0BF0", VA = "0x1808C23F0")]
		[DebuggerHidden]
		public MBDNNLEJDEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CD40", Offset = "0x4E1B540", VA = "0x184E1CD40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D010", Offset = "0x4E1B810", VA = "0x184E1D010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CF60", Offset = "0x4E1B760", VA = "0x184E1CF60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DLBNCGMFICJ, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CF60", Offset = "0x4E1B760", VA = "0x184E1CF60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IKBACLBHBND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<BIPFKHLFLDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<BIPFKHLFLDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C440", Offset = "0x4E1AC40", VA = "0x184E1C440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CC70", Offset = "0x4E1B470", VA = "0x184E1CC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GKJOIOCCANN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter<EOPDFOKLKOJ<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BA50", Offset = "0x4E1A250", VA = "0x184E1BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BD70", Offset = "0x4E1A570", VA = "0x184E1BD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EDALKDILBEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<BIPFKHLFLDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<BIPFKHLFLDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4E16A00", Offset = "0x4E15200", VA = "0x184E16A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4E17150", Offset = "0x4E15950", VA = "0x184E17150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FENEELJENDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<BIPFKHLFLDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private MPDFKEHFJBC <masterSwitchScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<BIPFKHLFLDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E17200", Offset = "0x4E15A00", VA = "0x184E17200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4E17910", Offset = "0x4E16110", VA = "0x184E17910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IBHNHLMLAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<BIPFKHLFLDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<BIPFKHLFLDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C000", Offset = "0x4E1A800", VA = "0x184E1C000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C330", Offset = "0x4E1AB30", VA = "0x184E1C330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DEENAOJOGMG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public DEENAOJOGMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4E1ED10", Offset = "0x4E1D510", VA = "0x184E1ED10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4E1EE70", Offset = "0x4E1D670", VA = "0x184E1EE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public DEENAOJOGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E16850", Offset = "0x4E15050", VA = "0x184E16850")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MJADFPDKENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public FGHDNNJFCIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IABBHCJLEHL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IABBHCJLEHL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D8B0", Offset = "0x4E1C0B0", VA = "0x184E1D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FKPHDFCDJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public FKPHDFCDJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B980", Offset = "0x4E1A180", VA = "0x184E1B980")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B9C0", Offset = "0x4E1A1C0", VA = "0x184E1B9C0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BA10", Offset = "0x4E1A210", VA = "0x184E1BA10")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DBKHDEAEDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public DLBNCGMFICJ sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public DBKHDEAEDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4E167D0", Offset = "0x4E14FD0", VA = "0x184E167D0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HKFMNCOFNJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public DLBNCGMFICJ sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public HKFMNCOFNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BF80", Offset = "0x4E1A780", VA = "0x184E1BF80")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ENBHGLBONHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public ENBHGLBONHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4E171A0", Offset = "0x4E159A0", VA = "0x184E171A0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GPFLLPLCEMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public GPFLLPLCEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BDC0", Offset = "0x4E1A5C0", VA = "0x184E1BDC0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EBJLKOEJAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public EBJLKOEJAJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4E16970", Offset = "0x4E15170", VA = "0x184E16970")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MOICGOLOAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public MOICGOLOAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DBE0", Offset = "0x4E1C3E0", VA = "0x184E1DBE0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OJGGJNLFELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public OJGGJNLFELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4E1ECB0", Offset = "0x4E1D4B0", VA = "0x184E1ECB0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E1EC50", Offset = "0x4E1D450", VA = "0x184E1EC50")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NDIPHGFCJNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
		public NDIPHGFCJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DFD0", Offset = "0x4E1C7D0", VA = "0x184E1DFD0")]
		internal bool <ClearSliceIds>b__3(MNLPNGDGBPJ stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E0D0", Offset = "0x4E1C8D0", VA = "0x184E1E0D0")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E310", Offset = "0x4E1CB10", VA = "0x184E1E310")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E070", Offset = "0x4E1C870", VA = "0x184E1E070")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HIBIICMBLOI PICKCNALLOC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable DGFDAIPLINP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LJEBAKBLFBF NDNJDMFJIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OBJAMLDFKOO JOHABFDGOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HBJLLMOFOJB IGGJKPMBAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AIKCKCKGIIB LKCDBJGJDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IBFBECALIAA ACFLEBJOLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HIBIICMBLOI NIMHCMOEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MGKCHJEDODG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static readonly Guid FNMCDGKKKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[CompilerGenerated]
	private Action<BIPFKHLFLDC> GFPAGPHLFOJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal static readonly DLBNCGMFICJ[] HBAEDAECKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HashSet<Guid>[] JCPGODCCPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<MNLPNGDGBPJ> LLEDOIMDHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private (DLBNCGMFICJ combinedSliceType, Guid[] sliceTypeIds)? PBEFBFHEBDB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B610", Offset = "0x4E19E10", VA = "0x184E1B610")]
	public FGHDNNJFCIJ(HBJLLMOFOJB IGGJKPMBAHP, AIKCKCKGIIB LKCDBJGJDKP, IBFBECALIAA ACFLEBJOLEC, [Optional] HIBIICMBLOI GGBNMHLLFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x211B880", Offset = "0x211A080", VA = "0x18211B880")]
	public static FGHDNNJFCIJ IJBFJIMOIFH<TNetworking>(TNetworking NPIHCMHDBGO, [Optional] HIBIICMBLOI GGBNMHLLFHG) where TNetworking : HBJLLMOFOJB, AIKCKCKGIIB, IBFBECALIAA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E19230", Offset = "0x4E17A30", VA = "0x184E19230")]
	public void GPGHDCEFFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23EFB70", Offset = "0x23EE370", VA = "0x1823EFB70")]
	public bool DNEODPJAKLD<T>(T JKFKIFLEKMB, Func<T, byte[]> EIOEEBAAFNO, bool NLHEBLHMJMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E18400", Offset = "0x4E16C00", VA = "0x184E18400")]
	public bool DNEODPJAKLD(byte[] JKFKIFLEKMB, int EODKKILDEEB, bool NLHEBLHMJMN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A7F0", Offset = "0x4E18FF0", VA = "0x184E1A7F0")]
	private static string LLFMKCDACFH(DLBNCGMFICJ DDIAMMMLKHB, Guid[] LFJFPCDFHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E18C10", Offset = "0x4E17410", VA = "0x184E18C10")]
	[IteratorStateMachine(typeof(MBDNNLEJDEK))]
	private static IEnumerable<(DLBNCGMFICJ, Guid)> EPFOKKMOFEI(DLBNCGMFICJ DLBEJFCNGNK, Guid[] LFJFPCDFHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A510", Offset = "0x4E18D10", VA = "0x184E1A510")]
	[AsyncStateMachine(typeof(IKBACLBHBND))]
	public Task<BIPFKHLFLDC> LEEFPKBHLOG(CancellationToken LFOGICEEHBE, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, [Optional] TimeSpan? IIONOJOHBFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E17960", Offset = "0x4E16160", VA = "0x184E17960")]
	[AsyncStateMachine(typeof(GKJOIOCCANN))]
	public Task<Guid> AHMMFNKJJAP(Guid IIAIEMLHFOO, CancellationToken LFOGICEEHBE, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, [Optional] TimeSpan? IIONOJOHBFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D050", Offset = "0x1D2B850", VA = "0x181D2D050")]
	[AsyncStateMachine(typeof(JMMMGCPAFEN))]
	public Task<EOPDFOKLKOJ<T>> FPGMBCEDNHD<T>(T JKFKIFLEKMB, Func<T, byte[]> EIOEEBAAFNO, Func<byte[], T> FIBAOEDBPNG, CancellationToken LFOGICEEHBE, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, [Optional] TimeSpan? IIONOJOHBFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E18E10", Offset = "0x4E17610", VA = "0x184E18E10")]
	[AsyncStateMachine(typeof(EDALKDILBEI))]
	public Task<BIPFKHLFLDC> FPGMBCEDNHD(byte[] JKFKIFLEKMB, CancellationToken LFOGICEEHBE, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, [Optional] TimeSpan? IIONOJOHBFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A670", Offset = "0x4E18E70", VA = "0x184E1A670")]
	[AsyncStateMachine(typeof(FENEELJENDC))]
	private Task<BIPFKHLFLDC> LIPDLDNNHDA(byte[] JKFKIFLEKMB, CancellationToken LFOGICEEHBE, IABBHCJLEHL FPHLOPNEPIO, IABBHCJLEHL MLNFPJILBKI, TimeSpan? IIONOJOHBFG, Stopwatch PFAHKAAKOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E1AAA0", Offset = "0x4E192A0", VA = "0x184E1AAA0")]
	[AsyncStateMachine(typeof(IBHNHLMLAAL))]
	private Task<BIPFKHLFLDC> MDBNOAFICJE(byte[] JKFKIFLEKMB, CancellationToken LFOGICEEHBE, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, [Optional] TimeSpan? IIONOJOHBFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A940", Offset = "0x4E19140", VA = "0x184E1A940")]
	[AsyncStateMachine(typeof(MJADFPDKENH))]
	public Task LPGMBDCEBIG(CancellationToken IFJFPECIHDI, Func<CancellationToken, Task> BBIJBNGCHOG, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, int ANDPCDJEOHN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D210", Offset = "0x1D2BA10", VA = "0x181D2D210")]
	[AsyncStateMachine(typeof(DMLDKIGBGFH))]
	public Task<T> LPGMBDCEBIG<T>(CancellationToken IFJFPECIHDI, Func<CancellationToken, Task<T>> BBIJBNGCHOG, [Optional] IABBHCJLEHL FPHLOPNEPIO, [Optional] IABBHCJLEHL MLNFPJILBKI, int ANDPCDJEOHN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D2C9E0", Offset = "0x1D2B1E0", VA = "0x181D2C9E0")]
	[AsyncStateMachine(typeof(DFHKPPIIHBH))]
	private Task<(bool, T)> CBALBIDOAAO<T>(Guid FFCHBIPHJCE, CancellationToken IFJFPECIHDI, Func<CancellationToken, Task<T>> BBIJBNGCHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E17CB0", Offset = "0x4E164B0", VA = "0x184E17CB0")]
	public void DHFLABOKIKJ(byte GEKEIJCBAOJ, int OFMKMCABAFI, object ECMGAJBJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A0D0", Offset = "0x4E188D0", VA = "0x184E1A0D0")]
	public Guid KFHDFNANPFF(Guid OEAFELLJNPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A460", Offset = "0x4E18C60", VA = "0x184E1A460")]
	internal static int LALEHFDKKGK(DLBNCGMFICJ DDIAMMMLKHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E19560", Offset = "0x4E17D60", VA = "0x184E19560")]
	public bool HKJKAGELNPL(DLBNCGMFICJ DDIAMMMLKHB, Guid FFCHBIPHJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E199B0", Offset = "0x4E181B0", VA = "0x184E199B0")]
	public void ICEDIFKHLJF(DLBNCGMFICJ DDIAMMMLKHB, Guid FFCHBIPHJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B450", Offset = "0x4E19C50", VA = "0x184E1B450")]
	private void PJJNNOBDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E19CE0", Offset = "0x4E184E0", VA = "0x184E19CE0")]
	internal (DLBNCGMFICJ, Guid[]) KAKHHHMLGDG(bool DAMCJLEMBFM = false)
	{
		return default((DLBNCGMFICJ, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A320", Offset = "0x4E18B20", VA = "0x184E1A320")]
	private HashSet<Guid> KIIJEPILFPK(DLBNCGMFICJ DDIAMMMLKHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E18C90", Offset = "0x4E17490", VA = "0x184E18C90")]
	private void FIGOOEABKJB(DLBNCGMFICJ DDIAMMMLKHB, Guid DDEJHPOCOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4E19310", Offset = "0x4E17B10", VA = "0x184E19310")]
	private void HENGPMCGLOJ(DLBNCGMFICJ DDIAMMMLKHB, Guid DDEJHPOCOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E187E0", Offset = "0x4E16FE0", VA = "0x184E187E0")]
	public static Func<Guid, bool> EAKILHNMLON(Guid DDEJHPOCOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E17AC0", Offset = "0x4E162C0", VA = "0x184E17AC0")]
	public static Func<Guid, bool> CAGFBIEBDEA(Guid DDEJHPOCOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E18870", Offset = "0x4E17070", VA = "0x184E18870")]
	public void EEKPPELJGMC(DLBNCGMFICJ DDIAMMMLKHB, Guid IJPHBEGKADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E1AC10", Offset = "0x4E19410", VA = "0x184E1AC10")]
	public void MGBKELBEOMD(DLBNCGMFICJ DDIAMMMLKHB, Func<Guid, bool> ALLMAMLCIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E17B50", Offset = "0x4E16350", VA = "0x184E17B50")]
	private string CMLJIKOHMNN(byte[] LCPCMCBOFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E18F80", Offset = "0x4E17780", VA = "0x184E18F80")]
	[CompilerGenerated]
	private object GFFCKHBHIME(in (DLBNCGMFICJ st, Guid[] ids, byte[] mts) DHAMMIIHHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E18960", Offset = "0x4E17160", VA = "0x184E18960")]
	[CompilerGenerated]
	private object EIAAELGMIOH(in (DLBNCGMFICJ rst, Guid[] ssids, byte[] pl) DHAMMIIHHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E17C60", Offset = "0x4E16460", VA = "0x184E17C60")]
	[CompilerGenerated]
	private bool DFPFNJABHFM(int POCKMPKGGEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NFLAFOHCBDH : MPDFKEHFJBC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HBFEFHJBIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Guid IPPCHNGAJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int CNKBLBNKKKC;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xBBC090", Offset = "0xBBA890", VA = "0x180BBC090")]
		public HBFEFHJBIMN(Guid HHODLJNDHLO, int PFLDLCJIGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BEA0", Offset = "0x4E1A6A0", VA = "0x184E1BEA0")]
		public static byte[] PBGNCPABBCO(HBFEFHJBIMN LMJMILCCPPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BE20", Offset = "0x4E1A620", VA = "0x184E1BE20")]
		private static byte[] FLMCHCGLDHA(int APEAIJJLBLJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Guid HHODLJNDHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FGHDNNJFCIJ JJCDJHPLIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool DLDANCPKHCB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E6B0", Offset = "0x4E1CEB0", VA = "0x184E1E6B0")]
	public NFLAFOHCBDH(Guid HHODLJNDHLO, FGHDNNJFCIJ JJCDJHPLIHK, IBFBECALIAA NPIHCMHDBGO, CancellationToken IFJFPECIHDI, [Optional] LKKHIAJDGJB MLJLLKHCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E550", Offset = "0x4E1CD50", VA = "0x184E1E550", Slot = "5")]
	protected override void KJAENMBELGH(int POCKMPKGGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BIPFKHLFLDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool EJCEDDNJHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly FGHDNNJFCIJ.DLBNCGMFICJ INIAAGEBFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Guid[] FIHIMOPIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly byte[] ENFFNAGLFCA;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25EA4F0", Offset = "0x25E8CF0", VA = "0x1825EA4F0")]
	public BIPFKHLFLDC(FGHDNNJFCIJ.DLBNCGMFICJ DDIAMMMLKHB, [NotNull] Guid[] LAHKMFJEJEF, byte[] LCPCMCBOFNJ, bool NLHEBLHMJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E165A0", Offset = "0x4E14DA0", VA = "0x184E165A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class ACBKEOPIMCG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A790", Offset = "0x1F78F90", VA = "0x181F7A790", Slot = "4")]
	public void MIFKMJLJFJF(T LMJMILCCPPB, IDictionary<object, object> JIJMHNDPFCA, bool GFFJOOMPOMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MLLGOKJIOGC(T LMJMILCCPPB, IDictionary<object, object> JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T GPGJANKJBGF(IDictionary<object, object> JIJMHNDPFCA);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A580", Offset = "0x1F78D80", VA = "0x181F7A580", Slot = "7")]
	public bool ELCFBFDOHNF(IDictionary<object, object> JIJMHNDPFCA, out T OKJNAIDIPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
	protected ACBKEOPIMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MPDFKEHFJBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool LKKHIAJDGJB(int PKDPAEEKEMG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool DOGKKFFGKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly IBFBECALIAA JCJEICGMLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly CancellationToken IFJFPECIHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CancellationToken DKOACIGFHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly LKKHIAJDGJB MLJLLKHCKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly CancellationTokenSource CHLFONJNNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly CancellationTokenSource BMMNJPPPKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly int DIDAKFOGHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool JJBJGMHKPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CancellationToken DFDJMHIOMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DDD0", Offset = "0x4E1C5D0", VA = "0x184E1DDD0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AGFCFBKKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4E1DC70", Offset = "0x4E1C470", VA = "0x184E1DC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DDF0", Offset = "0x4E1C5F0", VA = "0x184E1DDF0")]
	public MPDFKEHFJBC(IBFBECALIAA NPIHCMHDBGO, CancellationToken IFJFPECIHDI, [Optional] LKKHIAJDGJB MLJLLKHCKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C567F0", Offset = "0x2C54FF0", VA = "0x182C567F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DCC0", Offset = "0x4E1C4C0", VA = "0x184E1DCC0")]
	private void CECNAIKEINK(GNGELPCDOEB KPAOENOILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DD70", Offset = "0x4E1C570", VA = "0x184E1DD70")]
	protected void PNBGOJKFDHH(int POCKMPKGGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DD50", Offset = "0x4E1C550", VA = "0x184E1DD50", Slot = "5")]
	protected virtual void KJAENMBELGH(int POCKMPKGGEF)
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
