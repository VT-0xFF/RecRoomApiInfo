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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x994EBE0", Offset = "0x994D9E0", VA = "0x18994EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Networking.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class DDKZSTWEZWO : FIRBDKEDXYC<BufferedMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class SFJDTQTBFER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDictionary<object, object> WXWXNEHCUXD;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x994F410", Offset = "0x994E210", VA = "0x18994F410")]
			internal object SMZLQEGCTFK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal static readonly string[] PLOTNQDQEBL;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly DDKZSTWEZWO GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x994D350", Offset = "0x994C150", VA = "0x18994D350", Slot = "5")]
		protected override void XBFAFZPVUGJ(BufferedMessage a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x994C900", Offset = "0x994B700", VA = "0x18994C900", Slot = "6")]
		public override BufferedMessage Deserialize(IDictionary<object, object> data)
		{
			return default(BufferedMessage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x994D850", Offset = "0x994C650", VA = "0x18994D850")]
		public DDKZSTWEZWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CHQSJOHMNWO
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
			[Cpp2IlInjected.Address(RVA = "0x4FD9430", Offset = "0x4FD8230", VA = "0x184FD9430")]
			public static BufferedMessage<T> NPLSBFVZXUJ(BufferedMessage a, Func<byte[], T> b)
			{
				return default(BufferedMessage<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4FD99C0", Offset = "0x4FD87C0", VA = "0x184FD99C0")]
			public BufferedMessage(CombinedSlice combinedSlice, T payload, bool isMasterSwitchMessage = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4FD94F0", Offset = "0x4FD82F0", VA = "0x184FD94F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class FJYPZRIWLSP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class WYUZZVKPLDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public TaskCompletionSource<BufferedMessage> WHWAWPVBYAW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public FJYPZRIWLSP XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public WYUZZVKPLDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x9953100", Offset = "0x9951F00", VA = "0x189953100")]
				internal void CHJQGLRXQVJ(BufferedMessage a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x9953250", Offset = "0x9952050", VA = "0x189953250")]
				internal void LKQJFWPFZUD(string a, long b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9953170", Offset = "0x9951F70", VA = "0x189953170")]
				internal BufferedEventReceiveTimeoutException IOIRUPVREXG(TimeSpan a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class WZAGXCEMUOR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public string JYXNGJLNCZY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public long EFCQRCXLWDQ;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public WZAGXCEMUOR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x99534D0", Offset = "0x99522D0", VA = "0x1899534D0")]
				internal object IONYRWPOOIP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class SIXMNEQISOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public SliceType TRXBLHYMAOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Guid TJCXSZDZKKY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public int BQIKNQMLJRF;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public SIXMNEQISOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x994F460", Offset = "0x994E260", VA = "0x18994F460")]
				internal bool BKMMODCGKCM(BufferedMessage a)
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
				public FJYPZRIWLSP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public TimeSpan timeout;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private WYUZZVKPLDI <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private TaskAwaiter<BufferedMessage> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x994F690", Offset = "0x994E490", VA = "0x18994F690", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x994FEB0", Offset = "0x994ECB0", VA = "0x18994FEB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private readonly AZZOGUSWEIC VBFBHCWUJZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly string NWYHAQWMSQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly List<BufferedMessage> OOMGYQLWWTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private List<(string, long totalStopwatchTicks)> BMYTEZXAJOZ;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool HKACVYECYEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x994DBE0", Offset = "0x994C9E0", VA = "0x18994DBE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			private event Action<BufferedMessage> THLQHIQDEGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x994D960", Offset = "0x994C760", VA = "0x18994D960")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x994DC30", Offset = "0x994CA30", VA = "0x18994DC30")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x994DE20", Offset = "0x994CC20", VA = "0x18994DE20")]
			public FJYPZRIWLSP(AZZOGUSWEIC a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x994DCE0", Offset = "0x994CAE0", VA = "0x18994DCE0")]
			[AsyncStateMachine(typeof(<AwaitNextMessage>d__10))]
			public Task<BufferedMessage> YORIEUHDLBV(CancellationToken a, TimeSpan b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x994DA10", Offset = "0x994C810", VA = "0x18994DA10")]
			public void KFZJMEDYOXI(BufferedMessage a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x994D900", Offset = "0x994C700", VA = "0x18994D900", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x994DAC0", Offset = "0x994C8C0", VA = "0x18994DAC0")]
			public void QEOGNQGIJZO(SliceType a, Guid b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FSAELSPRGFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public TimeSpan OWEXDIAQZYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public CHQSJOHMNWO XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> CRTAOQVNPGT;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FSAELSPRGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x994DFC0", Offset = "0x994CDC0", VA = "0x18994DFC0")]
			internal bool VKUSMGAFFIZ(int a, TimeSpan b, TimeSpan c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x994E0B0", Offset = "0x994CEB0", VA = "0x18994E0B0")]
			internal bool ZGCOOYBMHGT(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class YQFWVSBGPST
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
				public YQFWVSBGPST <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x99529D0", Offset = "0x99517D0", VA = "0x1899529D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9952B80", Offset = "0x9951980", VA = "0x189952B80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Func<CancellationToken, Task> ILXYROTEVOB;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YQFWVSBGPST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9953570", Offset = "0x9952370", VA = "0x189953570")]
			[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
			internal Task<bool> MJCLXJPEHES(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PSJEAXPAEOG<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Func<Guid, bool> AVEWRGBXQCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public Guid KXIGCNORNOA;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public PSJEAXPAEOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x73B7160", Offset = "0x73B5F60", VA = "0x1873B7160")]
			internal bool MWWFGNTBBHO(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ZTAPQDVUGTO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public Dictionary<object, object> XZXERBSZYLV;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZTAPQDVUGTO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9953BE0", Offset = "0x99529E0", VA = "0x189953BE0")]
			internal object CTVEUPHHUKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9953B90", Offset = "0x9952990", VA = "0x189953B90")]
			internal object CTPXXINKKYU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JBZQKAOMTYU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public SliceType TRXBLHYMAOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public Guid KXIGCNORNOA;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public JBZQKAOMTYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x994E5F0", Offset = "0x994D3F0", VA = "0x18994E5F0")]
			internal object NDYBOYYHJZI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FPTOQSACGGX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public SliceType TRXBLHYMAOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public Guid KXIGCNORNOA;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FPTOQSACGGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x994DF20", Offset = "0x994CD20", VA = "0x18994DF20")]
			internal object PNWZHYEWJQY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class RYQFGLCIRJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public Guid TJCXSZDZKKY;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public RYQFGLCIRJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x994F3A0", Offset = "0x994E1A0", VA = "0x18994F3A0")]
			internal object IQHJNXMDYDY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EZRPNFOJXLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Guid TJCXSZDZKKY;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public EZRPNFOJXLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x994D890", Offset = "0x994C690", VA = "0x18994D890")]
			internal object KDCNEJLEGCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class RVBWMXFBDZU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public Guid TJCXSZDZKKY;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public RVBWMXFBDZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x994F370", Offset = "0x994E170", VA = "0x18994F370")]
			internal bool KWXRAKUHJBE(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class QPNVFDFTLRO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Guid TJCXSZDZKKY;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QPNVFDFTLRO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x29409C0", Offset = "0x293F7C0", VA = "0x1829409C0")]
			internal bool LCARHZLKLRA(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class TFCNPWVMMEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Func<Guid, bool> NVPTAEAQCOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<Guid, bool> EQKVMIGZOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Func<Guid, bool> EQFOPBNCEPZ;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public TFCNPWVMMEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x994F650", Offset = "0x994E450", VA = "0x18994F650")]
			internal bool MZRGONJHMJW(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x994F650", Offset = "0x994E450", VA = "0x18994F650")]
			internal bool NAHBGHQZORX(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class TEXGSQBPCSS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Guid EAGJSSXEHMY;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public TEXGSQBPCSS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x994F620", Offset = "0x994E420", VA = "0x18994F620")]
			internal bool MZWNLUDEVVF(Slice a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IVKEZMMJWRD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Guid EAGJSSXEHMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Dictionary<object, object> ZSYOXDKHQRT;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public IVKEZMMJWRD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x994E140", Offset = "0x994CF40", VA = "0x18994E140")]
			internal object CRIHVTXFYAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x994E3D0", Offset = "0x994D1D0", VA = "0x18994E3D0")]
			internal object CRYCNOEYAIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x994E360", Offset = "0x994D160", VA = "0x18994E360")]
			internal object CRNOTARDHLR()
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public FHXCPEDPGPT pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x994FF20", Offset = "0x994ED20", VA = "0x18994FF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99501B0", Offset = "0x994EFB0", VA = "0x1899501B0", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public FHXCPEDPGPT pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x6952F10", Offset = "0x6951D10", VA = "0x186952F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6954420", Offset = "0x6953220", VA = "0x186954420", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public FHXCPEDPGPT pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x6954590", Offset = "0x6953390", VA = "0x186954590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x69555A0", Offset = "0x69543A0", VA = "0x1869555A0", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public FHXCPEDPGPT pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x9950210", Offset = "0x994F010", VA = "0x189950210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9950A70", Offset = "0x994F870", VA = "0x189950A70", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public FHXCPEDPGPT pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9950AE0", Offset = "0x994F8E0", VA = "0x189950AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9950F20", Offset = "0x994FD20", VA = "0x189950F20", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

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
			private FSAELSPRGFE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public FHXCPEDPGPT pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Stopwatch elapsedStopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private COAXLPFEKHS <masterSwitchScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9950F90", Offset = "0x994FD90", VA = "0x189950F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9951AC0", Offset = "0x99508C0", VA = "0x189951AC0", Slot = "5")]
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
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public TimeSpan? timeoutOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public FHXCPEDPGPT pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9951B30", Offset = "0x9950930", VA = "0x189951B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9952500", Offset = "0x9951300", VA = "0x189952500", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public Guid proposedGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public FHXCPEDPGPT pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<BufferedMessage<Guid>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9952570", Offset = "0x9951370", VA = "0x189952570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9952960", Offset = "0x9951760", VA = "0x189952960", Slot = "5")]
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
			public CHQSJOHMNWO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private PSJEAXPAEOG<T> <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public FHXCPEDPGPT unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public FHXCPEDPGPT pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool <isRootMasterBlockSlice>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private QDZTVIZMXRT <masterSwitchTokenScope>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x70747D0", Offset = "0x70735D0", VA = "0x1870747D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7077C30", Offset = "0x7076A30", VA = "0x187077C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly PayloadTraceFormatter SZCGQAWCEQR;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Dictionary<object, object> HQXKLJZWALW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly OGEXSFQHDBH ONYPZFOXLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly FJYPZRIWLSP RJDNDVOSKSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly AZZOGUSWEIC VBFBHCWUJZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly RLWMQWFLYVW IMJGPGAMMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly JAGUJUYUPEX MFYRRVZCEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly PayloadTraceFormatter VKPUVECHJWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool ICYNOWPKTPY;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly TimeSpan VRVWMCLAJEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TimeSpan VSLTNURBFCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private byte QHDQORYCHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<Guid>[] NCXRSEHDPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Slice> ONSYSDZODUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CombinedSlice? FWLKWOVTPTQ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly OGEXSFQHDBH PUICWCULXGM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly OGEXSFQHDBH KZQZTQYISUQ;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal event Action<BufferedMessage> YTGGTXSHQNX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9947530", Offset = "0x9946330", VA = "0x189947530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9949780", Offset = "0x9948580", VA = "0x189949780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x994B540", Offset = "0x994A340", VA = "0x18994B540")]
		public CHQSJOHMNWO(AZZOGUSWEIC a, RLWMQWFLYVW b, JAGUJUYUPEX c, [Optional] TimeSpan? d, [Optional] PayloadTraceFormatter e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37DA850", Offset = "0x37D9650", VA = "0x1837DA850")]
		public static CHQSJOHMNWO WYDPQSPQVQA<a>(a a, [Optional] TimeSpan? b, [Optional] PayloadTraceFormatter c) where a : AZZOGUSWEIC, RLWMQWFLYVW, JAGUJUYUPEX
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9948140", Offset = "0x9946F40", VA = "0x189948140")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9949BB0", Offset = "0x99489B0", VA = "0x189949BB0")]
		private byte MZPNNVLYJSU()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x994A720", Offset = "0x9949520", VA = "0x18994A720")]
		private TimeSpan SRBRDIDOUEO(TimeSpan? a, int b = 1)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37D98D0", Offset = "0x37D86D0", VA = "0x1837D98D0")]
		public bool OLHJDJPWUJO<b>(b a, Func<b, byte[]> b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9949D30", Offset = "0x9948B30", VA = "0x189949D30")]
		public bool OLHJDJPWUJO(byte[] a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		private static string VRWTYAQYDZS(string a, string b = "yellow")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x994B0C0", Offset = "0x9949EC0", VA = "0x18994B0C0")]
		[AsyncStateMachine(typeof(<ReceiveBuffered>d__25))]
		public Task<BufferedMessage> ZSFSEDTDHCR(CancellationToken a, [Optional] FHXCPEDPGPT b, [Optional] FHXCPEDPGPT c, [Optional] TimeSpan? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99478A0", Offset = "0x99466A0", VA = "0x1899478A0")]
		[AsyncStateMachine(typeof(<SyncGuid>d__26))]
		public Task<Guid> BZFVMGOJMSD(Guid a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37D9990", Offset = "0x37D8790", VA = "0x1837D9990")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__27<>))]
		public Task<BufferedMessage<c>> SFFWNPYOVRO<c>(c a, Func<c, byte[]> b, Func<byte[], c> c, CancellationToken d, [Optional] FHXCPEDPGPT e, [Optional] FHXCPEDPGPT f, [Optional] TimeSpan? g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x994A440", Offset = "0x9949240", VA = "0x18994A440")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__28))]
		public Task<BufferedMessage> SFFWNPYOVRO(byte[] a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99495E0", Offset = "0x99483E0", VA = "0x1899495E0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveWithRetries>d__29))]
		private Task<BufferedMessage> JHUGGUKARCU(byte[] a, CancellationToken b, FHXCPEDPGPT c, FHXCPEDPGPT d, TimeSpan? e, Stopwatch f, [Optional] Func<bool> g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9949BC0", Offset = "0x99489C0", VA = "0x189949BC0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveSimple>d__30))]
		private Task<BufferedMessage> NUIROQCPXHK(byte[] a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x994A5C0", Offset = "0x99493C0", VA = "0x18994A5C0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__31))]
		public Task SGAEMXIJORE(CancellationToken a, Func<CancellationToken, Task> b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37DA0C0", Offset = "0x37D8EC0", VA = "0x1837DA0C0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__32<>))]
		public Task<d> SGAEMXIJORE<d>(CancellationToken a, Func<CancellationToken, Task<d>> b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37D8F80", Offset = "0x37D7D80", VA = "0x1837D8F80")]
		[AsyncStateMachine(typeof(<TryRunMasterLockedBlock>d__33<>))]
		private Task<(bool, e)> BWQSLXYURRS<e>(Guid a, CancellationToken b, Func<CancellationToken, Task<e>> c, [Optional] FHXCPEDPGPT d, [Optional] FHXCPEDPGPT e, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9948250", Offset = "0x9947050", VA = "0x189948250")]
		public void EWGFALHVYVC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9948C30", Offset = "0x9947A30", VA = "0x189948C30")]
		public Guid FTFNTBVMZQX(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9947BE0", Offset = "0x99469E0", VA = "0x189947BE0")]
		public bool DWBUHBRHBHA(SliceType a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9949830", Offset = "0x9948630", VA = "0x189949830")]
		public void LMOVEPHJPPW(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9947A10", Offset = "0x9946810", VA = "0x189947A10")]
		private void CUGCRIMLYSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99494D0", Offset = "0x99482D0", VA = "0x1899494D0")]
		internal CombinedSlice IVSXNIUYQHM(bool a = false)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x994AA70", Offset = "0x9949870", VA = "0x18994AA70")]
		private HashSet<Guid> YCFRLYXSFJU(SliceType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9947A20", Offset = "0x9946820", VA = "0x189947A20")]
		private void DTSDFFRIDMO(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99475E0", Offset = "0x99463E0", VA = "0x1899475E0")]
		private void BBJOBBFKWDV(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x994A3A0", Offset = "0x99491A0", VA = "0x18994A3A0")]
		public static Func<Guid, bool> QLVGMRPNYFE(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9949430", Offset = "0x9948230", VA = "0x189949430")]
		public static Func<Guid, bool> GXFNJLDHJXA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x994A2A0", Offset = "0x99490A0", VA = "0x18994A2A0")]
		public void QEOGNQGIJZO(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x994AB80", Offset = "0x9949980", VA = "0x18994AB80")]
		public void YOJVRFNTGTY(SliceType a, Func<Guid, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x994A950", Offset = "0x9949750", VA = "0x18994A950")]
		private static Dictionary<object, object> VVFAFLUNXFL(SliceType a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9948DB0", Offset = "0x9947BB0", VA = "0x189948DB0")]
		private void GCWFWMCNXQB(SliceType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BufferedEventReceiveTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<(string itemType, long totalStopwatchTicks)> QMREJQTCZNU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<(string itemType, long totalStopwatchTicks)> ProcessedActions
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF47C0", Offset = "0xCF35C0", VA = "0x180CF47C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99470D0", Offset = "0x9945ED0", VA = "0x1899470D0")]
		public BufferedEventReceiveTimeoutException(TimeSpan timeout, List<(string itemType, long totalStopwatchTicks)> processedActions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class QDZTVIZMXRT : COAXLPFEKHS
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
			[Cpp2IlInjected.Address(RVA = "0x994EBD0", Offset = "0x994D9D0", VA = "0x18994EBD0")]
			public MasterSwitchMessage(Guid transactionId, int senderActorNumber, int newMasterActorNumber)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x994EAC0", Offset = "0x994D8C0", VA = "0x18994EAC0")]
			public static byte[] NYKTBLQYXAJ(MasterSwitchMessage a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x994E930", Offset = "0x994D730", VA = "0x18994E930")]
			public static MasterSwitchMessage Deserialize(byte[] bytes)
			{
				return default(MasterSwitchMessage);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x994EA30", Offset = "0x994D830", VA = "0x18994EA30")]
			private static byte[] FPVWLIYBVIQ(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x994EA70", Offset = "0x994D870", VA = "0x18994EA70")]
			private static int NNIEIDSQSEE(byte[] a, int b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly Guid SMTOVZADDHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CHQSJOHMNWO VTJYKHZQGHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool NZXUOJKDNOJ;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x994F1C0", Offset = "0x994DFC0", VA = "0x18994F1C0")]
		public QDZTVIZMXRT(Guid a, CHQSJOHMNWO b, JAGUJUYUPEX c, CancellationToken d, [Optional] ShouldCancelForNewMaster e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x994EE50", Offset = "0x994DC50", VA = "0x18994EE50", Slot = "5")]
		protected override void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x994EC60", Offset = "0x994DA60", VA = "0x18994EC60", Slot = "6")]
		protected override void IPZJRCDKBBQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x994F000", Offset = "0x994DE00", VA = "0x18994F000")]
		private void YTGGTXSHQNX(BufferedMessage a)
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
		[Cpp2IlInjected.Address(RVA = "0x99474D0", Offset = "0x99462D0", VA = "0x1899474D0")]
		public BufferedMessage(CombinedSlice combinedSlice, [CanBeNull] byte[] payload, bool isMasterSwitchMessage, byte senderIdByte, byte messageIdByte)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9947340", Offset = "0x9946140", VA = "0x189947340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9947150", Offset = "0x9945F50", VA = "0x189947150")]
		private static void TZYRFOKBPAZ(byte[] a, StringBuilder b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct CombinedSlice
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class LCFQXOSFRCW : IEnumerable<Slice>, IEnumerable, IEnumerator<Slice>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private Slice OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CombinedSlice XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public CombinedSlice QMTTMRITYJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private SliceType[] ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int ULGHTDELHUA;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private Slice HOIRONUVRRM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x23A26F0", Offset = "0x23A14F0", VA = "0x1823A26F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Slice);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x994E730", Offset = "0x994D530", VA = "0x18994E730", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1D13E20", Offset = "0x1D12C20", VA = "0x181D13E20")]
			[DebuggerHidden]
			public LCFQXOSFRCW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x994E780", Offset = "0x994D580", VA = "0x18994E780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x994E8F0", Offset = "0x994D6F0", VA = "0x18994E8F0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x994E690", Offset = "0x994D490", VA = "0x18994E690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Slice> CBSRHZPFMWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x994E690", Offset = "0x994D490", VA = "0x18994E690", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
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
		[Cpp2IlInjected.Address(RVA = "0x994BDE0", Offset = "0x994ABE0", VA = "0x18994BDE0")]
		public static CombinedSlice CJMKPFZYUND(SliceType a, Guid b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x994BF50", Offset = "0x994AD50", VA = "0x18994BF50")]
		public static CombinedSlice QVYOPJJNUJQ(List<Slice> a)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x994C430", Offset = "0x994B230", VA = "0x18994C430")]
		public static CombinedSlice WCBYLXLMSUQ(SliceType a, Guid[] b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x994C770", Offset = "0x994B570", VA = "0x18994C770")]
		private CombinedSlice(SliceType combinedSliceType, Guid[] sliceIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x994BED0", Offset = "0x994ACD0", VA = "0x18994BED0")]
		[IteratorStateMachine(typeof(LCFQXOSFRCW))]
		public IEnumerable<Slice> CRPIPMBWGIS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x994C2C0", Offset = "0x994B0C0", VA = "0x18994C2C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ZOYGLTNABDX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9953680", Offset = "0x9952480", VA = "0x189953680")]
		public static string LCMXFSCZIVX(IDictionary<object, object> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class FIRBDKEDXYC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62A2DA0", Offset = "0x62A1BA0", VA = "0x1862A2DA0", Slot = "4")]
		public void SerializeTo(a message, IDictionary<object, object> data, bool clearBeforeWrite = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void XBFAFZPVUGJ(a a, IDictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract a Deserialize(IDictionary<object, object> data);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected FIRBDKEDXYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class COAXLPFEKHS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate bool ShouldCancelForNewMaster(int masterClientActorNumber);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		protected readonly JAGUJUYUPEX SUPZMQPDAPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly CancellationToken PCKMLYZKWRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly CancellationToken PGGLBCKJXMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ShouldCancelForNewMaster EJXMREQKOXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CancellationTokenSource TAGDKXHXSZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CancellationTokenSource WJJRQMJPQJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly int YTJCYBKKDWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool EPQOGGPSNAX;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CancellationToken FFKSQBBVJLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1B84CA0", Offset = "0x1B83AA0", VA = "0x181B84CA0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZRWNXBVAPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x994BB00", Offset = "0x994A900", VA = "0x18994BB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x994BC50", Offset = "0x994AA50", VA = "0x18994BC50")]
		public COAXLPFEKHS(JAGUJUYUPEX a, CancellationToken b, [Optional] ShouldCancelForNewMaster c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x994B9C0", Offset = "0x994A7C0", VA = "0x18994B9C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x994BB90", Offset = "0x994A990", VA = "0x18994BB90", Slot = "5")]
		protected virtual void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x994BA60", Offset = "0x994A860", VA = "0x18994BA60")]
		private void OnMasterClientSwitched(GUPOFWBVNMS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x994B9E0", Offset = "0x994A7E0", VA = "0x18994B9E0")]
		protected void HEBZHMFOUAQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x994BA40", Offset = "0x994A840", VA = "0x18994BA40", Slot = "6")]
		protected virtual void IPZJRCDKBBQ(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x5304CA0", Offset = "0x5303AA0", VA = "0x185304CA0")]
		public Slice(SliceType sliceType, Guid sliceId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x994F4D0", Offset = "0x994E2D0", VA = "0x18994F4D0")]
		public bool Equals(Slice other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x994F530", Offset = "0x994E330", VA = "0x18994F530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x994F5F0", Offset = "0x994E3F0", VA = "0x18994F5F0", Slot = "2")]
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
	internal static class QZLWFCHNVFP
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		internal static readonly SliceType[] MUJAUAPRLBU;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x994F220", Offset = "0x994E020", VA = "0x18994F220")]
		public static int WTFDYRQXSKT(SliceType a)
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
