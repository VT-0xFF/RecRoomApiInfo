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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AD1CB0", Offset = "0x9AD06B0", VA = "0x189AD1CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public SFJDTQTBFER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9AD24E0", Offset = "0x9AD0EE0", VA = "0x189AD24E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AD0420", Offset = "0x9ACEE20", VA = "0x189AD0420", Slot = "5")]
		protected override void XBFAFZPVUGJ(BufferedMessage a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF9C0", Offset = "0x9ACE3C0", VA = "0x189ACF9C0", Slot = "6")]
		public override BufferedMessage Deserialize(IDictionary<object, object> data)
		{
			return default(BufferedMessage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9AD0920", Offset = "0x9ACF320", VA = "0x189AD0920")]
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
			[Cpp2IlInjected.Address(RVA = "0x5029E30", Offset = "0x5028830", VA = "0x185029E30")]
			public static BufferedMessage<T> NPLSBFVZXUJ(BufferedMessage a, Func<byte[], T> b)
			{
				return default(BufferedMessage<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x502A3E0", Offset = "0x5028DE0", VA = "0x18502A3E0")]
			public BufferedMessage(CombinedSlice combinedSlice, T payload, bool isMasterSwitchMessage = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5029EF0", Offset = "0x50288F0", VA = "0x185029EF0", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
				public WYUZZVKPLDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x9AD61E0", Offset = "0x9AD4BE0", VA = "0x189AD61E0")]
				internal void CHJQGLRXQVJ(BufferedMessage a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x9AD6330", Offset = "0x9AD4D30", VA = "0x189AD6330")]
				internal void LKQJFWPFZUD(string a, long b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9AD6250", Offset = "0x9AD4C50", VA = "0x189AD6250")]
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
				[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
				public WZAGXCEMUOR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9AD65C0", Offset = "0x9AD4FC0", VA = "0x189AD65C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
				public SIXMNEQISOH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x9AD2530", Offset = "0x9AD0F30", VA = "0x189AD2530")]
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
				[Cpp2IlInjected.Address(RVA = "0x9AD2760", Offset = "0x9AD1160", VA = "0x189AD2760", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x9AD2F80", Offset = "0x9AD1980", VA = "0x189AD2F80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x9AD0CB0", Offset = "0x9ACF6B0", VA = "0x189AD0CB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			private event Action<BufferedMessage> THLQHIQDEGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x9AD0A30", Offset = "0x9ACF430", VA = "0x189AD0A30")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x9AD0D00", Offset = "0x9ACF700", VA = "0x189AD0D00")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0EF0", Offset = "0x9ACF8F0", VA = "0x189AD0EF0")]
			public FJYPZRIWLSP(AZZOGUSWEIC a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0DB0", Offset = "0x9ACF7B0", VA = "0x189AD0DB0")]
			[AsyncStateMachine(typeof(<AwaitNextMessage>d__10))]
			public Task<BufferedMessage> YORIEUHDLBV(CancellationToken a, TimeSpan b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0AE0", Offset = "0x9ACF4E0", VA = "0x189AD0AE0")]
			public void KFZJMEDYOXI(BufferedMessage a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9AD09D0", Offset = "0x9ACF3D0", VA = "0x189AD09D0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0B90", Offset = "0x9ACF590", VA = "0x189AD0B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FSAELSPRGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1090", Offset = "0x9ACFA90", VA = "0x189AD1090")]
			internal bool VKUSMGAFFIZ(int a, TimeSpan b, TimeSpan c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1180", Offset = "0x9ACFB80", VA = "0x189AD1180")]
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
				[Cpp2IlInjected.Address(RVA = "0x9AD5AB0", Offset = "0x9AD44B0", VA = "0x189AD5AB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x9AD5C60", Offset = "0x9AD4660", VA = "0x189AD5C60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Func<CancellationToken, Task> ILXYROTEVOB;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public YQFWVSBGPST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9AD6660", Offset = "0x9AD5060", VA = "0x189AD6660")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PSJEAXPAEOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x74E1680", Offset = "0x74E0080", VA = "0x1874E1680")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ZTAPQDVUGTO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AD6CD0", Offset = "0x9AD56D0", VA = "0x189AD6CD0")]
			internal object CTVEUPHHUKD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9AD6C80", Offset = "0x9AD5680", VA = "0x189AD6C80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public JBZQKAOMTYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AD16C0", Offset = "0x9AD00C0", VA = "0x189AD16C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FPTOQSACGGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0FF0", Offset = "0x9ACF9F0", VA = "0x189AD0FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public RYQFGLCIRJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9AD2470", Offset = "0x9AD0E70", VA = "0x189AD2470")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public EZRPNFOJXLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0960", Offset = "0x9ACF360", VA = "0x189AD0960")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public RVBWMXFBDZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9AD2440", Offset = "0x9AD0E40", VA = "0x189AD2440")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QPNVFDFTLRO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x297F0F0", Offset = "0x297DAF0", VA = "0x18297F0F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public TFCNPWVMMEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9AD2720", Offset = "0x9AD1120", VA = "0x189AD2720")]
			internal bool MZRGONJHMJW(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9AD2720", Offset = "0x9AD1120", VA = "0x189AD2720")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public TEXGSQBPCSS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9AD26F0", Offset = "0x9AD10F0", VA = "0x189AD26F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public IVKEZMMJWRD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1210", Offset = "0x9ACFC10", VA = "0x189AD1210")]
			internal object CRIHVTXFYAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9AD14A0", Offset = "0x9ACFEA0", VA = "0x189AD14A0")]
			internal object CRYCNOEYAIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1430", Offset = "0x9ACFE30", VA = "0x189AD1430")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD2FF0", Offset = "0x9AD19F0", VA = "0x189AD2FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9AD3280", Offset = "0x9AD1C80", VA = "0x189AD3280", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A38D20", Offset = "0x6A37720", VA = "0x186A38D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6A3A2C0", Offset = "0x6A38CC0", VA = "0x186A3A2C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A3A430", Offset = "0x6A38E30", VA = "0x186A3A430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6A3A7E0", Offset = "0x6A391E0", VA = "0x186A3A7E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD32E0", Offset = "0x9AD1CE0", VA = "0x189AD32E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9AD3B40", Offset = "0x9AD2540", VA = "0x189AD3B40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD3BB0", Offset = "0x9AD25B0", VA = "0x189AD3BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9AD3FF0", Offset = "0x9AD29F0", VA = "0x189AD3FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD4060", Offset = "0x9AD2A60", VA = "0x189AD4060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9AD4B90", Offset = "0x9AD3590", VA = "0x189AD4B90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD4C00", Offset = "0x9AD3600", VA = "0x189AD4C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9AD55E0", Offset = "0x9AD3FE0", VA = "0x189AD55E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD5650", Offset = "0x9AD4050", VA = "0x189AD5650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9AD5A40", Offset = "0x9AD4440", VA = "0x189AD5A40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x718DEB0", Offset = "0x718C8B0", VA = "0x18718DEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7191440", Offset = "0x718FE40", VA = "0x187191440", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACA5F0", Offset = "0x9AC8FF0", VA = "0x189ACA5F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9ACC850", Offset = "0x9ACB250", VA = "0x189ACC850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE600", Offset = "0x9ACD000", VA = "0x189ACE600")]
		public CHQSJOHMNWO(AZZOGUSWEIC a, RLWMQWFLYVW b, JAGUJUYUPEX c, [Optional] TimeSpan? d, [Optional] PayloadTraceFormatter e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3822F00", Offset = "0x3821900", VA = "0x183822F00")]
		public static CHQSJOHMNWO WYDPQSPQVQA<a>(a a, [Optional] TimeSpan? b, [Optional] PayloadTraceFormatter c) where a : AZZOGUSWEIC, RLWMQWFLYVW, JAGUJUYUPEX
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB200", Offset = "0x9AC9C00", VA = "0x189ACB200")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACCC80", Offset = "0x9ACB680", VA = "0x189ACCC80")]
		private byte MZPNNVLYJSU()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD7F0", Offset = "0x9ACC1F0", VA = "0x189ACD7F0")]
		private TimeSpan SRBRDIDOUEO(TimeSpan? a, int b = 1)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3821F60", Offset = "0x3820960", VA = "0x183821F60")]
		public bool OLHJDJPWUJO<b>(b a, Func<b, byte[]> b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9ACCE00", Offset = "0x9ACB800", VA = "0x189ACCE00")]
		public bool OLHJDJPWUJO(byte[] a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270")]
		private static string VRWTYAQYDZS(string a, string b = "yellow")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE190", Offset = "0x9ACCB90", VA = "0x189ACE190")]
		[AsyncStateMachine(typeof(<ReceiveBuffered>d__25))]
		public Task<BufferedMessage> ZSFSEDTDHCR(CancellationToken a, [Optional] FHXCPEDPGPT b, [Optional] FHXCPEDPGPT c, [Optional] TimeSpan? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA960", Offset = "0x9AC9360", VA = "0x189ACA960")]
		[AsyncStateMachine(typeof(<SyncGuid>d__26))]
		public Task<Guid> BZFVMGOJMSD(Guid a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3822020", Offset = "0x3820A20", VA = "0x183822020")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__27<>))]
		public Task<BufferedMessage<c>> SFFWNPYOVRO<c>(c a, Func<c, byte[]> b, Func<byte[], c> c, CancellationToken d, [Optional] FHXCPEDPGPT e, [Optional] FHXCPEDPGPT f, [Optional] TimeSpan? g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD510", Offset = "0x9ACBF10", VA = "0x189ACD510")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__28))]
		public Task<BufferedMessage> SFFWNPYOVRO(byte[] a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC6B0", Offset = "0x9ACB0B0", VA = "0x189ACC6B0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveWithRetries>d__29))]
		private Task<BufferedMessage> JHUGGUKARCU(byte[] a, CancellationToken b, FHXCPEDPGPT c, FHXCPEDPGPT d, TimeSpan? e, Stopwatch f, [Optional] Func<bool> g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9ACCC90", Offset = "0x9ACB690", VA = "0x189ACCC90")]
		[AsyncStateMachine(typeof(<MasterSendReceiveSimple>d__30))]
		private Task<BufferedMessage> NUIROQCPXHK(byte[] a, CancellationToken b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD690", Offset = "0x9ACC090", VA = "0x189ACD690")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__31))]
		public Task SGAEMXIJORE(CancellationToken a, Func<CancellationToken, Task> b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3822770", Offset = "0x3821170", VA = "0x183822770")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__32<>))]
		public Task<d> SGAEMXIJORE<d>(CancellationToken a, Func<CancellationToken, Task<d>> b, [Optional] FHXCPEDPGPT c, [Optional] FHXCPEDPGPT d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38215F0", Offset = "0x381FFF0", VA = "0x1838215F0")]
		[AsyncStateMachine(typeof(<TryRunMasterLockedBlock>d__33<>))]
		private Task<(bool, e)> BWQSLXYURRS<e>(Guid a, CancellationToken b, Func<CancellationToken, Task<e>> c, [Optional] FHXCPEDPGPT d, [Optional] FHXCPEDPGPT e, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB310", Offset = "0x9AC9D10", VA = "0x189ACB310")]
		public void EWGFALHVYVC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBD00", Offset = "0x9ACA700", VA = "0x189ACBD00")]
		public Guid FTFNTBVMZQX(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACACA0", Offset = "0x9AC96A0", VA = "0x189ACACA0")]
		public bool DWBUHBRHBHA(SliceType a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC900", Offset = "0x9ACB300", VA = "0x189ACC900")]
		public void LMOVEPHJPPW(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9ACAAD0", Offset = "0x9AC94D0", VA = "0x189ACAAD0")]
		private void CUGCRIMLYSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC5A0", Offset = "0x9ACAFA0", VA = "0x189ACC5A0")]
		internal CombinedSlice IVSXNIUYQHM(bool a = false)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDB40", Offset = "0x9ACC540", VA = "0x189ACDB40")]
		private HashSet<Guid> YCFRLYXSFJU(SliceType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9ACAAE0", Offset = "0x9AC94E0", VA = "0x189ACAAE0")]
		private void DTSDFFRIDMO(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA6A0", Offset = "0x9AC90A0", VA = "0x189ACA6A0")]
		private void BBJOBBFKWDV(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD470", Offset = "0x9ACBE70", VA = "0x189ACD470")]
		public static Func<Guid, bool> QLVGMRPNYFE(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC500", Offset = "0x9ACAF00", VA = "0x189ACC500")]
		public static Func<Guid, bool> GXFNJLDHJXA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD370", Offset = "0x9ACBD70", VA = "0x189ACD370")]
		public void QEOGNQGIJZO(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDC50", Offset = "0x9ACC650", VA = "0x189ACDC50")]
		public void YOJVRFNTGTY(SliceType a, Func<Guid, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDA20", Offset = "0x9ACC420", VA = "0x189ACDA20")]
		private static Dictionary<object, object> VVFAFLUNXFL(SliceType a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBE80", Offset = "0x9ACA880", VA = "0x189ACBE80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA190", Offset = "0x9AC8B90", VA = "0x189ACA190")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AD1CA0", Offset = "0x9AD06A0", VA = "0x189AD1CA0")]
			public MasterSwitchMessage(Guid transactionId, int senderActorNumber, int newMasterActorNumber)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1B90", Offset = "0x9AD0590", VA = "0x189AD1B90")]
			public static byte[] NYKTBLQYXAJ(MasterSwitchMessage a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1A00", Offset = "0x9AD0400", VA = "0x189AD1A00")]
			public static MasterSwitchMessage Deserialize(byte[] bytes)
			{
				return default(MasterSwitchMessage);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1B00", Offset = "0x9AD0500", VA = "0x189AD1B00")]
			private static byte[] FPVWLIYBVIQ(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1B40", Offset = "0x9AD0540", VA = "0x189AD1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AD2290", Offset = "0x9AD0C90", VA = "0x189AD2290")]
		public QDZTVIZMXRT(Guid a, CHQSJOHMNWO b, JAGUJUYUPEX c, CancellationToken d, [Optional] ShouldCancelForNewMaster e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD1F20", Offset = "0x9AD0920", VA = "0x189AD1F20", Slot = "5")]
		protected override void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9AD1D30", Offset = "0x9AD0730", VA = "0x189AD1D30", Slot = "6")]
		protected override void IPZJRCDKBBQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9AD20D0", Offset = "0x9AD0AD0", VA = "0x189AD20D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ACA590", Offset = "0x9AC8F90", VA = "0x189ACA590")]
		public BufferedMessage(CombinedSlice combinedSlice, [CanBeNull] byte[] payload, bool isMasterSwitchMessage, byte senderIdByte, byte messageIdByte)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA400", Offset = "0x9AC8E00", VA = "0x189ACA400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA210", Offset = "0x9AC8C10", VA = "0x189ACA210")]
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
				[Cpp2IlInjected.Address(RVA = "0x23E5370", Offset = "0x23E3D70", VA = "0x1823E5370", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9AD1800", Offset = "0x9AD0200", VA = "0x189AD1800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1D4C250", Offset = "0x1D4AC50", VA = "0x181D4C250")]
			[DebuggerHidden]
			public LCFQXOSFRCW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1850", Offset = "0x9AD0250", VA = "0x189AD1850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9AD19C0", Offset = "0x9AD03C0", VA = "0x189AD19C0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1760", Offset = "0x9AD0160", VA = "0x189AD1760", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Slice> CBSRHZPFMWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9AD1760", Offset = "0x9AD0160", VA = "0x189AD1760", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ACEEA0", Offset = "0x9ACD8A0", VA = "0x189ACEEA0")]
		public static CombinedSlice CJMKPFZYUND(SliceType a, Guid b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF010", Offset = "0x9ACDA10", VA = "0x189ACF010")]
		public static CombinedSlice QVYOPJJNUJQ(List<Slice> a)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF4F0", Offset = "0x9ACDEF0", VA = "0x189ACF4F0")]
		public static CombinedSlice WCBYLXLMSUQ(SliceType a, Guid[] b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF830", Offset = "0x9ACE230", VA = "0x189ACF830")]
		private CombinedSlice(SliceType combinedSliceType, Guid[] sliceIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEF90", Offset = "0x9ACD990", VA = "0x189ACEF90")]
		[IteratorStateMachine(typeof(LCFQXOSFRCW))]
		public IEnumerable<Slice> CRPIPMBWGIS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF380", Offset = "0x9ACDD80", VA = "0x189ACF380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ZOYGLTNABDX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9AD6770", Offset = "0x9AD5170", VA = "0x189AD6770")]
		public static string LCMXFSCZIVX(IDictionary<object, object> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class FIRBDKEDXYC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x635D810", Offset = "0x635C210", VA = "0x18635D810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1BBD950", Offset = "0x1BBC350", VA = "0x181BBD950")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZRWNXBVAPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9ACEBC0", Offset = "0x9ACD5C0", VA = "0x189ACEBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED10", Offset = "0x9ACD710", VA = "0x189ACED10")]
		public COAXLPFEKHS(JAGUJUYUPEX a, CancellationToken b, [Optional] ShouldCancelForNewMaster c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEA80", Offset = "0x9ACD480", VA = "0x189ACEA80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEC50", Offset = "0x9ACD650", VA = "0x189ACEC50", Slot = "5")]
		protected virtual void XTLFXBYXWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEB20", Offset = "0x9ACD520", VA = "0x189ACEB20")]
		private void OnMasterClientSwitched(GUPOFWBVNMS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEAA0", Offset = "0x9ACD4A0", VA = "0x189ACEAA0")]
		protected void HEBZHMFOUAQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEB00", Offset = "0x9ACD500", VA = "0x189ACEB00", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x53674F0", Offset = "0x5365EF0", VA = "0x1853674F0")]
		public Slice(SliceType sliceType, Guid sliceId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AD25A0", Offset = "0x9AD0FA0", VA = "0x189AD25A0")]
		public bool Equals(Slice other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AD2600", Offset = "0x9AD1000", VA = "0x189AD2600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AD26C0", Offset = "0x9AD10C0", VA = "0x189AD26C0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AD22F0", Offset = "0x9AD0CF0", VA = "0x189AD22F0")]
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
