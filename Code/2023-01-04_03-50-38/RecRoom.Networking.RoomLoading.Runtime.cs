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
internal class GEOGBFBNMEN : global::NJCHCLFEFOB<NKFAKCAPHBG>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LJJMCADBDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LJJMCADBDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D682B0", Offset = "0x5D676B0", VA = "0x185D682B0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] ONAKGMCNDKB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly GEOGBFBNMEN KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D63B50", Offset = "0x5D62F50", VA = "0x185D63B50", Slot = "5")]
	protected override void FBINBPGPECG(NKFAKCAPHBG KAKCNEMJMJL, IDictionary<object, object> PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D63FC0", Offset = "0x5D633C0", VA = "0x185D63FC0", Slot = "6")]
	public override NKFAKCAPHBG LOHKEOMODAB(IDictionary<object, object> PNMIIEJFOON)
	{
		return default(NKFAKCAPHBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D64D40", Offset = "0x5D64140", VA = "0x185D64D40")]
	public GEOGBFBNMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MBHCBBFEHOI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string BNIOCNFAGCN([NotNull] byte[] NEIPJLDAIJA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct NOOKBPKBJPD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PDMKBINOMHF AGFLCBACEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool BBMJLAEFDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T ADANCGEACAK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39D5810", Offset = "0x39D4C10", VA = "0x1839D5810")]
		public static NOOKBPKBJPD<T> MJHIPNIBLIN(NKFAKCAPHBG CKEECHPAEIF, Func<byte[], T> DJJCMDJKJBD)
		{
			return default(NOOKBPKBJPD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39D5A70", Offset = "0x39D4E70", VA = "0x1839D5A70")]
		public NOOKBPKBJPD(PDMKBINOMHF BCCGLIPFCBJ, T NEIPJLDAIJA, bool JLADJCAFDCO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39D5990", Offset = "0x39D4D90", VA = "0x1839D5990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HCFAOEMEDDD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NICKEIMBJGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<NKFAKCAPHBG> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HCFAOEMEDDD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public NICKEIMBJGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D460", Offset = "0x5D6C860", VA = "0x185D6D460")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D4B0", Offset = "0x5D6C8B0", VA = "0x185D6D4B0")]
			internal FFLCKEJKKGO <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class BAKACBBMPOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IHCNJAPNMEC.FNNDCLGONFJ itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public BAKACBBMPOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D63260", Offset = "0x5D62660", VA = "0x185D63260")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct IAPDCIMBHEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<NKFAKCAPHBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HCFAOEMEDDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NICKEIMBJGJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<NKFAKCAPHBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5D66C90", Offset = "0x5D66090", VA = "0x185D66C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5D674A0", Offset = "0x5D668A0", VA = "0x185D674A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MDBLIBMPFBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public KONIHDAFFOL sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public MDBLIBMPFBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5D6CFD0", Offset = "0x5D6C3D0", VA = "0x185D6CFD0")]
			internal bool <ClearSlice>b__0(NKFAKCAPHBG bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NOGOJPOECKO MOIHMPDHDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string DBDDPGPGAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<NKFAKCAPHBG> IOEJMFAPLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(IHCNJAPNMEC.FNNDCLGONFJ itemType, long totalStopwatchTicks)> OJPMAELODNM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EIILJIIGGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5D66680", Offset = "0x5D65A80", VA = "0x185D66680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<NKFAKCAPHBG> HFILPELMGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5D66920", Offset = "0x5D65D20", VA = "0x185D66920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5D66AF0", Offset = "0x5D65EF0", VA = "0x185D66AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D66B90", Offset = "0x5D65F90", VA = "0x185D66B90")]
		public HCFAOEMEDDD(NOGOJPOECKO MOIHMPDHDKL, string DBDDPGPGAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D667D0", Offset = "0x5D65BD0", VA = "0x185D667D0")]
		[AsyncStateMachine(typeof(IAPDCIMBHEH))]
		public Task<NKFAKCAPHBG> FHCHNLAGHCJ(CancellationToken BJOMIPBBJKO, TimeSpan BMIAOLHKMBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D666D0", Offset = "0x5D65AD0", VA = "0x185D666D0")]
		public void DNJLIJMADII(NKFAKCAPHBG KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D66780", Offset = "0x5D65B80", VA = "0x185D66780", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D669C0", Offset = "0x5D65DC0", VA = "0x185D669C0")]
		public void OIMKGJIOOOJ(KONIHDAFFOL AMMIHABAJFJ, Guid KDFBMFGPICB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GGBBMLEHDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<NKFAKCAPHBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NFFKLIOJGMF pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D64D80", Offset = "0x5D64180", VA = "0x185D64D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D656A0", Offset = "0x5D64AA0", VA = "0x185D656A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GNLLGNDBLKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NFFKLIOJGMF pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<NOOKBPKBJPD<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5D66280", Offset = "0x5D65680", VA = "0x185D66280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D66630", Offset = "0x5D65A30", VA = "0x185D66630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KMHIKBBJDHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<NKFAKCAPHBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NFFKLIOJGMF pauseAfterListeningToken;

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
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D67720", Offset = "0x5D66B20", VA = "0x185D67720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D68020", Offset = "0x5D67420", VA = "0x185D68020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NNBOGICEIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NNBOGICEIHE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GKPELLINHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<NKFAKCAPHBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private NNBOGICEIHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NFFKLIOJGMF pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LJOHAIHLJFB <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D65790", Offset = "0x5D64B90", VA = "0x185D65790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D66230", Offset = "0x5D65630", VA = "0x185D66230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PEHMKBGIPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<NKFAKCAPHBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NFFKLIOJGMF pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<NKFAKCAPHBG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6F0B0", Offset = "0x5D6E4B0", VA = "0x185D6F0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6F490", Offset = "0x5D6E890", VA = "0x185D6F490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KIEBJCBIMAD
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
			public KIEBJCBIMAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5D6FAD0", Offset = "0x5D6EED0", VA = "0x185D6FAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5D6FC40", Offset = "0x5D6F040", VA = "0x185D6FC40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KIEBJCBIMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D674F0", Offset = "0x5D668F0", VA = "0x185D674F0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LIBBCAEKOFM : IAsyncStateMachine
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
		public MBHCBBFEHOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NFFKLIOJGMF unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NFFKLIOJGMF pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D68070", Offset = "0x5D67470", VA = "0x185D68070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KKKEEPMDIKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KKKEEPMDIKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5D67680", Offset = "0x5D66A80", VA = "0x185D67680")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D67630", Offset = "0x5D66A30", VA = "0x185D67630")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GHIIIDOBBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public KONIHDAFFOL sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GHIIIDOBBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D656F0", Offset = "0x5D64AF0", VA = "0x185D656F0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NOBOPEKHHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KONIHDAFFOL sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NOBOPEKHHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6DE20", Offset = "0x5D6D220", VA = "0x185D6DE20")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DJAIFJFOLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DJAIFJFOLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D63910", Offset = "0x5D62D10", VA = "0x185D63910")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CDJNHOJEOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CDJNHOJEOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D638A0", Offset = "0x5D62CA0", VA = "0x185D638A0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FGIDIDPKLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FGIDIDPKLOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D63A00", Offset = "0x5D62E00", VA = "0x185D63A00")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NLAMMLINKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NLAMMLINKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5D6DC20", Offset = "0x5D6D020", VA = "0x185D6DC20")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FOBFLDMMKHI
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FOBFLDMMKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D63AF0", Offset = "0x5D62EF0", VA = "0x185D63AF0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D63A90", Offset = "0x5D62E90", VA = "0x185D63A90")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AACGOKHFBOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public AACGOKHFBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D63140", Offset = "0x5D62540", VA = "0x185D63140")]
		internal bool <ClearSliceIds>b__3(OPNCGHPGNJH stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BCKKFNMLNEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BCKKFNMLNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5D633A0", Offset = "0x5D627A0", VA = "0x185D633A0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5D63620", Offset = "0x5D62A20", VA = "0x185D63620")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5D63330", Offset = "0x5D62730", VA = "0x185D63330")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly BNIOCNFAGCN EIMNONBAPGI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable HOPCKHHIANO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly DDAFFKGIMND PNHLOBIKCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HCFAOEMEDDD EEOAGCCCNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NOGOJPOECKO MOIHMPDHDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LBEAFNPGOGA IAICLHIHPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EFOGLGILCDH CEFEDKFFENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BNIOCNFAGCN FAFEPGJAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DAIKPAIAHEO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan GIOFOJPKDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan NLHNDEAHLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte MKKIJKEGJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] EICDCEHLGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<OPNCGHPGNJH> IKFIIJKMIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PDMKBINOMHF? JHPLBHDKNHH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly DDAFFKGIMND PAIHBNEJEKD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly DDAFFKGIMND LOLLEPGIKNB;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<NKFAKCAPHBG> JDIFBOCMIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D68E60", Offset = "0x5D68260", VA = "0x185D68E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D68F00", Offset = "0x5D68300", VA = "0x185D68F00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D6CB20", Offset = "0x5D6BF20", VA = "0x185D6CB20")]
	public MBHCBBFEHOI(NOGOJPOECKO MOIHMPDHDKL, LBEAFNPGOGA IAICLHIHPIN, EFOGLGILCDH CEFEDKFFENF, [Optional] TimeSpan? NGBIEBFBPMC, [Optional] BNIOCNFAGCN ICPHKONOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32225E0", Offset = "0x32219E0", VA = "0x1832225E0")]
	public static MBHCBBFEHOI NMJEEGKPIID<TNetworking>(TNetworking CHLPJFPJJFO, [Optional] TimeSpan? NGBIEBFBPMC, [Optional] BNIOCNFAGCN ICPHKONOGIH) where TNetworking : NOGOJPOECKO, LBEAFNPGOGA, EFOGLGILCDH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B620", Offset = "0x5D6AA20", VA = "0x185D6B620")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A0D0", Offset = "0x5D694D0", VA = "0x185D6A0D0")]
	private byte HDHKNBGCPBK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D69650", Offset = "0x5D68A50", VA = "0x185D69650")]
	private TimeSpan FNMBMJOMPMF(TimeSpan? NGBIEBFBPMC, int EMDALDHNAMO = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3221D00", Offset = "0x3221100", VA = "0x183221D00")]
	public bool GHHMJHKOAIC<T>(T ICNNHPOPBIE, Func<T, byte[]> ABEAJHEEIJP, bool JLADJCAFDCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D69940", Offset = "0x5D68D40", VA = "0x185D69940")]
	public bool GHHMJHKOAIC(byte[] ICNNHPOPBIE, int HDBPGJKBPHN, bool JLADJCAFDCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	private static string ADMIAIMHKPE(string KAKCNEMJMJL, string CNDGCCPDGDM = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D68A80", Offset = "0x5D67E80", VA = "0x185D68A80")]
	[AsyncStateMachine(typeof(GGBBMLEHDDJ))]
	public Task<NKFAKCAPHBG> CFDLBCFIMLC(CancellationToken BJOMIPBBJKO, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, [Optional] TimeSpan? NGBIEBFBPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D688F0", Offset = "0x5D67CF0", VA = "0x185D688F0")]
	[AsyncStateMachine(typeof(GNLLGNDBLKB))]
	public Task<Guid> CEINMDFLDJC(Guid JGNPMFEODPD, CancellationToken BJOMIPBBJKO, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, [Optional] TimeSpan? BMIAOLHKMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3222260", Offset = "0x3221660", VA = "0x183222260")]
	[AsyncStateMachine(typeof(JAEJICMLCPH))]
	public Task<NOOKBPKBJPD<T>> KIHEJBHOEGG<T>(T ICNNHPOPBIE, Func<T, byte[]> ABEAJHEEIJP, Func<byte[], T> DJJCMDJKJBD, CancellationToken BJOMIPBBJKO, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, [Optional] TimeSpan? BMIAOLHKMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A8B0", Offset = "0x5D69CB0", VA = "0x185D6A8B0")]
	[AsyncStateMachine(typeof(KMHIKBBJDHM))]
	public Task<NKFAKCAPHBG> KIHEJBHOEGG(byte[] ICNNHPOPBIE, CancellationToken BJOMIPBBJKO, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, [Optional] TimeSpan? BMIAOLHKMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D69F20", Offset = "0x5D69320", VA = "0x185D69F20")]
	[AsyncStateMachine(typeof(GKPELLINHNG))]
	private Task<NKFAKCAPHBG> HCOHILDAODF(byte[] ICNNHPOPBIE, CancellationToken BJOMIPBBJKO, NFFKLIOJGMF GPNDOHKECFI, NFFKLIOJGMF FGCBNKDIPKO, TimeSpan? NGBIEBFBPMC, Stopwatch NNAKHKPMNPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D68FA0", Offset = "0x5D683A0", VA = "0x185D68FA0")]
	[AsyncStateMachine(typeof(PEHMKBGIPFA))]
	private Task<NKFAKCAPHBG> FCNFPJFDIBJ(byte[] ICNNHPOPBIE, CancellationToken BJOMIPBBJKO, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, [Optional] TimeSpan? BMIAOLHKMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A460", Offset = "0x5D69860", VA = "0x185D6A460")]
	[AsyncStateMachine(typeof(LIBBCAEKOFM))]
	public Task JEHEHMKOCIF(CancellationToken DECHKOCCOAA, Func<CancellationToken, Task> CNEBJLFLBAL, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, int DDCGPAJDMLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3221DB0", Offset = "0x32211B0", VA = "0x183221DB0")]
	[AsyncStateMachine(typeof(JOMNAJICEDI))]
	public Task<T> JEHEHMKOCIF<T>(CancellationToken DECHKOCCOAA, Func<CancellationToken, Task<T>> CNEBJLFLBAL, [Optional] NFFKLIOJGMF GPNDOHKECFI, [Optional] NFFKLIOJGMF FGCBNKDIPKO, int DDCGPAJDMLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32218B0", Offset = "0x3220CB0", VA = "0x1832218B0")]
	[AsyncStateMachine(typeof(PKNBNIIDDJE))]
	private Task<(bool, T)> CGKPCLLDHID<T>(Guid FDOLBFAMFMN, CancellationToken DECHKOCCOAA, Func<CancellationToken, Task<T>> CNEBJLFLBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B820", Offset = "0x5D6AC20", VA = "0x185D6B820")]
	public void OKGKNGOAOBE(byte FFINJKAOMCH, int OCBFIFAFHBM, object OKDONDENCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A0E0", Offset = "0x5D694E0", VA = "0x185D6A0E0")]
	public Guid HGKKNCBMGMO(Guid BHGOHDINFJE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ACB0", Offset = "0x5D6A0B0", VA = "0x185D6ACB0")]
	public bool NAHCJEAINLB(KONIHDAFFOL AMMIHABAJFJ, Guid FDOLBFAMFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B230", Offset = "0x5D6A630", VA = "0x185D6B230")]
	public void NAHJNKABIBB(KONIHDAFFOL AMMIHABAJFJ, Guid FDOLBFAMFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A340", Offset = "0x5D69740", VA = "0x185D6A340")]
	private void JAHJIHAFBBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A350", Offset = "0x5D69750", VA = "0x185D6A350")]
	internal PDMKBINOMHF JBCFGFJKOCO(bool NDADLKOGFID = false)
	{
		return default(PDMKBINOMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D68C00", Offset = "0x5D68000", VA = "0x185D68C00")]
	private HashSet<Guid> CHCLDCGLGCJ(KONIHDAFFOL AMMIHABAJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AAF0", Offset = "0x5D69EF0", VA = "0x185D6AAF0")]
	private void LEFDLODPEPE(KONIHDAFFOL AMMIHABAJFJ, Guid KDFBMFGPICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A5D0", Offset = "0x5D699D0", VA = "0x185D6A5D0")]
	private void JFAHLKEEBJF(KONIHDAFFOL AMMIHABAJFJ, Guid KDFBMFGPICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AA40", Offset = "0x5D69E40", VA = "0x185D6AA40")]
	public static Func<Guid, bool> KJNNOFMLINF(Guid KDFBMFGPICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D69890", Offset = "0x5D68C90", VA = "0x185D69890")]
	public static Func<Guid, bool> FODMILMEMBK(Guid KDFBMFGPICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B710", Offset = "0x5D6AB10", VA = "0x185D6B710")]
	public void OIMKGJIOOOJ(KONIHDAFFOL AMMIHABAJFJ, Guid ECIPILDKLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D69130", Offset = "0x5D68530", VA = "0x185D69130")]
	public void FDAHOANKFOA(KONIHDAFFOL AMMIHABAJFJ, Func<Guid, bool> FJMEJMHIMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D68D40", Offset = "0x5D68140", VA = "0x185D68D40")]
	private static ExitGames.Client.Photon.Hashtable CNDNNGBIAID(KONIHDAFFOL AMMIHABAJFJ, Guid KHKFCFKPHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C1B0", Offset = "0x5D6B5B0", VA = "0x185D6C1B0")]
	private void PIJPHMMIFPM(KONIHDAFFOL AMMIHABAJFJ, Guid KHKFCFKPHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FFLCKEJKKGO : ADFGABMKFEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(IHCNJAPNMEC.FNNDCLGONFJ itemType, long totalStopwatchTicks)> IMELABNGHIE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(IHCNJAPNMEC.FNNDCLGONFJ itemType, long totalStopwatchTicks)> MGOBOEADNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67EE20", Offset = "0x67E220", VA = "0x18067EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D63980", Offset = "0x5D62D80", VA = "0x185D63980")]
	public FFLCKEJKKGO(TimeSpan BMIAOLHKMBF, List<(IHCNJAPNMEC.FNNDCLGONFJ itemType, long totalStopwatchTicks)> IMELABNGHIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class POLFOFGKPFC : LJOHAIHLJFB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct OPADBPBEAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid HHKMLOCKEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int ANEJIEKPKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int KCICADABJAE;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E190", Offset = "0x5D6D590", VA = "0x185D6E190")]
		public OPADBPBEAJA(Guid HPEPINCFDLD, int PJGACJIGOPK, int MPAKJKLHPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D6DF70", Offset = "0x5D6D370", VA = "0x185D6DF70")]
		public static byte[] FBLBIDAIACI(OPADBPBEAJA KAKCNEMJMJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E0D0", Offset = "0x5D6D4D0", VA = "0x185D6E0D0")]
		public static OPADBPBEAJA LOHKEOMODAB(byte[] EEMDNKKFCBK)
		{
			return default(OPADBPBEAJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E050", Offset = "0x5D6D450", VA = "0x185D6E050")]
		private static byte[] ILOIMPDBFHI(int FNHGJOONKOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6DEC0", Offset = "0x5D6D2C0", VA = "0x185D6DEC0")]
		private static int AAFIOHLMMJM(byte[] KIPJNGHBKHA, int HMJKJGLHFKE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid HPEPINCFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MBHCBBFEHOI AFABPADDFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool IPIMGPOJEPG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FA70", Offset = "0x5D6EE70", VA = "0x185D6FA70")]
	public POLFOFGKPFC(Guid HPEPINCFDLD, MBHCBBFEHOI AFABPADDFPC, EFOGLGILCDH CHLPJFPJJFO, CancellationToken DECHKOCCOAA, [Optional] AAIDAJPCLKK CBIJEJLPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F4E0", Offset = "0x5D6E8E0", VA = "0x185D6F4E0", Slot = "5")]
	protected override void FCALEADMOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F8D0", Offset = "0x5D6ECD0", VA = "0x185D6F8D0", Slot = "6")]
	protected override void LPNBBOOEGFJ(int LLBKOFABBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F6B0", Offset = "0x5D6EAB0", VA = "0x185D6F6B0")]
	private void JDIFBOCMIMC(NKFAKCAPHBG JBGNLNMHJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct NKFAKCAPHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly PDMKBINOMHF AGFLCBACEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte JILKFIJLECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte HGFAEBPBHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool BBMJLAEFDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] ADANCGEACAK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DBC0", Offset = "0x5D6CFC0", VA = "0x185D6DBC0")]
	public NKFAKCAPHBG(PDMKBINOMHF BCCGLIPFCBJ, [CanBeNull] byte[] NEIPJLDAIJA, bool JLADJCAFDCO, byte IKKDPMMAJBN, byte GKDODLCAELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6DA20", Offset = "0x5D6CE20", VA = "0x185D6DA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6D830", Offset = "0x5D6CC30", VA = "0x185D6D830")]
	private static void EPBOJMDEFCG(byte[] NEIPJLDAIJA, StringBuilder BIOJHMCHAFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct PDMKBINOMHF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NDMGBPOGKOL : IEnumerable<OPNCGHPGNJH>, IEnumerable, IEnumerator<OPNCGHPGNJH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private OPNCGHPGNJH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public PDMKBINOMHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public PDMKBINOMHF <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private KONIHDAFFOL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OPNCGHPGNJH System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2BDFFE0", Offset = "0x2BDF3E0", VA = "0x182BDFFE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OPNCGHPGNJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D410", Offset = "0x5D6C810", VA = "0x185D6D410", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60")]
		[DebuggerHidden]
		public NDMGBPOGKOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D140", Offset = "0x5D6C540", VA = "0x185D6D140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D3D0", Offset = "0x5D6C7D0", VA = "0x185D6D3D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D330", Offset = "0x5D6C730", VA = "0x185D6D330", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPNCGHPGNJH> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D330", Offset = "0x5D6C730", VA = "0x185D6D330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly KONIHDAFFOL ANNDJNMJJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] GLEDOECNDJC;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E370", Offset = "0x5D6D770", VA = "0x185D6E370")]
	public static PDMKBINOMHF EDPPLJDHGEF(KONIHDAFFOL AMMIHABAJFJ, Guid PMEIMOKNBDO)
	{
		return default(PDMKBINOMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E470", Offset = "0x5D6D870", VA = "0x185D6E470")]
	public static PDMKBINOMHF IGOGAPBACAL(List<OPNCGHPGNJH> INHLAFNEKNO)
	{
		return default(PDMKBINOMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E890", Offset = "0x5D6DC90", VA = "0x185D6E890")]
	public static PDMKBINOMHF NNLMCOJLLFB(KONIHDAFFOL FBCKINJCHEN, Guid[] GPFHDDGCLDK)
	{
		return default(PDMKBINOMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EE70", Offset = "0x5D6E270", VA = "0x185D6EE70")]
	private PDMKBINOMHF(KONIHDAFFOL FBCKINJCHEN, Guid[] GPFHDDGCLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E2F0", Offset = "0x5D6D6F0", VA = "0x185D6E2F0")]
	[IteratorStateMachine(typeof(NDMGBPOGKOL))]
	public IEnumerable<OPNCGHPGNJH> DGEKEPAHBAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ECF0", Offset = "0x5D6E0F0", VA = "0x185D6ECF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class NJCHCLFEFOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x39C3A90", Offset = "0x39C2E90", VA = "0x1839C3A90", Slot = "4")]
	public void LAFJAPOKMNB(T KAKCNEMJMJL, IDictionary<object, object> PNMIIEJFOON, bool HJBGHJKAICC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FBINBPGPECG(T KAKCNEMJMJL, IDictionary<object, object> PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T LOHKEOMODAB(IDictionary<object, object> PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected NJCHCLFEFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LJOHAIHLJFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool AAIDAJPCLKK(int IGAFGAFOFNO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly EFOGLGILCDH MCIFHFALKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken DECHKOCCOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken DMIMHNJNAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly AAIDAJPCLKK CBIJEJLPOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource BKHPEFBALGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource JMCPNGLGBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int FPHIGFJCBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool KHIFPJEMNCN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken OIMALIPDANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D68370", Offset = "0x5D67770", VA = "0x185D68370")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PAMBOPJPAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D68480", Offset = "0x5D67880", VA = "0x185D68480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D685F0", Offset = "0x5D679F0", VA = "0x185D685F0")]
	public LJOHAIHLJFB(EFOGLGILCDH CHLPJFPJJFO, CancellationToken DECHKOCCOAA, [Optional] AAIDAJPCLKK CBIJEJLPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D68390", Offset = "0x5D67790", VA = "0x185D68390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D683B0", Offset = "0x5D677B0", VA = "0x185D683B0", Slot = "5")]
	protected virtual void FCALEADMOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D68530", Offset = "0x5D67930", VA = "0x185D68530")]
	private void IHLGNCPPLMO(GLJCDOAILMB OPFCKFFLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D684D0", Offset = "0x5D678D0", VA = "0x185D684D0")]
	protected void HOFEICEPOGG(int LLBKOFABBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D685D0", Offset = "0x5D679D0", VA = "0x185D685D0", Slot = "6")]
	protected virtual void LPNBBOOEGFJ(int LLBKOFABBKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OPNCGHPGNJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly KONIHDAFFOL MCIOLHKCAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid OPFMGDJMENJ;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4268210", Offset = "0x4267610", VA = "0x184268210")]
	public OPNCGHPGNJH(KONIHDAFFOL AMMIHABAJFJ, Guid FDOLBFAMFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E290", Offset = "0x5D6D690", VA = "0x185D6E290")]
	public bool PNCPEDMHILH(OPNCGHPGNJH EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E1A0", Offset = "0x5D6D5A0", VA = "0x185D6E1A0", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E260", Offset = "0x5D6D660", VA = "0x185D6E260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum KONIHDAFFOL : byte
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
internal static class MAFLHFKJGLG
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly KONIHDAFFOL[] LJKDCKKMJML;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D687A0", Offset = "0x5D67BA0", VA = "0x185D687A0")]
	public static int FEJJDKBPEKC(KONIHDAFFOL AMMIHABAJFJ)
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
