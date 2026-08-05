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
internal class ADBIICLPPIC : global::PEFNKMFFPFP<KPLOHOPAIAO>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CGNENMOPNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public CGNENMOPNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61768C0", Offset = "0x61756C0", VA = "0x1861768C0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] DMOKKIPACIH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ADBIICLPPIC JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6170BE0", Offset = "0x616F9E0", VA = "0x186170BE0", Slot = "5")]
	protected override void IGAGDOCAOCO(KPLOHOPAIAO LMLMHJKGDCH, IDictionary<object, object> FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6170070", Offset = "0x616EE70", VA = "0x186170070", Slot = "6")]
	public override KPLOHOPAIAO CJKIJAOEIBM(IDictionary<object, object> FILAKGLBGGA)
	{
		return default(KPLOHOPAIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6171270", Offset = "0x6170070", VA = "0x186171270")]
	public ADBIICLPPIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BCJGNNLDEJN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string EFFNLAHPEAP([NotNull] byte[] BNKBFACGLIM);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct ADJLHAJLJIN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly OEHDKGMEHOM KIJAAEIDJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool EGEEPDHIMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T GOMOKJBFMDP;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6030", Offset = "0x3FE4E30", VA = "0x183FE6030")]
		public static ADJLHAJLJIN<T> ECDMOAFINEL(KPLOHOPAIAO CLDIIPNOPMF, Func<byte[], T> NHMNHLNFNDL)
		{
			return default(ADJLHAJLJIN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6290", Offset = "0x3FE5090", VA = "0x183FE6290")]
		public ADJLHAJLJIN(OEHDKGMEHOM KDBILDMBKKJ, T BNKBFACGLIM, bool PKHMJKMFHHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6140", Offset = "0x3FE4F40", VA = "0x183FE6140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NIFCLKBFPBG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FBBJPHEEAPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<KPLOHOPAIAO> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public NIFCLKBFPBG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public FBBJPHEEAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6177170", Offset = "0x6175F70", VA = "0x186177170")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x61771C0", Offset = "0x6175FC0", VA = "0x1861771C0")]
			internal HDBMIHEDBGD <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MBKGLCIOBIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public BGNOACFBGFB.BHFGOFNPGDI itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public MBKGLCIOBIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x617A080", Offset = "0x6178E80", VA = "0x18617A080")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct JBDOBLCLIFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<KPLOHOPAIAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NIFCLKBFPBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private FBBJPHEEAPK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<KPLOHOPAIAO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6178B30", Offset = "0x6177930", VA = "0x186178B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6179340", Offset = "0x6178140", VA = "0x186179340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MBLNLNMEMCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public HGMEHLOCFLE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public MBLNLNMEMCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x617A150", Offset = "0x6178F50", VA = "0x18617A150")]
			internal bool <ClearSlice>b__0(KPLOHOPAIAO bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JLJCIAPHMDI OMLIPEAAELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string LGMCIBMEEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<KPLOHOPAIAO> DKLMMIIDMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(BGNOACFBGFB.BHFGOFNPGDI itemType, long totalStopwatchTicks)> IJGMLNAFHGD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CKCKMAPAJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x617B3F0", Offset = "0x617A1F0", VA = "0x18617B3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<KPLOHOPAIAO> DAPMHACDMHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x617AF30", Offset = "0x6179D30", VA = "0x18617AF30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x617B020", Offset = "0x6179E20", VA = "0x18617B020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x617B440", Offset = "0x617A240", VA = "0x18617B440")]
		public NIFCLKBFPBG(JLJCIAPHMDI OMLIPEAAELF, string LGMCIBMEEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x617B0C0", Offset = "0x6179EC0", VA = "0x18617B0C0")]
		[AsyncStateMachine(typeof(JBDOBLCLIFE))]
		public Task<KPLOHOPAIAO> FJPPJALBALM(CancellationToken NIEOBBGKEFJ, TimeSpan NNEBMFOPCOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x617B210", Offset = "0x617A010", VA = "0x18617B210")]
		public void HNLLGKNCIDM(KPLOHOPAIAO LMLMHJKGDCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x617AFD0", Offset = "0x6179DD0", VA = "0x18617AFD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x617B2C0", Offset = "0x617A0C0", VA = "0x18617B2C0")]
		public void JFDFBLKMLKF(HGMEHLOCFLE MGLGMPFEOHB, Guid KCHLIHHPAKF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AGCGIHAGOAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<KPLOHOPAIAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DGAJACEMLNI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61712B0", Offset = "0x61700B0", VA = "0x1861712B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6171BF0", Offset = "0x61709F0", VA = "0x186171BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AJENKCOGILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public DGAJACEMLNI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<ADJLHAJLJIN<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6171C40", Offset = "0x6170A40", VA = "0x186171C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6171FF0", Offset = "0x6170DF0", VA = "0x186171FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HCLDBDJJFMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<KPLOHOPAIAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DGAJACEMLNI pauseAfterListeningToken;

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
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6178010", Offset = "0x6176E10", VA = "0x186178010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6178910", Offset = "0x6177710", VA = "0x186178910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ENELHANEOCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ENELHANEOCH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NAEELDFHEIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<KPLOHOPAIAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ENELHANEOCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DGAJACEMLNI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private PIHMHNLDCFL <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x617A2C0", Offset = "0x61790C0", VA = "0x18617A2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x617AD90", Offset = "0x6179B90", VA = "0x18617AD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KOAJHOKKMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<KPLOHOPAIAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DGAJACEMLNI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<KPLOHOPAIAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61796B0", Offset = "0x61784B0", VA = "0x1861796B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6179A90", Offset = "0x6178890", VA = "0x186179A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GAKJKIDOPKD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public GAKJKIDOPKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x617CB00", Offset = "0x617B900", VA = "0x18617CB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x617CC70", Offset = "0x617BA70", VA = "0x18617CC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GAKJKIDOPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61775C0", Offset = "0x61763C0", VA = "0x1861775C0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct OELDHGPCKHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BCJGNNLDEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DGAJACEMLNI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DGAJACEMLNI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x617C300", Offset = "0x617B100", VA = "0x18617C300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PJGCCKJANEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PJGCCKJANEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x617CA60", Offset = "0x617B860", VA = "0x18617CA60")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x617CA10", Offset = "0x617B810", VA = "0x18617CA10")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KPNCLDHEEJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HGMEHLOCFLE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public KPNCLDHEEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6179ED0", Offset = "0x6178CD0", VA = "0x186179ED0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BNPKKLPNDMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public HGMEHLOCFLE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public BNPKKLPNDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6176820", Offset = "0x6175620", VA = "0x186176820")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AMFGNLFBPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public AMFGNLFBPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6172040", Offset = "0x6170E40", VA = "0x186172040")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FGHPNMPPPJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public FGHPNMPPPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6177550", Offset = "0x6176350", VA = "0x186177550")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LIBOPHAPEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public LIBOPHAPEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6179FF0", Offset = "0x6178DF0", VA = "0x186179FF0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CIAEGMDFKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public CIAEGMDFKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6176980", Offset = "0x6175780", VA = "0x186176980")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GDOFOJHEOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GDOFOJHEOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6177760", Offset = "0x6176560", VA = "0x186177760")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6177700", Offset = "0x6176500", VA = "0x186177700")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OJBBMPJBMPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public OJBBMPJBMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x617C540", Offset = "0x617B340", VA = "0x18617C540")]
		internal bool <ClearSliceIds>b__3(NHEDGBKAANP stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GHALHHPBPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GHALHHPBPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6177830", Offset = "0x6176630", VA = "0x186177830")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6177AB0", Offset = "0x61768B0", VA = "0x186177AB0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61777C0", Offset = "0x61765C0", VA = "0x1861777C0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly EFFNLAHPEAP JFDMEPAIGJL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable KNMBMHHJEIM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KDGMCGJBAGF ACLDDFFPDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NIFCLKBFPBG NFBONOKNDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JLJCIAPHMDI OMLIPEAAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KLCONECFFJG PFIBILBHNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GIMENMFNCMN DEPMKGCJDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EFFNLAHPEAP CLEAFAJPOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan BIAKADMGFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan FOFICCBAKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte OHBACNIDPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] DLHFNOKJLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<NHEDGBKAANP> DLHOJCDGFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private OEHDKGMEHOM? ONJNJHFJMPO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly KDGMCGJBAGF LMLKHGICOGB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly KDGMCGJBAGF OIEIABFOFFF;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<KPLOHOPAIAO> CGACJJOECID
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61731B0", Offset = "0x6171FB0", VA = "0x1861731B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6174190", Offset = "0x6172F90", VA = "0x186174190")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6176370", Offset = "0x6175170", VA = "0x186176370")]
	public BCJGNNLDEJN(JLJCIAPHMDI OMLIPEAAELF, KLCONECFFJG PFIBILBHNOF, GIMENMFNCMN DEPMKGCJDOP, [Optional] TimeSpan? HPLMCMMPDHG, [Optional] EFFNLAHPEAP IMMPKAADOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x38D6AD0", Offset = "0x38D58D0", VA = "0x1838D6AD0")]
	public static BCJGNNLDEJN BKEAAINCDGJ<TNetworking>(TNetworking GNPHKIFHPOM, [Optional] TimeSpan? HPLMCMMPDHG, [Optional] EFFNLAHPEAP IMMPKAADOFG) where TNetworking : JLJCIAPHMDI, KLCONECFFJG, GIMENMFNCMN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6174C50", Offset = "0x6173A50", VA = "0x186174C50")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6175CC0", Offset = "0x6174AC0", VA = "0x186175CC0")]
	private byte OEJHAFCJMOP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61733D0", Offset = "0x61721D0", VA = "0x1861733D0")]
	private TimeSpan ECMMAFFIFBO(TimeSpan? HPLMCMMPDHG, int MJKODALCAJB = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38D6FC0", Offset = "0x38D5DC0", VA = "0x1838D6FC0")]
	public bool IINKGDGIBJM<T>(T EPCBHDKOFNM, Func<T, byte[]> PPBHALAGCOC, bool PKHMJKMFHHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6174230", Offset = "0x6173030", VA = "0x186174230")]
	public bool IINKGDGIBJM(byte[] EPCBHDKOFNM, int EAFPDNPBHLP, bool PKHMJKMFHHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90")]
	private static string CDCOOGJGMBB(string LMLMHJKGDCH, string OEGNINEOMFI = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6173250", Offset = "0x6172050", VA = "0x186173250")]
	[AsyncStateMachine(typeof(AGCGIHAGOAO))]
	public Task<KPLOHOPAIAO> DOLNJHIFEKN(CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? HPLMCMMPDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6175FA0", Offset = "0x6174DA0", VA = "0x186175FA0")]
	[AsyncStateMachine(typeof(AJENKCOGILO))]
	public Task<Guid> PHJKKJDAKMK(Guid IMAFNHMKELP, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38D70E0", Offset = "0x38D5EE0", VA = "0x1838D70E0")]
	[AsyncStateMachine(typeof(GMDCCIEDELO))]
	public Task<ADJLHAJLJIN<T>> LHBBALHJJFE<T>(T EPCBHDKOFNM, Func<T, byte[]> PPBHALAGCOC, Func<byte[], T> NHMNHLNFNDL, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61752C0", Offset = "0x61740C0", VA = "0x1861752C0")]
	[AsyncStateMachine(typeof(HCLDBDJJFMF))]
	public Task<KPLOHOPAIAO> LHBBALHJJFE(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61720B0", Offset = "0x6170EB0", VA = "0x1861720B0")]
	[AsyncStateMachine(typeof(NAEELDFHEIK))]
	private Task<KPLOHOPAIAO> AJABDPIBDJD(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, DGAJACEMLNI DGNEPPJNEHB, DGAJACEMLNI NDHNONLIJIE, TimeSpan? HPLMCMMPDHG, Stopwatch HMEOKDPMNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6175E10", Offset = "0x6174C10", VA = "0x186175E10")]
	[AsyncStateMachine(typeof(KOAJHOKKMMG))]
	private Task<KPLOHOPAIAO> OOHFCNDMBNB(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6172430", Offset = "0x6171230", VA = "0x186172430")]
	[AsyncStateMachine(typeof(OELDHGPCKHI))]
	public Task BJGGADPOFJL(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task> PHENNPFNDHM, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38D6620", Offset = "0x38D5420", VA = "0x1838D6620")]
	[AsyncStateMachine(typeof(KOAPBKOGGID))]
	public Task<T> BJGGADPOFJL<T>(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task<T>> PHENNPFNDHM, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38D6B70", Offset = "0x38D5970", VA = "0x1838D6B70")]
	[AsyncStateMachine(typeof(GHCPNDMPCGJ))]
	private Task<(bool, T)> EIGBEDJFFHE<T>(Guid NEHFFLMLAAK, CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task<T>> PHENNPFNDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61737E0", Offset = "0x61725E0", VA = "0x1861737E0")]
	public void HAHHPDBAAPE(byte GNOOEPNILHC, int OBACLODMPLK, object KLLPOBANEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6174830", Offset = "0x6173630", VA = "0x186174830")]
	public Guid JEGOCNNGGPF(Guid FDGNEMDCAME)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6174D40", Offset = "0x6173B40", VA = "0x186174D40")]
	public bool LELCMHONNOM(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61725A0", Offset = "0x61713A0", VA = "0x1861725A0")]
	public void BOCDJFLPBPN(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6173720", Offset = "0x6172520", VA = "0x186173720")]
	private void FAFELFMOBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6173610", Offset = "0x6172410", VA = "0x186173610")]
	internal OEHDKGMEHOM ECOPBDHNMIO(bool HJFAPMCENBC = false)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6175CD0", Offset = "0x6174AD0", VA = "0x186175CD0")]
	private HashSet<Guid> OLLEMIDFIMD(HGMEHLOCFLE MGLGMPFEOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6172260", Offset = "0x6171060", VA = "0x186172260")]
	private void AJCCPFCNPMO(HGMEHLOCFLE MGLGMPFEOHB, Guid KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6172ED0", Offset = "0x6171CD0", VA = "0x186172ED0")]
	private void DJEOLMMPBDK(HGMEHLOCFLE MGLGMPFEOHB, Guid KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6174BA0", Offset = "0x61739A0", VA = "0x186174BA0")]
	public static Func<Guid, bool> KELHBCLGOAI(Guid KCHLIHHPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6173730", Offset = "0x6172530", VA = "0x186173730")]
	public static Func<Guid, bool> FKHEBADIFPK(Guid KCHLIHHPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6174A90", Offset = "0x6173890", VA = "0x186174A90")]
	public void JFDFBLKMLKF(HGMEHLOCFLE MGLGMPFEOHB, Guid ELHCNCOMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61729A0", Offset = "0x61717A0", VA = "0x1861729A0")]
	public void DGGKBLOPMFA(HGMEHLOCFLE MGLGMPFEOHB, Func<Guid, bool> DKEJECJAIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6175450", Offset = "0x6174250", VA = "0x186175450")]
	private static ExitGames.Client.Photon.Hashtable MJHJLNAOJGH(HGMEHLOCFLE MGLGMPFEOHB, Guid HLBAJOMKNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6175570", Offset = "0x6174370", VA = "0x186175570")]
	private void NJJBBCCAFGN(HGMEHLOCFLE MGLGMPFEOHB, Guid HLBAJOMKNDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HDBMIHEDBGD : EKAGONHNDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(BGNOACFBGFB.BHFGOFNPGDI itemType, long totalStopwatchTicks)> KAMJCOPIEJH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(BGNOACFBGFB.BHFGOFNPGDI itemType, long totalStopwatchTicks)> PDEAOMIMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x77D880", Offset = "0x77C680", VA = "0x18077D880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6178960", Offset = "0x6177760", VA = "0x186178960")]
	public HDBMIHEDBGD(TimeSpan NNEBMFOPCOF, List<(BGNOACFBGFB.BHFGOFNPGDI itemType, long totalStopwatchTicks)> KAMJCOPIEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DBPGMDBAMGI : PIHMHNLDCFL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HABHACJKIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid JBDIMBMHMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int FNEILILAGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int PIELKLICAGO;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6178000", Offset = "0x6176E00", VA = "0x186178000")]
		public HABHACJKIGP(Guid GBPBPAIFFFO, int AOEPDFDAANJ, int GJOPJOMJNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6177F20", Offset = "0x6176D20", VA = "0x186177F20")]
		public static byte[] PNKNJNLKBEB(HABHACJKIGP LMLMHJKGDCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6177D30", Offset = "0x6176B30", VA = "0x186177D30")]
		public static HABHACJKIGP CJKIJAOEIBM(byte[] CCFMJPPGPDK)
		{
			return default(HABHACJKIGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6177DF0", Offset = "0x6176BF0", VA = "0x186177DF0")]
		private static byte[] LOLFFGCHANM(int MNBBHFLLBID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6177E70", Offset = "0x6176C70", VA = "0x186177E70")]
		private static int MAENNIGACJE(byte[] GHBHCIDGONN, int NPDGHPHAKDK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid GBPBPAIFFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BCJGNNLDEJN BGHPOAOGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool HIFKGHIFFHA;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6176FA0", Offset = "0x6175DA0", VA = "0x186176FA0")]
	public DBPGMDBAMGI(Guid GBPBPAIFFFO, BCJGNNLDEJN BGHPOAOGGAA, GIMENMFNCMN GNPHKIFHPOM, CancellationToken OGPKLEECEBJ, [Optional] LAICOCFIKHL DELMEMDGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6176DD0", Offset = "0x6175BD0", VA = "0x186176DD0", Slot = "5")]
	protected override void DDMLPMOBKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6176A10", Offset = "0x6175810", VA = "0x186176A10", Slot = "6")]
	protected override void CFIPOABJMBH(int FMOAKOCKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6176BB0", Offset = "0x61759B0", VA = "0x186176BB0")]
	private void CGACJJOECID(KPLOHOPAIAO KBAIHCJLLLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KPLOHOPAIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly OEHDKGMEHOM KIJAAEIDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte APKCIAPNCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte HPEGHIGFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool EGEEPDHIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] GOMOKJBFMDP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6179E70", Offset = "0x6178C70", VA = "0x186179E70")]
	public KPLOHOPAIAO(OEHDKGMEHOM KDBILDMBKKJ, [CanBeNull] byte[] BNKBFACGLIM, bool PKHMJKMFHHB, byte DOOGEBEKLDK, byte KOLEALDIHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6179CD0", Offset = "0x6178AD0", VA = "0x186179CD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6179AE0", Offset = "0x61788E0", VA = "0x186179AE0")]
	private static void IBENHAEJHGN(byte[] BNKBFACGLIM, StringBuilder FMGHJPGOLOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct OEHDKGMEHOM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KCCBNBHDMAP : IEnumerable<NHEDGBKAANP>, IEnumerable, IEnumerator<NHEDGBKAANP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private NHEDGBKAANP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public OEHDKGMEHOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public OEHDKGMEHOM <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private HGMEHLOCFLE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NHEDGBKAANP System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4945810", Offset = "0x4944610", VA = "0x184945810", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NHEDGBKAANP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6179660", Offset = "0x6178460", VA = "0x186179660", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF30", Offset = "0x9FBD30", VA = "0x1809FCF30")]
		[DebuggerHidden]
		public KCCBNBHDMAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6179390", Offset = "0x6178190", VA = "0x186179390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6179620", Offset = "0x6178420", VA = "0x186179620", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6179580", Offset = "0x6178380", VA = "0x186179580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NHEDGBKAANP> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6179580", Offset = "0x6178380", VA = "0x186179580", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly HGMEHLOCFLE DKFGCILJIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] MPGEAAMHILN;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x617BA20", Offset = "0x617A820", VA = "0x18617BA20")]
	public static OEHDKGMEHOM HICCHEIDPMP(HGMEHLOCFLE MGLGMPFEOHB, Guid CKDCANAKLPE)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x617BB20", Offset = "0x617A920", VA = "0x18617BB20")]
	public static OEHDKGMEHOM JJIDKOGJNNG(List<NHEDGBKAANP> PEIOGGJJAFD)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x617B540", Offset = "0x617A340", VA = "0x18617B540")]
	public static OEHDKGMEHOM DHOEMMNMPAI(HGMEHLOCFLE GCOOANKBCCD, Guid[] CCJAFJIHNHC)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x617C0C0", Offset = "0x617AEC0", VA = "0x18617C0C0")]
	private OEHDKGMEHOM(HGMEHLOCFLE GCOOANKBCCD, Guid[] CCJAFJIHNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x617B9A0", Offset = "0x617A7A0", VA = "0x18617B9A0")]
	[IteratorStateMachine(typeof(KCCBNBHDMAP))]
	public IEnumerable<NHEDGBKAANP> FPJDOIDDACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x617BF40", Offset = "0x617AD40", VA = "0x18617BF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PEFNKMFFPFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x41E9BC0", Offset = "0x41E89C0", VA = "0x1841E9BC0", Slot = "4")]
	public void OAOKAJADACH(T LMLMHJKGDCH, IDictionary<object, object> FILAKGLBGGA, bool PAPJFKEGGDG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IGAGDOCAOCO(T LMLMHJKGDCH, IDictionary<object, object> FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T CJKIJAOEIBM(IDictionary<object, object> FILAKGLBGGA);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected PEFNKMFFPFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PIHMHNLDCFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool LAICOCFIKHL(int BLCCNOCAPGI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly GIMENMFNCMN FPIOGIIAILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken OGPKLEECEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken GJGGHDAPKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly LAICOCFIKHL DELMEMDGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource BBKDDOINMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource GJIEAHFEJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int MLKMOGGMDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HOGLAMBFJNL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken AMCBHMLCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x617C660", Offset = "0x617B460", VA = "0x18617C660")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LBJOBBAHMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x617C770", Offset = "0x617B570", VA = "0x18617C770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x617C860", Offset = "0x617B660", VA = "0x18617C860")]
	public PIHMHNLDCFL(GIMENMFNCMN GNPHKIFHPOM, CancellationToken OGPKLEECEBJ, [Optional] LAICOCFIKHL DELMEMDGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x617C750", Offset = "0x617B550", VA = "0x18617C750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x617C680", Offset = "0x617B480", VA = "0x18617C680", Slot = "5")]
	protected virtual void DDMLPMOBKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x617C7C0", Offset = "0x617B5C0", VA = "0x18617C7C0")]
	private void GGMHBPKJMJF(DMHOAMAMDGI AMBOEHLAAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x617C5E0", Offset = "0x617B3E0", VA = "0x18617C5E0")]
	protected void ALEJMIEMPOH(int FMOAKOCKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x617C640", Offset = "0x617B440", VA = "0x18617C640", Slot = "6")]
	protected virtual void CFIPOABJMBH(int FMOAKOCKOEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct NHEDGBKAANP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly HGMEHLOCFLE KBCDFCKJLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid PAGEPEFLLBP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E671F0", Offset = "0x2E65FF0", VA = "0x182E671F0")]
	public NHEDGBKAANP(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x617AED0", Offset = "0x6179CD0", VA = "0x18617AED0")]
	public bool NOHLHLNDIHM(NHEDGBKAANP KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x617ADE0", Offset = "0x6179BE0", VA = "0x18617ADE0", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x617AEA0", Offset = "0x6179CA0", VA = "0x18617AEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum HGMEHLOCFLE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Operation = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	RoomLoad = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	MasterBlock = 4
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class IHDGECJBCNA
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly HGMEHLOCFLE[] IADPMNIIEPE;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61789E0", Offset = "0x61777E0", VA = "0x1861789E0")]
	public static int FNGDPGDNEIL(HGMEHLOCFLE MGLGMPFEOHB)
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
