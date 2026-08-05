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
internal class KFLNOJOMBFJ : global::GKLHOAOCFAO<DGMFAOJAOCJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FLCONGODLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FLCONGODLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57264D0", Offset = "0x57250D0", VA = "0x1857264D0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] GEAKMCKKIPC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly KFLNOJOMBFJ PPLIIACIKDD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5727D90", Offset = "0x5726990", VA = "0x185727D90", Slot = "5")]
	protected override void IPKLPJMGHIG(DGMFAOJAOCJ EHGGIAFACBG, IDictionary<object, object> CEECNJJKNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5728180", Offset = "0x5726D80", VA = "0x185728180", Slot = "6")]
	public override DGMFAOJAOCJ OPELNPIHKCP(IDictionary<object, object> CEECNJJKNFO)
	{
		return default(DGMFAOJAOCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5728C50", Offset = "0x5727850", VA = "0x185728C50")]
	public KFLNOJOMBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AGEOHAGKELJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string BMEOBIMKABC([NotNull] byte[] IBEPFEBNHGC);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum GNCKEDBOKNE : byte
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
	private readonly struct IJAEGDMCBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly GNCKEDBOKNE LMINMFNMBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid FNODJLOPAHA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4601DE0", Offset = "0x46009E0", VA = "0x184601DE0")]
		public IJAEGDMCBCM(GNCKEDBOKNE NBOLOLKCOEB, Guid NLFDMHEOLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5726ED0", Offset = "0x5725AD0", VA = "0x185726ED0")]
		public bool KMDDCOFIBJP(IJAEGDMCBCM LPEBOAHCFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5726DE0", Offset = "0x57259E0", VA = "0x185726DE0", Slot = "0")]
		public override bool Equals(object HLJJNKOAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5726EA0", Offset = "0x5725AA0", VA = "0x185726EA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ENJGNGAJOOC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool ENBFCAIAAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly GNCKEDBOKNE LMINMFNMBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] AIBONKBCAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T HJLEFMOIJNP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2466DD0", Offset = "0x24659D0", VA = "0x182466DD0")]
		public static ENJGNGAJOOC<T> PJNOGPIODME(DGMFAOJAOCJ HHPIKFIPHEH, Func<byte[], T> KEPPGFHOMFH)
		{
			return default(ENJGNGAJOOC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x24671E0", Offset = "0x2465DE0", VA = "0x1824671E0")]
		public ENJGNGAJOOC(GNCKEDBOKNE NBOLOLKCOEB, Guid[] ADKLFMIPAHC, T IBEPFEBNHGC, bool OLPKJEBAABC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x24670C0", Offset = "0x2465CC0", VA = "0x1824670C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class GLOBEJKNLOH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OIEDGMLEJDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<DGMFAOJAOCJ> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GLOBEJKNLOH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public OIEDGMLEJDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5729BE0", Offset = "0x57287E0", VA = "0x185729BE0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5729C30", Offset = "0x5728830", VA = "0x185729C30")]
			internal DJJAMNDKGBA <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CKKIGKOELMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public GNFLMMFACPF.FJHGDKAELDN itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public CKKIGKOELMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5725160", Offset = "0x5723D60", VA = "0x185725160")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PCAFFMOPGMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<DGMFAOJAOCJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLOBEJKNLOH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private OIEDGMLEJDP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<DGMFAOJAOCJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5729F50", Offset = "0x5728B50", VA = "0x185729F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x572A600", Offset = "0x5729200", VA = "0x18572A600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IFNDMNBNNBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public GNCKEDBOKNE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public IFNDMNBNNBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5726C70", Offset = "0x5725870", VA = "0x185726C70")]
			internal bool <ClearSlice>b__0(DGMFAOJAOCJ bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly NAIBLCMEMEE PGMMKNGDOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string JGOJJOGPDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DGMFAOJAOCJ> GPLFEOJNMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(GNFLMMFACPF.FJHGDKAELDN itemType, long totalStopwatchTicks)> BAFFEKPCKLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GDGHMHFONFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5726920", Offset = "0x5725520", VA = "0x185726920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<DGMFAOJAOCJ> GBADPGHPGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5726AA0", Offset = "0x57256A0", VA = "0x185726AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x57267D0", Offset = "0x57253D0", VA = "0x1857267D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5726B40", Offset = "0x5725740", VA = "0x185726B40")]
		public GLOBEJKNLOH(NAIBLCMEMEE PGMMKNGDOIC, string JGOJJOGPDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5726960", Offset = "0x5725560", VA = "0x185726960")]
		[AsyncStateMachine(typeof(PCAFFMOPGMN))]
		public Task<DGMFAOJAOCJ> LAJFIODEDFK(CancellationToken NKLNCNDPFGD, TimeSpan CFAFKOMKLHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5726870", Offset = "0x5725470", VA = "0x185726870")]
		public void JAFDABGHIDM(DGMFAOJAOCJ EHGGIAFACBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5726780", Offset = "0x5725380", VA = "0x185726780", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5726690", Offset = "0x5725290", VA = "0x185726690")]
		public void AHLBNFNPFDH(GNCKEDBOKNE NBOLOLKCOEB, Guid PHGKKLLIIFD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IPMOMENJKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DGMFAOJAOCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BMNJFIPJIJC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<DGMFAOJAOCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5726F30", Offset = "0x5725B30", VA = "0x185726F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5727710", Offset = "0x5726310", VA = "0x185727710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AJCLDLJHDCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BMNJFIPJIJC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<ENJGNGAJOOC<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5724A70", Offset = "0x5723670", VA = "0x185724A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5724D90", Offset = "0x5723990", VA = "0x185724D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KIBIAIHDLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<DGMFAOJAOCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BMNJFIPJIJC pauseAfterListeningToken;

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
		private TaskAwaiter<DGMFAOJAOCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5728C90", Offset = "0x5727890", VA = "0x185728C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57293E0", Offset = "0x5727FE0", VA = "0x1857293E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FJJGAINMHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FJJGAINMHHE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct PDDEFIPBIPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<DGMFAOJAOCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private FJJGAINMHHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BMNJFIPJIJC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private EJKDPMPCEKB <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<DGMFAOJAOCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x572A650", Offset = "0x5729250", VA = "0x18572A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x572AEC0", Offset = "0x5729AC0", VA = "0x18572AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BNADPIFMFIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<DGMFAOJAOCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BMNJFIPJIJC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<DGMFAOJAOCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5724DE0", Offset = "0x57239E0", VA = "0x185724DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5725110", Offset = "0x5723D10", VA = "0x185725110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DONECFBNAAG
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
			public DONECFBNAAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x572B200", Offset = "0x5729E00", VA = "0x18572B200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x572B360", Offset = "0x5729F60", VA = "0x18572B360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public DONECFBNAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5725E80", Offset = "0x5724A80", VA = "0x185725E80")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PHGMMICNJPE : IAsyncStateMachine
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
		public AGEOHAGKELJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BMNJFIPJIJC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public BMNJFIPJIJC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x572AF10", Offset = "0x5729B10", VA = "0x18572AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KBGAIMMAOCN : IEnumerable<(GNCKEDBOKNE, Guid)>, IEnumerable, IEnumerator<(GNCKEDBOKNE, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (GNCKEDBOKNE sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private GNCKEDBOKNE sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GNCKEDBOKNE <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GNCKEDBOKNE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (GNCKEDBOKNE, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x292FD50", Offset = "0x292E950", VA = "0x18292FD50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((GNCKEDBOKNE, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5727D40", Offset = "0x5726940", VA = "0x185727D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D7D0", Offset = "0xA0C3D0", VA = "0x180A0D7D0")]
		[DebuggerHidden]
		public KBGAIMMAOCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5727A20", Offset = "0x5726620", VA = "0x185727A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5727CF0", Offset = "0x57268F0", VA = "0x185727CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5727C40", Offset = "0x5726840", VA = "0x185727C40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(GNCKEDBOKNE, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5727C40", Offset = "0x5726840", VA = "0x185727C40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LPNGIFJGDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public LPNGIFJGDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x57294B0", Offset = "0x57280B0", VA = "0x1857294B0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x57294F0", Offset = "0x57280F0", VA = "0x1857294F0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5729540", Offset = "0x5728140", VA = "0x185729540")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KJJJGKDHABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public GNCKEDBOKNE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public KJJJGKDHABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5729430", Offset = "0x5728030", VA = "0x185729430")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NMBDOAKJNAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public GNCKEDBOKNE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public NMBDOAKJNAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5729B60", Offset = "0x5728760", VA = "0x185729B60")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GEBACOPOFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public GEBACOPOFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5726630", Offset = "0x5725230", VA = "0x185726630")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HNDGBGEOIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public HNDGBGEOIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5726C10", Offset = "0x5725810", VA = "0x185726C10")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NLJDOLELPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public NLJDOLELPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5729AD0", Offset = "0x57286D0", VA = "0x185729AD0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PMIDLGFAGLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public PMIDLGFAGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x572B170", Offset = "0x5729D70", VA = "0x18572B170")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GBBLALIDEIK
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public GBBLALIDEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x57265D0", Offset = "0x57251D0", VA = "0x1857265D0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5726570", Offset = "0x5725170", VA = "0x185726570")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DDIGDGCJECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public DDIGDGCJECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5725210", Offset = "0x5723E10", VA = "0x185725210")]
		internal bool <ClearSliceIds>b__3(IJAEGDMCBCM stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5725310", Offset = "0x5723F10", VA = "0x185725310")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5725550", Offset = "0x5724150", VA = "0x185725550")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57252B0", Offset = "0x5723EB0", VA = "0x1857252B0")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly BMEOBIMKABC LDEKHFEEOGD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable PKEDBELFDOK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MIOMNMCGCGF KIEOOMFIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GLOBEJKNLOH BFJKIGBIECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NAIBLCMEMEE PGMMKNGDOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JLOJAGAOBPD FGPBGPCNGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GFCNFCIHGIM EOEJJEHCEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BMEOBIMKABC OPPDGJBJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KCKLADPBJBF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan EIJJGHNMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan CJKHMGMEKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte JCPHPLFCBFH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly GNCKEDBOKNE[] HICAFIIJIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] MAFDLEDLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<IJAEGDMCBCM> OPFKDNDIKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (GNCKEDBOKNE combinedSliceType, Guid[] sliceTypeIds)? HOJHCEJEKPK;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<DGMFAOJAOCJ> BNBOGCDGINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5723260", Offset = "0x5721E60", VA = "0x185723260")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5724430", Offset = "0x5723030", VA = "0x185724430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5724680", Offset = "0x5723280", VA = "0x185724680")]
	public AGEOHAGKELJ(NAIBLCMEMEE PGMMKNGDOIC, JLOJAGAOBPD FGPBGPCNGAF, GFCNFCIHGIM EOEJJEHCEII, [Optional] TimeSpan? OOMLNOJMMDO, [Optional] BMEOBIMKABC OCFPPIEKAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23854E0", Offset = "0x23840E0", VA = "0x1823854E0")]
	public static AGEOHAGKELJ MKABLFIGBDE<TNetworking>(TNetworking DDMKKFCKMAO, [Optional] TimeSpan? OOMLNOJMMDO, [Optional] BMEOBIMKABC OCFPPIEKAPA) where TNetworking : NAIBLCMEMEE, JLOJAGAOBPD, GFCNFCIHGIM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57223A0", Offset = "0x5720FA0", VA = "0x1857223A0")]
	public void KHFNNCAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5721D70", Offset = "0x5720970", VA = "0x185721D70")]
	private byte HAGBDIKAIJH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5722600", Offset = "0x5721200", VA = "0x185722600")]
	private TimeSpan LDGFOFFFEFF(TimeSpan? OOMLNOJMMDO, int BILMMHKECEN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28A2570", Offset = "0x28A1170", VA = "0x1828A2570")]
	public bool GMPOFAEGPHH<T>(T GOMDFBLCFHO, Func<T, byte[]> DOFPJMPPGBL, bool OLPKJEBAABC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5721850", Offset = "0x5720450", VA = "0x185721850")]
	public bool GMPOFAEGPHH(byte[] GOMDFBLCFHO, int DIBGLLEFCNB, bool OLPKJEBAABC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x699F60", Offset = "0x698B60", VA = "0x180699F60")]
	private static string MHPGOBNAICB(string EHGGIAFACBG, string GOKDGJHFBBA = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5720F00", Offset = "0x571FB00", VA = "0x185720F00")]
	[AsyncStateMachine(typeof(IPMOMENJKMD))]
	public Task<DGMFAOJAOCJ> ANDGIHIALFK(CancellationToken NKLNCNDPFGD, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, [Optional] TimeSpan? OOMLNOJMMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x57216F0", Offset = "0x57202F0", VA = "0x1857216F0")]
	[AsyncStateMachine(typeof(AJCLDLJHDCO))]
	public Task<Guid> GEDECBMFNDA(Guid JOBBJNEILGC, CancellationToken NKLNCNDPFGD, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, [Optional] TimeSpan? CFAFKOMKLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F92280", Offset = "0x1F90E80", VA = "0x181F92280")]
	[AsyncStateMachine(typeof(NHONOOBKDCC))]
	public Task<ENJGNGAJOOC<T>> CCPPMKBDMOE<T>(T GOMDFBLCFHO, Func<T, byte[]> DOFPJMPPGBL, Func<byte[], T> KEPPGFHOMFH, CancellationToken NKLNCNDPFGD, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, [Optional] TimeSpan? CFAFKOMKLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5721250", Offset = "0x571FE50", VA = "0x185721250")]
	[AsyncStateMachine(typeof(KIBIAIHDLLK))]
	public Task<DGMFAOJAOCJ> CCPPMKBDMOE(byte[] GOMDFBLCFHO, CancellationToken NKLNCNDPFGD, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, [Optional] TimeSpan? CFAFKOMKLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5722480", Offset = "0x5721080", VA = "0x185722480")]
	[AsyncStateMachine(typeof(PDDEFIPBIPK))]
	private Task<DGMFAOJAOCJ> LCKBPPMODHK(byte[] GOMDFBLCFHO, CancellationToken NKLNCNDPFGD, BMNJFIPJIJC BJDBHKLAPBE, BMNJFIPJIJC OPBALKHKCKM, TimeSpan? OOMLNOJMMDO, Stopwatch CGLHGHGOIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57210E0", Offset = "0x571FCE0", VA = "0x1857210E0")]
	[AsyncStateMachine(typeof(BNADPIFMFIB))]
	private Task<DGMFAOJAOCJ> CAAJIAHJKGB(byte[] GOMDFBLCFHO, CancellationToken NKLNCNDPFGD, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, [Optional] TimeSpan? CFAFKOMKLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57213C0", Offset = "0x571FFC0", VA = "0x1857213C0")]
	[AsyncStateMachine(typeof(PHGMMICNJPE))]
	public Task CDDFNHHGCFG(CancellationToken EAMPAKHINCA, Func<CancellationToken, Task> OEBCGJGIHFO, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, int CONFGEDFFBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F92440", Offset = "0x1F91040", VA = "0x181F92440")]
	[AsyncStateMachine(typeof(PPBOJOHJHLF))]
	public Task<T> CDDFNHHGCFG<T>(CancellationToken EAMPAKHINCA, Func<CancellationToken, Task<T>> OEBCGJGIHFO, [Optional] BMNJFIPJIJC BJDBHKLAPBE, [Optional] BMNJFIPJIJC OPBALKHKCKM, int CONFGEDFFBB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F92920", Offset = "0x1F91520", VA = "0x181F92920")]
	[AsyncStateMachine(typeof(LGJANJAOLOE))]
	private Task<(bool, T)> OBLBGFPOOJC<T>(Guid NLFDMHEOLDB, CancellationToken EAMPAKHINCA, Func<CancellationToken, Task<T>> OEBCGJGIHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5721060", Offset = "0x571FC60", VA = "0x185721060")]
	[IteratorStateMachine(typeof(KBGAIMMAOCN))]
	internal static IEnumerable<(GNCKEDBOKNE, Guid)> BDLAEDGFDKD(GNCKEDBOKNE LAFDANKEDMF, Guid[] LFLKPJAJIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5722B10", Offset = "0x5721710", VA = "0x185722B10")]
	public void MDCAFDBOOEG(byte LABEOEPAFNC, int JCCMLDPBFJG, object MEDDCFJEKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5721F00", Offset = "0x5720B00", VA = "0x185721F00")]
	public Guid IBMAEGPHIJN(Guid HGBBNLDFCAF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5723F30", Offset = "0x5722B30", VA = "0x185723F30")]
	internal static int NMOPGHGFEAN(GNCKEDBOKNE NBOLOLKCOEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5723FE0", Offset = "0x5722BE0", VA = "0x185723FE0")]
	public bool NNGJEPEAKAG(GNCKEDBOKNE NBOLOLKCOEB, Guid NLFDMHEOLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57227E0", Offset = "0x57213E0", VA = "0x1857227E0")]
	public void MBCFIBLNDEG(GNCKEDBOKNE NBOLOLKCOEB, Guid NLFDMHEOLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5720D70", Offset = "0x571F970", VA = "0x185720D70")]
	private void ABFFHEJEBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5723B40", Offset = "0x5722740", VA = "0x185723B40")]
	internal (GNCKEDBOKNE, Guid[]) NIDNDBMPEPD(bool OFMCPAHDEDB = false)
	{
		return default((GNCKEDBOKNE, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x57215B0", Offset = "0x57201B0", VA = "0x1857215B0")]
	private HashSet<Guid> ELJMJIFKMDM(GNCKEDBOKNE NBOLOLKCOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5721D80", Offset = "0x5720980", VA = "0x185721D80")]
	private void HJLAMHFIOHO(GNCKEDBOKNE NBOLOLKCOEB, Guid PHGKKLLIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5722150", Offset = "0x5720D50", VA = "0x185722150")]
	private void IMEABGLNKJJ(GNCKEDBOKNE NBOLOLKCOEB, Guid PHGKKLLIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5720D80", Offset = "0x571F980", VA = "0x185720D80")]
	public static Func<Guid, bool> ADCBKBPMFEA(Guid PHGKKLLIIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5721520", Offset = "0x5720120", VA = "0x185721520")]
	public static Func<Guid, bool> EEPANJBELKG(Guid PHGKKLLIIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5720E10", Offset = "0x571FA10", VA = "0x185720E10")]
	public void AHLBNFNPFDH(GNCKEDBOKNE NBOLOLKCOEB, Guid EGEEADFIFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5723300", Offset = "0x5721F00", VA = "0x185723300")]
	public void NCKKNPCKNEF(GNCKEDBOKNE NBOLOLKCOEB, Func<Guid, bool> BLKNHMPBBBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DJJAMNDKGBA : GHCPFEMJJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(GNFLMMFACPF.FJHGDKAELDN itemType, long totalStopwatchTicks)> EOEMNNIEMHH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(GNFLMMFACPF.FJHGDKAELDN itemType, long totalStopwatchTicks)> INIEEMNPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x637140", Offset = "0x635D40", VA = "0x180637140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5725E00", Offset = "0x5724A00", VA = "0x185725E00")]
	public DJJAMNDKGBA(TimeSpan CFAFKOMKLHB, List<(GNFLMMFACPF.FJHGDKAELDN itemType, long totalStopwatchTicks)> EOEMNNIEMHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MECKPIDBODB : EJKDPMPCEKB
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct JFFOBGAOBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid JDNHOCKLECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int FFPBGDIIDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int MODCIBCEIIH;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5727A10", Offset = "0x5726610", VA = "0x185727A10")]
		public JFFOBGAOBML(Guid DNNNGGMCKLO, int FDGGMJLNAOP, int INGPIIJINHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5727760", Offset = "0x5726360", VA = "0x185727760")]
		public static byte[] EKJBCLFLGLG(JFFOBGAOBML EHGGIAFACBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5727960", Offset = "0x5726560", VA = "0x185727960")]
		public static JFFOBGAOBML OPELNPIHKCP(byte[] DNJADMBKFKK)
		{
			return default(JFFOBGAOBML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5727830", Offset = "0x5726430", VA = "0x185727830")]
		private static byte[] JCNCLMKCHLB(int ACJHPBCLINB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x57278B0", Offset = "0x57264B0", VA = "0x1857278B0")]
		private static int MLMEEAIOOIC(byte[] EAANELKLKGA, int BAOHKIGDOBF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid DNNNGGMCKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly AGEOHAGKELJ GFCHEAJBPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool LIJNGMKMKHD;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5729A70", Offset = "0x5728670", VA = "0x185729A70")]
	public MECKPIDBODB(Guid DNNNGGMCKLO, AGEOHAGKELJ GFCHEAJBPCF, GFCNFCIHGIM DDMKKFCKMAO, CancellationToken EAMPAKHINCA, [Optional] PKHCDOOPDJF MJHMFDBIHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5729760", Offset = "0x5728360", VA = "0x185729760", Slot = "5")]
	protected override void KNKLDFODADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x57298E0", Offset = "0x57284E0", VA = "0x1857298E0", Slot = "6")]
	protected override void LMODEGANOKF(int BMMNBENJMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5729580", Offset = "0x5728180", VA = "0x185729580")]
	private void BNBOGCDGINH(DGMFAOJAOCJ OOHAAHIPCLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DGMFAOJAOCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte PDGFPBIFBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte MLIOCKLPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool ENBFCAIAAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly AGEOHAGKELJ.GNCKEDBOKNE LMINMFNMBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] AIBONKBCAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] HJLEFMOIJNP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5725DA0", Offset = "0x57249A0", VA = "0x185725DA0")]
	public DGMFAOJAOCJ(AGEOHAGKELJ.GNCKEDBOKNE NBOLOLKCOEB, [NotNull] Guid[] ADKLFMIPAHC, byte[] IBEPFEBNHGC, bool OLPKJEBAABC, byte KDPHCCPAMKI, byte NBGGMPCGKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5725930", Offset = "0x5724530", VA = "0x185725930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5725790", Offset = "0x5724390", VA = "0x185725790")]
	private static void NMBIBLGIFDD(byte[] IBEPFEBNHGC, StringBuilder HEDCPOGLKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class GKLHOAOCFAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33A7B60", Offset = "0x33A6760", VA = "0x1833A7B60", Slot = "4")]
	public void GHKDKBJOEHM(T EHGGIAFACBG, IDictionary<object, object> CEECNJJKNFO, bool KDGHGPFOPNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IPKLPJMGHIG(T EHGGIAFACBG, IDictionary<object, object> CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T OPELNPIHKCP(IDictionary<object, object> CEECNJJKNFO);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x33A7CB0", Offset = "0x33A68B0", VA = "0x1833A7CB0", Slot = "7")]
	public bool JFLMAAJEMIL(IDictionary<object, object> CEECNJJKNFO, out T BJGNNAIMCEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected GKLHOAOCFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EJKDPMPCEKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool PKHCDOOPDJF(int LPIJOILBMLA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool ONBALJNPLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly GFCNFCIHGIM CFIKEAHDOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken EAMPAKHINCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken NJCILLMAKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly PKHCDOOPDJF MJHMFDBIHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource HOHOKPDOIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource EBNJMKIEEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int OIFNCHPHEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool PHNMEHCCACI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken LLMIJODKEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57261D0", Offset = "0x5724DD0", VA = "0x1857261D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KKKPDHOMPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5726020", Offset = "0x5724C20", VA = "0x185726020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x57261F0", Offset = "0x5724DF0", VA = "0x1857261F0")]
	public EJKDPMPCEKB(GFCNFCIHGIM DDMKKFCKMAO, CancellationToken EAMPAKHINCA, [Optional] PKHCDOOPDJF MJHMFDBIHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5725FA0", Offset = "0x5724BA0", VA = "0x185725FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5726070", Offset = "0x5724C70", VA = "0x185726070", Slot = "5")]
	protected virtual void KNKLDFODADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5726140", Offset = "0x5724D40", VA = "0x185726140")]
	private void PBDFFFGGBIE(BHINAGHJPMD PNFBGOKLIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5725FC0", Offset = "0x5724BC0", VA = "0x185725FC0")]
	protected void FJFDBCIPELI(int BMMNBENJMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5726120", Offset = "0x5724D20", VA = "0x185726120", Slot = "6")]
	protected virtual void LMODEGANOKF(int BMMNBENJMFN)
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
