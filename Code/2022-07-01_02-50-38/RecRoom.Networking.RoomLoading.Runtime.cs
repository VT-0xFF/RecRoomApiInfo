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
internal class GHHIMDGGAPI : global::MPAEMHOLHII<ELKJHLECFEE>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IOGNMOJJOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public IOGNMOJJOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F66620", Offset = "0x4F64E20", VA = "0x184F66620")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] LMNENBCEFOP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly GHHIMDGGAPI JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F61210", Offset = "0x4F5FA10", VA = "0x184F61210", Slot = "5")]
	protected override void EAPCOPFIOLD(ELKJHLECFEE BOBNBIKICDK, IDictionary<object, object> BPPCNFHJMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F60A10", Offset = "0x4F5F210", VA = "0x184F60A10", Slot = "6")]
	public override ELKJHLECFEE DMAKMKNNBAJ(IDictionary<object, object> BPPCNFHJMAA)
	{
		return default(ELKJHLECFEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4F61780", Offset = "0x4F5FF80", VA = "0x184F61780")]
	public GHHIMDGGAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IFJGNAONOGK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string KPBHKOJBKPJ([NotNull] byte[] MDKOIJJHDKB);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum HDLEBFHOHAK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct OIJILIEDFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly HDLEBFHOHAK AHGCGLJFABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly Guid KKEBILBNBLA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4369E30", Offset = "0x4368630", VA = "0x184369E30")]
		public OIJILIEDFMA(HDLEBFHOHAK MOAAIOLDOII, Guid LABJHJNAAJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4F67710", Offset = "0x4F65F10", VA = "0x184F67710")]
		public bool ANFHIHCOHAE(OIJILIEDFMA EFDJFLPIKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4F67770", Offset = "0x4F65F70", VA = "0x184F67770", Slot = "0")]
		public override bool Equals(object ALCFLDIFDGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4F67830", Offset = "0x4F66030", VA = "0x184F67830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OPMCGNCNGDN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly bool MGGPJFHDMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly HDLEBFHOHAK AHGCGLJFABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid[] ONFIIOMHFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T CNBJMCKIFAE;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2A48E90", Offset = "0x2A47690", VA = "0x182A48E90")]
		public static OPMCGNCNGDN<T> CHKOOBNMIJD(ELKJHLECFEE IBIIEEDHBLD, Func<byte[], T> JPCJAKKDFKC)
		{
			return default(OPMCGNCNGDN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A49270", Offset = "0x2A47A70", VA = "0x182A49270")]
		public OPMCGNCNGDN(HDLEBFHOHAK MOAAIOLDOII, Guid[] BHMLPKPNCJE, T MDKOIJJHDKB, bool CMFFHIEKJFJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A491A0", Offset = "0x2A479A0", VA = "0x182A491A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HPHPFKOEPGA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FKPDLOBILAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TaskCompletionSource<ELKJHLECFEE> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HPHPFKOEPGA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public FKPDLOBILAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4F606A0", Offset = "0x4F5EEA0", VA = "0x184F606A0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4F606F0", Offset = "0x4F5EEF0", VA = "0x184F606F0")]
			internal GJIFIEJIEAG <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OHKMGMNGGIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HLPKOKDLKCE.CKOEGGKFADP itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public OHKMGMNGGIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4F67660", Offset = "0x4F65E60", VA = "0x184F67660")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct ABPEAALHOJM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<ELKJHLECFEE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HPHPFKOEPGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private FKPDLOBILAI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<ELKJHLECFEE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4F5ED70", Offset = "0x4F5D570", VA = "0x184F5ED70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4F5F420", Offset = "0x4F5DC20", VA = "0x184F5F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IPMPAOMFNOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public HDLEBFHOHAK sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public IPMPAOMFNOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4F666C0", Offset = "0x4F64EC0", VA = "0x184F666C0")]
			internal bool <ClearSlice>b__0(ELKJHLECFEE bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly EEAKFJJMMKK EIKDDAEEKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string EAEAJCMDNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<ELKJHLECFEE> NECKFMGMFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private List<(HLPKOKDLKCE.CKOEGGKFADP itemType, long totalStopwatchTicks)> EGDHGAOJLDJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NKPDJDAGFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4F61DF0", Offset = "0x4F605F0", VA = "0x184F61DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<ELKJHLECFEE> OHOJPCOKMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4F61FD0", Offset = "0x4F607D0", VA = "0x184F61FD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4F61D50", Offset = "0x4F60550", VA = "0x184F61D50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4F62070", Offset = "0x4F60870", VA = "0x184F62070")]
		public HPHPFKOEPGA(EEAKFJJMMKK EIKDDAEEKBI, string EAEAJCMDNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F61BC0", Offset = "0x4F603C0", VA = "0x184F61BC0")]
		[AsyncStateMachine(typeof(ABPEAALHOJM))]
		public Task<ELKJHLECFEE> DGJJNBMPIHD(CancellationToken OFMMACGDFGM, TimeSpan FBPIGFIGOFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4F61E30", Offset = "0x4F60630", VA = "0x184F61E30")]
		public void GOHNAOAMOKN(ELKJHLECFEE BOBNBIKICDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4F61D00", Offset = "0x4F60500", VA = "0x184F61D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4F61EE0", Offset = "0x4F606E0", VA = "0x184F61EE0")]
		public void MECKABKFCFL(HDLEBFHOHAK MOAAIOLDOII, Guid BKOGMFPFOOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EKFPCCMGBEL : IEnumerable<(HDLEBFHOHAK, Guid)>, IEnumerable, IEnumerator<(HDLEBFHOHAK, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (HDLEBFHOHAK, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private HDLEBFHOHAK sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HDLEBFHOHAK <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private HDLEBFHOHAK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (HDLEBFHOHAK, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2D7C3B0", Offset = "0x2D7ABB0", VA = "0x182D7C3B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((HDLEBFHOHAK, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4F60170", Offset = "0x4F5E970", VA = "0x184F60170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA97C20", Offset = "0xA96420", VA = "0x180A97C20")]
		[DebuggerHidden]
		public EKFPCCMGBEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F5FE50", Offset = "0x4F5E650", VA = "0x184F5FE50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4F60120", Offset = "0x4F5E920", VA = "0x184F60120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4F60070", Offset = "0x4F5E870", VA = "0x184F60070", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(HDLEBFHOHAK, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4F60070", Offset = "0x4F5E870", VA = "0x184F60070", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MBCPJIMAIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<ELKJHLECFEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4F66D50", Offset = "0x4F65550", VA = "0x184F66D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F67530", Offset = "0x4F65D30", VA = "0x184F67530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DAJMOOPEJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<OPMCGNCNGDN<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4F5FA50", Offset = "0x4F5E250", VA = "0x184F5FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4F5FD70", Offset = "0x4F5E570", VA = "0x184F5FD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct POHEEAHHLIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<ELKJHLECFEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F681B0", Offset = "0x4F669B0", VA = "0x184F681B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4F68900", Offset = "0x4F67100", VA = "0x184F68900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PONDNBHKBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PONDNBHKBGH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct PKHCLALNOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<ELKJHLECFEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private PONDNBHKBGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private JIILJBNMPMG <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F678F0", Offset = "0x4F660F0", VA = "0x184F678F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4F68160", Offset = "0x4F66960", VA = "0x184F68160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HMOCOHPILDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<ELKJHLECFEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<ELKJHLECFEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4F61840", Offset = "0x4F60040", VA = "0x184F61840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4F61B70", Offset = "0x4F60370", VA = "0x184F61B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PPFJMBLPOEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public PPFJMBLPOEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4F68BD0", Offset = "0x4F673D0", VA = "0x184F68BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4F68D30", Offset = "0x4F67530", VA = "0x184F68D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PPFJMBLPOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4F68AB0", Offset = "0x4F672B0", VA = "0x184F68AB0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct ICIIAIAPGCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IFJGNAONOGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public LBJKCPGAKPO unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LBJKCPGAKPO pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4F62140", Offset = "0x4F60940", VA = "0x184F62140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IMBJKFOBFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public IMBJKFOBFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4F66550", Offset = "0x4F64D50", VA = "0x184F66550")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F66590", Offset = "0x4F64D90", VA = "0x184F66590")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4F665E0", Offset = "0x4F64DE0", VA = "0x184F665E0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KGEALMDKMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public HDLEBFHOHAK sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KGEALMDKMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4F66CD0", Offset = "0x4F654D0", VA = "0x184F66CD0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NBJHAOOJEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public HDLEBFHOHAK sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NBJHAOOJEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4F67580", Offset = "0x4F65D80", VA = "0x184F67580")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CKLEJMCDLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CKLEJMCDLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4F5F9F0", Offset = "0x4F5E1F0", VA = "0x184F5F9F0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NFOEBCKCNEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NFOEBCKCNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4F67600", Offset = "0x4F65E00", VA = "0x184F67600")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EILNFPGIJPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public EILNFPGIJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4F5FDC0", Offset = "0x4F5E5C0", VA = "0x184F5FDC0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PDEAOPEONPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public PDEAOPEONPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4F67860", Offset = "0x4F66060", VA = "0x184F67860")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JPDICMJHBEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public JPDICMJHBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4F66C70", Offset = "0x4F65470", VA = "0x184F66C70")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4F66C10", Offset = "0x4F65410", VA = "0x184F66C10")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BGOEKAHGNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public BGOEKAHGNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4F5F470", Offset = "0x4F5DC70", VA = "0x184F5F470")]
		internal bool <ClearSliceIds>b__3(OIJILIEDFMA stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4F5F570", Offset = "0x4F5DD70", VA = "0x184F5F570")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F5F7B0", Offset = "0x4F5DFB0", VA = "0x184F5F7B0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4F5F510", Offset = "0x4F5DD10", VA = "0x184F5F510")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly KPBHKOJBKPJ JHICLMDAHAK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable EEJMCJLOPIB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly HFKDEFDCJGM GJOBIEPLOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HPHPFKOEPGA BLKKFIAILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EEAKFJJMMKK EIKDDAEEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BMHBGDCHDAO OKDCCAKMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OBPCLFCCOCL HAILIONGLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KPBHKOJBKPJ OEMOJODDLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BPDPEACPAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[CompilerGenerated]
	private Action<ELKJHLECFEE> OLHAMGNHNOB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan FLDPHMBBFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan NKPNGDMMHFN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal static readonly HDLEBFHOHAK[] LPDBFPEFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] EFCIDNEHJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<OIJILIEDFMA> PCIPOBAONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private (HDLEBFHOHAK combinedSliceType, Guid[] sliceTypeIds)? IONGAAIHBBG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4F66160", Offset = "0x4F64960", VA = "0x184F66160")]
	public IFJGNAONOGK(EEAKFJJMMKK EIKDDAEEKBI, BMHBGDCHDAO OKDCCAKMOFJ, OBPCLFCCOCL HAILIONGLEL, [Optional] TimeSpan? BBFIAAEJDKB, [Optional] KPBHKOJBKPJ HEELGPMAACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29B1130", Offset = "0x29AF930", VA = "0x1829B1130")]
	public static IFJGNAONOGK CFMFFFIKKCD<TNetworking>(TNetworking MGEBIGNOAKH, [Optional] TimeSpan? BBFIAAEJDKB, [Optional] KPBHKOJBKPJ HEELGPMAACH) where TNetworking : EEAKFJJMMKK, BMHBGDCHDAO, OBPCLFCCOCL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F63B70", Offset = "0x4F62370", VA = "0x184F63B70")]
	public void HCHOKKKPDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F63530", Offset = "0x4F61D30", VA = "0x184F63530")]
	private TimeSpan CIJKOAEJOGB(TimeSpan? BBFIAAEJDKB, int NMFIGFHGHGM = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2467A20", Offset = "0x2466220", VA = "0x182467A20")]
	public bool BFHCNDGFDCO<T>(T IIKDILPPAIH, Func<T, byte[]> KIAMEBFEPMJ, bool CMFFHIEKJFJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4F625E0", Offset = "0x4F60DE0", VA = "0x184F625E0")]
	public bool BFHCNDGFDCO(byte[] IIKDILPPAIH, int JFMEFNJLLED, bool CMFFHIEKJFJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4F629C0", Offset = "0x4F611C0", VA = "0x184F629C0")]
	private static string BFLMICGJKKC(HDLEBFHOHAK MOAAIOLDOII, Guid[] LBKDEFOOLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4F634B0", Offset = "0x4F61CB0", VA = "0x184F634B0")]
	[IteratorStateMachine(typeof(EKFPCCMGBEL))]
	private static IEnumerable<(HDLEBFHOHAK, Guid)> CHPOMEPNNFC(HDLEBFHOHAK OINKOEPPDGE, Guid[] LBKDEFOOLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4F63850", Offset = "0x4F62050", VA = "0x184F63850")]
	[AsyncStateMachine(typeof(MBCPJIMAIOI))]
	public Task<ELKJHLECFEE> DOFNNOAMICO(CancellationToken OFMMACGDFGM, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, [Optional] TimeSpan? BBFIAAEJDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4F62480", Offset = "0x4F60C80", VA = "0x184F62480")]
	[AsyncStateMachine(typeof(DAJMOOPEJJP))]
	public Task<Guid> AHKDCKBFPDB(Guid NOJHGOHNICD, CancellationToken OFMMACGDFGM, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, [Optional] TimeSpan? FBPIGFIGOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2C40", Offset = "0x2BC1440", VA = "0x182BC2C40")]
	[AsyncStateMachine(typeof(IIKPAKONGLE))]
	public Task<OPMCGNCNGDN<T>> MDADKMHHLDP<T>(T IIKDILPPAIH, Func<T, byte[]> KIAMEBFEPMJ, Func<byte[], T> JPCJAKKDFKC, CancellationToken OFMMACGDFGM, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, [Optional] TimeSpan? FBPIGFIGOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4F64C70", Offset = "0x4F63470", VA = "0x184F64C70")]
	[AsyncStateMachine(typeof(POHEEAHHLIC))]
	public Task<ELKJHLECFEE> MDADKMHHLDP(byte[] IIKDILPPAIH, CancellationToken OFMMACGDFGM, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, [Optional] TimeSpan? FBPIGFIGOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4F65B40", Offset = "0x4F64340", VA = "0x184F65B40")]
	[AsyncStateMachine(typeof(PKHCLALNOAA))]
	private Task<ELKJHLECFEE> OMFMNJHDHGJ(byte[] IIKDILPPAIH, CancellationToken OFMMACGDFGM, LBJKCPGAKPO LDGBPAECCJH, LBJKCPGAKPO ACICNKMBKNL, TimeSpan? BBFIAAEJDKB, Stopwatch HABNBMMLCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F64B00", Offset = "0x4F63300", VA = "0x184F64B00")]
	[AsyncStateMachine(typeof(HMOCOHPILDK))]
	private Task<ELKJHLECFEE> MCADKGGKHOK(byte[] IIKDILPPAIH, CancellationToken OFMMACGDFGM, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, [Optional] TimeSpan? FBPIGFIGOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F62320", Offset = "0x4F60B20", VA = "0x184F62320")]
	[AsyncStateMachine(typeof(ICIIAIAPGCB))]
	public Task AFPBCLKJPHD(CancellationToken NDBJLLGGEAE, Func<CancellationToken, Task> BIDHOIFPMMO, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, int DJKOHKACKHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2BC25A0", Offset = "0x2BC0DA0", VA = "0x182BC25A0")]
	[AsyncStateMachine(typeof(KFFBLHMAELO))]
	public Task<T> AFPBCLKJPHD<T>(CancellationToken NDBJLLGGEAE, Func<CancellationToken, Task<T>> BIDHOIFPMMO, [Optional] LBJKCPGAKPO LDGBPAECCJH, [Optional] LBJKCPGAKPO ACICNKMBKNL, int DJKOHKACKHC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BC20F0", Offset = "0x2BC08F0", VA = "0x182BC20F0")]
	[AsyncStateMachine(typeof(PLCJCEMKLHN))]
	private Task<(bool, T)> ABHDDDJBFAO<T>(Guid LABJHJNAAJA, CancellationToken NDBJLLGGEAE, Func<CancellationToken, Task<T>> BIDHOIFPMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F62B10", Offset = "0x4F61310", VA = "0x184F62B10")]
	public void BGKMIBDCLLC(byte HKJMAFJKNHI, int CNFJMMOGCDN, object FIDHBEOFCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F65D60", Offset = "0x4F64560", VA = "0x184F65D60")]
	public Guid PJECOMGBDDB(Guid EOEIGEACNMB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F63AC0", Offset = "0x4F622C0", VA = "0x184F63AC0")]
	internal static int GGAICCNHIPD(HDLEBFHOHAK MOAAIOLDOII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F64380", Offset = "0x4F62B80", VA = "0x184F64380")]
	public bool LDNEDDKNOAG(HDLEBFHOHAK MOAAIOLDOII, Guid LABJHJNAAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F647D0", Offset = "0x4F62FD0", VA = "0x184F647D0")]
	public void LOGDEBIKPCH(HDLEBFHOHAK MOAAIOLDOII, Guid LABJHJNAAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4F65CC0", Offset = "0x4F644C0", VA = "0x184F65CC0")]
	private void OMOKBHHCNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4F63F90", Offset = "0x4F62790", VA = "0x184F63F90")]
	internal (HDLEBFHOHAK, Guid[]) KMKPAIOAANB(bool MFFLNBMLGLD = false)
	{
		return default((HDLEBFHOHAK, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F63710", Offset = "0x4F61F10", VA = "0x184F63710")]
	private HashSet<Guid> CNJAKBNGHJH(HDLEBFHOHAK MOAAIOLDOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4F65710", Offset = "0x4F63F10", VA = "0x184F65710")]
	private void NAABIADOAKC(HDLEBFHOHAK MOAAIOLDOII, Guid BKOGMFPFOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4F63260", Offset = "0x4F61A60", VA = "0x184F63260")]
	private void BHFCMHIDKKI(HDLEBFHOHAK MOAAIOLDOII, Guid BKOGMFPFOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4F65CD0", Offset = "0x4F644D0", VA = "0x184F65CD0")]
	public static Func<Guid, bool> PAOHHIIIIFD(Guid BKOGMFPFOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F63F00", Offset = "0x4F62700", VA = "0x184F63F00")]
	public static Func<Guid, bool> JCEMMNJLBDB(Guid BKOGMFPFOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F64DE0", Offset = "0x4F635E0", VA = "0x184F64DE0")]
	public void MECKABKFCFL(HDLEBFHOHAK MOAAIOLDOII, Guid KNGLLBDNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F64ED0", Offset = "0x4F636D0", VA = "0x184F64ED0")]
	public void MOGAFBLAKKI(HDLEBFHOHAK MOAAIOLDOII, Func<Guid, bool> EHEKKLOMNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F639B0", Offset = "0x4F621B0", VA = "0x184F639B0")]
	private string EONCBKAGMJB(byte[] MDKOIJJHDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4F65890", Offset = "0x4F64090", VA = "0x184F65890")]
	[CompilerGenerated]
	private object NLCHOCACNCA(in (HDLEBFHOHAK st, Guid[] ids, byte[] mts) IKIFFPJKHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F63C50", Offset = "0x4F62450", VA = "0x184F63C50")]
	[CompilerGenerated]
	private object IOEMEAIABGB(in (HDLEBFHOHAK rst, Guid[] ssids, byte[] pl) IKIFFPJKHAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GJIFIEJIEAG : KMNKKJFMNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private List<(HLPKOKDLKCE.CKOEGGKFADP itemType, long totalStopwatchTicks)> MKDDMPFNBID;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(HLPKOKDLKCE.CKOEGGKFADP itemType, long totalStopwatchTicks)> CPMBMHNEHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x612F40", Offset = "0x611740", VA = "0x180612F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4F617C0", Offset = "0x4F5FFC0", VA = "0x184F617C0")]
	public GJIFIEJIEAG(TimeSpan FBPIGFIGOFL, List<(HLPKOKDLKCE.CKOEGGKFADP itemType, long totalStopwatchTicks)> MKDDMPFNBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FIPDNOHOKDO : JIILJBNMPMG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct FFMGGEOIMBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly Guid DFAMBMGKEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly int EJNFNIBCAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly int KDHCDAGPKPK;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4F604A0", Offset = "0x4F5ECA0", VA = "0x184F604A0")]
		public FFMGGEOIMBG(Guid PKNKNNMADLL, int AEAJBDHBPCD, int NOMBGOFELCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4F603D0", Offset = "0x4F5EBD0", VA = "0x184F603D0")]
		public static byte[] IICNIKFAIFP(FFMGGEOIMBG BOBNBIKICDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4F60350", Offset = "0x4F5EB50", VA = "0x184F60350")]
		private static byte[] DKAIFGFKNCE(int HPENCEMKHKB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Guid PKNKNNMADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly IFJGNAONOGK PNFEBHCAHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool ODKIKKMCBAB;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4F60640", Offset = "0x4F5EE40", VA = "0x184F60640")]
	public FIPDNOHOKDO(Guid PKNKNNMADLL, IFJGNAONOGK PNFEBHCAHJO, OBPCLFCCOCL MGEBIGNOAKH, CancellationToken NDBJLLGGEAE, [Optional] JHEICCJGODH POIDJFKMCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4F604B0", Offset = "0x4F5ECB0", VA = "0x184F604B0", Slot = "5")]
	protected override void CNPJFCMFNOD(int GGGMCMIPIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ELKJHLECFEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool MGGPJFHDMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly IFJGNAONOGK.HDLEBFHOHAK AHGCGLJFABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Guid[] ONFIIOMHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte[] CNBJMCKIFAE;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A492B0", Offset = "0x2A47AB0", VA = "0x182A492B0")]
	public ELKJHLECFEE(IFJGNAONOGK.HDLEBFHOHAK MOAAIOLDOII, [NotNull] Guid[] BHMLPKPNCJE, byte[] MDKOIJJHDKB, bool CMFFHIEKJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4F601C0", Offset = "0x4F5E9C0", VA = "0x184F601C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class MPAEMHOLHII<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x263DD90", Offset = "0x263C590", VA = "0x18263DD90", Slot = "4")]
	public void GEFFLMCIHLH(T BOBNBIKICDK, IDictionary<object, object> BPPCNFHJMAA, bool FEMOPADBIIN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EAPCOPFIOLD(T BOBNBIKICDK, IDictionary<object, object> BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T DMAKMKNNBAJ(IDictionary<object, object> BPPCNFHJMAA);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x263DC30", Offset = "0x263C430", VA = "0x18263DC30", Slot = "7")]
	public bool FAPLCIMNBJP(IDictionary<object, object> BPPCNFHJMAA, out T OFAIAAHACHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	protected MPAEMHOLHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JIILJBNMPMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool JHEICCJGODH(int HPEBMNPMNFI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool BKEPAEJLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly OBPCLFCCOCL ENDIIHKDJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken NDBJLLGGEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken GEGOKFGMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly JHEICCJGODH POIDJFKMCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource LNHHKNOLDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource ABPNLIJBFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int AOLNFMKMODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool CBBOIOGEMLI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken LEELBNGCEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4F66980", Offset = "0x4F65180", VA = "0x184F66980")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PAFLHGBFCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4F66910", Offset = "0x4F65110", VA = "0x184F66910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4F66A30", Offset = "0x4F65230", VA = "0x184F66A30")]
	public JIILJBNMPMG(OBPCLFCCOCL MGEBIGNOAKH, CancellationToken NDBJLLGGEAE, [Optional] JHEICCJGODH POIDJFKMCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x310CC20", Offset = "0x310B420", VA = "0x18310CC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4F669A0", Offset = "0x4F651A0", VA = "0x184F669A0")]
	private void IHFKLDFMBEP(EHBOOFFPCFP NJKNICOFMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F668B0", Offset = "0x4F650B0", VA = "0x184F668B0")]
	protected void ACCEHHDMEEN(int GGGMCMIPIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F66960", Offset = "0x4F65160", VA = "0x184F66960", Slot = "5")]
	protected virtual void CNPJFCMFNOD(int GGGMCMIPIIB)
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
