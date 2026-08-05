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
internal class MDNMIJHHNGO : global::PFGCPLEFLPF<MECONGMAEID>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GALDDKCCNOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GALDDKCCNOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0950", Offset = "0x4DAEF50", VA = "0x184DB0950")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] KKFLOAGOHJI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly MDNMIJHHNGO NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2FA0", Offset = "0x4DB15A0", VA = "0x184DB2FA0", Slot = "5")]
	protected override void DBBJBGCLDDF(MECONGMAEID EPAKPJCIEHE, IDictionary<object, object> OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DB32D0", Offset = "0x4DB18D0", VA = "0x184DB32D0", Slot = "6")]
	public override MECONGMAEID IACEKGNLJIN(IDictionary<object, object> OGNHKENMEGF)
	{
		return default(MECONGMAEID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3BB0", Offset = "0x4DB21B0", VA = "0x184DB3BB0")]
	public MDNMIJHHNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NGDFFMAGHLP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string JNLHFGNHNED([NotNull] byte[] JMPKGJCDKLN);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum GFNDHDDKPOG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct LKHIJNCFNJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly GFNDHDDKPOG IDHBIGLGIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly Guid PNDIENDBNOE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40ECD10", Offset = "0x40EB310", VA = "0x1840ECD10")]
		public LKHIJNCFNJF(GFNDHDDKPOG OEBPDMDLHPB, Guid BKNBDDFONFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2910", Offset = "0x4DB0F10", VA = "0x184DB2910")]
		public bool EODIBPOHCMG(LKHIJNCFNJF GJPJDOANCNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2970", Offset = "0x4DB0F70", VA = "0x184DB2970", Slot = "0")]
		public override bool Equals(object FIEDOLNFNLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2A30", Offset = "0x4DB1030", VA = "0x184DB2A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NOPNOIPLHEL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate bool IIPFLAEIFBJ(BMNAGFLMHFA JLDONLICNFI);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool ECMCAACONHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly GKPGABPIHEL KKBKNLLLIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationToken OLMBFPIKDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly CancellationToken CMNLIOGPMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly IIPFLAEIFBJ CPJGFPFEKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationTokenSource FAIIJFHEHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly CancellationTokenSource ODHHLHIHPHM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CancellationToken HKNFEFIOGEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4DB7F40", Offset = "0x4DB6540", VA = "0x184DB7F40")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HEMDOFGBELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4DB7EF0", Offset = "0x4DB64F0", VA = "0x184DB7EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4DB7FA0", Offset = "0x4DB65A0", VA = "0x184DB7FA0")]
		public NOPNOIPLHEL(GKPGABPIHEL KKBKNLLLIDH, CancellationToken OLMBFPIKDDC, [Optional] IIPFLAEIFBJ CPJGFPFEKPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DB7F60", Offset = "0x4DB6560", VA = "0x184DB7F60")]
		private void IKKFFDIGJGM(BMNAGFLMHFA LIBIEOPEJBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4DB7E30", Offset = "0x4DB6430", VA = "0x184DB7E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct IDBIFKBBCPL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly GFNDHDDKPOG IDHBIGLGIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Guid[] OCGFDBNOEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly T NAKDILCCMIC;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3420E40", Offset = "0x341F440", VA = "0x183420E40")]
		public static IDBIFKBBCPL<T> KEFLMHIHFCB(MECONGMAEID CNIFMIANALM, Func<byte[], T> ANJPPHDMNJK)
		{
			return default(IDBIFKBBCPL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x34210F0", Offset = "0x341F6F0", VA = "0x1834210F0")]
		public IDBIFKBBCPL(GFNDHDDKPOG OEBPDMDLHPB, Guid[] EDEGBOPKJCG, T JMPKGJCDKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3420F70", Offset = "0x341F570", VA = "0x183420F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class LLFLGJHAHJB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EKKBCCOKDJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<MECONGMAEID> newMessageTaskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public EKKBCCOKDJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4DB0810", Offset = "0x4DAEE10", VA = "0x184DB0810")]
			internal void <AwaitNextMessage>b__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct HGCBMOMLEGP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<MECONGMAEID> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LLFLGJHAHJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private EKKBCCOKDJJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<MECONGMAEID> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4DB1380", Offset = "0x4DAF980", VA = "0x184DB1380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4DB19C0", Offset = "0x4DAFFC0", VA = "0x184DB19C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DAIAPFBNMBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public GFNDHDDKPOG sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public DAIAPFBNMBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4DB02C0", Offset = "0x4DAE8C0", VA = "0x184DB02C0")]
			internal bool <ClearSlice>b__0(MECONGMAEID bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly string EFNNCDNLBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly List<MECONGMAEID> CLPPDALBAMG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DBPLNFHJBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4DB2A60", Offset = "0x4DB1060", VA = "0x184DB2A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		private event Action<MECONGMAEID> LICKPAHFEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4DB2D80", Offset = "0x4DB1380", VA = "0x184DB2D80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4DB2BA0", Offset = "0x4DB11A0", VA = "0x184DB2BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2F10", Offset = "0x4DB1510", VA = "0x184DB2F10")]
		public LLFLGJHAHJB(string EFNNCDNLBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2C40", Offset = "0x4DB1240", VA = "0x184DB2C40")]
		[AsyncStateMachine(typeof(HGCBMOMLEGP))]
		public Task<MECONGMAEID> KHBMNAPEEEB(CancellationToken CMOIBOJIACL, TimeSpan HFMGPPJGPEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2AF0", Offset = "0x4DB10F0", VA = "0x184DB2AF0")]
		public void HNGLENAGHDK(MECONGMAEID EPAKPJCIEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2AA0", Offset = "0x4DB10A0", VA = "0x184DB2AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2E20", Offset = "0x4DB1420", VA = "0x184DB2E20")]
		public void OIFKKGBJALN(GFNDHDDKPOG OEBPDMDLHPB, Guid IAKMMHHICJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BEHKEFELENL : IEnumerable<(GFNDHDDKPOG, Guid)>, IEnumerable, IEnumerator<(GFNDHDDKPOG, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (GFNDHDDKPOG, Guid) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GFNDHDDKPOG sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GFNDHDDKPOG <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private GFNDHDDKPOG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private (GFNDHDDKPOG, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2964EC0", Offset = "0x29634C0", VA = "0x182964EC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((GFNDHDDKPOG, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4DAF910", Offset = "0x4DADF10", VA = "0x184DAF910", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x935250", Offset = "0x933850", VA = "0x180935250")]
		[DebuggerHidden]
		public BEHKEFELENL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF5F0", Offset = "0x4DADBF0", VA = "0x184DAF5F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF8C0", Offset = "0x4DADEC0", VA = "0x184DAF8C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF810", Offset = "0x4DADE10", VA = "0x184DAF810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(GFNDHDDKPOG, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceType,System.Guid)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF810", Offset = "0x4DADE10", VA = "0x184DAF810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GCFHBHKOHHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<MECONGMAEID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EGHNIDJHOFI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4DB09F0", Offset = "0x4DAEFF0", VA = "0x184DB09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4DB1210", Offset = "0x4DAF810", VA = "0x184DB1210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EJMBLDBLFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EGHNIDJHOFI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<IDBIFKBBCPL<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4DB04A0", Offset = "0x4DAEAA0", VA = "0x184DB04A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4DB07C0", Offset = "0x4DAEDC0", VA = "0x184DB07C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IIOLHNONHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<MECONGMAEID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public EGHNIDJHOFI pauseAfterListeningToken;

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
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4DB1A10", Offset = "0x4DB0010", VA = "0x184DB1A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2160", Offset = "0x4DB0760", VA = "0x184DB2160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DADPJLMDAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<MECONGMAEID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public EGHNIDJHOFI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private NOPNOIPLHEL <masterSwitchScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4DAFA50", Offset = "0x4DAE050", VA = "0x184DAFA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0270", Offset = "0x4DAE870", VA = "0x184DB0270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PBKJOJDFIFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder<MECONGMAEID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EGHNIDJHOFI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8200", Offset = "0x4DB6800", VA = "0x184DB8200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8530", Offset = "0x4DB6B30", VA = "0x184DB8530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GODJFAFBIHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public GODJFAFBIHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4DB8640", Offset = "0x4DB6C40", VA = "0x184DB8640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4DB87A0", Offset = "0x4DB6DA0", VA = "0x184DB87A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GODJFAFBIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB1260", Offset = "0x4DAF860", VA = "0x184DB1260")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JPIBCMHHNJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NGDFFMAGHLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EGHNIDJHOFI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public EGHNIDJHOFI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4DB21B0", Offset = "0x4DB07B0", VA = "0x184DB21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MMBAKOKIMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public MMBAKOKIMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3D80", Offset = "0x4DB2380", VA = "0x184DB3D80")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3DC0", Offset = "0x4DB23C0", VA = "0x184DB3DC0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3E10", Offset = "0x4DB2410", VA = "0x184DB3E10")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EOJBAOIALIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GFNDHDDKPOG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public EOJBAOIALIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4DB08D0", Offset = "0x4DAEED0", VA = "0x184DB08D0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DIILOGPOBOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GFNDHDDKPOG sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DIILOGPOBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB0420", Offset = "0x4DAEA20", VA = "0x184DB0420")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OGNNECEAPBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public OGNNECEAPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8110", Offset = "0x4DB6710", VA = "0x184DB8110")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CGKKHBEGGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public CGKKHBEGGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF9F0", Offset = "0x4DADFF0", VA = "0x184DAF9F0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BIDBOACADBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BIDBOACADBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4DAF960", Offset = "0x4DADF60", VA = "0x184DAF960")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OHGKCIDGBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public OHGKCIDGBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8170", Offset = "0x4DB6770", VA = "0x184DB8170")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class POMFNMMCION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public POMFNMMCION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4DB85E0", Offset = "0x4DB6BE0", VA = "0x184DB85E0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8580", Offset = "0x4DB6B80", VA = "0x184DB8580")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LAFGPLBEAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LAFGPLBEAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2390", Offset = "0x4DB0990", VA = "0x184DB2390")]
		internal bool <ClearSliceIds>b__3(LKHIJNCFNJF stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2490", Offset = "0x4DB0A90", VA = "0x184DB2490")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4DB26D0", Offset = "0x4DB0CD0", VA = "0x184DB26D0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2430", Offset = "0x4DB0A30", VA = "0x184DB2430")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly JNLHFGNHNED NCHKNENKEOG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable CGMCHBCICFD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KLLALGMDGKB PGDICIKEMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LLFLGJHAHJB GFNILAIAFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DCCBOMHGGLA FCOLINCDNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BJOCHKNLABA CNDFBHNPDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GKPGABPIHEL KHLPKFMFOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JNLHFGNHNED IMPAJLCCHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PGGNJMMOIKA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal static readonly GFNDHDDKPOG[] HBOKLPAEKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HashSet<Guid>[] DCNIDKEONBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<LKHIJNCFNJF> IIPONPOMGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private (GFNDHDDKPOG combinedSliceType, Guid[] sliceTypeIds)? GBHMKABODJL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7AC0", Offset = "0x4DB60C0", VA = "0x184DB7AC0")]
	public NGDFFMAGHLP(DCCBOMHGGLA FCOLINCDNIJ, BJOCHKNLABA CNDFBHNPDHD, GKPGABPIHEL KHLPKFMFOLB, [Optional] JNLHFGNHNED GEIPEOOIAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DA00A0", Offset = "0x1D9E6A0", VA = "0x181DA00A0")]
	public static NGDFFMAGHLP LJNLMFJKBMB<TNetworking>(TNetworking KKBKNLLLIDH, [Optional] JNLHFGNHNED GEIPEOOIAPL) where TNetworking : DCCBOMHGGLA, BJOCHKNLABA, GKPGABPIHEL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5CB0", Offset = "0x4DB42B0", VA = "0x184DB5CB0")]
	public void HLHLNLIFMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7660", Offset = "0x1EF5C60", VA = "0x181EF7660")]
	public bool JLPBMOCCKDK<T>(T BLFOLMDAAAG, Func<T, byte[]> NPKKNDFIJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4DB66A0", Offset = "0x4DB4CA0", VA = "0x184DB66A0")]
	public bool JLPBMOCCKDK(byte[] BLFOLMDAAAG, int FFKMBKJCEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4490", Offset = "0x4DB2A90", VA = "0x184DB4490")]
	private static string CNKLOFGEOEM(GFNDHDDKPOG OEBPDMDLHPB, Guid[] CCFBNCCKMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5D90", Offset = "0x4DB4390", VA = "0x184DB5D90")]
	[IteratorStateMachine(typeof(BEHKEFELENL))]
	private static IEnumerable<(GFNDHDDKPOG, Guid)> HOJBDLFJDDP(GFNDHDDKPOG PPLHEHMKMPF, Guid[] CCFBNCCKMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4330", Offset = "0x4DB2930", VA = "0x184DB4330")]
	[AsyncStateMachine(typeof(GCFHBHKOHHL))]
	public Task<MECONGMAEID> CBAKAIIDDGC(CancellationToken CMOIBOJIACL, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, [Optional] TimeSpan? HFMGPPJGPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6540", Offset = "0x4DB4B40", VA = "0x184DB6540")]
	[AsyncStateMachine(typeof(EJMBLDBLFFP))]
	public Task<Guid> JINJLCDLOFI(Guid MNHKJONKOLI, CancellationToken CMOIBOJIACL, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, [Optional] TimeSpan? HFMGPPJGPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2647A90", Offset = "0x2646090", VA = "0x182647A90")]
	[AsyncStateMachine(typeof(IBJJEMAGIIG))]
	public Task<IDBIFKBBCPL<T>> NHHIBKGACAO<T>(T BLFOLMDAAAG, Func<T, byte[]> NPKKNDFIJMB, Func<byte[], T> ANJPPHDMNJK, CancellationToken CMOIBOJIACL, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, [Optional] TimeSpan? HFMGPPJGPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7090", Offset = "0x4DB5690", VA = "0x184DB7090")]
	[AsyncStateMachine(typeof(IIOLHNONHNN))]
	public Task<MECONGMAEID> NHHIBKGACAO(byte[] BLFOLMDAAAG, CancellationToken CMOIBOJIACL, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, [Optional] TimeSpan? HFMGPPJGPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6A70", Offset = "0x4DB5070", VA = "0x184DB6A70")]
	[AsyncStateMachine(typeof(DADPJLMDAND))]
	private Task<MECONGMAEID> KIOMOLJFMEE(byte[] BLFOLMDAAAG, CancellationToken CMOIBOJIACL, EGHNIDJHOFI EGMPPOOOFGB, EGHNIDJHOFI JOFEOMNADHF, TimeSpan? HFMGPPJGPEM, Stopwatch GHPKJANMNDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6BF0", Offset = "0x4DB51F0", VA = "0x184DB6BF0")]
	[AsyncStateMachine(typeof(PBKJOJDFIFI))]
	private Task<MECONGMAEID> LBFHGFJBDIM(byte[] BLFOLMDAAAG, CancellationToken CMOIBOJIACL, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, [Optional] TimeSpan? HFMGPPJGPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DB72B0", Offset = "0x4DB58B0", VA = "0x184DB72B0")]
	[AsyncStateMachine(typeof(JPIBCMHHNJL))]
	public Task NPHEFCIJOJA(CancellationToken OLMBFPIKDDC, Func<CancellationToken, Task> PAGPDEJKFHI, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, int GODGKECEJNK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2647C50", Offset = "0x2646250", VA = "0x182647C50")]
	[AsyncStateMachine(typeof(JEBLOCGHHLO))]
	public Task<T> NPHEFCIJOJA<T>(CancellationToken OLMBFPIKDDC, Func<CancellationToken, Task<T>> PAGPDEJKFHI, [Optional] EGHNIDJHOFI EGMPPOOOFGB, [Optional] EGHNIDJHOFI JOFEOMNADHF, int GODGKECEJNK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2647420", Offset = "0x2645A20", VA = "0x182647420")]
	[AsyncStateMachine(typeof(KDECNDJOFPE))]
	private Task<(bool, T)> MHBOAOEJKMF<T>(Guid BKNBDDFONFM, CancellationToken OLMBFPIKDDC, Func<CancellationToken, Task<T>> PAGPDEJKFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5E10", Offset = "0x4DB4410", VA = "0x184DB5E10")]
	public void JGEHGMKNOII(byte JPPKOANDKCC, int HNIPPCIGGDF, object BIJBMBCMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3E50", Offset = "0x4DB2450", VA = "0x184DB3E50")]
	public Guid ACIBJHIOLFF(Guid KDPKGIKDHGH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7200", Offset = "0x4DB5800", VA = "0x184DB7200")]
	internal static int NOFBBJALJBF(GFNDHDDKPOG OEBPDMDLHPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7500", Offset = "0x4DB5B00", VA = "0x184DB7500")]
	public bool PHOIJNAHNAC(GFNDHDDKPOG OEBPDMDLHPB, Guid BKNBDDFONFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5250", Offset = "0x4DB3850", VA = "0x184DB5250")]
	public void EPCDIMODAGK(GFNDHDDKPOG OEBPDMDLHPB, Guid BKNBDDFONFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4670", Offset = "0x4DB2C70", VA = "0x184DB4670")]
	private void DHGONCOBPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5580", Offset = "0x4DB3B80", VA = "0x184DB5580")]
	internal (GFNDHDDKPOG, Guid[]) EPMKJFCANCL(bool BJOFCCKGLFK = false)
	{
		return default((GFNDHDDKPOG, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4680", Offset = "0x4DB2C80", VA = "0x184DB4680")]
	private HashSet<Guid> DPDGKFKMAIK(GFNDHDDKPOG OEBPDMDLHPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4DB40A0", Offset = "0x4DB26A0", VA = "0x184DB40A0")]
	private void BFHDJNJGCEP(GFNDHDDKPOG OEBPDMDLHPB, Guid IAKMMHHICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5000", Offset = "0x4DB3600", VA = "0x184DB5000")]
	private void EOAKBDOGBBE(GFNDHDDKPOG OEBPDMDLHPB, Guid IAKMMHHICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5970", Offset = "0x4DB3F70", VA = "0x184DB5970")]
	public static Func<Guid, bool> FIOKFBMGGNJ(Guid IAKMMHHICJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DB45E0", Offset = "0x4DB2BE0", VA = "0x184DB45E0")]
	public static Func<Guid, bool> CNMAEEHHGPF(Guid IAKMMHHICJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7410", Offset = "0x4DB5A10", VA = "0x184DB7410")]
	public void OIFKKGBJALN(GFNDHDDKPOG OEBPDMDLHPB, Guid MOCGNKJBNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DB47C0", Offset = "0x4DB2DC0", VA = "0x184DB47C0")]
	public void ENCCOGPCDIH(GFNDHDDKPOG OEBPDMDLHPB, Func<Guid, bool> OFOHFCPEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4220", Offset = "0x4DB2820", VA = "0x184DB4220")]
	private string BOKMMCIFDEP(byte[] JMPKGJCDKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5A00", Offset = "0x4DB4000", VA = "0x184DB5A00")]
	[CompilerGenerated]
	private object HGDKDLGBPJP(in (GFNDHDDKPOG st, Guid[] ids, byte[] mts) DFPAFIPCLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6D60", Offset = "0x4DB5360", VA = "0x184DB6D60")]
	[CompilerGenerated]
	private object LGPCDBMAJGE(in (GFNDHDDKPOG rst, Guid[] ssids, byte[] pl) DFPAFIPCLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4DB7010", Offset = "0x4DB5610", VA = "0x184DB7010")]
	[CompilerGenerated]
	private bool NEKFMFMAHGP(BMNAGFLMHFA LIBIEOPEJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MECONGMAEID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly NGDFFMAGHLP.GFNDHDDKPOG IDHBIGLGIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Guid[] OCGFDBNOEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte[] NAKDILCCMIC;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x34210B0", Offset = "0x341F6B0", VA = "0x1834210B0")]
	public MECONGMAEID(NGDFFMAGHLP.GFNDHDDKPOG OEBPDMDLHPB, [NotNull] Guid[] EDEGBOPKJCG, byte[] JMPKGJCDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3BF0", Offset = "0x4DB21F0", VA = "0x184DB3BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class PFGCPLEFLPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x399FA10", Offset = "0x399E010", VA = "0x18399FA10", Slot = "4")]
	public void LGAFELIGCJA(T EPAKPJCIEHE, IDictionary<object, object> OGNHKENMEGF, bool KFAIGFKEGBE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void DBBJBGCLDDF(T EPAKPJCIEHE, IDictionary<object, object> OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T IACEKGNLJIN(IDictionary<object, object> OGNHKENMEGF);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x399FAC0", Offset = "0x399E0C0", VA = "0x18399FAC0", Slot = "7")]
	public bool NILIJJLJMPI(IDictionary<object, object> OGNHKENMEGF, out T GMKPJGGPBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
	protected PFGCPLEFLPF()
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
