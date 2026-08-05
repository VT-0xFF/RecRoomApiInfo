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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public FICNMLEDEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE660", Offset = "0x5CECE60", VA = "0x185CEE660")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CF11E0", Offset = "0x5CEF9E0", VA = "0x185CF11E0", Slot = "5")]
	protected override void BOEHPCBKFHF(PDIFMBALDGG NJAIIGFCHNG, IDictionary<object, object> PJDKPCLOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CF06C0", Offset = "0x5CEEEC0", VA = "0x185CF06C0", Slot = "6")]
	public override PDIFMBALDGG ADHMOLAJGDE(IDictionary<object, object> PJDKPCLOECB)
	{
		return default(PDIFMBALDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1880", Offset = "0x5CF0080", VA = "0x185CF1880")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BCF4E0", Offset = "0x4BCDCE0", VA = "0x184BCF4E0")]
		public BOPHDJJDEAK(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE92D0", Offset = "0x5CE7AD0", VA = "0x185CE92D0")]
		public bool FMLLLJFHODI(BOPHDJJDEAK IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9210", Offset = "0x5CE7A10", VA = "0x185CE9210", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9330", Offset = "0x5CE7B30", VA = "0x185CE9330", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x3909E00", Offset = "0x3908600", VA = "0x183909E00")]
		public static LFGHCEFMKAE<T> HPFBKDEDFHN(PDIFMBALDGG HHBOHBLDPFH, Func<byte[], T> ICNDBPGEOLG)
		{
			return default(LFGHCEFMKAE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x390A070", Offset = "0x3908870", VA = "0x18390A070")]
		public LFGHCEFMKAE(NMPJLJJBDGM ECCLDBENPJJ, Guid[] IBPHEICOGFM, T PLNNMJAODIH, bool LFNNBOOOKNA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3909F90", Offset = "0x3908790", VA = "0x183909F90", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public EKPIGKDBKPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5CED940", Offset = "0x5CEC140", VA = "0x185CED940")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5CED990", Offset = "0x5CEC190", VA = "0x185CED990")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public FMKAGNLDFHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5CEE720", Offset = "0x5CECF20", VA = "0x185CEE720")]
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
			[Cpp2IlInjected.Address(RVA = "0x5CEF640", Offset = "0x5CEDE40", VA = "0x185CEF640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5CEFE80", Offset = "0x5CEE680", VA = "0x185CEFE80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public BKCGINOOMMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5CE90A0", Offset = "0x5CE78A0", VA = "0x185CE90A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5CF3400", Offset = "0x5CF1C00", VA = "0x185CF3400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PDIFMBALDGG> FMPOGKBDDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5CF3210", Offset = "0x5CF1A10", VA = "0x185CF3210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5CF3070", Offset = "0x5CF1870", VA = "0x185CF3070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3450", Offset = "0x5CF1C50", VA = "0x185CF3450")]
		public NJONJANBKGK(FFCBBGPGJAC MGFGMMCKOEM, string OOHFFPKEBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5CF32B0", Offset = "0x5CF1AB0", VA = "0x185CF32B0")]
		[AsyncStateMachine(typeof(HDNPFJKDKOO))]
		public Task<PDIFMBALDGG> FOEONFJPPGF(CancellationToken OHJGLBPIBBN, TimeSpan EIPFKPHACBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3160", Offset = "0x5CF1960", VA = "0x185CF3160")]
		public void FJHHJGOGGGN(PDIFMBALDGG NJAIIGFCHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3110", Offset = "0x5CF1910", VA = "0x185CF3110", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2F40", Offset = "0x5CF1740", VA = "0x185CF2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CF1E00", Offset = "0x5CF0600", VA = "0x185CF1E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2730", Offset = "0x5CF0F30", VA = "0x185CF2730", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE88C0", Offset = "0x5CE70C0", VA = "0x185CE88C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8C70", Offset = "0x5CE7470", VA = "0x185CE8C70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEDD10", Offset = "0x5CEC510", VA = "0x185CEDD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE610", Offset = "0x5CECE10", VA = "0x185CEE610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEEB40", Offset = "0x5CED340", VA = "0x185CEEB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF5F0", Offset = "0x5CEDDF0", VA = "0x185CEF5F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CF19D0", Offset = "0x5CF01D0", VA = "0x185CF19D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1DB0", Offset = "0x5CF05B0", VA = "0x185CF1DB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5CF4150", Offset = "0x5CF2950", VA = "0x185CF4150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5CF42C0", Offset = "0x5CF2AC0", VA = "0x185CF42C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public IAJGLBFHNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0580", Offset = "0x5CEED80", VA = "0x185CF0580")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEE900", Offset = "0x5CED100", VA = "0x185CEE900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x35F1890", Offset = "0x35F0090", VA = "0x1835F1890", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5CE8FD0", Offset = "0x5CE77D0", VA = "0x185CE8FD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7420", Offset = "0x7F5C20", VA = "0x1807F7420")]
		[DebuggerHidden]
		public BDPKPIOJPBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8CC0", Offset = "0x5CE74C0", VA = "0x185CE8CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8F90", Offset = "0x5CE7790", VA = "0x185CE8F90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8EE0", Offset = "0x5CE76E0", VA = "0x185CE8EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(NMPJLJJBDGM, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8EE0", Offset = "0x5CE76E0", VA = "0x185CE8EE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public MBCFHLECHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2780", Offset = "0x5CF0F80", VA = "0x185CF2780")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CF27C0", Offset = "0x5CF0FC0", VA = "0x185CF27C0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2810", Offset = "0x5CF1010", VA = "0x185CF2810")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public HIEIFDBCAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5CEFED0", Offset = "0x5CEE6D0", VA = "0x185CEFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public GGBIBDEBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE7F0", Offset = "0x5CECFF0", VA = "0x185CEE7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ADGEBEAABMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8570", Offset = "0x5CE6D70", VA = "0x185CE8570")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public GGOFMADEELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE890", Offset = "0x5CED090", VA = "0x185CEE890")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public MNMKFPKJJFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2DF0", Offset = "0x5CF15F0", VA = "0x185CF2DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public JANDEHPDIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1940", Offset = "0x5CF0140", VA = "0x185CF1940")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public NDLOOKOPKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2EE0", Offset = "0x5CF16E0", VA = "0x185CF2EE0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2E80", Offset = "0x5CF1680", VA = "0x185CF2E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public HJOMACECAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5CEFF70", Offset = "0x5CEE770", VA = "0x185CEFF70")]
		internal bool <ClearSliceIds>b__3(BOPHDJJDEAK stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0080", Offset = "0x5CEE880", VA = "0x185CF0080")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0300", Offset = "0x5CEEB00", VA = "0x185CF0300")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0010", Offset = "0x5CEE810", VA = "0x185CF0010")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CEC340", Offset = "0x5CEAB40", VA = "0x185CEC340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA450", Offset = "0x5CE8C50", VA = "0x185CEA450")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CED490", Offset = "0x5CEBC90", VA = "0x185CED490")]
	public DEBBKGCKOLK(FFCBBGPGJAC MGFGMMCKOEM, IHCGNEMANOG LIGPPBAMHKK, BEJFDGEIIJB HJJIEDMJDHE, [Optional] TimeSpan? CMOKMDIBMMC, [Optional] OMBIBLCMAGA MNPLFGIMKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36A4DE0", Offset = "0x36A35E0", VA = "0x1836A4DE0")]
	public static DEBBKGCKOLK PENMFEHONLB<TNetworking>(TNetworking FMJNCAAMIPB, [Optional] TimeSpan? CMOKMDIBMMC, [Optional] OMBIBLCMAGA MNPLFGIMKOC) where TNetworking : FFCBBGPGJAC, IHCGNEMANOG, BEJFDGEIIJB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCD0", Offset = "0x5CEB4D0", VA = "0x185CECCD0")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9FE0", Offset = "0x5CE87E0", VA = "0x185CE9FE0")]
	private byte BGOJNGDADEO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CECDC0", Offset = "0x5CEB5C0", VA = "0x185CECDC0")]
	private TimeSpan PKKBDCDOKAN(TimeSpan? CMOKMDIBMMC, int ELMOPGMOLHE = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36A40B0", Offset = "0x36A28B0", VA = "0x1836A40B0")]
	public bool DFOAAEPJODP<T>(T ALFKNJNOKAI, Func<T, byte[]> PKCBLFIFNIL, bool LFNNBOOOKNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAD40", Offset = "0x5CE9540", VA = "0x185CEAD40")]
	public bool DFOAAEPJODP(byte[] ALFKNJNOKAI, int HNNAMAALCJD, bool LFNNBOOOKNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40")]
	private static string CHGJBNDKOII(string NJAIIGFCHNG, string NNPLNBENDGM = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBAF0", Offset = "0x5CEA2F0", VA = "0x185CEBAF0")]
	[AsyncStateMachine(typeof(KCHBDAFAMOO))]
	public Task<PDIFMBALDGG> FKAOMKOIBNF(CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? CMOKMDIBMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBD30", Offset = "0x5CEA530", VA = "0x185CEBD30")]
	[AsyncStateMachine(typeof(AKPLPFGLIIO))]
	public Task<Guid> ICKGCNCLEKF(Guid IPADFOIAMOF, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36A45B0", Offset = "0x36A2DB0", VA = "0x1836A45B0")]
	[AsyncStateMachine(typeof(LBOHDIAGMDD))]
	public Task<LFGHCEFMKAE<T>> IFCEOGJAKIG<T>(T ALFKNJNOKAI, Func<T, byte[]> PKCBLFIFNIL, Func<byte[], T> ICNDBPGEOLG, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBEC0", Offset = "0x5CEA6C0", VA = "0x185CEBEC0")]
	[AsyncStateMachine(typeof(FBDILHFADMP))]
	public Task<PDIFMBALDGG> IFCEOGJAKIG(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CED0D0", Offset = "0x5CEB8D0", VA = "0x185CED0D0")]
	[AsyncStateMachine(typeof(GJAGMEKFONH))]
	private Task<PDIFMBALDGG> PMJPAEEEOOD(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, OHPHHOAEIIK OCEALIIFLKM, OHPHHOAEIIK OOHPFEBLGMA, TimeSpan? CMOKMDIBMMC, Stopwatch LCJCDPMOPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB960", Offset = "0x5CEA160", VA = "0x185CEB960")]
	[AsyncStateMachine(typeof(JPDFPOOFLNO))]
	private Task<PDIFMBALDGG> EOMFCCEDBIE(byte[] ALFKNJNOKAI, CancellationToken OHJGLBPIBBN, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, [Optional] TimeSpan? EIPFKPHACBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC7D0", Offset = "0x5CEAFD0", VA = "0x185CEC7D0")]
	[AsyncStateMachine(typeof(GIDOPNKJDGJ))]
	public Task MJPOKHCCOBC(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task> CPBIPBGMGDE, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36A4930", Offset = "0x36A3130", VA = "0x1836A4930")]
	[AsyncStateMachine(typeof(LLOBEDFBOFB))]
	public Task<T> MJPOKHCCOBC<T>(CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task<T>> CPBIPBGMGDE, [Optional] OHPHHOAEIIK OCEALIIFLKM, [Optional] OHPHHOAEIIK OOHPFEBLGMA, int PCEAJDNOLME = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36A4160", Offset = "0x36A2960", VA = "0x1836A4160")]
	[AsyncStateMachine(typeof(LEALHFCGBMC))]
	private Task<(bool, T)> EBMAPOFGKOB<T>(Guid ACBMLODKCOC, CancellationToken PJNOBOOMKAP, Func<CancellationToken, Task<T>> CPBIPBGMGDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC050", Offset = "0x5CEA850", VA = "0x185CEC050")]
	[IteratorStateMachine(typeof(BDPKPIOJPBH))]
	internal static IEnumerable<(NMPJLJJBDGM, Guid)> JDFCHCMGDNL(NMPJLJJBDGM FMHPPNIDEFA, Guid[] HBHBEIOEFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA4F0", Offset = "0x5CE8CF0", VA = "0x185CEA4F0")]
	public void DFKEAOCFBOI(byte GGMHJDKPIFO, int BMOJJBEGBCD, object CFHPDIPNEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC0E0", Offset = "0x5CEA8E0", VA = "0x185CEC0E0")]
	public Guid JJHDDEGBADE(Guid CKOGPKNJEFI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CED000", Offset = "0x5CEB800", VA = "0x185CED000")]
	internal static int PMIFCIGAHPA(NMPJLJJBDGM ECCLDBENPJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB330", Offset = "0x5CE9B30", VA = "0x185CEB330")]
	public bool DHHOCFKNHNI(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC3E0", Offset = "0x5CEABE0", VA = "0x185CEC3E0")]
	public void MCDIGOEBLAC(NMPJLJJBDGM ECCLDBENPJJ, Guid ACBMLODKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBC70", Offset = "0x5CEA470", VA = "0x185CEBC70")]
	private void FPICEJCHANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9FF0", Offset = "0x5CE87F0", VA = "0x185CE9FF0")]
	internal (NMPJLJJBDGM, Guid[]) BICPHOHCBGD(bool PJOMEBDHMCD = false)
	{
		return default((NMPJLJJBDGM, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB820", Offset = "0x5CEA020", VA = "0x185CEB820")]
	private HashSet<Guid> EFINNFNHOPJ(NMPJLJJBDGM ECCLDBENPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9360", Offset = "0x5CE7B60", VA = "0x185CE9360")]
	private void AJIAHCIGEDG(NMPJLJJBDGM ECCLDBENPJJ, Guid DGFBLJMJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC940", Offset = "0x5CEB140", VA = "0x185CEC940")]
	private void OKNJJBEODBJ(NMPJLJJBDGM ECCLDBENPJJ, Guid DGFBLJMJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CECC20", Offset = "0x5CEB420", VA = "0x185CECC20")]
	public static Func<Guid, bool> PAEGBFIHDME(Guid DGFBLJMJMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBC80", Offset = "0x5CEA480", VA = "0x185CEBC80")]
	public static Func<Guid, bool> GPCDEGPANOD(Guid DGFBLJMJMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9ED0", Offset = "0x5CE86D0", VA = "0x185CE9ED0")]
	public void BDNHFKPBIFD(NMPJLJJBDGM ECCLDBENPJJ, Guid AJKDGHOLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9520", Offset = "0x5CE7D20", VA = "0x185CE9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x85E8F0", Offset = "0x85D0F0", VA = "0x18085E8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9020", Offset = "0x5CE7820", VA = "0x185CE9020")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE88B0", Offset = "0x5CE70B0", VA = "0x185CE88B0")]
		public AJEAFFIGPFC(Guid BAOCEKHOGAH, int LNMOFGJNNDL, int IHIGDKIFKDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8720", Offset = "0x5CE6F20", VA = "0x185CE8720")]
		public static byte[] HHDOHEHKDKI(AJEAFFIGPFC NJAIIGFCHNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CE85E0", Offset = "0x5CE6DE0", VA = "0x185CE85E0")]
		public static AJEAFFIGPFC ADHMOLAJGDE(byte[] CDDAIIMDJCN)
		{
			return default(AJEAFFIGPFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CE86A0", Offset = "0x5CE6EA0", VA = "0x185CE86A0")]
		private static byte[] FGNGBLPBHMN(int GBIDHHJLPLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8800", Offset = "0x5CE7000", VA = "0x185CE8800")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CF3AE0", Offset = "0x5CF22E0", VA = "0x185CF3AE0")]
	public OHIJGFNMOOI(Guid BAOCEKHOGAH, DEBBKGCKOLK LAFNOIFEIII, BEJFDGEIIJB FMJNCAAMIPB, CancellationToken PJNOBOOMKAP, [Optional] IDDMACIAGKD KBKCPADEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3770", Offset = "0x5CF1F70", VA = "0x185CF3770", Slot = "5")]
	protected override void EODJGGCGDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3940", Offset = "0x5CF2140", VA = "0x185CF3940", Slot = "6")]
	protected override void GMJEFIIGNJC(int FMINKJBIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3550", Offset = "0x5CF1D50", VA = "0x185CF3550")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CF40F0", Offset = "0x5CF28F0", VA = "0x185CF40F0")]
	public PDIFMBALDGG(DEBBKGCKOLK.NMPJLJJBDGM ECCLDBENPJJ, [NotNull] Guid[] IBPHEICOGFM, byte[] PLNNMJAODIH, bool LFNNBOOOKNA, byte ICKJKBDBLPA, byte KDMLDPCIAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3D40", Offset = "0x5CF2540", VA = "0x185CF3D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3B40", Offset = "0x5CF2340", VA = "0x185CF3B40")]
	private static void JLPCJBIGHOB(byte[] PLNNMJAODIH, StringBuilder IDIEBAILNNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class FAMACMKFGLF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34B5A80", Offset = "0x34B4280", VA = "0x1834B5A80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34B5B20", Offset = "0x34B4320", VA = "0x1834B5B20", Slot = "7")]
	public bool MNOKCDLOOIM(IDictionary<object, object> PJDKPCLOECB, out T BIHKHLGLJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CF2AB0", Offset = "0x5CF12B0", VA = "0x185CF2AB0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OFBKNGDIBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2850", Offset = "0x5CF1050", VA = "0x185CF2850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2AD0", Offset = "0x5CF12D0", VA = "0x185CF2AD0")]
	public MGADGGGHNNB(BEJFDGEIIJB FMJNCAAMIPB, CancellationToken PJNOBOOMKAP, [Optional] IDDMACIAGKD KBKCPADEFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CF29A0", Offset = "0x5CF11A0", VA = "0x185CF29A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF29C0", Offset = "0x5CF11C0", VA = "0x185CF29C0", Slot = "5")]
	protected virtual void EODJGGCGDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF28A0", Offset = "0x5CF10A0", VA = "0x185CF28A0")]
	private void AMPCLPPIHNL(ODNOGOADEAI NEDCFKCIJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2940", Offset = "0x5CF1140", VA = "0x185CF2940")]
	protected void BNLOJEFHPJB(int FMINKJBIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2A90", Offset = "0x5CF1290", VA = "0x185CF2A90", Slot = "6")]
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
