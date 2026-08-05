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
internal class JAKDBMPFENE : global::EMJFLIFNGDN<LNOIHDNDMKF>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MHOOKHBMJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public MHOOKHBMJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5100D60", Offset = "0x50FFD60", VA = "0x185100D60")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] CNDPCEPOKCG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly JAKDBMPFENE AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50FE830", Offset = "0x50FD830", VA = "0x1850FE830", Slot = "5")]
	protected override void ONJMPJKCELG(LNOIHDNDMKF ADIELDAOJPG, IDictionary<object, object> MPLJOBCIMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50FEBB0", Offset = "0x50FDBB0", VA = "0x1850FEBB0", Slot = "6")]
	public override LNOIHDNDMKF PKACOGLGLPC(IDictionary<object, object> MPLJOBCIMCD)
	{
		return default(LNOIHDNDMKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50FF5A0", Offset = "0x50FE5A0", VA = "0x1850FF5A0")]
	public JAKDBMPFENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IJOLLFACODL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string KBGAFFAICDC([NotNull] byte[] HPEACFNBKMA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum CBDLAMAHAAB : byte
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
	private readonly struct DPJFBKIJOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly CBDLAMAHAAB AMGKAFPJGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly Guid GAPBPNDGBFA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x43F5FD0", Offset = "0x43F4FD0", VA = "0x1843F5FD0")]
		public DPJFBKIJOKM(CBDLAMAHAAB LOHHANPNGIF, Guid EMLPKEBEMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x50F7C30", Offset = "0x50F6C30", VA = "0x1850F7C30")]
		public bool KOOAEOKKCJO(DPJFBKIJOKM GOAJJPLEOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50F7B40", Offset = "0x50F6B40", VA = "0x1850F7B40", Slot = "0")]
		public override bool Equals(object NHBCHHMAJOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50F7C00", Offset = "0x50F6C00", VA = "0x1850F7C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KNKMCFFJMNN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly bool PDAEIDENMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly CBDLAMAHAAB AMGKAFPJGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly Guid[] LHLBCNHGEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T MJBCCABCEEL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3014CA0", Offset = "0x3013CA0", VA = "0x183014CA0")]
		public static KNKMCFFJMNN<T> EHAFEAPBCKL(LNOIHDNDMKF OPLINAFGPDK, Func<byte[], T> KJKEBGGODPJ)
		{
			return default(KNKMCFFJMNN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3014F80", Offset = "0x3013F80", VA = "0x183014F80")]
		public KNKMCFFJMNN(CBDLAMAHAAB LOHHANPNGIF, Guid[] GCCICDNCIIN, T HPEACFNBKMA, bool PCOLMNBIDHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3014DF0", Offset = "0x3013DF0", VA = "0x183014DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LFDJONJDDDD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JBHLDOEHDEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TaskCompletionSource<LNOIHDNDMKF> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public LFDJONJDDDD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public JBHLDOEHDEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x50FF5E0", Offset = "0x50FE5E0", VA = "0x1850FF5E0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x50FF630", Offset = "0x50FE630", VA = "0x1850FF630")]
			internal NFKGENJCBEI <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DPJJAIDMOMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public JKMEDIMNNGA.PCBEFIDJKKD itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public DPJJAIDMOMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x50F7C90", Offset = "0x50F6C90", VA = "0x1850F7C90")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct OCDIJBFAEHH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<LNOIHDNDMKF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LFDJONJDDDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private JBHLDOEHDEG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<LNOIHDNDMKF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5100EE0", Offset = "0x50FFEE0", VA = "0x185100EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5101590", Offset = "0x5100590", VA = "0x185101590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ABGACDEGMDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CBDLAMAHAAB sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public ABGACDEGMDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x50F7800", Offset = "0x50F6800", VA = "0x1850F7800")]
			internal bool <ClearSlice>b__0(LNOIHDNDMKF bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly HGOFPCPBGKJ DDDCGHICLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string EDKKCOEOOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<LNOIHDNDMKF> ENNKPJAGACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private List<(JKMEDIMNNGA.PCBEFIDJKKD itemType, long totalStopwatchTicks)> AHIODOIBGFJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JGINNKLCHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x51006B0", Offset = "0x50FF6B0", VA = "0x1851006B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<LNOIHDNDMKF> GPHEMALOMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x51006F0", Offset = "0x50FF6F0", VA = "0x1851006F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5100610", Offset = "0x50FF610", VA = "0x185100610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5100790", Offset = "0x50FF790", VA = "0x185100790")]
		public LFDJONJDDDD(HGOFPCPBGKJ DDDCGHICLFB, string EDKKCOEOOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x51002E0", Offset = "0x50FF2E0", VA = "0x1851002E0")]
		[AsyncStateMachine(typeof(OCDIJBFAEHH))]
		public Task<LNOIHDNDMKF> CPKOKDICHFN(CancellationToken MCLPFBCBLEM, TimeSpan FKLAAAKHFFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5100420", Offset = "0x50FF420", VA = "0x185100420")]
		public void DDFGNBAKBHK(LNOIHDNDMKF ADIELDAOJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51004D0", Offset = "0x50FF4D0", VA = "0x1851004D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5100520", Offset = "0x50FF520", VA = "0x185100520")]
		public void EAINGDIHOHO(CBDLAMAHAAB LOHHANPNGIF, Guid ICEKBLFEGDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JHAIBAOHJMG : IEnumerable<(CBDLAMAHAAB, Guid)>, IEnumerable, IEnumerator<(CBDLAMAHAAB, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (CBDLAMAHAAB, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CBDLAMAHAAB sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CBDLAMAHAAB <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CBDLAMAHAAB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (CBDLAMAHAAB, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x298A1B0", Offset = "0x29891B0", VA = "0x18298A1B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((CBDLAMAHAAB, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x50FFC70", Offset = "0x50FEC70", VA = "0x1850FFC70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B64D0", Offset = "0x9B54D0", VA = "0x1809B64D0")]
		[DebuggerHidden]
		public JHAIBAOHJMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50FF950", Offset = "0x50FE950", VA = "0x1850FF950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50FFC20", Offset = "0x50FEC20", VA = "0x1850FFC20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50FFB70", Offset = "0x50FEB70", VA = "0x1850FFB70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CBDLAMAHAAB, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50FFB70", Offset = "0x50FEB70", VA = "0x1850FFB70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EFPIAHJCBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<LNOIHDNDMKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HJECJLMFJJN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<LNOIHDNDMKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x50F7D40", Offset = "0x50F6D40", VA = "0x1850F7D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50F8520", Offset = "0x50F7520", VA = "0x1850F8520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MCKIAEAFPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HJECJLMFJJN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<KNKMCFFJMNN<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x51009F0", Offset = "0x50FF9F0", VA = "0x1851009F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5100D10", Offset = "0x50FFD10", VA = "0x185100D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FAPOKLPHHCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<LNOIHDNDMKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HJECJLMFJJN pauseAfterListeningToken;

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
		private TaskAwaiter<LNOIHDNDMKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x50F8E30", Offset = "0x50F7E30", VA = "0x1850F8E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x50F9580", Offset = "0x50F8580", VA = "0x1850F9580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HNFEMLEFMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public HNFEMLEFMHN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EGOHGHAFFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<LNOIHDNDMKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private HNFEMLEFMHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HJECJLMFJJN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private KFFOAEJEPHJ <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<LNOIHDNDMKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x50F8570", Offset = "0x50F7570", VA = "0x1850F8570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x50F8DE0", Offset = "0x50F7DE0", VA = "0x1850F8DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IELCJMKFHHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<LNOIHDNDMKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HJECJLMFJJN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<LNOIHDNDMKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x50F9C30", Offset = "0x50F8C30", VA = "0x1850F9C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x50F9F60", Offset = "0x50F8F60", VA = "0x1850F9F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FHBGNHABBJL
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
			public FHBGNHABBJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5101660", Offset = "0x5100660", VA = "0x185101660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x51017C0", Offset = "0x51007C0", VA = "0x1851017C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public FHBGNHABBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x50F95D0", Offset = "0x50F85D0", VA = "0x1850F95D0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LAKIJGGDFGJ : IAsyncStateMachine
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
		public IJOLLFACODL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HJECJLMFJJN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HJECJLMFJJN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5100100", Offset = "0x50FF100", VA = "0x185100100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7EEFE0", Offset = "0x7EDFE0", VA = "0x1807EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class INOJHHFJJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public INOJHHFJJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x50FE760", Offset = "0x50FD760", VA = "0x1850FE760")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50FE7A0", Offset = "0x50FD7A0", VA = "0x1850FE7A0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x50FE7F0", Offset = "0x50FD7F0", VA = "0x1850FE7F0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CIEBDEBFNNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CBDLAMAHAAB sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public CIEBDEBFNNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x50F7AC0", Offset = "0x50F6AC0", VA = "0x1850F7AC0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class POOCNIDHHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CBDLAMAHAAB sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public POOCNIDHHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x51015E0", Offset = "0x51005E0", VA = "0x1851015E0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KIKMGOABHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public KIKMGOABHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x51000A0", Offset = "0x50FF0A0", VA = "0x1851000A0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MJKJKODEEAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public MJKJKODEEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5100E00", Offset = "0x50FFE00", VA = "0x185100E00")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AKLJGJDJHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public AKLJGJDJHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x50F7970", Offset = "0x50F6970", VA = "0x1850F7970")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GHKJNGCFMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public GHKJNGCFMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x50F9850", Offset = "0x50F8850", VA = "0x1850F9850")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ALONLEJDFFL
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
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ALONLEJDFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x50F7A60", Offset = "0x50F6A60", VA = "0x1850F7A60")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x50F7A00", Offset = "0x50F6A00", VA = "0x1850F7A00")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ILNMNILILGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ILNMNILILGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x50FE1E0", Offset = "0x50FD1E0", VA = "0x1850FE1E0")]
		internal bool <ClearSliceIds>b__3(DPJFBKIJOKM stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x50FE2E0", Offset = "0x50FD2E0", VA = "0x1850FE2E0")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x50FE520", Offset = "0x50FD520", VA = "0x1850FE520")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x50FE280", Offset = "0x50FD280", VA = "0x1850FE280")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly KBGAFFAICDC JDEJNNLPKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable NHLJINDDMBN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GKMAEMPGANM GBDCBJIMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LFDJONJDDDD LIJHNGMIECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HGOFPCPBGKJ DDDCGHICLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CMNCIEGMDKA ALGPPFAJBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HGMCOIIJAFA BMMGBDKNHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KBGAFFAICDC CHBCFLNMIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CKJDBNBCJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[CompilerGenerated]
	private Action<LNOIHDNDMKF> BBMEFOBJOOM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan KIEJNOEDDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan NMAEIMCFGJM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal static readonly CBDLAMAHAAB[] CCLKHLIIKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] CKBDGJNBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<DPJFBKIJOKM> EGLNCOGMOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private (CBDLAMAHAAB combinedSliceType, Guid[] sliceTypeIds)? FIFDMCJOCBI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x50FDDF0", Offset = "0x50FCDF0", VA = "0x1850FDDF0")]
	public IJOLLFACODL(HGOFPCPBGKJ DDDCGHICLFB, CMNCIEGMDKA ALGPPFAJBNI, HGMCOIIJAFA BMMGBDKNHME, [Optional] TimeSpan? EKDMFACMIEM, [Optional] KBGAFFAICDC BPIJBGPFEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x210D170", Offset = "0x210C170", VA = "0x18210D170")]
	public static IJOLLFACODL CPCMONNLAFN<TNetworking>(TNetworking DMPGLFNBANO, [Optional] TimeSpan? EKDMFACMIEM, [Optional] KBGAFFAICDC BPIJBGPFEGM) where TNetworking : HGOFPCPBGKJ, CMNCIEGMDKA, HGMCOIIJAFA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50FA880", Offset = "0x50F9880", VA = "0x1850FA880")]
	public void ALEEKPJPLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50FC770", Offset = "0x50FB770", VA = "0x1850FC770")]
	private TimeSpan MGNBAGHIOIH(TimeSpan? EKDMFACMIEM, int JEFIKPCMLFC = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x233FC30", Offset = "0x233EC30", VA = "0x18233FC30")]
	public bool OLKCGIKPOEI<T>(T COEDOBFCLLN, Func<T, byte[]> OAEPKMNGAFK, bool PCOLMNBIDHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50FD110", Offset = "0x50FC110", VA = "0x1850FD110")]
	public bool OLKCGIKPOEI(byte[] COEDOBFCLLN, int LANBJBADMLG, bool PCOLMNBIDHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50FAD50", Offset = "0x50F9D50", VA = "0x1850FAD50")]
	private static string BLIKBBCFIFI(CBDLAMAHAAB LOHHANPNGIF, Guid[] BMKNLLJGDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50FCE90", Offset = "0x50FBE90", VA = "0x1850FCE90")]
	[IteratorStateMachine(typeof(JHAIBAOHJMG))]
	private static IEnumerable<(CBDLAMAHAAB, Guid)> NJBBBFGDAGI(CBDLAMAHAAB AMINDKBBNMM, Guid[] BMKNLLJGDMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50FBA60", Offset = "0x50FAA60", VA = "0x1850FBA60")]
	[AsyncStateMachine(typeof(EFPIAHJCBLN))]
	public Task<LNOIHDNDMKF> HBBCKFAFHKD(CancellationToken MCLPFBCBLEM, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, [Optional] TimeSpan? EKDMFACMIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x50FCF10", Offset = "0x50FBF10", VA = "0x1850FCF10")]
	[AsyncStateMachine(typeof(MCKIAEAFPHK))]
	public Task<Guid> OAIEDPLLLMB(Guid DCEJHAALIJJ, CancellationToken MCLPFBCBLEM, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, [Optional] TimeSpan? FKLAAAKHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1CD0", Offset = "0x1FF0CD0", VA = "0x181FF1CD0")]
	[AsyncStateMachine(typeof(OIAPHNGBLNF))]
	public Task<KNKMCFFJMNN<T>> CJHFGDNGIIC<T>(T COEDOBFCLLN, Func<T, byte[]> OAEPKMNGAFK, Func<byte[], T> KJKEBGGODPJ, CancellationToken MCLPFBCBLEM, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, [Optional] TimeSpan? FKLAAAKHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50FB150", Offset = "0x50FA150", VA = "0x1850FB150")]
	[AsyncStateMachine(typeof(FAPOKLPHHCA))]
	public Task<LNOIHDNDMKF> CJHFGDNGIIC(byte[] COEDOBFCLLN, CancellationToken MCLPFBCBLEM, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, [Optional] TimeSpan? FKLAAAKHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50FBBC0", Offset = "0x50FABC0", VA = "0x1850FBBC0")]
	[AsyncStateMachine(typeof(EGOHGHAFFLL))]
	private Task<LNOIHDNDMKF> IKLKNBBICIL(byte[] COEDOBFCLLN, CancellationToken MCLPFBCBLEM, HJECJLMFJJN GFMICACDIPJ, HJECJLMFJJN PPCCCAHOMBN, TimeSpan? EKDMFACMIEM, Stopwatch OOOKOPGMMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50FCD20", Offset = "0x50FBD20", VA = "0x1850FCD20")]
	[AsyncStateMachine(typeof(IELCJMKFHHC))]
	private Task<LNOIHDNDMKF> NIPKMNNOCMB(byte[] COEDOBFCLLN, CancellationToken MCLPFBCBLEM, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, [Optional] TimeSpan? FKLAAAKHFFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50FB7C0", Offset = "0x50FA7C0", VA = "0x1850FB7C0")]
	[AsyncStateMachine(typeof(LAKIJGGDFGJ))]
	public Task GJIELOEGNCF(CancellationToken AFNHLPMKEOA, Func<CancellationToken, Task> KIOCIIDCJFO, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, int FNEFLCGECHA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1E90", Offset = "0x1FF0E90", VA = "0x181FF1E90")]
	[AsyncStateMachine(typeof(POFAOOCCNIP))]
	public Task<T> GJIELOEGNCF<T>(CancellationToken AFNHLPMKEOA, Func<CancellationToken, Task<T>> KIOCIIDCJFO, [Optional] HJECJLMFJJN GFMICACDIPJ, [Optional] HJECJLMFJJN PPCCCAHOMBN, int FNEFLCGECHA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2370", Offset = "0x1FF1370", VA = "0x181FF2370")]
	[AsyncStateMachine(typeof(EOCCMPEOEID))]
	private Task<(bool, T)> JPBPOLGDEAF<T>(Guid EMLPKEBEMIK, CancellationToken AFNHLPMKEOA, Func<CancellationToken, Task<T>> KIOCIIDCJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x50FD4F0", Offset = "0x50FC4F0", VA = "0x1850FD4F0")]
	public void PPDENGMPNGC(byte JLAEKMGBOII, int ADKJCHOGEBH, object EACAMIBELPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x50FB460", Offset = "0x50FA460", VA = "0x1850FB460")]
	public Guid FFNMFLDDFPG(Guid HCMOIHDACAL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50FB2C0", Offset = "0x50FA2C0", VA = "0x1850FB2C0")]
	internal static int CMNNPHBBGFM(CBDLAMAHAAB LOHHANPNGIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50FC320", Offset = "0x50FB320", VA = "0x1850FC320")]
	public bool LKANCBDJGOP(CBDLAMAHAAB LOHHANPNGIF, Guid EMLPKEBEMIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50FBFF0", Offset = "0x50FAFF0", VA = "0x1850FBFF0")]
	public void KFHNIJLBMPC(CBDLAMAHAAB LOHHANPNGIF, Guid EMLPKEBEMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50FD100", Offset = "0x50FC100", VA = "0x1850FD100")]
	private void OIBGHLFFLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50FA960", Offset = "0x50F9960", VA = "0x1850FA960")]
	internal (CBDLAMAHAAB, Guid[]) BCIDMCCPNBO(bool PGBAHOBMKHG = false)
	{
		return default((CBDLAMAHAAB, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50FB920", Offset = "0x50FA920", VA = "0x1850FB920")]
	private HashSet<Guid> HAMCDGBFPNP(CBDLAMAHAAB LOHHANPNGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50FCBA0", Offset = "0x50FBBA0", VA = "0x1850FCBA0")]
	private void NDOLKFKKNLD(CBDLAMAHAAB LOHHANPNGIF, Guid ICEKBLFEGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50FC950", Offset = "0x50FB950", VA = "0x1850FC950")]
	private void MLIBGMIHMEG(CBDLAMAHAAB LOHHANPNGIF, Guid ICEKBLFEGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50FA7F0", Offset = "0x50F97F0", VA = "0x1850FA7F0")]
	public static Func<Guid, bool> AEDNCEHFPDA(Guid ICEKBLFEGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50FD070", Offset = "0x50FC070", VA = "0x1850FD070")]
	public static Func<Guid, bool> ODOIMLKMJKE(Guid ICEKBLFEGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50FB370", Offset = "0x50FA370", VA = "0x1850FB370")]
	public void EAINGDIHOHO(CBDLAMAHAAB LOHHANPNGIF, Guid JKOIKJBBJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50F9FB0", Offset = "0x50F8FB0", VA = "0x1850F9FB0")]
	public void AEBKMHKHBLH(CBDLAMAHAAB LOHHANPNGIF, Func<Guid, bool> KPJOFECDGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50FB6B0", Offset = "0x50FA6B0", VA = "0x1850FB6B0")]
	private string GCMHHLNLEHO(byte[] HPEACFNBKMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50FBD40", Offset = "0x50FAD40", VA = "0x1850FBD40")]
	[CompilerGenerated]
	private object IMPLAHPHMAF(in (CBDLAMAHAAB st, Guid[] ids, byte[] mts) LMJLMIIJEAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50FAEA0", Offset = "0x50F9EA0", VA = "0x1850FAEA0")]
	[CompilerGenerated]
	private object CEPNGNDBGNJ(in (CBDLAMAHAAB rst, Guid[] ssids, byte[] pl) LMJLMIIJEAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NFKGENJCBEI : EBGAEEBEICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private List<(JKMEDIMNNGA.PCBEFIDJKKD itemType, long totalStopwatchTicks)> LFGHNHOCKFG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(JKMEDIMNNGA.PCBEFIDJKKD itemType, long totalStopwatchTicks)> AJIBHLMGMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E0140", Offset = "0x5DF140", VA = "0x1805E0140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5100E60", Offset = "0x50FFE60", VA = "0x185100E60")]
	public NFKGENJCBEI(TimeSpan FKLAAAKHFFA, List<(JKMEDIMNNGA.PCBEFIDJKKD itemType, long totalStopwatchTicks)> LFGHNHOCKFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IAFIICGKNJI : KFFOAEJEPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct FNEJHMFOLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly Guid FENPKHHGNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly int MNIGCKHDNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly int HCBCLPFCAII;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x50F9840", Offset = "0x50F8840", VA = "0x1850F9840")]
		public FNEJHMFOLFI(Guid BBFDNFEGKJF, int ICCLPJMBOOD, int BKAEBBHMEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x50F9770", Offset = "0x50F8770", VA = "0x1850F9770")]
		public static byte[] PBAEFNNDLEC(FNEJHMFOLFI ADIELDAOJPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x50F96F0", Offset = "0x50F86F0", VA = "0x1850F96F0")]
		private static byte[] BCFOKNBHAHK(int FBIMLOLEMBB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Guid BBFDNFEGKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly IJOLLFACODL GOJDHOFHJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool EDPDJIGDNCC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x50F9BD0", Offset = "0x50F8BD0", VA = "0x1850F9BD0")]
	public IAFIICGKNJI(Guid BBFDNFEGKJF, IJOLLFACODL GOJDHOFHJFO, HGMCOIIJAFA DMPGLFNBANO, CancellationToken AFNHLPMKEOA, [Optional] JMEMPHJNNJJ NNOKBKHOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x50F9A40", Offset = "0x50F8A40", VA = "0x1850F9A40", Slot = "5")]
	protected override void HHNMEELJHFH(int MEOKJHHDAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LNOIHDNDMKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool PDAEIDENMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly IJOLLFACODL.CBDLAMAHAAB AMGKAFPJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Guid[] LHLBCNHGEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte[] MJBCCABCEEL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3014F30", Offset = "0x3013F30", VA = "0x183014F30")]
	public LNOIHDNDMKF(IJOLLFACODL.CBDLAMAHAAB LOHHANPNGIF, [NotNull] Guid[] GCCICDNCIIN, byte[] HPEACFNBKMA, bool PCOLMNBIDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5100860", Offset = "0x50FF860", VA = "0x185100860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class EMJFLIFNGDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31D3390", Offset = "0x31D2390", VA = "0x1831D3390", Slot = "4")]
	public void GMFGJOHBDJC(T ADIELDAOJPG, IDictionary<object, object> MPLJOBCIMCD, bool FJGHKPDBOOA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ONJMPJKCELG(T ADIELDAOJPG, IDictionary<object, object> MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T PKACOGLGLPC(IDictionary<object, object> MPLJOBCIMCD);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31D3220", Offset = "0x31D2220", VA = "0x1831D3220", Slot = "7")]
	public bool AAFJMCHDDOO(IDictionary<object, object> MPLJOBCIMCD, out T LICEDGECIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected EMJFLIFNGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KFFOAEJEPHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool JMEMPHJNNJJ(int OLEHFFFANKM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool OPPEGHNMEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly HGMCOIIJAFA GOLNBAHAEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken AFNHLPMKEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken DKFCGHOOCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly JMEMPHJNNJJ NNOKBKHOCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource LCJEIDMFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource COMGJFCDLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int LKMKHCGDCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HBIPPBCPDPP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken ILFLABPFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50FFE10", Offset = "0x50FEE10", VA = "0x1850FFE10")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NEMKLHMFJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50FFD40", Offset = "0x50FED40", VA = "0x1850FFD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x50FFEC0", Offset = "0x50FEEC0", VA = "0x1850FFEC0")]
	public KFFOAEJEPHJ(HGMCOIIJAFA DMPGLFNBANO, CancellationToken AFNHLPMKEOA, [Optional] JMEMPHJNNJJ NNOKBKHOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E32250", Offset = "0x2E31250", VA = "0x182E32250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE30", Offset = "0x50FEE30", VA = "0x1850FFE30")]
	private void OGOHOANCKLG(IOILELHCGCN AKHGHJLLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x50FFD90", Offset = "0x50FED90", VA = "0x1850FFD90")]
	protected void DGDELGHPEPI(int MEOKJHHDAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50FFDF0", Offset = "0x50FEDF0", VA = "0x1850FFDF0", Slot = "5")]
	protected virtual void HHNMEELJHFH(int MEOKJHHDAMG)
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
