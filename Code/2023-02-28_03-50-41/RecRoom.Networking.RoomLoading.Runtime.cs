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
internal class MGPBLCBPBEB : global::PFEKCFPBNJH<OFBMBPBFHMJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class JCEIGMMFHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JCEIGMMFHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6152D10", Offset = "0x6151710", VA = "0x186152D10")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] HFJBGPHLDCK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly MGPBLCBPBEB FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61547A0", Offset = "0x61531A0", VA = "0x1861547A0", Slot = "5")]
	protected override void ENDJNGBEPJA(OFBMBPBFHMJ EJEIJOMMNGK, IDictionary<object, object> NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6153C30", Offset = "0x6152630", VA = "0x186153C30", Slot = "6")]
	public override OFBMBPBFHMJ AJGJBLGJHIK(IDictionary<object, object> NIPBPKPBPPP)
	{
		return default(OFBMBPBFHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6154E30", Offset = "0x6153830", VA = "0x186154E30")]
	public MGPBLCBPBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DFAGGIFGJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string HKDGPIAIJCD([NotNull] byte[] EONCDECCEBA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct DFAEGGONFLF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly CPFAFAKDPAI AMGLNLEDGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool EONPFLLLPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T CBNKGLFPDMA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x25936F0", Offset = "0x25920F0", VA = "0x1825936F0")]
		public static DFAEGGONFLF<T> KHJIOPNJOPF(OFBMBPBFHMJ DNHBBODIKOP, Func<byte[], T> IJJPDAPBANL)
		{
			return default(DFAEGGONFLF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2593990", Offset = "0x2592390", VA = "0x182593990")]
		public DFAEGGONFLF(CPFAFAKDPAI CIHKLJHNNIC, T EONCDECCEBA, bool LKENJBAGGOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x25937F0", Offset = "0x25921F0", VA = "0x1825937F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OIDEFAJGCAN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KFECODOEHCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<OFBMBPBFHMJ> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public OIDEFAJGCAN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public KFECODOEHCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6153010", Offset = "0x6151A10", VA = "0x186153010")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6153060", Offset = "0x6151A60", VA = "0x186153060")]
			internal OLJAFOIFGHA <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class KMOJNMHDHDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HMPKJKPIHFN.EMKLCPIAJHI itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public KMOJNMHDHDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x61539F0", Offset = "0x61523F0", VA = "0x1861539F0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct ADECEMDONLO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OFBMBPBFHMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OIDEFAJGCAN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private KFECODOEHCF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x614A220", Offset = "0x6148C20", VA = "0x18614A220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x614AA30", Offset = "0x6149430", VA = "0x18614AA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PFCEJJGOAMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public MHLEAAECBJH sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public PFCEJJGOAMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x61568B0", Offset = "0x61552B0", VA = "0x1861568B0")]
			internal bool <ClearSlice>b__0(OFBMBPBFHMJ bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly AEHMKHDGACK LAAGBINLGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string AOJEJPELGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<OFBMBPBFHMJ> PEFKACOLFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(HMPKJKPIHFN.EMKLCPIAJHI itemType, long totalStopwatchTicks)> CBIKHCJBAMA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool AMMMFHEPFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6155700", Offset = "0x6154100", VA = "0x186155700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<OFBMBPBFHMJ> ANADAALNAJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6155A20", Offset = "0x6154420", VA = "0x186155A20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x61557A0", Offset = "0x61541A0", VA = "0x1861557A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6155C10", Offset = "0x6154610", VA = "0x186155C10")]
		public OIDEFAJGCAN(AEHMKHDGACK LAAGBINLGON, string AOJEJPELGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6155AC0", Offset = "0x61544C0", VA = "0x186155AC0")]
		[AsyncStateMachine(typeof(ADECEMDONLO))]
		public Task<OFBMBPBFHMJ> OGNALHIBJEM(CancellationToken KAKEKEHNCME, TimeSpan BPABCDMAKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6155840", Offset = "0x6154240", VA = "0x186155840")]
		public void FMGHEFLDBDC(OFBMBPBFHMJ EJEIJOMMNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6155750", Offset = "0x6154150", VA = "0x186155750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61558F0", Offset = "0x61542F0", VA = "0x1861558F0")]
		public void HFDGDHMJLPG(MHLEAAECBJH ILBHJEHNLHF, Guid OGGLMCNMCLJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct INGNALNLKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<OFBMBPBFHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CAFOCDOFHHK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6152380", Offset = "0x6150D80", VA = "0x186152380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6152CC0", Offset = "0x61516C0", VA = "0x186152CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HJPIDAPMJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CAFOCDOFHHK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<DFAEGGONFLF<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61514A0", Offset = "0x614FEA0", VA = "0x1861514A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6151850", Offset = "0x6150250", VA = "0x186151850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IJMDGBCPHOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<OFBMBPBFHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CAFOCDOFHHK pauseAfterListeningToken;

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
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6151A30", Offset = "0x6150430", VA = "0x186151A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6152330", Offset = "0x6150D30", VA = "0x186152330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LAAMKGDEAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LAAMKGDEAPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PDLOIEBHOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<OFBMBPBFHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private LAAMKGDEAPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CAFOCDOFHHK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NMCAIPBHFAL <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6155D90", Offset = "0x6154790", VA = "0x186155D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6156860", Offset = "0x6155260", VA = "0x186156860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HABEHHJLFLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<OFBMBPBFHMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CAFOCDOFHHK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<OFBMBPBFHMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6150BD0", Offset = "0x614F5D0", VA = "0x186150BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6150FB0", Offset = "0x614F9B0", VA = "0x186150FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PNFABCABIKD
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
			public PNFABCABIKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6156CB0", Offset = "0x61556B0", VA = "0x186156CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6156E20", Offset = "0x6155820", VA = "0x186156E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PNFABCABIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6156B70", Offset = "0x6155570", VA = "0x186156B70")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JNHKDFCKGNN : IAsyncStateMachine
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
		public DFAGGIFGJFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CAFOCDOFHHK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CAFOCDOFHHK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6152DD0", Offset = "0x61517D0", VA = "0x186152DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HKGJFKEIBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HKGJFKEIBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x61518F0", Offset = "0x61502F0", VA = "0x1861518F0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61518A0", Offset = "0x61502A0", VA = "0x1861518A0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GDEGNLFFFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MHLEAAECBJH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GDEGNLFFFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6150B30", Offset = "0x614F530", VA = "0x186150B30")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HNDAHCCHFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MHLEAAECBJH sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HNDAHCCHFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6151990", Offset = "0x6150390", VA = "0x186151990")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HGNHGJJNNLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HGNHGJJNNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61512E0", Offset = "0x614FCE0", VA = "0x1861512E0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NGLKGBENDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NGLKGBENDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6154E70", Offset = "0x6153870", VA = "0x186154E70")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FFIEKHEECPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FFIEKHEECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6150AA0", Offset = "0x614F4A0", VA = "0x186150AA0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KHDOECDHCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KHDOECDHCAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6153960", Offset = "0x6152360", VA = "0x186153960")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AMDGCLILICK
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AMDGCLILICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x614AB60", Offset = "0x6149560", VA = "0x18614AB60")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x614AB00", Offset = "0x6149500", VA = "0x18614AB00")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FECLNKLINEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FECLNKLINEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6150A00", Offset = "0x614F400", VA = "0x186150A00")]
		internal bool <ClearSliceIds>b__3(HIJBLIODJPH stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KFGNAFNHDDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KFGNAFNHDDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6153460", Offset = "0x6151E60", VA = "0x186153460")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61536E0", Offset = "0x61520E0", VA = "0x1861536E0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61533F0", Offset = "0x6151DF0", VA = "0x1861533F0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HKDGPIAIJCD ICACANIJMPO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable AABANDGGGIH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MFNIAKBHBEB PFCIMHHBCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OIDEFAJGCAN JCDLNEKHNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AEHMKHDGACK LAAGBINLGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MMEGLAINFCK EMAHGDLIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GPKIGGINJFJ IBAFHAGCECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HKDGPIAIJCD MKAKJPMFGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IAFLCEPGHIO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan OFBPFCAIDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan DLPJMBHLGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte CNHNAMMNFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] DFOAJFLHOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<HIJBLIODJPH> AFPKALLOOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CPFAFAKDPAI? MJEOIPALFCJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly MFNIAKBHBEB LNJIKJOKHPN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly MFNIAKBHBEB JHPINLBNJBH;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<OFBMBPBFHMJ> BIJLPHILDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x614E740", Offset = "0x614D140", VA = "0x18614E740")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x614C0F0", Offset = "0x614AAF0", VA = "0x18614C0F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x614FC40", Offset = "0x614E640", VA = "0x18614FC40")]
	public DFAGGIFGJFA(AEHMKHDGACK LAAGBINLGON, MMEGLAINFCK EMAHGDLIGDD, GPKIGGINJFJ IBAFHAGCECC, [Optional] TimeSpan? MNJGLCOLGKA, [Optional] HKDGPIAIJCD IACKJEKCHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D631A0", Offset = "0x1D61BA0", VA = "0x181D631A0")]
	public static DFAGGIFGJFA BIGGFICLAAC<TNetworking>(TNetworking LNMHPEDOLKI, [Optional] TimeSpan? MNJGLCOLGKA, [Optional] HKDGPIAIJCD IACKJEKCHJA) where TNetworking : AEHMKHDGACK, MMEGLAINFCK, GPKIGGINJFJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x614D860", Offset = "0x614C260", VA = "0x18614D860")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x614C190", Offset = "0x614AB90", VA = "0x18614C190")]
	private byte ANBCFKBJGAB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x614B980", Offset = "0x614A380", VA = "0x18614B980")]
	private TimeSpan AAKFLBBKFCN(TimeSpan? MNJGLCOLGKA, int ILKLNDAPBEA = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D63A10", Offset = "0x1D62410", VA = "0x181D63A10")]
	public bool NJBIAAIMJKM<T>(T HLEJDFDJJLP, Func<T, byte[]> BAMJJNCDPBB, bool LKENJBAGGOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x614EA20", Offset = "0x614D420", VA = "0x18614EA20")]
	public bool NJBIAAIMJKM(byte[] HLEJDFDJJLP, int NMDODFIDCNM, bool LKENJBAGGOL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00")]
	private static string NKHDKGIBNAE(string EJEIJOMMNGK, string HAAENNGJIPE = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x614CF10", Offset = "0x614B910", VA = "0x18614CF10")]
	[AsyncStateMachine(typeof(INGNALNLKHA))]
	public Task<OFBMBPBFHMJ> FMNHFKEAGBF(CancellationToken KAKEKEHNCME, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, [Optional] TimeSpan? MNJGLCOLGKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x614F870", Offset = "0x614E270", VA = "0x18614F870")]
	[AsyncStateMachine(typeof(HJPIDAPMJAD))]
	public Task<Guid> PDGMIDJIFOL(Guid JFLMDGEFHLD, CancellationToken KAKEKEHNCME, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, [Optional] TimeSpan? BPABCDMAKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D63400", Offset = "0x1D61E00", VA = "0x181D63400")]
	[AsyncStateMachine(typeof(NCDIALDLNIH))]
	public Task<DFAEGGONFLF<T>> HJBPCGHDFJA<T>(T HLEJDFDJJLP, Func<T, byte[]> BAMJJNCDPBB, Func<byte[], T> IJJPDAPBANL, CancellationToken KAKEKEHNCME, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, [Optional] TimeSpan? BPABCDMAKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x614D400", Offset = "0x614BE00", VA = "0x18614D400")]
	[AsyncStateMachine(typeof(IJMDGBCPHOK))]
	public Task<OFBMBPBFHMJ> HJBPCGHDFJA(byte[] HLEJDFDJJLP, CancellationToken KAKEKEHNCME, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, [Optional] TimeSpan? BPABCDMAKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x614D6B0", Offset = "0x614C0B0", VA = "0x18614D6B0")]
	[AsyncStateMachine(typeof(PDLOIEBHOJC))]
	private Task<OFBMBPBFHMJ> JAHMEGEJAKN(byte[] HLEJDFDJJLP, CancellationToken KAKEKEHNCME, CAFOCDOFHHK PMBAKFJNCJI, CAFOCDOFHHK LCONMNHBMGE, TimeSpan? MNJGLCOLGKA, Stopwatch NKKIGMCKEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x614E7E0", Offset = "0x614D1E0", VA = "0x18614E7E0")]
	[AsyncStateMachine(typeof(HABEHHJLFLD))]
	private Task<OFBMBPBFHMJ> LHCIDFLNLLE(byte[] HLEJDFDJJLP, CancellationToken KAKEKEHNCME, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, [Optional] TimeSpan? BPABCDMAKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x614F700", Offset = "0x614E100", VA = "0x18614F700")]
	[AsyncStateMachine(typeof(JNHKDFCKGNN))]
	public Task OPBLJLIDGLO(CancellationToken HLIGFMLOMGA, Func<CancellationToken, Task> DPGAOBOBNBF, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, int NIJEAHFEHOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D63AC0", Offset = "0x1D624C0", VA = "0x181D63AC0")]
	[AsyncStateMachine(typeof(JPIOPHMJBPB))]
	public Task<T> OPBLJLIDGLO<T>(CancellationToken HLIGFMLOMGA, Func<CancellationToken, Task<T>> DPGAOBOBNBF, [Optional] CAFOCDOFHHK PMBAKFJNCJI, [Optional] CAFOCDOFHHK LCONMNHBMGE, int NIJEAHFEHOI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D635C0", Offset = "0x1D61FC0", VA = "0x181D635C0")]
	[AsyncStateMachine(typeof(MOPAIJFHCJA))]
	private Task<(bool, T)> MHHKFMHFNDP<T>(Guid NNFEIEJOPKG, CancellationToken HLIGFMLOMGA, Func<CancellationToken, Task<T>> DPGAOBOBNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x614C390", Offset = "0x614AD90", VA = "0x18614C390")]
	public void FIBKFPMOAIC(byte NLMDNLDJIGP, int ANHHDEJOADH, object KLHHFLEELNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x614D090", Offset = "0x614BA90", VA = "0x18614D090")]
	public Guid GBHBCAGPIDH(Guid PEPLFJPIDHL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x614E1C0", Offset = "0x614CBC0", VA = "0x18614E1C0")]
	public bool KILAAFCHCGL(MHLEAAECBJH ILBHJEHNLHF, Guid NNFEIEJOPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x614F300", Offset = "0x614DD00", VA = "0x18614F300")]
	public void ONAEBCMPBHD(MHLEAAECBJH ILBHJEHNLHF, Guid NNFEIEJOPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x614D590", Offset = "0x614BF90", VA = "0x18614D590")]
	private void HKJFPJNDOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x614D5A0", Offset = "0x614BFA0", VA = "0x18614D5A0")]
	internal CPFAFAKDPAI IJDGONAIDKG(bool JEKBFLANJFA = false)
	{
		return default(CPFAFAKDPAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x614C1A0", Offset = "0x614ABA0", VA = "0x18614C1A0")]
	private HashSet<Guid> AOOABJEENFN(MHLEAAECBJH ILBHJEHNLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x614CD40", Offset = "0x614B740", VA = "0x18614CD40")]
	private void FLICDIBPBOJ(MHLEAAECBJH ILBHJEHNLHF, Guid OGGLMCNMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x614F020", Offset = "0x614DA20", VA = "0x18614F020")]
	private void OABEIBJFAOG(MHLEAAECBJH ILBHJEHNLHF, Guid OGGLMCNMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x614E970", Offset = "0x614D370", VA = "0x18614E970")]
	public static Func<Guid, bool> MLECIMJINFK(Guid OGGLMCNMCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x614C2E0", Offset = "0x614ACE0", VA = "0x18614C2E0")]
	public static Func<Guid, bool> CPMCFNPMCON(Guid OGGLMCNMCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x614D2F0", Offset = "0x614BCF0", VA = "0x18614D2F0")]
	public void HFDGDHMJLPG(MHLEAAECBJH ILBHJEHNLHF, Guid CCGGCFPLCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x614BBC0", Offset = "0x614A5C0", VA = "0x18614BBC0")]
	public void ABHKPFJMDHP(MHLEAAECBJH ILBHJEHNLHF, Func<Guid, bool> IGIPKOIIMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x614E0A0", Offset = "0x614CAA0", VA = "0x18614E0A0")]
	private static ExitGames.Client.Photon.Hashtable JPNAEGJPNDL(MHLEAAECBJH ILBHJEHNLHF, Guid KLNKPMIMBHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x614D950", Offset = "0x614C350", VA = "0x18614D950")]
	private void JGJNHDNLGIM(MHLEAAECBJH ILBHJEHNLHF, Guid KLNKPMIMBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OLJAFOIFGHA : PGNDAHCCDBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(HMPKJKPIHFN.EMKLCPIAJHI itemType, long totalStopwatchTicks)> PJCHCNLFONN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(HMPKJKPIHFN.EMKLCPIAJHI itemType, long totalStopwatchTicks)> BENGKHLDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E20", Offset = "0x6C6820", VA = "0x1806C7E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6155D10", Offset = "0x6154710", VA = "0x186155D10")]
	public OLJAFOIFGHA(TimeSpan BPABCDMAKOP, List<(HMPKJKPIHFN.EMKLCPIAJHI itemType, long totalStopwatchTicks)> PJCHCNLFONN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EOGJEJPPFHD : NMCAIPBHFAL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct HGFLBLNCAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid DFAPGMHLLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int AACPLDOEAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int DMPANPNBOCG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61512D0", Offset = "0x614FCD0", VA = "0x1861512D0")]
		public HGFLBLNCAIB(Guid HMJLPGKCCBB, int KMAAFMLCLII, int DPJLGKPNHLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61511F0", Offset = "0x614FBF0", VA = "0x1861511F0")]
		public static byte[] JHPOCMCIPNJ(HGFLBLNCAIB EJEIJOMMNGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6151000", Offset = "0x614FA00", VA = "0x186151000")]
		public static HGFLBLNCAIB AJGJBLGJHIK(byte[] FMIGDHLBIKP)
		{
			return default(HGFLBLNCAIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61510C0", Offset = "0x614FAC0", VA = "0x1861510C0")]
		private static byte[] CIFLBDKMLPA(int ALJNHCKDPKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6151140", Offset = "0x614FB40", VA = "0x186151140")]
		private static int DMFKKAIEICF(byte[] JACBFDHNOPB, int GFDMFLGCBKB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid HMJLPGKCCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly DFAGGIFGJFA ONODKMAJPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool JBFMOCJNCCI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61509A0", Offset = "0x614F3A0", VA = "0x1861509A0")]
	public EOGJEJPPFHD(Guid HMJLPGKCCBB, DFAGGIFGJFA ONODKMAJPGL, GPKIGGINJFJ LNMHPEDOLKI, CancellationToken HLIGFMLOMGA, [Optional] ADPFAEOCBAC FBNLCLMPHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6150630", Offset = "0x614F030", VA = "0x186150630", Slot = "5")]
	protected override void FPLFNAKDNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6150800", Offset = "0x614F200", VA = "0x186150800", Slot = "6")]
	protected override void LNCPJGMLCCF(int IHLDGDIFKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6150410", Offset = "0x614EE10", VA = "0x186150410")]
	private void BIJLPHILDKL(OFBMBPBFHMJ OLKCNMLCBHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OFBMBPBFHMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly CPFAFAKDPAI AMGLNLEDGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte ANEBAJKHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte KJOBFJHJLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool EONPFLLLPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] CBNKGLFPDMA;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x61556A0", Offset = "0x61540A0", VA = "0x1861556A0")]
	public OFBMBPBFHMJ(CPFAFAKDPAI CIHKLJHNNIC, [CanBeNull] byte[] EONCDECCEBA, bool LKENJBAGGOL, byte PPEEOMMHOHB, byte LBBHOGPJJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6155500", Offset = "0x6153F00", VA = "0x186155500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6155310", Offset = "0x6153D10", VA = "0x186155310")]
	private static void CKPMMCBPODG(byte[] EONCDECCEBA, StringBuilder JGCNNCLKHIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CPFAFAKDPAI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DJLHOEPALBO : IEnumerable<HIJBLIODJPH>, IEnumerable, IEnumerator<HIJBLIODJPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private HIJBLIODJPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CPFAFAKDPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CPFAFAKDPAI <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MHLEAAECBJH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HIJBLIODJPH System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3D35040", Offset = "0x3D33A40", VA = "0x183D35040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HIJBLIODJPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x61503C0", Offset = "0x614EDC0", VA = "0x1861503C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x968EC0", Offset = "0x9678C0", VA = "0x180968EC0")]
		[DebuggerHidden]
		public DJLHOEPALBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61500F0", Offset = "0x614EAF0", VA = "0x1861500F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6150380", Offset = "0x614ED80", VA = "0x186150380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61502E0", Offset = "0x614ECE0", VA = "0x1861502E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HIJBLIODJPH> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61502E0", Offset = "0x614ECE0", VA = "0x1861502E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly MHLEAAECBJH BPILAKKPEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] OLHLMHHCNPI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x614B0A0", Offset = "0x6149AA0", VA = "0x18614B0A0")]
	public static CPFAFAKDPAI IMMCGFAIFLE(MHLEAAECBJH ILBHJEHNLHF, Guid BEDOFHIENKN)
	{
		return default(CPFAFAKDPAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x614B1A0", Offset = "0x6149BA0", VA = "0x18614B1A0")]
	public static CPFAFAKDPAI KBDGDMLKGAO(List<HIJBLIODJPH> MCCLCFAPIEK)
	{
		return default(CPFAFAKDPAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x614AC40", Offset = "0x6149640", VA = "0x18614AC40")]
	public static CPFAFAKDPAI EOBBCOGEEBF(MHLEAAECBJH DIGBKNHLDGJ, Guid[] LEFHPMNCJIK)
	{
		return default(CPFAFAKDPAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x614B740", Offset = "0x614A140", VA = "0x18614B740")]
	private CPFAFAKDPAI(MHLEAAECBJH DIGBKNHLDGJ, Guid[] LEFHPMNCJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x614ABC0", Offset = "0x61495C0", VA = "0x18614ABC0")]
	[IteratorStateMachine(typeof(DJLHOEPALBO))]
	public IEnumerable<HIJBLIODJPH> BGJGNLCDLJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x614B5C0", Offset = "0x6149FC0", VA = "0x18614B5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PFEKCFPBNJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3142850", Offset = "0x3141250", VA = "0x183142850", Slot = "4")]
	public void NBIELFFAOPP(T EJEIJOMMNGK, IDictionary<object, object> NIPBPKPBPPP, bool INLKKNFMKJK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ENDJNGBEPJA(T EJEIJOMMNGK, IDictionary<object, object> NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T AJGJBLGJHIK(IDictionary<object, object> NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
	protected PFEKCFPBNJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NMCAIPBHFAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool ADPFAEOCBAC(int KKGBKNBHADE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly GPKIGGINJFJ LKKBLPEHGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken HLIGFMLOMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken DJGPJGPHMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly ADPFAEOCBAC FBNLCLMPHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource DMFIDDGAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource KHBIKBEHAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int DOOEOLPNIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool DCLOGNFEMBO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken GKPFNAKDLME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6154F60", Offset = "0x6153960", VA = "0x186154F60")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FKGMIMPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6155050", Offset = "0x6153A50", VA = "0x186155050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6155160", Offset = "0x6153B60", VA = "0x186155160")]
	public NMCAIPBHFAL(GPKIGGINJFJ LNMHPEDOLKI, CancellationToken HLIGFMLOMGA, [Optional] ADPFAEOCBAC FBNLCLMPHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6154F40", Offset = "0x6153940", VA = "0x186154F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6154F80", Offset = "0x6153980", VA = "0x186154F80", Slot = "5")]
	protected virtual void FPLFNAKDNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61550A0", Offset = "0x6153AA0", VA = "0x1861550A0")]
	private void LLHNFGGPJMM(BNMLLFBMDOA OABPEPNAJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6154EE0", Offset = "0x61538E0", VA = "0x186154EE0")]
	protected void DPILDOPJCAP(int IHLDGDIFKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6155140", Offset = "0x6153B40", VA = "0x186155140", Slot = "6")]
	protected virtual void LNCPJGMLCCF(int IHLDGDIFKAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct HIJBLIODJPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly MHLEAAECBJH PMDNDANCIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid GAHNJNAEIPB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4C00", Offset = "0x1FE3600", VA = "0x181FE4C00")]
	public HIJBLIODJPH(MHLEAAECBJH ILBHJEHNLHF, Guid NNFEIEJOPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6151440", Offset = "0x614FE40", VA = "0x186151440")]
	public bool IHGPCKFDMJE(HIJBLIODJPH DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6151350", Offset = "0x614FD50", VA = "0x186151350", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6151410", Offset = "0x614FE10", VA = "0x186151410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum MHLEAAECBJH : byte
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
internal static class PKFPGAIPDMN
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly MHLEAAECBJH[] HLOFPMDGNIF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6156A20", Offset = "0x6155420", VA = "0x186156A20")]
	public static int FNMDNFLBAMO(MHLEAAECBJH ILBHJEHNLHF)
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
