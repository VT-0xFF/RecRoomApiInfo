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
internal class IKHGKEAGOMF : global::BKLFIDPCHLG<PGIFKEEINMC>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class JEEJOODFOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JEEJOODFOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5771DE0", Offset = "0x57709E0", VA = "0x185771DE0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] PMDIHKEKIDP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IKHGKEAGOMF DBFNMCLAAPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5771700", Offset = "0x5770300", VA = "0x185771700", Slot = "5")]
	protected override void MCPHAJCNOJE(PGIFKEEINMC CIJKLAFFGJI, IDictionary<object, object> OAGMKJFIKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5770E20", Offset = "0x576FA20", VA = "0x185770E20", Slot = "6")]
	public override PGIFKEEINMC EFBLDOLKNNC(IDictionary<object, object> OAGMKJFIKKL)
	{
		return default(PGIFKEEINMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5771CE0", Offset = "0x57708E0", VA = "0x185771CE0")]
	public IKHGKEAGOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PGOAKEJNCDN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string ILLAIKKBHHI([NotNull] byte[] LEPAGINGHFK);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum CMOGODNJFPC : byte
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
	private readonly struct HFELKMJNMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly CMOGODNJFPC DDIPLAONJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid KMFOHNIEBEK;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4728DB0", Offset = "0x47279B0", VA = "0x184728DB0")]
		public HFELKMJNMJC(CMOGODNJFPC BPNJDCHPGMM, Guid MIJJBKFBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5770840", Offset = "0x576F440", VA = "0x185770840")]
		public bool GLBPEIKDFCD(HFELKMJNMJC NPKIIGGBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5770780", Offset = "0x576F380", VA = "0x185770780", Slot = "0")]
		public override bool Equals(object EBMPLNBFAKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x57708A0", Offset = "0x576F4A0", VA = "0x1857708A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KKACAIKDAEL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool JGDDIEJLFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly CMOGODNJFPC DDIPLAONJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] JOKCNCLJKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T IGKCAPDIALJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A15780", Offset = "0x3A14380", VA = "0x183A15780")]
		public static KKACAIKDAEL<T> EABNFJFGGEE(PGIFKEEINMC DPGPCCOPFCI, Func<byte[], T> GBFLEMMNMAI)
		{
			return default(KKACAIKDAEL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A15A00", Offset = "0x3A14600", VA = "0x183A15A00")]
		public KKACAIKDAEL(CMOGODNJFPC BPNJDCHPGMM, Guid[] FCEFFDPGLAM, T LEPAGINGHFK, bool MLHDJLLLJEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A15930", Offset = "0x3A14530", VA = "0x183A15930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class OLAKJMPCANL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EHEJHHFENHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<PGIFKEEINMC> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public OLAKJMPCANL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public EHEJHHFENHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x576F930", Offset = "0x576E530", VA = "0x18576F930")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x576F980", Offset = "0x576E580", VA = "0x18576F980")]
			internal CNOJMLEBPKG <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OABHJDPEBLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public EDEJDAJBION.LBNGOALDHKP itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public OABHJDPEBLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x57730F0", Offset = "0x5771CF0", VA = "0x1857730F0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct LAHEMEJKMKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<PGIFKEEINMC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public OLAKJMPCANL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private EHEJHHFENHE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<PGIFKEEINMC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5771E80", Offset = "0x5770A80", VA = "0x185771E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5772530", Offset = "0x5771130", VA = "0x185772530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IBAMKKJKOOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public CMOGODNJFPC sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public IBAMKKJKOOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x57708D0", Offset = "0x576F4D0", VA = "0x1857708D0")]
			internal bool <ClearSlice>b__0(PGIFKEEINMC bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly NILOMKPGNEC MFKBPBJKBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string BOLHFMEHOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<PGIFKEEINMC> JBOCEGBCFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(EDEJDAJBION.LBNGOALDHKP itemType, long totalStopwatchTicks)> PLJOJFMMMOI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CJOBMOAFMDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x57737F0", Offset = "0x57723F0", VA = "0x1857737F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PGIFKEEINMC> LDOOJBLDMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x57736A0", Offset = "0x57722A0", VA = "0x1857736A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5773600", Offset = "0x5772200", VA = "0x185773600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5773830", Offset = "0x5772430", VA = "0x185773830")]
		public OLAKJMPCANL(NILOMKPGNEC MFKBPBJKBHP, string BOLHFMEHOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5773380", Offset = "0x5771F80", VA = "0x185773380")]
		[AsyncStateMachine(typeof(LAHEMEJKMKG))]
		public Task<PGIFKEEINMC> AJIMFHOFDPL(CancellationToken DHCIMDILIGO, TimeSpan JFIGOGADDHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5773740", Offset = "0x5772340", VA = "0x185773740")]
		public void IJBNIBBFDPO(PGIFKEEINMC CIJKLAFFGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x57735B0", Offset = "0x57721B0", VA = "0x1857735B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x57734C0", Offset = "0x57720C0", VA = "0x1857734C0")]
		public void DALOEIONNAO(CMOGODNJFPC BPNJDCHPGMM, Guid DJHPMDEHJMK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PPJAAKGHIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<PGIFKEEINMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BNJCICCOPAC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5777E90", Offset = "0x5776A90", VA = "0x185777E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5778670", Offset = "0x5777270", VA = "0x185778670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EMILFMKBGMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BNJCICCOPAC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<KKACAIKDAEL<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x576FCA0", Offset = "0x576E8A0", VA = "0x18576FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x576FFC0", Offset = "0x576EBC0", VA = "0x18576FFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BJEDCCHHEGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<PGIFKEEINMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public BNJCICCOPAC pauseAfterListeningToken;

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
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x576F040", Offset = "0x576DC40", VA = "0x18576F040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x576F790", Offset = "0x576E390", VA = "0x18576F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PPIKMABJHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PPIKMABJHAK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct APLBFFEKOIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<PGIFKEEINMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private PPIKMABJHAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BNJCICCOPAC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private LLILICEPJBC <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x576E780", Offset = "0x576D380", VA = "0x18576E780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x576EFF0", Offset = "0x576DBF0", VA = "0x18576EFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct FPIPEDHHLGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<PGIFKEEINMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BNJCICCOPAC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<PGIFKEEINMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5770010", Offset = "0x576EC10", VA = "0x185770010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5770340", Offset = "0x576EF40", VA = "0x185770340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IHAMOEJCFBJ
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
			public IHAMOEJCFBJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x57786C0", Offset = "0x57772C0", VA = "0x1857786C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5778820", Offset = "0x5777420", VA = "0x185778820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public IHAMOEJCFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5770D00", Offset = "0x576F900", VA = "0x185770D00")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OHMPPJEHIPB : IAsyncStateMachine
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
		public PGOAKEJNCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BNJCICCOPAC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public BNJCICCOPAC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x57731A0", Offset = "0x5771DA0", VA = "0x1857731A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GCIEBKCFDFN : IEnumerable<(CMOGODNJFPC, Guid)>, IEnumerable, IEnumerator<(CMOGODNJFPC, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (CMOGODNJFPC sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private CMOGODNJFPC sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CMOGODNJFPC <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CMOGODNJFPC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (CMOGODNJFPC, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1830", Offset = "0x2BC0430", VA = "0x182BC1830", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((CMOGODNJFPC, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x57706B0", Offset = "0x576F2B0", VA = "0x1857706B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA157D0", Offset = "0xA143D0", VA = "0x180A157D0")]
		[DebuggerHidden]
		public GCIEBKCFDFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5770390", Offset = "0x576EF90", VA = "0x185770390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5770660", Offset = "0x576F260", VA = "0x185770660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x57705B0", Offset = "0x576F1B0", VA = "0x1857705B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CMOGODNJFPC, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57705B0", Offset = "0x576F1B0", VA = "0x1857705B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DDJCOBAFPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DDJCOBAFPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x576F860", Offset = "0x576E460", VA = "0x18576F860")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x576F8A0", Offset = "0x576E4A0", VA = "0x18576F8A0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x576F8F0", Offset = "0x576E4F0", VA = "0x18576F8F0")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MDNEJCJELOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CMOGODNJFPC sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public MDNEJCJELOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5772A60", Offset = "0x5771660", VA = "0x185772A60")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GEIFJAKODKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CMOGODNJFPC sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GEIFJAKODKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5770700", Offset = "0x576F300", VA = "0x185770700")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class INDBPJBPPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public INDBPJBPPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5771D80", Offset = "0x5770980", VA = "0x185771D80")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ILNEKJMINMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ILNEKJMINMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5771D20", Offset = "0x5770920", VA = "0x185771D20")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NOBDDGJMCCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NOBDDGJMCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5773060", Offset = "0x5771C60", VA = "0x185773060")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LKFFHEOIEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LKFFHEOIEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5772600", Offset = "0x5771200", VA = "0x185772600")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PEOKPGOOJHC
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
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PEOKPGOOJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5773960", Offset = "0x5772560", VA = "0x185773960")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5773900", Offset = "0x5772500", VA = "0x185773900")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NFFBPALCPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NFFBPALCPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5772AE0", Offset = "0x57716E0", VA = "0x185772AE0")]
		internal bool <ClearSliceIds>b__3(HFELKMJNMJC stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5772BE0", Offset = "0x57717E0", VA = "0x185772BE0")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5772E20", Offset = "0x5771A20", VA = "0x185772E20")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5772B80", Offset = "0x5771780", VA = "0x185772B80")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly ILLAIKKBHHI DCHIOEGAEMH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable HBPGEALHKOF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JCOGOKFFNLN GLOAKKMGDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OLAKJMPCANL INMDFEFAAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NILOMKPGNEC MFKBPBJKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EELPMFGAGPC LOPCENEOHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KBMEIJJPDEK AHMIHBOMKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ILLAIKKBHHI HJKODNFHEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KNBPMOOFAFL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan BCOLLBACNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan BGENGGFGLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte FDPKFHFCAEO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly CMOGODNJFPC[] DKCIABAHODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] GPECAFEEOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<HFELKMJNMJC> DEJAJGKMAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (CMOGODNJFPC combinedSliceType, Guid[] sliceTypeIds)? KONMIKJENDO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<PGIFKEEINMC> PDOPAMNIJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5776B80", Offset = "0x5775780", VA = "0x185776B80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5776020", Offset = "0x5774C20", VA = "0x185776020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5777940", Offset = "0x5776540", VA = "0x185777940")]
	public PGOAKEJNCDN(NILOMKPGNEC MFKBPBJKBHP, EELPMFGAGPC LOPCENEOHIP, KBMEIJJPDEK AHMIHBOMKNE, [Optional] TimeSpan? CFALKDLEEJF, [Optional] ILLAIKKBHHI FOLEOBBOEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3138190", Offset = "0x3136D90", VA = "0x183138190")]
	public static PGOAKEJNCDN HGDJCAJGHAF<TNetworking>(TNetworking JCCFEHGPDHB, [Optional] TimeSpan? CFALKDLEEJF, [Optional] ILLAIKKBHHI FOLEOBBOEJN) where TNetworking : NILOMKPGNEC, EELPMFGAGPC, KBMEIJJPDEK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x57741B0", Offset = "0x5772DB0", VA = "0x1857741B0")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57759B0", Offset = "0x57745B0", VA = "0x1857759B0")]
	private byte GFOFOHCJFNK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57765F0", Offset = "0x57751F0", VA = "0x1857765F0")]
	private TimeSpan MHGPFKGLLLC(TimeSpan? CFALKDLEEJF, int CBGJEKELBLN = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27F3690", Offset = "0x27F2290", VA = "0x1827F3690")]
	public bool CHFGGDHNPMP<T>(T OGHAFEOOGNL, Func<T, byte[]> ODCFKLLJCFB, bool MLHDJLLLJEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57748D0", Offset = "0x57734D0", VA = "0x1857748D0")]
	public bool CHFGGDHNPMP(byte[] OGHAFEOOGNL, int IDDNIFCGGJJ, bool MLHDJLLLJEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F60", Offset = "0x6A0B60", VA = "0x1806A1F60")]
	private static string BOLMMMPHOOF(string CIJKLAFFGJI, string OKGJEMGBDBL = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x57757B0", Offset = "0x57743B0", VA = "0x1857757B0")]
	[AsyncStateMachine(typeof(PPJAAKGHIPO))]
	public Task<PGIFKEEINMC> EKEDOKHECII(CancellationToken DHCIMDILIGO, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, [Optional] TimeSpan? CFALKDLEEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5776C20", Offset = "0x5775820", VA = "0x185776C20")]
	[AsyncStateMachine(typeof(EMILFMKBGMB))]
	public Task<Guid> OENOELGGKMN(Guid PPLKGPEDBFN, CancellationToken DHCIMDILIGO, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, [Optional] TimeSpan? JFIGOGADDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF110", Offset = "0x1FADD10", VA = "0x181FAF110")]
	[AsyncStateMachine(typeof(NACMFEDJKCM))]
	public Task<KKACAIKDAEL<T>> LNFGJGOBBDC<T>(T OGHAFEOOGNL, Func<T, byte[]> ODCFKLLJCFB, Func<byte[], T> GBFLEMMNMAI, CancellationToken DHCIMDILIGO, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, [Optional] TimeSpan? JFIGOGADDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5776480", Offset = "0x5775080", VA = "0x185776480")]
	[AsyncStateMachine(typeof(BJEDCCHHEGI))]
	public Task<PGIFKEEINMC> LNFGJGOBBDC(byte[] OGHAFEOOGNL, CancellationToken DHCIMDILIGO, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, [Optional] TimeSpan? JFIGOGADDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5774030", Offset = "0x5772C30", VA = "0x185774030")]
	[AsyncStateMachine(typeof(APLBFFEKOIC))]
	private Task<PGIFKEEINMC> BJPMKIAAIAO(byte[] OGHAFEOOGNL, CancellationToken DHCIMDILIGO, BNJCICCOPAC AKKPJOCANIB, BNJCICCOPAC GLNJIDGGMNO, TimeSpan? CFALKDLEEJF, Stopwatch NJLMFEPEBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57760C0", Offset = "0x5774CC0", VA = "0x1857760C0")]
	[AsyncStateMachine(typeof(FPIPEDHHLGJ))]
	private Task<PGIFKEEINMC> KOOINPGMMKI(byte[] OGHAFEOOGNL, CancellationToken DHCIMDILIGO, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, [Optional] TimeSpan? JFIGOGADDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5775A70", Offset = "0x5774670", VA = "0x185775A70")]
	[AsyncStateMachine(typeof(OHMPPJEHIPB))]
	public Task HLECMNIDGBI(CancellationToken EOJPFFNCEBK, Func<CancellationToken, Task> OADDPANMHHI, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, int NKDLDPMNBNB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEA70", Offset = "0x1FAD670", VA = "0x181FAEA70")]
	[AsyncStateMachine(typeof(NEBOJPOFAMC))]
	public Task<T> HLECMNIDGBI<T>(CancellationToken EOJPFFNCEBK, Func<CancellationToken, Task<T>> OADDPANMHHI, [Optional] BNJCICCOPAC AKKPJOCANIB, [Optional] BNJCICCOPAC GLNJIDGGMNO, int NKDLDPMNBNB = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE5C0", Offset = "0x1FAD1C0", VA = "0x181FAE5C0")]
	[AsyncStateMachine(typeof(OEMPAMDGCGD))]
	private Task<(bool, T)> EEMLJMBLCAE<T>(Guid MIJJBKFBNDL, CancellationToken EOJPFFNCEBK, Func<CancellationToken, Task<T>> OADDPANMHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5776B00", Offset = "0x5775700", VA = "0x185776B00")]
	[IteratorStateMachine(typeof(GCIEBKCFDFN))]
	internal static IEnumerable<(CMOGODNJFPC, Guid)> MPMGDNALIBF(CMOGODNJFPC BCLDFPFMGLJ, Guid[] OGANLCOMJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5774DF0", Offset = "0x57739F0", VA = "0x185774DF0")]
	public void DAKHDMNFDEK(byte LAAEMPBFKLH, int NDMDCCJKPHO, object LMHCNCKJIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5776230", Offset = "0x5774E30", VA = "0x185776230")]
	public Guid LMCLHHFOMAE(Guid EMGPCKNBNJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x57759C0", Offset = "0x57745C0", VA = "0x1857759C0")]
	internal static int GGLMLBMFFAJ(CMOGODNJFPC BPNJDCHPGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5775BD0", Offset = "0x57747D0", VA = "0x185775BD0")]
	public bool ICACBIIOFBP(CMOGODNJFPC BPNJDCHPGMM, Guid MIJJBKFBNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57767D0", Offset = "0x57753D0", VA = "0x1857767D0")]
	public void MOCBIDNELNN(CMOGODNJFPC BPNJDCHPGMM, Guid MIJJBKFBNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5775910", Offset = "0x5774510", VA = "0x185775910")]
	private void FEODANNFPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5774290", Offset = "0x5772E90", VA = "0x185774290")]
	internal (CMOGODNJFPC, Guid[]) CGFHMKLDJKD(bool CDKPHDLFHEN = false)
	{
		return default((CMOGODNJFPC, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5776D80", Offset = "0x5775980", VA = "0x185776D80")]
	private HashSet<Guid> OKLCBNHLKML(CMOGODNJFPC BPNJDCHPGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5775630", Offset = "0x5774230", VA = "0x185775630")]
	private void DJHIAMGLCCB(CMOGODNJFPC BPNJDCHPGMM, Guid DJHPMDEHJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5774680", Offset = "0x5773280", VA = "0x185774680")]
	private void CGNCDHAHMEA(CMOGODNJFPC BPNJDCHPGMM, Guid DJHPMDEHJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5777700", Offset = "0x5776300", VA = "0x185777700")]
	public static Func<Guid, bool> PMBFABFPEKL(Guid DJHPMDEHJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5775920", Offset = "0x5774520", VA = "0x185775920")]
	public static Func<Guid, bool> FHKHHDCJDDB(Guid DJHPMDEHJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5775540", Offset = "0x5774140", VA = "0x185775540")]
	public void DALOEIONNAO(CMOGODNJFPC BPNJDCHPGMM, Guid NLAOGHDGOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5776EC0", Offset = "0x5775AC0", VA = "0x185776EC0")]
	public void PCGFGLKLHKP(CMOGODNJFPC BPNJDCHPGMM, Func<Guid, bool> GHDLPPDNGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CNOJMLEBPKG : AGGFLMKBNFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(EDEJDAJBION.LBNGOALDHKP itemType, long totalStopwatchTicks)> CMCJGGJACAP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(EDEJDAJBION.LBNGOALDHKP itemType, long totalStopwatchTicks)> OLEDBJPLAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63F140", Offset = "0x63DD40", VA = "0x18063F140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x576F7E0", Offset = "0x576E3E0", VA = "0x18576F7E0")]
	public CNOJMLEBPKG(TimeSpan JFIGOGADDHP, List<(EDEJDAJBION.LBNGOALDHKP itemType, long totalStopwatchTicks)> CMCJGGJACAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ANJCEEALAAM : LLILICEPJBC
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct ICIGDAFIJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid GBKFJJIHHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int NOANOAEPMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int MDAFNEIKHML;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5770CF0", Offset = "0x576F8F0", VA = "0x185770CF0")]
		public ICIGDAFIJAI(Guid IDLFHFGODGA, int GMGNDHPGPAC, int GLJAPMHEECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5770A40", Offset = "0x576F640", VA = "0x185770A40")]
		public static byte[] CGMPPIJDMHM(ICIGDAFIJAI CIJKLAFFGJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5770B90", Offset = "0x576F790", VA = "0x185770B90")]
		public static ICIGDAFIJAI EFBLDOLKNNC(byte[] IAIFCDOPKGE)
		{
			return default(ICIGDAFIJAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5770B10", Offset = "0x576F710", VA = "0x185770B10")]
		private static byte[] CMHIIGLHHAP(int JNJLPHNJHIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5770C40", Offset = "0x576F840", VA = "0x185770C40")]
		private static int FCICEMDMHEC(byte[] MKMOJNAKIIP, int HIANDEDCLIF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid IDLFHFGODGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly PGOAKEJNCDN IHEJFDBKFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool GDJKOALMGNA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x576E720", Offset = "0x576D320", VA = "0x18576E720")]
	public ANJCEEALAAM(Guid IDLFHFGODGA, PGOAKEJNCDN IHEJFDBKFDK, KBMEIJJPDEK JCCFEHGPDHB, CancellationToken EOJPFFNCEBK, [Optional] LGKAEGKHGID ECCGAKKLNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x576E3C0", Offset = "0x576CFC0", VA = "0x18576E3C0", Slot = "5")]
	protected override void FHMOAIABJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x576E230", Offset = "0x576CE30", VA = "0x18576E230", Slot = "6")]
	protected override void FGLOHFBHOAC(int KPKNFCCPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x576E540", Offset = "0x576D140", VA = "0x18576E540")]
	private void PDOPAMNIJJN(PGIFKEEINMC JOLBPPJGINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct PGIFKEEINMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte AKALBFOOJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte HKDAJOBCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool JGDDIEJLFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly PGOAKEJNCDN.CMOGODNJFPC DDIPLAONJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] JOKCNCLJKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] IGKCAPDIALJ;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5773FD0", Offset = "0x5772BD0", VA = "0x185773FD0")]
	public PGIFKEEINMC(PGOAKEJNCDN.CMOGODNJFPC BPNJDCHPGMM, [NotNull] Guid[] FCEFFDPGLAM, byte[] LEPAGINGHFK, bool MLHDJLLLJEG, byte DPCNCGOPOGF, byte EGOGIHOJJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5773B60", Offset = "0x5772760", VA = "0x185773B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x57739C0", Offset = "0x57725C0", VA = "0x1857739C0")]
	private static void NDOKENJPHBF(byte[] LEPAGINGHFK, StringBuilder DHFFICGFCHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class BKLFIDPCHLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29066E0", Offset = "0x29052E0", VA = "0x1829066E0", Slot = "4")]
	public void DJDCLOJKBJK(T CIJKLAFFGJI, IDictionary<object, object> OAGMKJFIKKL, bool PFLELFOHBMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MCPHAJCNOJE(T CIJKLAFFGJI, IDictionary<object, object> OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T EFBLDOLKNNC(IDictionary<object, object> OAGMKJFIKKL);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x29068F0", Offset = "0x29054F0", VA = "0x1829068F0", Slot = "7")]
	public bool MPCIJPGNHMD(IDictionary<object, object> OAGMKJFIKKL, out T HKFIKEOMLJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
	protected BKLFIDPCHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LLILICEPJBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool LGKAEGKHGID(int OHNAADNPPHG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly KBMEIJJPDEK DDHLOIAPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken EOJPFFNCEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken OCHEEMLIDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LGKAEGKHGID ECCGAKKLNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource POPLEOBBMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource PCKLPEJBGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int JOJCJGCILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool DOFEPEELPMB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken EBMHHPFNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57728C0", Offset = "0x57714C0", VA = "0x1857728C0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JCKCGCAOBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5772780", Offset = "0x5771380", VA = "0x185772780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x57728E0", Offset = "0x57714E0", VA = "0x1857728E0")]
	public LLILICEPJBC(KBMEIJJPDEK JCCFEHGPDHB, CancellationToken EOJPFFNCEBK, [Optional] LGKAEGKHGID ECCGAKKLNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5772690", Offset = "0x5771290", VA = "0x185772690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x57726D0", Offset = "0x57712D0", VA = "0x1857726D0", Slot = "5")]
	protected virtual void FHMOAIABJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x57727D0", Offset = "0x57713D0", VA = "0x1857727D0")]
	private void HJBCBDODHKN(JOLEIFGGDHD OGNEJEPEOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5772860", Offset = "0x5771460", VA = "0x185772860")]
	protected void NMMCOGELNBF(int KPKNFCCPEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x57726B0", Offset = "0x57712B0", VA = "0x1857726B0", Slot = "6")]
	protected virtual void FGLOHFBHOAC(int KPKNFCCPEME)
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
