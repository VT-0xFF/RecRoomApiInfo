using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Circuits.Static.RecRoom;
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
		[Cpp2IlInjected.Address(RVA = "0x2D5C410", Offset = "0x2D5B010", VA = "0x182D5C410")]
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
namespace RecRoom.Circuits.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct RRCV2Dependencies
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class DTYFEETFIUP : LRJJIFRHSNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public DTYFEETFIUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390", Slot = "4")]
			public LRJJIFRHSNA FXRWZXRSLSI(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390", Slot = "5")]
			public LRJJIFRHSNA LOPTEGOFUHF(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390", Slot = "6")]
			public LRJJIFRHSNA MCRDLVXBARZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			public void End()
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
	public static class WBIQBRMYKXY
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public ADSZSQCVFAD HTKPNKKRBHC;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2D60670", Offset = "0x2D5F270", VA = "0x182D60670")]
			internal QDGIPSGLXID YATYJKCMCRR(GetNetworkObjectDelegate a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <NewEV>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HJGLKQKSWYJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public PNGBXTCDDKS network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Registry? registry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2D5D100", Offset = "0x2D5BD00", VA = "0x182D5D100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2D5D750", Offset = "0x2D5C350", VA = "0x182D5D750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <NewEV>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PNGBXTCDDKS network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public HJGLKQKSWYJ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Registry registry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E00")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<JCZZZGYZEZI>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E08")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E38")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private QBUZPCMMQEU <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E40")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E48")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2D5D7C0", Offset = "0x2D5C3C0", VA = "0x182D5D7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DD80", Offset = "0x2D5C980", VA = "0x182D5DD80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <NewLimitedCircuits>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AsyncTaskMethodBuilder<DisposableOwned<LimitedCircuits>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ADSZSQCVFAD roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2D5DDF0", Offset = "0x2D5C9F0", VA = "0x182D5DDF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E300", Offset = "0x2D5CF00", VA = "0x182D5E300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FE30", Offset = "0x2D5EA30", VA = "0x182D5FE30")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__16))]
		public static Task<DisposableOwned<LimitedCircuits>>? ZJAYQAYBXAN([Optional] ADSZSQCVFAD? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F920", Offset = "0x2D5E520", VA = "0x182D5F920")]
		[AsyncStateMachine(typeof(<NewEV>d__21))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> LJKGZREKIBE(PNGBXTCDDKS a, [Optional] HJGLKQKSWYJ? dependencies, [Optional] Registry? b, [Optional] RegistryV2? c, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FAE0", Offset = "0x2D5E6E0", VA = "0x182D5FAE0")]
		[AsyncStateMachine(typeof(<NewEV>d__22))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> LJKGZREKIBE(PNGBXTCDDKS a, HJGLKQKSWYJ b, Registry c, RegistryV2 d, Id32<JCZZZGYZEZI>? rootObject, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F850", Offset = "0x2D5E450", VA = "0x182D5F850")]
		public static (RuntimeFnRegistry, RuntimeFns) KRLWQRPLVVC()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FD30", Offset = "0x2D5E930", VA = "0x182D5FD30")]
		public static (ExternalFnRegistry, ExternalFns) RLYORXAZLLH()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FCB0", Offset = "0x2D5E8B0", VA = "0x182D5FCB0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static PNGBXTCDDKS QTSFOWYPBZQ(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class OEGSGOHYBRU
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate QDGIPSGLXID CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <End>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AsyncTaskMethodBuilder<DisposableOwned<EVCreationResult>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public OEGSGOHYBRU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2D5CA30", Offset = "0x2D5B630", VA = "0x182D5CA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2D5D090", Offset = "0x2D5BC90", VA = "0x182D5D090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly PNGBXTCDDKS NKIBSVAFFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private CV2DependenciesDelegate? LQCNFDMZPYY;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private OEGSGOHYBRU(PNGBXTCDDKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C490", Offset = "0x2D5B090", VA = "0x182D5C490")]
		public static OEGSGOHYBRU Begin()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C630", Offset = "0x2D5B230", VA = "0x182D5C630")]
		public OEGSGOHYBRU QALUHMFGDWD(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C540", Offset = "0x2D5B140", VA = "0x182D5C540")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> End()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class AIGSOKYQOIM : QBUZPCMMQEU.ZWBQGEKCHWS
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate CAWAPZYOHWY NewCircuitsLifecycleDelegate(IYSCTJMEFHV.ZWBQGEKCHWS deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(QBUZPCMMQEU circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(QBUZPCMMQEU circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly GetRpcMessageSplitSizeBytesDelegate XXXDXLBMSRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly CircuitsWillDestroyDelegate ZKQUUXVBDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly LifecycleDidCreateDelegate EJXFFIAXHJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NewCircuitsLifecycleDelegate SYXFWEWEMAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PreReduceDelegate NYUGBGDAPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PostReduceDelegate AEOLFCNLCUB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int YQWFQWNZDBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x13533E0", Offset = "0x1351FE0", VA = "0x1813533E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2D51280", Offset = "0x2D4FE80", VA = "0x182D51280", Slot = "6")]
		public void JTLKLAAAVJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2D512B0", Offset = "0x2D4FEB0", VA = "0x182D512B0", Slot = "7")]
		public void VUHEDKZPPJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D512E0", Offset = "0x2D4FEE0", VA = "0x182D512E0", Slot = "5")]
		public CAWAPZYOHWY WCVKNOCDKTN(IYSCTJMEFHV.ZWBQGEKCHWS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF7B180", Offset = "0xF79D80", VA = "0x180F7B180", Slot = "8")]
		public void DOCGKORNSBS(QBUZPCMMQEU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF7B1B0", Offset = "0xF79DB0", VA = "0x180F7B1B0", Slot = "9")]
		public void KDYLPGOSAXD(QBUZPCMMQEU a, FJCTCRTIJZZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2D51310", Offset = "0x2D4FF10", VA = "0x182D51310")]
		public AIGSOKYQOIM([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly HVKVUJZXNUD<PNGBXTCDDKS, PNGBXTCDDKS.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly CGOWFXVOVPF<PNGBXTCDDKS, PNGBXTCDDKS.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly QBUZPCMMQEU CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly Id32<NAXUEJSETKJ> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly PNGBXTCDDKS Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D53310", Offset = "0x2D51F10", VA = "0x182D53310")]
		public EVCreationResult(HVKVUJZXNUD<PNGBXTCDDKS, PNGBXTCDDKS.MockStaticNetSysDeps> staticNetSys, CGOWFXVOVPF<PNGBXTCDDKS, PNGBXTCDDKS.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, QBUZPCMMQEU circuitsManager, Id32<NAXUEJSETKJ> clientId, PNGBXTCDDKS network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly QBUZPCMMQEU _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 RERRAOEGPYC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C260", Offset = "0x2D5AE60", VA = "0x182D5C260")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request JYDCJYGVPCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C2F0", Offset = "0x2D5AEF0", VA = "0x182D5C2F0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CKCMJRRVCXJ? ATFCPMVDCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C320", Offset = "0x2D5AF20", VA = "0x182D5C320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public YHTFDKLWCND? OHLXCYTMNOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C290", Offset = "0x2D5AE90", VA = "0x182D5C290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		internal LimitedCircuits(QBUZPCMMQEU circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class EIUABCOVLWG : HJGLKQKSWYJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HPUDPQOSLZV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public QDGIPSGLXID HHJFSVVTIGD;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HPUDPQOSLZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			internal QDGIPSGLXID SNHSVHTBFLH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BBDQXSJXACB.ZWBQGEKCHWS FGZLEXXGFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IYSCTJMEFHV.ZWBQGEKCHWS HQSTJLTFMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public QBUZPCMMQEU.ZWBQGEKCHWS HLOMVPQQCOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public QGHELZNSXBF.ZWBQGEKCHWS QQJGBXLBDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU> VIEMKMIYKDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CV2Request.ZWBQGEKCHWS ALRWSWUTPXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HQZRPDRLYMD YOEBAIBRSBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public SIAQCCPWYWO SVTYZEGMKLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LPPYWEGICFS FCFVUKHTKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HQZHXJLGZCY UAQJIWJGAYH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ZWOKKWUVOWC VJNALATDEKR
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2D53200", Offset = "0x2D51E00", VA = "0x182D53200")]
		private EIUABCOVLWG(BBDQXSJXACB.ZWBQGEKCHWS a, IYSCTJMEFHV.ZWBQGEKCHWS b, QBUZPCMMQEU.ZWBQGEKCHWS c, QGHELZNSXBF.ZWBQGEKCHWS d, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU> e, CV2Request.ZWBQGEKCHWS f, HQZRPDRLYMD g, SIAQCCPWYWO h, LPPYWEGICFS i, HQZHXJLGZCY j, ZWOKKWUVOWC k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2D52A20", Offset = "0x2D51620", VA = "0x182D52A20")]
		public static EIUABCOVLWG? HGKELXZZAAJ(QGHELZNSXBF.ZWBQGEKCHWS cv2RootSysDeps, [Optional] BBDQXSJXACB.ZWBQGEKCHWS? a, [Optional] IYSCTJMEFHV.ZWBQGEKCHWS? b, [Optional] QBUZPCMMQEU.ZWBQGEKCHWS? c, [Optional] TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>? reducerDeps, [Optional] CV2Request.ZWBQGEKCHWS? d, [Optional] HQZRPDRLYMD? e, [Optional] SIAQCCPWYWO? f, [Optional] LPPYWEGICFS? g, [Optional] HQZHXJLGZCY? h, [Optional] ZWOKKWUVOWC? i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2D530A0", Offset = "0x2D51CA0", VA = "0x182D530A0")]
		public static EIUABCOVLWG? VDHLWJHKWBF(QDGIPSGLXID cv2Dependencies, [Optional] BBDQXSJXACB.ZWBQGEKCHWS? a, [Optional] IYSCTJMEFHV.ZWBQGEKCHWS? b, [Optional] QBUZPCMMQEU.ZWBQGEKCHWS? c, [Optional] TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2D52DE0", Offset = "0x2D519E0", VA = "0x182D52DE0")]
		public static EIUABCOVLWG? URRVRSWWYFJ(GetNetworkObjectDelegate getNetworkObjectDelegate, [Optional] BBDQXSJXACB.ZWBQGEKCHWS? a, [Optional] IYSCTJMEFHV.ZWBQGEKCHWS? b, [Optional] QBUZPCMMQEU.ZWBQGEKCHWS? c, [Optional] TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class GYQACRDNWDV
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int JHNQVXCYAGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate CZYIKTCFOPF;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			internal int PHJOMMYESPM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2D556C0", Offset = "0x2D542C0", VA = "0x182D556C0")]
			internal CCKZZXOVVJO HJQZHOTWIDT(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2D55560", Offset = "0x2D54160", VA = "0x182D55560")]
			internal CCKZZXOVVJO[] HJBEPUMEFVS(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class GWLPQCWEVLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DynamicEnvironmentNetworkId CJDMJBYVYHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public GWGISWCHLZW JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWLPQCWEVLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2D55730", Offset = "0x2D54330", VA = "0x182D55730")]
			internal CCKZZXOVVJO UJBPMNEHAIT(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly EBUYLMQOMBA ISNIDEUIHGX;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2D557E0", Offset = "0x2D543E0", VA = "0x182D557E0")]
		public static CCKZZXOVVJO? VXKCIOCCRUX(Id32<JCZZZGYZEZI>? networkObject, [Optional] XERRWDCDEYP.SerializesIntoSavesDelegate? a, [Optional] XERRWDCDEYP.SerializesIntoInventionsDelegate? b, [Optional] XERRWDCDEYP.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D55800", Offset = "0x2D54400", VA = "0x182D55800")]
		public static QDGIPSGLXID? VYSKPPSIOQK(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] RIUQPTLWHHA? b, [Optional] AYBNVZICMFS? c, [Optional] FYKUDXEFATQ? d, [Optional] ADSZSQCVFAD? e, int f = 300000, bool g = false, bool h = false, [Optional] XEVORPDPVDW? i, [Optional] LGFMTZREUMN? j, [Optional] RRYJLIWAQJW? k, [Optional] CRNDIFJOJOT? l, [Optional] FRAUNCBXFKS? m, [Optional] MELVNCPVTZR? n, [Optional] DTLSINVZACO? o, [Optional] VKYPFXPEYWW.ZWBQGEKCHWS? p, [Optional] EqualsNodeV2.ZWBQGEKCHWS? q, [Optional] DGTUMWLRJWM? r, [Optional] QDGIPSGLXID.HasPlayerReferenceBoardDependenciesDelegate? s, [Optional] QDGIPSGLXID.GetPlayerReferenceBoardDependenciesDelegate? t, [Optional] QDGIPSGLXID.GetPlayerDefinitionBoardDependenciesDelegate? u, [Optional] QDGIPSGLXID.GetLocalRoomIdDelegate? v, [Optional] QDGIPSGLXID.GetLocalSubroomIdDelegate? w, [Optional] QDGIPSGLXID.GetSubroomIdsForLocalRoomDelegate? x, [Optional] QDGIPSGLXID.SaveMyPlayerRoomDataDelegate? y, int z = 100, [Optional] QDGIPSGLXID.SaveRoomOnPlayerBehalfDelegate? ba, [Optional] QDGIPSGLXID.ReportCloudDataLedgerChangedDelegate? bb, [Optional] QDGIPSGLXID.GetColorNameByIdDelegate? bc, [Optional] QDGIPSGLXID.GetPlayerDisplayNameFromSignalDelegate? bd, [Optional] QDGIPSGLXID.GetCreationObjectFriendlyNameFromSignalDelegate? be, [Optional] QDGIPSGLXID.GetTaggableNameFromSignalDelegate? bf, [Optional] QDGIPSGLXID.GetAudioNameFromSignalDelegate? bg, [Optional] QDGIPSGLXID.GetDestinationNameFromSignalDelegate? bh, [Optional] QDGIPSGLXID.GetPlayerEventNameFromSignalDelegate? bi, [Optional] QDGIPSGLXID.GetRoomKeyNameFromSignalDelegate? bj, [Optional] QDGIPSGLXID.GetRewardNameFromSignalDelegate? bk, [Optional] QDGIPSGLXID.GetRoomCurrencyNameFromSignalDelegate? bl, [Optional] QDGIPSGLXID.ReportPreloadedAudioChangedDelegate? bm, [Optional] QDGIPSGLXID.ReportRewardDataChangedDelegate? bn, [Optional] QDGIPSGLXID.GetConsumableNameFromSignalDelegate? bo, [Optional] QDGIPSGLXID.GetGiftDropShopItemNameFromSignalDelegate? bp, [Optional] QDGIPSGLXID.GetObjectiveMarkerNameFromSignalDelegate? bq, [Optional] QDGIPSGLXID.GetFriendlyLocalPlayerNameDelegate? br, [Optional] QDGIPSGLXID.GetInventoryItemNameFromSignalDelegate? bs, [Optional] QDGIPSGLXID.GetGetQuickChatTableNameFromSignalDelegate? bt, [Optional] QDGIPSGLXID.GetStateMachineStateNameFromSignalDelegate? bu, [Optional] QDGIPSGLXID.GetRoomOfferNameFromSignalDelegate? bv, [Optional] QDGIPSGLXID.GetStorefrontItemNameFromSignalDelegate? bw, [Optional] QDGIPSGLXID.GetObjectIdFromCreationObjectDelegate? bx, [Optional] QDGIPSGLXID.GetPropertyEntityFromIdDelegate? by, [Optional] QDGIPSGLXID.GetCostInBytesDelegate? bz, [Optional] QDGIPSGLXID.GetAvatarItemNameFromSignalDelegate? ca, [Optional] QDGIPSGLXID.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] QDGIPSGLXID.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] QDGIPSGLXID.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] QDGIPSGLXID.GetStoreItemNameFromSignalDelegate? ce, [Optional] QDGIPSGLXID.GetBodyPartNameFromSignalDelegate? cf, [Optional] QDGIPSGLXID.GetDependenciesForGraphInstanceDelegate? cg, [Optional] QDGIPSGLXID.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] QDGIPSGLXID.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] QDGIPSGLXID.GetRecNetImageFromSignalDelegate? cj)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<JCZZZGYZEZI>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class SZYIFHAHJZO : CRNDIFJOJOT
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly SZYIFHAHJZO CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly GetLocalPlayerDelegate? GZPHBWLYPXZ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C7E0", Offset = "0x2D5B3E0", VA = "0x182D5C7E0", Slot = "4")]
		public (BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY) PDBGPVZPNTU(object a)
		{
			return default((BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY, BTTYMEWUHLY));
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C7B0", Offset = "0x2D5B3B0", VA = "0x182D5C7B0", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "6")]
		public bool SNDHVNFTAHT(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xB7CD10", Offset = "0xB7B910", VA = "0x180B7CD10", Slot = "7")]
		public string CCEXGIURFJP(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public SZYIFHAHJZO([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class XERRWDCDEYP : CCKZZXOVVJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(XERRWDCDEYP self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(XERRWDCDEYP self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(XERRWDCDEYP self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly SerializesIntoSavesDelegate DWNRHLYXOFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoInventionsDelegate OUAATFKUBRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly CanPublishInInventionsDelegate LMGJLEGMEPW;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string? QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private DUFIFDHZMCM? CAZHWZSGXHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public DynamicEnvironmentNetworkId ILVWNJSBGDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x102F8D0", Offset = "0x102E4D0", VA = "0x18102F8D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool XOAJUVVHTBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D60640", Offset = "0x2D5F240", VA = "0x182D60640", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HRSLCGWDNUL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2D60610", Offset = "0x2D5F210", VA = "0x182D60610", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool FPTZOXXBFMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2D605E0", Offset = "0x2D5F1E0", VA = "0x182D605E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public YCWBJBOZPSP? SEZETOJMNFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Id32<JCZZZGYZEZI>? JODNNHRBCWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D60490", Offset = "0x2D5F090", VA = "0x182D60490", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FF20", Offset = "0x2D5EB20", VA = "0x182D5FF20", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(EBUYLMQOMBA e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60", Slot = "13")]
		public void Bind(DUFIFDHZMCM controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D60530", Offset = "0x2D5F130", VA = "0x182D60530")]
		private XERRWDCDEYP(Id32<JCZZZGYZEZI>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D5FFC0", Offset = "0x2D5EBC0", VA = "0x182D5FFC0")]
		public static XERRWDCDEYP? New(Id32<JCZZZGYZEZI>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HBNMCZBAYZF : XEVORPDPVDW
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

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly HBNMCZBAYZF CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly RoundToDecimalPlaceDelegate? XWNUMAOFFTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly TruncateToDecimalPlaceDelegate? CEIYADJQGST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly CircuitsColorLerpDelegate? ZQLOIGQZSTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorInverseLerpDelegate? IRHNUHNNOYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsMtx4x4GetPositionDelegate? POPQKJQTILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetRotationDelegate? NFUJLDGMKUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4InverseDelegate? EDOOHAYBJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4MultiplyDelegate? EZFOLLSLMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? FZOQDJUJUQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsQuatDotDelegate? FBGUVFGQTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatFromAngleAxisDelegate? UJHENARTEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? MQHXRSJLKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromFromToRotationDelegate? MUWAAZKNYIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromLookRotationDelegate? XLWXADCLSPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? WMJESUBHGMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatInverseDelegate? VFAPLPZDIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatLerpDelegate? CFTBRGXBMDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpUnclampedDelegate? QLQPKUNFJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatInverseLerpDelegate? FTWYPAKCALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatMultiplyDelegate? KMRFMNGHAHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatNormalizeDelegate? ONRSPUTBBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatRotateTowardsDelegate? QVRSGKDGKVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateVectorDelegate? RYSSJVNQBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatSlerpDelegate? CEJIKTEUEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatToAngleAxisDelegate? VOWENBQMDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToEulerAnglesDelegate? AZNGWTATZNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsVec3AddDelegate? KOHHIRJISVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? FXJJCLPEGNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? QSBHTENGMRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3CrossDelegate? SAJSCHQRCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3DotDelegate? PVCDRZZJDRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3AngleDelegate? RMVVYBDGGVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3GetMagnitudeDelegate? UCHKWAOHTLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3LerpDelegate? AEWWOEJSJTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpUnclampedDelegate? ZWTZWDJRIWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3InverseLerpDelegate? EQPCBMSLPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3MoveTowardsDelegate? UZCSGNOBCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3NegateDelegate? SJMJLVYHRKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NormalizeDelegate? OOUPXFYELKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3ProjectDelegate? RRTOPBOQOVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? NITNHZXTXDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ScaleDelegate? SCRFRLLTBAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3SmoothDampDelegate? OQKGOJKPCQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SubtractDelegate? PBYBMAGETLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SlerpDelegate? KPGRAERIICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3TransformDelegate? DJOWLRUUKTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3InverseTransformDelegate? QBTEGCJHBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly RealtimeSinceStartupDelegate? AUTOBLRSLFS;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D5BA00", Offset = "0x2D5A600", VA = "0x182D5BA00")]
		public HBNMCZBAYZF([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D59CE0", Offset = "0x2D588E0", VA = "0x182D59CE0")]
		public float DBUZOFGUQRS([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D59AF0", Offset = "0x2D586F0", VA = "0x182D59AF0")]
		public float CAIHPVETDPO([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D59E80", Offset = "0x2D58A80", VA = "0x182D59E80")]
		public CircuitsColor DTVMOVWKEKN([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A910", Offset = "0x2D59510", VA = "0x182D5A910")]
		public float WAVVDYDJBLT([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D59BE0", Offset = "0x2D587E0", VA = "0x182D59BE0")]
		public CircuitsVec3 CIBHQGFOLYH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B6D0", Offset = "0x2D5A2D0", VA = "0x182D5B6D0")]
		public CircuitsQuat YGENJYQLAWS([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B340", Offset = "0x2D59F40", VA = "0x182D5B340")]
		public CircuitsMtx4x4 VFDKNUDYAQI([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AF00", Offset = "0x2D59B00", VA = "0x182D5AF00")]
		public CircuitsMtx4x4 RLLTJTGONXC([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A940", Offset = "0x2D59540", VA = "0x182D5A940")]
		public CircuitsMtx4x4 MJZYOSQCFOA([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AD80", Offset = "0x2D59980", VA = "0x182D5AD80")]
		public float QHOVNRSAMVD([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A240", Offset = "0x2D58E40", VA = "0x182D5A240")]
		public CircuitsQuat FIXQZYDDXYU(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D59D00", Offset = "0x2D58900", VA = "0x182D59D00")]
		public CircuitsQuat PXQVWPPWLLB([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A6E0", Offset = "0x2D592E0", VA = "0x182D5A6E0")]
		public CircuitsQuat KFQLEQNLVLT([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D59B30", Offset = "0x2D58730", VA = "0x182D59B30")]
		public CircuitsQuat XSDYRDLNLMP([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ADF0", Offset = "0x2D599F0", VA = "0x182D5ADF0")]
		public CircuitsQuat QKAIFRXDSUW([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B040", Offset = "0x2D59C40", VA = "0x182D5B040")]
		public CircuitsQuat TCYKQIVOHIH([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AAB0", Offset = "0x2D596B0", VA = "0x182D5AAB0")]
		public CircuitsQuat NWCDBYDFELE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AC20", Offset = "0x2D59820", VA = "0x182D5AC20")]
		public float OGSRZYPQFZF([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AB70", Offset = "0x2D59770", VA = "0x182D5AB70")]
		public CircuitsQuat RASRDEQQICC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A790", Offset = "0x2D59390", VA = "0x182D5A790")]
		public CircuitsQuat KKJEEFHJUBT([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AC50", Offset = "0x2D59850", VA = "0x182D5AC50")]
		public CircuitsQuat OVASOCNBFSP([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B4D0", Offset = "0x2D5A0D0", VA = "0x182D5B4D0")]
		public CircuitsVec3 WZLNZANIKTU([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D59F70", Offset = "0x2D58B70", VA = "0x182D59F70")]
		public CircuitsQuat EHSWPSGLBQS([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A5D0", Offset = "0x2D591D0", VA = "0x182D5A5D0")]
		public void HWTPNMIVZSX([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B540", Offset = "0x2D5A140", VA = "0x182D5B540")]
		public CircuitsVec3 XPDZOVMZGXC([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A160", Offset = "0x2D58D60", VA = "0x182D5A160")]
		public CircuitsVec3 EXEYACOEAHT([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B170", Offset = "0x2D59D70", VA = "0x182D5B170")]
		public CircuitsVec3 TGGYBOVBLSZ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B100", Offset = "0x2D59D00", VA = "0x182D5B100")]
		public CircuitsVec3 TEIRCPWGKTM([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AFD0", Offset = "0x2D59BD0", VA = "0x182D5AFD0")]
		public CircuitsVec3 SXKHWYTXZMO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A9B0", Offset = "0x2D595B0", VA = "0x182D5A9B0")]
		public float MKWZUTSSRMN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D59B10", Offset = "0x2D58710", VA = "0x182D59B10")]
		public float CASXKZFWCXD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B250", Offset = "0x2D59E50", VA = "0x182D5B250")]
		public float TZKNOMOQXGA([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B7C0", Offset = "0x2D5A3C0", VA = "0x182D5B7C0")]
		public CircuitsVec3 ZGHRTIKSTGP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A490", Offset = "0x2D59090", VA = "0x182D5A490")]
		public CircuitsVec3 HBFQJUFYBGW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D59CB0", Offset = "0x2D588B0", VA = "0x182D59CB0")]
		public float GSAAORZRTZR([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D59C40", Offset = "0x2D58840", VA = "0x182D59C40")]
		public CircuitsVec3 CLBKJXWTEKB([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B270", Offset = "0x2D59E70", VA = "0x182D5B270")]
		public CircuitsVec3 UZYILIGPKVS([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A360", Offset = "0x2D58F60", VA = "0x182D5A360")]
		public CircuitsVec3 FZQPSAHBYYR([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A830", Offset = "0x2D59430", VA = "0x182D5A830")]
		public CircuitsVec3 KYDSHSEWPDZ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B660", Offset = "0x2D5A260", VA = "0x182D5B660")]
		public CircuitsVec3 YDBVTZPODXO([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A8A0", Offset = "0x2D594A0", VA = "0x182D5A8A0")]
		public CircuitsVec3 KZBNCPSQUQY([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D59A40", Offset = "0x2D58640", VA = "0x182D59A40")]
		public CircuitsVec3 BNMAKXGHPYC([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B2D0", Offset = "0x2D59ED0", VA = "0x182D5B2D0")]
		public CircuitsVec3 VAWTGTBZFXU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A0F0", Offset = "0x2D58CF0", VA = "0x182D5A0F0")]
		public CircuitsVec3 EUVXAIZKXRU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AA40", Offset = "0x2D59640", VA = "0x182D5AA40")]
		public CircuitsVec3 NPRJYPRPBUG([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A1D0", Offset = "0x2D58DD0", VA = "0x182D5A1D0")]
		public CircuitsVec3 EXVPZTPRDCK([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B790", Offset = "0x2D5A390", VA = "0x182D5B790", Slot = "50")]
		public Task ZDSCWPDXQRU(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "51")]
		public void AWYUPMZQTHU([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A030", Offset = "0x2D58C30", VA = "0x182D5A030", Slot = "52")]
		public XGVPGBNZWEC ENIRTWRIPYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B610", Offset = "0x2D5A210", VA = "0x182D5B610", Slot = "53")]
		public XGVPGBNZWEC YBVMQPCWLUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D59F50", Offset = "0x2D58B50", VA = "0x182D59F50", Slot = "54")]
		public float EGGPXLFWCBR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D59CE0", Offset = "0x2D588E0", VA = "0x182D59CE0", Slot = "4")]
		private float PYBNXONRJSO([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D59AF0", Offset = "0x2D586F0", VA = "0x182D59AF0", Slot = "5")]
		private float FMVDWDKABQS([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D598B0", Offset = "0x2D584B0", VA = "0x182D598B0", Slot = "6")]
		private CircuitsColor ACOGJHZWTZJ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A910", Offset = "0x2D59510", VA = "0x182D5A910", Slot = "7")]
		private float LPOAVGIGEST([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B470", Offset = "0x2D5A070", VA = "0x182D5B470", Slot = "8")]
		private CircuitsVec3 WQQDXIICNLH([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ADA0", Offset = "0x2D599A0", VA = "0x182D5ADA0", Slot = "9")]
		private CircuitsQuat PYQQCITLLOU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D59970", Offset = "0x2D58570", VA = "0x182D59970", Slot = "10")]
		private CircuitsMtx4x4 APLACFGBTKS([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A500", Offset = "0x2D59100", VA = "0x182D5A500", Slot = "11")]
		private CircuitsMtx4x4 HMKWOSKVMXE([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D59910", Offset = "0x2D58510", VA = "0x182D59910", Slot = "12")]
		private CircuitsMtx4x4 ALZFIOFNVGK([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AD80", Offset = "0x2D59980", VA = "0x182D5AD80", Slot = "13")]
		private float PLLIZILWDGL([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A240", Offset = "0x2D58E40", VA = "0x182D5A240", Slot = "14")]
		private CircuitsQuat XMQUTGZAGLU(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D59D00", Offset = "0x2D58900", VA = "0x182D59D00", Slot = "15")]
		private CircuitsQuat DDFPAHEYBLH([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A6E0", Offset = "0x2D592E0", VA = "0x182D5A6E0", Slot = "16")]
		private CircuitsQuat SBTXXJHXYQH([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D59B30", Offset = "0x2D58730", VA = "0x182D59B30", Slot = "17")]
		private CircuitsQuat CEFQZIFOECN([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2D5ADF0", Offset = "0x2D599F0", VA = "0x182D5ADF0", Slot = "18")]
		private CircuitsQuat VIZSELMECUA([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B040", Offset = "0x2D59C40", VA = "0x182D5B040", Slot = "19")]
		private CircuitsQuat TKPUBEDQBUJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AAB0", Offset = "0x2D596B0", VA = "0x182D5AAB0", Slot = "20")]
		private CircuitsQuat SFBLVDZBGQQ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AC20", Offset = "0x2D59820", VA = "0x182D5AC20", Slot = "21")]
		private float TMOCGCDTSMB([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AB70", Offset = "0x2D59770", VA = "0x182D5AB70", Slot = "22")]
		private CircuitsQuat NXSISVHSTIY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A790", Offset = "0x2D59390", VA = "0x182D5A790", Slot = "23")]
		private CircuitsQuat WFADORYGECT([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AC50", Offset = "0x2D59850", VA = "0x182D5AC50", Slot = "24")]
		private CircuitsQuat XMDBMQYOTDH([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B720", Offset = "0x2D5A320", VA = "0x182D5B720", Slot = "25")]
		private CircuitsVec3 YWJYWRCWGZW([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2D59F70", Offset = "0x2D58B70", VA = "0x182D59F70", Slot = "26")]
		private CircuitsQuat FGTXSIXQQKM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A5D0", Offset = "0x2D591D0", VA = "0x182D5A5D0", Slot = "27")]
		private void KPQHJYPHIOF([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A430", Offset = "0x2D59030", VA = "0x182D5A430", Slot = "28")]
		private CircuitsVec3 GUATRXTMBVA([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A080", Offset = "0x2D58C80", VA = "0x182D5A080", Slot = "29")]
		private CircuitsVec3 EOLKEUGUFET([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2D59EE0", Offset = "0x2D58AE0", VA = "0x182D59EE0", Slot = "30")]
		private CircuitsVec3 DUNRYXTJFRB([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A610", Offset = "0x2D59210", VA = "0x182D5A610", Slot = "31")]
		private CircuitsVec3 IMTAVFEQHPC([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2D599D0", Offset = "0x2D585D0", VA = "0x182D599D0", Slot = "32")]
		private CircuitsVec3 AUUVQKWRRIQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A2F0", Offset = "0x2D58EF0", VA = "0x182D5A2F0", Slot = "33")]
		private CircuitsVec3 FVYWACNNEUQ([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B5A0", Offset = "0x2D5A1A0", VA = "0x182D5B5A0", Slot = "34")]
		private CircuitsVec3 XTTJQLYOIMM([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A9B0", Offset = "0x2D595B0", VA = "0x182D5A9B0", Slot = "35")]
		private float WBDVGJIHAWH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2D59B10", Offset = "0x2D58710", VA = "0x182D59B10", Slot = "36")]
		private float QNYUTJNIKUP([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B250", Offset = "0x2D59E50", VA = "0x182D5B250", Slot = "37")]
		private float YQGJDHLNMAG([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AD10", Offset = "0x2D59910", VA = "0x182D5AD10", Slot = "38")]
		private CircuitsVec3 PISYHDNRUAV([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A9D0", Offset = "0x2D595D0", VA = "0x182D5A9D0", Slot = "39")]
		private CircuitsVec3 MOWHMSEGLXG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2D59CB0", Offset = "0x2D588B0", VA = "0x182D59CB0", Slot = "40")]
		private float DBLDOQNHVJL([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B1E0", Offset = "0x2D59DE0", VA = "0x182D5B1E0", Slot = "41")]
		private CircuitsVec3 TKXJIARDRLR([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A680", Offset = "0x2D59280", VA = "0x182D5A680", Slot = "42")]
		private CircuitsVec3 JGIVZPOKWVM([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AF70", Offset = "0x2D59B70", VA = "0x182D5AF70", Slot = "43")]
		private CircuitsVec3 SKMHRYAPANV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2D59DA0", Offset = "0x2D589A0", VA = "0x182D59DA0", Slot = "44")]
		private CircuitsVec3 DGHQZFRPHIF([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2D5AE90", Offset = "0x2D59A90", VA = "0x182D5AE90", Slot = "45")]
		private CircuitsVec3 QSJVPWFZXQC([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A560", Offset = "0x2D59160", VA = "0x182D5A560", Slot = "46")]
		private CircuitsVec3 HWLQVZMIBMS([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2D5B3B0", Offset = "0x2D59FB0", VA = "0x182D5B3B0", Slot = "47")]
		private CircuitsVec3 VMFTUOSFSGY([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2D5A3C0", Offset = "0x2D58FC0", VA = "0x182D5A3C0", Slot = "48")]
		private CircuitsVec3 GTMSJKJOFTG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2D59E10", Offset = "0x2D58A10", VA = "0x182D59E10", Slot = "49")]
		private CircuitsVec3 DTTJGFLTAUY([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class IHAJVIOLKMT : EVGZYTOOHDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x13E8500", Offset = "0x13E7100", VA = "0x1813E8500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool StopEventExecutionAfterSingleFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2393C80", Offset = "0x2392880", VA = "0x182393C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2D5BEE0", Offset = "0x2D5AAE0", VA = "0x182D5BEE0")]
		public IHAJVIOLKMT(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class JPQUNJYITNF : RRYJLIWAQJW
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(ABZCVUHNAYT e, FOHOLLFCENE invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly JPQUNJYITNF CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly GetCircuitsColorFromColorIndexDelegate? IAJMNQUERTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? MGGPGWOPUPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly InvisibleCollisionSetEnabledDelegate? ARCOBQGRROJ;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public JPQUNJYITNF([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C170", Offset = "0x2D5AD70", VA = "0x182D5C170", Slot = "4")]
		public CircuitsColor QRZOZMRWBZV(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C150", Offset = "0x2D5AD50", VA = "0x182D5C150")]
		public int LYIVSMXDXKV([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C150", Offset = "0x2D5AD50", VA = "0x182D5C150", Slot = "5")]
		private int FCXSMJABTBA([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class YWPAMMDMDQS : RFLMJRBPWOT
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class TPFKPAPAVZF
		{
			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public Guid SOCZHUYDANF
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public long IPHYAQBVRBK
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public int JTTBFFMRCVU
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool DSJLRMLCJJF
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x1DF5040", Offset = "0x1DF3C40", VA = "0x181DF5040")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool IECEWASATUN
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x1DF4D60", Offset = "0x1DF3960", VA = "0x181DF4D60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool ESKXRRGJGEC
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x2D5C8D0", Offset = "0x2D5B4D0", VA = "0x182D5C8D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x2D5C8F0", Offset = "0x2D5B4F0", VA = "0x182D5C8F0")]
			public TPFKPAPAVZF(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Dictionary<Id128<LWYTCPIHOQE>, TPFKPAPAVZF> ZPXKQRGAEVU;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2D60970", Offset = "0x2D5F570", VA = "0x182D60970")]
		public bool IWINICMTJLF([In] Id128<LWYTCPIHOQE> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2D608A0", Offset = "0x2D5F4A0", VA = "0x182D608A0")]
		public void LVIJMXKRNLR([In] Id128<LWYTCPIHOQE> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2D60C90", Offset = "0x2D5F890", VA = "0x182D60C90")]
		public void LVIJMXKRNLR([In] Id128<LWYTCPIHOQE> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2D60B10", Offset = "0x2D5F710", VA = "0x182D60B10")]
		public void ENTWQQWWXDI([In] Id128<LWYTCPIHOQE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2D60C30", Offset = "0x2D5F830", VA = "0x182D60C30")]
		public void QEJHSEKMINH([In] Id128<LWYTCPIHOQE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2D60A80", Offset = "0x2D5F680", VA = "0x182D60A80")]
		public bool DSJLRMLCJJF([In] Id128<LWYTCPIHOQE> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2D60D70", Offset = "0x2D5F970", VA = "0x182D60D70")]
		public YWPAMMDMDQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D60970", Offset = "0x2D5F570", VA = "0x182D60970", Slot = "4")]
		private bool CIQYEOLWMEM([In] Id128<LWYTCPIHOQE> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2D608A0", Offset = "0x2D5F4A0", VA = "0x182D608A0", Slot = "5")]
		private void BRNUCJXMPAM([In] Id128<LWYTCPIHOQE> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2D60B10", Offset = "0x2D5F710", VA = "0x182D60B10", Slot = "6")]
		private void VIDNTPNYAZP([In] Id128<LWYTCPIHOQE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2D60C30", Offset = "0x2D5F830", VA = "0x182D60C30", Slot = "7")]
		private void IJDNXEIBGQS([In] Id128<LWYTCPIHOQE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2D60A80", Offset = "0x2D5F680", VA = "0x182D60A80", Slot = "8")]
		private bool ZDKJEHABQJY([In] Id128<LWYTCPIHOQE> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class VRZPRPGVQMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D5F3F0", Offset = "0x2D5DFF0", VA = "0x182D5F3F0")]
		public static LogDeps TALYKAWOYOC()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class FSVHUEAVBRZ : RIUQPTLWHHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public delegate bool CanLocalPlayerCreateCurrencyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public delegate void ShowRoomCurrencyCreationUIDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public delegate IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GetAudioClipOptionsDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public delegate IReadOnlyDictionary<Guid, int> GetAudioClipGuidToIndexMapDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public delegate IReadOnlyDictionary<int, Guid> GetAudioClipIndexToGuidMapDelegate(AudioClipType clipType);

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public delegate IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GetAllAudioClipOptionsDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public delegate IReadOnlyDictionary<Guid, int> GetAllAudioClipGuidToIndexMapDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public delegate IReadOnlyDictionary<int, Guid> GetAllAudioClipIndexToGuidMapDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public delegate void PlayAudioPreviewDelegate(AudioClipType clipType, Guid clipGuid);

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public delegate void StopAudioPreviewDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public delegate bool SubscriptionIsActiveDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public delegate bool CanAffordToConvertVariableToCloudVariableDelegate();

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public delegate void ShowQuickChatEditMenuDelegate(Guid tableId);

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public delegate void ConfigureAttachedObjectDelegate(HXKABVYEKIU controlPanel, VXTUWJBKUSC staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate void ReleaseIconIdDelegate(Id32<KWZBWBHJPPH> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate Task<Result<None, JGXPLWKAZER>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, JGXPLWKAZER>> task);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<MultiResult, JGXPLWKAZER>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, JGXPLWKAZER>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> task);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault2>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public AsyncTaskMethodBuilder<Result<MultiResult, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Task<Result<MultiResult, JGXPLWKAZER>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private TaskAwaiter<Result<MultiResult, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E370", Offset = "0x2D5CF70", VA = "0x182D5E370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E630", Offset = "0x2D5D230", VA = "0x182D5E630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault3>d__130 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public AsyncTaskMethodBuilder<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private TaskAwaiter<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E6A0", Offset = "0x2D5D2A0", VA = "0x182D5E6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E960", Offset = "0x2D5D560", VA = "0x182D5E960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault>d__122 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public Task<Result<None, JGXPLWKAZER>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2D5E9D0", Offset = "0x2D5D5D0", VA = "0x182D5E9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2D5EC90", Offset = "0x2D5D890", VA = "0x182D5EC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<string, EnumChoiceData> YGMVBZHXEDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<int, string> XEONAXFKOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly List<object> BFXZWMVPRKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<Guid> THBKRAKZGRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CanLocalPlayerCreateCurrencyDelegate APGNGBASTAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly ShowRoomCurrencyCreationUIDelegate UPGTDIHQITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly GetAudioClipOptionsDelegate UNEYTCXATAQ;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly IReadOnlyDictionary<Guid, int> JOKRJILBJKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipGuidToIndexMapDelegate MICOYRSTGXW;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<int, Guid> NWTUJEJHQHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipIndexToGuidMapDelegate YRVHEDRYRVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAllAudioClipOptionsDelegate CBAUEVJRFSP;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly IReadOnlyDictionary<Guid, int> FPARGKOSSWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate APAYPGKLXPL;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<int, Guid> LNLYVHZWEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate TILMABBWSJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly PlayAudioPreviewDelegate XAFNWOFUCMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly StopAudioPreviewDelegate YXAEBYRKOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly SubscriptionIsActiveDelegate PXYMYVQAMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate JJLMVEMWECQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly Dictionary<string, EnumChoiceData> JDDTFAALVOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ShowQuickChatEditMenuDelegate LNQLZIOVXDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly ConfigureAttachedObjectDelegate XGMBGKPAPAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly DisplayInvalidNameErrorMessageDelegate LMCLFAAJDTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly IsStringPureDelegate SJCBRKOLIQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly TryGetSpecificChipConfigSummaryDelegate IAXGTDAYEET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly ReleaseIconIdDelegate BSSCEIXZAIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ReportCreationErrorToUserAsyncDelegate OOZWHLNUGSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 WIWCFHFHTYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 WIQVIALKKNI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public RuntimeEnvironment OEOKKPESMOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool UCOFZQEVNSH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyDictionary<int, string> MSNICCOUAAY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<object> UCQRFIBWIBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyList<Guid> RGCNEAPVBFS
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IReadOnlyDictionary<string, EnumChoiceData> UHNCPIWTMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public RoomVersion EWSNKNDTKAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xBD43A0", Offset = "0xBD2FA0", VA = "0x180BD43A0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool BYGUMHZZJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xBD4110", Offset = "0xBD2D10", VA = "0x180BD4110", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool QWUUKYFVSOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2D53CD0", Offset = "0x2D528D0", VA = "0x182D53CD0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JHZTBXLYEAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x2D53C80", Offset = "0x2D52880", VA = "0x182D53C80", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D53E60", Offset = "0x2D52A60", VA = "0x182D53E60")]
		public FSVHUEAVBRZ([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D53A90", Offset = "0x2D52690", VA = "0x182D53A90", Slot = "9")]
		public bool UEWVARKTFYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
		public static bool HMQILQPMOWX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D53450", Offset = "0x2D52050", VA = "0x182D53450", Slot = "10")]
		public bool CSVMQOWCEKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void HPKVGJJDALW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xF84030", Offset = "0xF82C30", VA = "0x180F84030", Slot = "11")]
		public void NEFWWTTCXHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D534C0", Offset = "0x2D520C0", VA = "0x182D534C0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ILOYFQBMEFM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D534F0", Offset = "0x2D520F0", VA = "0x182D534F0", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> IMZUWZXOUGJ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D53550", Offset = "0x2D52150", VA = "0x182D53550")]
		private static IReadOnlyDictionary<Guid, int> IUYUJEOYZAY(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D533E0", Offset = "0x2D51FE0", VA = "0x182D533E0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> BURFLPCWWOX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D53870", Offset = "0x2D52470", VA = "0x182D53870")]
		private static IReadOnlyDictionary<int, Guid> OIKPZKFHZVK(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D539D0", Offset = "0x2D525D0", VA = "0x182D539D0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> TBOQLQQPNOX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D533B0", Offset = "0x2D51FB0", VA = "0x182D533B0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BUJCVZYVHPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D53A60", Offset = "0x2D52660", VA = "0x182D53A60", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UECEPHJYEBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D53980", Offset = "0x2D52580", VA = "0x182D53980")]
		private static IReadOnlyDictionary<Guid, int> SWQEIMDUUPT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D4A700", Offset = "0x2D49300", VA = "0x182D4A700", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> FFNXATDESOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D537B0", Offset = "0x2D523B0", VA = "0x182D537B0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> MFNSQINMDOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void ZFJQIQBMRHQ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D53480", Offset = "0x2D52080", VA = "0x182D53480", Slot = "18")]
		public void FZIZEXMWSTD(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void PVVRJAGRFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D535A0", Offset = "0x2D521A0", VA = "0x182D535A0", Slot = "19")]
		public void JFEBCDUEQQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
		private static bool BLYHUDKSGDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D53380", Offset = "0x2D51F80", VA = "0x182D53380", Slot = "20")]
		public bool AAMHMFBQQDA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
		public static bool WYTUEUTUKHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D53B50", Offset = "0x2D52750", VA = "0x182D53B50", Slot = "21")]
		public bool UINWTIBHIPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D53520", Offset = "0x2D52120", VA = "0x182D53520", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ITKQLJVFSJY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> XDLNTXGUAWW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> OCJCMCLDCFU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D53950", Offset = "0x2D52550", VA = "0x182D53950", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> QQLABUWSKEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> FCLUBCFDRAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> QENZIMVDWDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public static void CSYKDZCOPTJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D53410", Offset = "0x2D52010", VA = "0x182D53410", Slot = "29")]
		public void CDHPPWAWAPI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void EOBQXAKIFUN(HXKABVYEKIU a, VXTUWJBKUSC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D53A30", Offset = "0x2D52630", VA = "0x182D53A30", Slot = "34")]
		public void UDNNKGKZOTG(HXKABVYEKIU a, VXTUWJBKUSC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void JCTSYQMHLBR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D537E0", Offset = "0x2D523E0", VA = "0x182D537E0")]
		private static Task<bool> MGNPRNKZIWP(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D53840", Offset = "0x2D52440", VA = "0x182D53840", Slot = "35")]
		public Task<bool> MMCFAFNEHGG(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D53C70", Offset = "0x2D52870", VA = "0x182D53C70")]
		private static bool VZQIKFOISAX(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D53C90", Offset = "0x2D52890", VA = "0x182D53C90", Slot = "36")]
		public bool XMUEFJXPNZM(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void SOIKLPZTOJB(Id32<KWZBWBHJPPH> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D53A00", Offset = "0x2D52600", VA = "0x182D53A00", Slot = "37")]
		public void TNSKWROOORE(Id32<KWZBWBHJPPH> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D53B80", Offset = "0x2D52780", VA = "0x182D53B80")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__122))]
		private static Task<Result<None, JGXPLWKAZER>> VUMLZLIHJEX(Task<Result<None, JGXPLWKAZER>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D538C0", Offset = "0x2D524C0", VA = "0x182D538C0", Slot = "38")]
		public Task<Result<None, JGXPLWKAZER>> OJLJZLPRRNI(Task<Result<None, JGXPLWKAZER>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D536C0", Offset = "0x2D522C0", VA = "0x182D536C0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__126))]
		private static Task<Result<MultiResult, JGXPLWKAZER>> KMFRQYPBUQD(Task<Result<MultiResult, JGXPLWKAZER>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D53920", Offset = "0x2D52520", VA = "0x182D53920", Slot = "39")]
		public Task<Result<MultiResult, JGXPLWKAZER>> OJLJZLPRRNI(Task<Result<MultiResult, JGXPLWKAZER>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D535D0", Offset = "0x2D521D0", VA = "0x182D535D0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__130))]
		private static Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> KMAKTRVELEU(Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D538F0", Offset = "0x2D524F0", VA = "0x182D538F0", Slot = "40")]
		public Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> OJLJZLPRRNI(Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class FYKUDXEFATQ : LZICCCOSCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(EBUYLMQOMBA e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private InteropDelegate? XJSBABBYZIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly InteropDelegate LJYWAYTCYHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly InteropDelegate CEHXUHTOPZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? HLDKNJPILGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private InvokeStudioFunctionDelegate? NUUOKJAQNEQ;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "5")]
		public LegacyCV2Result<None> HSFNUNGBCRW(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60")]
		private static LegacyCV2Result<None> Default(EBUYLMQOMBA _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "6")]
		public LegacyCV2Result<None> TZKGYDVHEVP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "7")]
		public LegacyCV2Result<None> FMWZDRPOTLM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "8")]
		public LegacyCV2Result<None> DVBAPKFUBTV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "9")]
		public LegacyCV2Result<None> XUBIJCKRVPR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "15")]
		public LegacyCV2Result<None> ELLHJDGFOWE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EBVFIQGQGEY(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ALTGSQVKOOU(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IZKVGFBLFNB(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UMDPSRAKZWG(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MQIJNVUZUFL(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GEVHSQLHKTL(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HYWJJKMHFKM(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "93")]
		public LegacyCV2Result<None> KGLJGOWBJGJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "94")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "95")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TKQDWWMSZBW(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MOTEGZSNQFG(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SGOXKXZYGUD(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "102")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EZZSIKYRVTK(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "103")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JKJOHAIZVLZ(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "104")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NQIJJJPEOQW(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "105")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KUIDQTHZOUH(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1191")]
		public LegacyCV2Result<None> MakeChatAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1192")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1193")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1194")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1196")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1195")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "107")]
		public LegacyCV2Result<None> UBDXTGGJVUU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UBAMFGYFCWB(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "110")]
		public LegacyCV2Result<None> GetSampleAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "111")]
		public LegacyCV2Result<None> GetRecRoomAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "112")]
		public LegacyCV2Result<None> AudioGetLength(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "113")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "114")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "115")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "116")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "117")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "118")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "119")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "120")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "121")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "122")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "123")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "124")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "125")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "126")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "127")]
		public LegacyCV2Result<None> PlayAudioAtPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "785")]
		public LegacyCV2Result<None> WJSJZEHMUAQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "786")]
		public LegacyCV2Result<None> ZOADBKZBGPG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "128")]
		public LegacyCV2Result<None> TJENFWTCOGE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "129")]
		public LegacyCV2Result<None> HBWCIGXMYHG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "130")]
		public LegacyCV2Result<None> MWLTIETFKFB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "131")]
		public LegacyCV2Result<None> TMBZBUQKJXN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "132")]
		public LegacyCV2Result<None> LEDZTSYVEXQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "133")]
		public LegacyCV2Result<None> ConstantAvatarItem(EBUYLMQOMBA e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "134")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "135")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "136")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "137")]
		public LegacyCV2Result<None> MotionTrailSetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "138")]
		public LegacyCV2Result<None> MotionTrailGetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "139")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "140")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "141")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "142")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "143")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "144")]
		public LegacyCV2Result<None> BeaconSetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "145")]
		public LegacyCV2Result<None> BeaconGetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "146")]
		public LegacyCV2Result<None> BeaconSetHeight(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "147")]
		public LegacyCV2Result<None> BeaconGetHeight(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "148")]
		public LegacyCV2Result<None> BeaconSetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "149")]
		public LegacyCV2Result<None> BeaconGetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "150")]
		public LegacyCV2Result<None> LGPHEXNJFQD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "151")]
		public LegacyCV2Result<None> ASLNYQHBPTS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "152")]
		public LegacyCV2Result<None> MUVGRCWTTDO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "153")]
		public LegacyCV2Result<None> GetLocalCameraForward(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "154")]
		public LegacyCV2Result<None> GetLocalCameraUp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "155")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "156")]
		public LegacyCV2Result<None> GetLocalCameraPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "157")]
		public LegacyCV2Result<None> SetCameraShake(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "158")]
		public LegacyCV2Result<None> StopCameraShake(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "159")]
		public LegacyCV2Result<None> SnapCameraImage(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "168")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "169")]
		public LegacyCV2Result<None> CollisionDataGetObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "170")]
		public LegacyCV2Result<None> CollisionDataGetDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "171")]
		public LegacyCV2Result<None> CollisionDataGetPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "172")]
		public LegacyCV2Result<None> CollisionDataGetNormal(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "173")]
		public LegacyCV2Result<None> BNSOZWVCVEK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "174")]
		public LegacyCV2Result<None> QNEVDBMIONH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "175")]
		public LegacyCV2Result<None> LLMPBXGTMLS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "176")]
		public LegacyCV2Result<None> SBVOXHXWATO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "177")]
		public LegacyCV2Result<None> GRJNRRAAPAM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "178")]
		public LegacyCV2Result<None> BFFFLJJYBRX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "179")]
		public LegacyCV2Result<None> EVFQDMQQWVB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "180")]
		public LegacyCV2Result<None> WTUILWTIUWR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "181")]
		public LegacyCV2Result<None> JBOGEZZRCCR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "182")]
		public LegacyCV2Result<None> ITMSMFLKPOB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "183")]
		public LegacyCV2Result<None> LLDIIXHIUWX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "184")]
		public LegacyCV2Result<None> XZJZLSBQTLN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "185")]
		public LegacyCV2Result<None> VLZNOQGUJQF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "186")]
		public LegacyCV2Result<None> BXQLTWMATHK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "187")]
		public LegacyCV2Result<None> JZKHYSSLFGB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "188")]
		public LegacyCV2Result<None> CPLWJFNOBAI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "189")]
		public LegacyCV2Result<None> BQYPWWHXARR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "190")]
		public LegacyCV2Result<None> GLOSFOZSLAE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "191")]
		public LegacyCV2Result<None> IWWKSJFQTLT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "192")]
		public LegacyCV2Result<None> CombatantGetHealthAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "193")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "194")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "195")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "196")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "197")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "198")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "199")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "200")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "201")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "202")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "203")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "204")]
		public LegacyCV2Result<None> CombatantSetHealthAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "205")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "206")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "207")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "208")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "209")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "210")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "211")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "212")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "218")]
		public LegacyCV2Result<None> CombatantToCombatantAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "219")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "220")]
		public LegacyCV2Result<None> CombatantSplit(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "221")]
		public LegacyCV2Result<None> CostumeEquip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "222")]
		public LegacyCV2Result<None> CostumeUnEquip(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "223")]
		public LegacyCV2Result<None> CostumeGetWearer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "224")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "250")]
		public LegacyCV2Result<None> IOJKBMMQERL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "251")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "252")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "253")]
		public LegacyCV2Result<None> IVALNFPSPTR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "254")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "255")]
		public LegacyCV2Result<None> XLNFFIOYVKC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "256")]
		public LegacyCV2Result<None> JVTVQFWLBOI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "257")]
		public LegacyCV2Result<None> YAXUKPIWQYN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "258")]
		public LegacyCV2Result<None> RNXVALCTTJU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "259")]
		public LegacyCV2Result<None> ZYKQKJLKVML(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "260")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "261")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "262")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "263")]
		public LegacyCV2Result<None> JZPJRRUPXNI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "264")]
		public LegacyCV2Result<None> XSRUOKMQWLB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "265")]
		public LegacyCV2Result<None> ToCreationObjectAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "268")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "266")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "267")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "269")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "270")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "271")]
		public LegacyCV2Result<None> ToCreationObjectButton(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "272")]
		public LegacyCV2Result<None> ToCreationObjectContainer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectRotator(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectPiston(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "280")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "281")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "283")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "278")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "284")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectSeat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "275")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "274")]
		public LegacyCV2Result<None> ToCreationObjectDice(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "277")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "285")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "273")]
		public LegacyCV2Result<None> ToCreationObjectCostume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "293")]
		public LegacyCV2Result<None> BIHIIPWYNSI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "282")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "279")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "276")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "320")]
		public LegacyCV2Result<None> FromCreationObjectAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "321")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "322")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "323")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "324")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "325")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "326")]
		public LegacyCV2Result<None> FromCreationObjectButton(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "328")]
		public LegacyCV2Result<None> FromCreationObjectContainer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "329")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "330")]
		public LegacyCV2Result<None> FromCreationObjectDie(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "332")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "331")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "340")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "341")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectPiston(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectRotator(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectText(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "335")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "336")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "338")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "333")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "339")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectSeat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "327")]
		public LegacyCV2Result<None> FromCreationObjectCostume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "337")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "334")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "376")]
		public LegacyCV2Result<None> AWXBINEWXKP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "377")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NIPSDWKWMSS(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "378")]
		public LegacyCV2Result<None> DiceRollFinished(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "379")]
		public LegacyCV2Result<None> DiceResult(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "380")]
		public LegacyCV2Result<None> DicePlayerRolled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "381")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "382")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MHOGFTCNWOC(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "383")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BTVPBDZDVCU(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "384")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NSREVFTOBJF(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "385")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KMMEJNGDTMA(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "386")]
		public LegacyCV2Result<TGHZEVLQENK.CV2DiscoverySectionType> OWOPGXJKGIP(EBUYLMQOMBA e, CircuitSignal a)
		{
			return default(LegacyCV2Result<TGHZEVLQENK.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "387")]
		public LegacyCV2Result<None> HJQPEZQYSTN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "388")]
		public LegacyCV2Result<None> EmitterStart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "389")]
		public LegacyCV2Result<None> EmitterStop(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "390")]
		public LegacyCV2Result<None> EmitterSetLooping(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "391")]
		public LegacyCV2Result<None> EmitterSetSize(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "392")]
		public LegacyCV2Result<None> EmitterSetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "393")]
		public LegacyCV2Result<None> EmitterSetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "394")]
		public LegacyCV2Result<None> EmitterSetColorNew(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "395")]
		public LegacyCV2Result<None> EmitterGetLooping(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "396")]
		public LegacyCV2Result<None> EmitterGetSize(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "397")]
		public LegacyCV2Result<None> EmitterGetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "398")]
		public LegacyCV2Result<None> EmitterGetPlaying(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "399")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(EBUYLMQOMBA e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PYDMGRNZGUH(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "401")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ADQMSWQUUIY(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "402")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BDVRNAFWKUR(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "403")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "404")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "406")]
		public LegacyCV2Result<None> GetFriendlyNameAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "161")]
		public LegacyCV2Result<None> GetFriendlyNameColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "410")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "407")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "408")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "409")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "411")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "412")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "413")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "414")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "415")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "416")]
		public LegacyCV2Result<None> GetFriendlyNameReward(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "417")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "418")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "419")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "420")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "421")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "422")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "423")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "424")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "425")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "426")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "427")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "428")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "429")]
		public LegacyCV2Result<None> SQPJUUUIWGE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "430")]
		public LegacyCV2Result<None> GPXXPQDXOKF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "431")]
		public LegacyCV2Result<None> YVDWELBYXYW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "432")]
		public LegacyCV2Result<None> CKAMGFUZUTJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "433")]
		public LegacyCV2Result<None> RGEXFAKXPOX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "434")]
		public LegacyCV2Result<None> DSSBUJGGMHP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "435")]
		public LegacyCV2Result<None> VQIPHNHNTSK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "436")]
		public LegacyCV2Result<None> ETRYETIUZVC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "441")]
		public LegacyCV2Result<None> SMKCYBQCWWC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "442")]
		public LegacyCV2Result<None> AYFLFYYYXHU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "443")]
		public LegacyCV2Result<None> XUHRJHBMPPF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "444")]
		public LegacyCV2Result<None> NRMEALLEFQO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "445")]
		public LegacyCV2Result<None> ZXEYHBJAUOW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "446")]
		public LegacyCV2Result<None> LGOLFBLUBUP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "437")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(EBUYLMQOMBA executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "438")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(EBUYLMQOMBA executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "439")]
		public LegacyCV2Result<None> XLOUJWQHTKJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "440")]
		public LegacyCV2Result<None> FIBVDWNAYZD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "447")]
		public LegacyCV2Result<None> QWTRCIXAAWZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "448")]
		public LegacyCV2Result<None> PPGDETIGHJL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "449")]
		public LegacyCV2Result<None> GNTOCPRWANM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "450")]
		public LegacyCV2Result<None> RFLCPIDOFTW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "451")]
		public LegacyCV2Result<None> QFPHNXATHAC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "452")]
		public LegacyCV2Result<None> HYLFESKXDXY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "453")]
		public LegacyCV2Result<None> OXLSAHHEUZO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "454")]
		public LegacyCV2Result<None> LOADFZFPPQG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "455")]
		public LegacyCV2Result<None> FNRMKQDQCKE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "456")]
		public LegacyCV2Result<None> RUXXJUZLJFK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "457")]
		public LegacyCV2Result<None> EMZSFCIAFVI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "458")]
		public LegacyCV2Result<None> XBZMBPRMXTA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "459")]
		public LegacyCV2Result<None> XPDBFYHYSHS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "460")]
		public LegacyCV2Result<None> LQJWFWMFMNK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "461")]
		public LegacyCV2Result<None> BAJYWZSEMQM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "462")]
		public LegacyCV2Result<None> VVOTEPFKQXY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "463")]
		public LegacyCV2Result<None> IVDBTHTIXOO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "464")]
		public LegacyCV2Result<None> TKMIPANGHPQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "465")]
		public LegacyCV2Result<None> EABMAOFFJRG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "466")]
		public LegacyCV2Result<None> WYXRILATYKK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D55320", Offset = "0x2D53F20", VA = "0x182D55320", Slot = "467")]
		public LegacyCV2Result<None> SendLogString(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "468")]
		public LegacyCV2Result<None> LerpColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "469")]
		public LegacyCV2Result<None> LerpUnclampedColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "470")]
		public LegacyCV2Result<None> InverseLerpVec3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "471")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "472")]
		public LegacyCV2Result<None> InverseLerpColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "473")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "474")]
		public LegacyCV2Result<None> SNJYINXCRHW(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "475")]
		public LegacyCV2Result<None> HTRHWRRWKNA(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "476")]
		public LegacyCV2Result<None> IGNRGJKDIVA(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "477")]
		public LegacyCV2Result<None> FBGKPCJIKNX(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "478")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "479")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "480")]
		public LegacyCV2Result<None> FogConstantValues(EBUYLMQOMBA e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "481")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "482")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "483")]
		public LegacyCV2Result<None> SunConstantValues(EBUYLMQOMBA e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "484")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "485")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "486")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(EBUYLMQOMBA e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.POCAOXNDGMM> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "487")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "488")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "489")]
		public LegacyCV2Result<None> PASHGBUQJST(EBUYLMQOMBA e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "490")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "491")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "492")]
		public LegacyCV2Result<None> KWDPTWFMABF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "493")]
		public LegacyCV2Result<None> TextScreenClearScreen(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "494")]
		public LegacyCV2Result<None> FDQCAWNOXKM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "495")]
		public LegacyCV2Result<None> VQJWMPJTVLE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "496")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "497")]
		public LegacyCV2Result<None> LYHFLOLVZIO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "498")]
		public LegacyCV2Result<None> CDUMGMEZRDL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D55210", Offset = "0x2D53E10", VA = "0x182D55210", Slot = "499")]
		public LegacyCV2Result<None> GetLocalPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "500")]
		public LegacyCV2Result<None> CWIOFWNPFDD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D55360", Offset = "0x2D53F60", VA = "0x182D55360", Slot = "502")]
		public LegacyCV2Result<None> VVUZECVCGVV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "501")]
		public LegacyCV2Result<None> NFYKGXCALAE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "503")]
		public LegacyCV2Result<None> YBNVGJWZDDK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "504")]
		public LegacyCV2Result<None> REOQJTJDTKT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "505")]
		public LegacyCV2Result<None> JHEMEJHHCXX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "506")]
		public LegacyCV2Result<None> MDGCBOZTWPL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "507")]
		public LegacyCV2Result<None> SYCRRMTJLYX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "508")]
		public LegacyCV2Result<None> DistanceAI_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "509")]
		public LegacyCV2Result<None> DistanceAI_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "510")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "511")]
		public LegacyCV2Result<None> DistanceAI_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "512")]
		public LegacyCV2Result<None> DistanceAI_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "513")]
		public LegacyCV2Result<None> DistanceCombatant_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "514")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "515")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "516")]
		public LegacyCV2Result<None> DistanceCombatant_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "517")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "518")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "519")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "520")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "521")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "522")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "523")]
		public LegacyCV2Result<None> DistancePlayer_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "524")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "525")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "526")]
		public LegacyCV2Result<None> DistancePlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "527")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "528")]
		public LegacyCV2Result<None> DistanceVector3_AI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "529")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "530")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "531")]
		public LegacyCV2Result<None> DistanceVector3_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "532")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "533")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "534")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "535")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "536")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "537")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "538")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "539")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "540")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "541")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "542")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "543")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "544")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "545")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "546")]
		public LegacyCV2Result<None> GetPositionAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "547")]
		public LegacyCV2Result<None> GetPositionCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "548")]
		public LegacyCV2Result<None> GetPositionCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "549")]
		public LegacyCV2Result<None> GetPositionPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "550")]
		public LegacyCV2Result<None> Raycast(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "551")]
		public LegacyCV2Result<None> VHKDYHFYWVW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "552")]
		public LegacyCV2Result<None> RaycastAll(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "553")]
		public LegacyCV2Result<None> Spherecast(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "554")]
		public LegacyCV2Result<None> FBTYIJTSUGH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "555")]
		public LegacyCV2Result<None> SpherecastAll(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "556")]
		public LegacyCV2Result<None> OverlapSphere(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "557")]
		public LegacyCV2Result<None> OverlapBox(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "558")]
		public LegacyCV2Result<None> ONQEHGKSVJM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "559")]
		public LegacyCV2Result<None> UEGMTBDTXLX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "560")]
		public LegacyCV2Result<None> SetPositionPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "561")]
		public LegacyCV2Result<None> SetPositionCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "562")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "563")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "564")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "565")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "567")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "568")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "569")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "570")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "571")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "572")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "573")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "574")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "575")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "576")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "577")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "578")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "579")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "580")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "581")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "582")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "583")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "584")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "585")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "586")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "587")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "588")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "589")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "590")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "591")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "592")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "593")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "594")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "595")]
		public LegacyCV2Result<None> PistonGetDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "596")]
		public LegacyCV2Result<None> PistonSetDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "597")]
		public LegacyCV2Result<None> PistonGetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "598")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "599")]
		public LegacyCV2Result<None> PistonSetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "600")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "601")]
		public LegacyCV2Result<None> PistonGetAcceleration(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "602")]
		public LegacyCV2Result<None> PistonSetAcceleration(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "603")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "604")]
		public LegacyCV2Result<None> PistonGetMaxDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "605")]
		public LegacyCV2Result<None> PistonSetMaxDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "606")]
		public LegacyCV2Result<None> PistonGetTargetDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "607")]
		public LegacyCV2Result<None> PistonSetTargetDistance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "608")]
		public LegacyCV2Result<None> RWNGVRHTFNY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "609")]
		public LegacyCV2Result<None> MGHPJEFYYMG(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "610")]
		public LegacyCV2Result<None> YFNIHLHZPLF(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "611")]
		public LegacyCV2Result<None> HFSKKSCPWYY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "612")]
		public LegacyCV2Result<None> BOERFZTBVQM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "613")]
		public LegacyCV2Result<None> WCGDETMDSQJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "614")]
		public LegacyCV2Result<None> PlayerAddRole(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "615")]
		public LegacyCV2Result<None> PlayerRemoveRole(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "616")]
		public LegacyCV2Result<None> FPNYZZAFODI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "617")]
		public LegacyCV2Result<None> FVQHIKJANDU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "618")]
		public LegacyCV2Result<None> BNPVOFAGTBV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "619")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "620")]
		public LegacyCV2Result<None> PlayerRightHandPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "621")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "622")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "623")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "624")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "625")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "626")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "628")]
		public LegacyCV2Result<None> GHOHEZORTOU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "627")]
		public LegacyCV2Result<None> EJDQNQNMURV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "629")]
		public LegacyCV2Result<None> FAGBBSVFUIO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "630")]
		public LegacyCV2Result<None> FFEDTYKKAZL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "631")]
		public LegacyCV2Result<None> PlayerHeadPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "632")]
		public LegacyCV2Result<None> PlayerHeadOrientation(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "633")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "634")]
		public LegacyCV2Result<None> PlayerHeadUpVector(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "635")]
		public LegacyCV2Result<None> PlayerHeadVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "636")]
		public LegacyCV2Result<None> PlayerHeadHeight(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "637")]
		public LegacyCV2Result<None> YZJABZUIMRI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "638")]
		public LegacyCV2Result<None> VHHDVECQLVD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "639")]
		public LegacyCV2Result<None> PlayerBodyPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "640")]
		public LegacyCV2Result<None> PlayerBodyOrientation(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "641")]
		public LegacyCV2Result<None> ETLJVJAGRJB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "642")]
		public LegacyCV2Result<None> SHLTVBYCIMC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "670")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "675")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(EBUYLMQOMBA e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "661")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "662")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "663")]
		public LegacyCV2Result<None> AVAXCVROENW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "664")]
		public LegacyCV2Result<None> QISVDHYMBIG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "665")]
		public LegacyCV2Result<None> QBAIZAWORKO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "666")]
		public LegacyCV2Result<None> XLJFRHIHNFL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "667")]
		public LegacyCV2Result<None> LBVWUGIJVMJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "668")]
		public LegacyCV2Result<None> PlayerGetCostume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "669")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "643")]
		public LegacyCV2Result<None> EREIDFLCIPA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "644")]
		public LegacyCV2Result<None> DXNIYWPKSBC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "645")]
		public LegacyCV2Result<None> TRNVWESQMNT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "646")]
		public LegacyCV2Result<None> DNEOBKZTHFG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "647")]
		public LegacyCV2Result<None> HCZIWRZVTSL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "648")]
		public LegacyCV2Result<None> KAFPENQLENU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "649")]
		public LegacyCV2Result<None> LSWXYUXJOXK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "650")]
		public LegacyCV2Result<None> POVZJODTTRL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "651")]
		public LegacyCV2Result<None> KBQLHFQUHAZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "652")]
		public LegacyCV2Result<None> AEFAVZNSMEU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "653")]
		public LegacyCV2Result<None> ZDBXIWTULBE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "654")]
		public LegacyCV2Result<None> PWVOLAFGMAL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "655")]
		public LegacyCV2Result<None> AIRTCLQMJYU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "656")]
		public LegacyCV2Result<None> CEIOOVJXFDG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "657")]
		public LegacyCV2Result<None> ZBWXLDSJQHL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "658")]
		public LegacyCV2Result<None> UGXPNAGCSKT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "659")]
		public LegacyCV2Result<None> FBIQFYEBCGJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "660")]
		public LegacyCV2Result<None> QTNQXXROVVY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "671")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "672")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "732")]
		public LegacyCV2Result<None> LZPSRJORCVE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "733")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "734")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "676")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "677")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "678")]
		public LegacyCV2Result<None> SYLVCRGIQTF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "679")]
		public LegacyCV2Result<None> KBXWPHYFCHT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "680")]
		public LegacyCV2Result<None> UFHVMWIRGOP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "681")]
		public LegacyCV2Result<None> NSSDBIGPRXL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "682")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "683")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "684")]
		public LegacyCV2Result<None> XAGMIVBYHJH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "685")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "686")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "687")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "688")]
		public LegacyCV2Result<None> JXKWIMURPPW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "689")]
		public LegacyCV2Result<None> SWTKVRKWCXI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "690")]
		public LegacyCV2Result<None> QGOZZDCSYXL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "691")]
		public LegacyCV2Result<None> IOGJQQQMEYL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "692")]
		public LegacyCV2Result<None> ZFSUGVAQILV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "693")]
		public LegacyCV2Result<None> GEULIOKDMZQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "694")]
		public LegacyCV2Result<None> OAXLTSSGBJR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "695")]
		public LegacyCV2Result<None> SCEDIKJXFDE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "696")]
		public LegacyCV2Result<None> TMOMYKOCPCO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "697")]
		public LegacyCV2Result<None> CZLFPSJUZOC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "698")]
		public LegacyCV2Result<None> YJLTXNYJRSS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "699")]
		public LegacyCV2Result<None> IBQCWSGSADU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "700")]
		public LegacyCV2Result<None> TGLROXSIIOA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "701")]
		public LegacyCV2Result<None> INPDWUXZKKD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "702")]
		public LegacyCV2Result<None> JGSMHITYVWG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "703")]
		public LegacyCV2Result<None> DGDJVHNXDVG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "704")]
		public LegacyCV2Result<None> OIGXKACOSHB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "705")]
		public LegacyCV2Result<None> SPJELAIBUGA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "707")]
		public LegacyCV2Result<None> HSIJXZUWZVI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "706")]
		public LegacyCV2Result<None> HALXYPVCLYA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "708")]
		public LegacyCV2Result<None> KXTJYWORCIJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "709")]
		public LegacyCV2Result<None> AXGUHKVCFUA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "710")]
		public LegacyCV2Result<None> EFGWVWTGYYD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "711")]
		public LegacyCV2Result<None> CUWTUTRHGTB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "712")]
		public LegacyCV2Result<None> CTUSNJKHKQC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "713")]
		public LegacyCV2Result<None> YFZODJQGGIL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "714")]
		public LegacyCV2Result<None> VXSFMGKLBZF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "715")]
		public LegacyCV2Result<None> XVBHLCVQVFC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "716")]
		public LegacyCV2Result<None> UPAYLMSZOVU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "717")]
		public LegacyCV2Result<None> GRMLLTPNBIE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "718")]
		public LegacyCV2Result<None> TCMHOBMALUA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "719")]
		public LegacyCV2Result<None> VLTBJYJFKEO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "720")]
		public LegacyCV2Result<None> DGTABFBOVAG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "721")]
		public LegacyCV2Result<None> ANLIICAFOJI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "722")]
		public LegacyCV2Result<None> LFIYXVYTFQD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "723")]
		public LegacyCV2Result<None> BWAUQZURYEL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "724")]
		public LegacyCV2Result<None> LZYYJTCKEIR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "725")]
		public LegacyCV2Result<None> LOJHPCYQRHB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "726")]
		public LegacyCV2Result<None> QCHXPUUEZFO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "727")]
		public LegacyCV2Result<None> TWMSUPILQCA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "728")]
		public LegacyCV2Result<None> ECNBIHSBJPG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "729")]
		public LegacyCV2Result<None> IQYSDUHIZRP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "730")]
		public LegacyCV2Result<None> YZYBLSHDAJB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "731")]
		public LegacyCV2Result<None> XZLCXAFWQQQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "735")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "736")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "737")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "738")]
		public LegacyCV2Result<None> RSUZLGLNFTG(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "739")]
		public LegacyCV2Result<None> HSKRKPONGHQ(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "740")]
		public LegacyCV2Result<None> BTUOYHDYKSH(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "741")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(EBUYLMQOMBA ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "742")]
		public LegacyCV2Result<None> NMKBSKYJHSR(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "743")]
		public LegacyCV2Result<None> RWWYOCKRESX(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "744")]
		public LegacyCV2Result<None> SCSDMDHIZAC(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "745")]
		public LegacyCV2Result<None> EJULACFNLGS(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "746")]
		public LegacyCV2Result<None> HMHLWODOMVO(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "673")]
		public LegacyCV2Result<None> PlayerGetProfileImage(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "674")]
		public LegacyCV2Result<None> AFOHBBXYZOQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "747")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "748")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "749")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "750")]
		public LegacyCV2Result<None> ShowPlayerProfile(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "751")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "752")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "753")]
		public LegacyCV2Result<None> RequestPostGameRewards(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "754")]
		public LegacyCV2Result<None> SetPlayerWorldUI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "755")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "756")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "757")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "758")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "759")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "760")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "761")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "762")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "763")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "764")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "765")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "766")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "767")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "768")]
		public LegacyCV2Result<None> NYZBVEVIXAE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "769")]
		public LegacyCV2Result<None> ZDHCGNFGZKA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "770")]
		public LegacyCV2Result<None> EKDLNLLMULC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "771")]
		public LegacyCV2Result<None> PVMGTBRAIJQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "772")]
		public LegacyCV2Result<None> XVZUKPDPGYE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "773")]
		public LegacyCV2Result<None> OSRIOARKJNO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "774")]
		public LegacyCV2Result<None> CXLFGVXPTIY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "775")]
		public LegacyCV2Result<None> ELKTIWYFSJE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "776")]
		public LegacyCV2Result<None> BEOANDGUQPK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "777")]
		public LegacyCV2Result<None> XPNBSHHUGUM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "778")]
		public LegacyCV2Result<None> NUFRHZLGXLQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "779")]
		public LegacyCV2Result<None> XQOVSQEGASZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "781")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "782")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "783")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "784")]
		public LegacyCV2Result<None> AGINCHAJUHA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "787")]
		public LegacyCV2Result<None> GetProjectile(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "788")]
		public LegacyCV2Result<None> TKJORGGWMPX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "789")]
		public LegacyCV2Result<None> ZAYBLWCHBNR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "790")]
		public LegacyCV2Result<None> KYPDMZXKHJV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "791")]
		public LegacyCV2Result<None> PISQWBNWMVT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "792")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "793")]
		public LegacyCV2Result<None> UHROKEJYKRD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "794")]
		public LegacyCV2Result<None> KLYWPGTOTGC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "795")]
		public LegacyCV2Result<None> UHHJHUEYGOY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "796")]
		public LegacyCV2Result<None> ResetRoom(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "797")]
		public LegacyCV2Result<None> ResetObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "798")]
		public LegacyCV2Result<None> DPPZBGVAYBS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "799")]
		public LegacyCV2Result<None> HGZAHRUAUAV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "800")]
		public LegacyCV2Result<None> ODVIWDMYMTK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "801")]
		public LegacyCV2Result<None> ConstantReward(EBUYLMQOMBA e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "802")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "109")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "803")]
		public LegacyCV2Result<None> ActivateConsumable(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "804")]
		public LegacyCV2Result<None> DeactivateConsumable(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "805")]
		public LegacyCV2Result<None> ConstantConsumable(EBUYLMQOMBA e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "806")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "807")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "808")]
		public LegacyCV2Result<None> ConstantRoomKey(EBUYLMQOMBA e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "809")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "810")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "811")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "812")]
		public LegacyCV2Result<None> ConstantInventoryItem(EBUYLMQOMBA e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "813")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "814")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "815")]
		public LegacyCV2Result<None> QJTIOZKKDXN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "817")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "818")]
		public LegacyCV2Result<None> NGZZCQCVSSP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "819")]
		public LegacyCV2Result<None> SVMKPYLMQDH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "820")]
		public LegacyCV2Result<None> MSXBEUUAMEP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "821")]
		public LegacyCV2Result<None> QZXKIVCLIGK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "822")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "823")]
		public LegacyCV2Result<None> ConstantRoomOffer(EBUYLMQOMBA e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "824")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "826")]
		public LegacyCV2Result<None> WOPYJXBLWPD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "827")]
		public LegacyCV2Result<None> WYXTVMEZUBJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "828")]
		public LegacyCV2Result<None> ConstantRoomCurrency(EBUYLMQOMBA e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(EBUYLMQOMBA e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(EBUYLMQOMBA e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "832")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(EBUYLMQOMBA e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "833")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "834")]
		public LegacyCV2Result<None> QPRZJYACJRT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "835")]
		public LegacyCV2Result<None> XIAJHTSQPIK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "836")]
		public LegacyCV2Result<None> KMZZARXVEHH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "837")]
		public LegacyCV2Result<None> FUHSMIHZRBX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "838")]
		public LegacyCV2Result<None> NKDQCUNATFN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "842")]
		public LegacyCV2Result<None> VAQUNQKBAKA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "843")]
		public LegacyCV2Result<None> NRWDWLTRYHK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "844")]
		public LegacyCV2Result<None> DNFCTWAGOIP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "846")]
		public LegacyCV2Result<None> SWWNVHMMJVN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "845")]
		public LegacyCV2Result<None> ECGXJMXEQZD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "847")]
		public LegacyCV2Result<None> FHTPRABEHPO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "849")]
		public LegacyCV2Result<None> FJINVVHGGAU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "848")]
		public LegacyCV2Result<None> PKDARSVFBCI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "850")]
		public LegacyCV2Result<None> RWPTPDGESZH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "851")]
		public LegacyCV2Result<None> RIWWOLFUXAZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "852")]
		public LegacyCV2Result<None> AWLYYRWQMHQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "853")]
		public LegacyCV2Result<None> MOGWEVVTIBC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "854")]
		public LegacyCV2Result<None> SPJXROAHZSS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "855")]
		public LegacyCV2Result<None> FBADZFIJSFI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "856")]
		public LegacyCV2Result<None> QFPUIOWVALQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "857")]
		public LegacyCV2Result<None> AllowDressUp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "858")]
		public LegacyCV2Result<None> ForbidDressUp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "859")]
		public LegacyCV2Result<None> OpenStore(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "860")]
		public LegacyCV2Result<None> OpenCheckout(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "861")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "862")]
		public LegacyCV2Result<None> GetTrialItemQuantity(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "863")]
		public LegacyCV2Result<None> EMTJACJULQE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "864")]
		public LegacyCV2Result<None> QWVXHOWOXVQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "865")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "866")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "867")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "868")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "869")]
		public LegacyCV2Result<None> StorefrontGetOffersList(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "870")]
		public LegacyCV2Result<None> StorefrontSetOffersList(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "871")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "872")]
		public LegacyCV2Result<None> GetStoreItemDetails(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "874")]
		public LegacyCV2Result<None> MannequinSetStoreItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "875")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "876")]
		public LegacyCV2Result<None> RaiseStudioEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "877")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "878")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "879")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "880")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "881")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "882")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "883")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "884")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(EBUYLMQOMBA e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "885")]
		public LegacyCV2Result<None> YCBHEFAOEBS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "886")]
		public LegacyCV2Result<None> EPKKBNLUGXI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "887")]
		public LegacyCV2Result<None> CBZNNBLHVUJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "888")]
		public LegacyCV2Result<None> VMQWCUOASGR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "889")]
		public LegacyCV2Result<None> OSTZDVHOEZG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "890")]
		public LegacyCV2Result<None> VSRPLJXFPVG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "891")]
		public LegacyCV2Result<None> KXTZWPYREIT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "892")]
		public LegacyCV2Result<None> SOPOJBCRURX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "893")]
		public LegacyCV2Result<None> QCEXPIWNCZJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "894")]
		public LegacyCV2Result<None> MLCOTQVWHBM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "895")]
		public LegacyCV2Result<None> GetFromSyncIdAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "896")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "897")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "898")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "899")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "900")]
		public LegacyCV2Result<None> GetSyncIdAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "901")]
		public LegacyCV2Result<None> GetSyncIdCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "902")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "903")]
		public LegacyCV2Result<None> GetSyncIdPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "904")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "912")]
		public LegacyCV2Result<None> HECGXJSGMNI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "911")]
		public LegacyCV2Result<None> WEYQTBDGRPX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "913")]
		public LegacyCV2Result<None> WBJSIVEQAOF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "914")]
		public LegacyCV2Result<None> PUBHWWDVGME(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "915")]
		public LegacyCV2Result<None> QWKSTKKVMOJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "916")]
		public LegacyCV2Result<None> FPMKDVCEJXR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "917")]
		public LegacyCV2Result<None> ZJHVDRKFAIQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "905")]
		public LegacyCV2Result<None> TextToolGetText(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "906")]
		public LegacyCV2Result<None> TextToolSetText(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "907")]
		public LegacyCV2Result<None> TextToolSetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "908")]
		public LegacyCV2Result<None> TextToolSetColorNew(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "909")]
		public LegacyCV2Result<None> TextToolSetMaterial(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "910")]
		public LegacyCV2Result<None> TextToolGetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "918")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "919")]
		public LegacyCV2Result<None> CXZPVYTPAQL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "925")]
		public LegacyCV2Result<None> GetParticleVfx(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "926")]
		public LegacyCV2Result<None> FNTDAXNMYRA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "927")]
		public LegacyCV2Result<None> OIPSKLUVURM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "928")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "929")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "930")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "931")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "932")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "933")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "934")]
		public LegacyCV2Result<None> GoToRoom(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "935")]
		public LegacyCV2Result<None> EAQRKJRFUSB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "920")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "921")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "922")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "923")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "924")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "936")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "937")]
		public LegacyCV2Result<None> QMMRAFVFVUZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "938")]
		public LegacyCV2Result<None> KUFVCSDVWWX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "939")]
		public LegacyCV2Result<None> PRTLUMXJJZB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "940")]
		public LegacyCV2Result<None> ZFBIRPIWIQR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "941")]
		public LegacyCV2Result<None> FGNKHVTUHOP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "942")]
		public LegacyCV2Result<None> MHXRIUABHBN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "943")]
		public LegacyCV2Result<None> WVMHHAAXDYB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "944")]
		public LegacyCV2Result<None> NSMLLQYZJOB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "945")]
		public LegacyCV2Result<None> WWSPAODDYYZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "946")]
		public LegacyCV2Result<None> FBVIFMTOIWR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "950")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "951")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "947")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "948")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "949")]
		public LegacyCV2Result<None> PlayerGetXp(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "952")]
		public LegacyCV2Result<None> PerlinNoise(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "953")]
		public LegacyCV2Result<None> AGTTZDEWWJX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "954")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "955")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "956")]
		public LegacyCV2Result<None> SeatSetLockOut(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "957")]
		public LegacyCV2Result<None> SeatSetLockIn(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "958")]
		public LegacyCV2Result<None> SeatUnseatPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "959")]
		public LegacyCV2Result<None> SeatGetLockIn(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "960")]
		public LegacyCV2Result<None> SeatGetLockOut(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "961")]
		public LegacyCV2Result<None> YYMRPFCZKNO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "962")]
		public LegacyCV2Result<None> TLLMJXJPQJZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "963")]
		public LegacyCV2Result<None> AZJLDHOLSNS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "964")]
		public LegacyCV2Result<None> EHDLJWAIETZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "965")]
		public LegacyCV2Result<None> DCZLXXAMHXQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "966")]
		public LegacyCV2Result<None> PFPOURQZBSH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "967")]
		public LegacyCV2Result<None> HWSZQJJQJPQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "968")]
		public LegacyCV2Result<None> BPBTOYBAFPU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "969")]
		public LegacyCV2Result<None> MPFHPKSQMAJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "970")]
		public LegacyCV2Result<None> SRREELMPOQQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "971")]
		public LegacyCV2Result<None> CINSPFDDUCC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "972")]
		public LegacyCV2Result<None> AQPRZFEMDKP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "973")]
		public LegacyCV2Result<None> TQKNSZCROZP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "974")]
		public LegacyCV2Result<None> PTTTJQQKAVI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "975")]
		public LegacyCV2Result<None> EVROPPWAPGV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "976")]
		public LegacyCV2Result<None> WOPWGFAYLVI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "977")]
		public LegacyCV2Result<None> VPEMEHNXJVY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "978")]
		public LegacyCV2Result<None> NavMeshSamplePosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "979")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "991")]
		public LegacyCV2Result<None> CIXBRMLCCVQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "992")]
		public LegacyCV2Result<None> EXCTQPMEVOO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "993")]
		public LegacyCV2Result<None> YJHDQWDWTFG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "994")]
		public LegacyCV2Result<None> INNYORBIOUY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "995")]
		public LegacyCV2Result<None> AGMTDIQXSAJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "996")]
		public LegacyCV2Result<None> QSPGHANLQMN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "997")]
		public LegacyCV2Result<None> HFOKVVWIVBW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "998")]
		public LegacyCV2Result<None> KWXZGJFBGLH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "999")]
		public LegacyCV2Result<None> XUKGIAHADYI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1000")]
		public LegacyCV2Result<None> DJURFTBAYWD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1001")]
		public LegacyCV2Result<None> FNGBQKWIUAZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1002")]
		public LegacyCV2Result<None> LALVWVFRRWM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1003")]
		public LegacyCV2Result<None> SHXKBNFRWRB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1004")]
		public LegacyCV2Result<None> ZFDQNYIKUHH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1005")]
		public LegacyCV2Result<None> NUYYHSZETDX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1006")]
		public LegacyCV2Result<None> SMEVPQYSBPX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1007")]
		public LegacyCV2Result<None> SCEJOGBQONT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1008")]
		public LegacyCV2Result<None> QGLMRHAWNUY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1009")]
		public LegacyCV2Result<None> ZKIVYYXROFO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1010")]
		public LegacyCV2Result<None> TEHLMQIKVYT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1011")]
		public LegacyCV2Result<None> JHZPHXXBOSP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1012")]
		public LegacyCV2Result<None> KNBUBEGQCMF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1013")]
		public LegacyCV2Result<None> BRWNOGXVXJL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1014")]
		public LegacyCV2Result<None> EHKKNGDNLRS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1015")]
		public LegacyCV2Result<None> JFSPCITDRBG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1016")]
		public LegacyCV2Result<None> IsValidAI(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1017")]
		public LegacyCV2Result<None> IsValidCombatant(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D55250", Offset = "0x2D53E50", VA = "0x182D55250", Slot = "1018")]
		public LegacyCV2Result<None> IsValidPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1019")]
		public LegacyCV2Result<None> IsValidReward(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1020")]
		public LegacyCV2Result<None> IsValidAudio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1021")]
		public LegacyCV2Result<None> ValidIfNotNull(EBUYLMQOMBA e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1022")]
		public LegacyCV2Result<None> GetVelocityCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1023")]
		public LegacyCV2Result<None> GetVelocityPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1024")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1025")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1026")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1027")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1028")]
		public LegacyCV2Result<None> GetUpVectorPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1029")]
		public LegacyCV2Result<None> GetOrientationCreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1030")]
		public LegacyCV2Result<None> GetOrientationPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1031")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1032")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1033")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1034")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1035")]
		public LegacyCV2Result<None> SMXQBJRPNGR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1036")]
		public LegacyCV2Result<None> CGMMPIQAEDG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1037")]
		public LegacyCV2Result<None> MQHDGKFIMMA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1038")]
		public LegacyCV2Result<None> GTEDZTGKKNO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1039")]
		public LegacyCV2Result<None> CYTSFWSKYBK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1040")]
		public LegacyCV2Result<None> RXWQYUEHJGQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1041")]
		public LegacyCV2Result<None> VWEAILARUCI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1042")]
		public LegacyCV2Result<None> HFWPHQAJFNY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1043")]
		public LegacyCV2Result<None> KHBLSDVJZHQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1044")]
		public LegacyCV2Result<None> WVJGRKMNIOC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1045")]
		public LegacyCV2Result<None> KITMUJLWTVE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1046")]
		public LegacyCV2Result<None> ZJISJQQEGAZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1047")]
		public LegacyCV2Result<None> BSMXVNHVZEJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1048")]
		public LegacyCV2Result<None> OGGBFKDUVKR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1049")]
		public LegacyCV2Result<None> XAXAKYKAJIZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1050")]
		public LegacyCV2Result<None> WKWUZJESMJO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1051")]
		public LegacyCV2Result<None> SDBRYRRRLSE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1052")]
		public LegacyCV2Result<None> YBQDCCRFQQL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1053")]
		public LegacyCV2Result<None> DXQZQDQFZGP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1054")]
		public LegacyCV2Result<None> XJQHEGDRSFH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1055")]
		public LegacyCV2Result<None> CUZWDURDVWF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1056")]
		public LegacyCV2Result<None> SENBRCVMQWE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1057")]
		public LegacyCV2Result<None> UZQGGKOAFJO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1058")]
		public LegacyCV2Result<None> KHUXPWCYXGJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1059")]
		public LegacyCV2Result<None> JSEFCPJRBUR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1060")]
		public LegacyCV2Result<None> GJSAESEJMGN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1061")]
		public LegacyCV2Result<None> QAVTKLMRSAF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1062")]
		public LegacyCV2Result<None> QIPZVTDUDJG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1063")]
		public LegacyCV2Result<None> NOMTXLXECCV(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1064")]
		public LegacyCV2Result<None> ZGLLRBWDDXB(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1065")]
		public LegacyCV2Result<None> ZYGQHULLQLB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1066")]
		public LegacyCV2Result<None> IZGEYANEVYO(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1067")]
		public LegacyCV2Result<None> AFHWWWCZYQW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1068")]
		public LegacyCV2Result<None> NHASEWPGZGI(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1069")]
		public LegacyCV2Result<None> ZGAQQBHIPPS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1070")]
		public LegacyCV2Result<None> SCBQWYKRCRI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1071")]
		public LegacyCV2Result<None> FNPUDNIOTYC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1072")]
		public LegacyCV2Result<None> GIWPSONZTRE(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1073")]
		public LegacyCV2Result<None> WTABRHEGDNF(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1074")]
		public LegacyCV2Result<None> VGJCBRVRVOE(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1075")]
		public LegacyCV2Result<None> CLCGTZMZBVN(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1076")]
		public LegacyCV2Result<None> DKGAWBNTHWA(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1077")]
		public LegacyCV2Result<None> UNTYZAAKMCY(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1078")]
		public LegacyCV2Result<None> ORTFFPKMFTJ(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1079")]
		public LegacyCV2Result<None> CAOVBYNGJCT(ABZCVUHNAYT e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1080")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1081")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1082")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1083")]
		public LegacyCV2Result<None> UDWLJVPGNPH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1084")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1085")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1086")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1087")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1088")]
		public LegacyCV2Result<None> HolotarProjectorPlay(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1089")]
		public LegacyCV2Result<None> HolotarProjectorResume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1090")]
		public LegacyCV2Result<None> HolotarProjectorPause(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1091")]
		public LegacyCV2Result<None> HolotarProjectorStop(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1092")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1093")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1094")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1095")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1096")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1097")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1098")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1099")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1100")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1101")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1102")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1103")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1104")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1105")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1106")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1107")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1108")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1109")]
		public LegacyCV2Result<None> LGJDOZZOBPN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1110")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1111")]
		public LegacyCV2Result<None> MQRGRKWUBFB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1112")]
		public LegacyCV2Result<None> CGQDUPNTCHU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1113")]
		public LegacyCV2Result<None> TBITBXVECXL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1114")]
		public LegacyCV2Result<None> HLMBUXGAKXK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1115")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1116")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1117")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1118")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1119")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1120")]
		public LegacyCV2Result<None> GunHandleGetCanReload(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1121")]
		public LegacyCV2Result<None> GunHandleSetCanReload(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1122")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1123")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1124")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1125")]
		public LegacyCV2Result<None> IAYBBVFWKTK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1126")]
		public LegacyCV2Result<None> QHJXJLEEGOM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1127")]
		public LegacyCV2Result<None> CRFFAZUUYVM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1128")]
		public LegacyCV2Result<None> IHBNXVXXQLQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1129")]
		public LegacyCV2Result<None> RDTDBPWCPLD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1130")]
		public LegacyCV2Result<None> ULZUCQUOAYX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1131")]
		public LegacyCV2Result<None> WZSEQNIUDED(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1132")]
		public LegacyCV2Result<None> QMMXCLUYSNX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1133")]
		public LegacyCV2Result<None> JPKZHABDLXS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1134")]
		public LegacyCV2Result<None> AUSFURTYCVW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1135")]
		public LegacyCV2Result<None> QDECLLDCXBJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1136")]
		public LegacyCV2Result<None> GEDHDRGEDGU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "160")]
		public LegacyCV2Result<None> IZTPFVCOCCW(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "162")]
		public LegacyCV2Result<None> GetIntFromRROColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "163")]
		public LegacyCV2Result<None> GetColorFromRGB(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "164")]
		public LegacyCV2Result<None> GetColorFromHSV(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "165")]
		public LegacyCV2Result<None> GetRGBFromColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "166")]
		public LegacyCV2Result<None> GetHSVFromColor(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x2D553A0", Offset = "0x2D53FA0", VA = "0x182D553A0", Slot = "167")]
		public bool YQNVORAWCEE(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1137")]
		public LegacyCV2Result<None> EZSKODWSWWU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1138")]
		public LegacyCV2Result<None> YMPASDUQXCP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1139")]
		public LegacyCV2Result<None> UJRIZVTSPTO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(EBUYLMQOMBA e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1151")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1140")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1141")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1142")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1143")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1144")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1145")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1146")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1147")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1148")]
		public LegacyCV2Result<None> CLNTDLMHYYF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1149")]
		public LegacyCV2Result<None> OVTJGFOCTBT(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "225")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(EBUYLMQOMBA e, InOut io, WLMRTWBYHRP objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "226")]
		public LegacyCV2Result<None> MVOYWLOOEOU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "227")]
		public LegacyCV2Result<None> FEKLEQQXXSA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "228")]
		public LegacyCV2Result<None> CZCPOTHLCDG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "229")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "230")]
		public LegacyCV2Result<None> BFVCAMKGGRH(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "231")]
		public LegacyCV2Result<None> JSPHHGRUGXB(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "232")]
		public LegacyCV2Result<None> RCRSQTOCWRJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "233")]
		public LegacyCV2Result<None> TGXRWTWWYOE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "234")]
		public LegacyCV2Result<None> MEFCCNKDXWU(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "235")]
		public LegacyCV2Result<None> NDNWEMWUNHP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "236")]
		public LegacyCV2Result<None> JROEQBHXYCJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "237")]
		public LegacyCV2Result<None> HKJQCTURKTJ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "238")]
		public LegacyCV2Result<None> FQILNRWFUKP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "239")]
		public LegacyCV2Result<None> BTMEQZKDQHG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "240")]
		public LegacyCV2Result<None> AUUHCCJVZBC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "241")]
		public LegacyCV2Result<None> DCGIFDONIOM(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "242")]
		public LegacyCV2Result<None> CYWONFLDKKO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "243")]
		public LegacyCV2Result<None> BAEOOKCOODI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "244")]
		public LegacyCV2Result<None> ROXOLIHMTFK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "245")]
		public LegacyCV2Result<None> ZOJKNVNTSSY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "246")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "247")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "248")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "249")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60")]
		private static LegacyCV2Result<None> Default(EBUYLMQOMBA e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2D55290", Offset = "0x2D53E90", VA = "0x182D55290", Slot = "1152")]
		public LegacyCV2Result<None> PWLTFUUGFEP(EBUYLMQOMBA a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1155")]
		public LegacyCV2Result<None> YWKUOWYVGRE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1156")]
		public LegacyCV2Result<None> TJVIRIBJHBS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1157")]
		public LegacyCV2Result<None> QSEASVTQUQS(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1158")]
		public LegacyCV2Result<None> KVVRBRYQYKP(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1153")]
		public LegacyCV2Result<None> ConstantQuickChatTable(EBUYLMQOMBA e, InOut io, KOEISEEXUJN quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1154")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "980")]
		public LegacyCV2Result<None> CZVSFJIUYQI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "981")]
		public LegacyCV2Result<None> XBAEORHVBMA(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "982")]
		public LegacyCV2Result<None> HXMDINLPYTC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "983")]
		public LegacyCV2Result<None> DJCEPVBZXPC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "984")]
		public LegacyCV2Result<None> FFTHHKXZJJI(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "985")]
		public LegacyCV2Result<None> KWAQCBICLFE(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "986")]
		public LegacyCV2Result<None> IJLBEPTIING(EBUYLMQOMBA a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "987")]
		public LegacyCV2Result<None> EKETSEOTBUC(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "988")]
		public LegacyCV2Result<None> OPNXMKIAPYG(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "989")]
		public LegacyCV2Result<None> UINIBLSVRLD(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "990")]
		public LegacyCV2Result<None> TKGEIOAODEF(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1162")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1163")]
		public LegacyCV2Result<None> HandleSetControlLabel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1164")]
		public LegacyCV2Result<None> HandleGetControlLabel(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1165")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1166")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1167")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1168")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1169")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AUNJHOYTSYP(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1176")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1177")]
		public LegacyCV2Result<None> ZUJIHOKVRMO(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1178")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1179")]
		public LegacyCV2Result<None> RSQDVIPTEQR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1180")]
		public LegacyCV2Result<None> ElementSnapToElement(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1181")]
		public LegacyCV2Result<None> ElementUnsnap(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1182")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1183")]
		public LegacyCV2Result<None> SnapPointUnsnap(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1170")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1171")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1172")]
		public LegacyCV2Result<None> YOCJUHVGUGN(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1173")]
		public LegacyCV2Result<None> GetTexture(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1174")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1175")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1184")]
		public LegacyCV2Result<None> QNYOBALAFQL(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1185")]
		public LegacyCV2Result<None> ZQPQUPGFATY(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1186")]
		public LegacyCV2Result<None> ZUHZZYOFTVQ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1187")]
		public LegacyCV2Result<None> KRCBHOVVIRR(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1188")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QWPTXLDTEYT(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1189")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FBEBQPPVKLZ(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1190")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MLTREBDMLFB(EBUYLMQOMBA a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D553B0", Offset = "0x2D53FB0", VA = "0x182D553B0")]
		public FYKUDXEFATQ([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1197")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1198")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1199")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1200")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1201")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1202")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1203")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1204")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1205")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1206")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1207")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1208")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1209")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1210")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1211")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1212")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1213")]
		public LegacyCV2Result<None> ConstantBodyPart(EBUYLMQOMBA e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1214")]
		public LegacyCV2Result<None> PFMICTCZGWK(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1215")]
		public LegacyCV2Result<None> CSKNMRPCDTZ(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1216")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "566")]
		public LegacyCV2Result<None> QLMLLBUBHWX(EBUYLMQOMBA e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1217")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1218")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1219")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1220")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1221")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1222")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1223")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1224")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1225")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1226")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1227")]
		public LegacyCV2Result<None> TDERUBSPQIQ(ABZCVUHNAYT e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1228")]
		public LegacyCV2Result<None> AYLKXRRKECT(ABZCVUHNAYT e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1229")]
		public LegacyCV2Result<None> VBBOZLQDICI(ABZCVUHNAYT e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1230")]
		public LegacyCV2Result<None> BTOSYVSWVWU(ABZCVUHNAYT e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1231")]
		public LegacyCV2Result<None> UGCCWHQLHCD(ABZCVUHNAYT e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60")]
		public LegacyCV2Result<None> ConstantStorefrontItem(EBUYLMQOMBA e, InOut io, [In] DSCOFEIRJNM storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1160")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1161")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(EBUYLMQOMBA e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1150")]
		private LegacyCV2Result<None> OZLPGYHBVTE(EBUYLMQOMBA a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "1159")]
		private LegacyCV2Result<None> ZCHSIHNMJIZ(EBUYLMQOMBA a, InOut b, [In] DSCOFEIRJNM storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class TEQAPDRCOOD : AYBNVZICMFS
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(ISQMNSLHPDN node);

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly TEQAPDRCOOD SFYIBZFHVJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate KVKCAAAKRFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate BOFPAFHMDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private bool EFICIDSMQBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool CGAUOWAHNUW;

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70", Slot = "4")]
		public Task<bool> ORNNWOVMDSN(ISQMNSLHPDN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D64AD0", Offset = "0x2D636D0", VA = "0x182D64AD0", Slot = "5")]
		public Task<bool> GYHVNPFMJUM(ISQMNSLHPDN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D64BA0", Offset = "0x2D637A0", VA = "0x182D64BA0")]
		public TEQAPDRCOOD([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D64B00", Offset = "0x2D63700", VA = "0x182D64B00", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? HVUKSXZSEDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220", Slot = "7")]
		public bool BDQEGKMEGEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x1697C10", Offset = "0x1696810", VA = "0x181697C10", Slot = "8")]
		public bool KLJHGCKJXQW()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Obsolete]
	public sealed class ALBOOUMKUBD : AQDYFLYICTW
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid QSUOOLCUEWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void Bind(KICLDPOGVNI pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x11E9A20", Offset = "0x11E8620", VA = "0x1811E9A20")]
		public ALBOOUMKUBD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D610D0", Offset = "0x2D5FCD0", VA = "0x182D610D0")]
		public static ALBOOUMKUBD New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class YRNQHSWAMRB : ADSZSQCVFAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public delegate bool IsNodeRestrictedDelegate(Id128<EPXTWKGOJAA> nodeDefId, Id128<JQPVMRMCZNG>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IsNodeRestrictedDelegate? RIDMQHZTSGM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BYGUMHZZJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EZUJBKBPUKS
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x2D69F20", Offset = "0x2D68B20", VA = "0x182D69F20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool SNEZHJDFYZV
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x2393C80", Offset = "0x2392880", VA = "0x182393C80", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "6")]
		public bool EIOBBELDMAM(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "7")]
		public CanSaveObjectIntoInventionResultType NAXYNQIPBOF(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D69ED0", Offset = "0x2D68AD0", VA = "0x182D69ED0", Slot = "8")]
		public bool RMFTZCAGDPC(Id128<EPXTWKGOJAA> nodeDefId, Id128<JQPVMRMCZNG>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
		public bool URFMRATTKCL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "10")]
		public bool MUYIKIASOMX(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D69F30", Offset = "0x2D68B30", VA = "0x182D69F30")]
		public YRNQHSWAMRB(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class VBXSIHLHTJV : DGTUMWLRJWM
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly VBXSIHLHTJV SFYIBZFHVJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ShouldLogEventSenderToMakerPenDelegate RWWZODCMCAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate MDUEWFUZOOT;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NELQICKYDXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0x13533E0", Offset = "0x1351FE0", VA = "0x1813533E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool APGNZCWIFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x2D67950", Offset = "0x2D66550", VA = "0x182D67950", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2D679F0", Offset = "0x2D665F0", VA = "0x182D679F0")]
		public VBXSIHLHTJV([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class BOGDYYAKHLC : LGFMTZREUMN
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly BOGDYYAKHLC CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "4")]
		public object Deserialize(object value, Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BOGDYYAKHLC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class DXVZKEUHDLF : XGVPGBNZWEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class XOBJFMPHDLG : RLICAXYJDLP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public static readonly XOBJFMPHDLG CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool JZXUPAMYITE
			{
				[Cpp2IlInjected.Token(Token = "0x6000712")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x2D67CF0", Offset = "0x2D668F0", VA = "0x182D67CF0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			public void FISHJDRILVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XOBJFMPHDLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly DXVZKEUHDLF CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private DXVZKEUHDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2D623D0", Offset = "0x2D60FD0", VA = "0x182D623D0", Slot = "4")]
		public RLICAXYJDLP JQSTEJIDXIY()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class CGOWFXVOVPF<a, b> : IDisposable, SILNEZLGRTM where a : notnull where b : notnull, TDCKFGWTXZP.MQMDYMTPLDL<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly b KOIFGESKYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly a DGUJSJOVIIS;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<NAXUEJSETKJ> NQXKXYOLGTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<NAXUEJSETKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x438DFB0", Offset = "0x438CBB0", VA = "0x18438DFB0")]
		public CGOWFXVOVPF(b a, a b, Id32<NAXUEJSETKJ> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x438C400", Offset = "0x438B000", VA = "0x18438C400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x438CB20", Offset = "0x438B720", VA = "0x18438CB20")]
		public Id32<JCZZZGYZEZI> KLBAFAAOCCP([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<JCZZZGYZEZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x438D830", Offset = "0x438C430", VA = "0x18438D830", Slot = "6")]
		public void UHGZUXXNTIU(Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x438D580", Offset = "0x438C180", VA = "0x18438D580", Slot = "7")]
		public void TDUSJHRSNIG(Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x438BF00", Offset = "0x438AB00", VA = "0x18438BF00", Slot = "8")]
		public void BDHCBMQPJZR(Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x438C870", Offset = "0x438B470", VA = "0x18438C870", Slot = "10")]
		public void HVKDPAMLJUY(Id32<JCZZZGYZEZI> objectId, Id32<NAXUEJSETKJ> clientId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x438D5C0", Offset = "0x438C1C0", VA = "0x18438D5C0", Slot = "9")]
		public void UDGDBGPKQQG(Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x438CDD0", Offset = "0x438B9D0", VA = "0x18438CDD0", Slot = "11")]
		public void LNXSUKGFGXW(Id32<JCZZZGYZEZI> objectId, HNXUMQZYUXF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x438D2B0", Offset = "0x438BEB0", VA = "0x18438D2B0", Slot = "12")]
		public Id32<NAXUEJSETKJ> QXGWVINWTMT(Id32<JCZZZGYZEZI> objectId)
		{
			return default(Id32<NAXUEJSETKJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x438DAA0", Offset = "0x438C6A0", VA = "0x18438DAA0", Slot = "13")]
		public Id32<DYGAYOUURZQ> UIPCARLSUNP(Id32<JCZZZGYZEZI> objectId, string a, object b, QVVEGMKXHXU c, HPXOTNIQIPU d)
		{
			return default(Id32<DYGAYOUURZQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x438DF70", Offset = "0x438CB70", VA = "0x18438DF70", Slot = "14")]
		public void XONZEUNQGOL(Id32<DYGAYOUURZQ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x438CAE0", Offset = "0x438B6E0", VA = "0x18438CAE0", Slot = "15")]
		public void JCOZDKUZOMP(Id32<DYGAYOUURZQ> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class TDCKFGWTXZP
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface MQMDYMTPLDL<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ITQBPFLWDGF(a a, Id32<NAXUEJSETKJ> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<NAXUEJSETKJ>? VSQGTSVXBHE(a a);

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<JCZZZGYZEZI> KLBAFAAOCCP(a a, Id32<NAXUEJSETKJ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void UHGZUXXNTIU(a a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b);

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void TDUSJHRSNIG(a a, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b);

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void HVKDPAMLJUY(a a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b);

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void UDGDBGPKQQG(a a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b);

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void LNXSUKGFGXW(a a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, HNXUMQZYUXF? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<NAXUEJSETKJ>? QXGWVINWTMT(a a, Id32<JCZZZGYZEZI> objectId);

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<DYGAYOUURZQ> UIPCARLSUNP(a a, Id32<NAXUEJSETKJ> clientId, string b, object c, QVVEGMKXHXU d, HPXOTNIQIPU e);

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void XONZEUNQGOL(a a, Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void JCOZDKUZOMP(a a, Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class YHIGBDAQIBP
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public readonly HashSet<Id32<JCZZZGYZEZI>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public SOAId32Field<DYGAYOUURZQ, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly Dictionary<Id32<DYGAYOUURZQ>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DYGAYOUURZQ>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public SOAField<JCZZZGYZEZI, HNXUMQZYUXF?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x2D63B30", Offset = "0x2D62730", VA = "0x182D63B30")]
			private MockCV2DynamicNetSys(HashSet<Id32<JCZZZGYZEZI>> authorityOf, [In] SOAId32Field<DYGAYOUURZQ, MockCV2SyncField> syncFields, Dictionary<Id32<DYGAYOUURZQ>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<DYGAYOUURZQ>> mockSyncFieldToSyncField, [In] SOAField<JCZZZGYZEZI, HNXUMQZYUXF?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x2D63970", Offset = "0x2D62570", VA = "0x182D63970")]
			public static MockCV2DynamicNetSys New()
			{
				return default(MockCV2DynamicNetSys);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private struct MockCV2ObjectShared
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Id32<NAXUEJSETKJ>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x2D63BD0", Offset = "0x2D627D0", VA = "0x182D63BD0")]
			public MockCV2ObjectShared(Id32<NAXUEJSETKJ> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public HPXOTNIQIPU SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public QVVEGMKXHXU SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			internal MockCV2SyncField(HPXOTNIQIPU syncField, QVVEGMKXHXU syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2D63CF0", Offset = "0x2D628F0", VA = "0x182D63CF0")]
			public static MockCV2SyncField New(HPXOTNIQIPU syncField, QVVEGMKXHXU syncFieldChangeHandler)
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
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public object Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public int Uses;

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2D63CA0", Offset = "0x2D628A0", VA = "0x182D63CA0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x2D63C50", Offset = "0x2D62850", VA = "0x182D63C50")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private SOAId32Field<JCZZZGYZEZI, MockCV2ObjectShared> KUMKPAJOIVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<JCZZZGYZEZI>> COWQJNAVFQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> YLEPTZPARQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> SDSVMRGGAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAField<NAXUEJSETKJ, MockCV2DynamicNetSys> KWQXGEGXPZM;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<JCZZZGYZEZI>? DRTIYXRMXDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x1344320", Offset = "0x1342F20", VA = "0x181344320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2D68610", Offset = "0x2D67210", VA = "0x182D68610")]
		public void Destroy([In] SOAId32<NAXUEJSETKJ> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2D681B0", Offset = "0x2D66DB0", VA = "0x182D681B0")]
		public void CKRYHQCERMP(Id32<NAXUEJSETKJ> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2D68950", Offset = "0x2D67550", VA = "0x182D68950")]
		public void ITQBPFLWDGF(Id32<NAXUEJSETKJ> clientId, Id32<NAXUEJSETKJ>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2D69000", Offset = "0x2D67C00", VA = "0x182D69000")]
		public Id32<JCZZZGYZEZI> KLBAFAAOCCP(Id32<NAXUEJSETKJ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<NAXUEJSETKJ> clientIds)
		{
			return default(Id32<JCZZZGYZEZI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2D69870", Offset = "0x2D68470", VA = "0x182D69870")]
		public Id32<DYGAYOUURZQ> UIPCARLSUNP(Id32<NAXUEJSETKJ> clientId, string a, object b, QVVEGMKXHXU c, HPXOTNIQIPU d)
		{
			return default(Id32<DYGAYOUURZQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2D69AD0", Offset = "0x2D686D0", VA = "0x182D69AD0")]
		public void XONZEUNQGOL(Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2D69C60", Offset = "0x2D68860", VA = "0x182D69C60")]
		public Id32<JCZZZGYZEZI>? YHCBBESVXBQ([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x2D697F0", Offset = "0x2D683F0", VA = "0x182D697F0")]
		public void UHGZUXXNTIU([In] SOAId32<NAXUEJSETKJ> clientIds, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2D69530", Offset = "0x2D68130", VA = "0x182D69530")]
		public void TDUSJHRSNIG(Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x2D68850", Offset = "0x2D67450", VA = "0x182D68850")]
		public void HVKDPAMLJUY(Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x2D69670", Offset = "0x2D68270", VA = "0x182D69670")]
		public void UDGDBGPKQQG([In] SOAId32<NAXUEJSETKJ> clientIds, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x2D69410", Offset = "0x2D68010", VA = "0x182D69410")]
		public void LNXSUKGFGXW(Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, HNXUMQZYUXF? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x2D694E0", Offset = "0x2D680E0", VA = "0x182D694E0")]
		public Id32<NAXUEJSETKJ>? QXGWVINWTMT(Id32<JCZZZGYZEZI> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2D68C90", Offset = "0x2D67890", VA = "0x182D68C90")]
		public void JCOZDKUZOMP([In] SOAId32<NAXUEJSETKJ> clientIds, Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x2D69D30", Offset = "0x2D68930", VA = "0x182D69D30")]
		public YHIGBDAQIBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class FCADMOGITSQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2D62710", Offset = "0x2D61310", VA = "0x182D62710")]
		public static void Destroy(this YHIGBDAQIBP.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class YDKZULVCEPM : VKYPFXPEYWW.ZWBQGEKCHWS
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static YDKZULVCEPM ACQSDEGTZFZ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate MZSBEJLUTBY
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate KAWVEGNEHWB
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public YDKZULVCEPM(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class PNGBXTCDDKS : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : CKZYRSCPJVN.CSUFSUEQYQE<FJCTCRTIJZZ, PNGBXTCDDKS>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public PNGBXTCDDKS root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public Id32<NAXUEJSETKJ> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public FJCTCRTIJZZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600075C")]
				[Cpp2IlInjected.Address(RVA = "0x2D66AA0", Offset = "0x2D656A0", VA = "0x182D66AA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600075D")]
				[Cpp2IlInjected.Address(RVA = "0x2D66CE0", Offset = "0x2D658E0", VA = "0x182D66CE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
			public int EVEAETAQEGW(PNGBXTCDDKS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x2D64910", Offset = "0x2D63510", VA = "0x182D64910", Slot = "5")]
			public int MQAMUWJMKPE(PNGBXTCDDKS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x2D648F0", Offset = "0x2D634F0", VA = "0x182D648F0", Slot = "6")]
			public int FOTZMWPLMIN(PNGBXTCDDKS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xFDAFB0", Offset = "0xFD9BB0", VA = "0x180FDAFB0", Slot = "7")]
			public int FLXODIRSMIZ(PNGBXTCDDKS a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x2D64A80", Offset = "0x2D63680", VA = "0x182D64A80", Slot = "8")]
			public void ZUHSUOIBOVK(PNGBXTCDDKS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			public bool OWYSWTKXADL(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> actorId, FJCTCRTIJZZ[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "10")]
			public bool YDIRSQIOCRR(PNGBXTCDDKS a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2D64930", Offset = "0x2D63530", VA = "0x182D64930", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> senderId, FJCTCRTIJZZ b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : CKZYRSCPJVN.MQBQDZFUSGT<ActionDeps, QBUZPCMMQEU.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps UCLDKFGCKUV
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public QBUZPCMMQEU.StaticNetSysReceiverDeps RXVTFWJVISK
			{
				[Cpp2IlInjected.Token(Token = "0x600075F")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "5")]
				get
				{
					return default(QBUZPCMMQEU.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps VCRSLRIZTTN
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : MXOPUYEECLP.MQMDYMTPLDL<PNGBXTCDDKS>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public PNGBXTCDDKS root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public Id32<NAXUEJSETKJ> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public FJCTCRTIJZZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000762")]
				[Cpp2IlInjected.Address(RVA = "0x2D66780", Offset = "0x2D65380", VA = "0x182D66780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000763")]
				[Cpp2IlInjected.Address(RVA = "0x2D66A30", Offset = "0x2D65630", VA = "0x182D66A30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2D63D30", Offset = "0x2D62930", VA = "0x182D63D30", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, JGXPLWKAZER>> UNCASKUFXTN(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, FJCTCRTIJZZ b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : TDCKFGWTXZP.MQMDYMTPLDL<PNGBXTCDDKS>
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x2D633B0", Offset = "0x2D61FB0", VA = "0x182D633B0", Slot = "4")]
			public void ITQBPFLWDGF(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xFDB3C0", Offset = "0xFD9FC0", VA = "0x180FDB3C0", Slot = "5")]
			public Id32<NAXUEJSETKJ>? VSQGTSVXBHE(PNGBXTCDDKS a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0x2D63310", Offset = "0x2D61F10", VA = "0x182D63310")]
			public Id32<JCZZZGYZEZI> KLBAFAAOCCP(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<JCZZZGYZEZI>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x2D636E0", Offset = "0x2D622E0", VA = "0x182D636E0", Slot = "7")]
			public void UHGZUXXNTIU(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x2D63550", Offset = "0x2D62150", VA = "0x182D63550", Slot = "8")]
			public void TDUSJHRSNIG(PNGBXTCDDKS a, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x2D63370", Offset = "0x2D61F70", VA = "0x182D63370", Slot = "9")]
			public void HVKDPAMLJUY(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x2D636B0", Offset = "0x2D622B0", VA = "0x182D636B0", Slot = "10")]
			public void UDGDBGPKQQG(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, LWCFQVZRHOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x2D63410", Offset = "0x2D62010", VA = "0x182D63410", Slot = "11")]
			public void LNXSUKGFGXW(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<JCZZZGYZEZI> objectId, HNXUMQZYUXF? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x2D634F0", Offset = "0x2D620F0", VA = "0x182D634F0", Slot = "12")]
			public Id32<NAXUEJSETKJ>? QXGWVINWTMT(PNGBXTCDDKS a, Id32<JCZZZGYZEZI> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x2D63770", Offset = "0x2D62370", VA = "0x182D63770", Slot = "13")]
			public Id32<DYGAYOUURZQ> UIPCARLSUNP(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, string b, object c, QVVEGMKXHXU d, HPXOTNIQIPU e)
			{
				return default(Id32<DYGAYOUURZQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2D637D0", Offset = "0x2D623D0", VA = "0x182D637D0", Slot = "14")]
			public void XONZEUNQGOL(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2D633E0", Offset = "0x2D61FE0", VA = "0x182D633E0", Slot = "15")]
			public void JCOZDKUZOMP(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> clientId, Id32<DYGAYOUURZQ> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2D63310", Offset = "0x2D61F10", VA = "0x182D63310", Slot = "6")]
			private Id32<JCZZZGYZEZI> CSDGEFUFHGZ(PNGBXTCDDKS a, Id32<NAXUEJSETKJ> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<JCZZZGYZEZI>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private struct <RetainClient>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public PNGBXTCDDKS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public Id32<JCZZZGYZEZI>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public HJGLKQKSWYJ deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Registry registry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E08")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<NAXUEJSETKJ> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private HVKVUJZXNUD<PNGBXTCDDKS, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E18")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private CGOWFXVOVPF<PNGBXTCDDKS, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E20")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private QBUZPCMMQEU <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E28")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2D660D0", Offset = "0x2D64CD0", VA = "0x182D660D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2D66710", Offset = "0x2D65310", VA = "0x182D66710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly BMSWPZSAWWN<FJCTCRTIJZZ, None, QBUZPCMMQEU, ActionDeps, QBUZPCMMQEU.StaticNetSysReceiverDeps, RootDeps, PNGBXTCDDKS, Deps> QZBWGXHCPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly YHIGBDAQIBP TKXWEVUEOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private SOAId32<NAXUEJSETKJ> SSTZTQHSSMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAField<NAXUEJSETKJ, None> KWQXGEGXPZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<NAXUEJSETKJ, QBUZPCMMQEU> KGDIWNSDZDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Id32<NAXUEJSETKJ>? NPYYBHSROQD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate ACFUCZYVEVR
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2D64590", Offset = "0x2D63190", VA = "0x182D64590")]
		public PNGBXTCDDKS(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2D64050", Offset = "0x2D62C50", VA = "0x182D64050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2D63E90", Offset = "0x2D62A90", VA = "0x182D63E90")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> CKRYHQCERMP(HJGLKQKSWYJ a, Registry b, RegistryV2 c, Id32<JCZZZGYZEZI>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D64220", Offset = "0x2D62E20", VA = "0x182D64220")]
		private void ITQBPFLWDGF(Id32<NAXUEJSETKJ> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2D644B0", Offset = "0x2D630B0", VA = "0x182D644B0")]
		[CompilerGenerated]
		private Id32<JCZZZGYZEZI>? WIPJIBJQRYB([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class IIQHFVXASPB : IYSCTJMEFHV.ZWBQGEKCHWS
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<RCCZIPRQHLG> DeserializeCircuitsJunctionAsyncDelegate(QBUZPCMMQEU circuitsManager, RootData evRoomData, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public delegate void LifecycleDidInitializeDelegate();

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		public delegate void LifecycleWillDestroyDelegate();

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private struct <DeserializeCircuitsJunctionAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public AsyncTaskMethodBuilder<RCCZIPRQHLG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public IIQHFVXASPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public QBUZPCMMQEU circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public RootData evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private TaskAwaiter<RCCZIPRQHLG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2D64DB0", Offset = "0x2D639B0", VA = "0x182D64DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x2D64FC0", Offset = "0x2D63BC0", VA = "0x182D64FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate LNEEBPIGFCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? PXAZMJARJRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? WOCUADGHUKP;

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2D62820", Offset = "0x2D61420", VA = "0x182D62820", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeCircuitsJunctionAsync>d__2))]
		public Task<RCCZIPRQHLG> BKMTNDKJWWM(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x1057A70", Offset = "0x1056670", VA = "0x181057A70", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x118ABC0", Offset = "0x11897C0", VA = "0x18118ABC0", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2D629A0", Offset = "0x2D615A0", VA = "0x182D629A0")]
		public IIQHFVXASPB([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class CSNLAHZSEAD : QGHELZNSXBF.ZWBQGEKCHWS
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate QDGIPSGLXID GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<CHEUGVJIRCB> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<VMMHASWVFTD> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<QGHELZNSXBF.ZWBQGEKCHWS.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate Task<StaticCircuitsConfig> GetStaticCircuitsConfigAsyncDelegate(CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private struct <GetCircuitGraphToolMappingAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AsyncTaskMethodBuilder<QGHELZNSXBF.ZWBQGEKCHWS.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private TaskAwaiter<QGHELZNSXBF.ZWBQGEKCHWS.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2D65030", Offset = "0x2D63C30", VA = "0x182D65030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2D65220", Offset = "0x2D63E20", VA = "0x182D65220", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public AsyncTaskMethodBuilder<VMMHASWVFTD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			private TaskAwaiter<VMMHASWVFTD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2D65290", Offset = "0x2D63E90", VA = "0x182D65290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2D65480", Offset = "0x2D64080", VA = "0x182D65480", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AsyncTaskMethodBuilder<CHEUGVJIRCB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			private TaskAwaiter<CHEUGVJIRCB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D654F0", Offset = "0x2D640F0", VA = "0x182D654F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2D656E0", Offset = "0x2D642E0", VA = "0x182D656E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public AsyncTaskMethodBuilder<CircuitRootData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2D65750", Offset = "0x2D64350", VA = "0x182D65750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2D65940", Offset = "0x2D64540", VA = "0x182D65940", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AsyncTaskMethodBuilder<StaticCircuitsConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2D659B0", Offset = "0x2D645B0", VA = "0x182D659B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2D65BA0", Offset = "0x2D647A0", VA = "0x182D65BA0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public AsyncTaskMethodBuilder<SuperRoomData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CSNLAHZSEAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D65C10", Offset = "0x2D64810", VA = "0x182D65C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2D65E00", Offset = "0x2D64A00", VA = "0x182D65E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetCV2DependenciesDelegate QQYLJFKXIYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomDataAsyncDelegate RDBSLWYNDQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetSuperRoomDataAsyncDelegate JBWQBUWTNBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetRoomAssetDataAsyncDelegate XIDGAMFZGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetPlayerSaveDataAsyncDelegate TOEMGSTIFBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate WOJSFBXFSEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetStaticCircuitsConfigAsyncDelegate VRFQFSNTAIV;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public QDGIPSGLXID QDGIPSGLXID
		{
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x13533E0", Offset = "0x1351FE0", VA = "0x1813533E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2D61870", Offset = "0x2D60470", VA = "0x182D61870", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> PCSAGAVORGM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2D61540", Offset = "0x2D60140", VA = "0x182D61540", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> DBGJUNNFCJJ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2D61A90", Offset = "0x2D60690", VA = "0x182D61A90", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<CHEUGVJIRCB> XGUIWAWDYMM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2D61980", Offset = "0x2D60580", VA = "0x182D61980", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<VMMHASWVFTD> SKUPCDKWKYV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2D61650", Offset = "0x2D60250", VA = "0x182D61650", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<QGHELZNSXBF.ZWBQGEKCHWS.CircuitGraphToolMapping> ECIDWSIVOUS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2D61760", Offset = "0x2D60360", VA = "0x182D61760", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> OJVIESBXCZX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2D61BA0", Offset = "0x2D607A0", VA = "0x182D61BA0")]
		public CSNLAHZSEAD(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class MWRHJVWSNEH : CV2Request.ZWBQGEKCHWS
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly CV2Request.ZWBQGEKCHWS CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly GetCanSendRequestsDelegate YFJUWFHHNGT;

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public MWRHJVWSNEH(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x13533E0", Offset = "0x1351FE0", VA = "0x1813533E0", Slot = "4")]
		public bool XZTOMLILFTR()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class EKXXSVCAKDW : HQZRPDRLYMD
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, GOLLTPPMOJR> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly TryReportErrToUserDelegate DYZAQFBSKQZ;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70")]
		public bool SXTVIADDXIF([In] Result<None, GOLLTPPMOJR> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D62550", Offset = "0x2D61150", VA = "0x182D62550")]
		public EKXXSVCAKDW([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70", Slot = "4")]
		private bool ODHIGPOMTTE([In] Result<None, GOLLTPPMOJR> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class JRSZSJJPFXP : SIAQCCPWYWO
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate EBUYLMQOMBA CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly JRSZSJJPFXP CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly CurrentExecParamsDelegate? YMXYPUJQFCX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public EBUYLMQOMBA CANTJJXMVKN
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x13533E0", Offset = "0x1351FE0", VA = "0x1813533E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public JRSZSJJPFXP([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class CCJZQRGQQQZ : LPPYWEGICFS
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly LPPYWEGICFS CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly GetGameColorFromIdDelegate BSLOCERMXHX;

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70", Slot = "4")]
		public CircuitsColor MYBJKXOLEQF(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D61390", Offset = "0x2D5FF90", VA = "0x182D61390")]
		public CCJZQRGQQQZ([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class LHTMYXMQOAR : HQZHXJLGZCY
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public delegate Task<bool> IsStringPureAsyncDelegate(string value, string context);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private struct <IsStringPureAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public LHTMYXMQOAR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2D65E70", Offset = "0x2D64A70", VA = "0x182D65E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x2D66060", Offset = "0x2D64C60", VA = "0x182D66060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly IsStringPureAsyncDelegate RRWOKOKDRHO;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D62E40", Offset = "0x2D61A40", VA = "0x182D62E40", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> VCNVGRVBWIS(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D62F80", Offset = "0x2D61B80", VA = "0x182D62F80")]
		public LHTMYXMQOAR([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class AFBKHRJQSCT : ZWOKKWUVOWC
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate DVSTOKFWFDA? GetNodeVisualizationConfigDelegate([In] Id128<EPXTWKGOJAA> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly ZWOKKWUVOWC CFGULCWBBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly GetNodeVisualizationConfigDelegate SSKXJCMQANJ;

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70")]
		public DVSTOKFWFDA? EGVDGHBJMMD([In] Id128<EPXTWKGOJAA> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D60F10", Offset = "0x2D5FB10", VA = "0x182D60F10")]
		public AFBKHRJQSCT([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D60E70", Offset = "0x2D5FA70", VA = "0x182D60E70", Slot = "4")]
		private DVSTOKFWFDA UATFKZTOYTP([In] Id128<EPXTWKGOJAA> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class LXYQTKIAGPU : EZLAWBCIVGN
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D63140", Offset = "0x2D61D40", VA = "0x182D63140", Slot = "4")]
		public LRJJIFRHSNA QLXMWVPLEQC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LXYQTKIAGPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class XUEERIDNNXQ : JUZDWRULVVJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, bool> GLVKCTQBZLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, float> QGNMHFOEADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, double> ZIXGOJPDSJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, int> JSAKAECSRCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, long> CMOYWAEWOCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, string> VBTPZSUAXMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, uint> DBJTAQQQJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, ulong> XAQHWIOORWA;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D67D90", Offset = "0x2D66990", VA = "0x182D67D90", Slot = "4")]
		public bool? ITSGGLEAJPJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D67E30", Offset = "0x2D66A30", VA = "0x182D67E30")]
		public XUEERIDNNXQ()
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
