using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.All.Mock.RecRoom;
using Circuits.All.Mock.RecRoom.NetSystem;
using Circuits.All.Mock.RecRoom.V2;
using Circuits.All.Mock.RecRoom.V2.NetSystem;
using Circuits.All.RecRoom;
using Circuits.All.RecRoom.Dependencies;
using Circuits.All.RecRoom.Injection;
using Circuits.All.RecRoom.Integration;
using Circuits.Dynamic.Api;
using Circuits.Dynamic.RecRoom.Api;
using Circuits.Shared.Api;
using Circuits.Shared.RecRoom.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Core.RequestReduce;
using Circuits.Static.Mock.Core.NetSystem;
using Circuits.Static.Mock.RecRoom.NetSystem;
using Circuits.Static.RecRoom.Api;
using Circuits.Static.RecRoom.Protobuf;
using CircuitsV2;
using CircuitsV2.Dependencies;
using CircuitsV2.DynamicNetSystem;
using CircuitsV2.Lang;
using CircuitsV2.Lang.Graphs;
using CircuitsV2.Lang.Memory;
using CircuitsV2.Lang.Nodes;
using CircuitsV2.Lang.Nodes.Intrinsic;
using CircuitsV2.Lang.Nodes.Moods;
using CircuitsV2.Lang.Traits;
using CircuitsV2.Persistence;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;

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
		[Cpp2IlInjected.Address(RVA = "0x2868A10", Offset = "0x2867210", VA = "0x182868A10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Circuits.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct RRCV2Dependencies
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class MWWJFNCECER : IQCQWTMRGRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public MWWJFNCECER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0", Slot = "4")]
			public IQCQWTMRGRC IFQNMOYGOQW(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0", Slot = "5")]
			public IQCQWTMRGRC XNHYIUQHGMV(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0", Slot = "6")]
			public IQCQWTMRGRC CXUWZRYQWMV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			public void AXHFTEUJRLO()
			{
			}
		}
	}
}
namespace Circuits.All.Mock
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Todo("All of the methods in this type should use named parameters for clarity.")]
	[Todo("We should move most methods which create objects to their respective type.")]
	[WillBeRenamedTo("CircuitsMockUtil")]
	public static class RZKRAQDXSLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public UBBXDGOYCFP NTJPCPFKLHI;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x286DD60", Offset = "0x286C560", VA = "0x18286DD60")]
			internal UZDPQANMDSF IJZNUCAUBNL(GetNetworkObjectDelegate a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <NewEV>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public YMJQTRDYOVJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public BXZRGPVAATC network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x286B9F0", Offset = "0x286A1F0", VA = "0x18286B9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x286C090", Offset = "0x286A890", VA = "0x18286C090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <NewEV>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public BXZRGPVAATC network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public YMJQTRDYOVJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<SJYBMYLJCNS>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private WUFOVRVICVI <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x286C100", Offset = "0x286A900", VA = "0x18286C100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x286C690", Offset = "0x286AE90", VA = "0x18286C690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <NewLimitedCircuits>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<DisposableOwned<LimitedCircuits>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public UBBXDGOYCFP roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x286C700", Offset = "0x286AF00", VA = "0x18286C700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x286CC10", Offset = "0x286B410", VA = "0x18286CC10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x286B270", Offset = "0x2869A70", VA = "0x18286B270")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? UFRTVDUAYRF([Optional] UBBXDGOYCFP? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x286AF60", Offset = "0x2869760", VA = "0x18286AF60")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> RUPQQTWFWGI(BXZRGPVAATC a, [Optional] YMJQTRDYOVJ? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x286B0E0", Offset = "0x28698E0", VA = "0x18286B0E0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> RUPQQTWFWGI(BXZRGPVAATC a, YMJQTRDYOVJ b, RegistryV2 c, Id32<SJYBMYLJCNS>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x286AE10", Offset = "0x2869610", VA = "0x18286AE10")]
		public static (RuntimeFnRegistry, RuntimeFns) KOJZTMUQHFI()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x286AD10", Offset = "0x2869510", VA = "0x18286AD10")]
		public static (ExternalFnRegistry, ExternalFns) HCHOGOHUYZB()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x286AEE0", Offset = "0x28696E0", VA = "0x18286AEE0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static BXZRGPVAATC NUNIQTCONJC(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class HCKJJJEQJOE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate UZDPQANMDSF CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <End>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<DisposableOwned<EVCreationResult>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public HCKJJJEQJOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x286B600", Offset = "0x2869E00", VA = "0x18286B600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x286B980", Offset = "0x286A180", VA = "0x18286B980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly BXZRGPVAATC URFVQFBZAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? PGJOQSQKEXQ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		private HCKJJJEQJOE(BXZRGPVAATC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28613A0", Offset = "0x285FBA0", VA = "0x1828613A0")]
		public static HCKJJJEQJOE CYOPTWCDXLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2861450", Offset = "0x285FC50", VA = "0x182861450")]
		public HCKJJJEQJOE ZAWXOUPHROF(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28612B0", Offset = "0x285FAB0", VA = "0x1828612B0")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> AXHFTEUJRLO()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class EPVXJFFEUTE : WUFOVRVICVI.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate GWUCTVNWOHE NewCircuitsLifecycleDelegate(USDOVPRHJYZ.ZVDGYJVWQXS deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(WUFOVRVICVI circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(WUFOVRVICVI circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate VHQWUAIWXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate LZGRSQZKAQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate QJQMWERBAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate YDOVLHDTJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate ZRBRDKMMUHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate GDAMFHDMOEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int HLOELWGHGRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x101F410", Offset = "0x101DC10", VA = "0x18101F410", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28605F0", Offset = "0x285EDF0", VA = "0x1828605F0", Slot = "6")]
		public void MWNQCCSIIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28605C0", Offset = "0x285EDC0", VA = "0x1828605C0", Slot = "7")]
		public void CQYOPPXHXVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2860620", Offset = "0x285EE20", VA = "0x182860620", Slot = "5")]
		public GWUCTVNWOHE ZJBTICZALNX(USDOVPRHJYZ.ZVDGYJVWQXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC7DA10", Offset = "0xC7C210", VA = "0x180C7DA10", Slot = "8")]
		public void UYIQLOFRWJY(WUFOVRVICVI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC7DA70", Offset = "0xC7C270", VA = "0x180C7DA70", Slot = "9")]
		public void TVXGPLCNJID(WUFOVRVICVI a, UZPYRKQPSNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2860650", Offset = "0x285EE50", VA = "0x182860650")]
		public EPVXJFFEUTE([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly IMPSIRPQCTD<BXZRGPVAATC, BXZRGPVAATC.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly MFXCORTPMUN<BXZRGPVAATC, BXZRGPVAATC.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly WUFOVRVICVI CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<ZORKRESYKMD> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly BXZRGPVAATC Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2860EB0", Offset = "0x285F6B0", VA = "0x182860EB0")]
		public EVCreationResult(IMPSIRPQCTD<BXZRGPVAATC, BXZRGPVAATC.MockStaticNetSysDeps> staticNetSys, MFXCORTPMUN<BXZRGPVAATC, BXZRGPVAATC.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, WUFOVRVICVI circuitsManager, Id32<ZORKRESYKMD> clientId, BXZRGPVAATC network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly WUFOVRVICVI _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 ZUDYUJWPOSI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2865930", Offset = "0x2864130", VA = "0x182865930")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request KQBNDACPJAY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2865960", Offset = "0x2864160", VA = "0x182865960")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MONBQIUQOND? AHDAIYXMICI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x28659F0", Offset = "0x28641F0", VA = "0x1828659F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public LIKWTTGVGUH? SMTWMJSHTAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2865990", Offset = "0x2864190", VA = "0x182865990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		internal LimitedCircuits(WUFOVRVICVI circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class NRAXMKWEUOE : YMJQTRDYOVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GRBOBWIYTRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public UZDPQANMDSF BCZYZBKFAXX;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public GRBOBWIYTRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			internal UZDPQANMDSF WYKLCRVXTDJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public USDOVPRHJYZ.ZVDGYJVWQXS ZWFVDBYFRZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public WUFOVRVICVI.ZVDGYJVWQXS GWXMDICXLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public UODJRLEVSXT.ZVDGYJVWQXS KYVASCOZIDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI> AIZPACHMDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ZVDGYJVWQXS VMPVWCQGZFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JDJZIVHVKYR ZMXIIHZYOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HBXNNDQOUSM FSGGIZXFAUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JMIZFOBJITY DOXWMKSIFVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GQGQFHQZALQ UZRORNEAVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public UHZWDRMUWQU HMZZDAZSRHV
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2868920", Offset = "0x2867120", VA = "0x182868920")]
		private NRAXMKWEUOE(USDOVPRHJYZ.ZVDGYJVWQXS a, WUFOVRVICVI.ZVDGYJVWQXS b, UODJRLEVSXT.ZVDGYJVWQXS c, ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI> d, CV2Request.ZVDGYJVWQXS e, JDJZIVHVKYR f, HBXNNDQOUSM g, JMIZFOBJITY h, GQGQFHQZALQ i, UHZWDRMUWQU j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2868480", Offset = "0x2866C80", VA = "0x182868480")]
		public static NRAXMKWEUOE? NJSVFZYKXJZ(UODJRLEVSXT.ZVDGYJVWQXS cv2RootSysDeps, [Optional] USDOVPRHJYZ.ZVDGYJVWQXS? a, [Optional] WUFOVRVICVI.ZVDGYJVWQXS? b, [Optional] ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>? reducerDeps, [Optional] CV2Request.ZVDGYJVWQXS? c, [Optional] JDJZIVHVKYR? d, [Optional] HBXNNDQOUSM? e, [Optional] JMIZFOBJITY? f, [Optional] GQGQFHQZALQ? g, [Optional] UHZWDRMUWQU? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28687D0", Offset = "0x2866FD0", VA = "0x1828687D0")]
		public static NRAXMKWEUOE XOMEIUOQIHL(UZDPQANMDSF a, [Optional] USDOVPRHJYZ.ZVDGYJVWQXS? circuitsLifecycleDeps, [Optional] WUFOVRVICVI.ZVDGYJVWQXS? circuitsManagerDeps, [Optional] ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2868110", Offset = "0x2866910", VA = "0x182868110")]
		public static NRAXMKWEUOE KUTOKSGZXCR(GetNetworkObjectDelegate a, [Optional] USDOVPRHJYZ.ZVDGYJVWQXS? circuitsLifecycleDeps, [Optional] WUFOVRVICVI.ZVDGYJVWQXS? circuitsManagerDeps, [Optional] ZLUDVAHINHT.BZZUHUVHMDL<ActionKind, UZPYRKQPSNH, WUFOVRVICVI>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HOLHHMLMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CYJUGVKDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GetNetworkObjectDelegate YCBRGRSLTHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int BXOQNHVOMTT;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CYJUGVKDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x285F4E0", Offset = "0x285DCE0", VA = "0x18285F4E0")]
			internal XHJXGPOIEEW EHFNJUKMRIO(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x285F550", Offset = "0x285DD50", VA = "0x18285F550")]
			internal XHJXGPOIEEW[] EHVIBOSETQP(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
			internal int RHFCNBSJWVN()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CYPBECEAVCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public DynamicEnvironmentNetworkId FYWPEEVYYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CYJUGVKDLRI GPYHOBUULHO;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CYPBECEAVCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x285F6B0", Offset = "0x285DEB0", VA = "0x18285F6B0")]
			internal XHJXGPOIEEW YIRJAVCBYHG(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly XBMWUHKVFEA PHALWSHVVCR;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28614F0", Offset = "0x285FCF0", VA = "0x1828614F0")]
		public static XHJXGPOIEEW? CKBOUGADMXL(Id32<SJYBMYLJCNS>? networkObject, [Optional] XTZGZHBBDQV.SerializesIntoSavesDelegate? a, [Optional] XTZGZHBBDQV.SerializesIntoInventionsDelegate? b, [Optional] XTZGZHBBDQV.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2861510", Offset = "0x285FD10", VA = "0x182861510")]
		public static UZDPQANMDSF? ESZGWFJFRPO(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] MPXBTOPSSLG? b, [Optional] JJNLNGDBNMW? c, [Optional] RAOTZFJBDDG? d, [Optional] UBBXDGOYCFP? e, int f = 300000, bool g = false, bool h = false, [Optional] BDOZCBFUNUO? i, [Optional] WODYAHVHTHI? j, [Optional] DEVUSPJCWGJ? k, [Optional] PKIQFPOYTSE? l, [Optional] QUBDHEIJUTP? m, [Optional] WMQFNJROUJW? n, [Optional] NYCNJIJVNJW.ZVDGYJVWQXS? o, [Optional] EqualsNodeV2.ZVDGYJVWQXS? p, [Optional] DLTGECITYVE? q, [Optional] UZDPQANMDSF.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] UZDPQANMDSF.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] UZDPQANMDSF.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] UZDPQANMDSF.GetLocalRoomIdDelegate? u, [Optional] UZDPQANMDSF.GetLocalSubroomIdDelegate? v, [Optional] UZDPQANMDSF.GetSubroomIdsForLocalRoomDelegate? w, [Optional] UZDPQANMDSF.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] UZDPQANMDSF.SaveRoomOnPlayerBehalfDelegate? z, [Optional] UZDPQANMDSF.ReportCloudDataLedgerChangedDelegate? ba, [Optional] UZDPQANMDSF.GetColorNameByIdDelegate? bb, [Optional] UZDPQANMDSF.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] UZDPQANMDSF.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] UZDPQANMDSF.GetTaggableNameFromSignalDelegate? be, [Optional] UZDPQANMDSF.GetAudioNameFromSignalDelegate? bf, [Optional] UZDPQANMDSF.GetDestinationNameFromSignalDelegate? bg, [Optional] UZDPQANMDSF.GetPlayerEventNameFromSignalDelegate? bh, [Optional] UZDPQANMDSF.GetRoomKeyNameFromSignalDelegate? bi, [Optional] UZDPQANMDSF.GetRewardNameFromSignalDelegate? bj, [Optional] UZDPQANMDSF.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] UZDPQANMDSF.ReportPreloadedAudioChangedDelegate? bl, [Optional] UZDPQANMDSF.ReportRewardDataChangedDelegate? bm, [Optional] UZDPQANMDSF.GetConsumableNameFromSignalDelegate? bn, [Optional] UZDPQANMDSF.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] UZDPQANMDSF.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] UZDPQANMDSF.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] UZDPQANMDSF.GetInventoryItemNameFromSignalDelegate? br, [Optional] UZDPQANMDSF.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] UZDPQANMDSF.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] UZDPQANMDSF.GetRoomOfferNameFromSignalDelegate? bu, [Optional] UZDPQANMDSF.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] UZDPQANMDSF.GetObjectIdFromCreationObjectDelegate? bw, [Optional] UZDPQANMDSF.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] UZDPQANMDSF.GetCostInBytesDelegate? by, [Optional] UZDPQANMDSF.GetAvatarItemNameFromSignalDelegate? bz, [Optional] UZDPQANMDSF.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] UZDPQANMDSF.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] UZDPQANMDSF.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] UZDPQANMDSF.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] UZDPQANMDSF.GetStoreItemNameFromSignalDelegate? ce, [Optional] UZDPQANMDSF.GetBodyPartNameFromSignalDelegate? cf, [Optional] UZDPQANMDSF.GetDependenciesForGraphInstanceDelegate? cg, [Optional] UZDPQANMDSF.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] UZDPQANMDSF.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] UZDPQANMDSF.GetRecNetImageNameFromSignalDelegate? cj, [Optional] UZDPQANMDSF.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] UZDPQANMDSF.IsFunctionValidForAIDelegate? cm, [Optional] UZDPQANMDSF.GetAIFunctionNameFromSignalDelegate? cn)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<SJYBMYLJCNS>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class LMKTWMIKRSO : DEVUSPJCWGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly LMKTWMIKRSO QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GetLocalPlayerDelegate? UCXEYSLTHRH;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2865840", Offset = "0x2864040", VA = "0x182865840", Slot = "4")]
		public (CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO) VUQFRJEBCPG(object a)
		{
			return default((CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO, CHWIRXZHGDO));
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2865810", Offset = "0x2864010", VA = "0x182865810", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "6")]
		public bool WOZOQQPPCVJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xB103A0", Offset = "0xB0EBA0", VA = "0x180B103A0", Slot = "7")]
		public string KGDEWKBNWMP(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public LMKTWMIKRSO([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class XTZGZHBBDQV : XHJXGPOIEEW
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(XTZGZHBBDQV self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(XTZGZHBBDQV self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(XTZGZHBBDQV self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoSavesDelegate NXDCZMKDOXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly SerializesIntoInventionsDelegate DGYZPJWGXOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly CanPublishInInventionsDelegate SUSMMKCZAGO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private OBCVSBYULQO? TCOUATMBRHU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId TOZCCTSBWXR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD41160", Offset = "0xD3F960", VA = "0x180D41160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TDGEQKLVCYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x286EB80", Offset = "0x286D380", VA = "0x18286EB80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LQBBAPBUHHT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x286EB50", Offset = "0x286D350", VA = "0x18286EB50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool PATUGKDTOGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x286EB20", Offset = "0x286D320", VA = "0x18286EB20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TYDGTGQPMVL? ZPUOJFTOUHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<SJYBMYLJCNS>? CQRGOCRUUVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x286E9D0", Offset = "0x286D1D0", VA = "0x18286E9D0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x286E480", Offset = "0x286CC80", VA = "0x18286E480", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(XBMWUHKVFEA e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10", Slot = "13")]
		public void Bind(OBCVSBYULQO controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x286EA70", Offset = "0x286D270", VA = "0x18286EA70")]
		private XTZGZHBBDQV(Id32<SJYBMYLJCNS>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x286E520", Offset = "0x286CD20", VA = "0x18286E520")]
		public static XTZGZHBBDQV? New(Id32<SJYBMYLJCNS>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NEALLNBWWVX : BDOZCBFUNUO
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public delegate float RoundToDecimalPlaceDelegate([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public delegate float TruncateToDecimalPlaceDelegate([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public delegate CircuitsColor CircuitsColorLerpDelegate([In] CircuitsColor a, [In] CircuitsColor b, float t);

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public delegate float CircuitsColorInverseLerpDelegate([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public delegate CircuitsVec3 CircuitsMtx4x4GetPositionDelegate([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public delegate CircuitsQuat CircuitsMtx4x4GetRotationDelegate([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public delegate CircuitsMtx4x4 CircuitsMtx4x4InverseDelegate([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public delegate CircuitsMtx4x4 CircuitsMtx4x4MultiplyDelegate([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate CircuitsMtx4x4 CircuitsRigidTransformGetTranslateRotateMatrixDelegate([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate float CircuitsQuatDotDelegate([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate CircuitsQuat CircuitsQuatFromAngleAxisDelegate(float angle, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate CircuitsQuat CircuitsQuatFromEulerAnglesDelegate([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate CircuitsQuat CircuitsQuatFromFromToRotationDelegate([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate CircuitsQuat CircuitsQuatFromLookRotationDelegate([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public delegate float CircuitsQuatGetAngleBetweenDelegate([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public delegate CircuitsQuat CircuitsQuatInverseDelegate([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate CircuitsQuat CircuitsQuatLerpDelegate([In] CircuitsQuat a, [In] CircuitsQuat b, float t);

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public delegate CircuitsQuat CircuitsQuatLerpUnclampedDelegate([In] CircuitsQuat a, [In] CircuitsQuat b, float t);

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate float CircuitsQuatInverseLerpDelegate([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public delegate CircuitsQuat CircuitsQuatMultiplyDelegate([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public delegate CircuitsQuat CircuitsQuatNormalizeDelegate([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate CircuitsQuat CircuitsQuatRotateTowardsDelegate([In] CircuitsQuat from, [In] CircuitsQuat to, float maxDegreesDelta);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public delegate CircuitsVec3 CircuitsQuatRotateVectorDelegate([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public delegate CircuitsQuat CircuitsQuatSlerpDelegate([In] CircuitsQuat a, [In] CircuitsQuat b, float t);

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public delegate void CircuitsQuatToAngleAxisDelegate([In] CircuitsQuat self, [Out] float angle, [Out] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate CircuitsVec3 CircuitsQuatToEulerAnglesDelegate([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public delegate CircuitsVec3 CircuitsVec3AddDelegate([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public delegate CircuitsVec3 CircuitsVec3ClampMagnitudeDelegate([In] CircuitsVec3 self, [In] float maxLength);

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public delegate CircuitsVec3 CircuitsVec3ClosestPointOnPlaneDelegate([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public delegate CircuitsVec3 CircuitsVec3CrossDelegate([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public delegate float CircuitsVec3DotDelegate([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public delegate float CircuitsVec3AngleDelegate([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate float CircuitsVec3GetMagnitudeDelegate([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate CircuitsVec3 CircuitsVec3LerpDelegate([In] CircuitsVec3 a, [In] CircuitsVec3 b, float t);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public delegate CircuitsVec3 CircuitsVec3LerpUnclampedDelegate([In] CircuitsVec3 a, [In] CircuitsVec3 b, float t);

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public delegate float CircuitsVec3InverseLerpDelegate([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public delegate CircuitsVec3 CircuitsVec3MoveTowardsDelegate([In] CircuitsVec3 current, [In] CircuitsVec3 target, float maxDelta);

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public delegate CircuitsVec3 CircuitsVec3NegateDelegate([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public delegate CircuitsVec3 CircuitsVec3NormalizeDelegate([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public delegate CircuitsVec3 CircuitsVec3ProjectDelegate([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public delegate CircuitsVec3 CircuitsVec3ProjectOnPlaneDelegate([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public delegate CircuitsVec3 CircuitsVec3ScaleDelegate([In] CircuitsVec3 self, float scalar);

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public delegate CircuitsVec3 CircuitsVec3SmoothDampDelegate([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime, [Out] CircuitsVec3 velocity);

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate CircuitsVec3 CircuitsVec3SubtractDelegate([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate CircuitsVec3 CircuitsVec3SlerpDelegate([In] CircuitsVec3 a, [In] CircuitsVec3 b, float t);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate CircuitsVec3 CircuitsVec3TransformDelegate([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate CircuitsVec3 CircuitsVec3InverseTransformDelegate([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate float RealtimeSinceStartupDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly NEALLNBWWVX QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly RoundToDecimalPlaceDelegate? DYXPBOWMVYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TruncateToDecimalPlaceDelegate? QWMUQJSAEVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorLerpDelegate? EFAVSMLUXEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsColorInverseLerpDelegate? LRTJCEIFDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetPositionDelegate? IHKSEVZEAWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4GetRotationDelegate? YGICJIDGFNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4InverseDelegate? MSQUKHYWVFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4MultiplyDelegate? OXJOHCFBKFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? DNJOGPFDDRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatDotDelegate? WHWDABAVOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromAngleAxisDelegate? LYNMHJZFSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? NJHLRCJMQHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromFromToRotationDelegate? KJFLQGXHLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromLookRotationDelegate? NLQWELVIZDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? RVSWMZDMBRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatInverseDelegate? VDHIFXRBJPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpDelegate? TOWPANOTAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatLerpUnclampedDelegate? DSPGKWFBDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatInverseLerpDelegate? YZEADOANFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatMultiplyDelegate? LXKYRVZQOVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatNormalizeDelegate? QKQPVLLVFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateTowardsDelegate? KSGYKIUTRLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatRotateVectorDelegate? BMUZXHJTCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatSlerpDelegate? MNFBDGMEJXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToAngleAxisDelegate? IPZWZDFAQYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatToEulerAnglesDelegate? YCDJSDRTDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3AddDelegate? ITTRIYDMZMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? BPJZFRKYOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? YTMYKXDLEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3CrossDelegate? GIEGGKXGLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3DotDelegate? NZJUCDOIUSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3AngleDelegate? QVODQPUYZBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3GetMagnitudeDelegate? LZJMANZSIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpDelegate? ZQVIDQXQUIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3LerpUnclampedDelegate? QQUDSMNYXTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3InverseLerpDelegate? QQNBXCWCGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3MoveTowardsDelegate? ZPCDADMDGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NegateDelegate? JRLYGMRDICR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3NormalizeDelegate? EKNDFPJVFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectDelegate? YBRULNPISGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? JUPAPQYSOXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ScaleDelegate? MLCDSNOYUHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SmoothDampDelegate? HMSAQPOYRUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SubtractDelegate? ZBTWKAGXTSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SlerpDelegate? PHTVTRWAYXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3TransformDelegate? AHUXOPZUENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3InverseTransformDelegate? NBNOFWNGVJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly RealtimeSinceStartupDelegate? BKBYCFJAKRE;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2867C30", Offset = "0x2866430", VA = "0x182867C30")]
		public NEALLNBWWVX([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2866820", Offset = "0x2865020", VA = "0x182866820")]
		public float ZYCSRYDSALY([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28672E0", Offset = "0x2865AE0", VA = "0x1828672E0")]
		public float RKRMMCUCWBM([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2865DF0", Offset = "0x28645F0", VA = "0x182865DF0")]
		public CircuitsColor CALSDSVVPDF([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2866940", Offset = "0x2865140", VA = "0x182866940")]
		public float KAMHWZMGYXZ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28676F0", Offset = "0x2865EF0", VA = "0x1828676F0")]
		public CircuitsVec3 USPFBTCDBZL([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28674E0", Offset = "0x2865CE0", VA = "0x1828674E0")]
		public CircuitsQuat TALFNEAWNKE([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2866CD0", Offset = "0x28654D0", VA = "0x182866CD0")]
		public CircuitsMtx4x4 LXGAHXSVHDQ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2865D10", Offset = "0x2864510", VA = "0x182865D10")]
		public CircuitsMtx4x4 BLKDNHWIQHU([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28666A0", Offset = "0x2864EA0", VA = "0x1828666A0")]
		public CircuitsMtx4x4 HNRRWQTGAJQ([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2866F40", Offset = "0x2865740", VA = "0x182866F40")]
		public float PAJJGISNWAL([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28663F0", Offset = "0x2864BF0", VA = "0x1828663F0")]
		public CircuitsQuat GKIFOFMNMEC(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28664A0", Offset = "0x2864CA0", VA = "0x1828664A0")]
		public CircuitsQuat SDIGCMADBXP([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2866710", Offset = "0x2864F10", VA = "0x182866710")]
		public CircuitsQuat XZTNPPYJDML([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2867300", Offset = "0x2865B00", VA = "0x182867300")]
		public CircuitsQuat SYJGXDMFWCV([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28661D0", Offset = "0x28649D0", VA = "0x1828661D0")]
		public CircuitsQuat LVJELFJHYFO([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2866A20", Offset = "0x2865220", VA = "0x182866A20")]
		public CircuitsQuat ZVEYOWHVICB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2866270", Offset = "0x2864A70", VA = "0x182866270")]
		public CircuitsQuat GCTFVTHJQZG([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2866840", Offset = "0x2865040", VA = "0x182866840")]
		public float XZLWDWLAQGV([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2865AF0", Offset = "0x28642F0", VA = "0x182865AF0")]
		public CircuitsQuat TIHZKBYTJGE([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2865E50", Offset = "0x2864650", VA = "0x182865E50")]
		public CircuitsQuat COWWEOVERBB([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2867530", Offset = "0x2865D30", VA = "0x182867530")]
		public CircuitsQuat WKQKAOUPBXH([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2867470", Offset = "0x2865C70", VA = "0x182867470")]
		public CircuitsVec3 SJDPMSJSHIU([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2866FD0", Offset = "0x28657D0", VA = "0x182866FD0")]
		public CircuitsQuat ZLJKCOHCTAM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28676B0", Offset = "0x2865EB0", VA = "0x1828676B0")]
		public void ZLXRZKODDZD([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2865F40", Offset = "0x2864740", VA = "0x182865F40")]
		public CircuitsVec3 CQJNPFQQIUW([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2867100", Offset = "0x2865900", VA = "0x182867100")]
		public CircuitsVec3 PNNWSGWMHYL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2865FA0", Offset = "0x28647A0", VA = "0x182865FA0")]
		public CircuitsVec3 CRHRLMDFZEL([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2866B30", Offset = "0x2865330", VA = "0x182866B30")]
		public CircuitsVec3 KVXDPXHLGKY([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2867750", Offset = "0x2865F50", VA = "0x182867750")]
		public CircuitsVec3 VOBRKFZTQOQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2865BA0", Offset = "0x28643A0", VA = "0x182865BA0")]
		public float ALTZKNFMQHN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2866620", Offset = "0x2864E20", VA = "0x182866620")]
		public float VBJEZWDUKXJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2866AE0", Offset = "0x28652E0", VA = "0x182866AE0")]
		public float KJJRPXJGPXE([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2866010", Offset = "0x2864810", VA = "0x182866010")]
		public CircuitsVec3 DRRURSNNABT([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2867990", Offset = "0x2866190", VA = "0x182867990")]
		public CircuitsVec3 ZHBQKOESIPK([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2866B00", Offset = "0x2865300", VA = "0x182866B00")]
		public float ZXBNUVKKZOJ([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2867400", Offset = "0x2865C00", VA = "0x182867400")]
		public CircuitsVec3 SCYRSHBVPDR([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2866C70", Offset = "0x2865470", VA = "0x182866C70")]
		public CircuitsVec3 LVVESOEJWCK([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2866E10", Offset = "0x2865610", VA = "0x182866E10")]
		public CircuitsVec3 NDTNDLEWNVB([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2867830", Offset = "0x2866030", VA = "0x182867830")]
		public CircuitsVec3 WJQXUJHOQYR([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2866080", Offset = "0x2864880", VA = "0x182866080")]
		public CircuitsVec3 FLLHZVHDNWW([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2865CA0", Offset = "0x28644A0", VA = "0x182865CA0")]
		public CircuitsVec3 BLFCCMQNSEO([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2866970", Offset = "0x2865170", VA = "0x182866970")]
		public CircuitsVec3 KBPLDFSLHEQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2867640", Offset = "0x2865E40", VA = "0x182867640")]
		public CircuitsVec3 UODVUDPKJYM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2865BC0", Offset = "0x28643C0", VA = "0x182865BC0")]
		public CircuitsVec3 AMOQGVRCQXK([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2866160", Offset = "0x2864960", VA = "0x182866160")]
		public CircuitsVec3 FVRZRNHEJWI([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28665B0", Offset = "0x2864DB0", VA = "0x1828665B0")]
		public CircuitsVec3 GYWMDNPBZYQ([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2867250", Offset = "0x2865A50", VA = "0x182867250", Slot = "50")]
		public Task QKIPKRUDBDO(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "51")]
		public void NJQUAPRINKY([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2865EF0", Offset = "0x28646F0", VA = "0x182865EF0", Slot = "52")]
		public QRKXCZQCLUH<ICREPLTPBUD> CPHGPFOCMQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28673B0", Offset = "0x2865BB0", VA = "0x1828673B0", Slot = "53")]
		public QRKXCZQCLUH<ICREPLTPBUD> RVKZLHVWLWH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2867970", Offset = "0x2866170", VA = "0x182867970", Slot = "54")]
		public float ZDKVLJATRDH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2866820", Offset = "0x2865020", VA = "0x182866820", Slot = "4")]
		private float JBJYSULTYMY([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28672E0", Offset = "0x2865AE0", VA = "0x1828672E0", Slot = "5")]
		private float SGAMLHGHGYU([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2867910", Offset = "0x2866110", VA = "0x182867910", Slot = "6")]
		private CircuitsColor YNBGGJHQNJH([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2866940", Offset = "0x2865140", VA = "0x182866940", Slot = "7")]
		private float WHRMNNMVZGR([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2866870", Offset = "0x2865070", VA = "0x182866870", Slot = "8")]
		private CircuitsVec3 JVZELGTCVTF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x28675F0", Offset = "0x2865DF0", VA = "0x1828675F0", Slot = "9")]
		private CircuitsQuat UGPCPSQDCIC([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2866640", Offset = "0x2864E40", VA = "0x182866640", Slot = "10")]
		private CircuitsMtx4x4 HMNVBNMFJHC([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2867280", Offset = "0x2865A80", VA = "0x182867280", Slot = "11")]
		private CircuitsMtx4x4 QTGTAHJEVBK([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2866D40", Offset = "0x2865540", VA = "0x182866D40", Slot = "12")]
		private CircuitsMtx4x4 MNHNGWDTKMU([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2866F40", Offset = "0x2865740", VA = "0x182866F40", Slot = "13")]
		private float NXNUYPVQZUN([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28663F0", Offset = "0x2864BF0", VA = "0x1828663F0", Slot = "14")]
		private CircuitsQuat IQCBWEDEPYQ(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28664A0", Offset = "0x2864CA0", VA = "0x1828664A0", Slot = "15")]
		private CircuitsQuat GKZUJIPXSIP([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2866710", Offset = "0x2864F10", VA = "0x182866710", Slot = "16")]
		private CircuitsQuat IHPUWSXPAYB([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2867300", Offset = "0x2865B00", VA = "0x182867300", Slot = "17")]
		private CircuitsQuat RMISBXPYNPN([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x28661D0", Offset = "0x28649D0", VA = "0x1828661D0", Slot = "18")]
		private CircuitsQuat GBMUXVNHKRA([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2866A20", Offset = "0x2865220", VA = "0x182866A20", Slot = "19")]
		private CircuitsQuat KHXHAWPDLBJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2866270", Offset = "0x2864A70", VA = "0x182866270", Slot = "20")]
		private CircuitsQuat MEIBAXMADZA([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2866840", Offset = "0x2865040", VA = "0x182866840", Slot = "21")]
		private float JIVWFAMYQOD([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2865AF0", Offset = "0x28642F0", VA = "0x182865AF0", Slot = "22")]
		private CircuitsQuat AJNVEDNGZZE([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2865E50", Offset = "0x2864650", VA = "0x182865E50", Slot = "23")]
		private CircuitsQuat DQWZQLEACRH([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2867530", Offset = "0x2865D30", VA = "0x182867530", Slot = "24")]
		private CircuitsQuat TEQIJGIOJCD([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2866BA0", Offset = "0x28653A0", VA = "0x182866BA0", Slot = "25")]
		private CircuitsVec3 LAPXWKJXFUK([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2866FD0", Offset = "0x28657D0", VA = "0x182866FD0", Slot = "26")]
		private CircuitsQuat OPREZLYELBU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28676B0", Offset = "0x2865EB0", VA = "0x1828676B0", Slot = "27")]
		private void UOXGDTVJVMP([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28667C0", Offset = "0x2864FC0", VA = "0x1828667C0", Slot = "28")]
		private CircuitsVec3 IRTLQLZROSA([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2866DA0", Offset = "0x28655A0", VA = "0x182866DA0", Slot = "29")]
		private CircuitsVec3 MVGBKJYYCEF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2865C30", Offset = "0x2864430", VA = "0x182865C30", Slot = "30")]
		private CircuitsVec3 AYSHGOLAWPP([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28668D0", Offset = "0x28650D0", VA = "0x1828668D0", Slot = "31")]
		private CircuitsVec3 JZQIHTCWNNY([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x28678A0", Offset = "0x28660A0", VA = "0x1828678A0", Slot = "32")]
		private CircuitsVec3 XIVRSAISRBI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2867A00", Offset = "0x2866200", VA = "0x182867A00", Slot = "33")]
		private CircuitsVec3 ZYRZYMQHZJY([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x28660F0", Offset = "0x28648F0", VA = "0x1828660F0", Slot = "34")]
		private CircuitsVec3 FRMBRRCCZZQ([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2865BA0", Offset = "0x28643A0", VA = "0x182865BA0", Slot = "35")]
		private float COHBNMFZQFT([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2866620", Offset = "0x2864E20", VA = "0x182866620", Slot = "36")]
		private float HKIOLVQBQAV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2866AE0", Offset = "0x28652E0", VA = "0x182866AE0", Slot = "37")]
		private float MWPGJJFTJAA([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2865D80", Offset = "0x2864580", VA = "0x182865D80", Slot = "38")]
		private CircuitsVec3 BSRCOQNTTGL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28671E0", Offset = "0x28659E0", VA = "0x1828671E0", Slot = "39")]
		private CircuitsVec3 PXOBCUUGJWC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2866B00", Offset = "0x2865300", VA = "0x182866B00", Slot = "40")]
		private float KPKBHBQAIAL([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28677C0", Offset = "0x2865FC0", VA = "0x1828677C0", Slot = "41")]
		private CircuitsVec3 VWKLEHZEZIF([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2866C10", Offset = "0x2865410", VA = "0x182866C10", Slot = "42")]
		private CircuitsVec3 LIWIGLNFCXK([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2866EE0", Offset = "0x28656E0", VA = "0x182866EE0", Slot = "43")]
		private CircuitsVec3 NXGCWQRHSKJ([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2866F60", Offset = "0x2865760", VA = "0x182866F60", Slot = "44")]
		private CircuitsVec3 OHLJJPQLZHF([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2867090", Offset = "0x2865890", VA = "0x182867090", Slot = "45")]
		private CircuitsVec3 OVKXMLJWHAY([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2867170", Offset = "0x2865970", VA = "0x182867170", Slot = "46")]
		private CircuitsVec3 PUXGLFQBTKM([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2866330", Offset = "0x2864B30", VA = "0x182866330", Slot = "47")]
		private CircuitsVec3 GEGSFMSFLLI([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2866540", Offset = "0x2864D40", VA = "0x182866540", Slot = "48")]
		private CircuitsVec3 GPUCFHLPHMW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2866E70", Offset = "0x2865670", VA = "0x182866E70", Slot = "49")]
		private CircuitsVec3 NGJKNTLIFLE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class IZTAPEUVOIV : VZASIBUSZVE
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x10A36B0", Offset = "0x10A1EB0", VA = "0x1810A36B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool StopEventExecutionAfterSingleFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xFA98D0", Offset = "0xFA80D0", VA = "0x180FA98D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x28655A0", Offset = "0x2863DA0", VA = "0x1828655A0")]
		public IZTAPEUVOIV(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class TYQWWFWDPIJ : WODYAHVHTHI
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(KWKTECQWUKV e, JSQXMLOBYKQ invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly TYQWWFWDPIJ QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetCircuitsColorFromColorIndexDelegate? ETXCTGYNDGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? VMOSUEQPZES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly InvisibleCollisionSetEnabledDelegate? GOMGAZWWCWP;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB332D0", Offset = "0xB31AD0", VA = "0x180B332D0")]
		public TYQWWFWDPIJ([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x286B410", Offset = "0x2869C10", VA = "0x18286B410", Slot = "4")]
		public CircuitsColor FLVATXSJHEZ(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x286B460", Offset = "0x2869C60", VA = "0x18286B460")]
		public int XRJBCVVIMIP([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x286B460", Offset = "0x2869C60", VA = "0x18286B460", Slot = "5")]
		private int XIHZOZEBDYI([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class BNHVEQYCFSU : MKBYAADBOFT
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class HMEIHYKCFRX
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid WCQFLPGSEFD
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long TVDGLSLMWBM
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int MBRLXZEPVGY
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool UCHUIGTRFBH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1855640", Offset = "0x1853E40", VA = "0x181855640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool PVOWGIEZNFB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x18559F0", Offset = "0x18541F0", VA = "0x1818559F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool KNHOVVLHFSY
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x2861470", Offset = "0x285FC70", VA = "0x182861470")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2861490", Offset = "0x285FC90", VA = "0x182861490")]
			public HMEIHYKCFRX(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly Dictionary<Id128<CATHGSEFVUK>, HMEIHYKCFRX> SGQEILXJWFG;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x285F270", Offset = "0x285DA70", VA = "0x18285F270")]
		public bool XNHFNBGEREB([In] Id128<CATHGSEFVUK> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x285F110", Offset = "0x285D910", VA = "0x18285F110")]
		public void YGLZZYNZNFT([In] Id128<CATHGSEFVUK> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x285F380", Offset = "0x285DB80", VA = "0x18285F380")]
		public void YGLZZYNZNFT([In] Id128<CATHGSEFVUK> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x285EF90", Offset = "0x285D790", VA = "0x18285EF90")]
		public void UGFKQNRDCOE([In] Id128<CATHGSEFVUK> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x285F0B0", Offset = "0x285D8B0", VA = "0x18285F0B0")]
		public void VTXLTAIFZKP([In] Id128<CATHGSEFVUK> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x285F1E0", Offset = "0x285D9E0", VA = "0x18285F1E0")]
		public bool UCHUIGTRFBH([In] Id128<CATHGSEFVUK> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x285F460", Offset = "0x285DC60", VA = "0x18285F460")]
		public BNHVEQYCFSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x285F270", Offset = "0x285DA70", VA = "0x18285F270", Slot = "4")]
		private bool YPKTDRMRYVA([In] Id128<CATHGSEFVUK> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x285F110", Offset = "0x285D910", VA = "0x18285F110", Slot = "5")]
		private void QOEVJIKHMAW([In] Id128<CATHGSEFVUK> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x285EF90", Offset = "0x285D790", VA = "0x18285EF90", Slot = "6")]
		private void LGIDOQGHIAP([In] Id128<CATHGSEFVUK> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x285F0B0", Offset = "0x285D8B0", VA = "0x18285F0B0", Slot = "7")]
		private void MNARGULIMGE([In] Id128<CATHGSEFVUK> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x285F1E0", Offset = "0x285D9E0", VA = "0x18285F1E0", Slot = "8")]
		private bool SFZBKWEKBSU([In] Id128<CATHGSEFVUK> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class XFLXPIEHQDV
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x286E050", Offset = "0x286C850", VA = "0x18286E050")]
		public static LogDeps YKMMPLKWWTS()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class KQCEFEWLEZQ : MeshLibrary.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
		public byte[]? GRWOFUAAUGT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void KZGEVDEVAIC(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KQCEFEWLEZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class QZGRRRIZGEB : MPXBTOPSSLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public delegate bool CanLocalPlayerCreateCurrencyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public delegate void ShowRoomCurrencyCreationUIDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public delegate IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GetAudioClipOptionsDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public delegate IReadOnlyDictionary<Guid, int> GetAudioClipGuidToIndexMapDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public delegate IReadOnlyDictionary<int, Guid> GetAudioClipIndexToGuidMapDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public delegate IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GetAllAudioClipOptionsDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public delegate IReadOnlyDictionary<Guid, int> GetAllAudioClipGuidToIndexMapDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public delegate IReadOnlyDictionary<int, Guid> GetAllAudioClipIndexToGuidMapDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public delegate void PlayAudioPreviewDelegate(AudioClipType clipType, Guid clipGuid);

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public delegate void StopAudioPreviewDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public delegate bool SubscriptionIsActiveDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public delegate bool CanAffordToConvertVariableToCloudVariableDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public delegate void ShowQuickChatEditMenuDelegate(Guid tableId);

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public delegate void ConfigureAttachedObjectDelegate(YPLOSRHQJQG controlPanel, VGSZPQPOABG staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<GEWLTDJAIBZ> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, SPRIBHSTRKT>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, SPRIBHSTRKT>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, SPRIBHSTRKT>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, SPRIBHSTRKT>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> task);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault2>d__132 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AsyncTaskMethodBuilder<Result<MultiResult, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Task<Result<MultiResult, SPRIBHSTRKT>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<Result<MultiResult, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x286CC80", Offset = "0x286B480", VA = "0x18286CC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x286CF40", Offset = "0x286B740", VA = "0x18286CF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault3>d__136 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public AsyncTaskMethodBuilder<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private TaskAwaiter<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x286CFB0", Offset = "0x286B7B0", VA = "0x18286CFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x286D270", Offset = "0x286BA70", VA = "0x18286D270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public AsyncTaskMethodBuilder<Result<None, SPRIBHSTRKT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task<Result<None, SPRIBHSTRKT>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<Result<None, SPRIBHSTRKT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x286D2E0", Offset = "0x286BAE0", VA = "0x18286D2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x286D5A0", Offset = "0x286BDA0", VA = "0x18286D5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<string, EnumChoiceData> FXWOLOZNJOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<int, string> ONSMQUXZCOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<object> HRQEYMIECBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly List<Guid> ZCXZJJLJNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly CanLocalPlayerCreateCurrencyDelegate GDUCRMXUYAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ShowRoomCurrencyCreationUIDelegate IJNFNOHBFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipOptionsDelegate THAFMKUJNCK;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<Guid, int> SGDXCJQKKPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipGuidToIndexMapDelegate JIGRURUELHY;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<int, Guid> AHWTMSWRGKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipIndexToGuidMapDelegate CHFDZIAEPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipOptionsDelegate GXYAZATOKZH;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<Guid, int> LTVRWGVBNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate NFROZJYULDF;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<int, Guid> EBBQPIVEXVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate VOGTDVHHJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly PlayAudioPreviewDelegate RQYEVZOQMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly StopAudioPreviewDelegate CHIDNLHSOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SubscriptionIsActiveDelegate HTAPOXUAIZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate JLTMJHASPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, EnumChoiceData> RPJKTMARNBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly ShowQuickChatEditMenuDelegate EAELEIMCIXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly ConfigureAttachedObjectDelegate USRQMKAJIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DisplayInvalidNameErrorMessageDelegate MVDJWKJSAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly IsStringPureDelegate WOWLFKQJUFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TryGetSpecificChipConfigSummaryDelegate DFNKINWRAFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReleaseIconIdDelegate TJQRRTJADSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate QMRHLKCTIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 DQZIDXGZQBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 DQUBGQNCGQE;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment YBGSQJQQZVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool KOMPWJALQOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> NGKVLZMIWWW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> FGSILQRZWLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> PNXGPHJDBKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> PJPYTTMLOJU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xABA0F0", Offset = "0xAB88F0", VA = "0x180ABA0F0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion FCIYQJTIZXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD6EC30", Offset = "0xD6D430", VA = "0x180D6EC30", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BJTMRWQQTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC48EB0", Offset = "0xC476B0", VA = "0x180C48EB0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JAKPDPNZCBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x28692E0", Offset = "0x2867AE0", VA = "0x1828692E0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool PRTBFTNLCNY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2868C70", Offset = "0x2867470", VA = "0x182868C70", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MVVQCKSJBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAAF540", Offset = "0xAADD40", VA = "0x180AAF540", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2869610", Offset = "0x2867E10", VA = "0x182869610")]
		public QZGRRRIZGEB([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2868E10", Offset = "0x2867610", VA = "0x182868E10", Slot = "9")]
		public bool NBONUXCDUTE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
		public static bool IFTYAFFNJXX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2869210", Offset = "0x2867A10", VA = "0x182869210", Slot = "10")]
		public bool SWMYYWHRNCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public static void XAEEWSWGKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xC7DFD0", Offset = "0xC7C7D0", VA = "0x180C7DFD0", Slot = "11")]
		public void CNOPSZUZJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2868F30", Offset = "0x2867730", VA = "0x182868F30")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> QZFWUXDXHYA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2868B40", Offset = "0x2867340", VA = "0x182868B40", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> AAYHSXOBAFZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2868FB0", Offset = "0x28677B0", VA = "0x182868FB0")]
		private static IReadOnlyDictionary<Guid, int> RXISQDGKITM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x28692B0", Offset = "0x2867AB0", VA = "0x1828692B0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> WFUQPQPHJBT(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2868F60", Offset = "0x2867760", VA = "0x182868F60")]
		private static IReadOnlyDictionary<int, Guid> RKKQIQIWLIK(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2868D40", Offset = "0x2867540", VA = "0x182868D40", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> HXLNTGTGCND(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2868C80", Offset = "0x2867480", VA = "0x182868C80")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EAKEVSBXJVN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2856E10", Offset = "0x2855610", VA = "0x182856E10", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> TKODAVKVEMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x28692F0", Offset = "0x2867AF0", VA = "0x1828692F0")]
		private static IReadOnlyDictionary<Guid, int> WYLZKNLXUBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2868CB0", Offset = "0x28674B0", VA = "0x182868CB0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> ERGQUGZQGOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2869340", Offset = "0x2867B40", VA = "0x182869340", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> XCSPXFSBITU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private static void BNKDGLVSYEY(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2869270", Offset = "0x2867A70", VA = "0x182869270", Slot = "18")]
		public void TRSVVADIQHR(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private static void UGMFGPQZZZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2869000", Offset = "0x2867800", VA = "0x182869000", Slot = "19")]
		public void SEMXICULMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
		private static bool BKXLPXTOUGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2868ED0", Offset = "0x28676D0", VA = "0x182868ED0", Slot = "20")]
		public bool NLPQWMEXUME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
		public static bool AGVSUQYLSXG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2868D10", Offset = "0x2867510", VA = "0x182868D10", Slot = "21")]
		public bool GKYCGZTUVHR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2868CE0", Offset = "0x28674E0", VA = "0x182868CE0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> FXFSHLICFIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> PUDEGJUKZAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> WCINRRUNTCY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2868F00", Offset = "0x2867700", VA = "0x182868F00", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PTBUXJNGCQF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> ZVDBDIAWVKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> OULWNZHIAPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public static void GMUVIHSWCDD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2869460", Offset = "0x2867C60", VA = "0x182869460", Slot = "29")]
		public void ZSQNSIKNTHK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private static void BFVFYPRWLJB(YPLOSRHQJQG a, VGSZPQPOABG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2868BB0", Offset = "0x28673B0", VA = "0x182868BB0", Slot = "35")]
		public void BSLZNOHTIXM(YPLOSRHQJQG a, VGSZPQPOABG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> UAKBREFUCVK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> IHBLLPWWCCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private static void QNMNMBOORDX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2868C10", Offset = "0x2867410", VA = "0x182868C10")]
		private static Task<bool> CLQMDFXCOEJ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2868BE0", Offset = "0x28673E0", VA = "0x182868BE0", Slot = "38")]
		public Task<bool> BYTQZPTNTZG(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2868D70", Offset = "0x2867570", VA = "0x182868D70")]
		private static bool JNKWUHRJHMF(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2868B70", Offset = "0x2867370", VA = "0x182868B70", Slot = "39")]
		public bool ATBYLORTKEE(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private static void XXGEXNOXKXL(Id32<GEWLTDJAIBZ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2869240", Offset = "0x2867A40", VA = "0x182869240", Slot = "40")]
		public void SYKKYYGOFUA(Id32<GEWLTDJAIBZ> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2869370", Offset = "0x2867B70", VA = "0x182869370")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, SPRIBHSTRKT>> ZOMPPVWEFEZ(Task<Result<None, SPRIBHSTRKT>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2868DB0", Offset = "0x28675B0", VA = "0x182868DB0", Slot = "41")]
		public Task<Result<None, SPRIBHSTRKT>> KHJGRMVJLEM(Task<Result<None, SPRIBHSTRKT>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2869120", Offset = "0x2867920", VA = "0x182869120")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, SPRIBHSTRKT>> SHQAXCGLKWJ(Task<Result<MultiResult, SPRIBHSTRKT>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2868D80", Offset = "0x2867580", VA = "0x182868D80", Slot = "42")]
		public Task<Result<MultiResult, SPRIBHSTRKT>> KHJGRMVJLEM(Task<Result<MultiResult, SPRIBHSTRKT>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2869030", Offset = "0x2867830", VA = "0x182869030")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> SHKTZVMOBLA(Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2868DE0", Offset = "0x28675E0", VA = "0x182868DE0", Slot = "43")]
		public Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> KHJGRMVJLEM(Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class RAOTZFJBDDG : FNMAXEDRINV
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(XBMWUHKVFEA e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? VOISZPBMJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate QAZCQUNMBRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly InteropDelegate WAAAUZPNPPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InteropDelegate? QLWPEIKAGUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private InvokeStudioFunctionDelegate? ZWFPOITRBDQ;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "5")]
		public LegacyCV2Result<None> FESXRCNUJES(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		private static LegacyCV2Result<None> Default(XBMWUHKVFEA _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "6")]
		public LegacyCV2Result<None> ZKFWRULKQSD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "7")]
		public LegacyCV2Result<None> BOHWFMSVHGE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "8")]
		public LegacyCV2Result<None> YDQEAVMVWNH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "9")]
		public LegacyCV2Result<None> TYYAGWRLVQJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "15")]
		public LegacyCV2Result<None> INFSULCNCYS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ITGGMMGKODY(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UBQGZNPHGHE(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IQETTIFWYIZ(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DATRZQZRZUM(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FRDILTUIOJF(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LCMIXKFBGUD(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WUAQJWRWJHM(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "93")]
		public LegacyCV2Result<None> RCDESAHPRPZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "94")]
		public LegacyCV2Result<None> PUYLCAOAHZJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "95")]
		public LegacyCV2Result<None> ZXJYUYFYNSM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YSFJCPDIBQE(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(XBMWUHKVFEA e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LQLDHNFSUPI(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HHDBRDGZSZI(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PCVRNJDLWHD(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RDQAZPEJAGM(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KCNLXCLYEXX(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RIOLQDYQOPJ(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YSXGDTLWUEL(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VJSEDYYIFQW(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x12993C0", Offset = "0x1297BC0", VA = "0x1812993C0", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MGXPUNWZRGN(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KMZTXZJKNSC(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "119")]
		public LegacyCV2Result<None> JTKZJVNMDTA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DPQFKCYLDHZ(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "121")]
		public LegacyCV2Result<None> WYASCMBLJZJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "122")]
		public LegacyCV2Result<None> WUNXJOBGIFB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "123")]
		public LegacyCV2Result<None> QSYJNQVWTTN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "124")]
		public LegacyCV2Result<None> IBEVUUBHSBV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "125")]
		public LegacyCV2Result<None> BTICKEPCOPB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "126")]
		public LegacyCV2Result<None> YRNUWUGRCGU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "818")]
		public LegacyCV2Result<None> MMJPAELHMHQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "819")]
		public LegacyCV2Result<None> PLQPZJVTNYO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "147")]
		public LegacyCV2Result<None> VMRAJDVLMNU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "148")]
		public LegacyCV2Result<None> QKHZTHKSGPM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "149")]
		public LegacyCV2Result<None> KAAOJBRCYOB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "150")]
		public LegacyCV2Result<None> YQHPRCZPCBP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "151")]
		public LegacyCV2Result<None> AYVKOZPKWYY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(XBMWUHKVFEA e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(XBMWUHKVFEA e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(XBMWUHKVFEA e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, FNMAXEDRINV.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(XBMWUHKVFEA e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, FNMAXEDRINV.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "174")]
		public LegacyCV2Result<None> CPLVILJFTKF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "175")]
		public LegacyCV2Result<None> RGMOYQOQKIO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "176")]
		public LegacyCV2Result<None> KKHJYSSMIHM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "197")]
		public LegacyCV2Result<None> ELZUDZWECUM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "198")]
		public LegacyCV2Result<None> LFRFDENSGTB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "199")]
		public LegacyCV2Result<None> DGDAGDIBSOO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "200")]
		public LegacyCV2Result<None> WRRXVUKUVVQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "201")]
		public LegacyCV2Result<None> JPRBCAZVKEG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "202")]
		public LegacyCV2Result<None> DREBBMAILOP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "203")]
		public LegacyCV2Result<None> EROTXWZQMUZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "204")]
		public LegacyCV2Result<None> RMFIZJKUQDR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "205")]
		public LegacyCV2Result<None> RWVUCJOJBZJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "206")]
		public LegacyCV2Result<None> XITLKQFIPAP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "207")]
		public LegacyCV2Result<None> HQNXCIUJUAV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "208")]
		public LegacyCV2Result<None> CDKHZMMYHMB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "209")]
		public LegacyCV2Result<None> ZLSBWIUAGAL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "210")]
		public LegacyCV2Result<None> HANWEWVVGMC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "211")]
		public LegacyCV2Result<None> DBJBEKXBOJJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "212")]
		public LegacyCV2Result<None> GETVHHMLTWO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "213")]
		public LegacyCV2Result<None> VNJGXZGPNWZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "214")]
		public LegacyCV2Result<None> NKJJTKABBAS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "215")]
		public LegacyCV2Result<None> NWGDHZTOLNR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "274")]
		public LegacyCV2Result<None> ITOUGCGIVOD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "277")]
		public LegacyCV2Result<None> UNXATJQEGZD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "279")]
		public LegacyCV2Result<None> GCIWNRUJZXS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "280")]
		public LegacyCV2Result<None> MLEKCQRRWWC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "281")]
		public LegacyCV2Result<None> ZWLQKDAEDCT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "282")]
		public LegacyCV2Result<None> MIAAPHIGJDK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "283")]
		public LegacyCV2Result<None> QYVAKALHZRL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "287")]
		public LegacyCV2Result<None> BMVKBGDTGLG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "288")]
		public LegacyCV2Result<None> XUVAZOLOFPH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "317")]
		public LegacyCV2Result<None> EPCBHYDKTZE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "406")]
		public LegacyCV2Result<None> UAEYPJCFFXD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FMGLKUDIKZG(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PCNEOJCZFMY(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MEYHTUAUOUO(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IQAELPMCWXL(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XJYPBLUTJJU(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "416")]
		public LegacyCV2Result<UVWXRTASCGW.CV2DiscoverySectionType> MTIABBFREWR(XBMWUHKVFEA e, CircuitSignal a)
		{
			return default(LegacyCV2Result<UVWXRTASCGW.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "417")]
		public LegacyCV2Result<None> WZBBIGIUBIJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(XBMWUHKVFEA e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KAMAHRFZMHP(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OHAFXNKQMYK(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NKLQIYVYKUP(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "462")]
		public LegacyCV2Result<None> NOCWWVEKKRA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "463")]
		public LegacyCV2Result<None> GYTGRFGJXCL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "464")]
		public LegacyCV2Result<None> KJCRVMFXZSY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "465")]
		public LegacyCV2Result<None> BNQFBUAVYYN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "466")]
		public LegacyCV2Result<None> YDWTHZNDUZP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "467")]
		public LegacyCV2Result<None> ONZNBZJODRB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "468")]
		public LegacyCV2Result<None> PXEEUEAJPVK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "469")]
		public LegacyCV2Result<None> LEJBUMFVKGO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "474")]
		public LegacyCV2Result<None> DMBLYEAJIMM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "475")]
		public LegacyCV2Result<None> XJUTSTGYATG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "476")]
		public LegacyCV2Result<None> DDUMAKUZMMZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "477")]
		public LegacyCV2Result<None> RUZWWJPAIII(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "478")]
		public LegacyCV2Result<None> BTDEPOVJJWY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "479")]
		public LegacyCV2Result<None> QQKJLVEDMFT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(XBMWUHKVFEA executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(XBMWUHKVFEA executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "472")]
		public LegacyCV2Result<None> JRDMIYDXYML(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "473")]
		public LegacyCV2Result<None> PFRRFRVLKSD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "480")]
		public LegacyCV2Result<None> GDUXTUBFDHJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "481")]
		public LegacyCV2Result<None> UOGNSEZGBAD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "482")]
		public LegacyCV2Result<None> EULYSDSVGYY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "483")]
		public LegacyCV2Result<None> TZERSYRQLVU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "484")]
		public LegacyCV2Result<None> CJOFLZEMKGY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "485")]
		public LegacyCV2Result<None> ITTYEGWMWGU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "486")]
		public LegacyCV2Result<None> UJHBHBTMIMG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "487")]
		public LegacyCV2Result<None> OOXDGPNRLUE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "488")]
		public LegacyCV2Result<None> HIBFYWRDEVM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "489")]
		public LegacyCV2Result<None> QONVECOOYMK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "490")]
		public LegacyCV2Result<None> AZRGCOLJGCU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "491")]
		public LegacyCV2Result<None> NWCZFVDQWSU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "492")]
		public LegacyCV2Result<None> HVSCRELYGVI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "493")]
		public LegacyCV2Result<None> HAMQXJIWCIG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "494")]
		public LegacyCV2Result<None> LHCCOXXBOFE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "495")]
		public LegacyCV2Result<None> BIVLCRBVPWU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "496")]
		public LegacyCV2Result<None> XUAUGQVRZHK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "497")]
		public LegacyCV2Result<None> OFAAPQONVDS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "498")]
		public LegacyCV2Result<None> OPMPWPOYBXE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "499")]
		public LegacyCV2Result<None> MBLYIIQDEIE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x286AB20", Offset = "0x2869320", VA = "0x18286AB20", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "507")]
		public LegacyCV2Result<None> WWOOJNCZHVQ(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "508")]
		public LegacyCV2Result<None> LGMJTMAVUSU(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "509")]
		public LegacyCV2Result<None> KCVKTHYFYGA(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "510")]
		public LegacyCV2Result<None> KIBSRCPGHGT(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(XBMWUHKVFEA e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(XBMWUHKVFEA e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(XBMWUHKVFEA e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.GHGLYMHIMAO> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "522")]
		public LegacyCV2Result<None> WESXWWBXSIV(XBMWUHKVFEA e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "525")]
		public LegacyCV2Result<None> WPNDAILYHQZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "527")]
		public LegacyCV2Result<None> VCOYPOZIGFQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "528")]
		public LegacyCV2Result<None> WPUJXEXXOEA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "530")]
		public LegacyCV2Result<None> LTQLOHZWDPS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "531")]
		public LegacyCV2Result<None> LADUZRJGIDN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x286AA00", Offset = "0x2869200", VA = "0x18286AA00", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "533")]
		public LegacyCV2Result<None> HLDHRLGOOIX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x286A9C0", Offset = "0x28691C0", VA = "0x18286A9C0", Slot = "535")]
		public LegacyCV2Result<None> AKIFWGQBVDH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "534")]
		public LegacyCV2Result<None> PIETMMEOIRI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "536")]
		public LegacyCV2Result<None> HNFUHSNVQLU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "537")]
		public LegacyCV2Result<None> EOOVEAEQYKN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "538")]
		public LegacyCV2Result<None> WOAATZCCOBJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "539")]
		public LegacyCV2Result<None> HNCKTICRXQX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "540")]
		public LegacyCV2Result<None> VXZRAHVGBWN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "584")]
		public LegacyCV2Result<None> YOXQMBXMAQO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "587")]
		public LegacyCV2Result<None> DUHZTDWRVYN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "591")]
		public LegacyCV2Result<None> KTYCMAOBQKM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "592")]
		public LegacyCV2Result<None> ZJCSEPKGHQD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "641")]
		public LegacyCV2Result<None> SOXECLYLGNK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "642")]
		public LegacyCV2Result<None> DSDTEFNMWJS(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "643")]
		public LegacyCV2Result<None> TCRMUDQSEFT(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "644")]
		public LegacyCV2Result<None> IYYURBSMYOS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "645")]
		public LegacyCV2Result<None> TJEQZIOLZIO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "646")]
		public LegacyCV2Result<None> XOPFEBXEILJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "649")]
		public LegacyCV2Result<None> ENEQPSZTVGY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "650")]
		public LegacyCV2Result<None> FVFSMPRJURO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "651")]
		public LegacyCV2Result<None> EEETPHJBFHD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "661")]
		public LegacyCV2Result<None> UDRIZVDJOIO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "660")]
		public LegacyCV2Result<None> WCZVNTRGQXT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "662")]
		public LegacyCV2Result<None> LRJRHOICGBC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "663")]
		public LegacyCV2Result<None> QWTKUOGMRKD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "670")]
		public LegacyCV2Result<None> IUJESPQVRRK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "671")]
		public LegacyCV2Result<None> IXMHZSUUBNF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "674")]
		public LegacyCV2Result<None> HZOOHVJENSR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "675")]
		public LegacyCV2Result<None> DMHTJXYMXOM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(XBMWUHKVFEA e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "696")]
		public LegacyCV2Result<None> KDSXTCSZRAO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "697")]
		public LegacyCV2Result<None> SAWZFCQKWWI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "698")]
		public LegacyCV2Result<None> BVOFIFJZAFW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "699")]
		public LegacyCV2Result<None> TRPOVPGDCRZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "700")]
		public LegacyCV2Result<None> WVTJXQWHVJV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "676")]
		public LegacyCV2Result<None> CRYMBWERHWQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "677")]
		public LegacyCV2Result<None> KTEWOJIKGPQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "678")]
		public LegacyCV2Result<None> RGJZNVERKBB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "679")]
		public LegacyCV2Result<None> KHDXIMKOJLE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "680")]
		public LegacyCV2Result<None> GUMDSSWRZKZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "681")]
		public LegacyCV2Result<None> NVJQYIJDCMM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "682")]
		public LegacyCV2Result<None> ASIXQZKHMBI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "683")]
		public LegacyCV2Result<None> JFSZTIBULPB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "684")]
		public LegacyCV2Result<None> MJCTJZLGJCX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "685")]
		public LegacyCV2Result<None> JBIYSOYLUMS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "686")]
		public LegacyCV2Result<None> QXUNCAMBABC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "687")]
		public LegacyCV2Result<None> KHTYFNSRDEV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "688")]
		public LegacyCV2Result<None> XTWGUCVIGBA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "689")]
		public LegacyCV2Result<None> EAOHSDSIDLY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "690")]
		public LegacyCV2Result<None> KOSPSPYZVNV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "691")]
		public LegacyCV2Result<None> LPXBVYOOKTT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "692")]
		public LegacyCV2Result<None> XXYCHBFMLDV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "693")]
		public LegacyCV2Result<None> SQVZEYKECME(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "765")]
		public LegacyCV2Result<None> FQEURIBZOCA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "711")]
		public LegacyCV2Result<None> HNFHLTCJNGZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "712")]
		public LegacyCV2Result<None> KJVYEIUPGDV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "713")]
		public LegacyCV2Result<None> ALRMGBQOCDP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "714")]
		public LegacyCV2Result<None> WXSNKNUJENF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "717")]
		public LegacyCV2Result<None> GLGZXYNTJHV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "721")]
		public LegacyCV2Result<None> GTURNONTQJQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "722")]
		public LegacyCV2Result<None> LSGSVGMVKKE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "723")]
		public LegacyCV2Result<None> LUWUQOYLSXZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "724")]
		public LegacyCV2Result<None> OWTOXJADOTX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "725")]
		public LegacyCV2Result<None> UKTDWCRSIXP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "726")]
		public LegacyCV2Result<None> YWADWZFGCMY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "727")]
		public LegacyCV2Result<None> HUDAPEKBDFH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "728")]
		public LegacyCV2Result<None> PGVQVILLIXK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "729")]
		public LegacyCV2Result<None> UEZQHNZRPQA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "730")]
		public LegacyCV2Result<None> HGZMXVIOINC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "731")]
		public LegacyCV2Result<None> NENQPLNGFAI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "732")]
		public LegacyCV2Result<None> MZGQSKEZFNK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "733")]
		public LegacyCV2Result<None> EPCJITWLJDY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "734")]
		public LegacyCV2Result<None> DJVTYIYLTMN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "735")]
		public LegacyCV2Result<None> YEEABRIMCGI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "736")]
		public LegacyCV2Result<None> FVBVQRQPRHE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "737")]
		public LegacyCV2Result<None> UGFHXSDIMYR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "738")]
		public LegacyCV2Result<None> TSTFOMKYJUC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "740")]
		public LegacyCV2Result<None> YCBZKWGWWCQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "739")]
		public LegacyCV2Result<None> AFVGABDFWWC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "741")]
		public LegacyCV2Result<None> JMZSNBEGUOH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "742")]
		public LegacyCV2Result<None> YKZYRXJZFCG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "743")]
		public LegacyCV2Result<None> UVJBAVBFMVD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "744")]
		public LegacyCV2Result<None> TGKAPVHBULD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "745")]
		public LegacyCV2Result<None> ZUKJQHAQPUE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "746")]
		public LegacyCV2Result<None> OLZAIRQAYAN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "747")]
		public LegacyCV2Result<None> NNURRKUQXQB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "748")]
		public LegacyCV2Result<None> DJZMBVWZNAK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "749")]
		public LegacyCV2Result<None> QLUMFLWABTK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "750")]
		public LegacyCV2Result<None> FXKIQWHWUAW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "751")]
		public LegacyCV2Result<None> IYEQPIPIHUO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "752")]
		public LegacyCV2Result<None> FLBFQWYDGSE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "753")]
		public LegacyCV2Result<None> NBYXCGVGIFG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "754")]
		public LegacyCV2Result<None> HWBGILVRLQU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "755")]
		public LegacyCV2Result<None> MFWOLRJHGGV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "756")]
		public LegacyCV2Result<None> JEUEQYEUOJT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "757")]
		public LegacyCV2Result<None> AMHAZMEFDAT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "758")]
		public LegacyCV2Result<None> BQDPPBIXAUN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "759")]
		public LegacyCV2Result<None> ZNTOIAISKKO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "760")]
		public LegacyCV2Result<None> YQHKMXGLZOW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "761")]
		public LegacyCV2Result<None> WJFULPFQGKG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "762")]
		public LegacyCV2Result<None> UCFVOTTCIAD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "763")]
		public LegacyCV2Result<None> ZLQBJJFYTUV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "764")]
		public LegacyCV2Result<None> ZTHNJFUXHAG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "771")]
		public LegacyCV2Result<None> INOENTOPXSO(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "772")]
		public LegacyCV2Result<None> KBGFARNWIHK(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "773")]
		public LegacyCV2Result<None> KHOUQQSTPIR(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(XBMWUHKVFEA ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "775")]
		public LegacyCV2Result<None> IRWTZZQXGQT(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "776")]
		public LegacyCV2Result<None> ZFVAIPWHRJH(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "777")]
		public LegacyCV2Result<None> WQCZGRAZXQI(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "778")]
		public LegacyCV2Result<None> GRKBDWVFWYQ(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "779")]
		public LegacyCV2Result<None> TRNOXRCYWPE(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "707")]
		public LegacyCV2Result<None> HDIFMEVWYQK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "801")]
		public LegacyCV2Result<None> VGDYMILILYS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "802")]
		public LegacyCV2Result<None> FVJNDJUUHKK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "803")]
		public LegacyCV2Result<None> GTHQGOBNUGC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "804")]
		public LegacyCV2Result<None> ASHSDQFWVVC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "805")]
		public LegacyCV2Result<None> CIONZQSXVXM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "806")]
		public LegacyCV2Result<None> XURHQTZAPWS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "807")]
		public LegacyCV2Result<None> PGPZOSVJICK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "808")]
		public LegacyCV2Result<None> XSFEAHLLNQM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "809")]
		public LegacyCV2Result<None> BIAZUKJUNIS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "810")]
		public LegacyCV2Result<None> LYNMUIXEFVA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "811")]
		public LegacyCV2Result<None> UYEHMYPRCRW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "812")]
		public LegacyCV2Result<None> XMFLZXQDJDR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "817")]
		public LegacyCV2Result<None> HEZYUWGWNBK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "821")]
		public LegacyCV2Result<None> BPHRDWSGIML(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "822")]
		public LegacyCV2Result<None> NQOWKMOIICJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "823")]
		public LegacyCV2Result<None> UNASNUVDTPX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "824")]
		public LegacyCV2Result<None> VFUHKTKNVEX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "826")]
		public LegacyCV2Result<None> VLUVXQEGHXF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "827")]
		public LegacyCV2Result<None> GZLKSISWDKA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "828")]
		public LegacyCV2Result<None> FZGUZHAPIBA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "831")]
		public LegacyCV2Result<None> WPUXMHAIJJY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "832")]
		public LegacyCV2Result<None> NXAJSXXDXVJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "833")]
		public LegacyCV2Result<None> FAEDFOBNIOO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(XBMWUHKVFEA e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "836")]
		public LegacyCV2Result<None> SYGRTKYDBDH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WKVANSFNBXN(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OOXJCJKONYT(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XBJZSQOBTWC(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> URFUQHDCCYH(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GNZHSQXOXQI(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(XBMWUHKVFEA e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(XBMWUHKVFEA e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(XBMWUHKVFEA e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "856")]
		public LegacyCV2Result<None> LYDWIUENUQF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "859")]
		public LegacyCV2Result<None> PWOZBFRPNDP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "860")]
		public LegacyCV2Result<None> ROUFYSWYUSH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "861")]
		public LegacyCV2Result<None> GAAXGITHXYR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "862")]
		public LegacyCV2Result<None> EVOZZDCPCYM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "864")]
		public LegacyCV2Result<None> FIPJBKKZNCJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "865")]
		public LegacyCV2Result<None> JCBSDRRXYPT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(XBMWUHKVFEA e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "869")]
		public LegacyCV2Result<None> AWKYNEKFDCH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "879")]
		public LegacyCV2Result<None> HRZTRDZUXVH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "880")]
		public LegacyCV2Result<None> QHIAAZKQPBT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "881")]
		public LegacyCV2Result<None> AKHPVFWUABW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "882")]
		public LegacyCV2Result<None> HUPKGQUFZQV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(XBMWUHKVFEA e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(XBMWUHKVFEA e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(XBMWUHKVFEA e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(XBMWUHKVFEA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "889")]
		public LegacyCV2Result<None> PYDGGXDPSKT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "890")]
		public LegacyCV2Result<None> PRIRKRAUNTK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "891")]
		public LegacyCV2Result<None> PWLDDMHATOP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "892")]
		public LegacyCV2Result<None> DHAIQGRMOIP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "893")]
		public LegacyCV2Result<None> SQYFYAJPSMR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "897")]
		public LegacyCV2Result<None> ANIXZJZMDSO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "898")]
		public LegacyCV2Result<None> CDZQKIAGVGC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "899")]
		public LegacyCV2Result<None> EOVCCEOUQZX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "901")]
		public LegacyCV2Result<None> KVTGZFNGROF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "900")]
		public LegacyCV2Result<None> CHOVZJUMYMP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "902")]
		public LegacyCV2Result<None> VTLTUSGOZOO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "904")]
		public LegacyCV2Result<None> ANWMISDMWJQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "903")]
		public LegacyCV2Result<None> AEVVNYXOXXM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "905")]
		public LegacyCV2Result<None> FIQXCYQVOTV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "906")]
		public LegacyCV2Result<None> CEAUJXJMDRR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "907")]
		public LegacyCV2Result<None> VLCVHDAKLBS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "908")]
		public LegacyCV2Result<None> MUEUFVDEVES(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "909")]
		public LegacyCV2Result<None> IQNFSEZHOZK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "910")]
		public LegacyCV2Result<None> POIKFWXQUYE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "911")]
		public LegacyCV2Result<None> YMPYRZPCMMI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "918")]
		public LegacyCV2Result<None> XJYEOCKQJOC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "919")]
		public LegacyCV2Result<None> GGXBEUHNCFG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(XBMWUHKVFEA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "941")]
		public LegacyCV2Result<None> IPTQIKBKNPM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "942")]
		public LegacyCV2Result<None> HTBKEMTBSXC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "943")]
		public LegacyCV2Result<None> SEODRHKWGWP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "944")]
		public LegacyCV2Result<None> NIZADDWBMUD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "945")]
		public LegacyCV2Result<None> HFQYILURBNY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "946")]
		public LegacyCV2Result<None> LVDPQBTNCVQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "947")]
		public LegacyCV2Result<None> FKTSVLSSAGR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "948")]
		public LegacyCV2Result<None> FQRUOTJXJBZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "949")]
		public LegacyCV2Result<None> YCUQTGWJYMB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "950")]
		public LegacyCV2Result<None> JWYVXABLNDK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "968")]
		public LegacyCV2Result<None> DDCHFPHJJYU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "967")]
		public LegacyCV2Result<None> JUUGFNAUDAL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "969")]
		public LegacyCV2Result<None> TQPSVXJXWAX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "970")]
		public LegacyCV2Result<None> UIWOUGQAKZM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "971")]
		public LegacyCV2Result<None> NEDODZNSROH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "972")]
		public LegacyCV2Result<None> GINHIGKPQIV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "973")]
		public LegacyCV2Result<None> ZQOQWFWZAMK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "975")]
		public LegacyCV2Result<None> OVVEVJMVXUJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "982")]
		public LegacyCV2Result<None> GXMEBXLPZFO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "983")]
		public LegacyCV2Result<None> IWUUIYZPHWQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "991")]
		public LegacyCV2Result<None> RPLCZYLOKFV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "993")]
		public LegacyCV2Result<None> JPUHPTCAVHV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "994")]
		public LegacyCV2Result<None> VJNIKIPWXEB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "995")]
		public LegacyCV2Result<None> NTMRLGEFMPX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "996")]
		public LegacyCV2Result<None> IMSLOWBTYHB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "997")]
		public LegacyCV2Result<None> BTVCRJLRCJP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "998")]
		public LegacyCV2Result<None> RXGEPYRQDXL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "999")]
		public LegacyCV2Result<None> MWJJUAVXJHN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1000")]
		public LegacyCV2Result<None> JNLFOLCOLYX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1001")]
		public LegacyCV2Result<None> DOFVLMENFTV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1002")]
		public LegacyCV2Result<None> UBXEBHEAJQX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1009")]
		public LegacyCV2Result<None> MOFLQVXEBAT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1017")]
		public LegacyCV2Result<None> VWXEGZGGMQW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1018")]
		public LegacyCV2Result<None> IMNNGKUAOUV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1019")]
		public LegacyCV2Result<None> ZNEJLWIKQSG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1020")]
		public LegacyCV2Result<None> AEHIFENAHWZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1021")]
		public LegacyCV2Result<None> UPRZVUQDFFK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1022")]
		public LegacyCV2Result<None> QKCKOEFYWPX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1023")]
		public LegacyCV2Result<None> CLYLCFGTQEM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1024")]
		public LegacyCV2Result<None> IJOBDDQOXNS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1025")]
		public LegacyCV2Result<None> GBWFISCDODR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1026")]
		public LegacyCV2Result<None> YQDISSPCKAK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1027")]
		public LegacyCV2Result<None> VXDJMZBSCEU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1028")]
		public LegacyCV2Result<None> XCCTWIMYNWB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1029")]
		public LegacyCV2Result<None> CGRYDSDXXOX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1030")]
		public LegacyCV2Result<None> OYNPQSCUTNS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1031")]
		public LegacyCV2Result<None> SZEJTYEDLHR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1032")]
		public LegacyCV2Result<None> JBUUONHQRIY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1033")]
		public LegacyCV2Result<None> DXJVURFHWMU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1047")]
		public LegacyCV2Result<None> ZIMRATCBGDG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1048")]
		public LegacyCV2Result<None> XTLUISHBBTW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1049")]
		public LegacyCV2Result<None> EMATMMQFNAS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1050")]
		public LegacyCV2Result<None> GLWUCHQGNPQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1051")]
		public LegacyCV2Result<None> FYNEXUNUBHB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1052")]
		public LegacyCV2Result<None> YLUJNOJQAXB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1053")]
		public LegacyCV2Result<None> CVHXVVZFRNM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1054")]
		public LegacyCV2Result<None> WCCSLDMALVZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1055")]
		public LegacyCV2Result<None> QKLZRCHYKPQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1056")]
		public LegacyCV2Result<None> VSQAQTFDTCZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1057")]
		public LegacyCV2Result<None> TQXIFIHJVQD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1058")]
		public LegacyCV2Result<None> VHUNMJQXEYC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1059")]
		public LegacyCV2Result<None> UXDSEYBAKJD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1060")]
		public LegacyCV2Result<None> FOLDLWEZFBB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1061")]
		public LegacyCV2Result<None> AEGCQMQPWHN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1062")]
		public LegacyCV2Result<None> URQRODMIPOX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1063")]
		public LegacyCV2Result<None> BIVPTTDWLLZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1064")]
		public LegacyCV2Result<None> UQOMFKPKBEK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1065")]
		public LegacyCV2Result<None> ENDDLKJLFWC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1066")]
		public LegacyCV2Result<None> ZRDDJMMWHRL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1067")]
		public LegacyCV2Result<None> DQHBUIXBHYR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1068")]
		public LegacyCV2Result<None> NSKVWCURYUD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1069")]
		public LegacyCV2Result<None> WUFDATJMHIL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1070")]
		public LegacyCV2Result<None> XILJRODGEQS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1071")]
		public LegacyCV2Result<None> DOOUQTFFVDU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x286AA40", Offset = "0x2869240", VA = "0x18286AA40", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(XBMWUHKVFEA e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(XBMWUHKVFEA e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1092")]
		public LegacyCV2Result<None> FNXSZHYWXBF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1093")]
		public LegacyCV2Result<None> ZUMDYBUPIEC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1094")]
		public LegacyCV2Result<None> HQVCGZMQHEK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1095")]
		public LegacyCV2Result<None> ELWPHHEACIK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1096")]
		public LegacyCV2Result<None> WCEIGGXVCZU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1097")]
		public LegacyCV2Result<None> XSSOHMLYPDM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1098")]
		public LegacyCV2Result<None> HNLEYWMDXHI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1099")]
		public LegacyCV2Result<None> XAVSKZJGDZK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1100")]
		public LegacyCV2Result<None> YZIBQYVUMEU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1101")]
		public LegacyCV2Result<None> PQHECRFIWEI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1102")]
		public LegacyCV2Result<None> RHBAVCFEMWY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1103")]
		public LegacyCV2Result<None> PGJPVKDHIHV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1104")]
		public LegacyCV2Result<None> LVGXNTVKONN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1105")]
		public LegacyCV2Result<None> FDBJMXYBXNF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1106")]
		public LegacyCV2Result<None> EZTDSHUAFKX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1107")]
		public LegacyCV2Result<None> MBZZLZRVUZU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1108")]
		public LegacyCV2Result<None> UBLCRKKXEEK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1109")]
		public LegacyCV2Result<None> BLFLSNPPGMJ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1110")]
		public LegacyCV2Result<None> EHJNENXLQXX(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1111")]
		public LegacyCV2Result<None> LKUFJTZSCIL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1112")]
		public LegacyCV2Result<None> HLXNOPCSHUT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1113")]
		public LegacyCV2Result<None> VRUJFMXGRHA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1114")]
		public LegacyCV2Result<None> CTNGUHLQTRA(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1115")]
		public LegacyCV2Result<None> HOBGEMBDHGT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1116")]
		public LegacyCV2Result<None> LIOEVQSQGGD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1117")]
		public LegacyCV2Result<None> BUPCBOCUFPR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1118")]
		public LegacyCV2Result<None> SBVFYCWODRR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1119")]
		public LegacyCV2Result<None> DEUBSECQASO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1120")]
		public LegacyCV2Result<None> OTAFTTJLGVR(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1121")]
		public LegacyCV2Result<None> YMPPYTOKCKN(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1122")]
		public LegacyCV2Result<None> AXPXLAMTWFT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1123")]
		public LegacyCV2Result<None> HEXMWAAILYY(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1124")]
		public LegacyCV2Result<None> QWVODWNFHXG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1125")]
		public LegacyCV2Result<None> FZJXIMVAGDE(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1126")]
		public LegacyCV2Result<None> EISIRDNUFQC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1127")]
		public LegacyCV2Result<None> NCTNPNUJCVC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1128")]
		public LegacyCV2Result<None> JJMOGYQHXME(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1129")]
		public LegacyCV2Result<None> FEDMKGGRMKY(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1130")]
		public LegacyCV2Result<None> UEDBIUYCDMR(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1131")]
		public LegacyCV2Result<None> KKNRTVRDNPU(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1132")]
		public LegacyCV2Result<None> NIPHGQPZEQZ(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1133")]
		public LegacyCV2Result<None> YEAZTZTWKUC(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1134")]
		public LegacyCV2Result<None> FRBLBHWMFIC(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1135")]
		public LegacyCV2Result<None> SFRNMIDTCNT(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1136")]
		public LegacyCV2Result<None> HJFCBDFPQOB(KWKTECQWUKV e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1140")]
		public LegacyCV2Result<None> FWTFSZXBGDB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1166")]
		public LegacyCV2Result<None> KKNGHWRVKCN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1168")]
		public LegacyCV2Result<None> AFACFMHLYJD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1169")]
		public LegacyCV2Result<None> JDENQVBKBQI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1170")]
		public LegacyCV2Result<None> PZWEYPRSIID(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1171")]
		public LegacyCV2Result<None> PRDBLJMDKSK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1182")]
		public LegacyCV2Result<None> PPVNBLITTVY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1183")]
		public LegacyCV2Result<None> MLLNDDGAEAW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1184")]
		public LegacyCV2Result<None> ZXFHDHJIHPG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1185")]
		public LegacyCV2Result<None> YHCXFZUEJKQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1186")]
		public LegacyCV2Result<None> LUFIUWYRZCT(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1187")]
		public LegacyCV2Result<None> RDVBMTMOESZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1188")]
		public LegacyCV2Result<None> ZVLGYUTVUQB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1189")]
		public LegacyCV2Result<None> IAMQNKHSYGH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1190")]
		public LegacyCV2Result<None> EGVKGPAPOJE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1191")]
		public LegacyCV2Result<None> AFHBPCHLVEG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1192")]
		public LegacyCV2Result<None> QGJYFRISQXD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1193")]
		public LegacyCV2Result<None> PWOEYLGETZE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "184")]
		public LegacyCV2Result<None> YHOOIOITCME(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x286AB10", Offset = "0x2869310", VA = "0x18286AB10", Slot = "191")]
		public bool PCHRIXGOGJY(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1194")]
		public LegacyCV2Result<None> DMXRXCWASGO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1195")]
		public LegacyCV2Result<None> ZIGQSSZRLUZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1196")]
		public LegacyCV2Result<None> FLMLJYRCMAS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(XBMWUHKVFEA e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1205")]
		public LegacyCV2Result<None> IGAERWSDJSD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1206")]
		public LegacyCV2Result<None> ZVSSNDQYOEH(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(XBMWUHKVFEA e, InOut io, DOEACYEMAPN objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "250")]
		public LegacyCV2Result<None> MBPYMEFNYBY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "251")]
		public LegacyCV2Result<None> ATKRBASQAMK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "252")]
		public LegacyCV2Result<None> JXOQTGKQLTM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "254")]
		public LegacyCV2Result<None> IWYGYILCGYD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "255")]
		public LegacyCV2Result<None> CBFQDOGTPMZ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "256")]
		public LegacyCV2Result<None> QIZWOJWTXAV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "257")]
		public LegacyCV2Result<None> KTTOCBYRRYK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "258")]
		public LegacyCV2Result<None> YTJVQPPLIES(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "259")]
		public LegacyCV2Result<None> YVVQWGTFORF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "260")]
		public LegacyCV2Result<None> ISSVXWUCAAD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "261")]
		public LegacyCV2Result<None> QOKXJCVCCAF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "262")]
		public LegacyCV2Result<None> OQGJBTIRAPL(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "263")]
		public LegacyCV2Result<None> BBPPVBODZLM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "264")]
		public LegacyCV2Result<None> NFCKMGBOXQG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "265")]
		public LegacyCV2Result<None> ESVCNEVJLTI(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "266")]
		public LegacyCV2Result<None> XLVURPFQFCQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "267")]
		public LegacyCV2Result<None> QJMVLBTLMIE(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "268")]
		public LegacyCV2Result<None> DWBTXXTLZAW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "269")]
		public LegacyCV2Result<None> DJSFORDJHNY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		private static LegacyCV2Result<None> Default(XBMWUHKVFEA e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x286AA80", Offset = "0x2869280", VA = "0x18286AA80", Slot = "1209")]
		public LegacyCV2Result<None> MFRBLPNSCUF(XBMWUHKVFEA a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1212")]
		public LegacyCV2Result<None> IDCWLJTJAGM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1213")]
		public LegacyCV2Result<None> GFGQJOIDWJQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1214")]
		public LegacyCV2Result<None> RYKRSVGCBVO(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1215")]
		public LegacyCV2Result<None> VXDTRDMEYDP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(XBMWUHKVFEA e, InOut io, YDPYXZBLKSN quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1036")]
		public LegacyCV2Result<None> XQQIEEQIIWG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1037")]
		public LegacyCV2Result<None> GCEUBCWGEDY(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1038")]
		public LegacyCV2Result<None> AVLIBGTCRKC(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1039")]
		public LegacyCV2Result<None> XYXQPLBTACK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1040")]
		public LegacyCV2Result<None> HFVMIHEQTIQ(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1041")]
		public LegacyCV2Result<None> UZKUBSWTRVK(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1042")]
		public LegacyCV2Result<None> FCUVRNTAFGK(XBMWUHKVFEA a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1043")]
		public LegacyCV2Result<None> MSXRBMBPTHG(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1044")]
		public LegacyCV2Result<None> YYGVJJEIULW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1045")]
		public LegacyCV2Result<None> GEYRUCDMVVN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1046")]
		public LegacyCV2Result<None> BDLFPXSXUBV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XCDATKOZJFH(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1234")]
		public LegacyCV2Result<None> VFVJWWSPCHW(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1236")]
		public LegacyCV2Result<None> JYFRVFNEBXF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1229")]
		public LegacyCV2Result<None> VPUISCIBIJV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1241")]
		public LegacyCV2Result<None> WNHBZNGOZDP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1242")]
		public LegacyCV2Result<None> IDORTHOYPEU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1243")]
		public LegacyCV2Result<None> WGFIUEBMKPS(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1244")]
		public LegacyCV2Result<None> EHWMWOFLOEM(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1245")]
		public LegacyCV2Result<None> ABJVDZXYHWV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZKDGVCLAAEJ(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JFQYMZUYYAF(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XBFBVTRABRT(XBMWUHKVFEA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1259")]
		public LegacyCV2Result<None> PLXWKIFROAD(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1260")]
		public LegacyCV2Result<None> PKFUJSOSFGN(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1261")]
		public LegacyCV2Result<None> MKMFLLUBYKF(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1262")]
		public LegacyCV2Result<None> FYHXPIBBAVV(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x286AB60", Offset = "0x2869360", VA = "0x18286AB60")]
		public RAOTZFJBDDG([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(XBMWUHKVFEA e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1280")]
		public LegacyCV2Result<None> IOOJQZGQSOU(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1281")]
		public LegacyCV2Result<None> ILLERTSMFFP(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "599")]
		public LegacyCV2Result<None> BJMLXOPLPGB(XBMWUHKVFEA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1293")]
		public LegacyCV2Result<None> VBGRTFVFGFI(KWKTECQWUKV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1294")]
		public LegacyCV2Result<None> ZVUQBOMWTQF(KWKTECQWUKV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1295")]
		public LegacyCV2Result<None> HISXEOLPWVU(KWKTECQWUKV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1296")]
		public LegacyCV2Result<None> IYHIRWAKYYO(KWKTECQWUKV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1297")]
		public LegacyCV2Result<None> ZKXPQPHYMJX(KWKTECQWUKV e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(XBMWUHKVFEA e, InOut io, [In] JPYIERNGUMI storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(XBMWUHKVFEA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> RANVIXPPPSN(XBMWUHKVFEA a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, FNMAXEDRINV.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> YUFDLZKVHVJ(XBMWUHKVFEA a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, FNMAXEDRINV.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1207")]
		private LegacyCV2Result<None> ZATKABZNTNG(XBMWUHKVFEA a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1216")]
		private LegacyCV2Result<None> PVNHRUKFVPF(XBMWUHKVFEA a, InOut b, [In] JPYIERNGUMI storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0", Slot = "1257")]
		private LegacyCV2Result<None> WQJXULYXZHT(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class XHNJMAKBJPL : JJNLNGDBNMW
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(SWVYATRHDPH node);

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly XHNJMAKBJPL RAZFDZOVHOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate VFDLBHLERRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate RSNKFGDWGQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool JTORMGRWLER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool CJKPLSHHTZO;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650", Slot = "4")]
		public Task<bool> LIXHZJVMTNN(SWVYATRHDPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x28773E0", Offset = "0x2875BE0", VA = "0x1828773E0", Slot = "5")]
		public Task<bool> DFWUIOMQKEW(SWVYATRHDPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x28774B0", Offset = "0x2875CB0", VA = "0x1828774B0")]
		public XHNJMAKBJPL([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2877410", Offset = "0x2875C10", VA = "0x182877410", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? RWACHQVCHMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB290", VA = "0x180AACA90", Slot = "7")]
		public bool XLLFBSNPEDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x1339D80", Offset = "0x1338580", VA = "0x181339D80", Slot = "8")]
		public bool UWHFBVKNRNK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class DGQVHLXRYQT : DFHTHEPTSCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid RDWDZIYDDVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void Bind(LZQHHBLMYBG pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xE72FA0", Offset = "0xE717A0", VA = "0x180E72FA0")]
		public DGQVHLXRYQT(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x286FA00", Offset = "0x286E200", VA = "0x18286FA00")]
		public static DGQVHLXRYQT New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class SEZOECFDBIF : UBBXDGOYCFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<YJGJBYABSIW> nodeDefId, Id128<VAEORNAZREW>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IsNodeRestrictedDelegate? UJNXAKJILPE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BJTMRWQQTWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LUWBOZTMSXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x28745A0", Offset = "0x2872DA0", VA = "0x1828745A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool RUSSRCVYFRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xFA98D0", Offset = "0xFA80D0", VA = "0x180FA98D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "6")]
		public bool PRVVJWRSLOC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType ZKNTKDTDHFN(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x28745B0", Offset = "0x2872DB0", VA = "0x1828745B0", Slot = "8")]
		public bool YBDLQPMMFSO(Id128<YJGJBYABSIW> nodeDefId, Id128<VAEORNAZREW>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "9")]
		public bool YDIRYXINNXT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "10")]
		public bool WTMABBTMDDX(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2874600", Offset = "0x2872E00", VA = "0x182874600")]
		public SEZOECFDBIF(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class FKQDBFVKAWZ : DLTGECITYVE
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FKQDBFVKAWZ RAZFDZOVHOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventSenderToMakerPenDelegate OZLEKDCEQLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate APFISXDNRSZ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool RGCVZAHPLHD
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x101F410", Offset = "0x101DC10", VA = "0x18101F410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WNELWNBRJUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x286FB40", Offset = "0x286E340", VA = "0x18286FB40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x286FBE0", Offset = "0x286E3E0", VA = "0x18286FBE0")]
		public FKQDBFVKAWZ([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class UEBAFGYMCBP : QRKXCZQCLUH<ICREPLTPBUD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class PUOVLDBVKEC : ICREPLTPBUD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly PUOVLDBVKEC QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool FVMFXONPYXK
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2873E70", Offset = "0x2872670", VA = "0x182873E70", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			public void KREKMGBERGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public PUOVLDBVKEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly UEBAFGYMCBP QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private UEBAFGYMCBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2877320", Offset = "0x2875B20", VA = "0x182877320", Slot = "4")]
		public ICREPLTPBUD XJHQCCWPSMG()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class MFXCORTPMUN<a, b> : IDisposable, YXPWXONPQVW where a : notnull where b : notnull, EIAPYSQOVDN.BZPGNHHMTGT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly b FPRKQLVLHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly a JBLKSQNAJJO;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<ZORKRESYKMD> YCINBNIEXJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<ZORKRESYKMD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x5009810", Offset = "0x5008010", VA = "0x185009810")]
		public MFXCORTPMUN(b a, a b, Id32<ZORKRESYKMD> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x57E8240", Offset = "0x57E6A40", VA = "0x1857E8240", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x57E94A0", Offset = "0x57E7CA0", VA = "0x1857E94A0")]
		public Id32<SJYBMYLJCNS> UNTTNZPWAKF([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<SJYBMYLJCNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x57E8F90", Offset = "0x57E7790", VA = "0x1857E8F90", Slot = "6")]
		public void TUWFWRPKLCW(Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x57E9E20", Offset = "0x57E8620", VA = "0x1857E9E20", Slot = "7")]
		public void ZWDGKNDJFFK(Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x57E8FD0", Offset = "0x57E77D0", VA = "0x1857E8FD0", Slot = "8")]
		public void TUWXLEEPPJD(Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x57E8D20", Offset = "0x57E7520", VA = "0x1857E8D20", Slot = "10")]
		public void TSRMAXHWSNY(Id32<SJYBMYLJCNS> objectId, Id32<ZORKRESYKMD> clientId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x57E8530", Offset = "0x57E6D30", VA = "0x1857E8530", Slot = "9")]
		public void MFXUYILGSDO(Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x57E7FF0", Offset = "0x57E67F0", VA = "0x1857E7FF0", Slot = "11")]
		public void APJPEMZBMAO(Id32<SJYBMYLJCNS> objectId, XXBGSQEASIF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x57E8A10", Offset = "0x57E7210", VA = "0x1857E8A10", Slot = "12")]
		public Id32<ZORKRESYKMD> QGJRRKXMENX(Id32<SJYBMYLJCNS> objectId)
		{
			return default(Id32<ZORKRESYKMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x57E8270", Offset = "0x57E6A70", VA = "0x1857E8270", Slot = "13")]
		public Id32<JCHFTPSLWKY> LPGBWPIAFTB(Id32<SJYBMYLJCNS> objectId, string a, object b, bool c, IEAGUDBCKHG d, ZVKVRWIYDGI e)
		{
			return default(Id32<JCHFTPSLWKY>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x57E99C0", Offset = "0x57E81C0", VA = "0x1857E99C0", Slot = "14")]
		public void YVTSAOUQMSJ(Id32<JCHFTPSLWKY> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x57E9750", Offset = "0x57E7F50", VA = "0x1857E9750", Slot = "15")]
		public void XSSONRKMHWJ(Id32<JCHFTPSLWKY> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class EIAPYSQOVDN
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface BZPGNHHMTGT<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PQEXQIKPZUT(a a, Id32<ZORKRESYKMD> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<ZORKRESYKMD>? HZGKNEXLCVS(a a);

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<SJYBMYLJCNS> UNTTNZPWAKF(a a, Id32<ZORKRESYKMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void TUWFWRPKLCW(a a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ZWDGKNDJFFK(a a, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void TSRMAXHWSNY(a a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void MFXUYILGSDO(a a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void APJPEMZBMAO(a a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, XXBGSQEASIF? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<ZORKRESYKMD>? QGJRRKXMENX(a a, Id32<SJYBMYLJCNS> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<JCHFTPSLWKY> LPGBWPIAFTB(a a, Id32<ZORKRESYKMD> clientId, string b, object c, IEAGUDBCKHG d, ZVKVRWIYDGI e);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void YVTSAOUQMSJ(a a, Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void XSSONRKMHWJ(a a, Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class LWGFNLLWUHZ
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly HashSet<Id32<SJYBMYLJCNS>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SOAId32Field<JCHFTPSLWKY, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly Dictionary<Id32<JCHFTPSLWKY>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<JCHFTPSLWKY>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public SOAField<SJYBMYLJCNS, XXBGSQEASIF?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2873B10", Offset = "0x2872310", VA = "0x182873B10")]
			private MockCV2DynamicNetSys(HashSet<Id32<SJYBMYLJCNS>> authorityOf, [In] SOAId32Field<JCHFTPSLWKY, MockCV2SyncField> syncFields, Dictionary<Id32<JCHFTPSLWKY>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<JCHFTPSLWKY>> mockSyncFieldToSyncField, [In] SOAField<SJYBMYLJCNS, XXBGSQEASIF?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x2873950", Offset = "0x2872150", VA = "0x182873950")]
			public static MockCV2DynamicNetSys New()
			{
				return default(MockCV2DynamicNetSys);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private struct MockCV2ObjectShared
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Id32<ZORKRESYKMD>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2873BB0", Offset = "0x28723B0", VA = "0x182873BB0")]
			public MockCV2ObjectShared(Id32<ZORKRESYKMD> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public ZVKVRWIYDGI SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public IEAGUDBCKHG SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
			internal MockCV2SyncField(ZVKVRWIYDGI syncField, IEAGUDBCKHG syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2873CD0", Offset = "0x28724D0", VA = "0x182873CD0")]
			public static MockCV2SyncField New(ZVKVRWIYDGI syncField, IEAGUDBCKHG syncFieldChangeHandler)
			{
				return default(MockCV2SyncField);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		internal struct MockCV2SyncFieldShared
		{
			[Cpp2IlInjected.Token(Token = "0x2000091")]
			public sealed class M
			{
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public object Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public int Uses;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x2873C80", Offset = "0x2872480", VA = "0x182873C80")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2873C30", Offset = "0x2872430", VA = "0x182873C30")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<SJYBMYLJCNS, MockCV2ObjectShared> RHGMGVWVNGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<SJYBMYLJCNS>> IZUGDSCCDNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> RJAJTHNVDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> PUVQKPFECVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAField<ZORKRESYKMD, MockCV2DynamicNetSys> HGUDUJOITAM;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<SJYBMYLJCNS>? UZKRSIYJCTG
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xB48810", Offset = "0xB47010", VA = "0x180B48810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xFF7DE0", Offset = "0xFF65E0", VA = "0x180FF7DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x28715C0", Offset = "0x286FDC0", VA = "0x1828715C0")]
		public void Destroy([In] SOAId32<ZORKRESYKMD> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2872040", Offset = "0x2870840", VA = "0x182872040")]
		public void SBCUTXAMXNT(Id32<ZORKRESYKMD> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2871CB0", Offset = "0x28704B0", VA = "0x182871CB0")]
		public void PQEXQIKPZUT(Id32<ZORKRESYKMD> clientId, Id32<ZORKRESYKMD>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2872620", Offset = "0x2870E20", VA = "0x182872620")]
		public Id32<SJYBMYLJCNS> UNTTNZPWAKF(Id32<ZORKRESYKMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<ZORKRESYKMD> clientIds)
		{
			return default(Id32<SJYBMYLJCNS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x28718D0", Offset = "0x28700D0", VA = "0x1828718D0")]
		public Id32<JCHFTPSLWKY> LPGBWPIAFTB(Id32<ZORKRESYKMD> clientId, string a, object b, IEAGUDBCKHG c, ZVKVRWIYDGI d)
		{
			return default(Id32<JCHFTPSLWKY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2872DA0", Offset = "0x28715A0", VA = "0x182872DA0")]
		public void YVTSAOUQMSJ(Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2871800", Offset = "0x2870000", VA = "0x182871800")]
		public Id32<SJYBMYLJCNS>? GENTRBOKVTK([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x28725A0", Offset = "0x2870DA0", VA = "0x1828725A0")]
		public void TUWFWRPKLCW([In] SOAId32<ZORKRESYKMD> clientIds, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2872F30", Offset = "0x2871730", VA = "0x182872F30")]
		public void ZWDGKNDJFFK(Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x28724A0", Offset = "0x2870CA0", VA = "0x1828724A0")]
		public void TSRMAXHWSNY(Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2871B30", Offset = "0x2870330", VA = "0x182871B30")]
		public void MFXUYILGSDO([In] SOAId32<ZORKRESYKMD> clientIds, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x28714F0", Offset = "0x286FCF0", VA = "0x1828714F0")]
		public void APJPEMZBMAO(Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, XXBGSQEASIF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2871FF0", Offset = "0x28707F0", VA = "0x182871FF0")]
		public Id32<ZORKRESYKMD>? QGJRRKXMENX(Id32<SJYBMYLJCNS> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2872A30", Offset = "0x2871230", VA = "0x182872A30")]
		public void XSSONRKMHWJ([In] SOAId32<ZORKRESYKMD> clientIds, Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2873070", Offset = "0x2871870", VA = "0x182873070")]
		public LWGFNLLWUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class LZZQQUSPGYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x2873210", Offset = "0x2871A10", VA = "0x182873210")]
		public static void Destroy(this LWGFNLLWUHZ.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class UDZTIJAOLEQ : NYCNJIJVNJW.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static UDZTIJAOLEQ IKZLUJXNMMR;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate DIXSTGBLXDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate GTQHOUEPLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xABC070", Offset = "0xABA870", VA = "0x180ABC070")]
		public UDZTIJAOLEQ(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class BXZRGPVAATC : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : WJCXSIBAOJT.HMLSSQKIODE<UZPYRKQPSNH, BXZRGPVAATC>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public AsyncTaskMethodBuilder<Result<object, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public BXZRGPVAATC root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public Id32<ZORKRESYKMD> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public UZPYRKQPSNH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter<Result<object, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007A8")]
				[Cpp2IlInjected.Address(RVA = "0x2876370", Offset = "0x2874B70", VA = "0x182876370", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A9")]
				[Cpp2IlInjected.Address(RVA = "0x28765B0", Offset = "0x2874DB0", VA = "0x1828765B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			public int WSOGVUHINFS(BXZRGPVAATC a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x28743E0", Offset = "0x2872BE0", VA = "0x1828743E0", Slot = "5")]
			public int VYEZWTOFYRG(BXZRGPVAATC a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x28743C0", Offset = "0x2872BC0", VA = "0x1828743C0", Slot = "6")]
			public int NZSPPUAEWSL(BXZRGPVAATC a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x28743A0", Offset = "0x2872BA0", VA = "0x1828743A0", Slot = "7")]
			public int IRNSUYDTTQH(BXZRGPVAATC a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2874550", Offset = "0x2872D50", VA = "0x182874550", Slot = "8")]
			public void ZLEQPNFHISW(BXZRGPVAATC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "9")]
			public bool DSHGFRIPKZJ(BXZRGPVAATC a, Id32<ZORKRESYKMD> actorId, UZPYRKQPSNH[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "10")]
			public bool LBWGEGASKVP(BXZRGPVAATC a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2874400", Offset = "0x2872C00", VA = "0x182874400", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(BXZRGPVAATC a, Id32<ZORKRESYKMD> senderId, UZPYRKQPSNH b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : WJCXSIBAOJT.BZZUHUVHMDL<ActionDeps, WUFOVRVICVI.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps LWSNPQXCZQP
			{
				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public WUFOVRVICVI.StaticNetSysReceiverDeps WEZIQYCHWJG
			{
				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "5")]
				get
				{
					return default(WUFOVRVICVI.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps ZFZDSYKPXUR
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : SUUJUEDKSYD.BZPGNHHMTGT<BXZRGPVAATC>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public AsyncTaskMethodBuilder<Result<object?, SPRIBHSTRKT>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public BXZRGPVAATC root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public Id32<ZORKRESYKMD> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public UZPYRKQPSNH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private TaskAwaiter<Result<object?, SPRIBHSTRKT>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x2876050", Offset = "0x2874850", VA = "0x182876050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x2876300", Offset = "0x2874B00", VA = "0x182876300", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2873D10", Offset = "0x2872510", VA = "0x182873D10", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, SPRIBHSTRKT>> WOSCAFSXEFP(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, UZPYRKQPSNH b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : EIAPYSQOVDN.BZPGNHHMTGT<BXZRGPVAATC>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x2873460", Offset = "0x2871C60", VA = "0x182873460", Slot = "4")]
			public void PQEXQIKPZUT(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xCD2FB0", Offset = "0xCD17B0", VA = "0x180CD2FB0", Slot = "5")]
			public Id32<ZORKRESYKMD>? HZGKNEXLCVS(BXZRGPVAATC a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x28734F0", Offset = "0x2871CF0", VA = "0x1828734F0")]
			public Id32<SJYBMYLJCNS> UNTTNZPWAKF(BXZRGPVAATC a, Id32<ZORKRESYKMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<SJYBMYLJCNS>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x2873590", Offset = "0x2871D90", VA = "0x182873590", Slot = "7")]
			public void TUWFWRPKLCW(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x28737F0", Offset = "0x2871FF0", VA = "0x1828737F0", Slot = "8")]
			public void ZWDGKNDJFFK(BXZRGPVAATC a, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2873550", Offset = "0x2871D50", VA = "0x182873550", Slot = "9")]
			public void TSRMAXHWSNY(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2873430", Offset = "0x2871C30", VA = "0x182873430", Slot = "10")]
			public void MFXUYILGSDO(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, PJJLODNDMKD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x28732F0", Offset = "0x2871AF0", VA = "0x1828732F0", Slot = "11")]
			public void APJPEMZBMAO(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<SJYBMYLJCNS> objectId, XXBGSQEASIF? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2873490", Offset = "0x2871C90", VA = "0x182873490", Slot = "12")]
			public Id32<ZORKRESYKMD>? QGJRRKXMENX(BXZRGPVAATC a, Id32<SJYBMYLJCNS> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x28733D0", Offset = "0x2871BD0", VA = "0x1828733D0", Slot = "13")]
			public Id32<JCHFTPSLWKY> LPGBWPIAFTB(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, string b, object c, IEAGUDBCKHG d, ZVKVRWIYDGI e)
			{
				return default(Id32<JCHFTPSLWKY>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2873650", Offset = "0x2871E50", VA = "0x182873650", Slot = "14")]
			public void YVTSAOUQMSJ(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2873620", Offset = "0x2871E20", VA = "0x182873620", Slot = "15")]
			public void XSSONRKMHWJ(BXZRGPVAATC a, Id32<ZORKRESYKMD> clientId, Id32<JCHFTPSLWKY> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x28734F0", Offset = "0x2871CF0", VA = "0x1828734F0", Slot = "6")]
			private Id32<SJYBMYLJCNS> TDSEWXMPYEP(BXZRGPVAATC a, Id32<ZORKRESYKMD> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<SJYBMYLJCNS>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private struct <RetainClient>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public BXZRGPVAATC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Id32<SJYBMYLJCNS>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public YMJQTRDYOVJ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Id32<ZORKRESYKMD> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private IMPSIRPQCTD<BXZRGPVAATC, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private MFXCORTPMUN<BXZRGPVAATC, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private WUFOVRVICVI <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2875990", Offset = "0x2874190", VA = "0x182875990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2875FE0", Offset = "0x28747E0", VA = "0x182875FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly QALTLGDAYDV<UZPYRKQPSNH, None, WUFOVRVICVI, ActionDeps, WUFOVRVICVI.StaticNetSysReceiverDeps, RootDeps, BXZRGPVAATC, Deps> IYRDBKGVMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly LWGFNLLWUHZ YWFSQVWJYRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAId32<ZORKRESYKMD> LFBKTPLDKZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<ZORKRESYKMD, None> HGUDUJOITAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAField<ZORKRESYKMD, WUFOVRVICVI> ORKMHMXOXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Id32<ZORKRESYKMD>? CNWICZVPBBT;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate WWTEDWLDASB
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x286F2F0", Offset = "0x286DAF0", VA = "0x18286F2F0")]
		public BXZRGPVAATC(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x286EC30", Offset = "0x286D430", VA = "0x18286EC30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x286F090", Offset = "0x286D890", VA = "0x18286F090")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> SBCUTXAMXNT(YMJQTRDYOVJ a, RegistryV2 b, Id32<SJYBMYLJCNS>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x286EE00", Offset = "0x286D600", VA = "0x18286EE00")]
		private void PQEXQIKPZUT(Id32<ZORKRESYKMD> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x286F210", Offset = "0x286DA10", VA = "0x18286F210")]
		[CompilerGenerated]
		private Id32<SJYBMYLJCNS>? TKEJBBSCXMP([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class KADIFJGZBXT : USDOVPRHJYZ.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<ORNTCHYXYPW> DeserializeCircuitsJunctionAsyncDelegate(WUFOVRVICVI circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public delegate void LifecycleDidInitializeDelegate();

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public delegate void LifecycleWillDestroyDelegate();

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private struct <DeserializeInstance>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public AsyncTaskMethodBuilder<ORNTCHYXYPW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public KADIFJGZBXT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public WUFOVRVICVI circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter<ORNTCHYXYPW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x2874680", Offset = "0x2872E80", VA = "0x182874680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x2874880", Offset = "0x2873080", VA = "0x182874880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate INNWGHTPYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleDidInitializeDelegate? QGLQKBBPMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LifecycleWillDestroyDelegate? WKWSNHMUCKV;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x28711A0", Offset = "0x286F9A0", VA = "0x1828711A0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<ORNTCHYXYPW> ULUEHIOQJKB(WUFOVRVICVI a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void RCYEGXGWMET(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xD62260", Offset = "0xD60A60", VA = "0x180D62260", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xDFA700", Offset = "0xDF8F00", VA = "0x180DFA700", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2871310", Offset = "0x286FB10", VA = "0x182871310")]
		public KADIFJGZBXT([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class FRLKIHSBGJX : UODJRLEVSXT.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate UZDPQANMDSF GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<QLBYSLYPNIL> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<TJUJUSPIWTZ> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<UODJRLEVSXT.ZVDGYJVWQXS.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate Task<StaticCircuitsConfig> GetStaticCircuitsConfigAsyncDelegate(CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private struct <GetCircuitGraphToolMappingAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public AsyncTaskMethodBuilder<UODJRLEVSXT.ZVDGYJVWQXS.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<UODJRLEVSXT.ZVDGYJVWQXS.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x28748F0", Offset = "0x28730F0", VA = "0x1828748F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x2874AE0", Offset = "0x28732E0", VA = "0x182874AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private struct <GetPlayerSaveDataAsync>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public AsyncTaskMethodBuilder<TJUJUSPIWTZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<TJUJUSPIWTZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2874B50", Offset = "0x2873350", VA = "0x182874B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2874D40", Offset = "0x2873540", VA = "0x182874D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private struct <GetRoomAssetDataAsync>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public AsyncTaskMethodBuilder<QLBYSLYPNIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private TaskAwaiter<QLBYSLYPNIL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2874DB0", Offset = "0x28735B0", VA = "0x182874DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2874FA0", Offset = "0x28737A0", VA = "0x182874FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private struct <GetRoomDataAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public AsyncTaskMethodBuilder<CircuitRootData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2875010", Offset = "0x2873810", VA = "0x182875010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2875200", Offset = "0x2873A00", VA = "0x182875200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private struct <GetStaticCircuitsConfigAsync>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public AsyncTaskMethodBuilder<StaticCircuitsConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2875270", Offset = "0x2873A70", VA = "0x182875270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2875460", Offset = "0x2873C60", VA = "0x182875460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private struct <GetSuperRoomDataAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AsyncTaskMethodBuilder<SuperRoomData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public FRLKIHSBGJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x28754D0", Offset = "0x2873CD0", VA = "0x1828754D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x28756C0", Offset = "0x2873EC0", VA = "0x1828756C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetCV2DependenciesDelegate TZDQRCIGLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetRoomDataAsyncDelegate ODCYIHGBAVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetSuperRoomDataAsyncDelegate BEBUHUZLZJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomAssetDataAsyncDelegate PYVSDIDYUZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetPlayerSaveDataAsyncDelegate AEJEGAPTBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate KNNEDTPWRMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetStaticCircuitsConfigAsyncDelegate DGJBQYVWDZN;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public UZDPQANMDSF UZDPQANMDSF
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x101F410", Offset = "0x101DC10", VA = "0x18101F410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x286FED0", Offset = "0x286E6D0", VA = "0x18286FED0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> FBNERRUSCKS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x286FFE0", Offset = "0x286E7E0", VA = "0x18286FFE0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> IFBSLPXLJMV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2870420", Offset = "0x286EC20", VA = "0x182870420", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<QLBYSLYPNIL> QUXJEWFOLTY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2870200", Offset = "0x286EA00", VA = "0x182870200", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<TJUJUSPIWTZ> PHVNACIDNLN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x28700F0", Offset = "0x286E8F0", VA = "0x1828700F0", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<UODJRLEVSXT.ZVDGYJVWQXS.CircuitGraphToolMapping> NHBIAEWZQHK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2870310", Offset = "0x286EB10", VA = "0x182870310", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> PUJSNXPMDZV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2870530", Offset = "0x286ED30", VA = "0x182870530")]
		public FRLKIHSBGJX(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class ROFGRAVZKNL : CV2Request.ZVDGYJVWQXS
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CV2Request.ZVDGYJVWQXS QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly GetCanSendRequestsDelegate MZNUQOLYCJL;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public ROFGRAVZKNL(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x101F410", Offset = "0x101DC10", VA = "0x18101F410", Slot = "4")]
		public bool EBALXMGUWWF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class JFWODVEFQNY : JDJZIVHVKYR
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, ZVSGMZZHZEF> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly TryReportErrToUserDelegate DBHYGMEZBIL;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650")]
		public bool UXVZDFLEASP([In] Result<None, ZVSGMZZHZEF> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2870FF0", Offset = "0x286F7F0", VA = "0x182870FF0")]
		public JFWODVEFQNY([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650", Slot = "4")]
		private bool VVYXFIRCPIA([In] Result<None, ZVSGMZZHZEF> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class MTLYMYFOYNV : HBXNNDQOUSM
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate XBMWUHKVFEA CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly MTLYMYFOYNV QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly CurrentExecParamsDelegate? DJIZECGWWKV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public XBMWUHKVFEA WQETLTKBGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0x101F410", Offset = "0x101DC10", VA = "0x18101F410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public MTLYMYFOYNV([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class CXIJBHPCKOP : JMIZFOBJITY
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly JMIZFOBJITY QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly GetGameColorFromIdDelegate GWRIHIJVRVR;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650", Slot = "4")]
		public CircuitsColor NAJFICRCIMH(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x286F860", Offset = "0x286E060", VA = "0x18286F860")]
		public CXIJBHPCKOP([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class ZLSSULMPDOX : GQGQFHQZALQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public delegate Task<bool> IsStringPureAsyncDelegate(string value, string context);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private struct <IsStringPureAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public ZLSSULMPDOX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0x2875730", Offset = "0x2873F30", VA = "0x182875730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x2875920", Offset = "0x2874120", VA = "0x182875920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly IsStringPureAsyncDelegate DXLKVFRVNEG;

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x28776B0", Offset = "0x2875EB0", VA = "0x1828776B0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> UZWJKGCCKYA(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x28777F0", Offset = "0x2875FF0", VA = "0x1828777F0")]
		public ZLSSULMPDOX([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class ZRKMYUIMLZH : UHZWDRMUWQU
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate IPJIQLDRPBS? GetNodeVisualizationConfigDelegate([In] Id128<YJGJBYABSIW> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly UHZWDRMUWQU QIBVUYLFYAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly GetNodeVisualizationConfigDelegate GKDEDUJMKLD;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650")]
		public IPJIQLDRPBS? PQCBXTFNLBX([In] Id128<YJGJBYABSIW> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2877A10", Offset = "0x2876210", VA = "0x182877A10")]
		public ZRKMYUIMLZH([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x286F650", Offset = "0x286DE50", VA = "0x18286F650", Slot = "4")]
		private IPJIQLDRPBS GYPHUDRGBMP([In] Id128<YJGJBYABSIW> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class ZYHCUSMQCVG : WJNNGZCVIXN
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2877BC0", Offset = "0x28763C0", VA = "0x182877BC0", Slot = "4")]
		public IQCQWTMRGRC NTCLQQDRSCA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZYHCUSMQCVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class QIHBFRARJQY : SIDHHOOLKJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, bool> IAPFLVSBEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, float> PNUYXBNEGSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, double> UHFRNGUXPMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, int> XSWODQARYLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, long> YCBEFKOQQZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, string> AUIPROXBBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, uint> CLFZLBOXHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, ulong> UPYKGIWJSLA;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2873F10", Offset = "0x2872710", VA = "0x182873F10", Slot = "4")]
		public bool? WWWMWOTPIWF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2873FB0", Offset = "0x28727B0", VA = "0x182873FB0")]
		public QIHBFRARJQY()
		{
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
