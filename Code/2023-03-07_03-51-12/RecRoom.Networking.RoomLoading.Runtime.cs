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
internal class MPIMDGOFMGJ : global::MJAAMBAMMHJ<IGCPMELOMFK>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KHNONMKBDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KHNONMKBDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6284890", Offset = "0x6283C90", VA = "0x186284890")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] JGFKCBJFOFN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly MPIMDGOFMGJ KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62861D0", Offset = "0x62855D0", VA = "0x1862861D0", Slot = "5")]
	protected override void FPNGEILNMNJ(IGCPMELOMFK CIBBLLOHCGM, IDictionary<object, object> MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6285660", Offset = "0x6284A60", VA = "0x186285660", Slot = "6")]
	public override IGCPMELOMFK AHLFMBEKFNG(IDictionary<object, object> MPEBBGJJODN)
	{
		return default(IGCPMELOMFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6286860", Offset = "0x6285C60", VA = "0x186286860")]
	public MPIMDGOFMGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CPHIJNHNMFK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string NOFCPFMCHGL([NotNull] byte[] OCMDFIDHJDH);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct OJFBNEMFIIJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly PNFLFPEFCIN MNPMACNAAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool IFIODKGIIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T KIJNDIPNDMA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2CC8FE0", Offset = "0x2CC83E0", VA = "0x182CC8FE0")]
		public static OJFBNEMFIIJ<T> NCINHKPBPPK(IGCPMELOMFK GANCAJLOMAO, Func<byte[], T> FEPLHMEOEFB)
		{
			return default(OJFBNEMFIIJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9290", Offset = "0x2CC8690", VA = "0x182CC9290")]
		public OJFBNEMFIIJ(PNFLFPEFCIN DOGCECFAEPJ, T OCMDFIDHJDH, bool LMDLHJFMGPA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2CC90F0", Offset = "0x2CC84F0", VA = "0x182CC90F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DNJFEGJJBLI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FNDPCCIJLPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<IGCPMELOMFK> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DNJFEGJJBLI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public FNDPCCIJLPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62830F0", Offset = "0x62824F0", VA = "0x1862830F0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6283140", Offset = "0x6282540", VA = "0x186283140")]
			internal OLGHPDKGBAC <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LOHCJGNPHNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public CCDJNMKLABL.JGJAJIMHAPO itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public LOHCJGNPHNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6285420", Offset = "0x6284820", VA = "0x186285420")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct NAALPCNBKGJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<IGCPMELOMFK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DNJFEGJJBLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private FNDPCCIJLPM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<IGCPMELOMFK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x62868A0", Offset = "0x6285CA0", VA = "0x1862868A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x62870B0", Offset = "0x62864B0", VA = "0x1862870B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DHDEGALOGEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public GKHGJLPDPEH sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public DHDEGALOGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6282270", Offset = "0x6281670", VA = "0x186282270")]
			internal bool <ClearSlice>b__0(IGCPMELOMFK bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EIPBLKPHMFE NLHODMDHHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string AJHLOAGEOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<IGCPMELOMFK> APNPBCPOEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(CCDJNMKLABL.JGJAJIMHAPO itemType, long totalStopwatchTicks)> LFCCLDGGOFD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool INIFKHGCOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6282800", Offset = "0x6281C00", VA = "0x186282800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<IGCPMELOMFK> HDBIHKLAIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62823E0", Offset = "0x62817E0", VA = "0x1862823E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6282850", Offset = "0x6281C50", VA = "0x186282850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62828F0", Offset = "0x6281CF0", VA = "0x1862828F0")]
		public DNJFEGJJBLI(EIPBLKPHMFE NLHODMDHHDP, string AJHLOAGEOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62826B0", Offset = "0x6281AB0", VA = "0x1862826B0")]
		[AsyncStateMachine(typeof(NAALPCNBKGJ))]
		public Task<IGCPMELOMFK> HHANGFDLKIL(CancellationToken MJMCKAGGCOI, TimeSpan OHFDFDCBAGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6282600", Offset = "0x6281A00", VA = "0x186282600")]
		public void HFBMNILHOKG(IGCPMELOMFK CIBBLLOHCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6282480", Offset = "0x6281880", VA = "0x186282480", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62824D0", Offset = "0x62818D0", VA = "0x1862824D0")]
		public void HADGFDJBFAE(GKHGJLPDPEH BODNAAGCOFL, Guid BJKMNBIBKCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMKJFMBKDKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<IGCPMELOMFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NCNPBEKEBJI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6284950", Offset = "0x6283D50", VA = "0x186284950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6285290", Offset = "0x6284690", VA = "0x186285290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct INFKCHPCPAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NCNPBEKEBJI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<OJFBNEMFIIJ<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6283A90", Offset = "0x6282E90", VA = "0x186283A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6283E40", Offset = "0x6283240", VA = "0x186283E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DEKMHANGOLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<IGCPMELOMFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NCNPBEKEBJI pauseAfterListeningToken;

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
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6281600", Offset = "0x6280A00", VA = "0x186281600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6281F00", Offset = "0x6281300", VA = "0x186281F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MHKBKDOGFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MHKBKDOGFPG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BKOFJKDBJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<IGCPMELOMFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private MHKBKDOGFPG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NCNPBEKEBJI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DCEMEGMIAKN <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x627B950", Offset = "0x627AD50", VA = "0x18627B950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x627C420", Offset = "0x627B820", VA = "0x18627C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ELKHNBPHDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<IGCPMELOMFK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NCNPBEKEBJI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<IGCPMELOMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6282A80", Offset = "0x6281E80", VA = "0x186282A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6282E60", Offset = "0x6282260", VA = "0x186282E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LBLBPHKEADE
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
			public LBLBPHKEADE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6288200", Offset = "0x6287600", VA = "0x186288200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6288370", Offset = "0x6287770", VA = "0x186288370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LBLBPHKEADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62852E0", Offset = "0x62846E0", VA = "0x1862852E0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FBLFPEDEMAH : IAsyncStateMachine
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
		public CPHIJNHNMFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NCNPBEKEBJI unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NCNPBEKEBJI pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6282EB0", Offset = "0x62822B0", VA = "0x186282EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class NLOPCLCJOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public NLOPCLCJOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6287150", Offset = "0x6286550", VA = "0x186287150")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6287100", Offset = "0x6286500", VA = "0x186287100")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HOBNEJBOAIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GKHGJLPDPEH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HOBNEJBOAIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6283600", Offset = "0x6282A00", VA = "0x186283600")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JLEKLPGMEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GKHGJLPDPEH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JLEKLPGMEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62846E0", Offset = "0x6283AE0", VA = "0x1862846E0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HHHDMPGNGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HHHDMPGNGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62834D0", Offset = "0x62828D0", VA = "0x1862834D0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JPEBDFMPGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JPEBDFMPGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6284780", Offset = "0x6283B80", VA = "0x186284780")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ALHMNPBHABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ALHMNPBHABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x627B770", Offset = "0x627AB70", VA = "0x18627B770")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EKELMOCKCFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EKELMOCKCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62829F0", Offset = "0x6281DF0", VA = "0x1862829F0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HMKANEPJHCD
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
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HMKANEPJHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62835A0", Offset = "0x62829A0", VA = "0x1862835A0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6283540", Offset = "0x6282940", VA = "0x186283540")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KGAHCDALHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KGAHCDALHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62847F0", Offset = "0x6283BF0", VA = "0x1862847F0")]
		internal bool <ClearSliceIds>b__3(ANBCPEIAKFI stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JHHGFHNNMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JHHGFHNNMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62841E0", Offset = "0x62835E0", VA = "0x1862841E0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6284460", Offset = "0x6283860", VA = "0x186284460")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6284170", Offset = "0x6283570", VA = "0x186284170")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly NOFCPFMCHGL HLPDLOGGJGL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable PNBBMKDMDKE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IMLIINHNGKM HFONEINFODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DNJFEGJJBLI HLMBLKIFPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EIPBLKPHMFE NLHODMDHHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BLHFANMACHC HAGOOFMPPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HIPAPOMCLID KBHDCDKOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NOFCPFMCHGL DAAFGDCLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MDPNAAPBFCF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan LLPDEJKCCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan IDGBNBDMINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte BOAIFABNCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] PNLNHAELNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<ANBCPEIAKFI> GBAPIHDLIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PNFLFPEFCIN? FIFEFDOGIAM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly IMLIINHNGKM FFOCLMDGBEK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IMLIINHNGKM BEJNNPIEIOO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<IGCPMELOMFK> EHOPIDLAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627E8B0", Offset = "0x627DCB0", VA = "0x18627E8B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6280080", Offset = "0x627F480", VA = "0x186280080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6280D20", Offset = "0x6280120", VA = "0x186280D20")]
	public CPHIJNHNMFK(EIPBLKPHMFE NLHODMDHHDP, BLHFANMACHC HAGOOFMPPKL, HIPAPOMCLID KBHDCDKOLNE, [Optional] TimeSpan? BLHJFFFLAPF, [Optional] NOFCPFMCHGL EEAMILKBMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA48C0", Offset = "0x2CA3CC0", VA = "0x182CA48C0")]
	public static CPHIJNHNMFK NNMIIGJGCIC<TNetworking>(TNetworking CMHEIEGMDHP, [Optional] TimeSpan? BLHJFFFLAPF, [Optional] NOFCPFMCHGL EEAMILKBMDA) where TNetworking : EIPBLKPHMFE, BLHFANMACHC, HIPAPOMCLID
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x627E7C0", Offset = "0x627DBC0", VA = "0x18627E7C0")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x627E050", Offset = "0x627D450", VA = "0x18627E050")]
	private byte FGIHDHGIEGA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x627F060", Offset = "0x627E460", VA = "0x18627F060")]
	private TimeSpan KHBPINCBIMP(TimeSpan? BLHJFFFLAPF, int EDEFHKLHKJE = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3B90", Offset = "0x2CA2F90", VA = "0x182CA3B90")]
	public bool CGEFMEOHGIN<T>(T IKCBKOBINEP, Func<T, byte[]> JJCCPFKLFDH, bool LMDLHJFMGPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x627D0C0", Offset = "0x627C4C0", VA = "0x18627D0C0")]
	public bool CGEFMEOHGIN(byte[] IKCBKOBINEP, int EHDMNODNJHF, bool LMDLHJFMGPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	private static string AIMOIGEGAEN(string CIBBLLOHCGM, string EELAMBEFNPK = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x627E210", Offset = "0x627D610", VA = "0x18627E210")]
	[AsyncStateMachine(typeof(KMKJFMBKDKB))]
	public Task<IGCPMELOMFK> GEKFJINAHEF(CancellationToken MJMCKAGGCOI, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, [Optional] TimeSpan? BLHJFFFLAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x627EED0", Offset = "0x627E2D0", VA = "0x18627EED0")]
	[AsyncStateMachine(typeof(INFKCHPCPAK))]
	public Task<Guid> JKHANFOCMPG(Guid NJBFFOAIFFD, CancellationToken MJMCKAGGCOI, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, [Optional] TimeSpan? OHFDFDCBAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CA40F0", Offset = "0x2CA34F0", VA = "0x182CA40F0")]
	[AsyncStateMachine(typeof(DMDKNAOJFAL))]
	public Task<OJFBNEMFIIJ<T>> GIJHGOHOJGA<T>(T IKCBKOBINEP, Func<T, byte[]> JJCCPFKLFDH, Func<byte[], T> FEPLHMEOEFB, CancellationToken MJMCKAGGCOI, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, [Optional] TimeSpan? OHFDFDCBAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x627E390", Offset = "0x627D790", VA = "0x18627E390")]
	[AsyncStateMachine(typeof(DEKMHANGOLK))]
	public Task<IGCPMELOMFK> GIJHGOHOJGA(byte[] IKCBKOBINEP, CancellationToken MJMCKAGGCOI, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, [Optional] TimeSpan? OHFDFDCBAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x627E060", Offset = "0x627D460", VA = "0x18627E060")]
	[AsyncStateMachine(typeof(BKOFJKDBJCK))]
	private Task<IGCPMELOMFK> GCJEAJOKLEG(byte[] IKCBKOBINEP, CancellationToken MJMCKAGGCOI, NCNPBEKEBJI FMMODEGHJIC, NCNPBEKEBJI HLFEOCAHFOD, TimeSpan? BLHJFFFLAPF, Stopwatch EBCOGJGDOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x627E630", Offset = "0x627DA30", VA = "0x18627E630")]
	[AsyncStateMachine(typeof(ELKHNBPHDMM))]
	private Task<IGCPMELOMFK> HNDHLKIPLHK(byte[] IKCBKOBINEP, CancellationToken MJMCKAGGCOI, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, [Optional] TimeSpan? OHFDFDCBAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x627D6C0", Offset = "0x627CAC0", VA = "0x18627D6C0")]
	[AsyncStateMachine(typeof(FBLFPEDEMAH))]
	public Task CPCBAOBMMJN(CancellationToken JFEIMHDODID, Func<CancellationToken, Task> KKPPAOENEHN, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, int GJKFNHPEBKP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3C40", Offset = "0x2CA3040", VA = "0x182CA3C40")]
	[AsyncStateMachine(typeof(HJPEPIPDKAA))]
	public Task<T> CPCBAOBMMJN<T>(CancellationToken JFEIMHDODID, Func<CancellationToken, Task<T>> KKPPAOENEHN, [Optional] NCNPBEKEBJI FMMODEGHJIC, [Optional] NCNPBEKEBJI HLFEOCAHFOD, int GJKFNHPEBKP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4470", Offset = "0x2CA3870", VA = "0x182CA4470")]
	[AsyncStateMachine(typeof(HFNAHFMDGLG))]
	private Task<(bool, T)> HEJNNJDGCHD<T>(Guid MCEDDCCLFGN, CancellationToken JFEIMHDODID, Func<CancellationToken, Task<T>> KKPPAOENEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6280130", Offset = "0x627F530", VA = "0x186280130")]
	public void PECPLOKOAJC(byte KOIFIHCACIP, int ICEJCNKCKBG, object KGMOGBBCAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x627CA60", Offset = "0x627BE60", VA = "0x18627CA60")]
	public Guid AGDIACALNDJ(Guid CIMPJAMIENF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x627E950", Offset = "0x627DD50", VA = "0x18627E950")]
	public bool JAEMPDEDPIG(GKHGJLPDPEH BODNAAGCOFL, Guid MCEDDCCLFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x627CCC0", Offset = "0x627C0C0", VA = "0x18627CCC0")]
	public void AOGHDBMMGGK(GKHGJLPDPEH BODNAAGCOFL, Guid MCEDDCCLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6280120", Offset = "0x627F520", VA = "0x186280120")]
	private void OKDJOEHIILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x627F2A0", Offset = "0x627E6A0", VA = "0x18627F2A0")]
	internal PNFLFPEFCIN LHLFACCGOAI(bool GJBDEGJLFGI = false)
	{
		return default(PNFLFPEFCIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x627FF40", Offset = "0x627F340", VA = "0x18627FF40")]
	private HashSet<Guid> NNBAMBNOIBE(GKHGJLPDPEH BODNAAGCOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x627DE80", Offset = "0x627D280", VA = "0x18627DE80")]
	private void FGHDFFLOIAF(GKHGJLPDPEH BODNAAGCOFL, Guid BJKMNBIBKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x627F3B0", Offset = "0x627E7B0", VA = "0x18627F3B0")]
	private void LOBIECBGCID(GKHGJLPDPEH BODNAAGCOFL, Guid BJKMNBIBKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x627F690", Offset = "0x627EA90", VA = "0x18627F690")]
	public static Func<Guid, bool> MCHOBNPBPCG(Guid BJKMNBIBKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x627F740", Offset = "0x627EB40", VA = "0x18627F740")]
	public static Func<Guid, bool> MDDGLACACKL(Guid BJKMNBIBKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x627E520", Offset = "0x627D920", VA = "0x18627E520")]
	public void HADGFDJBFAE(GKHGJLPDPEH BODNAAGCOFL, Guid MGGCBNJHBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x627D950", Offset = "0x627CD50", VA = "0x18627D950")]
	public void FBNFLFJOFEH(GKHGJLPDPEH BODNAAGCOFL, Func<Guid, bool> CDAKMANHJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x627D830", Offset = "0x627CC30", VA = "0x18627D830")]
	private static ExitGames.Client.Photon.Hashtable CPDABLFEIJM(GKHGJLPDPEH BODNAAGCOFL, Guid CFMAPOFCFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x627F7F0", Offset = "0x627EBF0", VA = "0x18627F7F0")]
	private void MNOPCFDMDFK(GKHGJLPDPEH BODNAAGCOFL, Guid CFMAPOFCFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OLGHPDKGBAC : BNHGCMFEGEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(CCDJNMKLABL.JGJAJIMHAPO itemType, long totalStopwatchTicks)> OABIFANBIJP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(CCDJNMKLABL.JGJAJIMHAPO itemType, long totalStopwatchTicks)> JDNCKOEBEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x884180", Offset = "0x883580", VA = "0x180884180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6287270", Offset = "0x6286670", VA = "0x186287270")]
	public OLGHPDKGBAC(TimeSpan OHFDFDCBAGK, List<(CCDJNMKLABL.JGJAJIMHAPO itemType, long totalStopwatchTicks)> OABIFANBIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class COFGOJEKOIM : DCEMEGMIAKN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct INKJBAPPAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid NNNDNDHOMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int OLHGDIHPJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int FFKGENHAJBH;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6284160", Offset = "0x6283560", VA = "0x186284160")]
		public INKJBAPPAMP(Guid EHFKDFGOFNC, int JHOCGKKDBMD, int ILHPFPDDNNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6283F50", Offset = "0x6283350", VA = "0x186283F50")]
		public static byte[] DGECGJPLFOM(INKJBAPPAMP CIBBLLOHCGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6283E90", Offset = "0x6283290", VA = "0x186283E90")]
		public static INKJBAPPAMP AHLFMBEKFNG(byte[] GJDBLJLIDDI)
		{
			return default(INKJBAPPAMP);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6284030", Offset = "0x6283430", VA = "0x186284030")]
		private static byte[] HFIENOIMAPK(int MDFMPEMHONH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62840B0", Offset = "0x62834B0", VA = "0x1862840B0")]
		private static int POMGIDBFLGO(byte[] JHCFBNEILOJ, int GABJOMFFJAI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid EHFKDFGOFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CPHIJNHNMFK ALCDJKDIIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool CNDNJOEANGO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x627CA00", Offset = "0x627BE00", VA = "0x18627CA00")]
	public COFGOJEKOIM(Guid EHFKDFGOFNC, CPHIJNHNMFK ALCDJKDIIMG, HIPAPOMCLID CMHEIEGMDHP, CancellationToken JFEIMHDODID, [Optional] OHHKDILFOHB MBFHFAMJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x627C470", Offset = "0x627B870", VA = "0x18627C470", Slot = "5")]
	protected override void EEGDFFDFEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x627C860", Offset = "0x627BC60", VA = "0x18627C860", Slot = "6")]
	protected override void KOOAPHIAFOI(int GHNKPMAKKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x627C640", Offset = "0x627BA40", VA = "0x18627C640")]
	private void EHOPIDLAKAL(IGCPMELOMFK CDNMGCHJCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct IGCPMELOMFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly PNFLFPEFCIN MNPMACNAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte OHKOGDCBGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte HGPKAHOELGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool IFIODKGIIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] KIJNDIPNDMA;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6283A30", Offset = "0x6282E30", VA = "0x186283A30")]
	public IGCPMELOMFK(PNFLFPEFCIN DOGCECFAEPJ, [CanBeNull] byte[] OCMDFIDHJDH, bool LMDLHJFMGPA, byte AOEFFIOKODH, byte GMAJNDCNPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6283890", Offset = "0x6282C90", VA = "0x186283890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62836A0", Offset = "0x6282AA0", VA = "0x1862836A0")]
	private static void NKEHHNAADBF(byte[] OCMDFIDHJDH, StringBuilder LKPFCMFGBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct PNFLFPEFCIN
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DGOPPDBJPOG : IEnumerable<ANBCPEIAKFI>, IEnumerable, IEnumerator<ANBCPEIAKFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private ANBCPEIAKFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public PNFLFPEFCIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public PNFLFPEFCIN <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GKHGJLPDPEH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ANBCPEIAKFI System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3970EE0", Offset = "0x39702E0", VA = "0x183970EE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ANBCPEIAKFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6282220", Offset = "0x6281620", VA = "0x186282220", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x829280", Offset = "0x828680", VA = "0x180829280")]
		[DebuggerHidden]
		public DGOPPDBJPOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6281F50", Offset = "0x6281350", VA = "0x186281F50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62821E0", Offset = "0x62815E0", VA = "0x1862821E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6282140", Offset = "0x6281540", VA = "0x186282140", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ANBCPEIAKFI> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6282140", Offset = "0x6281540", VA = "0x186282140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly GKHGJLPDPEH NGAHBBKFNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] MIDDEBHBCNE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6287CC0", Offset = "0x62870C0", VA = "0x186287CC0")]
	public static PNFLFPEFCIN JALGCHHBFDJ(GKHGJLPDPEH BODNAAGCOFL, Guid AKPGCMFKHGA)
	{
		return default(PNFLFPEFCIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6287440", Offset = "0x6286840", VA = "0x186287440")]
	public static PNFLFPEFCIN BKEAFHNMDKJ(List<ANBCPEIAKFI> LMFIIDDNCMM)
	{
		return default(PNFLFPEFCIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6287860", Offset = "0x6286C60", VA = "0x186287860")]
	public static PNFLFPEFCIN EECJNIFMILE(GKHGJLPDPEH CPCDILCHAGK, Guid[] APENEJEIEDA)
	{
		return default(PNFLFPEFCIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6287FC0", Offset = "0x62873C0", VA = "0x186287FC0")]
	private PNFLFPEFCIN(GKHGJLPDPEH CPCDILCHAGK, Guid[] APENEJEIEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6287DC0", Offset = "0x62871C0", VA = "0x186287DC0")]
	[IteratorStateMachine(typeof(DGOPPDBJPOG))]
	public IEnumerable<ANBCPEIAKFI> KGBCOPLBNGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6287E40", Offset = "0x6287240", VA = "0x186287E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class MJAAMBAMMHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38101A0", Offset = "0x380F5A0", VA = "0x1838101A0", Slot = "4")]
	public void COBEEKMMBJI(T CIBBLLOHCGM, IDictionary<object, object> MPEBBGJJODN, bool BHGBMFHLCPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FPNGEILNMNJ(T CIBBLLOHCGM, IDictionary<object, object> MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T AHLFMBEKFNG(IDictionary<object, object> MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected MJAAMBAMMHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DCEMEGMIAKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool OHHKDILFOHB(int HBEKGPIEIAO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly HIPAPOMCLID FCOJJOEHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken JFEIMHDODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken HGFLBMFBDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly OHHKDILFOHB MBFHFAMJOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource MJMGOLKMNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource NDBMODCALJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int HOKCLPOGFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HGPCLPDPGGM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken NNDLAMFLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62813C0", Offset = "0x62807C0", VA = "0x1862813C0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BMECDOFMHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62813E0", Offset = "0x62807E0", VA = "0x1862813E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6281450", Offset = "0x6280850", VA = "0x186281450")]
	public DCEMEGMIAKN(HIPAPOMCLID CMHEIEGMDHP, CancellationToken JFEIMHDODID, [Optional] OHHKDILFOHB MBFHFAMJOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6281230", Offset = "0x6280630", VA = "0x186281230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6281250", Offset = "0x6280650", VA = "0x186281250", Slot = "5")]
	protected virtual void EEGDFFDFEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6281320", Offset = "0x6280720", VA = "0x186281320")]
	private void GHCPIMCKJIE(JEHHKLECEGB PIDNOAALGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62811D0", Offset = "0x62805D0", VA = "0x1862811D0")]
	protected void CEEIFDIDJOF(int GHNKPMAKKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6281430", Offset = "0x6280830", VA = "0x186281430", Slot = "6")]
	protected virtual void KOOAPHIAFOI(int GHNKPMAKKPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct ANBCPEIAKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly GKHGJLPDPEH BMKBEANBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid IEJLLLBIIGJ;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B451A0", Offset = "0x2B445A0", VA = "0x182B451A0")]
	public ANBCPEIAKFI(GKHGJLPDPEH BODNAAGCOFL, Guid MCEDDCCLFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x627B8F0", Offset = "0x627ACF0", VA = "0x18627B8F0")]
	public bool LNPLILOIFFP(ANBCPEIAKFI FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x627B800", Offset = "0x627AC00", VA = "0x18627B800", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x627B8C0", Offset = "0x627ACC0", VA = "0x18627B8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum GKHGJLPDPEH : byte
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
internal static class PDCPMGBMPHL
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly GKHGJLPDPEH[] FKDGPGAANJI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62872F0", Offset = "0x62866F0", VA = "0x1862872F0")]
	public static int CCJKHIPOHDE(GKHGJLPDPEH BODNAAGCOFL)
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
