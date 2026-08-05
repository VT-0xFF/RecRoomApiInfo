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
internal class ICCFJCNLEFG : global::FAMACMKFGLF<PDIFMBALDGG>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FICNMLEDEKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FICNMLEDEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C1B830", Offset = "0x5C1A830", VA = "0x185C1B830")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] MKJFFAPEGBC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ICCFJCNLEFG KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E3B0", Offset = "0x5C1D3B0", VA = "0x185C1E3B0", Slot = "5")]
	protected override void BOEHPCBKFHF(PDIFMBALDGG NJAIIGFCHNG, IDictionary<object, object> PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C1D890", Offset = "0x5C1C890", VA = "0x185C1D890", Slot = "6")]
	public override PDIFMBALDGG ADHMOLAJGDE(IDictionary<object, object> PJDKPCLOECB)
	{
		return default(PDIFMBALDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C1EA50", Offset = "0x5C1DA50", VA = "0x185C1EA50")]
	public ICCFJCNLEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DEBBKGCKOLK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string OMBIBLCMAGA([NotNull] byte[] PLNNMJAODIH);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum NMPJLJJBDGM : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct BOPHDJJDEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly NMPJLJJBDGM GHJGFMPIAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid KGIMDBOGFBK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46DC2B0", Offset = "0x46DB2B0", VA = "0x1846DC2B0")]
		public BOPHDJJDEAK(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C164A0", Offset = "0x5C154A0", VA = "0x185C164A0")]
		public bool FMLLLJFHODI(BOPHDJJDEAK IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C163E0", Offset = "0x5C153E0", VA = "0x185C163E0", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C16500", Offset = "0x5C15500", VA = "0x185C16500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct LFGHCEFMKAE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool BPBGODCBHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly NMPJLJJBDGM GHJGFMPIAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] MHGABHGBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T HHPDNNAJJDO;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2AA22A0", Offset = "0x2AA12A0", VA = "0x182AA22A0")]
		public static LFGHCEFMKAE<T> HPFBKDEDFHN(PDIFMBALDGG HHBOHBLDPFH, Func<byte[], T> ICNDBPGEOLG)
		{
			return default(LFGHCEFMKAE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2510", Offset = "0x2AA1510", VA = "0x182AA2510")]
		public LFGHCEFMKAE(NMPJLJJBDGM ECCLDBENPJJ, Guid[] IBPHEICOGFM, T PLNNMJAODIH, bool LFNNBOOOKNA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2430", Offset = "0x2AA1430", VA = "0x182AA2430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NJONJANBKGK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EKPIGKDBKPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<PDIFMBALDGG> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public NJONJANBKGK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public EKPIGKDBKPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5C1AB10", Offset = "0x5C19B10", VA = "0x185C1AB10")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5C1AB60", Offset = "0x5C19B60", VA = "0x185C1AB60")]
			internal BFJLENBLJOH <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FMKAGNLDFHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public INIMCJMPGMD.GCEKEDDJLMO itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public FMKAGNLDFHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5C1B8F0", Offset = "0x5C1A8F0", VA = "0x185C1B8F0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct HDNPFJKDKOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<PDIFMBALDGG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public NJONJANBKGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private EKPIGKDBKPJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<PDIFMBALDGG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5C1C810", Offset = "0x5C1B810", VA = "0x185C1C810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5C1D050", Offset = "0x5C1C050", VA = "0x185C1D050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BKCGINOOMMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public NMPJLJJBDGM sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public BKCGINOOMMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5C16270", Offset = "0x5C15270", VA = "0x185C16270")]
			internal bool <ClearSlice>b__0(PDIFMBALDGG bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly FFCBBGPGJAC MGFGMMCKOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string OOHFFPKEBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<PDIFMBALDGG> MLLOIHMOMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(INIMCJMPGMD.GCEKEDDJLMO itemType, long totalStopwatchTicks)> GCFAPBDBCEJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CEBGHGDFBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5C205D0", Offset = "0x5C1F5D0", VA = "0x185C205D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PDIFMBALDGG> FMPOGKBDDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5C203E0", Offset = "0x5C1F3E0", VA = "0x185C203E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5C20240", Offset = "0x5C1F240", VA = "0x185C20240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5C20620", Offset = "0x5C1F620", VA = "0x185C20620")]
		public NJONJANBKGK(FFCBBGPGJAC MGFGMMCKOEM, string OOHFFPKEBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5C20480", Offset = "0x5C1F480", VA = "0x185C20480")]
		[AsyncStateMachine(typeof(HDNPFJKDKOO))]
		public Task<PDIFMBALDGG> FOEONFJPPGF(CancellationToken OHJGLBPIBBN, TimeSpan EIPFKPHACBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5C20330", Offset = "0x5C1F330", VA = "0x185C20330")]
		public void FJHHJGOGGGN(PDIFMBALDGG NJAIIGFCHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5C202E0", Offset = "0x5C1F2E0", VA = "0x185C202E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5C20110", Offset = "0x5C1F110", VA = "0x185C20110")]
		public void BDNHFKPBIFD(NMPJLJJBDGM ECCLDBENPJJ, Guid DGFBLJMJMFI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KCHBDAFAMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PDIFMBALDGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5C1EFD0", Offset = "0x5C1DFD0", VA = "0x185C1EFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5C1F900", Offset = "0x5C1E900", VA = "0x185C1F900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AKPLPFGLIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<LFGHCEFMKAE<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5C15A90", Offset = "0x5C14A90", VA = "0x185C15A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5C15E40", Offset = "0x5C14E40", VA = "0x185C15E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FBDILHFADMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<PDIFMBALDGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5C1AEE0", Offset = "0x5C19EE0", VA = "0x185C1AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5C1B7E0", Offset = "0x5C1A7E0", VA = "0x185C1B7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MNLPKFAEDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MNLPKFAEDHG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GJAGMEKFONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<PDIFMBALDGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private MNLPKFAEDHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private MGADGGGHNNB <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5C1BD10", Offset = "0x5C1AD10", VA = "0x185C1BD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5C1C7C0", Offset = "0x5C1B7C0", VA = "0x185C1C7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JPDFPOOFLNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<PDIFMBALDGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<PDIFMBALDGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5C1EBA0", Offset = "0x5C1DBA0", VA = "0x185C1EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5C1EF80", Offset = "0x5C1DF80", VA = "0x185C1EF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IAJGLBFHNLL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public IAJGLBFHNLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5C21320", Offset = "0x5C20320", VA = "0x185C21320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5C21490", Offset = "0x5C20490", VA = "0x185C21490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public IAJGLBFHNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D750", Offset = "0x5C1C750", VA = "0x185C1D750")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GIDOPNKJDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public DEBBKGCKOLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OHPHHOAEIIK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public OHPHHOAEIIK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5C1BAD0", Offset = "0x5C1AAD0", VA = "0x185C1BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BDPKPIOJPBH : IEnumerable<(NMPJLJJBDGM, Guid)>, IEnumerable, IEnumerator<(NMPJLJJBDGM, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (NMPJLJJBDGM sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private NMPJLJJBDGM sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public NMPJLJJBDGM <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private NMPJLJJBDGM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (NMPJLJJBDGM, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x26E8A00", Offset = "0x26E7A00", VA = "0x1826E8A00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((NMPJLJJBDGM, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5C161A0", Offset = "0x5C151A0", VA = "0x185C161A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B20", Offset = "0xAA4B20", VA = "0x180AA5B20")]
		[DebuggerHidden]
		public BDPKPIOJPBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5C15E90", Offset = "0x5C14E90", VA = "0x185C15E90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5C16160", Offset = "0x5C15160", VA = "0x185C16160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5C160B0", Offset = "0x5C150B0", VA = "0x185C160B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(NMPJLJJBDGM, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5C160B0", Offset = "0x5C150B0", VA = "0x185C160B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MBCFHLECHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MBCFHLECHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5C1F950", Offset = "0x5C1E950", VA = "0x185C1F950")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5C1F990", Offset = "0x5C1E990", VA = "0x185C1F990")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5C1F9E0", Offset = "0x5C1E9E0", VA = "0x185C1F9E0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HIEIFDBCAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public NMPJLJJBDGM sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HIEIFDBCAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D0A0", Offset = "0x5C1C0A0", VA = "0x185C1D0A0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GGBIBDEBJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public NMPJLJJBDGM sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GGBIBDEBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5C1B9C0", Offset = "0x5C1A9C0", VA = "0x185C1B9C0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ADGEBEAABMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ADGEBEAABMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C15740", Offset = "0x5C14740", VA = "0x185C15740")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GGOFMADEELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public GGOFMADEELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5C1BA60", Offset = "0x5C1AA60", VA = "0x185C1BA60")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MNMKFPKJJFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public MNMKFPKJJFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5C1FFC0", Offset = "0x5C1EFC0", VA = "0x185C1FFC0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JANDEHPDIBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JANDEHPDIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5C1EB10", Offset = "0x5C1DB10", VA = "0x185C1EB10")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NDLOOKOPKFG
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

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NDLOOKOPKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5C200B0", Offset = "0x5C1F0B0", VA = "0x185C200B0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5C20050", Offset = "0x5C1F050", VA = "0x185C20050")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HJOMACECAEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public HJOMACECAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D140", Offset = "0x5C1C140", VA = "0x185C1D140")]
		internal bool <ClearSliceIds>b__3(BOPHDJJDEAK stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D250", Offset = "0x5C1C250", VA = "0x185C1D250")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D4D0", Offset = "0x5C1C4D0", VA = "0x185C1D4D0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5C1D1E0", Offset = "0x5C1C1E0", VA = "0x185C1D1E0")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly OMBIBLCMAGA PHGAFCGJFBB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable LKFCEHBIPJF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DBIKEOAHPOD LIFDPIFLCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NJONJANBKGK HMBIKDIAGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FFCBBGPGJAC MGFGMMCKOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IHCGNEMANOG LIGPPBAMHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BEJFDGEIIJB HJJIEDMJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OMBIBLCMAGA JKGBJBJEJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan IGDJPHKACDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan PEDMHJKAHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte AFJPDGFGEAD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly NMPJLJJBDGM[] LDJEABPGHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] BDPJKCFFNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<BOPHDJJDEAK> JDHLKAMAJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (NMPJLJJBDGM combinedSliceType, Guid[] sliceTypeIds)? KLJMMJEPJDF;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<PDIFMBALDGG> AEDIBBNJALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C19510", Offset = "0x5C18510", VA = "0x185C19510")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C17620", Offset = "0x5C16620", VA = "0x185C17620")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C1A660", Offset = "0x5C19660", VA = "0x185C1A660")]
	public DEBBKGCKOLK(FFCBBGPGJAC MGFGMMCKOEM, IHCGNEMANOG LIGPPBAMHKK, BEJFDGEIIJB HJJIEDMJDHE, [Optional] TimeSpan? CMOKMDIBMMC, [Optional] OMBIBLCMAGA MNPLFGIMKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27B6FF0", Offset = "0x27B5FF0", VA = "0x1827B6FF0")]
	public static DEBBKGCKOLK PENMFEHONLB<TNetworking>(TNetworking FMJNCAAMIPB, [Optional] TimeSpan? CMOKMDIBMMC, [Optional] OMBIBLCMAGA MNPLFGIMKOC) where TNetworking : FFCBBGPGJAC, IHCGNEMANOG, BEJFDGEIIJB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C19EA0", Offset = "0x5C18EA0", VA = "0x185C19EA0")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C171B0", Offset = "0x5C161B0", VA = "0x185C171B0")]
	private byte BGOJNGDADEO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C19F90", Offset = "0x5C18F90", VA = "0x185C19F90")]
	private TimeSpan PKKBDCDOKAN(TimeSpan? CMOKMDIBMMC, int ELMOPGMOLHE = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27B62C0", Offset = "0x27B52C0", VA = "0x1827B62C0")]
	public bool DFOAAEPJODP<T>(T ALFKNJNOKAI, Func<T, byte[]> PKCBLFIFNIL, bool LFNNBOOOKNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C17F10", Offset = "0x5C16F10", VA = "0x185C17F10")]
	public bool DFOAAEPJODP(byte[] ALFKNJNOKAI, int HNNAMAALCJD, bool LFNNBOOOKNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040")]
	private static string CHGJBNDKOII(string NJAIIGFCHNG, string NNPLNBENDGM = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C18CC0", Offset = "0x5C17CC0", VA = "0x185C18CC0")]
	[AsyncStateMachine(typeof(KCHBDAFAMOO))]
	public Task<PDIFMBALDGG> FKAOMKOIBNF(CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? CMOKMDIBMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C18F00", Offset = "0x5C17F00", VA = "0x185C18F00")]
	[AsyncStateMachine(typeof(AKPLPFGLIIO))]
	public Task<Guid> ICKGCNCLEKF(Guid IPADFOIAMOF, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27B67C0", Offset = "0x27B57C0", VA = "0x1827B67C0")]
	[AsyncStateMachine(typeof(LBOHDIAGMDD))]
	public Task<LFGHCEFMKAE<T>> IFCEOGJAKIG<T>(T ALFKNJNOKAI, Func<T, byte[]> PKCBLFIFNIL, Func<byte[], T> ICNDBPGEOLG, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C19090", Offset = "0x5C18090", VA = "0x185C19090")]
	[AsyncStateMachine(typeof(FBDILHFADMP))]
	public Task<PDIFMBALDGG> IFCEOGJAKIG(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C1A2A0", Offset = "0x5C192A0", VA = "0x185C1A2A0")]
	[AsyncStateMachine(typeof(GJAGMEKFONH))]
	private Task<PDIFMBALDGG> PMJPAEEEOOD(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, OHPHHOAEIIK OCEALIIFLKM, OHPHHOAEIIK OOHPFEBLGMA, TimeSpan? CMOKMDIBMMC, Stopwatch LCJCDPMOPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C18B30", Offset = "0x5C17B30", VA = "0x185C18B30")]
	[AsyncStateMachine(typeof(JPDFPOOFLNO))]
	private Task<PDIFMBALDGG> EOMFCCEDBIE(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C199A0", Offset = "0x5C189A0", VA = "0x185C199A0")]
	[AsyncStateMachine(typeof(GIDOPNKJDGJ))]
	public Task MJPOKHCCOBC(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task> CPBIPBGMGDE, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27B6B40", Offset = "0x27B5B40", VA = "0x1827B6B40")]
	[AsyncStateMachine(typeof(LLOBEDFBOFB))]
	public Task<T> MJPOKHCCOBC<T>(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task<T>> CPBIPBGMGDE, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27B6370", Offset = "0x27B5370", VA = "0x1827B6370")]
	[AsyncStateMachine(typeof(LEALHFCGBMC))]
	private Task<(bool, T)> EBMAPOFGKOB<T>(Guid ACBMLODKCOC, CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task<T>> CPBIPBGMGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C19220", Offset = "0x5C18220", VA = "0x185C19220")]
	[IteratorStateMachine(typeof(BDPKPIOJPBH))]
	internal static IEnumerable<(NMPJLJJBDGM, Guid)> JDFCHCMGDNL(NMPJLJJBDGM FMHPPNIDEFA, Guid[] HBHBEIOEFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C176C0", Offset = "0x5C166C0", VA = "0x185C176C0")]
	public void DFKEAOCFBOI(byte GGMHJDKPIFO, int BMOJJBEGBCD, object CFHPDIPNEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C192B0", Offset = "0x5C182B0", VA = "0x185C192B0")]
	public Guid JJHDDEGBADE(Guid CKOGPKNJEFI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C1A1D0", Offset = "0x5C191D0", VA = "0x185C1A1D0")]
	internal static int PMIFCIGAHPA(NMPJLJJBDGM ECCLDBENPJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C18500", Offset = "0x5C17500", VA = "0x185C18500")]
	public bool DHHOCFKNHNI(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C195B0", Offset = "0x5C185B0", VA = "0x185C195B0")]
	public void MCDIGOEBLAC(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C18E40", Offset = "0x5C17E40", VA = "0x185C18E40")]
	private void FPICEJCHANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C171C0", Offset = "0x5C161C0", VA = "0x185C171C0")]
	internal (NMPJLJJBDGM, Guid[]) BICPHOHCBGD(bool PJOMEBDHMCD = false)
	{
		return default((NMPJLJJBDGM, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C189F0", Offset = "0x5C179F0", VA = "0x185C189F0")]
	private HashSet<Guid> EFINNFNHOPJ(NMPJLJJBDGM ECCLDBENPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C16530", Offset = "0x5C15530", VA = "0x185C16530")]
	private void AJIAHCIGEDG(NMPJLJJBDGM ECCLDBENPJJ, Guid DGFBLJMJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C19B10", Offset = "0x5C18B10", VA = "0x185C19B10")]
	private void OKNJJBEODBJ(NMPJLJJBDGM ECCLDBENPJJ, Guid DGFBLJMJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C19DF0", Offset = "0x5C18DF0", VA = "0x185C19DF0")]
	public static Func<Guid, bool> PAEGBFIHDME(Guid DGFBLJMJMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C18E50", Offset = "0x5C17E50", VA = "0x185C18E50")]
	public static Func<Guid, bool> GPCDEGPANOD(Guid DGFBLJMJMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C170A0", Offset = "0x5C160A0", VA = "0x185C170A0")]
	public void BDNHFKPBIFD(NMPJLJJBDGM ECCLDBENPJJ, Guid AJKDGHOLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C166F0", Offset = "0x5C156F0", VA = "0x185C166F0")]
	public void ANIDLECHMFI(NMPJLJJBDGM ECCLDBENPJJ, Func<Guid, bool> MMAGAAJJGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BFJLENBLJOH : HJPEADGBBBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(INIMCJMPGMD.GCEKEDDJLMO itemType, long totalStopwatchTicks)> JAOAHIGPBBM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(INIMCJMPGMD.GCEKEDDJLMO itemType, long totalStopwatchTicks)> OHEFFAKPEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x650E20", Offset = "0x64FE20", VA = "0x180650E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5C161F0", Offset = "0x5C151F0", VA = "0x185C161F0")]
	public BFJLENBLJOH(TimeSpan EIPFKPHACBC, List<(INIMCJMPGMD.GCEKEDDJLMO itemType, long totalStopwatchTicks)> JAOAHIGPBBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OHIJGFNMOOI : MGADGGGHNNB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct AJEAFFIGPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid NIABBEBKBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int KEPOBBMDMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int LCBIPPDCFHP;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5C15A80", Offset = "0x5C14A80", VA = "0x185C15A80")]
		public AJEAFFIGPFC(Guid BAOCEKHOGAH, int LNMOFGJNNDL, int IHIGDKIFKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5C158F0", Offset = "0x5C148F0", VA = "0x185C158F0")]
		public static byte[] HHDOHEHKDKI(AJEAFFIGPFC NJAIIGFCHNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5C157B0", Offset = "0x5C147B0", VA = "0x185C157B0")]
		public static AJEAFFIGPFC ADHMOLAJGDE(byte[] CDDAIIMDJCN)
		{
			return default(AJEAFFIGPFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5C15870", Offset = "0x5C14870", VA = "0x185C15870")]
		private static byte[] FGNGBLPBHMN(int GBIDHHJLPLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5C159D0", Offset = "0x5C149D0", VA = "0x185C159D0")]
		private static int OHOPMKBHBFJ(byte[] CJDJFGNOADI, int MMABPPDCBIB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid BAOCEKHOGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly DEBBKGCKOLK LAFNOIFEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool AMHONFGHGEN;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5C20CB0", Offset = "0x5C1FCB0", VA = "0x185C20CB0")]
	public OHIJGFNMOOI(Guid BAOCEKHOGAH, DEBBKGCKOLK LAFNOIFEIII, BEJFDGEIIJB FMJNCAAMIPB, CancellationToken PJNOBOOMKAP, [Optional] IDDMACIAGKD KBKCPADEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5C20940", Offset = "0x5C1F940", VA = "0x185C20940", Slot = "5")]
	protected override void EODJGGCGDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C20B10", Offset = "0x5C1FB10", VA = "0x185C20B10", Slot = "6")]
	protected override void GMJEFIIGNJC(int FMINKJBIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5C20720", Offset = "0x5C1F720", VA = "0x185C20720")]
	private void AEDIBBNJALB(PDIFMBALDGG MDCOKMKDOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct PDIFMBALDGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte CEGECPHGGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte ECABEFAJEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool BPBGODCBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly DEBBKGCKOLK.NMPJLJJBDGM GHJGFMPIAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] MHGABHGBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] HHPDNNAJJDO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C212C0", Offset = "0x5C202C0", VA = "0x185C212C0")]
	public PDIFMBALDGG(DEBBKGCKOLK.NMPJLJJBDGM ECCLDBENPJJ, [NotNull] Guid[] IBPHEICOGFM, byte[] PLNNMJAODIH, bool LFNNBOOOKNA, byte ICKJKBDBLPA, byte KDMLDPCIAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C20F10", Offset = "0x5C1FF10", VA = "0x185C20F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5C20D10", Offset = "0x5C1FD10", VA = "0x185C20D10")]
	private static void JLPCJBIGHOB(byte[] PLNNMJAODIH, StringBuilder IDIEBAILNNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class FAMACMKFGLF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25AC070", Offset = "0x25AB070", VA = "0x1825AC070", Slot = "4")]
	public void JCCONJEGAGM(T NJAIIGFCHNG, IDictionary<object, object> PJDKPCLOECB, bool JLKCFPEEEFP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void BOEHPCBKFHF(T NJAIIGFCHNG, IDictionary<object, object> PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T ADHMOLAJGDE(IDictionary<object, object> PJDKPCLOECB);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x25AC110", Offset = "0x25AB110", VA = "0x1825AC110", Slot = "7")]
	public bool MNOKCDLOOIM(IDictionary<object, object> PJDKPCLOECB, out T BIHKHLGLJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected FAMACMKFGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MGADGGGHNNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool IDDMACIAGKD(int MFHGCDADHEG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly BEJFDGEIIJB BMACDOJDALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken PJNOBOOMKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken BKELJLJEFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly IDDMACIAGKD KBKCPADEFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource GHHDBANIAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource IBGPINFMEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int CJLPMHBNMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool CKBNKOAAPGF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken DLBIMGFBCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5C1FC80", Offset = "0x5C1EC80", VA = "0x185C1FC80")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OFBKNGDIBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5C1FA20", Offset = "0x5C1EA20", VA = "0x185C1FA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FCA0", Offset = "0x5C1ECA0", VA = "0x185C1FCA0")]
	public MGADGGGHNNB(BEJFDGEIIJB FMJNCAAMIPB, CancellationToken PJNOBOOMKAP, [Optional] IDDMACIAGKD KBKCPADEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FB70", Offset = "0x5C1EB70", VA = "0x185C1FB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FB90", Offset = "0x5C1EB90", VA = "0x185C1FB90", Slot = "5")]
	protected virtual void EODJGGCGDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FA70", Offset = "0x5C1EA70", VA = "0x185C1FA70")]
	private void AMPCLPPIHNL(ODNOGOADEAI NEDCFKCIJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FB10", Offset = "0x5C1EB10", VA = "0x185C1FB10")]
	protected void BNLOJEFHPJB(int FMINKJBIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FC60", Offset = "0x5C1EC60", VA = "0x185C1FC60", Slot = "6")]
	protected virtual void GMJEFIIGNJC(int FMINKJBIOLL)
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
