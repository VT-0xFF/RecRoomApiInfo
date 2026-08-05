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
internal class OCJPPOFHHLC : global::FIKKAJEOBAH<ALNEMJDLIED>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FIHDDNAECGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public FIHDDNAECGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x625C860", Offset = "0x625B060", VA = "0x18625C860")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] PJOALFHPFFB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly OCJPPOFHHLC PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x625F3E0", Offset = "0x625DBE0", VA = "0x18625F3E0", Slot = "5")]
	protected override void COGHHHLCIIP(ALNEMJDLIED EPAIMCEIMPA, IDictionary<object, object> LBEMEOBAAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x625F850", Offset = "0x625E050", VA = "0x18625F850", Slot = "6")]
	public override ALNEMJDLIED JFCMHHFNDFE(IDictionary<object, object> LBEMEOBAAJI)
	{
		return default(ALNEMJDLIED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62605F0", Offset = "0x625EDF0", VA = "0x1862605F0")]
	public OCJPPOFHHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AJCJCPIKJLL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string AHABCCHOOGJ([NotNull] byte[] HBMMCJPOJGP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct CIGHHABNNFI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly CBDNBGEKFAM OELBKPPKIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool CDBFHKAEJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T KAHHBKPIBEC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28D37F0", Offset = "0x28D1FF0", VA = "0x1828D37F0")]
		public static CIGHHABNNFI<T> EGJHDNCINKP(ALNEMJDLIED MGEDPJPJILF, Func<byte[], T> FFKJLNEJKGH)
		{
			return default(CIGHHABNNFI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3BA0", Offset = "0x28D23A0", VA = "0x1828D3BA0")]
		public CIGHHABNNFI(CBDNBGEKFAM IKKCNAANNEA, T HBMMCJPOJGP, bool MFBNJFGICPJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28D3A70", Offset = "0x28D2270", VA = "0x1828D3A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MBKBKFCBLPP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MIJDGGLBIMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<ALNEMJDLIED> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public MBKBKFCBLPP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MIJDGGLBIMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x625E0B0", Offset = "0x625C8B0", VA = "0x18625E0B0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x625E100", Offset = "0x625C900", VA = "0x18625E100")]
			internal PNGKBCACLNE <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CFGPCNCGALG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HPBNNBBFJII.GOPDHPKPLHN itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public CFGPCNCGALG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x625B2A0", Offset = "0x6259AA0", VA = "0x18625B2A0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct ODOCKCCAMBF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<ALNEMJDLIED> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public MBKBKFCBLPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private MIJDGGLBIMJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<ALNEMJDLIED> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6260630", Offset = "0x625EE30", VA = "0x186260630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6260E40", Offset = "0x625F640", VA = "0x186260E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class LIBFALGOGKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CHKGIICKICK sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public LIBFALGOGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x625D840", Offset = "0x625C040", VA = "0x18625D840")]
			internal bool <ClearSlice>b__0(ALNEMJDLIED bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JIGEBENKLEN DHCEDJPOOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string AEDBBOHDOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<ALNEMJDLIED> PLLKLEMLFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(HPBNNBBFJII.GOPDHPKPLHN itemType, long totalStopwatchTicks)> PPINJNNALLL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IEOFBGEFKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x625DD70", Offset = "0x625C570", VA = "0x18625DD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<ALNEMJDLIED> NADPOHCJFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x625DF10", Offset = "0x625C710", VA = "0x18625DF10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x625DBA0", Offset = "0x625C3A0", VA = "0x18625DBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x625DFB0", Offset = "0x625C7B0", VA = "0x18625DFB0")]
		public MBKBKFCBLPP(JIGEBENKLEN DHCEDJPOOPL, string AEDBBOHDOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x625DDC0", Offset = "0x625C5C0", VA = "0x18625DDC0")]
		[AsyncStateMachine(typeof(ODOCKCCAMBF))]
		public Task<ALNEMJDLIED> NCCFOJOFPFJ(CancellationToken DIEJHKIAFPL, TimeSpan NCNCMLGEIJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x625DAA0", Offset = "0x625C2A0", VA = "0x18625DAA0")]
		public void CFLJIALKNPK(ALNEMJDLIED EPAIMCEIMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x625DB50", Offset = "0x625C350", VA = "0x18625DB50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x625DC40", Offset = "0x625C440", VA = "0x18625DC40")]
		public void FJFAFGCKAMK(CHKGIICKICK FCADMEJHNHP, Guid MKEJJPNNCOG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NGMCHCEMHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<ALNEMJDLIED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EJBLIOEJEKL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<ALNEMJDLIED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x625E770", Offset = "0x625CF70", VA = "0x18625E770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x625F0C0", Offset = "0x625D8C0", VA = "0x18625F0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LFBJFJFPBKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EJBLIOEJEKL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<CIGHHABNNFI<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x625D440", Offset = "0x625BC40", VA = "0x18625D440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x625D7F0", Offset = "0x625BFF0", VA = "0x18625D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ECJCIMDNKCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<ALNEMJDLIED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EJBLIOEJEKL pauseAfterListeningToken;

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
		private TaskAwaiter<ALNEMJDLIED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x625B3E0", Offset = "0x6259BE0", VA = "0x18625B3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x625BCE0", Offset = "0x625A4E0", VA = "0x18625BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ADLCGGHFJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ADLCGGHFJPB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FALMMKPMKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<ALNEMJDLIED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ADLCGGHFJPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public EJBLIOEJEKL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private HBBBPGLKBIH <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<ALNEMJDLIED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x625BD30", Offset = "0x625A530", VA = "0x18625BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x625C810", Offset = "0x625B010", VA = "0x18625C810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CFDNNKMJJNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<ALNEMJDLIED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public EJBLIOEJEKL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<ALNEMJDLIED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x625AE70", Offset = "0x6259670", VA = "0x18625AE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x625B250", Offset = "0x6259A50", VA = "0x18625B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LDCFLPLIDDL
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
			public LDCFLPLIDDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62612A0", Offset = "0x625FAA0", VA = "0x1862612A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6261410", Offset = "0x625FC10", VA = "0x186261410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LDCFLPLIDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x625D300", Offset = "0x625BB00", VA = "0x18625D300")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NKDDOGOJNDJ : IAsyncStateMachine
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
		public AJCJCPIKJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public EJBLIOEJEKL unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EJBLIOEJEKL pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x625F110", Offset = "0x625D910", VA = "0x18625F110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LPJBLPJPOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LPJBLPJPOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x625DA00", Offset = "0x625C200", VA = "0x18625DA00")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x625D9B0", Offset = "0x625C1B0", VA = "0x18625D9B0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JIOJFNIHLAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CHKGIICKICK sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JIOJFNIHLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x625D1A0", Offset = "0x625B9A0", VA = "0x18625D1A0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IHHLFJEOCAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CHKGIICKICK sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IHHLFJEOCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x625CF30", Offset = "0x625B730", VA = "0x18625CF30")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PNKKNBICKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PNKKNBICKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6261230", Offset = "0x625FA30", VA = "0x186261230")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CIMJJHGDBHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CIMJJHGDBHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x625B370", Offset = "0x6259B70", VA = "0x18625B370")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GMNNFLHKDED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GMNNFLHKDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x625C920", Offset = "0x625B120", VA = "0x18625C920")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OAFOGBGICJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public OAFOGBGICJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x625F350", Offset = "0x625DB50", VA = "0x18625F350")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LBELJBLFBFG
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LBELJBLFBFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x625D2A0", Offset = "0x625BAA0", VA = "0x18625D2A0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x625D240", Offset = "0x625BA40", VA = "0x18625D240")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ACGLPHBOPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public ACGLPHBOPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62547B0", Offset = "0x6252FB0", VA = "0x1862547B0")]
		internal bool <ClearSliceIds>b__3(GNLBEHKAOOL stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BEGIMJKGGCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public BEGIMJKGGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62595C0", Offset = "0x6257DC0", VA = "0x1862595C0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6259840", Offset = "0x6258040", VA = "0x186259840")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6259550", Offset = "0x6257D50", VA = "0x186259550")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly AHABCCHOOGJ KKABEKLKOJC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable NCDDOICBFHG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EPLLLGIOIJN BDPHKECPGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MBKBKFCBLPP POGBAADMMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JIGEBENKLEN DHCEDJPOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KFBOHPGLGOP LFEBCJKFKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MMBEKLJFJHE GDHBMDMDLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AHABCCHOOGJ HJDJCGINJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IFDCADIMIGO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan AFGKGJMDPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan NNFICNBNCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte EIKGDDENAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] AADJNKICDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<GNLBEHKAOOL> DGOCOLCBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CBDNBGEKFAM? GDFJDDOCHLO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly EPLLLGIOIJN FIDJHFHLGCK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly EPLLLGIOIJN JBAPPMEDLOE;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<ALNEMJDLIED> KFAPOPHJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62560E0", Offset = "0x62548E0", VA = "0x1862560E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6257890", Offset = "0x6256090", VA = "0x186257890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6258CB0", Offset = "0x62574B0", VA = "0x186258CB0")]
	public AJCJCPIKJLL(JIGEBENKLEN DHCEDJPOOPL, KFBOHPGLGOP LFEBCJKFKDB, MMBEKLJFJHE GDHBMDMDLKM, [Optional] TimeSpan? GOOIAGABIGK, [Optional] AHABCCHOOGJ EBGKIDBIAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x17F74D0", Offset = "0x17F5CD0", VA = "0x1817F74D0")]
	public static AJCJCPIKJLL FDJBMGCBCML<TNetworking>(TNetworking AKIKINCCOGC, [Optional] TimeSpan? GOOIAGABIGK, [Optional] AHABCCHOOGJ EBGKIDBIAFE) where TNetworking : JIGEBENKLEN, KFBOHPGLGOP, MMBEKLJFJHE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6255C90", Offset = "0x6254490", VA = "0x186255C90")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6257140", Offset = "0x6255940", VA = "0x186257140")]
	private byte NEAJAOIFEHA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6258830", Offset = "0x6257030", VA = "0x186258830")]
	private TimeSpan PJCNBCLMOBF(TimeSpan? GOOIAGABIGK, int IAPNADEKBJN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x17F7570", Offset = "0x17F5D70", VA = "0x1817F7570")]
	public bool HDFNAILADOE<T>(T AALBDKEOGMI, Func<T, byte[]> PPMEKADMLKD, bool MFBNJFGICPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6255250", Offset = "0x6253A50", VA = "0x186255250")]
	public bool HDFNAILADOE(byte[] AALBDKEOGMI, int LHHMLKBGMDF, bool MFBNJFGICPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E20", Offset = "0x7F2620", VA = "0x1807F3E20")]
	private static string LNPOHPDBIBD(string EPAIMCEIMPA, string LCCPJBCAOGP = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6254B70", Offset = "0x6253370", VA = "0x186254B70")]
	[AsyncStateMachine(typeof(NGMCHCEMHLI))]
	public Task<ALNEMJDLIED> CPGLCMGMKOO(CancellationToken DIEJHKIAFPL, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, [Optional] TimeSpan? GOOIAGABIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6255B00", Offset = "0x6254300", VA = "0x186255B00")]
	[AsyncStateMachine(typeof(LFBJFJFPBKL))]
	public Task<Guid> IHBDDMJCDPI(Guid KIKMKMLCPAM, CancellationToken DIEJHKIAFPL, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, [Optional] TimeSpan? NCNCMLGEIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x17F7620", Offset = "0x17F5E20", VA = "0x1817F7620")]
	[AsyncStateMachine(typeof(PLDLMJMMFFC))]
	public Task<CIGHHABNNFI<T>> HOABDHEECKO<T>(T AALBDKEOGMI, Func<T, byte[]> PPMEKADMLKD, Func<byte[], T> FFKJLNEJKGH, CancellationToken DIEJHKIAFPL, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, [Optional] TimeSpan? NCNCMLGEIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6255970", Offset = "0x6254170", VA = "0x186255970")]
	[AsyncStateMachine(typeof(ECJCIMDNKCO))]
	public Task<ALNEMJDLIED> HOABDHEECKO(byte[] AALBDKEOGMI, CancellationToken DIEJHKIAFPL, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, [Optional] TimeSpan? NCNCMLGEIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62549C0", Offset = "0x62531C0", VA = "0x1862549C0")]
	[AsyncStateMachine(typeof(FALMMKPMKFN))]
	private Task<ALNEMJDLIED> BOGFFKFFJFI(byte[] AALBDKEOGMI, CancellationToken DIEJHKIAFPL, EJBLIOEJEKL CMFGONPKDEM, EJBLIOEJEKL AAOCOFLOCMM, TimeSpan? GOOIAGABIGK, Stopwatch GMAKGHHMOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6255F50", Offset = "0x6254750", VA = "0x186255F50")]
	[AsyncStateMachine(typeof(CFDNNKMJJNB))]
	private Task<ALNEMJDLIED> JIIOFKLLKIF(byte[] AALBDKEOGMI, CancellationToken DIEJHKIAFPL, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, [Optional] TimeSpan? NCNCMLGEIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6256180", Offset = "0x6254980", VA = "0x186256180")]
	[AsyncStateMachine(typeof(NKDDOGOJNDJ))]
	public Task JOGGECMHEEE(CancellationToken JCCIHLNCAGB, Func<CancellationToken, Task> HHMCHCNMDHO, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, int DEPDKEEDEEA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x17F79A0", Offset = "0x17F61A0", VA = "0x1817F79A0")]
	[AsyncStateMachine(typeof(HLHPNABABME))]
	public Task<T> JOGGECMHEEE<T>(CancellationToken JCCIHLNCAGB, Func<CancellationToken, Task<T>> HHMCHCNMDHO, [Optional] EJBLIOEJEKL CMFGONPKDEM, [Optional] EJBLIOEJEKL AAOCOFLOCMM, int DEPDKEEDEEA = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x17F7080", Offset = "0x17F5880", VA = "0x1817F7080")]
	[AsyncStateMachine(typeof(EJFHMBDGGOI))]
	private Task<(bool, T)> FACGHCGJDFM<T>(Guid JBKBMGHPHPC, CancellationToken JCCIHLNCAGB, Func<CancellationToken, Task<T>> HHMCHCNMDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6257E60", Offset = "0x6256660", VA = "0x186257E60")]
	public void PHKKMJFHDIL(byte PEOACDCAMNM, int PGJGDLHAEFF, object MNBJMIMEMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6254F40", Offset = "0x6253740", VA = "0x186254F40")]
	public Guid FPJNAFJCDMD(Guid KEKBLGILBJN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6257310", Offset = "0x6255B10", VA = "0x186257310")]
	public bool OEOFBGOPPMJ(CHKGIICKICK FCADMEJHNHP, Guid JBKBMGHPHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6256300", Offset = "0x6254B00", VA = "0x186256300")]
	public void KJIEJHCHFIJ(CHKGIICKICK FCADMEJHNHP, Guid JBKBMGHPHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62562F0", Offset = "0x6254AF0", VA = "0x1862562F0")]
	private void KHOAHMHAEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6257200", Offset = "0x6255A00", VA = "0x186257200")]
	internal CBDNBGEKFAM OBKAHJIEDDP(bool MCINIECPKNM = false)
	{
		return default(CBDNBGEKFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6254CF0", Offset = "0x62534F0", VA = "0x186254CF0")]
	private HashSet<Guid> DDCDEJPLHIO(CHKGIICKICK FCADMEJHNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6255D80", Offset = "0x6254580", VA = "0x186255D80")]
	private void JEDPMEEAGNH(CHKGIICKICK FCADMEJHNHP, Guid MKEJJPNNCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6256E50", Offset = "0x6255650", VA = "0x186256E50")]
	private void MJFLDBOHNKA(CHKGIICKICK FCADMEJHNHP, Guid MKEJJPNNCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6257150", Offset = "0x6255950", VA = "0x186257150")]
	public static Func<Guid, bool> NOEFBGKDLMB(Guid MKEJJPNNCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62551A0", Offset = "0x62539A0", VA = "0x1862551A0")]
	public static Func<Guid, bool> GOPFCAICKKI(Guid MKEJJPNNCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6254E30", Offset = "0x6253630", VA = "0x186254E30")]
	public void FJFAFGCKAMK(CHKGIICKICK FCADMEJHNHP, Guid GPMCECCEKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6257930", Offset = "0x6256130", VA = "0x186257930")]
	public void PAFIIGAEIEK(CHKGIICKICK FCADMEJHNHP, Func<Guid, bool> FFIONBGPFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6255850", Offset = "0x6254050", VA = "0x186255850")]
	private static ExitGames.Client.Photon.Hashtable HKLHKICJJEP(CHKGIICKICK FCADMEJHNHP, Guid PHDMILOCJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6256700", Offset = "0x6254F00", VA = "0x186256700")]
	private void LGIFKDEGEBK(CHKGIICKICK FCADMEJHNHP, Guid PHDMILOCJDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PNGKBCACLNE : LCONIFGADAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(HPBNNBBFJII.GOPDHPKPLHN itemType, long totalStopwatchTicks)> HCOJDFBPDDI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(HPBNNBBFJII.GOPDHPKPLHN itemType, long totalStopwatchTicks)> JBPCALCKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE20", Offset = "0x6DA620", VA = "0x1806DBE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62611B0", Offset = "0x625F9B0", VA = "0x1862611B0")]
	public PNGKBCACLNE(TimeSpan NCNCMLGEIJM, List<(HPBNNBBFJII.GOPDHPKPLHN itemType, long totalStopwatchTicks)> HCOJDFBPDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BGAKFNLIAGC : HBBBPGLKBIH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct MLGIPODBKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid DFJMBNLBPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int IHGAFDLAHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int AHEPKCKIAIG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x625E760", Offset = "0x625CF60", VA = "0x18625E760")]
		public MLGIPODBKFC(Guid POFADHEMAKN, int LLIBNMMEBFO, int BCKDOKFOOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x625E680", Offset = "0x625CE80", VA = "0x18625E680")]
		public static byte[] ODHIHDMAPDF(MLGIPODBKFC EPAIMCEIMPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x625E540", Offset = "0x625CD40", VA = "0x18625E540")]
		public static MLGIPODBKFC JFCMHHFNDFE(byte[] EBBNNMNMLOE)
		{
			return default(MLGIPODBKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x625E600", Offset = "0x625CE00", VA = "0x18625E600")]
		private static byte[] NEFCPNNEMGH(int AOKAFHMCMMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x625E490", Offset = "0x625CC90", VA = "0x18625E490")]
		private static int CEMHDKNJOLB(byte[] FMGFCCGGCLP, int LHHBOCAHDEE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid POFADHEMAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly AJCJCPIKJLL GBMJCFKCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool NDBKINDKNIL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x625A050", Offset = "0x6258850", VA = "0x18625A050")]
	public BGAKFNLIAGC(Guid POFADHEMAKN, AJCJCPIKJLL GBMJCFKCHCP, MMBEKLJFJHE AKIKINCCOGC, CancellationToken JCCIHLNCAGB, [Optional] IIIIFBGDIJM LHIBEEHGMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6259AC0", Offset = "0x62582C0", VA = "0x186259AC0", Slot = "5")]
	protected override void FBMEOPHGMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6259C90", Offset = "0x6258490", VA = "0x186259C90", Slot = "6")]
	protected override void GNFAPIBCIHP(int BOOPIJDEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6259E30", Offset = "0x6258630", VA = "0x186259E30")]
	private void KFAPOPHJMEB(ALNEMJDLIED HPOPKGOCACE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ALNEMJDLIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly CBDNBGEKFAM OELBKPPKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte IMHAIAKAPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte AEJOKGADGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool CDBFHKAEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] KAHHBKPIBEC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x62594F0", Offset = "0x6257CF0", VA = "0x1862594F0")]
	public ALNEMJDLIED(CBDNBGEKFAM IKKCNAANNEA, [CanBeNull] byte[] HBMMCJPOJGP, bool MFBNJFGICPJ, byte APLICKINHPD, byte DIJJBENLDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6259350", Offset = "0x6257B50", VA = "0x186259350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6259160", Offset = "0x6257960", VA = "0x186259160")]
	private static void PCAEFPNANFP(byte[] HBMMCJPOJGP, StringBuilder GEKGIFCBLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CBDNBGEKFAM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PEFCJACAOMM : IEnumerable<GNLBEHKAOOL>, IEnumerable, IEnumerator<GNLBEHKAOOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private GNLBEHKAOOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CBDNBGEKFAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CBDNBGEKFAM <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private CHKGIICKICK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GNLBEHKAOOL System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x41558E0", Offset = "0x41540E0", VA = "0x1841558E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GNLBEHKAOOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6261160", Offset = "0x625F960", VA = "0x186261160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97CE80", Offset = "0x97B680", VA = "0x18097CE80")]
		[DebuggerHidden]
		public PEFCJACAOMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6260E90", Offset = "0x625F690", VA = "0x186260E90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6261120", Offset = "0x625F920", VA = "0x186261120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6261080", Offset = "0x625F880", VA = "0x186261080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GNLBEHKAOOL> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6261080", Offset = "0x625F880", VA = "0x186261080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly CHKGIICKICK EEBPIBKJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] FNNBEHCBCNG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x625A130", Offset = "0x6258930", VA = "0x18625A130")]
	public static CBDNBGEKFAM DENKEELKECG(CHKGIICKICK FCADMEJHNHP, Guid BPGGNBCPCBK)
	{
		return default(CBDNBGEKFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x625A230", Offset = "0x6258A30", VA = "0x18625A230")]
	public static CBDNBGEKFAM JOMJHHALACD(List<GNLBEHKAOOL> GCEACKOFNLP)
	{
		return default(CBDNBGEKFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x625A650", Offset = "0x6258E50", VA = "0x18625A650")]
	public static CBDNBGEKFAM LILOPOJJPLN(CHKGIICKICK EKKNBOLMGIN, Guid[] LOHKIBAGOGE)
	{
		return default(CBDNBGEKFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x625AC30", Offset = "0x6259430", VA = "0x18625AC30")]
	private CBDNBGEKFAM(CHKGIICKICK EKKNBOLMGIN, Guid[] LOHKIBAGOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x625A0B0", Offset = "0x62588B0", VA = "0x18625A0B0")]
	[IteratorStateMachine(typeof(PEFCJACAOMM))]
	public IEnumerable<GNLBEHKAOOL> CHPANPNOCPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x625AAB0", Offset = "0x62592B0", VA = "0x18625AAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FIKKAJEOBAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B470", Offset = "0x2C79C70", VA = "0x182C7B470", Slot = "4")]
	public void OIHIHFFDGDC(T EPAIMCEIMPA, IDictionary<object, object> LBEMEOBAAJI, bool JJFBMNNFEKD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void COGHHHLCIIP(T EPAIMCEIMPA, IDictionary<object, object> LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T JFCMHHFNDFE(IDictionary<object, object> LBEMEOBAAJI);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected FIKKAJEOBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HBBBPGLKBIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool IIIIFBGDIJM(int MKLODJCJAGH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool KFGNFGMLOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly MMBEKLJFJHE NAAFNBDPJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken JCCIHLNCAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken CAHMAENGEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly IIIIFBGDIJM LHIBEEHGMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource KLKKOGCKJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource LIKOALMLLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int NKAKCDOEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BIEMDBBKMML;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken BMMMFOFHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x625CBC0", Offset = "0x625B3C0", VA = "0x18625CBC0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PHGJEDDELLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x625CCD0", Offset = "0x625B4D0", VA = "0x18625CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x625CD80", Offset = "0x625B580", VA = "0x18625CD80")]
	public HBBBPGLKBIH(MMBEKLJFJHE AKIKINCCOGC, CancellationToken JCCIHLNCAGB, [Optional] IIIIFBGDIJM LHIBEEHGMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x625CBA0", Offset = "0x625B3A0", VA = "0x18625CBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x625CBE0", Offset = "0x625B3E0", VA = "0x18625CBE0", Slot = "5")]
	protected virtual void FBMEOPHGMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x625CB00", Offset = "0x625B300", VA = "0x18625CB00")]
	private void DECCDMOEEHK(CPHBKIKDFMP FMLGLMNHILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x625CD20", Offset = "0x625B520", VA = "0x18625CD20")]
	protected void LLCELFJNCHK(int BOOPIJDEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x625CCB0", Offset = "0x625B4B0", VA = "0x18625CCB0", Slot = "6")]
	protected virtual void GNFAPIBCIHP(int BOOPIJDEHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GNLBEHKAOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly CHKGIICKICK EHIBLCONEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid COGGACHIKLC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D1B0", Offset = "0x1C5B9B0", VA = "0x181C5D1B0")]
	public GNLBEHKAOOL(CHKGIICKICK FCADMEJHNHP, Guid JBKBMGHPHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x625CA70", Offset = "0x625B270", VA = "0x18625CA70")]
	public bool GKAHDDHENKO(GNLBEHKAOOL HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x625C9B0", Offset = "0x625B1B0", VA = "0x18625C9B0", Slot = "0")]
	public override bool Equals(object BFHAMCLNCKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x625CAD0", Offset = "0x625B2D0", VA = "0x18625CAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum CHKGIICKICK : byte
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
internal static class JINCLABADCD
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly CHKGIICKICK[] NHKIJLDKMON;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x625D050", Offset = "0x625B850", VA = "0x18625D050")]
	public static int JMCPBPMOMFE(CHKGIICKICK FCADMEJHNHP)
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
