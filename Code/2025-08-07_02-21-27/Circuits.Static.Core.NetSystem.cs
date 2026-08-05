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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF4DD0", Offset = "0x2DF39D0", VA = "0x182DF4DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class KEOZPQBAJRY : NJKZNHRVAZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4D40", Offset = "0x2DF3940", VA = "0x182DF4D40", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4DC0", Offset = "0x2DF39C0", VA = "0x182DF4DC0")]
		private KEOZPQBAJRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4D70", Offset = "0x2DF3970", VA = "0x182DF4D70")]
		public static KEOZPQBAJRY New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, PTFHOSMCVOJ.MQBQDZFUSGT<TPartialAction, TPartialActionId, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class EUZKCNQYGNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly TPartialAction?[] VTAOLTEVWLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private int LHVQCHGCDXL;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1118100", Offset = "0x1116D00", VA = "0x181118100")]
			private EUZKCNQYGNM(TPartialAction[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4CDA9D0", Offset = "0x4CD95D0", VA = "0x184CDA9D0")]
			public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>.EUZKCNQYGNM New(int expectedCount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4CDA7C0", Offset = "0x4CD93C0", VA = "0x184CDA7C0")]
			public Option<TFullAction> KSQJCSMPPCK(TPartialAction a, TDeps b)
			{
				return default(Option<TFullAction>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TPartialActionId, EUZKCNQYGNM>? _reassemblers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Dictionary<TPartialActionId, EUZKCNQYGNM> HODPLEDAQJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x61B57D0", Offset = "0x61B43D0", VA = "0x1861B57D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61B5B10", Offset = "0x61B4710", VA = "0x1861B5B10")]
		private PartialActionReassembly(Dictionary<TPartialActionId, EUZKCNQYGNM>? reassemblers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61B54A0", Offset = "0x61B40A0", VA = "0x1861B54A0")]
		public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> New(TDeps deps)
		{
			return default(PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61B3FF0", Offset = "0x61B2BF0", VA = "0x1861B3FF0")]
		public Result<Option<TFullAction>, JGXPLWKAZER> KSQJCSMPPCK(TPartialAction a)
		{
			return default(Result<Option<TFullAction>, JGXPLWKAZER>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61B5870", Offset = "0x61B4470", VA = "0x1861B5870")]
		public void YVYVTMPYDJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PTFHOSMCVOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface MQBQDZFUSGT<a, out b, out c> where a : notnull where b : notnull where c : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int XWUMJQQQCAD([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int CPOGEMODEWM([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			b FHZTJNEMSMZ([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			c XRCOQPQXOIN(a[] a);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : NOXVGYFJVAA.MPWJGSLXIVK<TPartialSnapshot, TFullSnapshot>
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
		[Cpp2IlInjected.Address(RVA = "0x653CF80", Offset = "0x653BB80", VA = "0x18653CF80")]
		internal SnapshotReassembly(TPartialSnapshot[] snapshotParts, int snapshotCount, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x653CF20", Offset = "0x653BB20", VA = "0x18653CF20")]
		public static SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> New(TDeps deps)
		{
			return default(SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class NOXVGYFJVAA
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface MPWJGSLXIVK<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int TMCJQSHGFUN([In] a partialSnapshot);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			b RNFCKWGOVBJ(a[] a);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA270", Offset = "0x3DB8E70", VA = "0x183DBA270")]
		public static Option<b> KSQJCSMPPCK<b, a, c>(this SnapshotReassembly<a, b, c> a, a b) where c : MPWJGSLXIVK<a, b>
		{
			return default(Option<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9CC0", Offset = "0x3DB88C0", VA = "0x183DB9CC0")]
		public static bool Discard<TPartialSnapshot, TFullSnapshot, TDeps>(this SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> self, TPartialSnapshot partialSnapshot) where TDeps : MPWJGSLXIVK<TPartialSnapshot, TFullSnapshot>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class ZVETLAHOUZJ : NJKZNHRVAZM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4E50", Offset = "0x2DF3A50", VA = "0x182DF4E50", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4DC0", Offset = "0x2DF39C0", VA = "0x182DF4DC0")]
		public ZVETLAHOUZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class MXXKGDIFLPR<a, b, c, d, e, f, g, h> where d : CKZYRSCPJVN.ANUMCWZZTHU<a, b> where e : CKZYRSCPJVN.DDNRUXYNJKJ<a, c> where f : CKZYRSCPJVN.CSUFSUEQYQE<a, g> where h : CKZYRSCPJVN.MQBQDZFUSGT<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface XLHYPDYPBUV
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EYYJYYPOBAZ([In] Result<object, JGXPLWKAZER> result);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Result<object, JGXPLWKAZER> WXDLZOZUMTI();
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class TGGRMYSSCXN : XLHYPDYPBUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly List<Result<object, GOLLTPPMOJR>> MSOKKQQYYHW;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65E7BA0", Offset = "0x65E67A0", VA = "0x1865E7BA0")]
			public static TGGRMYSSCXN New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x65E7AA0", Offset = "0x65E66A0", VA = "0x1865E7AA0")]
			public void EYYJYYPOBAZ([In] Result<object, JGXPLWKAZER> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x65E7D40", Offset = "0x65E6940", VA = "0x1865E7D40", Slot = "5")]
			public Result<object, JGXPLWKAZER> WXDLZOZUMTI()
			{
				return default(Result<object, JGXPLWKAZER>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65E7FD0", Offset = "0x65E6BD0", VA = "0x1865E7FD0")]
			public TGGRMYSSCXN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x65E7AA0", Offset = "0x65E66A0", VA = "0x1865E7AA0", Slot = "4")]
			private void GRBRITWMSJQ([In] Result<object, JGXPLWKAZER> result)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class XJLRMKWJDQE : XLHYPDYPBUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Result<object, JGXPLWKAZER> DPYMPPUTDRZ;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4413780", Offset = "0x4412380", VA = "0x184413780")]
			public static XJLRMKWJDQE New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x29C5AB0", Offset = "0x29C46B0", VA = "0x1829C5AB0")]
			public void EYYJYYPOBAZ([In] Result<object, JGXPLWKAZER> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280", Slot = "5")]
			public Result<object, JGXPLWKAZER> WXDLZOZUMTI()
			{
				return default(Result<object, JGXPLWKAZER>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XJLRMKWJDQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x29C5AB0", Offset = "0x29C46B0", VA = "0x1829C5AB0", Slot = "4")]
			private void GRBRITWMSJQ([In] Result<object, JGXPLWKAZER> result)
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
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

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
			public XLHYPDYPBUV completionSink;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<a> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private XLHYPDYPBUV <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x55C4750", Offset = "0x55C3350", VA = "0x1855C4750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x55CC700", Offset = "0x55CB300", VA = "0x1855CC700", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

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
			public Id32<NAXUEJSETKJ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x55DA270", Offset = "0x55D8E70", VA = "0x1855DA270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x55DB250", Offset = "0x55D9E50", VA = "0x1855DB250", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Task lastReceive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Id32<NAXUEJSETKJ> senderId;

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
			private XLHYPDYPBUV <completion>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x55D96A0", Offset = "0x55D82A0", VA = "0x1855D96A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x55DA0E0", Offset = "0x55D8CE0", VA = "0x1855DA0E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Id32<NAXUEJSETKJ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5620CE0", Offset = "0x561F8E0", VA = "0x185620CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x56218B0", Offset = "0x56204B0", VA = "0x1856218B0", Slot = "5")]
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
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Id32<NAXUEJSETKJ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x56D2D40", Offset = "0x56D1940", VA = "0x1856D2D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x56D3110", Offset = "0x56D1D10", VA = "0x1856D3110", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public a[] actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public MXXKGDIFLPR<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Id32<NAXUEJSETKJ> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x57FD210", Offset = "0x57FBE10", VA = "0x1857FD210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x57FE860", Offset = "0x57FD460", VA = "0x1857FE860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly h KOIFGESKYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool NNBULMEXCZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int NVCNZYRNRXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Task LEHBJYQAYXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int EFTSKPWQMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int ZTUAQBWPJSP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private d UCLDKFGCKUV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEC00", Offset = "0x5EDD800", VA = "0x185EDEC00")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private f VCRSLRIZTTN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5EDFB60", Offset = "0x5EDE760", VA = "0x185EDFB60")]
			get
			{
				return (f)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private e RXVTFWJVISK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5EDEBD0", Offset = "0x5EDD7D0", VA = "0x185EDEBD0")]
			get
			{
				return (e)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CTPZTJZRKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xBF7020", Offset = "0xBF5C20", VA = "0x180BF7020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBF7050", Offset = "0xBF5C50", VA = "0x180BF7050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int XMJEGYOZPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int UNOYQLZPZKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int MILGIRLOJIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB3C3D0", Offset = "0xB3AFD0", VA = "0x180B3C3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EE33F0", Offset = "0x5EE1FF0", VA = "0x185EE33F0")]
		public MXXKGDIFLPR(h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EE14E0", Offset = "0x5EE00E0", VA = "0x185EE14E0")]
		public Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(g a, b b, Id32<NAXUEJSETKJ> c, a d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5EE1380", Offset = "0x5EDFF80", VA = "0x185EE1380")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<SendActionToAll>d__24))]
		private Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(g a, Id32<NAXUEJSETKJ> b, a c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EDEDD0", Offset = "0x5EDD9D0", VA = "0x185EDEDD0")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<SplitSendActionToAll>d__25))]
		private Task<Result<object, JGXPLWKAZER>> HAGIHUTRKGF(g a, Id32<NAXUEJSETKJ> b, a[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFA00", Offset = "0x5EDE600", VA = "0x185EDFA00")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<ReceiveAction>d__26))]
		public Task<Result<object, JGXPLWKAZER>> KREQFJWIICM(g a, b b, c c, Id32<NAXUEJSETKJ> d, a e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0630", Offset = "0x5EDF230", VA = "0x185EE0630")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<ReceiveActionAsync>d__27))]
		private Task<Result<object, JGXPLWKAZER>> SYCPSVAYUVS(g a, b b, c c, Id32<NAXUEJSETKJ> d, a e, Task f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2BB0", Offset = "0x5EE17B0", VA = "0x185EE2BB0")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<ProcessAction>d__31))]
		private Task VFJYFNUDPFS(g a, b b, c c, a d, XLHYPDYPBUV e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0390", Offset = "0x5EDEF90", VA = "0x185EE0390")]
		private void PGALNYITYIU(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE620", Offset = "0x5EDD220", VA = "0x185EDE620")]
		private void CQGTCLRQBRT(g a, b b, c c, Id32<NAXUEJSETKJ> d, a e, bool f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFD30", Offset = "0x5EDE930", VA = "0x185EDFD30")]
		[AsyncStateMachine(typeof(MXXKGDIFLPR<, , , , , , , >.<SendSnapshot>d__34))]
		public Task MQNORXLJDXN(g a, b b, Id32<NAXUEJSETKJ> c, a[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD0B0", Offset = "0x5EDBCB0", VA = "0x185EDD0B0")]
		private (a, int) BTDNDNSTLRC(g a, b b, a c)
		{
			return default((a, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class CKZYRSCPJVN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public interface ANUMCWZZTHU<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int WUJDWWEIQFW(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			a MNCQESCFBTR(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			a DRLFOLBZPJS(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IReadOnlyList<a> YUZXGRDATYC(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			a[] BTSIDZFQYPX(b a, a b, int c);

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool LQITHRXJZTM(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool JERHRNSQHFW(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			bool NPXSWSBYUXM(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			bool BYCWIHPYCUU(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "9")]
			bool WJMUFYLOCLU(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "10")]
			bool YJZHIAOBRLB(b a, a b);
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface MQBQDZFUSGT<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			a UCLDKFGCKUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			b RXVTFWJVISK
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			c VCRSLRIZTTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface DDNRUXYNJKJ<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Id32<NAXUEJSETKJ> MWIBQUIXVCC(b a);

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void CZKNVZEJCRD(b a);

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<object, JGXPLWKAZER>> KREQFJWIICM(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "3")]
			a[] DDKUKJMIWQK(b a);
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public interface CSUFSUEQYQE<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int EVEAETAQEGW(b a);

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int MQAMUWJMKPE(b a);

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			int FOTZMWPLMIN(b a);

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			int FLXODIRSMIZ(b a);

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZUHSUOIBOVK(b a);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool OWYSWTKXADL(b a, Id32<NAXUEJSETKJ> b, a[] c);

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool YDIRSQIOCRR(b a, int b);

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "7")]
			Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(b a, Id32<NAXUEJSETKJ> b, a c, bool d = true);
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
