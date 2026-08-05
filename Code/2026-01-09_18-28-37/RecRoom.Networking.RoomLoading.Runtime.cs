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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x8318A00", Offset = "0x8317E00", VA = "0x188318A00")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Networking.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class QAMOVSOQALN : DBWRKRYAYUL<BufferedMessage>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ZUBXSHNKXNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDictionary<object, object> HECVUOXIWJQ;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZUBXSHNKXNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8322A70", Offset = "0x8321E70", VA = "0x188322A70")]
			internal object TVZHDKFKICF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal static readonly string[] SSSHLSFDMOQ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly QAMOVSOQALN ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8319690", Offset = "0x8318A90", VA = "0x188319690", Slot = "5")]
		protected override void VIKQOAFPCDO(BufferedMessage a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8318CA0", Offset = "0x83180A0", VA = "0x188318CA0", Slot = "6")]
		public override BufferedMessage Deserialize(IDictionary<object, object> data)
		{
			return default(BufferedMessage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8319B70", Offset = "0x8318F70", VA = "0x188319B70")]
		public QAMOVSOQALN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class VFCOBRYCDRN
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
			[Cpp2IlInjected.Address(RVA = "0x3CC4560", Offset = "0x3CC3960", VA = "0x183CC4560")]
			public static BufferedMessage<T> TXXYRQETTLW(BufferedMessage a, Func<byte[], T> b)
			{
				return default(BufferedMessage<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3CC49C0", Offset = "0x3CC3DC0", VA = "0x183CC49C0")]
			public BufferedMessage(CombinedSlice combinedSlice, T payload, bool isMasterSwitchMessage = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3CC48F0", Offset = "0x3CC3CF0", VA = "0x183CC48F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class RIZIAUFMZJW : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class LYTSFHXTFCL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public TaskCompletionSource<BufferedMessage> RTFRWAPDKKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public RIZIAUFMZJW ZFLSXXSLHFA;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public LYTSFHXTFCL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8317D70", Offset = "0x8317170", VA = "0x188317D70")]
				internal void BRHHJLDCWWW(BufferedMessage a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8317EC0", Offset = "0x83172C0", VA = "0x188317EC0")]
				internal void ZRPQYDLBPZU(string a, long b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8317DE0", Offset = "0x83171E0", VA = "0x188317DE0")]
				internal BufferedEventReceiveTimeoutException UFAZUCDLSVJ(TimeSpan a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class LYOLIBDVVRC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public string MBSPJUIWNPX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public long QTBHACVAEUX;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public LYOLIBDVVRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8317CD0", Offset = "0x83170D0", VA = "0x188317CD0")]
				internal object UEVSWVJOJKA()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class QORFRYRZXRM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public SliceType QYKWSLIBSEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Guid UDWTGJWMJMD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public int CKLUFHYGCLG;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public QORFRYRZXRM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8319BB0", Offset = "0x8318FB0", VA = "0x188319BB0")]
				internal bool TMPDFWFZHVJ(BufferedMessage a)
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
				public RIZIAUFMZJW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public TimeSpan timeout;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				private LYTSFHXTFCL <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private TaskAwaiter<BufferedMessage> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x831A390", Offset = "0x8319790", VA = "0x18831A390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x831ABB0", Offset = "0x8319FB0", VA = "0x18831ABB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private readonly IWCEIOAOFPL CZGENKNNHVW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly string MSFOYBAMOBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly List<BufferedMessage> AKGNRHQUSOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private List<(string, long totalStopwatchTicks)> LHNFTLRVOIS;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public bool THVXWOCDCMK
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8319FB0", Offset = "0x83193B0", VA = "0x188319FB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			private event Action<BufferedMessage> COQNMYVQOQM
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8319C20", Offset = "0x8319020", VA = "0x188319C20")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x8319D30", Offset = "0x8319130", VA = "0x188319D30")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x831A140", Offset = "0x8319540", VA = "0x18831A140")]
			public RIZIAUFMZJW(IWCEIOAOFPL a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x831A000", Offset = "0x8319400", VA = "0x18831A000")]
			[AsyncStateMachine(typeof(<AwaitNextMessage>d__10))]
			public Task<BufferedMessage> SGQEOBMOLGE(CancellationToken a, TimeSpan b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8319F00", Offset = "0x8319300", VA = "0x188319F00")]
			public void OZINEQRQNMX(BufferedMessage a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8319CD0", Offset = "0x83190D0", VA = "0x188319CD0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8319DE0", Offset = "0x83191E0", VA = "0x188319DE0")]
			public void MHSQGYCEOJR(SliceType a, Guid b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PHNCDSIYYGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public TimeSpan ORYCZEMWRWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public VFCOBRYCDRN ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<bool> JEAQXCYCWNY;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public PHNCDSIYYGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8318BB0", Offset = "0x8317FB0", VA = "0x188318BB0")]
			internal bool YHWVOMFJNTK(int a, TimeSpan b, TimeSpan c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8318B20", Offset = "0x8317F20", VA = "0x188318B20")]
			internal bool JTPOVQBFNMI(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class COMRVCIDYUO
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
				public COMRVCIDYUO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x831D6B0", Offset = "0x831CAB0", VA = "0x18831D6B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x831D860", Offset = "0x831CC60", VA = "0x18831D860", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Func<CancellationToken, Task> OXUCMARNOZK;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public COMRVCIDYUO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8316550", Offset = "0x8315950", VA = "0x188316550")]
			[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
			internal Task<bool> RFDXJTNNXKX(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FLUUCAEELCH<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Func<Guid, bool> PYEANBFBMHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public Guid ABKHLDDPRUB;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public FLUUCAEELCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4D651F0", Offset = "0x4D645F0", VA = "0x184D651F0")]
			internal bool GCJFTCTTGPH(int a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OMBUVAXXFQR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public Dictionary<object, object> OKCCBUFFWBE;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public OMBUVAXXFQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8318A80", Offset = "0x8317E80", VA = "0x188318A80")]
			internal object TFZSTHLAMEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8318AD0", Offset = "0x8317ED0", VA = "0x188318AD0")]
			internal object TGEZQOEXVPP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class ZJEDCJEUGER
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public SliceType QYKWSLIBSEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public Guid ABKHLDDPRUB;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZJEDCJEUGER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83229D0", Offset = "0x8321DD0", VA = "0x1883229D0")]
			internal object DCVHWTERBIL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class MEOKCAVLMTA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public SliceType QYKWSLIBSEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public Guid ABKHLDDPRUB;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MEOKCAVLMTA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8318560", Offset = "0x8317960", VA = "0x188318560")]
			internal object YUKDTFEWZTF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class HZLLTHFHYMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public Guid UDWTGJWMJMD;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public HZLLTHFHYMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8317710", Offset = "0x8316B10", VA = "0x188317710")]
			internal object CBFQBQMMBXT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class VYHZZUSHEGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Guid UDWTGJWMJMD;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public VYHZZUSHEGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8322450", Offset = "0x8321850", VA = "0x188322450")]
			internal object AUHYRHFBSBG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class IWLGJUOWHTJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public Guid UDWTGJWMJMD;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IWLGJUOWHTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8317CA0", Offset = "0x83170A0", VA = "0x188317CA0")]
			internal bool UFGESAUXHIF(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class SWNUAPMEZAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Guid UDWTGJWMJMD;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public SWNUAPMEZAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2625030", Offset = "0x2624430", VA = "0x182625030")]
			internal bool MGETLFKUXWX(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class IHZJSDYCISQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Func<Guid, bool> JYBXWPVZEZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<Guid, bool> LWCMHOWFASR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Func<Guid, bool> LVMRPUOMYKQ;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IHZJSDYCISQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8317C30", Offset = "0x8317030", VA = "0x188317C30")]
			internal bool TQTNPCAGGAR(Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8317C30", Offset = "0x8317030", VA = "0x188317C30")]
			internal bool TQDSXHSODSQ(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IIEQPKRZSDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Guid IUBWWDZBKZH;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IIEQPKRZSDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8317C70", Offset = "0x8317070", VA = "0x188317C70")]
			internal bool TQOGRVGIWPI(Slice a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class IBSBOHUWYKU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Guid IUBWWDZBKZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Dictionary<object, object> KOCDHXSGZRI;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public IBSBOHUWYKU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83177F0", Offset = "0x8316BF0", VA = "0x1883177F0")]
			internal object QYAJWYHCUVR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8317A10", Offset = "0x8316E10", VA = "0x188317A10")]
			internal object QYFQUFBAEHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8317780", Offset = "0x8316B80", VA = "0x188317780")]
			internal object QXVCZRNFLKI()
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public PSXSXSWTYDW pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x831AC20", Offset = "0x831A020", VA = "0x18831AC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x831AEB0", Offset = "0x831A2B0", VA = "0x18831AEB0", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PSXSXSWTYDW pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x508F7C0", Offset = "0x508EBC0", VA = "0x18508F7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x50906D0", Offset = "0x508FAD0", VA = "0x1850906D0", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public PSXSXSWTYDW pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x5090840", Offset = "0x508FC40", VA = "0x185090840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5091850", Offset = "0x5090C50", VA = "0x185091850", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PSXSXSWTYDW pauseAfterListeningToken;

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
			[Cpp2IlInjected.Address(RVA = "0x831AF10", Offset = "0x831A310", VA = "0x18831AF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x831B770", Offset = "0x831AB70", VA = "0x18831B770", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public PSXSXSWTYDW pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x831B7E0", Offset = "0x831ABE0", VA = "0x18831B7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x831BC20", Offset = "0x831B020", VA = "0x18831BC20", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

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
			private PHNCDSIYYGP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public byte[] messageToSend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public PSXSXSWTYDW pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Stopwatch elapsedStopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private MCIHOVNMXXD <masterSwitchScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x831BC90", Offset = "0x831B090", VA = "0x18831BC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x831C7C0", Offset = "0x831BBC0", VA = "0x18831C7C0", Slot = "5")]
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
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public TimeSpan? timeoutOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public PSXSXSWTYDW pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x831C830", Offset = "0x831BC30", VA = "0x18831C830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x831D200", Offset = "0x831C600", VA = "0x18831D200", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public Guid proposedGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public PSXSXSWTYDW pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TimeSpan? timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<BufferedMessage<Guid>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x831D270", Offset = "0x831C670", VA = "0x18831D270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x831D640", Offset = "0x831CA40", VA = "0x18831D640", Slot = "5")]
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
			public VFCOBRYCDRN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private FLUUCAEELCH<T> <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public PSXSXSWTYDW unpauseForListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public PSXSXSWTYDW pauseAfterListeningToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool <isRootMasterBlockSlice>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private EGMDEVGOAVK <masterSwitchTokenScope>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x52F1780", Offset = "0x52F0B80", VA = "0x1852F1780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x52F56C0", Offset = "0x52F4AC0", VA = "0x1852F56C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly PayloadTraceFormatter NGTSIVTMKPM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Dictionary<object, object> AIKNTLFBPVZ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly YTJXGECMSCM TCKAKWEELND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly RIZIAUFMZJW IIRIJLKYJRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IWCEIOAOFPL CZGENKNNHVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly UHNPSXCDMML GSILMCADHZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MXHGYCMAQIO SHBZSPKGBGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly PayloadTraceFormatter XOLWBMFVVZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool TEMRMIPWZPT;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly TimeSpan OQMGNTWLEWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TimeSpan DJNBMLQPIHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private byte WUDSZTDGRMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<Guid>[] UMLUUOGIYUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Slice> PPKICALJRCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CombinedSlice? BFRNZZDYRYJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly YTJXGECMSCM PNOVXQRAZQF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly YTJXGECMSCM BOIVBUNFMFT;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal event Action<BufferedMessage> PXHZELNZJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8321250", Offset = "0x8320650", VA = "0x188321250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83211A0", Offset = "0x83205A0", VA = "0x1883211A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8321FD0", Offset = "0x83213D0", VA = "0x188321FD0")]
		public VFCOBRYCDRN(IWCEIOAOFPL a, UHNPSXCDMML b, MXHGYCMAQIO c, [Optional] TimeSpan? d, [Optional] PayloadTraceFormatter e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7970", Offset = "0x3BB6D70", VA = "0x183BB7970")]
		public static VFCOBRYCDRN HWDGOIXNIKF<a>(a a, [Optional] TimeSpan? b, [Optional] PayloadTraceFormatter c) where a : IWCEIOAOFPL, UHNPSXCDMML, MXHGYCMAQIO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x831E190", Offset = "0x831D590", VA = "0x18831E190")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x831E070", Offset = "0x831D470", VA = "0x18831E070")]
		private byte ALREWWLUOHZ()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83217F0", Offset = "0x8320BF0", VA = "0x1883217F0")]
		private TimeSpan VVVJZFVQZKR(TimeSpan? a, int b = 1)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7B50", Offset = "0x3BB6F50", VA = "0x183BB7B50")]
		public bool PKNOWPQBNOD<b>(b a, Func<b, byte[]> b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83204A0", Offset = "0x831F8A0", VA = "0x1883204A0")]
		public bool PKNOWPQBNOD(byte[] a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840")]
		private static string XKWNWAUXYOB(string a, string b = "yellow")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83209E0", Offset = "0x831FDE0", VA = "0x1883209E0")]
		[AsyncStateMachine(typeof(<ReceiveBuffered>d__25))]
		public Task<BufferedMessage> PZFEWIDWKZS(CancellationToken a, [Optional] PSXSXSWTYDW b, [Optional] PSXSXSWTYDW c, [Optional] TimeSpan? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x831EDD0", Offset = "0x831E1D0", VA = "0x18831EDD0")]
		[AsyncStateMachine(typeof(<SyncGuid>d__26))]
		public Task<Guid> MGDMHBUGSTS(Guid a, CancellationToken b, [Optional] PSXSXSWTYDW c, [Optional] PSXSXSWTYDW d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7C10", Offset = "0x3BB7010", VA = "0x183BB7C10")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__27<>))]
		public Task<BufferedMessage<c>> WDBVZXXVYFX<c>(c a, Func<c, byte[]> b, Func<byte[], c> c, CancellationToken d, [Optional] PSXSXSWTYDW e, [Optional] PSXSXSWTYDW f, [Optional] TimeSpan? g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8321A20", Offset = "0x8320E20", VA = "0x188321A20")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveMessage>d__28))]
		public Task<BufferedMessage> WDBVZXXVYFX(byte[] a, CancellationToken b, [Optional] PSXSXSWTYDW c, [Optional] PSXSXSWTYDW d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x831E460", Offset = "0x831D860", VA = "0x18831E460")]
		[AsyncStateMachine(typeof(<MasterSendReceiveWithRetries>d__29))]
		private Task<BufferedMessage> GLBHWOKXIGX(byte[] a, CancellationToken b, PSXSXSWTYDW c, PSXSXSWTYDW d, TimeSpan? e, Stopwatch f, [Optional] Func<bool> g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x831E8D0", Offset = "0x831DCD0", VA = "0x18831E8D0")]
		[AsyncStateMachine(typeof(<MasterSendReceiveSimple>d__30))]
		private Task<BufferedMessage> IVWIZYKOPPX(byte[] a, CancellationToken b, [Optional] PSXSXSWTYDW c, [Optional] PSXSXSWTYDW d, [Optional] TimeSpan? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x831E600", Offset = "0x831DA00", VA = "0x18831E600")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__31))]
		public Task GTZEHSYOWGP(CancellationToken a, Func<CancellationToken, Task> b, [Optional] PSXSXSWTYDW c, [Optional] PSXSXSWTYDW d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB71E0", Offset = "0x3BB65E0", VA = "0x183BB71E0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__32<>))]
		public Task<d> GTZEHSYOWGP<d>(CancellationToken a, Func<CancellationToken, Task<d>> b, [Optional] PSXSXSWTYDW c, [Optional] PSXSXSWTYDW d, int e = 3, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8340", Offset = "0x3BB7740", VA = "0x183BB8340")]
		[AsyncStateMachine(typeof(<TryRunMasterLockedBlock>d__33<>))]
		private Task<(bool, e)> XWIFAYRCPNH<e>(Guid a, CancellationToken b, Func<CancellationToken, Task<e>> c, [Optional] PSXSXSWTYDW d, [Optional] PSXSXSWTYDW e, [Optional] Func<Guid, bool> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x831FAD0", Offset = "0x831EED0", VA = "0x18831FAD0")]
		public void OKQIWPCSQCV(LEKSKUSYOLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x831E760", Offset = "0x831DB60", VA = "0x18831E760")]
		public Guid IFODIYEVOVS(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x831F570", Offset = "0x831E970", VA = "0x18831F570")]
		public bool OCHAIONIOFB(SliceType a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x831EA50", Offset = "0x831DE50", VA = "0x18831EA50")]
		public void KIAAILTFRLR(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x831EA40", Offset = "0x831DE40", VA = "0x18831EA40")]
		private void KDFOMPRLVRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83215C0", Offset = "0x83209C0", VA = "0x1883215C0")]
		internal CombinedSlice TLVHUHKAUQJ(bool a = false)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x831E080", Offset = "0x831D480", VA = "0x18831E080")]
		private HashSet<Guid> DQCAJGLUCXX(SliceType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x831E2A0", Offset = "0x831D6A0", VA = "0x18831E2A0")]
		private void EAIJTGKTNQZ(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8321300", Offset = "0x8320700", VA = "0x188321300")]
		private void TALITEBESKG(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8321C40", Offset = "0x8321040", VA = "0x188321C40")]
		public static Func<Guid, bool> ZCQQWZYSLUN(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8321BA0", Offset = "0x8320FA0", VA = "0x188321BA0")]
		public static Func<Guid, bool> WTUUFFPZJAH(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x831EF40", Offset = "0x831E340", VA = "0x18831EF40")]
		public void MHSQGYCEOJR(SliceType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x831F040", Offset = "0x831E440", VA = "0x18831F040")]
		public void NVYNYLUPCHB(SliceType a, Func<Guid, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83216D0", Offset = "0x8320AD0", VA = "0x1883216D0")]
		private static Dictionary<object, object> VPIFDOXZGYQ(SliceType a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8320B40", Offset = "0x831FF40", VA = "0x188320B40")]
		private void SCYIXATIUHM(SliceType a, Guid b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BufferedEventReceiveTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<(string itemType, long totalStopwatchTicks)> FRRIECXGJQB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public IReadOnlyList<(string itemType, long totalStopwatchTicks)> ProcessedActions
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAAFB60", Offset = "0xAAEF60", VA = "0x180AAFB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83160F0", Offset = "0x83154F0", VA = "0x1883160F0")]
		public BufferedEventReceiveTimeoutException(TimeSpan timeout, List<(string itemType, long totalStopwatchTicks)> processedActions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class EGMDEVGOAVK : MCIHOVNMXXD
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
			[Cpp2IlInjected.Address(RVA = "0x83189F0", Offset = "0x8317DF0", VA = "0x1883189F0")]
			public MasterSwitchMessage(Guid transactionId, int senderActorNumber, int newMasterActorNumber)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8318890", Offset = "0x8317C90", VA = "0x188318890")]
			public static byte[] MFMKHXDBDDO(MasterSwitchMessage a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8318750", Offset = "0x8317B50", VA = "0x188318750")]
			public static MasterSwitchMessage Deserialize(byte[] bytes)
			{
				return default(MasterSwitchMessage);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8318850", Offset = "0x8317C50", VA = "0x188318850")]
			private static byte[] ECZUGHYKHEV(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x83189A0", Offset = "0x8317DA0", VA = "0x1883189A0")]
			private static int UDQRCNXMISJ(byte[] a, int b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly Guid SDARQBNJMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly VFCOBRYCDRN MQKRMKVMWHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private bool RLAZXREIOVU;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83176B0", Offset = "0x8316AB0", VA = "0x1883176B0")]
		public EGMDEVGOAVK(Guid a, VFCOBRYCDRN b, MXHGYCMAQIO c, CancellationToken d, [Optional] ShouldCancelForNewMaster e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8317310", Offset = "0x8316710", VA = "0x188317310", Slot = "5")]
		protected override void RNTFFKRIRHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83174C0", Offset = "0x83168C0", VA = "0x1883174C0", Slot = "6")]
		protected override void SFHRZKWMMQR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8317150", Offset = "0x8316550", VA = "0x188317150")]
		private void PXHZELNZJXG(BufferedMessage a)
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
		[Cpp2IlInjected.Address(RVA = "0x83164F0", Offset = "0x83158F0", VA = "0x1883164F0")]
		public BufferedMessage(CombinedSlice combinedSlice, [CanBeNull] byte[] payload, bool isMasterSwitchMessage, byte senderIdByte, byte messageIdByte)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8316360", Offset = "0x8315760", VA = "0x188316360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8316170", Offset = "0x8315570", VA = "0x188316170")]
		private static void BLCYNTJMWZG(byte[] a, StringBuilder b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct CombinedSlice
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class UASBYVVZKSJ : IEnumerable<Slice>, IEnumerable, IEnumerator<Slice>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private Slice FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CombinedSlice ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public CombinedSlice ARFHFJWNFKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private SliceType[] DJOJRFZZVTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int DJJCTZGCMIP;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private Slice GNDCSSGNCNB
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x2083D20", Offset = "0x2083120", VA = "0x182083D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Slice);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x831DDD0", Offset = "0x831D1D0", VA = "0x18831DDD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1A0A740", Offset = "0x1A09B40", VA = "0x181A0A740")]
			[DebuggerHidden]
			public UASBYVVZKSJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x831DF00", Offset = "0x831D300", VA = "0x18831DF00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x831DE20", Offset = "0x831D220", VA = "0x18831DE20", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x831DE60", Offset = "0x831D260", VA = "0x18831DE60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Slice> UAIBRNSXKCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x831DE60", Offset = "0x831D260", VA = "0x18831DE60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
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
		[Cpp2IlInjected.Address(RVA = "0x8316D80", Offset = "0x8316180", VA = "0x188316D80")]
		public static CombinedSlice NONVZBSAQTQ(SliceType a, Guid b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8316A10", Offset = "0x8315E10", VA = "0x188316A10")]
		public static CombinedSlice LIMUDLXTYUV(List<Slice> a)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8316660", Offset = "0x8315A60", VA = "0x188316660")]
		public static CombinedSlice BTWTSCEMTBP(SliceType a, Guid[] b)
		{
			return default(CombinedSlice);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8316FC0", Offset = "0x83163C0", VA = "0x188316FC0")]
		private CombinedSlice(SliceType combinedSliceType, Guid[] sliceIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8316990", Offset = "0x8315D90", VA = "0x188316990")]
		[IteratorStateMachine(typeof(UASBYVVZKSJ))]
		public IEnumerable<Slice> GHBYMVTUPOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8316E60", Offset = "0x8316260", VA = "0x188316E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ZIWPTHMUVWS
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83224C0", Offset = "0x83218C0", VA = "0x1883224C0")]
		public static string PCMGTORINUS(IDictionary<object, object> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public abstract class DBWRKRYAYUL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x406BF30", Offset = "0x406B330", VA = "0x18406BF30", Slot = "4")]
		public void SerializeTo(a message, IDictionary<object, object> data, bool clearBeforeWrite = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void VIKQOAFPCDO(a a, IDictionary<object, object> b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract a Deserialize(IDictionary<object, object> data);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected DBWRKRYAYUL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class MCIHOVNMXXD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate bool ShouldCancelForNewMaster(int masterClientActorNumber);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool ZZTRGFNCDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		protected readonly MXHGYCMAQIO ZTWCHJPIWPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly CancellationToken FJAWHCFEKXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly CancellationToken CULSPQYZUUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ShouldCancelForNewMaster ZWKSXPHAKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CancellationTokenSource BRWYFHNOGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CancellationTokenSource KIPPTELPGRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly int CWYJBMAPHOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool LBLXFSTSJOG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CancellationToken KLXZFAPDVWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x187AEA0", Offset = "0x187A2A0", VA = "0x18187AEA0")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZRTJTDPRMBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8318340", Offset = "0x8317740", VA = "0x188318340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83183D0", Offset = "0x83177D0", VA = "0x1883183D0")]
		public MCIHOVNMXXD(MXHGYCMAQIO a, CancellationToken b, [Optional] ShouldCancelForNewMaster c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8318140", Offset = "0x8317540", VA = "0x188318140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8318260", Offset = "0x8317660", VA = "0x188318260", Slot = "5")]
		protected virtual void RNTFFKRIRHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83181C0", Offset = "0x83175C0", VA = "0x1883181C0")]
		private void OnMasterClientSwitched(JDMCEZTJJPL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8318160", Offset = "0x8317560", VA = "0x188318160")]
		protected void JAKCWHIWZKF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8318320", Offset = "0x8317720", VA = "0x188318320", Slot = "6")]
		protected virtual void SFHRZKWMMQR(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x4065510", Offset = "0x4064910", VA = "0x184065510")]
		public Slice(SliceType sliceType, Guid sliceId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x831A240", Offset = "0x8319640", VA = "0x18831A240")]
		public bool Equals(Slice other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x831A2A0", Offset = "0x83196A0", VA = "0x18831A2A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x831A360", Offset = "0x8319760", VA = "0x18831A360", Slot = "2")]
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
	internal static class MULWVUXXODC
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		internal static readonly SliceType[] ULPUUZBLBMF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8318600", Offset = "0x8317A00", VA = "0x188318600")]
		public static int TPSGVLUETPC(SliceType a)
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
