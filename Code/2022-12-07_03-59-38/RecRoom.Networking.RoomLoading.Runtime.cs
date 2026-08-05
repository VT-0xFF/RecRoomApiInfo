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
internal class CPGPFNPLMPF : global::JOMMPNKHCPN<MJPLDIOAJAH>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LDNFPLGNNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LDNFPLGNNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B1A0", Offset = "0x5D99DA0", VA = "0x185D9B1A0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] LPCFBKNGJFC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CPGPFNPLMPF OHEGMANNBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D95850", Offset = "0x5D94450", VA = "0x185D95850", Slot = "5")]
	protected override void EJFPNDNELOE(MJPLDIOAJAH DPNJMDFICMK, IDictionary<object, object> GAGLKGONONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D95CC0", Offset = "0x5D948C0", VA = "0x185D95CC0", Slot = "6")]
	public override MJPLDIOAJAH PPPEOPKFADK(IDictionary<object, object> GAGLKGONONJ)
	{
		return default(MJPLDIOAJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D96A40", Offset = "0x5D95640", VA = "0x185D96A40")]
	public CPGPFNPLMPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AFCKFGFKPJC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string JMPJLAHHNFM([NotNull] byte[] ADEMJHPFLJL);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct KDLEJCDLFKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly HBILACFBIGG NDKGFCILOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool DOCGBAPCGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T IDCANPHMJGF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB0A0", Offset = "0x2CF9CA0", VA = "0x182CFB0A0")]
		public static KDLEJCDLFKE<T> BCOGLAEMFHN(MJPLDIOAJAH MAIFCPGBDGC, Func<byte[], T> CBNMJFDKOHP)
		{
			return default(KDLEJCDLFKE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB350", Offset = "0x2CF9F50", VA = "0x182CFB350")]
		public KDLEJCDLFKE(HBILACFBIGG KJGFHIOGHBK, T ADEMJHPFLJL, bool KOLFJPCDFAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2CFB1B0", Offset = "0x2CF9DB0", VA = "0x182CFB1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MJLAMBCEOKJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NBJNLKAGFLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<MJPLDIOAJAH> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public MJLAMBCEOKJ <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public NBJNLKAGFLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5D9C890", Offset = "0x5D9B490", VA = "0x185D9C890")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5D9C8E0", Offset = "0x5D9B4E0", VA = "0x185D9C8E0")]
			internal KBGNFONFLKA <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class OPDCFLEPCEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LDLHPCOIFJP.BKOBPDPDGGP itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public OPDCFLEPCEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D9CEA0", Offset = "0x5D9BAA0", VA = "0x185D9CEA0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct JBJJKFPLHNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MJPLDIOAJAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public MJLAMBCEOKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NBJNLKAGFLD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<MJPLDIOAJAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5D99D40", Offset = "0x5D98940", VA = "0x185D99D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5D9A550", Offset = "0x5D99150", VA = "0x185D9A550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JAKLEOLNAKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public GKHADMOPLBF sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public JAKLEOLNAKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5D99BD0", Offset = "0x5D987D0", VA = "0x185D99BD0")]
			internal bool <ClearSlice>b__0(MJPLDIOAJAH bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JOBPLKIKOKG FCCHJBGPLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string OIJIALKKLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<MJPLDIOAJAH> JPFEOAJDOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(LDLHPCOIFJP.BKOBPDPDGGP itemType, long totalStopwatchTicks)> BMALPJMFDKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FHNGAMMAJMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5D9C350", Offset = "0x5D9AF50", VA = "0x185D9C350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<MJPLDIOAJAH> LICIFHNIKBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5D9C0E0", Offset = "0x5D9ACE0", VA = "0x185D9C0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5D9C2B0", Offset = "0x5D9AEB0", VA = "0x185D9C2B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D9C3A0", Offset = "0x5D9AFA0", VA = "0x185D9C3A0")]
		public MJLAMBCEOKJ(JOBPLKIKOKG FCCHJBGPLPG, string OIJIALKKLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D9BE90", Offset = "0x5D9AA90", VA = "0x185D9BE90")]
		[AsyncStateMachine(typeof(JBJJKFPLHNH))]
		public Task<MJPLDIOAJAH> BNHOJEJCGDH(CancellationToken OKPCBPJCBCJ, TimeSpan JBOENGFCOFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D9BFE0", Offset = "0x5D9ABE0", VA = "0x185D9BFE0")]
		public void CHFKOEPFPBP(MJPLDIOAJAH DPNJMDFICMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D9C090", Offset = "0x5D9AC90", VA = "0x185D9C090", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D9C180", Offset = "0x5D9AD80", VA = "0x185D9C180")]
		public void KDONBFNLLGD(GKHADMOPLBF CKFFLNMBIDH, Guid BEAOEMMHBNI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JJEPKINELCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<MJPLDIOAJAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CMFLPAKKNOD pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A710", Offset = "0x5D99310", VA = "0x185D9A710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B030", Offset = "0x5D99C30", VA = "0x185D9B030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EOBHAPIPPKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CMFLPAKKNOD pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<KDLEJCDLFKE<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5D97CA0", Offset = "0x5D968A0", VA = "0x185D97CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D98050", Offset = "0x5D96C50", VA = "0x185D98050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LMJOAOHANJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<MJPLDIOAJAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CMFLPAKKNOD pauseAfterListeningToken;

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
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B540", Offset = "0x5D9A140", VA = "0x185D9B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D9BE40", Offset = "0x5D9AA40", VA = "0x185D9BE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JFHDKMILDNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JFHDKMILDNB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EMMABMDPPGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<MJPLDIOAJAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private JFHDKMILDNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CMFLPAKKNOD pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private CNGAKMMHAFA <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D971B0", Offset = "0x5D95DB0", VA = "0x185D971B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D97C50", Offset = "0x5D96850", VA = "0x185D97C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CKMMIEEHDKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<MJPLDIOAJAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CMFLPAKKNOD pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<MJPLDIOAJAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D94FF0", Offset = "0x5D93BF0", VA = "0x185D94FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D953D0", Offset = "0x5D93FD0", VA = "0x185D953D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EGNFGECONDF
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
			public EGNFGECONDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5D9D010", Offset = "0x5D9BC10", VA = "0x185D9D010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5D9D180", Offset = "0x5D9BD80", VA = "0x185D9D180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EGNFGECONDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D97070", Offset = "0x5D95C70", VA = "0x185D97070")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NEJLDLABNDD : IAsyncStateMachine
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
		public AFCKFGFKPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public CMFLPAKKNOD unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CMFLPAKKNOD pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D9CC60", Offset = "0x5D9B860", VA = "0x185D9CC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DHLFKGMCLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DHLFKGMCLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5D96AD0", Offset = "0x5D956D0", VA = "0x185D96AD0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D96A80", Offset = "0x5D95680", VA = "0x185D96A80")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JOIHJDAJGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GKHADMOPLBF sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public JOIHJDAJGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B080", Offset = "0x5D99C80", VA = "0x185D9B080")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GPILPPPLCGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public GKHADMOPLBF sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GPILPPPLCGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5D986A0", Offset = "0x5D972A0", VA = "0x185D986A0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IHBPAMGEAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public IHBPAMGEAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D99B60", Offset = "0x5D98760", VA = "0x185D99B60")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HBPMBDLNHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public HBPMBDLNHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D99500", Offset = "0x5D98100", VA = "0x185D99500")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EBBEJKHPAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public EBBEJKHPAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D96FE0", Offset = "0x5D95BE0", VA = "0x185D96FE0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GKCIBEIFMPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GKCIBEIFMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5D98610", Offset = "0x5D97210", VA = "0x185D98610")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BDHMDBGPJDN
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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public BDHMDBGPJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D94F10", Offset = "0x5D93B10", VA = "0x185D94F10")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D94EB0", Offset = "0x5D93AB0", VA = "0x185D94EB0")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PECJAEINKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PECJAEINKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D9CF70", Offset = "0x5D9BB70", VA = "0x185D9CF70")]
		internal bool <ClearSliceIds>b__3(AHLMFMIIHFH stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GJIBNOBPMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public GJIBNOBPMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5D98110", Offset = "0x5D96D10", VA = "0x185D98110")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5D98390", Offset = "0x5D96F90", VA = "0x185D98390")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5D980A0", Offset = "0x5D96CA0", VA = "0x185D980A0")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly JMPJLAHHNFM FHEBJBFJCEB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable ONCDJMKEGHD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FJDNOHIPOJF ACLGLIBBNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MJLAMBCEOKJ MBKCJCBNGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JOBPLKIKOKG FCCHJBGPLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NCBMGIHIGDO JMCMIGMHBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ELCFGCLPODH FEIBABJNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JMPJLAHHNFM OONNCIOIBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LNPINMMGACJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan GFIMMBLNPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan DDBBHNLDDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte DAFICFNDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] FNOGKOAMBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<AHLMFMIIHFH> EGEIDNJPHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HBILACFBIGG? LPKLMCJDGLC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly FJDNOHIPOJF PLCJAAKGKFL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly FJDNOHIPOJF OENAABMGGEJ;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<MJPLDIOAJAH> NJHALLBAHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D91210", Offset = "0x5D8FE10", VA = "0x185D91210")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D91680", Offset = "0x5D90280", VA = "0x185D91680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D948B0", Offset = "0x5D934B0", VA = "0x185D948B0")]
	public AFCKFGFKPJC(JOBPLKIKOKG FCCHJBGPLPG, NCBMGIHIGDO JMCMIGMHBDF, ELCFGCLPODH FEIBABJNNLF, [Optional] TimeSpan? PLAFBEKJCGI, [Optional] JMPJLAHHNFM MGBIDFPKFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E34480", Offset = "0x1E33080", VA = "0x181E34480")]
	public static AFCKFGFKPJC HIGAKMAPPCK<TNetworking>(TNetworking NKGCEELNNIP, [Optional] TimeSpan? PLAFBEKJCGI, [Optional] JMPJLAHHNFM MGBIDFPKFLH) where TNetworking : JOBPLKIKOKG, NCBMGIHIGDO, ELCFGCLPODH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D918A0", Offset = "0x5D904A0", VA = "0x185D918A0")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D91990", Offset = "0x5D90590", VA = "0x185D91990")]
	private byte FDLGHFELPIH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D912B0", Offset = "0x5D8FEB0", VA = "0x185D912B0")]
	private TimeSpan CCGICCFKJFH(TimeSpan? PLAFBEKJCGI, int PHOFDIEKLKA = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E348A0", Offset = "0x1E334A0", VA = "0x181E348A0")]
	public bool NHIAJLCBKGO<T>(T FICEFCGCCDN, Func<T, byte[]> AILCJINKCMI, bool KOLFJPCDFAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D93AC0", Offset = "0x5D926C0", VA = "0x185D93AC0")]
	public bool NHIAJLCBKGO(byte[] FICEFCGCCDN, int NBMDLHGCPOM, bool KOLFJPCDFAA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D8CB0", VA = "0x1806DA0B0")]
	private static string KMFCNLNCPNJ(string DPNJMDFICMK, string NCBJACAKLIH = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D91720", Offset = "0x5D90320", VA = "0x185D91720")]
	[AsyncStateMachine(typeof(JJEPKINELCO))]
	public Task<MJPLDIOAJAH> EGKIMAJLDDM(CancellationToken OKPCBPJCBCJ, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, [Optional] TimeSpan? PLAFBEKJCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D90F10", Offset = "0x5D8FB10", VA = "0x185D90F10")]
	[AsyncStateMachine(typeof(EOBHAPIPPKO))]
	public Task<Guid> BLOLBBDAFPJ(Guid BJEDENIBBDE, CancellationToken OKPCBPJCBCJ, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, [Optional] TimeSpan? JBOENGFCOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E34520", Offset = "0x1E33120", VA = "0x181E34520")]
	[AsyncStateMachine(typeof(IAJJGACIOGL))]
	public Task<KDLEJCDLFKE<T>> JOLCMMHNJDD<T>(T FICEFCGCCDN, Func<T, byte[]> AILCJINKCMI, Func<byte[], T> CBNMJFDKOHP, CancellationToken OKPCBPJCBCJ, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, [Optional] TimeSpan? JBOENGFCOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D931D0", Offset = "0x5D91DD0", VA = "0x185D931D0")]
	[AsyncStateMachine(typeof(LMJOAOHANJP))]
	public Task<MJPLDIOAJAH> JOLCMMHNJDD(byte[] FICEFCGCCDN, CancellationToken OKPCBPJCBCJ, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, [Optional] TimeSpan? JBOENGFCOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D93860", Offset = "0x5D92460", VA = "0x185D93860")]
	[AsyncStateMachine(typeof(EMMABMDPPGP))]
	private Task<MJPLDIOAJAH> MIFECIOCFIK(byte[] FICEFCGCCDN, CancellationToken OKPCBPJCBCJ, CMFLPAKKNOD BONKEPDJHCI, CMFLPAKKNOD FMOHOOJLEDF, TimeSpan? PLAFBEKJCGI, Stopwatch EINCEAFBMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D914F0", Offset = "0x5D900F0", VA = "0x185D914F0")]
	[AsyncStateMachine(typeof(CKMMIEEHDKN))]
	private Task<MJPLDIOAJAH> CKGHICDNMEJ(byte[] FICEFCGCCDN, CancellationToken OKPCBPJCBCJ, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, [Optional] TimeSpan? JBOENGFCOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D910A0", Offset = "0x5D8FCA0", VA = "0x185D910A0")]
	[AsyncStateMachine(typeof(NEJLDLABNDD))]
	public Task BPKBILPOGDI(CancellationToken CLLGBCLOIHL, Func<CancellationToken, Task> PKIKELLGLNI, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, int EGKGECANAEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E33FD0", Offset = "0x1E32BD0", VA = "0x181E33FD0")]
	[AsyncStateMachine(typeof(ENLMNKEMCIP))]
	public Task<T> BPKBILPOGDI<T>(CancellationToken CLLGBCLOIHL, Func<CancellationToken, Task<T>> PKIKELLGLNI, [Optional] CMFLPAKKNOD BONKEPDJHCI, [Optional] CMFLPAKKNOD FMOHOOJLEDF, int EGKGECANAEN = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E33B80", Offset = "0x1E32780", VA = "0x181E33B80")]
	[AsyncStateMachine(typeof(DIPKNJGBEKJ))]
	private Task<(bool, T)> ACKGJMCCEDG<T>(Guid EBAMGGDFELK, CancellationToken CLLGBCLOIHL, Func<CancellationToken, Task<T>> PKIKELLGLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D91FD0", Offset = "0x5D90BD0", VA = "0x185D91FD0")]
	public void ICBMAKLPKAH(byte LKLNMLJDNFN, int NJLEBONBCID, object MCEKJBECMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D90CB0", Offset = "0x5D8F8B0", VA = "0x185D90CB0")]
	public Guid BLOEFAFJNPG(Guid GGHNKEJJOIN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D90730", Offset = "0x5D8F330", VA = "0x185D90730")]
	public bool AGEHBAFOBGM(GKHADMOPLBF CKFFLNMBIDH, Guid EBAMGGDFELK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D93360", Offset = "0x5D91F60", VA = "0x185D93360")]
	public void KDJLJDFAMNJ(GKHADMOPLBF CKFFLNMBIDH, Guid EBAMGGDFELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D940A0", Offset = "0x5D92CA0", VA = "0x185D940A0")]
	private void NIKKGCLAIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D919A0", Offset = "0x5D905A0", VA = "0x185D919A0")]
	internal HBILACFBIGG FLPFEJEOJJG(bool MFNAMPCNHAB = false)
	{
		return default(HBILACFBIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D92960", Offset = "0x5D91560", VA = "0x185D92960")]
	private HashSet<Guid> IPDCCKDGAKP(GKHADMOPLBF CKFFLNMBIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D944B0", Offset = "0x5D930B0", VA = "0x185D944B0")]
	private void PLNFBFHNCOF(GKHADMOPLBF CKFFLNMBIDH, Guid BEAOEMMHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D940B0", Offset = "0x5D92CB0", VA = "0x185D940B0")]
	private void NLEANLCBLHJ(GKHADMOPLBF CKFFLNMBIDH, Guid BEAOEMMHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D90680", Offset = "0x5D8F280", VA = "0x185D90680")]
	public static Func<Guid, bool> AADNHCNDLPD(Guid BEAOEMMHBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D93A10", Offset = "0x5D92610", VA = "0x185D93A10")]
	public static Func<Guid, bool> NBDPDCGMFLO(Guid BEAOEMMHBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D93750", Offset = "0x5D92350", VA = "0x185D93750")]
	public void KDONBFNLLGD(GKHADMOPLBF CKFFLNMBIDH, Guid FGOJNBAPFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D91AB0", Offset = "0x5D906B0", VA = "0x185D91AB0")]
	public void HCHKLOCOBPF(GKHADMOPLBF CKFFLNMBIDH, Func<Guid, bool> FJBAJMOKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D94390", Offset = "0x5D92F90", VA = "0x185D94390")]
	private static ExitGames.Client.Photon.Hashtable OMNMGICOIBE(GKHADMOPLBF CKFFLNMBIDH, Guid EECHOEEEOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D92AA0", Offset = "0x5D916A0", VA = "0x185D92AA0")]
	private void JFIENOCDMDL(GKHADMOPLBF CKFFLNMBIDH, Guid EECHOEEEOLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KBGNFONFLKA : KKGGEJLPEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(LDLHPCOIFJP.BKOBPDPDGGP itemType, long totalStopwatchTicks)> JCLIGOBODMD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(LDLHPCOIFJP.BKOBPDPDGGP itemType, long totalStopwatchTicks)> IBMDGNMDLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73A230", Offset = "0x738E30", VA = "0x18073A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D9B120", Offset = "0x5D99D20", VA = "0x185D9B120")]
	public KBGNFONFLKA(TimeSpan JBOENGFCOFI, List<(LDLHPCOIFJP.BKOBPDPDGGP itemType, long totalStopwatchTicks)> JCLIGOBODMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IGNDILOPBJI : CNGAKMMHAFA
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct LGFGOLJCBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid JIDPKFEIKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int ILGELGPFFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int PMPBECMDLNA;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B530", Offset = "0x5D9A130", VA = "0x185D9B530")]
		public LGFGOLJCBNF(Guid AEDIJKNPCAG, int GCPFMKMEGNM, int OENHIKGNKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B260", Offset = "0x5D99E60", VA = "0x185D9B260")]
		public static byte[] ANBECOLJJND(LGFGOLJCBNF DPNJMDFICMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B470", Offset = "0x5D9A070", VA = "0x185D9B470")]
		public static LGFGOLJCBNF PPPEOPKFADK(byte[] FCLGIGIIKEH)
		{
			return default(LGFGOLJCBNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B3F0", Offset = "0x5D99FF0", VA = "0x185D9B3F0")]
		private static byte[] LEFNFJMKKLD(int NFLKAEEEFMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B340", Offset = "0x5D99F40", VA = "0x185D9B340")]
		private static int JPMLGKFLHIJ(byte[] BBNJNGMFOML, int KLEGICPDLIF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid AEDIJKNPCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly AFCKFGFKPJC IJFIMPLLAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool CAAFADENKFC;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D99B00", Offset = "0x5D98700", VA = "0x185D99B00")]
	public IGNDILOPBJI(Guid AEDIJKNPCAG, AFCKFGFKPJC IJFIMPLLAKC, ELCFGCLPODH NKGCEELNNIP, CancellationToken CLLGBCLOIHL, [Optional] BEGKBFPPCIE JAHLNOCNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D99710", Offset = "0x5D98310", VA = "0x185D99710", Slot = "5")]
	protected override void JOPJBPGFINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D99570", Offset = "0x5D98170", VA = "0x185D99570", Slot = "6")]
	protected override void AJJFJKLEEEE(int PFDDGDDJOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D998E0", Offset = "0x5D984E0", VA = "0x185D998E0")]
	private void NJHALLBAHIG(MJPLDIOAJAH JLFOFMDCBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MJPLDIOAJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly HBILACFBIGG NDKGFCILOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte OIBEOCEJOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte FKIIKCPJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool DOCGBAPCGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] IDCANPHMJGF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C830", Offset = "0x5D9B430", VA = "0x185D9C830")]
	public MJPLDIOAJAH(HBILACFBIGG KJGFHIOGHBK, [CanBeNull] byte[] ADEMJHPFLJL, bool KOLFJPCDFAA, byte MGGEPHPMNGN, byte NGMDLLDGLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C690", Offset = "0x5D9B290", VA = "0x185D9C690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D9C4A0", Offset = "0x5D9B0A0", VA = "0x185D9C4A0")]
	private static void BHHDKPALNOA(byte[] ADEMJHPFLJL, StringBuilder LOBJNHKLLCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct HBILACFBIGG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DKOPOEIOLAD : IEnumerable<AHLMFMIIHFH>, IEnumerable, IEnumerator<AHLMFMIIHFH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private AHLMFMIIHFH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HBILACFBIGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HBILACFBIGG <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GKHADMOPLBF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AHLMFMIIHFH System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x37050E0", Offset = "0x3703CE0", VA = "0x1837050E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(AHLMFMIIHFH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5D96E40", Offset = "0x5D95A40", VA = "0x185D96E40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x714D30", Offset = "0x713930", VA = "0x180714D30")]
		[DebuggerHidden]
		public DKOPOEIOLAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D96B70", Offset = "0x5D95770", VA = "0x185D96B70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D96E00", Offset = "0x5D95A00", VA = "0x185D96E00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D96D60", Offset = "0x5D95960", VA = "0x185D96D60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AHLMFMIIHFH> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D96D60", Offset = "0x5D95960", VA = "0x185D96D60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly GKHADMOPLBF AAJALDLEDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] EHCGPONKEAD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D98740", Offset = "0x5D97340", VA = "0x185D98740")]
	public static HBILACFBIGG AAEAIIMNGCF(GKHADMOPLBF CKFFLNMBIDH, Guid LCLJGGIEBAH)
	{
		return default(HBILACFBIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D98CA0", Offset = "0x5D978A0", VA = "0x185D98CA0")]
	public static HBILACFBIGG KLCCBOBEHFH(List<AHLMFMIIHFH> FBGFNGBCDBB)
	{
		return default(HBILACFBIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D98840", Offset = "0x5D97440", VA = "0x185D98840")]
	public static HBILACFBIGG CMELOJDHJPG(GKHADMOPLBF KCDCAKBFKPD, Guid[] LPIDGEKLOMJ)
	{
		return default(HBILACFBIGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D992C0", Offset = "0x5D97EC0", VA = "0x185D992C0")]
	private HBILACFBIGG(GKHADMOPLBF KCDCAKBFKPD, Guid[] LPIDGEKLOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D990C0", Offset = "0x5D97CC0", VA = "0x185D990C0")]
	[IteratorStateMachine(typeof(DKOPOEIOLAD))]
	public IEnumerable<AHLMFMIIHFH> NHEPEMKOIDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D99140", Offset = "0x5D97D40", VA = "0x185D99140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class JOMMPNKHCPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C52E20", Offset = "0x3C51A20", VA = "0x183C52E20", Slot = "4")]
	public void PFDABMNEFNI(T DPNJMDFICMK, IDictionary<object, object> GAGLKGONONJ, bool FGJJNPDDBHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EJFPNDNELOE(T DPNJMDFICMK, IDictionary<object, object> GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T PPPEOPKFADK(IDictionary<object, object> GAGLKGONONJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
	protected JOMMPNKHCPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CNGAKMMHAFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool BEGKBFPPCIE(int MKBECDBLPOF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool JIGLPOGPBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly ELCFGCLPODH CBDMAFPJJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken CLLGBCLOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken KKHJGJBCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly BEGKBFPPCIE JAHLNOCNBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource HFPNIOKEKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource BCHHNKICOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int AIJLJJANAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool JPIJKHFCOAA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken JJMIFFGDMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D95460", Offset = "0x5D94060", VA = "0x185D95460")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GLNBNEFNEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D95650", Offset = "0x5D94250", VA = "0x185D95650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D956A0", Offset = "0x5D942A0", VA = "0x185D956A0")]
	public CNGAKMMHAFA(ELCFGCLPODH NKGCEELNNIP, CancellationToken CLLGBCLOIHL, [Optional] BEGKBFPPCIE JAHLNOCNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D95440", Offset = "0x5D94040", VA = "0x185D95440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D95520", Offset = "0x5D94120", VA = "0x185D95520", Slot = "5")]
	protected virtual void JOPJBPGFINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D95480", Offset = "0x5D94080", VA = "0x185D95480")]
	private void GHBHIMJDNGM(JCBHONMOFEO IFBJKHAEMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D955F0", Offset = "0x5D941F0", VA = "0x185D955F0")]
	protected void KCIJKCFBANH(int PFDDGDDJOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D95420", Offset = "0x5D94020", VA = "0x185D95420", Slot = "6")]
	protected virtual void AJJFJKLEEEE(int PFDDGDDJOEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct AHLMFMIIHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly GKHADMOPLBF MCNPPBBDNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid ALAGLKBHMPK;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD160", Offset = "0x4DBBD60", VA = "0x184DBD160")]
	public AHLMFMIIHFH(GKHADMOPLBF CKFFLNMBIDH, Guid EBAMGGDFELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D94E50", Offset = "0x5D93A50", VA = "0x185D94E50")]
	public bool MNDEPBAJPKN(AHLMFMIIHFH GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D94D60", Offset = "0x5D93960", VA = "0x185D94D60", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D94E20", Offset = "0x5D93A20", VA = "0x185D94E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum GKHADMOPLBF : byte
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
internal static class EAHMGPECKLG
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly GKHADMOPLBF[] HKIOBNCFALG;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D96E90", Offset = "0x5D95A90", VA = "0x185D96E90")]
	public static int OCCDBDEHALO(GKHADMOPLBF CKFFLNMBIDH)
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
