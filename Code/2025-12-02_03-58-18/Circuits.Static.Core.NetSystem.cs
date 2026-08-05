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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C5A90", Offset = "0x28C4690", VA = "0x1828C5A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DTLUCCNHVDG : WGZNYBELYEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28C5A10", Offset = "0x28C4610", VA = "0x1828C5A10", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28C5A00", Offset = "0x28C4600", VA = "0x1828C5A00")]
		private DTLUCCNHVDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28C5A40", Offset = "0x28C4640", VA = "0x1828C5A40")]
		public static DTLUCCNHVDG New()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, OFHCPGBMCLJ.LGUBDHHAHFH<TPartialAction, TPartialActionId, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class RUKYIRHOPUE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly TPartialAction?[] CFYJPHFMAVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private int CVBAINHBURZ;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD27EC0", Offset = "0xD26AC0", VA = "0x180D27EC0")]
			private RUKYIRHOPUE(TPartialAction[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5ADE910", Offset = "0x5ADD510", VA = "0x185ADE910")]
			public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>.RUKYIRHOPUE New(int expectedCount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5ADE2F0", Offset = "0x5ADCEF0", VA = "0x185ADE2F0")]
			public Option<TFullAction> IYAZURCHEPO(TPartialAction a, TDeps b)
			{
				return default(Option<TFullAction>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TPartialActionId, RUKYIRHOPUE>? _reassemblers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TDeps _deps;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Dictionary<TPartialActionId, RUKYIRHOPUE> BHXLUDFJHWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x59FFB20", Offset = "0x59FE720", VA = "0x1859FFB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x59FFE60", Offset = "0x59FEA60", VA = "0x1859FFE60")]
		private PartialActionReassembly(Dictionary<TPartialActionId, RUKYIRHOPUE>? reassemblers, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59FF7F0", Offset = "0x59FE3F0", VA = "0x1859FF7F0")]
		public static PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps> New(TDeps deps)
		{
			return default(PartialActionReassembly<TPartialAction, TPartialActionId, TFullAction, TDeps>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x59FE320", Offset = "0x59FCF20", VA = "0x1859FE320")]
		public Result<Option<TFullAction>, GGHDNJMZMXZ> IYAZURCHEPO(TPartialAction a)
		{
			return default(Result<Option<TFullAction>, GGHDNJMZMXZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59FFBC0", Offset = "0x59FE7C0", VA = "0x1859FFBC0")]
		public void VEYNQNDLMKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OFHCPGBMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface LGUBDHHAHFH<a, out b, out c> where a : notnull where b : notnull where c : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int UBZSESARFGZ([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int LNZVXJBHOPI([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			b QGAJNZZXVVZ([In] a partialAction);

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "3")]
			c RMWRUYHSHPN(a[] a);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HXOSVQIMUVM.LGOUGANCXTY<TPartialSnapshot, TFullSnapshot>
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
		[Cpp2IlInjected.Address(RVA = "0x5D71070", Offset = "0x5D6FC70", VA = "0x185D71070")]
		internal SnapshotReassembly(TPartialSnapshot[] snapshotParts, int snapshotCount, TDeps deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D71010", Offset = "0x5D6FC10", VA = "0x185D71010")]
		public static SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> New(TDeps deps)
		{
			return default(SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class HXOSVQIMUVM
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public interface LGOUGANCXTY<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int IEVHHJKKPGT([In] a partialSnapshot);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "1")]
			b FZHVTOOHFPL(a[] a);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x36B5540", Offset = "0x36B4140", VA = "0x1836B5540")]
		public static Option<b> IYAZURCHEPO<b, a, c>(this SnapshotReassembly<a, b, c> a, a b) where c : LGOUGANCXTY<a, b>
		{
			return default(Option<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36B4F90", Offset = "0x36B3B90", VA = "0x1836B4F90")]
		public static bool Discard<TPartialSnapshot, TFullSnapshot, TDeps>(this SnapshotReassembly<TPartialSnapshot, TFullSnapshot, TDeps> self, TPartialSnapshot partialSnapshot) where TDeps : LGOUGANCXTY<TPartialSnapshot, TFullSnapshot>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DBVHHLBHBIF : WGZNYBELYEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28C59D0", Offset = "0x28C45D0", VA = "0x1828C59D0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28C5A00", Offset = "0x28C4600", VA = "0x1828C5A00")]
		public DBVHHLBHBIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class MTNHRKQBEEZ<a, b, c, d, e, f, g, h> where d : BFACBNGTTJL.GGKRIQJBKVW<a, b> where e : BFACBNGTTJL.PSEMMSKKBRB<a, c> where f : BFACBNGTTJL.ZGIMNPCIEIW<a, g> where h : BFACBNGTTJL.LGUBDHHAHFH<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface JWZJNZVMAVB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void VDWONKIFJZV([In] Result<object, GGHDNJMZMXZ> result);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Result<object, GGHDNJMZMXZ> OTULOODZYXG();
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class JJXBKESMLPT : JWZJNZVMAVB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly List<Result<object, JGLGQAAJYUN>> HPGFIQMDUYO;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5065180", Offset = "0x5063D80", VA = "0x185065180")]
			public static JJXBKESMLPT New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5065080", Offset = "0x5063C80", VA = "0x185065080")]
			public void VDWONKIFJZV([In] Result<object, GGHDNJMZMXZ> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x50653D0", Offset = "0x5063FD0", VA = "0x1850653D0", Slot = "5")]
			public Result<object, GGHDNJMZMXZ> OTULOODZYXG()
			{
				return default(Result<object, GGHDNJMZMXZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5065630", Offset = "0x5064230", VA = "0x185065630")]
			public JJXBKESMLPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5065080", Offset = "0x5063C80", VA = "0x185065080", Slot = "4")]
			private void DUHWZBJRBRW([In] Result<object, GGHDNJMZMXZ> result)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private sealed class CVONIKCBGLQ : JWZJNZVMAVB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Result<object, GGHDNJMZMXZ> EWPQKZCSYZX;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3CFC3A0", Offset = "0x3CFAFA0", VA = "0x183CFC3A0")]
			public static CVONIKCBGLQ New()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2246910", Offset = "0x2245510", VA = "0x182246910")]
			public void VDWONKIFJZV([In] Result<object, GGHDNJMZMXZ> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0", Slot = "5")]
			public Result<object, GGHDNJMZMXZ> OTULOODZYXG()
			{
				return default(Result<object, GGHDNJMZMXZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CVONIKCBGLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2246910", Offset = "0x2245510", VA = "0x182246910", Slot = "4")]
			private void DUHWZBJRBRW([In] Result<object, GGHDNJMZMXZ> result)
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
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

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
			public JWZJNZVMAVB completionSink;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<a> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private JWZJNZVMAVB <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<Result<object?, GGHDNJMZMXZ>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x500FF90", Offset = "0x500EB90", VA = "0x18500FF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5016800", Offset = "0x5015400", VA = "0x185016800", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

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
			public Id32<VXOAABITZCX> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5025890", Offset = "0x5024490", VA = "0x185025890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5025CD0", Offset = "0x50248D0", VA = "0x185025CD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Task lastReceive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Id32<VXOAABITZCX> senderId;

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
			private JWZJNZVMAVB <completion>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x50218C0", Offset = "0x50204C0", VA = "0x1850218C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5024AF0", Offset = "0x50236F0", VA = "0x185024AF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Id32<VXOAABITZCX> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public a action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x508D380", Offset = "0x508BF80", VA = "0x18508D380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x508D670", Offset = "0x508C270", VA = "0x18508D670", Slot = "5")]
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
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public b receiverNetSys;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Id32<VXOAABITZCX> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5097180", Offset = "0x5095D80", VA = "0x185097180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5097E80", Offset = "0x5096A80", VA = "0x185097E80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<object, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public a[] actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public MTNHRKQBEEZ<a, b, c, d, e, f, g, h> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public g root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Id32<VXOAABITZCX> senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x51B2E10", Offset = "0x51B1A10", VA = "0x1851B2E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x51B3680", Offset = "0x51B2280", VA = "0x1851B3680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly h GSCBNDREEJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool TPQPYZUQUYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int FPYGUYKPCUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Task UCTYROESGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int RHCZNNXPTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int XKZXYXVENFT;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private d UXRPJJYGSOT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5709BC0", Offset = "0x57087C0", VA = "0x185709BC0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private f HGEEJBTONKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5709780", Offset = "0x5708380", VA = "0x185709780")]
			get
			{
				return (f)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private e SQUTMCRJUCQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5708860", Offset = "0x5707460", VA = "0x185708860")]
			get
			{
				return (e)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool QTTFVDNOGNT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAFC0F0", Offset = "0xAFACF0", VA = "0x180AFC0F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAFC7B0", Offset = "0xAFB3B0", VA = "0x180AFC7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int QBMVXHVAWRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB0BC00", Offset = "0xB0A800", VA = "0x180B0BC00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ESQMSOEPXLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int UPXVOWGYDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xABDF90", Offset = "0xABCB90", VA = "0x180ABDF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5709BF0", Offset = "0x57087F0", VA = "0x185709BF0")]
		public MTNHRKQBEEZ(h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5708FE0", Offset = "0x5707BE0", VA = "0x185708FE0")]
		public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(g a, b b, Id32<VXOAABITZCX> c, a d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5708E80", Offset = "0x5707A80", VA = "0x185708E80")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<SendActionToAll>d__24))]
		private Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(g a, Id32<VXOAABITZCX> b, a c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5708B30", Offset = "0x5707730", VA = "0x185708B30")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<SplitSendActionToAll>d__25))]
		private Task<Result<object, GGHDNJMZMXZ>> GXNRRISVRLV(g a, Id32<VXOAABITZCX> b, a[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x57089D0", Offset = "0x57075D0", VA = "0x1857089D0")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<ReceiveAction>d__26))]
		public Task<Result<object, GGHDNJMZMXZ>> FXWPUQGUJCW(g a, b b, c c, Id32<VXOAABITZCX> d, a e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5708D00", Offset = "0x5707900", VA = "0x185708D00")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<ReceiveActionAsync>d__27))]
		private Task<Result<object, GGHDNJMZMXZ>> HKJUJGCZVCC(g a, b b, c c, Id32<VXOAABITZCX> d, a e, Task f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5709400", Offset = "0x5708000", VA = "0x185709400")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<ProcessAction>d__31))]
		private Task NHFPIZUSRDU(g a, b b, c c, a d, JWZJNZVMAVB e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5708C90", Offset = "0x5707890", VA = "0x185708C90")]
		private void GZIPSHWJLPY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x57097B0", Offset = "0x57083B0", VA = "0x1857097B0")]
		private void UGWHOWLJNWD(g a, b b, c c, Id32<VXOAABITZCX> d, a e, bool f, bool g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5708890", Offset = "0x5707490", VA = "0x185708890")]
		[AsyncStateMachine(typeof(MTNHRKQBEEZ<, , , , , , , >.<SendSnapshot>d__34))]
		public Task FXQMZIFRMHT(g a, b b, Id32<VXOAABITZCX> c, a[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5709550", Offset = "0x5708150", VA = "0x185709550")]
		private (a, int) PCEQVJFKQRE(g a, b b, a c)
		{
			return default((a, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class BFACBNGTTJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public interface GGKRIQJBKVW<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int MCLOEYKEGSK(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			a DERKSSJTOCR(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			a GGJGKLHGOFA(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IReadOnlyList<a> SZOEEMZQLUU(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			a[] EWAZCICPRWT(b a, a b, int c);

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool QAQIHJXWFYI(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool HTGXGICUXOC(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			bool UKRPTTVASCU(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			bool ZCBJRIZOQZE(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "9")]
			bool UCEEJSMCTZK(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "10")]
			bool SNCSIZNRKLP(b a, a b);
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface LGUBDHHAHFH<a, b, c>
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			a UXRPJJYGSOT
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			b SQUTMCRJUCQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			c HGEEJBTONKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface PSEMMSKKBRB<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Id32<VXOAABITZCX> RFKSDBTAXME(b a);

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void YVFFECVVFTF(b a);

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<Result<object, GGHDNJMZMXZ>> FXWPUQGUJCW(b a, a b);

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "3")]
			a[] MMSAFUTUBSI(b a);
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public interface ZGIMNPCIEIW<a, b>
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			int ATYYUNSMBGE(b a);

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int WDKMPPXLGGY(b a);

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			int IIDQNLBXFRF(b a);

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			int GUZGQOYBNXF(b a);

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void QAIXRDFEKBU(b a);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			bool XYXZOUVUBGH(b a, Id32<VXOAABITZCX> b, a[] c);

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			bool GHBKDHYPXSF(b a, int b);

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "7")]
			Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(b a, Id32<VXOAABITZCX> b, a c, bool d = true);
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
