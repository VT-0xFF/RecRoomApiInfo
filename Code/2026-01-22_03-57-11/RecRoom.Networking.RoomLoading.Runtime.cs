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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8405400", Offset = "0x8403C00", VA = "0x188405400")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Networking.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class HQADOSOZSNC : PVYNIAVTXDC<BufferedMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class XGUNRQTJNJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDictionary<object, object> OZIJAYZVMBR;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XGUNRQTJNJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x840D960", Offset = "0x840C160", VA = "0x18840D960")]
			internal object CCVXQDNGJPA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal static readonly string[] CXGYKLTUTZN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly HQADOSOZSNC QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84039D0", Offset = "0x84021D0", VA = "0x1884039D0", Slot = "5")]
		protected override void VNQRMQZUJNZ(BufferedMessage a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8402F70", Offset = "0x8401770", VA = "0x188402F70", Slot = "6")]
		public override BufferedMessage Deserialize(IDictionary<object, object> data)
		{
			return default(BufferedMessage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8403EB0", Offset = "0x84026B0", VA = "0x188403EB0")]
		public HQADOSOZSNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class WIRGXAFIAGE
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
			[Cpp2IlInjected.Address(RVA = "0x3D664D0", Offset = "0x3D64CD0", VA = "0x183D664D0")]
			public static BufferedMessage<T> JIZLVEWQUBZ(BufferedMessage a, Func<byte[], T> b)
			{
				return default(BufferedMessage<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3D66930", Offset = "0x3D65130", VA = "0x183D66930")]
			public BufferedMessage(CombinedSlice combinedSlice, T payload, bool isMasterSwitchMessage = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3D666C0", Offset = "0x3D64EC0", VA = "0x183D666C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CXGVUHOVTYR : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class JHXZLDGKHPS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public TaskCompletionSource<BufferedMessage> LOKBQIHBFDS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public CXGVUHOVTYR BDLWXAGXLOZ;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JHXZLDGKHPS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x84042C0", Offset = "0x8402AC0", VA = "0x1884042C0")]
				internal void VYSQQNJTDBX(BufferedMessage a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8404040", Offset = "0x8402840", VA = "0x188404040")]
				internal void MIGWDBOXABD(string a, long b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8403F60", Offset = "0x8402760", VA = "0x188403F60")]
				internal BufferedEventReceiveTimeoutException LSQEBPDLLVI(TimeSpan a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class JIDGIKAHRBB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public string VWPSGIKJBCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public long KYTPPGAIHEI;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public JIDGIKAHRBB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8404330", Offset = "0x8402B30", VA = "0x188404330")]
				internal object LSVKYVXIVGR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class NUBZRTTVHDX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public SliceType TIIKJNQGFSD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Guid MPEPFPTIHKW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public int ZXZOFLBFYAZ;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public NUBZRTTVHDX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8405390", Offset = "0x8403B90", VA = "0x188405390")]
				internal bool SIBHTLOOKMC(BufferedMessage a)
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
				public CXGVUHOVTYR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public TimeSpan timeout;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private JHXZLDGKHPS <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private TaskAwaiter<BufferedMessage> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x84055D0", Offset = "0x8403DD0", VA = "0x1884055D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x8405DF0", Offset = "0x84045F0", VA = "0x188405DF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private readonly OIPNVNKIDVK RSRWKVIBYIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly string HFCWVYTHNXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly List<BufferedMessage> LOWTVHSFOTT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private List<(string, long totalStopwatchTicks)> YIAWCTZBKFF;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool EOSVXKFTLPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8401B00", Offset = "0x8400300", VA = "0x188401B00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			private event Action<BufferedMessage> GJDRISMAJTD
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8401A50", Offset = "0x8400250", VA = "0x188401A50")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x8401800", Offset = "0x8400000", VA = "0x188401800")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8401D20", Offset = "0x8400520", VA = "0x188401D20")]
			public CXGVUHOVTYR(OIPNVNKIDVK a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8401910", Offset = "0x8400110", VA = "0x188401910")]
			[AsyncStateMachine(typeof(<AwaitNextMessage>d__10))]
			public Task<BufferedMessage> PBPKJRCQNYN(CancellationToken a, TimeSpan b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8401C70", Offset = "0x8400470", VA = "0x188401C70")]
			public void YYXMRNYQGHG(BufferedMessage a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x84018B0", Offset = "0x84000B0", VA = "0x1884018B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8401B50", Offset = "0x8400350", VA = "0x188401B50")]
			public void XOZTVUSOTAS(SliceType a, Guid b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class XQTSCXJHXWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public TimeSpan VOYETOAZNUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public WIRGXAFIAGE BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> RFFIKMQFBIZ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XQTSCXJHXWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x840DA40", Offset = "0x840C240", VA = "0x18840DA40")]
			internal bool YACGAEEPXML(int a, TimeSpan b, TimeSpan c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x840D9B0", Offset = "0x840C1B0", VA = "0x18840D9B0")]
			internal bool JYDWWKGBKCN(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LKNKIBAMZQN
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
				public LKNKIBAMZQN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x84088E0", Offset = "0x84070E0", VA = "0x1884088E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x8408A90", Offset = "0x8407290", VA = "0x188408A90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Func<CancellationToken, Task> VVOEBTRKXCD;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public LKNKIBAMZQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8404DA0", Offset = "0x84035A0", VA = "0x188404DA0")]
			[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
			internal Task<bool> ZHJXYLXJPFK(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LNSWLYDQRXS<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Func<Guid, bool> WADWDOPQLMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public Guid YIWQICIMVIK;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public LNSWLYDQRXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x52F7C80", Offset = "0x52F6480", VA = "0x1852F7C80")]
			internal bool MWWRLCMJQVU(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GNSJUUVFLZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public Dictionary<object, object> TLUDKGFSHGR;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public GNSJUUVFLZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8402F20", Offset = "0x8401720", VA = "0x188402F20")]
			internal object SETAVXHLMGR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8402ED0", Offset = "0x84016D0", VA = "0x188402ED0")]
			internal object SENTYQNOCVI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class WXLNBJYJSJU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public SliceType TIIKJNQGFSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public Guid YIWQICIMVIK;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WXLNBJYJSJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x840D8C0", Offset = "0x840C0C0", VA = "0x18840D8C0")]
			internal object LXUNEULURAQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class JWKCUPMIMHT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public SliceType TIIKJNQGFSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public Guid YIWQICIMVIK;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JWKCUPMIMHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x84047F0", Offset = "0x8402FF0", VA = "0x1884047F0")]
			internal object KGKDPYKUXEK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NAISWONUTDQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public Guid MPEPFPTIHKW;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAISWONUTDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84052B0", Offset = "0x8403AB0", VA = "0x1884052B0")]
			internal object VJGPORRZWYU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class IKLFJXTOAOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Guid MPEPFPTIHKW;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IKLFJXTOAOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8403EF0", Offset = "0x84026F0", VA = "0x188403EF0")]
			internal object TSYDDKOOQAL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WFTKWXJFSZG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public Guid MPEPFPTIHKW;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WFTKWXJFSZG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8409000", Offset = "0x8407800", VA = "0x188409000")]
			internal bool SMSZSITFXNK(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DKBWDDQYZNY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Guid MPEPFPTIHKW;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public DKBWDDQYZNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x266FBD0", Offset = "0x266E3D0", VA = "0x18266FBD0")]
			internal bool ZSVYTGDVJZO(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class NGBTJMQOLQP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Func<Guid, bool> AFAGKKJDIGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<Guid, bool> HGYWRIGDMRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Func<Guid, bool> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NGBTJMQOLQP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8405350", Offset = "0x8403B50", VA = "0x188405350")]
			internal bool RODEOWKYVZA(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8405350", Offset = "0x8403B50", VA = "0x188405350")]
			internal bool RNXXRPRBMNR(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class NFWMMFWRCFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Guid BIXRDSRDEDE;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NFWMMFWRCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8405320", Offset = "0x8403B20", VA = "0x188405320")]
			internal bool ROILMDEWFKJ(Slice a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class WWIQCXNKFGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Guid BIXRDSRDEDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Dictionary<object, object> NLFBLKRLJVJ;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WWIQCXNKFGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x840D630", Offset = "0x840BE30", VA = "0x18840D630")]
			internal object KZCILCOAZBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x840D410", Offset = "0x840BC10", VA = "0x18840D410")]
			internal object KYXBNVUDPPZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x840D850", Offset = "0x840C050", VA = "0x18840D850")]
			internal object KZHPIJHYIMR()
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x8405E60", Offset = "0x8404660", VA = "0x188405E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84060F0", Offset = "0x84048F0", VA = "0x1884060F0", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x509E4D0", Offset = "0x509CCD0", VA = "0x18509E4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x509FFF0", Offset = "0x509E7F0", VA = "0x18509FFF0", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x50A0160", Offset = "0x509E960", VA = "0x1850A0160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x50A1180", Offset = "0x509F980", VA = "0x1850A1180", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x8406150", Offset = "0x8404950", VA = "0x188406150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x84069B0", Offset = "0x84051B0", VA = "0x1884069B0", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8406A20", Offset = "0x8405220", VA = "0x188406A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8406E60", Offset = "0x8405660", VA = "0x188406E60", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

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
			private XQTSCXJHXWU <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Stopwatch elapsedStopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private JKJLIPSUNHQ <masterSwitchScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8406ED0", Offset = "0x84056D0", VA = "0x188406ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8407A00", Offset = "0x8406200", VA = "0x188407A00", Slot = "5")]
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
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public TimeSpan? timeoutOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8407A70", Offset = "0x8406270", VA = "0x188407A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8408430", Offset = "0x8406C30", VA = "0x188408430", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public Guid proposedGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<BufferedMessage<Guid>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84084A0", Offset = "0x8406CA0", VA = "0x1884084A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8408870", Offset = "0x8407070", VA = "0x188408870", Slot = "5")]
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
			public WIRGXAFIAGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private LNSWLYDQRXS<T> <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public VKYKZTFWRNZ unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public VKYKZTFWRNZ pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool <isRootMasterBlockSlice>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private FWKZVNKXMSX <masterSwitchTokenScope>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x53BA880", Offset = "0x53B9080", VA = "0x1853BA880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x53BB980", Offset = "0x53BA180", VA = "0x1853BB980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly PayloadTraceFormatter HNMASHMDVDR;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Dictionary<object, object> YPDGVIVERUC;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly JFVSBLTWLJF WQQKYLNJPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly CXGVUHOVTYR GUTYUUTNCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly OIPNVNKIDVK RSRWKVIBYIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly IBUSXBISTXU UGIMUQMJPXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly PARGVAODMKF HTDNKSRRWYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly PayloadTraceFormatter IUTSZBBRPQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool EWAJJDIHWIY;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly TimeSpan AWGSNVEAGUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TimeSpan UPIKYEWCKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private byte PDKMFUZMSSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<Guid>[] ODAVQGVIWGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Slice> JGJKILQEOPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CombinedSlice? SYXJAWHTPAM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly JFVSBLTWLJF CKUJBDRKGJQ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly JFVSBLTWLJF MBNNYILCVLE;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal event Action<BufferedMessage> BVGDQFMHTXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x840BDE0", Offset = "0x840A5E0", VA = "0x18840BDE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84093B0", Offset = "0x8407BB0", VA = "0x1884093B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x840CF90", Offset = "0x840B790", VA = "0x18840CF90")]
		public WIRGXAFIAGE(OIPNVNKIDVK a, IBUSXBISTXU b, PARGVAODMKF c, [Optional] TimeSpan? d, [Optional] PayloadTraceFormatter e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD3A0", Offset = "0x3BFBBA0", VA = "0x183BFD3A0")]
		public static WIRGXAFIAGE JFUAFHQRDYG<a>(a a, [Optional] TimeSpan? b, [Optional] PayloadTraceFormatter c) where a : OIPNVNKIDVK, IBUSXBISTXU, PARGVAODMKF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8409BF0", Offset = "0x84083F0", VA = "0x188409BF0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8409E10", Offset = "0x8408610", VA = "0x188409E10")]
		private byte EKFRUNDVHEW()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84099C0", Offset = "0x84081C0", VA = "0x1884099C0")]
		private TimeSpan DZVCYWIIEHC(TimeSpan? a, int b = 1)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD580", Offset = "0x3BFBD80", VA = "0x183BFD580")]
		public bool TXHNUTMCRAO<b>(b a, Func<b, byte[]> b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x840BFF0", Offset = "0x840A7F0", VA = "0x18840BFF0")]
		public bool TXHNUTMCRAO(byte[] a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0")]
		private static string WHBVLQPXAYW(string a, string b = "yellow")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x840BE90", Offset = "0x840A690", VA = "0x18840BE90")]
		[AsyncStateMachine(typeof(<ReceiveBuffered>d__25))]
		public Task<BufferedMessage> TLOZHOZPYET(CancellationToken a, [Optional] VKYKZTFWRNZ b, [Optional] VKYKZTFWRNZ c, [Optional] TimeSpan? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8409570", Offset = "0x8407D70", VA = "0x188409570")]
		[AsyncStateMachine(typeof(<SyncGuid>d__26))]
		public Task<Guid> BQHGLNVMKVX(Guid a, CancellationToken b, [Optional] VKYKZTFWRNZ c, [Optional] VKYKZTFWRNZ d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD640", Offset = "0x3BFBE40", VA = "0x183BFD640")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__27<>))]
		public Task<BufferedMessage<c>> VAELYICIHJM<c>(c a, Func<c, byte[]> b, Func<byte[], c> c, CancellationToken d, [Optional] VKYKZTFWRNZ e, [Optional] VKYKZTFWRNZ f, [Optional] TimeSpan? g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x840C530", Offset = "0x840AD30", VA = "0x18840C530")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__28))]
		public Task<BufferedMessage> VAELYICIHJM(byte[] a, CancellationToken b, [Optional] VKYKZTFWRNZ c, [Optional] VKYKZTFWRNZ d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8409E20", Offset = "0x8408620", VA = "0x188409E20")]
		[AsyncStateMachine(typeof(<MasterSendReceiveWithRetries>d__29))]
		private Task<BufferedMessage> FLRFAUWOSPU(byte[] a, CancellationToken b, VKYKZTFWRNZ c, VKYKZTFWRNZ d, TimeSpan? e, Stopwatch f, [Optional] Func<bool> g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x840C6C0", Offset = "0x840AEC0", VA = "0x18840C6C0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveSimple>d__30))]
		private Task<BufferedMessage> WKJXAFXQQQS(byte[] a, CancellationToken b, [Optional] VKYKZTFWRNZ c, [Optional] VKYKZTFWRNZ d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x840CB40", Offset = "0x840B340", VA = "0x18840CB40")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__31))]
		public Task ZNAZXFGFFVK(CancellationToken a, Func<CancellationToken, Task> b, [Optional] VKYKZTFWRNZ c, [Optional] VKYKZTFWRNZ d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDD70", Offset = "0x3BFC570", VA = "0x183BFDD70")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__32<>))]
		public Task<d> ZNAZXFGFFVK<d>(CancellationToken a, Func<CancellationToken, Task<d>> b, [Optional] VKYKZTFWRNZ c, [Optional] VKYKZTFWRNZ d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC9D0", Offset = "0x3BFB1D0", VA = "0x183BFC9D0")]
		[AsyncStateMachine(typeof(<TryRunMasterLockedBlock>d__33<>))]
		private Task<(bool, e)> FPSPCTVCSJM<e>(Guid a, CancellationToken b, Func<CancellationToken, Task<e>> c, [Optional] VKYKZTFWRNZ d, [Optional] VKYKZTFWRNZ e, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8409FC0", Offset = "0x84087C0", VA = "0x188409FC0")]
		public void FVOKMVSXNLI(TZRHNFDOAHO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x840C9D0", Offset = "0x840B1D0", VA = "0x18840C9D0")]
		public Guid XYOIVFMICIR(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x840B880", Offset = "0x840A080", VA = "0x18840B880")]
		public bool MCWSSJBNXDO(SliceType a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8409030", Offset = "0x8407830", VA = "0x188409030")]
		public void BIOHFAIAIDM(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x840C6B0", Offset = "0x840AEB0", VA = "0x18840C6B0")]
		private void VEZKXSGTXDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8409460", Offset = "0x8407C60", VA = "0x188409460")]
		internal CombinedSlice BPWBCLOWDPO(bool a = false)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8409D00", Offset = "0x8408500", VA = "0x188409D00")]
		private HashSet<Guid> EHHZNFBQQSE(SliceType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84096E0", Offset = "0x8407EE0", VA = "0x1884096E0")]
		private void BQPMSCAIYUY(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x840AEC0", Offset = "0x84096C0", VA = "0x18840AEC0")]
		private void GWCTVQHPMND(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x840C830", Offset = "0x840B030", VA = "0x18840C830")]
		public static Func<Guid, bool> WXZEVJZTBAA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x840B180", Offset = "0x8409980", VA = "0x18840B180")]
		public static Func<Guid, bool> HPIACGJSHOA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x840C8D0", Offset = "0x840B0D0", VA = "0x18840C8D0")]
		public void XOZTVUSOTAS(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x840A990", Offset = "0x8409190", VA = "0x18840A990")]
		public void GTVHUZCGVZS(SliceType a, Func<Guid, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84098A0", Offset = "0x84080A0", VA = "0x1884098A0")]
		private static Dictionary<object, object> BXICDRKIZSD(SliceType a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x840B220", Offset = "0x8409A20", VA = "0x18840B220")]
		private void HYWGUWMSBMX(SliceType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BufferedEventReceiveTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<(string itemType, long totalStopwatchTicks)> LHWDVDHNVQU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<(string itemType, long totalStopwatchTicks)> ProcessedActions
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABA0F0", Offset = "0xAB88F0", VA = "0x180ABA0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84013A0", Offset = "0x83FFBA0", VA = "0x1884013A0")]
		public BufferedEventReceiveTimeoutException(TimeSpan timeout, List<(string itemType, long totalStopwatchTicks)> processedActions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class FWKZVNKXMSX : JKJLIPSUNHQ
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
			[Cpp2IlInjected.Address(RVA = "0x84052A0", Offset = "0x8403AA0", VA = "0x1884052A0")]
			public MasterSwitchMessage(Guid transactionId, int senderActorNumber, int newMasterActorNumber)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8405190", Offset = "0x8403990", VA = "0x188405190")]
			public static byte[] VOPQGDPBGDJ(MasterSwitchMessage a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8405050", Offset = "0x8403850", VA = "0x188405050")]
			public static MasterSwitchMessage Deserialize(byte[] bytes)
			{
				return default(MasterSwitchMessage);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8405150", Offset = "0x8403950", VA = "0x188405150")]
			private static byte[] GOBSBLJCWMK(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8405000", Offset = "0x8403800", VA = "0x188405000")]
			private static int APNSMTUYKPI(byte[] a, int b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly Guid SBCUGIEUSIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly WIRGXAFIAGE AWPCIJTEYWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool CRCAXNEZDML;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8402E70", Offset = "0x8401670", VA = "0x188402E70")]
		public FWKZVNKXMSX(Guid a, WIRGXAFIAGE b, PARGVAODMKF c, CancellationToken d, [Optional] ShouldCancelForNewMaster e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8402AD0", Offset = "0x84012D0", VA = "0x188402AD0", Slot = "5")]
		protected override void OPJJLZXZUSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8402C80", Offset = "0x8401480", VA = "0x188402C80", Slot = "6")]
		protected override void UCGYWJULLOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8402910", Offset = "0x8401110", VA = "0x188402910")]
		private void BVGDQFMHTXJ(BufferedMessage a)
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
		[Cpp2IlInjected.Address(RVA = "0x84017A0", Offset = "0x83FFFA0", VA = "0x1884017A0")]
		public BufferedMessage(CombinedSlice combinedSlice, [CanBeNull] byte[] payload, bool isMasterSwitchMessage, byte senderIdByte, byte messageIdByte)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8401610", Offset = "0x83FFE10", VA = "0x188401610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8401420", Offset = "0x83FFC20", VA = "0x188401420")]
		private static void CCVOUYIQBNR(byte[] a, StringBuilder b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct CombinedSlice
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class ZYQEIQHXKME : IEnumerable<Slice>, IEnumerable, IEnumerator<Slice>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private Slice VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CombinedSlice BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public CombinedSlice LUHQKPWTGKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private SliceType[] YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int YLNEDRBNMVQ;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private Slice XXQPEYYHMOA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x20DBC90", Offset = "0x20DA490", VA = "0x1820DBC90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Slice);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x840DD80", Offset = "0x840C580", VA = "0x18840DD80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F060", Offset = "0x1A4D860", VA = "0x181A4F060")]
			[DebuggerHidden]
			public ZYQEIQHXKME(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x840DC10", Offset = "0x840C410", VA = "0x18840DC10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x840DB30", Offset = "0x840C330", VA = "0x18840DB30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x840DB70", Offset = "0x840C370", VA = "0x18840DB70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Slice> JNXDUZKLIXR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x840DB70", Offset = "0x840C370", VA = "0x18840DB70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
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
		[Cpp2IlInjected.Address(RVA = "0x84021D0", Offset = "0x84009D0", VA = "0x1884021D0")]
		public static CombinedSlice RKEBRQGBDHF(SliceType a, Guid b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8402410", Offset = "0x8400C10", VA = "0x188402410")]
		public static CombinedSlice WOFIANQKLMY(List<Slice> a)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8401E20", Offset = "0x8400620", VA = "0x188401E20")]
		public static CombinedSlice EZZEMSZCPAK(SliceType a, Guid[] b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8402780", Offset = "0x8400F80", VA = "0x188402780")]
		private CombinedSlice(SliceType combinedSliceType, Guid[] sliceIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8402150", Offset = "0x8400950", VA = "0x188402150")]
		[IteratorStateMachine(typeof(ZYQEIQHXKME))]
		public IEnumerable<Slice> HQVSWDMNLEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84022B0", Offset = "0x8400AB0", VA = "0x1884022B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class KEGEQDKYCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8404890", Offset = "0x8403090", VA = "0x188404890")]
		public static string HMEXOFCXWFN(IDictionary<object, object> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class PVYNIAVTXDC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5AC2080", Offset = "0x5AC0880", VA = "0x185AC2080", Slot = "4")]
		public void SerializeTo(a message, IDictionary<object, object> data, bool clearBeforeWrite = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void VNQRMQZUJNZ(a a, IDictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract a Deserialize(IDictionary<object, object> data);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected PVYNIAVTXDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class JKJLIPSUNHQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate bool ShouldCancelForNewMaster(int masterClientActorNumber);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool RZOBVXQYVPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		protected readonly PARGVAODMKF CRDDVOKTPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly CancellationToken HTGXMVKWYWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly CancellationToken LJXABQZZXGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ShouldCancelForNewMaster FXUQGYQPFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CancellationTokenSource MMCOWLTRXEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CancellationTokenSource UZBEPSHUOXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly int BIADRXOWIEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool ISWIKRJJIPP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CancellationToken WBZHFMCHKWB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x18B8D90", Offset = "0x18B7590", VA = "0x1818B8D90")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BXOQTFHJZZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8404450", Offset = "0x8402C50", VA = "0x188404450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8404660", Offset = "0x8402E60", VA = "0x188404660")]
		public JKJLIPSUNHQ(PARGVAODMKF a, CancellationToken b, [Optional] ShouldCancelForNewMaster c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8404430", Offset = "0x8402C30", VA = "0x188404430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84044E0", Offset = "0x8402CE0", VA = "0x1884044E0", Slot = "5")]
		protected virtual void OPJJLZXZUSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84045A0", Offset = "0x8402DA0", VA = "0x1884045A0")]
		private void OnMasterClientSwitched(MNBQIABPYXS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84043D0", Offset = "0x8402BD0", VA = "0x1884043D0")]
		protected void CCUNBSASDLE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8404640", Offset = "0x8402E40", VA = "0x188404640", Slot = "6")]
		protected virtual void UCGYWJULLOY(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x410A6E0", Offset = "0x4108EE0", VA = "0x18410A6E0")]
		public Slice(SliceType sliceType, Guid sliceId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8405480", Offset = "0x8403C80", VA = "0x188405480")]
		public bool Equals(Slice other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84054E0", Offset = "0x8403CE0", VA = "0x1884054E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84055A0", Offset = "0x8403DA0", VA = "0x1884055A0", Slot = "2")]
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
	internal static class LQCLTVUACVF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		internal static readonly SliceType[] YORAMCOOKSM;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8404EB0", Offset = "0x84036B0", VA = "0x188404EB0")]
		public static int BMSGDPVOROJ(SliceType a)
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
