using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Circuits.Static.Utilities;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9CA50", Offset = "0x2B9BA50", VA = "0x182B9CA50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class NSBUDFNYKEP : HCFARDHKLRV
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9D0", Offset = "0x2B9B9D0", VA = "0x182B9C9D0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9C0", Offset = "0x2B9B9C0", VA = "0x182B9C9C0")]
		private NSBUDFNYKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CA00", Offset = "0x2B9BA00", VA = "0x182B9CA00")]
		public static NSBUDFNYKEP New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, GIJANZXYKKQ.IULAIVKNAGW<TPartialAction, TPartialActionId, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class UWWKFDVTQDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly TPartialAction?[] NXXWSFEMLYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private int OZYVRQDXKBS;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x10444D0", Offset = "0x10434D0", VA = "0x1810444D0")]
			private UWWKFDVTQDV(TPartialAction[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F25E50", Offset = "0x7F24E50", VA = "0x187F25E50")]
			public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>.UWWKFDVTQDV New(int expectedCount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F26040", Offset = "0x7F25040", VA = "0x187F26040")]
			public Option<TFullAction> PTBOQRPBEQT(TPartialAction a, TDeps b)
			{
				return default(Option<TFullAction>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TPartialActionId, UWWKFDVTQDV>? _reassemblers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Dictionary<TPartialActionId, UWWKFDVTQDV> LJQGOWTQBSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7568F20", Offset = "0x7567F20", VA = "0x187568F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x756A8D0", Offset = "0x75698D0", VA = "0x18756A8D0")]
		private PartialActionReassembly(Dictionary<TPartialActionId, UWWKFDVTQDV>? reassemblers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7568FD0", Offset = "0x7567FD0", VA = "0x187568FD0")]
		public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> New(TDeps deps)
		{
			return default(PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75691E0", Offset = "0x75681E0", VA = "0x1875691E0")]
		public Result<Option<TFullAction>, MCRZZCNKUJE> PTBOQRPBEQT(TPartialAction a)
		{
			return default(Result<Option<TFullAction>, MCRZZCNKUJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7568C80", Offset = "0x7567C80", VA = "0x187568C80")]
		public void DEMTCKDYBVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GIJANZXYKKQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface IULAIVKNAGW<a, out b, out c> where a : notnull where b : notnull where c : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int GYOZEDVJTHM([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int XZQZKIMCQZL([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			b CHVKKTAODFU([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			c HIEOUGRGTSE(a[] a);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LZLNHQMZWLV.IUQHGCEKJSF<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal TPartialSnapshot[] _snapshotParts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int _snapshotCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EAC0", Offset = "0x7B3DAC0", VA = "0x187B3EAC0")]
		internal SnapshotReassembly(TPartialSnapshot[] snapshotParts, int snapshotCount, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EA60", Offset = "0x7B3DA60", VA = "0x187B3EA60")]
		public static SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> New(TDeps deps)
		{
			return default(SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class LZLNHQMZWLV
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface IUQHGCEKJSF<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int DEKSYBOWVWA([In] a partialSnapshot);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			b YLDXUMMOOWC(a[] a);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BF23C0", Offset = "0x3BF13C0", VA = "0x183BF23C0")]
		public static Option<b> PTBOQRPBEQT<b, a, c>(this SnapshotReassembly<a, b, c> a, a b) where c : IUQHGCEKJSF<a, b>
		{
			return default(Option<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1E10", Offset = "0x3BF0E10", VA = "0x183BF1E10")]
		public static bool Discard<TPartialSnapshot, TFullSnapshot, TDeps>(this SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> self, TPartialSnapshot partialSnapshot) where TDeps : IUQHGCEKJSF<TPartialSnapshot, TFullSnapshot>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DWKEZNQLSCI : HCFARDHKLRV
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C990", Offset = "0x2B9B990", VA = "0x182B9C990", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9C0", Offset = "0x2B9B9C0", VA = "0x182B9C9C0")]
		public DWKEZNQLSCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class RHGHGLLFFEI<a, b, c, d, e, f, g, h> where d : DZRBQUPXGSQ.KUIAHXWWOZF<a, b> where e : DZRBQUPXGSQ.PFCXERMDFKQ<a, c> where f : DZRBQUPXGSQ.RHUCFMBNWHH<a, g> where h : DZRBQUPXGSQ.IULAIVKNAGW<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface KCHTRACLBRS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void TRIXXBAQAKY([In] Result<object, MCRZZCNKUJE> result);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Result<object, MCRZZCNKUJE> UIKXFPAHNRL();
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class ZQKAUZPLLMS : KCHTRACLBRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly List<Result<object, YCREHOYWOHO>> DREKYACRQDF;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5149140", Offset = "0x5148140", VA = "0x185149140")]
			public static ZQKAUZPLLMS New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5149490", Offset = "0x5148490", VA = "0x185149490")]
			public void TRIXXBAQAKY([In] Result<object, MCRZZCNKUJE> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5149740", Offset = "0x5148740", VA = "0x185149740", Slot = "5")]
			public Result<object, MCRZZCNKUJE> UIKXFPAHNRL()
			{
				return default(Result<object, MCRZZCNKUJE>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5149940", Offset = "0x5148940", VA = "0x185149940")]
			public ZQKAUZPLLMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5149490", Offset = "0x5148490", VA = "0x185149490", Slot = "4")]
			private void WEUIPOHGFMZ([In] Result<object, MCRZZCNKUJE> result)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class JGZFDACZYTB : KCHTRACLBRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Result<object, MCRZZCNKUJE> NYELVJAIYCW;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x66F4F00", Offset = "0x66F3F00", VA = "0x1866F4F00")]
			public static JGZFDACZYTB New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x25A5800", Offset = "0x25A4800", VA = "0x1825A5800")]
			public void TRIXXBAQAKY([In] Result<object, MCRZZCNKUJE> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00", Slot = "5")]
			public Result<object, MCRZZCNKUJE> UIKXFPAHNRL()
			{
				return default(Result<object, MCRZZCNKUJE>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public JGZFDACZYTB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x25A5800", Offset = "0x25A4800", VA = "0x1825A5800", Slot = "4")]
			private void WEUIPOHGFMZ([In] Result<object, MCRZZCNKUJE> result)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <ProcessAction>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KCHTRACLBRS completionSink;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<a> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KCHTRACLBRS <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<Result<object?, MCRZZCNKUJE>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC8EC0", Offset = "0x6AC7EC0", VA = "0x186AC8EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAA60", Offset = "0x6AC9A60", VA = "0x186ACAA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <ReceiveAction>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6B7ED70", Offset = "0x6B7DD70", VA = "0x186B7ED70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6B7F4E0", Offset = "0x6B7E4E0", VA = "0x186B7F4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <ReceiveActionAsync>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Task lastReceive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public c receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool <wasWaitingForSnapshot>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool <isMyAction>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private KCHTRACLBRS <completion>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6B7ADD0", Offset = "0x6B79DD0", VA = "0x186B7ADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6B7E300", Offset = "0x6B7D300", VA = "0x186B7E300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6CC69A0", Offset = "0x6CC59A0", VA = "0x186CC69A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6CC6FF0", Offset = "0x6CC5FF0", VA = "0x186CC6FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <SendSnapshot>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public a[] snapshotActions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D58CD0", Offset = "0x6D57CD0", VA = "0x186D58CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D59010", Offset = "0x6D58010", VA = "0x186D59010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <SplitSendActionToAll>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder<Result<object, MCRZZCNKUJE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public a[] actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RHGHGLLFFEI<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Id32<WNPWZNYIVVQ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<Result<object, MCRZZCNKUJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6DFB920", Offset = "0x6DFA920", VA = "0x186DFB920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6DFBDE0", Offset = "0x6DFADE0", VA = "0x186DFBDE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly h BIQCNNIQICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool RLXQUOMFXXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int QAXKSGCUVIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Task LUGCLONZLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int MTVWRFIGWSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int PUHVSDUQZQI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private d EYKBEKPNGJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x78260C0", Offset = "0x78250C0", VA = "0x1878260C0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private f YJDSXHZAHFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x781FF10", Offset = "0x781EF10", VA = "0x18781FF10")]
			get
			{
				return (f)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private e NZQKMTVCVBT
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x78239D0", Offset = "0x78229D0", VA = "0x1878239D0")]
			get
			{
				return (e)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FROWRYXZPZS
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE0B760", Offset = "0xE0A760", VA = "0x180E0B760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xE0B750", Offset = "0xE0A750", VA = "0x180E0B750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int KSQKLLCGXDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TQLXOZATEAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int RHWJLKDKCXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD1D340", Offset = "0xD1C340", VA = "0x180D1D340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7826570", Offset = "0x7825570", VA = "0x187826570")]
		public RHGHGLLFFEI(h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7824390", Offset = "0x7823390", VA = "0x187824390")]
		public Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(g a, b b, Id32<WNPWZNYIVVQ> c, a d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78247F0", Offset = "0x78237F0", VA = "0x1878247F0")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<SendActionToAll>d__24))]
		private Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(g a, Id32<WNPWZNYIVVQ> b, a c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78200F0", Offset = "0x781F0F0", VA = "0x1878200F0")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<SplitSendActionToAll>d__25))]
		private Task<Result<object, MCRZZCNKUJE>> KNPYHBHCXAK(g a, Id32<WNPWZNYIVVQ> b, a[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7825A40", Offset = "0x7824A40", VA = "0x187825A40")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<ReceiveAction>d__26))]
		public Task<Result<object, MCRZZCNKUJE>> VCNDPOOUIXD(g a, b b, c c, Id32<WNPWZNYIVVQ> d, a e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78218C0", Offset = "0x78208C0", VA = "0x1878218C0")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<ReceiveActionAsync>d__27))]
		private Task<Result<object, MCRZZCNKUJE>> LRAXSOOIFVN(g a, b b, c c, Id32<WNPWZNYIVVQ> d, a e, Task f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x781F770", Offset = "0x781E770", VA = "0x18781F770")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<ProcessAction>d__31))]
		private Task EVFKAOFVECV(g a, b b, c c, a d, KCHTRACLBRS e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78262A0", Offset = "0x78252A0", VA = "0x1878262A0")]
		private void YLSMDYSGSEV(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x78233E0", Offset = "0x78223E0", VA = "0x1878233E0")]
		private void MBLSJYWVBJE(g a, b b, c c, Id32<WNPWZNYIVVQ> d, a e, bool f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x781F630", Offset = "0x781E630", VA = "0x18781F630")]
		[AsyncStateMachine(typeof(RHGHGLLFFEI<, , , , , , , >.<SendSnapshot>d__34))]
		public Task CCUUWWMEYIQ(g a, b b, Id32<WNPWZNYIVVQ> c, a[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7820710", Offset = "0x781F710", VA = "0x187820710")]
		private (a, int) LESLEAWBJEH(g a, b b, a c)
		{
			return default((a, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class DZRBQUPXGSQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public interface KUIAHXWWOZF<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int KBKRZZJJMWN(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			a NNUKSLXOKOE(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			a PGFEOOHFOVJ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IReadOnlyList<a> PSNLUFMBYVL(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			a[] HHITXMVBLEQ(b a, a b, int c);

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool KNMNEJKTNWZ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool PEPDGBQPMUJ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			bool OKMIZBGNKEZ(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			bool YUZUOYQQKPX(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "9")]
			bool LJDOULWZRSX(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "10")]
			bool JXNJZSVTKXI(b a, a b);
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface IULAIVKNAGW<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			a EYKBEKPNGJQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			b NZQKMTVCVBT
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			c YJDSXHZAHFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface PFCXERMDFKQ<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Id32<WNPWZNYIVVQ> FDVHIIAJUMT(b a);

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SIMZEIXXWZK(b a);

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<object, MCRZZCNKUJE>> VCNDPOOUIXD(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "3")]
			a[] YGJNXDIJIND(b a);
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public interface RHUCFMBNWHH<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int FDEGIOXLPFX(b a);

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int DTRKSXRBFJR(b a);

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			int PEULEIYOSKA(b a);

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			int GTFDDLUNWDO(b a);

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ANMNTYRHGPB(b a);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool RTRMJRKTARW(b a, Id32<WNPWZNYIVVQ> b, a[] c);

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool GCLNRUDHTPE(b a, int b);

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "7")]
			Task<Result<object, MCRZZCNKUJE>> TXBWXIKUHFQ(b a, Id32<WNPWZNYIVVQ> b, a c, bool d = true);
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
