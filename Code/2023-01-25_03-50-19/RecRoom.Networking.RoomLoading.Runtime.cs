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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CGNENMOPNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB170", Offset = "0x5DBA170", VA = "0x185DBB170")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DB5540", Offset = "0x5DB4540", VA = "0x185DB5540", Slot = "5")]
	protected override void IGAGDOCAOCO(KPLOHOPAIAO LMLMHJKGDCH, IDictionary<object, object> FILAKGLBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DB49E0", Offset = "0x5DB39E0", VA = "0x185DB49E0", Slot = "6")]
	public override KPLOHOPAIAO CJKIJAOEIBM(IDictionary<object, object> FILAKGLBGGA)
	{
		return default(KPLOHOPAIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5BD0", Offset = "0x5DB4BD0", VA = "0x185DB5BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2952B50", Offset = "0x2951B50", VA = "0x182952B50")]
		public static ADJLHAJLJIN<T> ECDMOAFINEL(KPLOHOPAIAO CLDIIPNOPMF, Func<byte[], T> NHMNHLNFNDL)
		{
			return default(ADJLHAJLJIN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2952DB0", Offset = "0x2951DB0", VA = "0x182952DB0")]
		public ADJLHAJLJIN(OEHDKGMEHOM KDBILDMBKKJ, T BNKBFACGLIM, bool PKHMJKMFHHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2952C60", Offset = "0x2951C60", VA = "0x182952C60", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public FBBJPHEEAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5DBBA20", Offset = "0x5DBAA20", VA = "0x185DBBA20")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5DBBA70", Offset = "0x5DBAA70", VA = "0x185DBBA70")]
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
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public MBKGLCIOBIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE920", Offset = "0x5DBD920", VA = "0x185DBE920")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DBD3D0", Offset = "0x5DBC3D0", VA = "0x185DBD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5DBDBE0", Offset = "0x5DBCBE0", VA = "0x185DBDBE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public MBLNLNMEMCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5DBE9F0", Offset = "0x5DBD9F0", VA = "0x185DBE9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DBFC60", Offset = "0x5DBEC60", VA = "0x185DBFC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<KPLOHOPAIAO> DAPMHACDMHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF7A0", Offset = "0x5DBE7A0", VA = "0x185DBF7A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5DBF890", Offset = "0x5DBE890", VA = "0x185DBF890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFCB0", Offset = "0x5DBECB0", VA = "0x185DBFCB0")]
		public NIFCLKBFPBG(JLJCIAPHMDI OMLIPEAAELF, string LGMCIBMEEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF930", Offset = "0x5DBE930", VA = "0x185DBF930")]
		[AsyncStateMachine(typeof(JBDOBLCLIFE))]
		public Task<KPLOHOPAIAO> FJPPJALBALM(CancellationToken NIEOBBGKEFJ, TimeSpan NNEBMFOPCOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFA80", Offset = "0x5DBEA80", VA = "0x185DBFA80")]
		public void HNLLGKNCIDM(KPLOHOPAIAO LMLMHJKGDCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF840", Offset = "0x5DBE840", VA = "0x185DBF840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5DBFB30", Offset = "0x5DBEB30", VA = "0x185DBFB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB5C10", Offset = "0x5DB4C10", VA = "0x185DB5C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6530", Offset = "0x5DB5530", VA = "0x185DB6530", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB6580", Offset = "0x5DB5580", VA = "0x185DB6580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6930", Offset = "0x5DB5930", VA = "0x185DB6930", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBC8B0", Offset = "0x5DBB8B0", VA = "0x185DBC8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD1B0", Offset = "0x5DBC1B0", VA = "0x185DBD1B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBEB60", Offset = "0x5DBDB60", VA = "0x185DBEB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF600", Offset = "0x5DBE600", VA = "0x185DBF600", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBDF50", Offset = "0x5DBCF50", VA = "0x185DBDF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE330", Offset = "0x5DBD330", VA = "0x185DBE330", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DC1370", Offset = "0x5DC0370", VA = "0x185DC1370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5DC14E0", Offset = "0x5DC04E0", VA = "0x185DC14E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GAKJKIDOPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBE60", Offset = "0x5DBAE60", VA = "0x185DBBE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DC0B70", Offset = "0x5DBFB70", VA = "0x185DC0B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PJGCCKJANEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC12D0", Offset = "0x5DC02D0", VA = "0x185DC12D0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC1280", Offset = "0x5DC0280", VA = "0x185DC1280")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public KPNCLDHEEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE770", Offset = "0x5DBD770", VA = "0x185DBE770")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public BNPKKLPNDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB0D0", Offset = "0x5DBA0D0", VA = "0x185DBB0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AMFGNLFBPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6980", Offset = "0x5DB5980", VA = "0x185DB6980")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public FGHPNMPPPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBDF0", Offset = "0x5DBADF0", VA = "0x185DBBDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LIBOPHAPEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE890", Offset = "0x5DBD890", VA = "0x185DBE890")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public CIAEGMDFKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB230", Offset = "0x5DBA230", VA = "0x185DBB230")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GDOFOJHEOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC000", Offset = "0x5DBB000", VA = "0x185DBC000")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBBFA0", Offset = "0x5DBAFA0", VA = "0x185DBBFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public OJBBMPJBMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0DB0", Offset = "0x5DBFDB0", VA = "0x185DC0DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GHALHHPBPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC0D0", Offset = "0x5DBB0D0", VA = "0x185DBC0D0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC350", Offset = "0x5DBB350", VA = "0x185DBC350")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC060", Offset = "0x5DBB060", VA = "0x185DBC060")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB7AC0", Offset = "0x5DB6AC0", VA = "0x185DB7AC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8A80", Offset = "0x5DB7A80", VA = "0x185DB8A80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAC20", Offset = "0x5DB9C20", VA = "0x185DBAC20")]
	public BCJGNNLDEJN(JLJCIAPHMDI OMLIPEAAELF, KLCONECFFJG PFIBILBHNOF, GIMENMFNCMN DEPMKGCJDOP, [Optional] TimeSpan? HPLMCMMPDHG, [Optional] EFFNLAHPEAP IMMPKAADOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22D3650", Offset = "0x22D2650", VA = "0x1822D3650")]
	public static BCJGNNLDEJN BKEAAINCDGJ<TNetworking>(TNetworking GNPHKIFHPOM, [Optional] TimeSpan? HPLMCMMPDHG, [Optional] EFFNLAHPEAP IMMPKAADOFG) where TNetworking : JLJCIAPHMDI, KLCONECFFJG, GIMENMFNCMN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9520", Offset = "0x5DB8520", VA = "0x185DB9520")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA570", Offset = "0x5DB9570", VA = "0x185DBA570")]
	private byte OEJHAFCJMOP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7CE0", Offset = "0x5DB6CE0", VA = "0x185DB7CE0")]
	private TimeSpan ECMMAFFIFBO(TimeSpan? HPLMCMMPDHG, int MJKODALCAJB = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22D3B40", Offset = "0x22D2B40", VA = "0x1822D3B40")]
	public bool IINKGDGIBJM<T>(T EPCBHDKOFNM, Func<T, byte[]> PPBHALAGCOC, bool PKHMJKMFHHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8B20", Offset = "0x5DB7B20", VA = "0x185DB8B20")]
	public bool IINKGDGIBJM(byte[] EPCBHDKOFNM, int EAFPDNPBHLP, bool PKHMJKMFHHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77B500", Offset = "0x77A500", VA = "0x18077B500")]
	private static string CDCOOGJGMBB(string LMLMHJKGDCH, string OEGNINEOMFI = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7B60", Offset = "0x5DB6B60", VA = "0x185DB7B60")]
	[AsyncStateMachine(typeof(AGCGIHAGOAO))]
	public Task<KPLOHOPAIAO> DOLNJHIFEKN(CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? HPLMCMMPDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA850", Offset = "0x5DB9850", VA = "0x185DBA850")]
	[AsyncStateMachine(typeof(AJENKCOGILO))]
	public Task<Guid> PHJKKJDAKMK(Guid IMAFNHMKELP, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22D3BF0", Offset = "0x22D2BF0", VA = "0x1822D3BF0")]
	[AsyncStateMachine(typeof(GMDCCIEDELO))]
	public Task<ADJLHAJLJIN<T>> LHBBALHJJFE<T>(T EPCBHDKOFNM, Func<T, byte[]> PPBHALAGCOC, Func<byte[], T> NHMNHLNFNDL, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9B90", Offset = "0x5DB8B90", VA = "0x185DB9B90")]
	[AsyncStateMachine(typeof(HCLDBDJJFMF))]
	public Task<KPLOHOPAIAO> LHBBALHJJFE(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DB69F0", Offset = "0x5DB59F0", VA = "0x185DB69F0")]
	[AsyncStateMachine(typeof(NAEELDFHEIK))]
	private Task<KPLOHOPAIAO> AJABDPIBDJD(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, DGAJACEMLNI DGNEPPJNEHB, DGAJACEMLNI NDHNONLIJIE, TimeSpan? HPLMCMMPDHG, Stopwatch HMEOKDPMNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA6C0", Offset = "0x5DB96C0", VA = "0x185DBA6C0")]
	[AsyncStateMachine(typeof(KOAJHOKKMMG))]
	private Task<KPLOHOPAIAO> OOHFCNDMBNB(byte[] EPCBHDKOFNM, CancellationToken NIEOBBGKEFJ, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, [Optional] TimeSpan? NNEBMFOPCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6D60", Offset = "0x5DB5D60", VA = "0x185DB6D60")]
	[AsyncStateMachine(typeof(OELDHGPCKHI))]
	public Task BJGGADPOFJL(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task> PHENNPFNDHM, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22D31A0", Offset = "0x22D21A0", VA = "0x1822D31A0")]
	[AsyncStateMachine(typeof(KOAPBKOGGID))]
	public Task<T> BJGGADPOFJL<T>(CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task<T>> PHENNPFNDHM, [Optional] DGAJACEMLNI DGNEPPJNEHB, [Optional] DGAJACEMLNI NDHNONLIJIE, int PNOOAPLCHHO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22D36F0", Offset = "0x22D26F0", VA = "0x1822D36F0")]
	[AsyncStateMachine(typeof(GHCPNDMPCGJ))]
	private Task<(bool, T)> EIGBEDJFFHE<T>(Guid NEHFFLMLAAK, CancellationToken OGPKLEECEBJ, Func<CancellationToken, Task<T>> PHENNPFNDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB80F0", Offset = "0x5DB70F0", VA = "0x185DB80F0")]
	public void HAHHPDBAAPE(byte GNOOEPNILHC, int OBACLODMPLK, object KLLPOBANEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9100", Offset = "0x5DB8100", VA = "0x185DB9100")]
	public Guid JEGOCNNGGPF(Guid FDGNEMDCAME)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9610", Offset = "0x5DB8610", VA = "0x185DB9610")]
	public bool LELCMHONNOM(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6ED0", Offset = "0x5DB5ED0", VA = "0x185DB6ED0")]
	public void BOCDJFLPBPN(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8030", Offset = "0x5DB7030", VA = "0x185DB8030")]
	private void FAFELFMOBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7F20", Offset = "0x5DB6F20", VA = "0x185DB7F20")]
	internal OEHDKGMEHOM ECOPBDHNMIO(bool HJFAPMCENBC = false)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA580", Offset = "0x5DB9580", VA = "0x185DBA580")]
	private HashSet<Guid> OLLEMIDFIMD(HGMEHLOCFLE MGLGMPFEOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6BA0", Offset = "0x5DB5BA0", VA = "0x185DB6BA0")]
	private void AJCCPFCNPMO(HGMEHLOCFLE MGLGMPFEOHB, Guid KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DB77E0", Offset = "0x5DB67E0", VA = "0x185DB77E0")]
	private void DJEOLMMPBDK(HGMEHLOCFLE MGLGMPFEOHB, Guid KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9470", Offset = "0x5DB8470", VA = "0x185DB9470")]
	public static Func<Guid, bool> KELHBCLGOAI(Guid KCHLIHHPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8040", Offset = "0x5DB7040", VA = "0x185DB8040")]
	public static Func<Guid, bool> FKHEBADIFPK(Guid KCHLIHHPAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9360", Offset = "0x5DB8360", VA = "0x185DB9360")]
	public void JFDFBLKMLKF(HGMEHLOCFLE MGLGMPFEOHB, Guid ELHCNCOMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DB72C0", Offset = "0x5DB62C0", VA = "0x185DB72C0")]
	public void DGGKBLOPMFA(HGMEHLOCFLE MGLGMPFEOHB, Func<Guid, bool> DKEJECJAIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9D20", Offset = "0x5DB8D20", VA = "0x185DB9D20")]
	private static ExitGames.Client.Photon.Hashtable MJHJLNAOJGH(HGMEHLOCFLE MGLGMPFEOHB, Guid HLBAJOMKNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9E40", Offset = "0x5DB8E40", VA = "0x185DB9E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x684E20", Offset = "0x683E20", VA = "0x180684E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD200", Offset = "0x5DBC200", VA = "0x185DBD200")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DBC8A0", Offset = "0x5DBB8A0", VA = "0x185DBC8A0")]
		public HABHACJKIGP(Guid GBPBPAIFFFO, int AOEPDFDAANJ, int GJOPJOMJNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC7C0", Offset = "0x5DBB7C0", VA = "0x185DBC7C0")]
		public static byte[] PNKNJNLKBEB(HABHACJKIGP LMLMHJKGDCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC5D0", Offset = "0x5DBB5D0", VA = "0x185DBC5D0")]
		public static HABHACJKIGP CJKIJAOEIBM(byte[] CCFMJPPGPDK)
		{
			return default(HABHACJKIGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC690", Offset = "0x5DBB690", VA = "0x185DBC690")]
		private static byte[] LOLFFGCHANM(int MNBBHFLLBID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBC710", Offset = "0x5DBB710", VA = "0x185DBC710")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DBB850", Offset = "0x5DBA850", VA = "0x185DBB850")]
	public DBPGMDBAMGI(Guid GBPBPAIFFFO, BCJGNNLDEJN BGHPOAOGGAA, GIMENMFNCMN GNPHKIFHPOM, CancellationToken OGPKLEECEBJ, [Optional] LAICOCFIKHL DELMEMDGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB680", Offset = "0x5DBA680", VA = "0x185DBB680", Slot = "5")]
	protected override void DDMLPMOBKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB2C0", Offset = "0x5DBA2C0", VA = "0x185DBB2C0", Slot = "6")]
	protected override void CFIPOABJMBH(int FMOAKOCKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5DBB460", Offset = "0x5DBA460", VA = "0x185DBB460")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DBE710", Offset = "0x5DBD710", VA = "0x185DBE710")]
	public KPLOHOPAIAO(OEHDKGMEHOM KDBILDMBKKJ, [CanBeNull] byte[] BNKBFACGLIM, bool PKHMJKMFHHB, byte DOOGEBEKLDK, byte KOLEALDIHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE570", Offset = "0x5DBD570", VA = "0x185DBE570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE380", Offset = "0x5DBD380", VA = "0x185DBE380")]
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
			[Cpp2IlInjected.Address(RVA = "0x29D3780", Offset = "0x29D2780", VA = "0x1829D3780", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DBDF00", Offset = "0x5DBCF00", VA = "0x185DBDF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FA61C0", Offset = "0x1FA51C0", VA = "0x181FA61C0")]
		[DebuggerHidden]
		public KCCBNBHDMAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDC30", Offset = "0x5DBCC30", VA = "0x185DBDC30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDEC0", Offset = "0x5DBCEC0", VA = "0x185DBDEC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDE20", Offset = "0x5DBCE20", VA = "0x185DBDE20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NHEDGBKAANP> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDE20", Offset = "0x5DBCE20", VA = "0x185DBDE20", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DC0290", Offset = "0x5DBF290", VA = "0x185DC0290")]
	public static OEHDKGMEHOM HICCHEIDPMP(HGMEHLOCFLE MGLGMPFEOHB, Guid CKDCANAKLPE)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0390", Offset = "0x5DBF390", VA = "0x185DC0390")]
	public static OEHDKGMEHOM JJIDKOGJNNG(List<NHEDGBKAANP> PEIOGGJJAFD)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5DBFDB0", Offset = "0x5DBEDB0", VA = "0x185DBFDB0")]
	public static OEHDKGMEHOM DHOEMMNMPAI(HGMEHLOCFLE GCOOANKBCCD, Guid[] CCJAFJIHNHC)
	{
		return default(OEHDKGMEHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0930", Offset = "0x5DBF930", VA = "0x185DC0930")]
	private OEHDKGMEHOM(HGMEHLOCFLE GCOOANKBCCD, Guid[] CCJAFJIHNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0210", Offset = "0x5DBF210", VA = "0x185DC0210")]
	[IteratorStateMachine(typeof(KCCBNBHDMAP))]
	public IEnumerable<NHEDGBKAANP> FPJDOIDDACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5DC07B0", Offset = "0x5DBF7B0", VA = "0x185DC07B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PEFNKMFFPFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3468490", Offset = "0x3467490", VA = "0x183468490", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DC0ED0", Offset = "0x5DBFED0", VA = "0x185DC0ED0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LBJOBBAHMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0FE0", Offset = "0x5DBFFE0", VA = "0x185DC0FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC10D0", Offset = "0x5DC00D0", VA = "0x185DC10D0")]
	public PIHMHNLDCFL(GIMENMFNCMN GNPHKIFHPOM, CancellationToken OGPKLEECEBJ, [Optional] LAICOCFIKHL DELMEMDGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0FC0", Offset = "0x5DBFFC0", VA = "0x185DC0FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0EF0", Offset = "0x5DBFEF0", VA = "0x185DC0EF0", Slot = "5")]
	protected virtual void DDMLPMOBKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DC1030", Offset = "0x5DC0030", VA = "0x185DC1030")]
	private void GGMHBPKJMJF(DMHOAMAMDGI AMBOEHLAAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0E50", Offset = "0x5DBFE50", VA = "0x185DC0E50")]
	protected void ALEJMIEMPOH(int FMOAKOCKOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DC0EB0", Offset = "0x5DBFEB0", VA = "0x185DC0EB0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B332D0", Offset = "0x2B322D0", VA = "0x182B332D0")]
	public NHEDGBKAANP(HGMEHLOCFLE MGLGMPFEOHB, Guid NEHFFLMLAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF740", Offset = "0x5DBE740", VA = "0x185DBF740")]
	public bool NOHLHLNDIHM(NHEDGBKAANP KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF650", Offset = "0x5DBE650", VA = "0x185DBF650", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBF710", Offset = "0x5DBE710", VA = "0x185DBF710", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DBD280", Offset = "0x5DBC280", VA = "0x185DBD280")]
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
