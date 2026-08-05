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
internal class CNOHNNBNCHH : global::GEOKFLGKPON<MIJKANCCBPP>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EMIAFKBGIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public EMIAFKBGIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4ED8250", Offset = "0x4ED7450", VA = "0x184ED8250")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] AIIPKODEBGL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CNOHNNBNCHH JACNMOBBDPN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4ED70B0", Offset = "0x4ED62B0", VA = "0x184ED70B0", Slot = "5")]
	protected override void AHGEJPDIAOO(MIJKANCCBPP MPHBMEGMJKJ, IDictionary<object, object> NJOKIDJGNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7430", Offset = "0x4ED6630", VA = "0x184ED7430", Slot = "6")]
	public override MIJKANCCBPP HMOLPLGFINA(IDictionary<object, object> NJOKIDJGNHA)
	{
		return default(MIJKANCCBPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7E20", Offset = "0x4ED7020", VA = "0x184ED7E20")]
	public CNOHNNBNCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ENEGFJHMAMA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string DMLGNBGINHF([NotNull] byte[] IMJFNGNMFKJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum CHLEGCBEJGF : byte
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
	private readonly struct CKMGGKNOEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly CHLEGCBEJGF CCEIEKBHKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly Guid ELBICIHLLEB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x42D0F80", Offset = "0x42D0180", VA = "0x1842D0F80")]
		public CKMGGKNOEBE(CHLEGCBEJGF HOALAKFODPD, Guid KIICCCAKINK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7050", Offset = "0x4ED6250", VA = "0x184ED7050")]
		public bool HNONPHLDFEM(CKMGGKNOEBE EBJKBJMLDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6F60", Offset = "0x4ED6160", VA = "0x184ED6F60", Slot = "0")]
		public override bool Equals(object CEEAMODAEEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7020", Offset = "0x4ED6220", VA = "0x184ED7020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct GPABDIICDPN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly bool PLFDCIBLGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly CHLEGCBEJGF CCEIEKBHKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid[] HHHKEEAKKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T DBAACGDJPON;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E350", Offset = "0x2C4D550", VA = "0x182C4E350")]
		public static GPABDIICDPN<T> MFPHHKAHMMF(MIJKANCCBPP EBDOBLDLKIO, Func<byte[], T> NEAOIDFKBEM)
		{
			return default(GPABDIICDPN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E630", Offset = "0x2C4D830", VA = "0x182C4E630")]
		public GPABDIICDPN(CHLEGCBEJGF HOALAKFODPD, Guid[] KLEFHMJAKGM, T IMJFNGNMFKJ, bool NGIPELKDHAN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2C4E510", Offset = "0x2C4D710", VA = "0x182C4E510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KLBFLDOHLFA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ENDKKEFCPMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TaskCompletionSource<MIJKANCCBPP> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public KLBFLDOHLFA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public ENDKKEFCPMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4ED82F0", Offset = "0x4ED74F0", VA = "0x184ED82F0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8340", Offset = "0x4ED7540", VA = "0x184ED8340")]
			internal LJNPPMOGMCH <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KNAEMHFCHHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AMFABAGPFGC.INAAGIAEPPJ itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public KNAEMHFCHHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4EDDD50", Offset = "0x4EDCF50", VA = "0x184EDDD50")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BILMKCPKIPG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<MIJKANCCBPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public KLBFLDOHLFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private ENDKKEFCPMJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<MIJKANCCBPP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6700", Offset = "0x4ED5900", VA = "0x184ED6700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6DB0", Offset = "0x4ED5FB0", VA = "0x184ED6DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BELKHCKEINH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CHLEGCBEJGF sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public BELKHCKEINH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6590", Offset = "0x4ED5790", VA = "0x184ED6590")]
			internal bool <ClearSlice>b__0(MIJKANCCBPP bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly FOGJDAIMMCO IMNLCHPAGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string DHHHKILCPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<MIJKANCCBPP> JCNPFHJDNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private List<(AMFABAGPFGC.INAAGIAEPPJ itemType, long totalStopwatchTicks)> EIPEKNGBCEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PHGDMBIDDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4EDDB00", Offset = "0x4EDCD00", VA = "0x184EDDB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<MIJKANCCBPP> OIOMOMNFBDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4EDD7D0", Offset = "0x4EDC9D0", VA = "0x184EDD7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4EDD870", Offset = "0x4EDCA70", VA = "0x184EDD870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDC80", Offset = "0x4EDCE80", VA = "0x184EDDC80")]
		public KLBFLDOHLFA(FOGJDAIMMCO IMNLCHPAGID, string DHHHKILCPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDB40", Offset = "0x4EDCD40", VA = "0x184EDDB40")]
		[AsyncStateMachine(typeof(BILMKCPKIPG))]
		public Task<MIJKANCCBPP> PJOBPECALJN(CancellationToken MNPKHBAPNDC, TimeSpan EFGEEIOMDKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD960", Offset = "0x4EDCB60", VA = "0x184EDD960")]
		public void GAOLHMKFOPJ(MIJKANCCBPP MPHBMEGMJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD910", Offset = "0x4EDCB10", VA = "0x184EDD910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDA10", Offset = "0x4EDCC10", VA = "0x184EDDA10")]
		public void GIIHFFMNIEL(CHLEGCBEJGF HOALAKFODPD, Guid HAMKLMCJFNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EJFEMHHGIOO : IEnumerable<(CHLEGCBEJGF, Guid)>, IEnumerable, IEnumerator<(CHLEGCBEJGF, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (CHLEGCBEJGF, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CHLEGCBEJGF sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CHLEGCBEJGF <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CHLEGCBEJGF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (CHLEGCBEJGF, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2670EB0", Offset = "0x26700B0", VA = "0x182670EB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((CHLEGCBEJGF, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8200", Offset = "0x4ED7400", VA = "0x184ED8200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2832B90", Offset = "0x2831D90", VA = "0x182832B90")]
		[DebuggerHidden]
		public EJFEMHHGIOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7EE0", Offset = "0x4ED70E0", VA = "0x184ED7EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4ED81B0", Offset = "0x4ED73B0", VA = "0x184ED81B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4ED8100", Offset = "0x4ED7300", VA = "0x184ED8100", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CHLEGCBEJGF, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4ED8100", Offset = "0x4ED7300", VA = "0x184ED8100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FLJOPEPLLEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<MIJKANCCBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HPIMPDEBPJM pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC890", Offset = "0x4EDBA90", VA = "0x184EDC890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD070", Offset = "0x4EDC270", VA = "0x184EDD070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PLPHJMAOJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HPIMPDEBPJM pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<GPABDIICDPN<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFAF0", Offset = "0x4EDECF0", VA = "0x184EDFAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFE10", Offset = "0x4EDF010", VA = "0x184EDFE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OBBJOKJGCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<MIJKANCCBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HPIMPDEBPJM pauseAfterListeningToken;

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
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE4B0", Offset = "0x4EDD6B0", VA = "0x184EDE4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4EDEC00", Offset = "0x4EDDE00", VA = "0x184EDEC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KBCEJFEDKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public KBCEJFEDKCC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OGKDEGEOLAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<MIJKANCCBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private KBCEJFEDKCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HPIMPDEBPJM pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private AHHHDKFIEDL <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4EDECB0", Offset = "0x4EDDEB0", VA = "0x184EDECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF520", Offset = "0x4EDE720", VA = "0x184EDF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NBNACNCBEHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<MIJKANCCBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HPIMPDEBPJM pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<MIJKANCCBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE130", Offset = "0x4EDD330", VA = "0x184EDE130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE460", Offset = "0x4EDD660", VA = "0x184EDE460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class POFJKPOBGPK
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
			public POFJKPOBGPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4EDFF80", Offset = "0x4EDF180", VA = "0x184EDFF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4EE00E0", Offset = "0x4EDF2E0", VA = "0x184EE00E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public POFJKPOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFE60", Offset = "0x4EDF060", VA = "0x184EDFE60")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GMIJPOBJCNJ : IAsyncStateMachine
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
		public ENEGFJHMAMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HPIMPDEBPJM unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HPIMPDEBPJM pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD0C0", Offset = "0x4EDC2C0", VA = "0x184EDD0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x607790", Offset = "0x606990", VA = "0x180607790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IMGNKMPCLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IMGNKMPCLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD510", Offset = "0x4EDC710", VA = "0x184EDD510")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD550", Offset = "0x4EDC750", VA = "0x184EDD550")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD5A0", Offset = "0x4EDC7A0", VA = "0x184EDD5A0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IKKCHLINCKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CHLEGCBEJGF sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IKKCHLINCKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD490", Offset = "0x4EDC690", VA = "0x184EDD490")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DCKMKPIJDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CHLEGCBEJGF sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public DCKMKPIJDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7E60", Offset = "0x4ED7060", VA = "0x184ED7E60")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OEBHOPAIIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public OEBHOPAIIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDEC50", Offset = "0x4EDDE50", VA = "0x184EDEC50")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MIHEMNEKPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MIHEMNEKPHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDE80", Offset = "0x4EDD080", VA = "0x184EDDE80")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AHDEIICJMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public AHDEIICJMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED61A0", Offset = "0x4ED53A0", VA = "0x184ED61A0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JCCFNFJLFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public JCCFNFJLFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD5E0", Offset = "0x4EDC7E0", VA = "0x184EDD5E0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MOILJJKNGHJ
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public MOILJJKNGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE0D0", Offset = "0x4EDD2D0", VA = "0x184EDE0D0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE070", Offset = "0x4EDD270", VA = "0x184EDE070")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PGLPCBEKMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public PGLPCBEKMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF570", Offset = "0x4EDE770", VA = "0x184EDF570")]
		internal bool <ClearSliceIds>b__3(CKMGGKNOEBE stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF670", Offset = "0x4EDE870", VA = "0x184EDF670")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF8B0", Offset = "0x4EDEAB0", VA = "0x184EDF8B0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF610", Offset = "0x4EDE810", VA = "0x184EDF610")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DMLGNBGINHF LDGCNFBMKOL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable ODLLLIDBCLO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PJBMNMILBPN DEMJKEACLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KLBFLDOHLFA MOLEKBLAGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FOGJDAIMMCO IMNLCHPAGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MAGHPCEIDCJ HLHOEBNLBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DDHMBDBKOLO KCJACOAFKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DMLGNBGINHF KJGOAAJGMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BJOLDLCEHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[CompilerGenerated]
	private Action<MIJKANCCBPP> BNCBHMFNKHL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan JKFLBHFLBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan KGPDKEOMDOD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal static readonly CHLEGCBEJGF[] MMJHAPEINGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] BCNAFEEJGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<CKMGGKNOEBE> PLOMMDJAEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private (CHLEGCBEJGF combinedSliceType, Guid[] sliceTypeIds)? DHPPNLBPJNC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC4A0", Offset = "0x4EDB6A0", VA = "0x184EDC4A0")]
	public ENEGFJHMAMA(FOGJDAIMMCO IMNLCHPAGID, MAGHPCEIDCJ HLHOEBNLBPG, DDHMBDBKOLO KCJACOAFKAF, [Optional] TimeSpan? ENGPMLADLHP, [Optional] DMLGNBGINHF JNCFMMLPEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21B38B0", Offset = "0x21B2AB0", VA = "0x1821B38B0")]
	public static ENEGFJHMAMA AKAGIDAMDJK<TNetworking>(TNetworking MPNHFLDDJEL, [Optional] TimeSpan? ENGPMLADLHP, [Optional] DMLGNBGINHF JNCFMMLPEAJ) where TNetworking : FOGJDAIMMCO, MAGHPCEIDCJ, DDHMBDBKOLO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC210", Offset = "0x4EDB410", VA = "0x184EDC210")]
	public void PPFJJMADIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9DF0", Offset = "0x4ED8FF0", VA = "0x184ED9DF0")]
	private TimeSpan HHAOKBPKEOC(TimeSpan? ENGPMLADLHP, int FKLEAJCDNNP = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x282A350", Offset = "0x2829550", VA = "0x18282A350")]
	public bool HAKGHALPMAF<T>(T OHBEJFMNKIC, Func<T, byte[]> CODADDDNOHG, bool NGIPELKDHAN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9070", Offset = "0x4ED8270", VA = "0x184ED9070")]
	public bool HAKGHALPMAF(byte[] OHBEJFMNKIC, int AHJEGPDAHLO, bool NGIPELKDHAN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA6D0", Offset = "0x4ED98D0", VA = "0x184EDA6D0")]
	private static string IMCJJNJOGKH(CHLEGCBEJGF HOALAKFODPD, Guid[] LDHOHDCHCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8F00", Offset = "0x4ED8100", VA = "0x184ED8F00")]
	[IteratorStateMachine(typeof(EJFEMHHGIOO))]
	private static IEnumerable<(CHLEGCBEJGF, Guid)> EKFGONNOEFK(CHLEGCBEJGF LODEDFDIBPL, Guid[] LDHOHDCHCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA820", Offset = "0x4ED9A20", VA = "0x184EDA820")]
	[AsyncStateMachine(typeof(FLJOPEPLLEF))]
	public Task<MIJKANCCBPP> IMGKCJKNFNN(CancellationToken MNPKHBAPNDC, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, [Optional] TimeSpan? ENGPMLADLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8B70", Offset = "0x4ED7D70", VA = "0x184ED8B70")]
	[AsyncStateMachine(typeof(PLPHJMAOJAI))]
	public Task<Guid> DNCPCLFJDAF(Guid EAHDKCOKMNA, CancellationToken MNPKHBAPNDC, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, [Optional] TimeSpan? EFGEEIOMDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2299310", Offset = "0x2298510", VA = "0x182299310")]
	[AsyncStateMachine(typeof(PIHIBAFJGLD))]
	public Task<GPABDIICDPN<T>> IPOPHMKHHKN<T>(T OHBEJFMNKIC, Func<T, byte[]> CODADDDNOHG, Func<byte[], T> NEAOIDFKBEM, CancellationToken MNPKHBAPNDC, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, [Optional] TimeSpan? EFGEEIOMDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4EDAAF0", Offset = "0x4ED9CF0", VA = "0x184EDAAF0")]
	[AsyncStateMachine(typeof(OBBJOKJGCLO))]
	public Task<MIJKANCCBPP> IPOPHMKHHKN(byte[] OHBEJFMNKIC, CancellationToken MNPKHBAPNDC, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, [Optional] TimeSpan? EFGEEIOMDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8CD0", Offset = "0x4ED7ED0", VA = "0x184ED8CD0")]
	[AsyncStateMachine(typeof(OGKDEGEOLAH))]
	private Task<MIJKANCCBPP> EAMCIOCLOHN(byte[] OHBEJFMNKIC, CancellationToken MNPKHBAPNDC, HPIMPDEBPJM GDLMPEIICAH, HPIMPDEBPJM KFLCICBFBKJ, TimeSpan? ENGPMLADLHP, Stopwatch LCDKHFEENHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA980", Offset = "0x4ED9B80", VA = "0x184EDA980")]
	[AsyncStateMachine(typeof(NBNACNCBEHE))]
	private Task<MIJKANCCBPP> IPDFOJDIBBM(byte[] OHBEJFMNKIC, CancellationToken MNPKHBAPNDC, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, [Optional] TimeSpan? EFGEEIOMDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB190", Offset = "0x4EDA390", VA = "0x184EDB190")]
	[AsyncStateMachine(typeof(GMIJPOBJCNJ))]
	public Task KADHONLADFD(CancellationToken NDAAKCECFIE, Func<CancellationToken, Task> GONEKILNFCO, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, int GMJHHPBJOBH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22994D0", Offset = "0x22986D0", VA = "0x1822994D0")]
	[AsyncStateMachine(typeof(PGBBIALODAP))]
	public Task<T> KADHONLADFD<T>(CancellationToken NDAAKCECFIE, Func<CancellationToken, Task<T>> GONEKILNFCO, [Optional] HPIMPDEBPJM GDLMPEIICAH, [Optional] HPIMPDEBPJM KFLCICBFBKJ, int GMJHHPBJOBH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2298CA0", Offset = "0x2297EA0", VA = "0x182298CA0")]
	[AsyncStateMachine(typeof(JBLAJMAGIOA))]
	private Task<(bool, T)> CBFEAJMCPNF<T>(Guid KIICCCAKINK, CancellationToken NDAAKCECFIE, Func<CancellationToken, Task<T>> GONEKILNFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9450", Offset = "0x4ED8650", VA = "0x184ED9450")]
	public void HBMDKFJOJFF(byte BFJJPKCBDIC, int PJKMEGCHHIM, object JMMIABKLMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9BA0", Offset = "0x4ED8DA0", VA = "0x184ED9BA0")]
	public Guid HCKCBEAOGNE(Guid PMAABGAAFNO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8E50", Offset = "0x4ED8050", VA = "0x184ED8E50")]
	internal static int EFOEOFBBDLO(CHLEGCBEJGF HOALAKFODPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA280", Offset = "0x4ED9480", VA = "0x184EDA280")]
	public bool IDIPGENJIMB(CHLEGCBEJGF HOALAKFODPD, Guid KIICCCAKINK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB2F0", Offset = "0x4EDA4F0", VA = "0x184EDB2F0")]
	public void KCALPLDGHGL(CHLEGCBEJGF HOALAKFODPD, Guid KIICCCAKINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8B60", Offset = "0x4ED7D60", VA = "0x184ED8B60")]
	private void CNFMAILNHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EDAC60", Offset = "0x4ED9E60", VA = "0x184EDAC60")]
	internal (CHLEGCBEJGF, Guid[]) JKHIJBLLBLB(bool GJFGBFCHJBA = false)
	{
		return default((CHLEGCBEJGF, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB050", Offset = "0x4EDA250", VA = "0x184EDB050")]
	private HashSet<Guid> JPAHLOHNNAD(CHLEGCBEJGF HOALAKFODPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC000", Offset = "0x4EDB200", VA = "0x184EDC000")]
	private void OLIMKKHBMIE(CHLEGCBEJGF HOALAKFODPD, Guid HAMKLMCJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8660", Offset = "0x4ED7860", VA = "0x184ED8660")]
	private void CFFLINOPGOE(CHLEGCBEJGF HOALAKFODPD, Guid HAMKLMCJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC180", Offset = "0x4EDB380", VA = "0x184EDC180")]
	public static Func<Guid, bool> PJACAMBDAPE(Guid HAMKLMCJFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB730", Offset = "0x4EDA930", VA = "0x184EDB730")]
	public static Func<Guid, bool> LJHDBIIPKKD(Guid HAMKLMCJFNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8F80", Offset = "0x4ED8180", VA = "0x184ED8F80")]
	public void GIIHFFMNIEL(CHLEGCBEJGF HOALAKFODPD, Guid LHOELMCHLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB7C0", Offset = "0x4EDA9C0", VA = "0x184EDB7C0")]
	public void OJHNENBNKMG(CHLEGCBEJGF HOALAKFODPD, Func<Guid, bool> LNKLAGDOOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB620", Offset = "0x4EDA820", VA = "0x184EDB620")]
	private string LCFGCNFDKPJ(byte[] IMJFNGNMFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9FD0", Offset = "0x4ED91D0", VA = "0x184ED9FD0")]
	[CompilerGenerated]
	private object HHIFKHKKPAA(in (CHLEGCBEJGF st, Guid[] ids, byte[] mts) KNBHIGDFKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4ED88B0", Offset = "0x4ED7AB0", VA = "0x184ED88B0")]
	[CompilerGenerated]
	private object CKHLAKJFMCE(in (CHLEGCBEJGF rst, Guid[] ssids, byte[] pl) KNBHIGDFKBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LJNPPMOGMCH : LKCIALHGMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private List<(AMFABAGPFGC.INAAGIAEPPJ itemType, long totalStopwatchTicks)> ELBCLFCLNJA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(AMFABAGPFGC.INAAGIAEPPJ itemType, long totalStopwatchTicks)> BKLKMNDJAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D7E10", Offset = "0x5D7010", VA = "0x1805D7E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4EDDE00", Offset = "0x4EDD000", VA = "0x184EDDE00")]
	public LJNPPMOGMCH(TimeSpan EFGEEIOMDKH, List<(AMFABAGPFGC.INAAGIAEPPJ itemType, long totalStopwatchTicks)> ELBCLFCLNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HPOHANCIDCG : AHHHDKFIEDL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct CHOOJJMNOCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly Guid BKIBLIJFJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly int EEKLKJDHDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly int EFNHBGPJLBM;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6F50", Offset = "0x4ED6150", VA = "0x184ED6F50")]
		public CHOOJJMNOCP(Guid EMLCMDFOKFC, int KAAEJJOHBDA, int HIFPCMMKPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6E80", Offset = "0x4ED6080", VA = "0x184ED6E80")]
		public static byte[] MNIJLJLODBL(CHOOJJMNOCP MPHBMEGMJKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6E00", Offset = "0x4ED6000", VA = "0x184ED6E00")]
		private static byte[] BFJEPCPNMLG(int PNNJEJIELDM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Guid EMLCMDFOKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly ENEGFJHMAMA HMODMNGBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool FLPDOIPPDMN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4EDD430", Offset = "0x4EDC630", VA = "0x184EDD430")]
	public HPOHANCIDCG(Guid EMLCMDFOKFC, ENEGFJHMAMA HMODMNGBEAN, DDHMBDBKOLO MPNHFLDDJEL, CancellationToken NDAAKCECFIE, [Optional] ACBCIGANMCI JDBOKGDEIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4EDD2A0", Offset = "0x4EDC4A0", VA = "0x184EDD2A0", Slot = "5")]
	protected override void GPHHCKGGCGE(int JIOFAKOCBHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct MIJKANCCBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool PLFDCIBLGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly ENEGFJHMAMA.CHLEGCBEJGF CCEIEKBHKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Guid[] HHHKEEAKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte[] DBAACGDJPON;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E5E0", Offset = "0x2C4D7E0", VA = "0x182C4E5E0")]
	public MIJKANCCBPP(ENEGFJHMAMA.CHLEGCBEJGF HOALAKFODPD, [NotNull] Guid[] KLEFHMJAKGM, byte[] IMJFNGNMFKJ, bool NGIPELKDHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4EDDEE0", Offset = "0x4EDD0E0", VA = "0x184EDDEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class GEOKFLGKPON<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22072B0", Offset = "0x22064B0", VA = "0x1822072B0", Slot = "4")]
	public void OKHGEGJBCIO(T MPHBMEGMJKJ, IDictionary<object, object> NJOKIDJGNHA, bool HGHJEDAGPAD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void AHGEJPDIAOO(T MPHBMEGMJKJ, IDictionary<object, object> NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T HMOLPLGFINA(IDictionary<object, object> NJOKIDJGNHA);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2207140", Offset = "0x2206340", VA = "0x182207140", Slot = "7")]
	public bool HNBNHJMNPDN(IDictionary<object, object> NJOKIDJGNHA, out T OHFCEIKAIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x17B4810", Offset = "0x17B3A10", VA = "0x1817B4810")]
	protected GEOKFLGKPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AHHHDKFIEDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool ACBCIGANMCI(int MNPFCDFGCNB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool NELKGEDACJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly DDHMBDBKOLO OGHOJDLAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken NDAAKCECFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken AFKAACOCHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly ACBCIGANMCI JDBOKGDEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource OIDIAJEFFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource HOPHKMCJJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int DEPFMCEKIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BBKPCILHLDL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken NKFLFDLHPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6390", Offset = "0x4ED5590", VA = "0x184ED6390")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MMLNENJKKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6250", Offset = "0x4ED5450", VA = "0x184ED6250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED63B0", Offset = "0x4ED55B0", VA = "0x184ED63B0")]
	public AHHHDKFIEDL(DDHMBDBKOLO MPNHFLDDJEL, CancellationToken NDAAKCECFIE, [Optional] ACBCIGANMCI JDBOKGDEIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B95D90", Offset = "0x2B94F90", VA = "0x182B95D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED62A0", Offset = "0x4ED54A0", VA = "0x184ED62A0")]
	private void HHCPCIPLOAC(BFJNMOMPEEB EFEGMLDGHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6330", Offset = "0x4ED5530", VA = "0x184ED6330")]
	protected void MHAOGJGKKOK(int JIOFAKOCBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6230", Offset = "0x4ED5430", VA = "0x184ED6230", Slot = "5")]
	protected virtual void GPHHCKGGCGE(int JIOFAKOCBHC)
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
