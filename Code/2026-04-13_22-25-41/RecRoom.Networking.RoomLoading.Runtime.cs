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
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Networking.DataTypes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9964840", Offset = "0x9963240", VA = "0x189964840")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Networking.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class QOJDMJHJLAB : LRYDFTJTPMZ<BufferedMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BFGCHHTGJIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDictionary<object, object> GEHCEZHJWAY;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public BFGCHHTGJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x995ED60", Offset = "0x995D760", VA = "0x18995ED60")]
			internal object WIMZBMUJMGL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal static readonly string[] BZVMDLBFWFM;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly QOJDMJHJLAB UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9965540", Offset = "0x9963F40", VA = "0x189965540", Slot = "5")]
		protected override void VYJSTEFQWGG(BufferedMessage a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9964AF0", Offset = "0x99634F0", VA = "0x189964AF0", Slot = "6")]
		public override BufferedMessage Deserialize(IDictionary<object, object> data)
		{
			return default(BufferedMessage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9965A40", Offset = "0x9964440", VA = "0x189965A40")]
		public QOJDMJHJLAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HDJSOXJOQNX
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate string PayloadTraceFormatter([NotNull] byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public readonly struct BufferedMessage<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly CombinedSlice CombinedSlice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly bool IsMasterSwitchMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly T Payload;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x50B6670", Offset = "0x50B5070", VA = "0x1850B6670")]
			public static BufferedMessage<T> RKQVUGEIKUS(BufferedMessage a, Func<byte[], T> b)
			{
				return default(BufferedMessage<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x50B6E90", Offset = "0x50B5890", VA = "0x1850B6E90")]
			public BufferedMessage(CombinedSlice combinedSlice, T payload, bool isMasterSwitchMessage = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x50B6C20", Offset = "0x50B5620", VA = "0x1850B6C20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ABJGFSQWZBQ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class WLUGBDBSDJT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public TaskCompletionSource<BufferedMessage> KKCPQCUEYSD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public ABJGFSQWZBQ DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
				public WLUGBDBSDJT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x996A870", Offset = "0x9969270", VA = "0x18996A870")]
				internal void LGDWMUMONGY(BufferedMessage a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x996A9C0", Offset = "0x99693C0", VA = "0x18996A9C0")]
				internal void YKFCAKVZCVC(string a, long b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x996A8E0", Offset = "0x99692E0", VA = "0x18996A8E0")]
				internal BufferedEventReceiveTimeoutException OFTWDCPVOTT(TimeSpan a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class WLOZDWHUTYK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public string HNRLUWEOSRF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public long DMRXGYGLRGR;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
				public WLOZDWHUTYK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x996A7D0", Offset = "0x99691D0", VA = "0x18996A7D0")]
				internal object OFOPFVVYFIK()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class JRFIKRCKNGU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public SliceType ZWYZIZOBNCC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Guid CHFCRKUIPAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public int LJZYSSLFFZQ;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
				public JRFIKRCKNGU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x9964260", Offset = "0x9962C60", VA = "0x189964260")]
				internal bool ZRKJBHCMKCR(BufferedMessage a)
				{
					return default(bool);
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private struct <AwaitNextMessage>d__10 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public AsyncTaskMethodBuilder<BufferedMessage> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ABJGFSQWZBQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public TimeSpan timeout;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private WLUGBDBSDJT <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private TaskAwaiter<BufferedMessage> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x9966430", Offset = "0x9964E30", VA = "0x189966430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9966C50", Offset = "0x9965650", VA = "0x189966C50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private readonly WAQFCQLRXNB CRARBJPQPYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly string IVDKDHOIMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly List<BufferedMessage> SFJRMCXAIDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private List<(string, long totalStopwatchTicks)> KJMDGBLCZCE;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool EJRRYLKGJEE
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x995EA40", Offset = "0x995D440", VA = "0x18995EA40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			private event Action<BufferedMessage> VDOUNUJPIDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x995E7A0", Offset = "0x995D1A0", VA = "0x18995E7A0")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x995E850", Offset = "0x995D250", VA = "0x18995E850")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x995EC60", Offset = "0x995D660", VA = "0x18995EC60")]
			public ABJGFSQWZBQ(WAQFCQLRXNB a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x995E900", Offset = "0x995D300", VA = "0x18995E900")]
			[AsyncStateMachine(typeof(<AwaitNextMessage>d__10))]
			public Task<BufferedMessage> TUZLPWJLHSO(CancellationToken a, TimeSpan b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x995EBB0", Offset = "0x995D5B0", VA = "0x18995EBB0")]
			public void XFDHRADCVUB(BufferedMessage a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x995E740", Offset = "0x995D140", VA = "0x18995E740", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x995EA90", Offset = "0x995D490", VA = "0x18995EA90")]
			public void WZVBHBJMYNH(SliceType a, Guid b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NSPBPFWQIHX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public TimeSpan ATGTGSTETVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public HDJSOXJOQNX DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> YDLQGGMRTZK;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public NSPBPFWQIHX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9964620", Offset = "0x9963020", VA = "0x189964620")]
			internal bool INHTAONZTEO(int a, TimeSpan b, TimeSpan c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9964710", Offset = "0x9963110", VA = "0x189964710")]
			internal bool WNWSNSHVPVQ(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class XKXJREZMWEQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				public XKXJREZMWEQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x9969770", Offset = "0x9968170", VA = "0x189969770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9969920", Offset = "0x9968320", VA = "0x189969920", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Func<CancellationToken, Task> CAOJLLIRRTQ;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public XKXJREZMWEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x996AC40", Offset = "0x9969640", VA = "0x18996AC40")]
			[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
			internal Task<bool> RHEGMIEBYDX(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HTCOQUHFBNP<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Func<Guid, bool> MRIJJBARIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public Guid SWOAKQWDSPJ;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public HTCOQUHFBNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x647D880", Offset = "0x647C280", VA = "0x18647D880")]
			internal bool MMOTQGCUPWP(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ZREJSMQIMLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public Dictionary<object, object> MTSIVAAIAPK;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public ZREJSMQIMLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x996B200", Offset = "0x9969C00", VA = "0x18996B200")]
			internal object XTQGTEESFYE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x996B250", Offset = "0x9969C50", VA = "0x18996B250")]
			internal object XTVNQKYPPJN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JBJVEBURCHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public SliceType ZWYZIZOBNCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public Guid SWOAKQWDSPJ;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public JBJVEBURCHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x99641C0", Offset = "0x9962BC0", VA = "0x1899641C0")]
			internal object FPWZGGOAZFL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class NUVRKGMFIGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public SliceType ZWYZIZOBNCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public Guid SWOAKQWDSPJ;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public NUVRKGMFIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x99647A0", Offset = "0x99631A0", VA = "0x1899647A0")]
			internal object IFMJWONTUWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LFGYZMWMHTR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public Guid CHFCRKUIPAB;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LFGYZMWMHTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9964300", Offset = "0x9962D00", VA = "0x189964300")]
			internal object TCOEZIATKBF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PVEMMDQTAIS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Guid CHFCRKUIPAB;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public PVEMMDQTAIS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9964A80", Offset = "0x9963480", VA = "0x189964A80")]
			internal object YBRJKLKOHEK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class LBSQFYZEUKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public Guid CHFCRKUIPAB;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LBSQFYZEUKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x99642D0", Offset = "0x9962CD0", VA = "0x1899642D0")]
			internal bool LODQRLPJGIT(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class UHIMSUEDZWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Guid CHFCRKUIPAB;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UHIMSUEDZWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x29487C0", Offset = "0x29471C0", VA = "0x1829487C0")]
			internal bool EXJMGDOZPPX(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class OYBLYKBVHUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Func<Guid, bool> DXSOPSPYHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<Guid, bool> QJWVFRBYOIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Func<Guid, bool> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public OYBLYKBVHUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9964A10", Offset = "0x9963410", VA = "0x189964A10")]
			internal bool BGFOQLFWCPN(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9964A10", Offset = "0x9963410", VA = "0x189964A10")]
			internal bool BGKVNRZTMAW(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OYGSVQVSRFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Guid QRVRTTEGYJB;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public OYGSVQVSRFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9964A50", Offset = "0x9963450", VA = "0x189964A50")]
			internal bool BGAHTELYTEE(Slice a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ZOGHFCXRNGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Guid QRVRTTEGYJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Dictionary<object, object> UUYURFGSWXG;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public ZOGHFCXRNGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x996AFE0", Offset = "0x99699E0", VA = "0x18996AFE0")]
			internal object AVXQPKGBAOR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x996AD50", Offset = "0x9969750", VA = "0x18996AD50")]
			internal object AVHVXPYIYGQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x996AF70", Offset = "0x9969970", VA = "0x18996AF70")]
			internal object AVSJSDMDRDI()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Func<CancellationToken, Task> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Func<Guid, bool> blockCompletionLookup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9966CC0", Offset = "0x99656C0", VA = "0x189966CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9966F50", Offset = "0x9965950", VA = "0x189966F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__32<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Func<Guid, bool> blockCompletionLookup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private Guid <sliceId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<Guid> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private TaskAwaiter<(bool, T)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6943790", Offset = "0x6942190", VA = "0x186943790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6944CA0", Offset = "0x69436A0", VA = "0x186944CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <MasterSendAllReceiveMessage>d__27<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AsyncTaskMethodBuilder<BufferedMessage<T>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Func<T, byte[]> serializer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public T messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Func<byte[], T> deserializer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6945A90", Offset = "0x6944490", VA = "0x186945A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6945E20", Offset = "0x6944820", VA = "0x186945E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <MasterSendAllReceiveMessage>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AsyncTaskMethodBuilder<BufferedMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private Stopwatch <sw>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <frameStart>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9966FB0", Offset = "0x99659B0", VA = "0x189966FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9967810", Offset = "0x9966210", VA = "0x189967810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <MasterSendReceiveSimple>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AsyncTaskMethodBuilder<BufferedMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9967880", Offset = "0x9966280", VA = "0x189967880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9967CC0", Offset = "0x99666C0", VA = "0x189967CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <MasterSendReceiveWithRetries>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AsyncTaskMethodBuilder<BufferedMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Func<bool> hasBlockBeenCompleted;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public TimeSpan? timeoutOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private NSPBPFWQIHX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Stopwatch elapsedStopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private UIMGUQBRJXZ <masterSwitchScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9967D30", Offset = "0x9966730", VA = "0x189967D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9968860", Offset = "0x9967260", VA = "0x189968860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <ReceiveBuffered>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncTaskMethodBuilder<BufferedMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public TimeSpan? timeoutOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x99688D0", Offset = "0x99672D0", VA = "0x1899688D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x99692A0", Offset = "0x9967CA0", VA = "0x1899692A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <SyncGuid>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder<Guid> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public Guid proposedGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<BufferedMessage<Guid>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9969310", Offset = "0x9967D10", VA = "0x189969310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9969700", Offset = "0x9968100", VA = "0x189969700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct <TryRunMasterLockedBlock>d__33<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder<(bool, T)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public Func<Guid, bool> blockCompletionLookup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public Guid sliceId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public HDJSOXJOQNX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private HTCOQUHFBNP<T> <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public HUEZKUZYOFE unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public HUEZKUZYOFE pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool <isRootMasterBlockSlice>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private SBIXPKPBXLI <masterSwitchTokenScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private T <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<BufferedMessage<Guid>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7061A60", Offset = "0x7060460", VA = "0x187061A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x70659B0", Offset = "0x70643B0", VA = "0x1870659B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly PayloadTraceFormatter WKISKXANJKQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Dictionary<object, object> EEVUXWRAZNH;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly SVLVGVMSMLM XOVPEDKBVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly ABJGFSQWZBQ SLUGYMQJKWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly WAQFCQLRXNB CRARBJPQPYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly UOPCXDWXRCN DHXMWWVJVXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly HWFXACOITXO BFNZCZOOJVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly PayloadTraceFormatter PJUSXQIMRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool INFOAPNSOCD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly TimeSpan ZQJJLMXLZBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TimeSpan GWBZLGROAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private byte DGEIGNADDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<Guid>[] NXMVRIDXNXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Slice> ADJLVETSTVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CombinedSlice? LIYHIASGWOT;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly SVLVGVMSMLM UPKLYNMUYCP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly SVLVGVMSMLM IYFWKLTCIKL;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal event Action<BufferedMessage> BCOYNHJMLFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9960090", Offset = "0x995EA90", VA = "0x189960090")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99620F0", Offset = "0x9960AF0", VA = "0x1899620F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9963D40", Offset = "0x9962740", VA = "0x189963D40")]
		public HDJSOXJOQNX(WAQFCQLRXNB a, UOPCXDWXRCN b, HWFXACOITXO c, [Optional] TimeSpan? d, [Optional] PayloadTraceFormatter e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AED640", Offset = "0x3AEC040", VA = "0x183AED640")]
		public static HDJSOXJOQNX AUPBJFACDYP<a>(a a, [Optional] TimeSpan? b, [Optional] PayloadTraceFormatter c) where a : WAQFCQLRXNB, UOPCXDWXRCN, HWFXACOITXO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99602A0", Offset = "0x995ECA0", VA = "0x1899602A0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9961950", Offset = "0x9960350", VA = "0x189961950")]
		private byte JSZVJDQABPP()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9962950", Offset = "0x9961350", VA = "0x189962950")]
		private TimeSpan WNGWFSSPWXR(TimeSpan? a, int b = 1)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE670", Offset = "0x3AED070", VA = "0x183AEE670")]
		public bool KMBLAPODCHD<b>(b a, Func<b, byte[]> b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9961960", Offset = "0x9960360", VA = "0x189961960")]
		public bool KMBLAPODCHD(byte[] a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF80B0", VA = "0x180DF96B0")]
		private static string WUBGCDOCOJN(string a, string b = "yellow")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9961650", Offset = "0x9960050", VA = "0x189961650")]
		[AsyncStateMachine(typeof(<ReceiveBuffered>d__25))]
		public Task<BufferedMessage> HLWVEHPUBXI(CancellationToken a, [Optional] HUEZKUZYOFE b, [Optional] HUEZKUZYOFE c, [Optional] TimeSpan? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99627D0", Offset = "0x99611D0", VA = "0x1899627D0")]
		[AsyncStateMachine(typeof(<SyncGuid>d__26))]
		public Task<Guid> VHWVJRKGQPI(Guid a, CancellationToken b, [Optional] HUEZKUZYOFE c, [Optional] HUEZKUZYOFE d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE730", Offset = "0x3AED130", VA = "0x183AEE730")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__27<>))]
		public Task<BufferedMessage<c>> SXYECTJLEIT<c>(c a, Func<c, byte[]> b, Func<byte[], c> c, CancellationToken d, [Optional] HUEZKUZYOFE e, [Optional] HUEZKUZYOFE f, [Optional] TimeSpan? g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9962360", Offset = "0x9960D60", VA = "0x189962360")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__28))]
		public Task<BufferedMessage> SXYECTJLEIT(byte[] a, CancellationToken b, [Optional] HUEZKUZYOFE c, [Optional] HUEZKUZYOFE d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99617B0", Offset = "0x99601B0", VA = "0x1899617B0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveWithRetries>d__29))]
		private Task<BufferedMessage> IZKDYAQVVFX(byte[] a, CancellationToken b, HUEZKUZYOFE c, HUEZKUZYOFE d, TimeSpan? e, Stopwatch f, [Optional] Func<bool> g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99624E0", Offset = "0x9960EE0", VA = "0x1899624E0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveSimple>d__30))]
		private Task<BufferedMessage> TNCOZCQURMX(byte[] a, CancellationToken b, [Optional] HUEZKUZYOFE c, [Optional] HUEZKUZYOFE d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9960140", Offset = "0x995EB40", VA = "0x189960140")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__31))]
		public Task DFCEDMNQHOB(CancellationToken a, Func<CancellationToken, Task> b, [Optional] HUEZKUZYOFE c, [Optional] HUEZKUZYOFE d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AED6E0", Offset = "0x3AEC0E0", VA = "0x183AED6E0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__32<>))]
		public Task<d> DFCEDMNQHOB<d>(CancellationToken a, Func<CancellationToken, Task<d>> b, [Optional] HUEZKUZYOFE c, [Optional] HUEZKUZYOFE d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDCB0", Offset = "0x3AEC6B0", VA = "0x183AEDCB0")]
		[AsyncStateMachine(typeof(<TryRunMasterLockedBlock>d__33<>))]
		private Task<(bool, e)> FPJMXRUCHCX<e>(Guid a, CancellationToken b, Func<CancellationToken, Task<e>> c, [Optional] HUEZKUZYOFE d, [Optional] HUEZKUZYOFE e, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99603B0", Offset = "0x995EDB0", VA = "0x1899603B0")]
		public void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9962650", Offset = "0x9961050", VA = "0x189962650")]
		public Guid UKNRFJUKHMS(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99634C0", Offset = "0x9961EC0", VA = "0x1899634C0")]
		public bool ZXUSWQUMYOB(SliceType a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99612D0", Offset = "0x995FCD0", VA = "0x1899612D0")]
		public void GVCKKGZOGPD(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9962940", Offset = "0x9961340", VA = "0x189962940")]
		private void WMJCMMVEQFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9961FE0", Offset = "0x99609E0", VA = "0x189961FE0")]
		internal CombinedSlice ONMVFEBCCAT(bool a = false)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9961ED0", Offset = "0x99608D0", VA = "0x189961ED0")]
		private HashSet<Guid> NDWZQOXTQLB(SliceType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99621A0", Offset = "0x9960BA0", VA = "0x1899621A0")]
		private void RXZBWFDAKLR(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x995FDD0", Offset = "0x995E7D0", VA = "0x18995FDD0")]
		private void BVURFGDWMRW(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9962C80", Offset = "0x9961680", VA = "0x189962C80")]
		public static Func<Guid, bool> YSNMCEECVZN(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x995FD30", Offset = "0x995E730", VA = "0x18995FD30")]
		public static Func<Guid, bool> BVIACZNRYPP(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9962B80", Offset = "0x9961580", VA = "0x189962B80")]
		public void WZVBHBJMYNH(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9960D90", Offset = "0x995F790", VA = "0x189960D90")]
		public void GOJQKYNIQUV(SliceType a, Func<Guid, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9962D20", Offset = "0x9961720", VA = "0x189962D20")]
		private static Dictionary<object, object> YZDHMOISEVM(SliceType a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9962E40", Offset = "0x9961840", VA = "0x189962E40")]
		private void ZPGFLXJYTOE(SliceType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BufferedEventReceiveTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<(string itemType, long totalStopwatchTicks)> NWOQQOOQEZV;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<(string itemType, long totalStopwatchTicks)> ProcessedActions
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6800", VA = "0x180CF7E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x995EDB0", Offset = "0x995D7B0", VA = "0x18995EDB0")]
		public BufferedEventReceiveTimeoutException(TimeSpan timeout, List<(string itemType, long totalStopwatchTicks)> processedActions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SBIXPKPBXLI : UIMGUQBRJXZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct MasterSwitchMessage
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public readonly Guid TransactionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public readonly int NewMasterActorNumber;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public readonly int SenderActorNumber;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9964610", Offset = "0x9963010", VA = "0x189964610")]
			public MasterSwitchMessage(Guid transactionId, int senderActorNumber, int newMasterActorNumber)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9964470", Offset = "0x9962E70", VA = "0x189964470")]
			public static byte[] GHRXOLGFAHI(MasterSwitchMessage a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9964370", Offset = "0x9962D70", VA = "0x189964370")]
			public static MasterSwitchMessage Deserialize(byte[] bytes)
			{
				return default(MasterSwitchMessage);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9964580", Offset = "0x9962F80", VA = "0x189964580")]
			private static byte[] RRDDCWFSCMD(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x99645C0", Offset = "0x9962FC0", VA = "0x1899645C0")]
			private static int XPJVHPJIREP(byte[] a, int b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly Guid WMDSWPJYJVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly HDJSOXJOQNX ZPOVIJMPSGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool WNWPUPXFGQY;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9965FE0", Offset = "0x99649E0", VA = "0x189965FE0")]
		public SBIXPKPBXLI(Guid a, HDJSOXJOQNX b, HWFXACOITXO c, CancellationToken d, [Optional] ShouldCancelForNewMaster e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9965C40", Offset = "0x9964640", VA = "0x189965C40", Slot = "5")]
		protected override void WCFLDSFNRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9965DF0", Offset = "0x99647F0", VA = "0x189965DF0", Slot = "6")]
		protected override void YKCKIASSLSX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9965A80", Offset = "0x9964480", VA = "0x189965A80")]
		private void BCOYNHJMLFA(BufferedMessage a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct BufferedMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly CombinedSlice CombinedSlice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly byte SenderIdByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly byte MessageIdByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly bool IsMasterSwitchMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x995F1B0", Offset = "0x995DBB0", VA = "0x18995F1B0")]
		public BufferedMessage(CombinedSlice combinedSlice, [CanBeNull] byte[] payload, bool isMasterSwitchMessage, byte senderIdByte, byte messageIdByte)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x995F020", Offset = "0x995DA20", VA = "0x18995F020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x995EE30", Offset = "0x995D830", VA = "0x18995EE30")]
		private static void OJGFOOKLAGK(byte[] a, StringBuilder b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct CombinedSlice
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class TOZLONMMDGH : IEnumerable<Slice>, IEnumerable, IEnumerator<Slice>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private Slice PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CombinedSlice DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public CombinedSlice PSKTUVYPCWT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private SliceType[] MOIGOWZIHVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int MOYBGRHAKDD;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private Slice KHGJZBOBFUF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x23B0EE0", Offset = "0x23AF8E0", VA = "0x1823B0EE0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Slice);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x9966230", Offset = "0x9964C30", VA = "0x189966230", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1D01620", Offset = "0x1D00020", VA = "0x181D01620")]
			[DebuggerHidden]
			public TOZLONMMDGH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x99662C0", Offset = "0x9964CC0", VA = "0x1899662C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9966280", Offset = "0x9964C80", VA = "0x189966280", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9966190", Offset = "0x9964B90", VA = "0x189966190", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Slice> EXWKYMXBTJM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9966190", Offset = "0x9964B90", VA = "0x189966190", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly SliceType CombinedSliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly Guid[] SliceIds;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x995FAB0", Offset = "0x995E4B0", VA = "0x18995FAB0")]
		public static CombinedSlice UZEIIPAPXVG(SliceType a, Guid b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x995F5D0", Offset = "0x995DFD0", VA = "0x18995F5D0")]
		public static CombinedSlice HIAVQMLBQKX(List<Slice> a)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x995F290", Offset = "0x995DC90", VA = "0x18995F290")]
		public static CombinedSlice FJIGZSHTSZV(SliceType a, Guid[] b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x995FBA0", Offset = "0x995E5A0", VA = "0x18995FBA0")]
		private CombinedSlice(SliceType combinedSliceType, Guid[] sliceIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x995F210", Offset = "0x995DC10", VA = "0x18995F210")]
		[IteratorStateMachine(typeof(TOZLONMMDGH))]
		public IEnumerable<Slice> CNAAOLXBPRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x995F940", Offset = "0x995E340", VA = "0x18995F940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ULMESMLZMSA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x996A2C0", Offset = "0x9968CC0", VA = "0x18996A2C0")]
		public static string UNCPFDRLNWI(IDictionary<object, object> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class LRYDFTJTPMZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6878FC0", Offset = "0x68779C0", VA = "0x186878FC0", Slot = "4")]
		public void SerializeTo(a message, IDictionary<object, object> data, bool clearBeforeWrite = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void VYJSTEFQWGG(a a, IDictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract a Deserialize(IDictionary<object, object> data);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected LRYDFTJTPMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class UIMGUQBRJXZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate bool ShouldCancelForNewMaster(int masterClientActorNumber);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool IXEHIPWMHET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		protected readonly HWFXACOITXO ODHEGVZHCYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly CancellationToken VGAYJXAXAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly CancellationToken LGHMYOJPZQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ShouldCancelForNewMaster TRFNSQVWOMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CancellationTokenSource GOAJAVZZQXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CancellationTokenSource BILCMAUHFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly int XGOQVEBEJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool FUSPGLPWPGE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CancellationToken SPPDXZHLFGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1B8DEF0", Offset = "0x1B8C8F0", VA = "0x181B8DEF0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BIYYHNWWWMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9969EC0", Offset = "0x99688C0", VA = "0x189969EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x996A130", Offset = "0x9968B30", VA = "0x18996A130")]
		public UIMGUQBRJXZ(HWFXACOITXO a, CancellationToken b, [Optional] ShouldCancelForNewMaster c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9969EA0", Offset = "0x99688A0", VA = "0x189969EA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x996A050", Offset = "0x9968A50", VA = "0x18996A050", Slot = "5")]
		protected virtual void WCFLDSFNRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9969FB0", Offset = "0x99689B0", VA = "0x189969FB0")]
		private void OnMasterClientSwitched(DDFOJMMWCEL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9969F50", Offset = "0x9968950", VA = "0x189969F50")]
		protected void HPNZKHJHCIH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x996A110", Offset = "0x9968B10", VA = "0x18996A110", Slot = "6")]
		protected virtual void YKCKIASSLSX(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Slice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly SliceType SliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly Guid SliceId;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5393780", Offset = "0x5392180", VA = "0x185393780")]
		public Slice(SliceType sliceType, Guid sliceId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9966040", Offset = "0x9964A40", VA = "0x189966040")]
		public bool Equals(Slice other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x99660A0", Offset = "0x9964AA0", VA = "0x1899660A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9966160", Offset = "0x9964B60", VA = "0x189966160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Flags]
	public enum SliceType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		MasterBlock = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class ONOYXHVTWBM
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		internal static readonly SliceType[] BEVIRFPTHRV;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x99648C0", Offset = "0x99632C0", VA = "0x1899648C0")]
		public static int XEMTTIUTKRQ(SliceType a)
		{
			return default(int);
		}
	}
}
namespace Cpp2IlInjected
{
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
}
