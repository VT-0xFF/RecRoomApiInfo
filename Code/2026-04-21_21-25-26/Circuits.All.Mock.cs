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
		[Cpp2IlInjected.Address(RVA = "0x2B39C80", Offset = "0x2B38680", VA = "0x182B39C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		internal sealed class VFEYXCQMADV : KWTALZZMCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public VFEYXCQMADV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "4")]
			public KWTALZZMCKC KVYTGOXKNOE(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "5")]
			public KWTALZZMCKC TMXFMLRQCOD(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "6")]
			public KWTALZZMCKC NZEGBPPLYCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			public void YTMSCNEQASK()
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
	public static class YOOCNXTONSS
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FUIFISZXLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public LABJXPUMTYX BWYAAGRKBEE;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FUIFISZXLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2B32290", Offset = "0x2B30C90", VA = "0x182B32290")]
			internal NGVEIXANPDZ FZWRAEBWWGT(GetNetworkObjectDelegate a)
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
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ZIWGSIEKNOO network;

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
			[Cpp2IlInjected.Address(RVA = "0x2B3A790", Offset = "0x2B39190", VA = "0x182B3A790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AE30", Offset = "0x2B39830", VA = "0x182B3AE30", Slot = "5")]
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
			public ZIWGSIEKNOO network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<KXSFMFRUWWC>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private LLXPXHNGEHC <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B3AEA0", Offset = "0x2B398A0", VA = "0x182B3AEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B430", Offset = "0x2B39E30", VA = "0x182B3B430", Slot = "5")]
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
			public LABJXPUMTYX roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B4A0", Offset = "0x2B39EA0", VA = "0x182B3B4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2B3B9B0", Offset = "0x2B3A3B0", VA = "0x182B3B9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FA60", Offset = "0x2B3E460", VA = "0x182B3FA60")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? DIKGYKFQCZD([Optional] LABJXPUMTYX? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FB50", Offset = "0x2B3E550", VA = "0x182B3FB50")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> PXODKZYOGIK(ZIWGSIEKNOO a, [Optional] ADMWIPYDBOF? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FCD0", Offset = "0x2B3E6D0", VA = "0x182B3FCD0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> PXODKZYOGIK(ZIWGSIEKNOO a, ADMWIPYDBOF b, RegistryV2 c, Id32<KXSFMFRUWWC>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FF60", Offset = "0x2B3E960", VA = "0x182B3FF60")]
		public static (RuntimeFnRegistry, RuntimeFns) SGKOIEENKHW()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FE60", Offset = "0x2B3E860", VA = "0x182B3FE60")]
		public static (ExternalFnRegistry, ExternalFns) RQRMRRTGMEF()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B40030", Offset = "0x2B3EA30", VA = "0x182B40030")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static ZIWGSIEKNOO XQLIWXRTPXQ(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class BEYBKYVQXJA
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate NGVEIXANPDZ CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public BEYBKYVQXJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A3A0", Offset = "0x2B38DA0", VA = "0x182B3A3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A720", Offset = "0x2B39120", VA = "0x182B3A720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ZIWGSIEKNOO CBVFEPFPNZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? MMEHMAWSOLS;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		private BEYBKYVQXJA(ZIWGSIEKNOO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B30190", Offset = "0x2B2EB90", VA = "0x182B30190")]
		public static BEYBKYVQXJA AZAFAXRXEYK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B30240", Offset = "0x2B2EC40", VA = "0x182B30240")]
		public BEYBKYVQXJA QNGYPNUHMYH(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B30260", Offset = "0x2B2EC60", VA = "0x182B30260")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> YTMSCNEQASK()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class VJSXTGLXMZO : LLXPXHNGEHC.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate MVPDPCIQCZK NewCircuitsLifecycleDelegate(CCKWHATKPBN.VAEKADQIRNQ deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(LLXPXHNGEHC circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(LLXPXHNGEHC circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate ZQGHWRCZSAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate CMJEQNQBLZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate CJCOGYRCIXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate JYCLMFBKRVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate MEJTFIIEBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate KQMYVOUZBXT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ZGVCEPKXULJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12DA5F0", Offset = "0x12D8FF0", VA = "0x1812DA5F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CB00", Offset = "0x2B3B500", VA = "0x182B3CB00", Slot = "6")]
		public void BSVAKVESYQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CB60", Offset = "0x2B3B560", VA = "0x182B3CB60", Slot = "7")]
		public void ZMWKOQLICTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CB30", Offset = "0x2B3B530", VA = "0x182B3CB30", Slot = "5")]
		public MVPDPCIQCZK JYDVFJKURUD(CCKWHATKPBN.VAEKADQIRNQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF36000", Offset = "0xF34A00", VA = "0x180F36000", Slot = "8")]
		public void NLIDBWXTTVK(LLXPXHNGEHC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF36030", Offset = "0xF34A30", VA = "0x180F36030", Slot = "9")]
		public void KHNWMNPHRQR(LLXPXHNGEHC a, JGWKKBUFZYH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CB90", Offset = "0x2B3B590", VA = "0x182B3CB90")]
		public VJSXTGLXMZO([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly OHLNKQHDPWD<ZIWGSIEKNOO, ZIWGSIEKNOO.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly HADKPPFWQVZ<ZIWGSIEKNOO, ZIWGSIEKNOO.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly LLXPXHNGEHC CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<QOLQCAXXJSV> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly ZIWGSIEKNOO Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B321A0", Offset = "0x2B30BA0", VA = "0x182B321A0")]
		public EVCreationResult(OHLNKQHDPWD<ZIWGSIEKNOO, ZIWGSIEKNOO.MockStaticNetSysDeps> staticNetSys, HADKPPFWQVZ<ZIWGSIEKNOO, ZIWGSIEKNOO.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, LLXPXHNGEHC circuitsManager, Id32<QOLQCAXXJSV> clientId, ZIWGSIEKNOO network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly LLXPXHNGEHC _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 SHXKCJUNVKK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2B35550", Offset = "0x2B33F50", VA = "0x182B35550")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request VXFKWVSXXWO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2B35580", Offset = "0x2B33F80", VA = "0x182B35580")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KQGIQGHQWFJ? HERUJKSIDRU
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2B35450", Offset = "0x2B33E50", VA = "0x182B35450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public JOTUAXHHOSV? FWCMWMNGSOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2B355B0", Offset = "0x2B33FB0", VA = "0x182B355B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		internal LimitedCircuits(LLXPXHNGEHC circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class LWEUCNDUTTQ : ADMWIPYDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class CFKCLVFDGAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public NGVEIXANPDZ YZSUIAMLRPJ;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public CFKCLVFDGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			internal NGVEIXANPDZ DXQLJHTMCGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CCKWHATKPBN.VAEKADQIRNQ YMNHPYMKYKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LLXPXHNGEHC.VAEKADQIRNQ GVUJLRGXJNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public QMPJCTMUYTR.VAEKADQIRNQ LVRLWVTOYCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC> KCUMYMULKAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.VAEKADQIRNQ ZGPDNETMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public XXFEIMFXUFV POIJMWMPEWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UHFIXPZEGDI YHGIWREOJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public VILOZUKICQY VEAWHMVIPAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BFKKVPEWDDK FYKMOQQNFCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SULRVJJWMBY ZJJEOPUGPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B35360", Offset = "0x2B33D60", VA = "0x182B35360")]
		private LWEUCNDUTTQ(CCKWHATKPBN.VAEKADQIRNQ a, LLXPXHNGEHC.VAEKADQIRNQ b, QMPJCTMUYTR.VAEKADQIRNQ c, PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC> d, CV2Request.VAEKADQIRNQ e, XXFEIMFXUFV f, UHFIXPZEGDI g, VILOZUKICQY h, BFKKVPEWDDK i, SULRVJJWMBY j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2B34EB0", Offset = "0x2B338B0", VA = "0x182B34EB0")]
		public static LWEUCNDUTTQ? PQBZKLOOYRD(QMPJCTMUYTR.VAEKADQIRNQ cv2RootSysDeps, [Optional] CCKWHATKPBN.VAEKADQIRNQ? a, [Optional] LLXPXHNGEHC.VAEKADQIRNQ? b, [Optional] PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>? reducerDeps, [Optional] CV2Request.VAEKADQIRNQ? c, [Optional] XXFEIMFXUFV? d, [Optional] UHFIXPZEGDI? e, [Optional] VILOZUKICQY? f, [Optional] BFKKVPEWDDK? g, [Optional] SULRVJJWMBY? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B35210", Offset = "0x2B33C10", VA = "0x182B35210")]
		public static LWEUCNDUTTQ RTSKRPIWKED(NGVEIXANPDZ a, [Optional] CCKWHATKPBN.VAEKADQIRNQ? circuitsLifecycleDeps, [Optional] LLXPXHNGEHC.VAEKADQIRNQ? circuitsManagerDeps, [Optional] PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B34B30", Offset = "0x2B33530", VA = "0x182B34B30")]
		public static LWEUCNDUTTQ GTUWVVZILZR(GetNetworkObjectDelegate a, [Optional] CCKWHATKPBN.VAEKADQIRNQ? circuitsLifecycleDeps, [Optional] LLXPXHNGEHC.VAEKADQIRNQ? circuitsManagerDeps, [Optional] PPKJGVJKAIL.EXOUKTTMMZJ<ActionKind, JGWKKBUFZYH, LLXPXHNGEHC>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class NJDVXIGGWAP
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public GetNetworkObjectDelegate LTAKNUBMIGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int EHWSETKKZPJ;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B30070", Offset = "0x2B2EA70", VA = "0x182B30070")]
			internal XUIFPTGWGWM RHPJHOHQZSM(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FF10", Offset = "0x2B2E910", VA = "0x182B2FF10")]
			internal XUIFPTGWGWM[] RFTZGFKOSUJ(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			internal int GFJITKMJXON()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BBBPZVCGPLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public DynamicEnvironmentNetworkId HGKDKSRDNFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public BAWJCOIJFZS DODNVPQZHNM;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BBBPZVCGPLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x2B300E0", Offset = "0x2B2EAE0", VA = "0x182B300E0")]
			internal XUIFPTGWGWM MENHUECMSXW(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly XEQZGTZPMCK USMNYGULCPV;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B35610", Offset = "0x2B34010", VA = "0x182B35610")]
		public static XUIFPTGWGWM? ABPUNKXFNVJ(Id32<KXSFMFRUWWC>? networkObject, [Optional] BVYQPPGGXYP.SerializesIntoSavesDelegate? a, [Optional] BVYQPPGGXYP.SerializesIntoInventionsDelegate? b, [Optional] BVYQPPGGXYP.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B35630", Offset = "0x2B34030", VA = "0x182B35630")]
		public static NGVEIXANPDZ? RBVCSPVFFIK(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] DDEDPKRJVXM? b, [Optional] PWSVWEXBUOM? c, [Optional] EFDTPCKLAJY? d, [Optional] LABJXPUMTYX? e, int f = 300000, bool g = false, bool h = false, [Optional] XXZEYNQURCM? i, [Optional] TDJYSKBEZUY? j, [Optional] DVVQPGBJPED? k, [Optional] YZHTLTWFAJE? l, [Optional] SFKGPCNMOKX? m, [Optional] FHVGDCVDRXM? n, [Optional] GSDWEVUUWEW.VAEKADQIRNQ? o, [Optional] EqualsNodeV2.VAEKADQIRNQ? p, [Optional] RMNFFILVAMY? q, [Optional] NGVEIXANPDZ.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] NGVEIXANPDZ.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] NGVEIXANPDZ.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] NGVEIXANPDZ.GetLocalRoomIdDelegate? u, [Optional] NGVEIXANPDZ.GetLocalSubroomIdDelegate? v, [Optional] NGVEIXANPDZ.GetSubroomIdsForLocalRoomDelegate? w, [Optional] NGVEIXANPDZ.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] NGVEIXANPDZ.SaveRoomOnPlayerBehalfDelegate? z, [Optional] NGVEIXANPDZ.ReportCloudDataLedgerChangedDelegate? ba, [Optional] NGVEIXANPDZ.GetColorNameByIdDelegate? bb, [Optional] NGVEIXANPDZ.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] NGVEIXANPDZ.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] NGVEIXANPDZ.GetTaggableNameFromSignalDelegate? be, [Optional] NGVEIXANPDZ.GetAudioNameFromSignalDelegate? bf, [Optional] NGVEIXANPDZ.GetDestinationNameFromSignalDelegate? bg, [Optional] NGVEIXANPDZ.GetPlayerEventNameFromSignalDelegate? bh, [Optional] NGVEIXANPDZ.GetRoomKeyNameFromSignalDelegate? bi, [Optional] NGVEIXANPDZ.GetRewardNameFromSignalDelegate? bj, [Optional] NGVEIXANPDZ.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] NGVEIXANPDZ.ReportPreloadedAudioChangedDelegate? bl, [Optional] NGVEIXANPDZ.ReportRewardDataChangedDelegate? bm, [Optional] NGVEIXANPDZ.GetConsumableNameFromSignalDelegate? bn, [Optional] NGVEIXANPDZ.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] NGVEIXANPDZ.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] NGVEIXANPDZ.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] NGVEIXANPDZ.GetInventoryItemNameFromSignalDelegate? br, [Optional] NGVEIXANPDZ.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] NGVEIXANPDZ.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] NGVEIXANPDZ.GetRoomOfferNameFromSignalDelegate? bu, [Optional] NGVEIXANPDZ.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] NGVEIXANPDZ.GetObjectIdFromCreationObjectDelegate? bw, [Optional] NGVEIXANPDZ.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] NGVEIXANPDZ.GetCostInBytesDelegate? by, [Optional] NGVEIXANPDZ.GetAvatarItemNameFromSignalDelegate? bz, [Optional] NGVEIXANPDZ.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] NGVEIXANPDZ.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] NGVEIXANPDZ.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] NGVEIXANPDZ.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] NGVEIXANPDZ.GetStoreItemNameFromSignalDelegate? ce, [Optional] NGVEIXANPDZ.GetBodyPartNameFromSignalDelegate? cf, [Optional] NGVEIXANPDZ.GetDependenciesForGraphInstanceDelegate? cg, [Optional] NGVEIXANPDZ.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] NGVEIXANPDZ.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] NGVEIXANPDZ.GetRecNetImageNameFromSignalDelegate? cj, [Optional] NGVEIXANPDZ.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] NGVEIXANPDZ.IsFunctionValidForAIDelegate? cm, [Optional] NGVEIXANPDZ.GetAIFunctionNameFromSignalDelegate? cn, [Optional] NGVEIXANPDZ.FromSerializableObjectDelegate? co, [Optional] NGVEIXANPDZ.ToSerializableObjectDelegate? cp)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<KXSFMFRUWWC>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class LQKHFADHGSU : DVVQPGBJPED
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly LQKHFADHGSU GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly GetLocalPlayerDelegate? IUDMHSDCHTN;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B34A40", Offset = "0x2B33440", VA = "0x182B34A40", Slot = "4")]
		public (PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW) ZATLRIHTHFM(object a)
		{
			return default((PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW, PKRLFBOSBOW));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B34A10", Offset = "0x2B33410", VA = "0x182B34A10", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "6")]
		public bool FFOFFAGVGVT(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD75E20", Offset = "0xD74820", VA = "0x180D75E20", Slot = "7")]
		public string EZWGFCAVZCR(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public LQKHFADHGSU([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class BVYQPPGGXYP : XUIFPTGWGWM
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(BVYQPPGGXYP self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(BVYQPPGGXYP self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(BVYQPPGGXYP self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly SerializesIntoSavesDelegate VGPDCKVAEWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly SerializesIntoInventionsDelegate FCQDLJDVTTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly CanPublishInInventionsDelegate ASHVKXMHZTW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NHMGSARTNUY? KRCRFNHTVTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId QKVWMDFRJNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xFFBED0", Offset = "0xFFA8D0", VA = "0x180FFBED0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool UNMWGLBQSTY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2B30A70", Offset = "0x2B2F470", VA = "0x182B30A70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GTCZBIMIHZV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2B30A40", Offset = "0x2B2F440", VA = "0x182B30A40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool AOXHNXUSVMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2B30A10", Offset = "0x2B2F410", VA = "0x182B30A10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RYXFRFZJHPB? AUDEHXSVPDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<KXSFMFRUWWC>? RDDXJAUVQZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B308C0", Offset = "0x2B2F2C0", VA = "0x182B308C0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B30350", Offset = "0x2B2ED50", VA = "0x182B30350", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(XEQZGTZPMCK e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270", Slot = "13")]
		public void Bind(NHMGSARTNUY controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B30960", Offset = "0x2B2F360", VA = "0x182B30960")]
		private BVYQPPGGXYP(Id32<KXSFMFRUWWC>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B303F0", Offset = "0x2B2EDF0", VA = "0x182B303F0")]
		public static BVYQPPGGXYP? New(Id32<KXSFMFRUWWC>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class YKOYGSNTAFR : XXZEYNQURCM
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

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly YKOYGSNTAFR GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly RoundToDecimalPlaceDelegate? MJXJVGVGQGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly TruncateToDecimalPlaceDelegate? GSRBSIYRLYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsColorLerpDelegate? DNVBLRZVTZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsColorInverseLerpDelegate? MLJAIIQBOLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4GetPositionDelegate? TAOTDAKWMTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4GetRotationDelegate? PCXQQIOWHSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsMtx4x4InverseDelegate? GEVISFIVORA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsMtx4x4MultiplyDelegate? IUUYWSGPCHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? QHKQSDOEUEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatDotDelegate? ZFTEZOEIIYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromAngleAxisDelegate? ECRHARQCIQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? JZEZLRLVCBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatFromFromToRotationDelegate? LEHMGFCMOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatFromLookRotationDelegate? TPDNDNULEQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? MEDUMRCCWMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseDelegate? TUDZWNPXKYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatLerpDelegate? QHYMYMHERQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatLerpUnclampedDelegate? KSEBGLFFFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatInverseLerpDelegate? BSQYDZMVUOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatMultiplyDelegate? YDETOXLPSJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatNormalizeDelegate? NCTSQYRZAFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatRotateTowardsDelegate? TNSYAFBFMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatRotateVectorDelegate? XJVTVJWXUOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatSlerpDelegate? OWAEROXQBGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsQuatToAngleAxisDelegate? KGABATPSTHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsQuatToEulerAnglesDelegate? UDJYMUHLWQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3AddDelegate? ZQMVTSPVLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? WGLXJBDNWPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? KESXGHUANFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3CrossDelegate? XZNMSCCJWXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3DotDelegate? LVGFZFFPPMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3AngleDelegate? ETTEDUZFDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3GetMagnitudeDelegate? USPTEZUJLRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3LerpDelegate? XQDUIWJEAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3LerpUnclampedDelegate? CINYMAHPMRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3InverseLerpDelegate? LLQZQLPWOUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3MoveTowardsDelegate? BYKKREXYYLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3NegateDelegate? GXUZIUNQQRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3NormalizeDelegate? RZMDMXMSSJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ProjectDelegate? HWIGOQYMUQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? BFFJYDEHYQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3ScaleDelegate? SIGMLDGXVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SmoothDampDelegate? EHWGIQWTFUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3SubtractDelegate? YYIEIMZQZHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3SlerpDelegate? ADLNYMWFXEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CircuitsVec3TransformDelegate? NPHKWWLPAHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CircuitsVec3InverseTransformDelegate? MUZNKOUNQAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly RealtimeSinceStartupDelegate? SQSMACWQWWQ;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F580", Offset = "0x2B3DF80", VA = "0x182B3F580")]
		public YKOYGSNTAFR([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D740", Offset = "0x2B3C140", VA = "0x182B3D740")]
		public float BRDJJBGPBUE([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCB0", Offset = "0x2B3C6B0", VA = "0x182B3DCB0")]
		public float VGZZWOJXJDK([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F140", Offset = "0x2B3DB40", VA = "0x182B3F140")]
		public CircuitsColor XUUQROLCDMB([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCD0", Offset = "0x2B3C6D0", VA = "0x182B3DCD0")]
		public float OFFTSSDEEFH([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F050", Offset = "0x2B3DA50", VA = "0x182B3F050")]
		public CircuitsVec3 WZERXWQYSJF([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F000", Offset = "0x2B3DA00", VA = "0x182B3F000")]
		public CircuitsQuat WDNEJRQHJDY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EAB0", Offset = "0x2B3D4B0", VA = "0x182B3EAB0")]
		public CircuitsMtx4x4 RCWYWRATPUY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D6B0", Offset = "0x2B3C0B0", VA = "0x182B3D6B0")]
		public CircuitsMtx4x4 AZBMCSONKYY([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DFB0", Offset = "0x2B3C9B0", VA = "0x182B3DFB0")]
		public CircuitsMtx4x4 HUXOTNZUOGI([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA20", Offset = "0x2B3D420", VA = "0x182B3EA20")]
		public float XVZXYLDHZHX([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E970", Offset = "0x2B3D370", VA = "0x182B3E970")]
		public CircuitsQuat QPHLSKQDNPK(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D8E0", Offset = "0x2B3C2E0", VA = "0x182B3D8E0")]
		public CircuitsQuat JNAYOHEGESL([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E020", Offset = "0x2B3CA20", VA = "0x182B3E020")]
		public CircuitsQuat IGWIVAUSXNL([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DEA0", Offset = "0x2B3C8A0", VA = "0x182B3DEA0")]
		public CircuitsQuat HCWCSWJBFRB([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E1A0", Offset = "0x2B3CBA0", VA = "0x182B3E1A0")]
		public CircuitsQuat KAMOXVDPKAK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E8B0", Offset = "0x2B3D2B0", VA = "0x182B3E8B0")]
		public CircuitsQuat QLVHNJBDSUP([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB20", Offset = "0x2B3C520", VA = "0x182B3DB20")]
		public CircuitsQuat DZBHPDQLGEO([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D880", Offset = "0x2B3C280", VA = "0x182B3D880")]
		public float CIRHHLAYRXF([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E3E0", Offset = "0x2B3CDE0", VA = "0x182B3E3E0")]
		public CircuitsQuat QQXNXDFQHHA([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E5C0", Offset = "0x2B3CFC0", VA = "0x182B3E5C0")]
		public CircuitsQuat ONJSFXVMNDH([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D760", Offset = "0x2B3C160", VA = "0x182B3D760")]
		public CircuitsQuat BTVNMLLWUKH([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EC90", Offset = "0x2B3D690", VA = "0x182B3EC90")]
		public CircuitsVec3 RUDTHMNGEWS([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DA60", Offset = "0x2B3C460", VA = "0x182B3DA60")]
		public CircuitsQuat DPTZDQZEFTY([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E6D0", Offset = "0x2B3D0D0", VA = "0x182B3E6D0")]
		public void OWMBVUGVGTV([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E0D0", Offset = "0x2B3CAD0", VA = "0x182B3E0D0")]
		public CircuitsVec3 JBRMIJBTXDC([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ED00", Offset = "0x2B3D700", VA = "0x182B3ED00")]
		public CircuitsVec3 SAXIQPYXWQV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E7D0", Offset = "0x2B3D1D0", VA = "0x182B3E7D0")]
		public CircuitsVec3 QBKQSUENORT([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E710", Offset = "0x2B3D110", VA = "0x182B3E710")]
		public CircuitsVec3 OXJCLARGWRM([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D580", Offset = "0x2B3BF80", VA = "0x182B3D580")]
		public CircuitsVec3 AHTVEPLLVSW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD60", Offset = "0x2B3C760", VA = "0x182B3DD60")]
		public float GAOYJKUSCYV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F0B0", Offset = "0x2B3DAB0", VA = "0x182B3F0B0")]
		public float YJBMKTWXATH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EB20", Offset = "0x2B3D520", VA = "0x182B3EB20")]
		public float XBABRQDLSLO([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EF90", Offset = "0x2B3D990", VA = "0x182B3EF90")]
		public CircuitsVec3 WCKBPJPCUVZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F2E0", Offset = "0x2B3DCE0", VA = "0x182B3F2E0")]
		public CircuitsVec3 ZMIMNNTBFEO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D8B0", Offset = "0x2B3C2B0", VA = "0x182B3D8B0")]
		public float EFNSAALLXYH([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E240", Offset = "0x2B3CC40", VA = "0x182B3E240")]
		public CircuitsVec3 KBHGBCJBMIB([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD00", Offset = "0x2B3C700", VA = "0x182B3DD00")]
		public CircuitsVec3 FXWUXCWTSEI([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F210", Offset = "0x2B3DC10", VA = "0x182B3F210")]
		public CircuitsVec3 YVUONWKHHJP([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E130", Offset = "0x2B3CB30", VA = "0x182B3E130")]
		public CircuitsVec3 JTSFITYOPOP([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D980", Offset = "0x2B3C380", VA = "0x182B3D980")]
		public CircuitsVec3 CPOTSXUCADG([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EBB0", Offset = "0x2B3D5B0", VA = "0x182B3EBB0")]
		public CircuitsVec3 RGJRVRJTWSA([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD80", Offset = "0x2B3C780", VA = "0x182B3DD80")]
		public CircuitsVec3 GPQDHSCHOBA([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DC40", Offset = "0x2B3C640", VA = "0x182B3DC40")]
		public CircuitsVec3 FQSKCSOUZXI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA40", Offset = "0x2B3D440", VA = "0x182B3EA40")]
		public CircuitsVec3 RBIVHGUOTKW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EB40", Offset = "0x2B3D540", VA = "0x182B3EB40")]
		public CircuitsVec3 REKXCXDEZIK([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EF20", Offset = "0x2B3D920", VA = "0x182B3EF20")]
		public CircuitsVec3 UYIQYCCOIEG([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EE30", Offset = "0x2B3D830", VA = "0x182B3EE30", Slot = "50")]
		public Task THEQWNCNUVA(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "51")]
		public void VIHPERTIHSC([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E390", Offset = "0x2B3CD90", VA = "0x182B3E390", Slot = "52")]
		public FZTDTHLGFIN<SJTUWKSMSLH> MFPOXXWYTNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ED70", Offset = "0x2B3D770", VA = "0x182B3ED70", Slot = "53")]
		public FZTDTHLGFIN<SJTUWKSMSLH> SDUTGKJETGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D720", Offset = "0x2B3C120", VA = "0x182B3D720", Slot = "54")]
		public float BOYAVAADXIT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D740", Offset = "0x2B3C140", VA = "0x182B3D740", Slot = "4")]
		private float GGWWGOFYKXU([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCB0", Offset = "0x2B3C6B0", VA = "0x182B3DCB0", Slot = "5")]
		private float FQSLADBROVY([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F350", Offset = "0x2B3DD50", VA = "0x182B3F350", Slot = "6")]
		private CircuitsColor ZXSOZVGSWQD([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DCD0", Offset = "0x2B3C6D0", VA = "0x182B3DCD0", Slot = "7")]
		private float FTFOXZKDXRN([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D820", Offset = "0x2B3C220", VA = "0x182B3D820", Slot = "8")]
		private CircuitsVec3 BWBJHKHTPTD([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E780", Offset = "0x2B3D180", VA = "0x182B3E780", Slot = "9")]
		private CircuitsQuat PXTNBSYGBXO([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EE60", Offset = "0x2B3D860", VA = "0x182B3EE60", Slot = "10")]
		private CircuitsMtx4x4 TQYLNMLZMUO([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DBE0", Offset = "0x2B3C5E0", VA = "0x182B3DBE0", Slot = "11")]
		private CircuitsMtx4x4 EVXZOOUVMMW([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E500", Offset = "0x2B3CF00", VA = "0x182B3E500", Slot = "12")]
		private CircuitsMtx4x4 NQACTDHBZXU([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA20", Offset = "0x2B3D420", VA = "0x182B3EA20", Slot = "13")]
		private float QQTJDHVYLLV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E970", Offset = "0x2B3D370", VA = "0x182B3E970", Slot = "14")]
		private CircuitsQuat TMZPTIYQNYS(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D8E0", Offset = "0x2B3C2E0", VA = "0x182B3D8E0", Slot = "15")]
		private CircuitsQuat CLUERHGYOUV([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E020", Offset = "0x2B3CA20", VA = "0x182B3E020", Slot = "16")]
		private CircuitsQuat LSWUPFZUIIT([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DEA0", Offset = "0x2B3C8A0", VA = "0x182B3DEA0", Slot = "17")]
		private CircuitsQuat HDKIWNBEBMZ([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E1A0", Offset = "0x2B3CBA0", VA = "0x182B3E1A0", Slot = "18")]
		private CircuitsQuat OKMTNVRJGCQ([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E8B0", Offset = "0x2B3D2B0", VA = "0x182B3E8B0", Slot = "19")]
		private CircuitsQuat QGYCVWVROEJ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB20", Offset = "0x2B3C520", VA = "0x182B3DB20", Slot = "20")]
		private CircuitsQuat ESAZVBGOEOY([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D880", Offset = "0x2B3C280", VA = "0x182B3D880", Slot = "21")]
		private float JWZMYZBRIXP([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E3E0", Offset = "0x2B3CDE0", VA = "0x182B3E3E0", Slot = "22")]
		private CircuitsQuat MUZJMRCYQJO([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E5C0", Offset = "0x2B3CFC0", VA = "0x182B3E5C0", Slot = "23")]
		private CircuitsQuat ZLVPCFRSDIX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D760", Offset = "0x2B3C160", VA = "0x182B3D760", Slot = "24")]
		private CircuitsQuat MDSAFNCQSSJ([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EC20", Offset = "0x2B3D620", VA = "0x182B3EC20", Slot = "25")]
		private CircuitsVec3 RTHSUTRIMJK([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DA60", Offset = "0x2B3C460", VA = "0x182B3DA60", Slot = "26")]
		private CircuitsQuat KAFBSRUCPDK([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E6D0", Offset = "0x2B3D0D0", VA = "0x182B3E6D0", Slot = "27")]
		private void VMDAUDZFJVP([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DF50", Offset = "0x2B3C950", VA = "0x182B3DF50", Slot = "28")]
		private CircuitsVec3 HOCELVYKGPM([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E660", Offset = "0x2B3D060", VA = "0x182B3E660", Slot = "29")]
		private CircuitsVec3 ORJROFTBGTV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E840", Offset = "0x2B3D240", VA = "0x182B3E840", Slot = "30")]
		private CircuitsVec3 QDLLUHBLXZN([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D510", Offset = "0x2B3BF10", VA = "0x182B3D510", Slot = "31")]
		private CircuitsVec3 AHCMJWMAORG([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F270", Offset = "0x2B3DC70", VA = "0x182B3F270", Slot = "32")]
		private CircuitsVec3 YZRZZFWMYTK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D430", Offset = "0x2B3BE30", VA = "0x182B3D430", Slot = "33")]
		private CircuitsVec3 ABFYQUQDFFO([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E320", Offset = "0x2B3CD20", VA = "0x182B3E320", Slot = "34")]
		private CircuitsVec3 LVBTDLHZNZS([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DD60", Offset = "0x2B3C760", VA = "0x182B3DD60", Slot = "35")]
		private float HRFKUPRTODZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F0B0", Offset = "0x2B3DAB0", VA = "0x182B3F0B0", Slot = "36")]
		private float XAOOTQTNLOT([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EB20", Offset = "0x2B3D520", VA = "0x182B3EB20", Slot = "37")]
		private float RDLFNOAWPHI([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DE30", Offset = "0x2B3C830", VA = "0x182B3DE30", Slot = "38")]
		private CircuitsVec3 GZNEQDXJPGZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E2B0", Offset = "0x2B3CCB0", VA = "0x182B3E2B0", Slot = "39")]
		private CircuitsVec3 LFMVGZLGQJC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D8B0", Offset = "0x2B3C2B0", VA = "0x182B3D8B0", Slot = "40")]
		private float CISXREMZIZD([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D9F0", Offset = "0x2B3C3F0", VA = "0x182B3D9F0", Slot = "41")]
		private CircuitsVec3 DFRZWSGOMOT([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E560", Offset = "0x2B3CF60", VA = "0x182B3E560", Slot = "42")]
		private CircuitsVec3 NXQTAWNLUJY([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EEC0", Offset = "0x2B3D8C0", VA = "0x182B3EEC0", Slot = "43")]
		private CircuitsVec3 UQXJDTIFPTJ([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D4A0", Offset = "0x2B3BEA0", VA = "0x182B3D4A0", Slot = "44")]
		private CircuitsVec3 AEHZCEPICMF([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F1A0", Offset = "0x2B3DBA0", VA = "0x182B3F1A0", Slot = "45")]
		private CircuitsVec3 YONDHVJBJWK([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F0D0", Offset = "0x2B3DAD0", VA = "0x182B3F0D0", Slot = "46")]
		private CircuitsVec3 XLYANJYBNSC([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D5F0", Offset = "0x2B3BFF0", VA = "0x182B3D5F0", Slot = "47")]
		private CircuitsVec3 AHZFJDUQYWU([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E490", Offset = "0x2B3CE90", VA = "0x182B3E490", Slot = "48")]
		private CircuitsVec3 NELTNKVCNMA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EDC0", Offset = "0x2B3D7C0", VA = "0x182B3EDC0", Slot = "49")]
		private CircuitsVec3 SFMHVUNPQNC([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class KEQHXTDLMKL : ZEZQRTUNDKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x137E3F0", Offset = "0x137CDF0", VA = "0x18137E3F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool StopEventExecutionAfterSingleFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x113A7F0", Offset = "0x11391F0", VA = "0x18113A7F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B30", Offset = "0x2B31530", VA = "0x182B32B30")]
		public KEQHXTDLMKL(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class ZJNHMXYWAOD : TDJYSKBEZUY
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(BHTKLEBSRSX e, YCMCVDRHXQG invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly ZJNHMXYWAOD GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly GetCircuitsColorFromColorIndexDelegate? UEUYLVLMETS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? CDCIAJNGIXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly InvisibleCollisionSetEnabledDelegate? YHOMSQTYPLD;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xE078A0", Offset = "0xE062A0", VA = "0x180E078A0")]
		public ZJNHMXYWAOD([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2B400D0", Offset = "0x2B3EAD0", VA = "0x182B400D0", Slot = "4")]
		public CircuitsColor WMHLWHDVJSP(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B400B0", Offset = "0x2B3EAB0", VA = "0x182B400B0")]
		public int VQAHGEIWWXD([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2B400B0", Offset = "0x2B3EAB0", VA = "0x182B400B0", Slot = "5")]
		private int KKKHOIWFHWS([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ETWYZOKWPGS : NBTXVMDREKH
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class EYDCYYJVIGL
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid BLVFIYLFPBN
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long PPQTCLEGSUM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int IRBBPXNSSTM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool ORIDITOUDRJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x1B417C0", Offset = "0x1B401C0", VA = "0x181B417C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool COSWAVQIMPP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x1B417B0", Offset = "0x1B401B0", VA = "0x181B417B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool RXCCWHLYVJI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x2B32210", Offset = "0x2B30C10", VA = "0x182B32210")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B32230", Offset = "0x2B30C30", VA = "0x182B32230")]
			public EYDCYYJVIGL(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<Id128<MVBOYPURKWM>, EYDCYYJVIGL> GQIETIMLRFE;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D70", Offset = "0x2B30770", VA = "0x182B31D70")]
		public bool AQWHATXCDLJ([In] Id128<MVBOYPURKWM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E80", Offset = "0x2B30880", VA = "0x182B31E80")]
		public void IMRYNLAJCHB([In] Id128<MVBOYPURKWM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2B31F50", Offset = "0x2B30950", VA = "0x182B31F50")]
		public void IMRYNLAJCHB([In] Id128<MVBOYPURKWM> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C50", Offset = "0x2B30650", VA = "0x182B31C50")]
		public void OYIISZVJSSK([In] Id128<MVBOYPURKWM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2B320C0", Offset = "0x2B30AC0", VA = "0x182B320C0")]
		public void VHTTONEYWWB([In] Id128<MVBOYPURKWM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B32030", Offset = "0x2B30A30", VA = "0x182B32030")]
		public bool ORIDITOUDRJ([In] Id128<MVBOYPURKWM> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2B32120", Offset = "0x2B30B20", VA = "0x182B32120")]
		public ETWYZOKWPGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2B31D70", Offset = "0x2B30770", VA = "0x182B31D70", Slot = "4")]
		private bool MBJGPWPPEBO([In] Id128<MVBOYPURKWM> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2B31E80", Offset = "0x2B30880", VA = "0x182B31E80", Slot = "5")]
		private void DSSPNSNXACQ([In] Id128<MVBOYPURKWM> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2B31C50", Offset = "0x2B30650", VA = "0x182B31C50", Slot = "6")]
		private void AIITSYZPOCZ([In] Id128<MVBOYPURKWM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2B320C0", Offset = "0x2B30AC0", VA = "0x182B320C0", Slot = "7")]
		private void ZHMUDHHSWTA([In] Id128<MVBOYPURKWM> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2B32030", Offset = "0x2B30A30", VA = "0x182B32030", Slot = "8")]
		private bool VIWGUJWCJXE([In] Id128<MVBOYPURKWM> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class TAPUWNEJINL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B39E60", Offset = "0x2B38860", VA = "0x182B39E60")]
		public static LogDeps XHLQFIRENEG()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class GITCBKWPAYY : MeshLibrary.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
		public byte[]? JDBCAGIPEDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
		public void OSAVSDVCGWU(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GITCBKWPAYY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class LBXHITMZCYD : DDEDPKRJVXM
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
		public delegate void ConfigureAttachedObjectDelegate(LYKEDRYMWQY controlPanel, RCFAQTSGIYC staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<PYGQCMVVAXX> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, KXUOEYSOWHL>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, KXUOEYSOWHL>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, KXUOEYSOWHL>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, KXUOEYSOWHL>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> task);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault2>d__132 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public AsyncTaskMethodBuilder<Result<MultiResult, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public Task<Result<MultiResult, KXUOEYSOWHL>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private TaskAwaiter<Result<MultiResult, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BA20", Offset = "0x2B3A420", VA = "0x182B3BA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BCE0", Offset = "0x2B3A6E0", VA = "0x182B3BCE0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncTaskMethodBuilder<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2B3BD50", Offset = "0x2B3A750", VA = "0x182B3BD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C010", Offset = "0x2B3AA10", VA = "0x182B3C010", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public AsyncTaskMethodBuilder<Result<None, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Task<Result<None, KXUOEYSOWHL>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter<Result<None, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C080", Offset = "0x2B3AA80", VA = "0x182B3C080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2B3C340", Offset = "0x2B3AD40", VA = "0x182B3C340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<string, EnumChoiceData> EPPNOJRFWXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Dictionary<int, string> MJHIJRQRSWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly List<object> ZRAZCWYZWYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly List<Guid> IGZQSRNPXCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CanLocalPlayerCreateCurrencyDelegate CHXCLOMVNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly ShowRoomCurrencyCreationUIDelegate CHLIPKUPLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipOptionsDelegate EMSHJRPMEBG;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<Guid, int> JGVXMASWIXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipGuidToIndexMapDelegate SXAVTXFFIII;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<int, Guid> QEOBDBOPNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAudioClipIndexToGuidMapDelegate PTEJDIOVARK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipOptionsDelegate ONZYNOSSYHF;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<Guid, int> EMWTWYCHBYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate OCKOEOMBQUB;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly IReadOnlyDictionary<int, Guid> AOWTLDDDQYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate SVUFGJMLEMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly PlayAudioPreviewDelegate GMATKXOVDTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly StopAudioPreviewDelegate NQESZKKVCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly SubscriptionIsActiveDelegate DWRKLEPIJJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate MQBZDDMWMEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Dictionary<string, EnumChoiceData> YVIZTNLJOMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly ShowQuickChatEditMenuDelegate PSCGGVHSXSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly ConfigureAttachedObjectDelegate OZVTHLXVAIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly DisplayInvalidNameErrorMessageDelegate WCPXLTTRRQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly IsStringPureDelegate UOUTTDDQUMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly TryGetSpecificChipConfigSummaryDelegate ZUUVJTDDSZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReleaseIconIdDelegate DBXQFZMQJET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate AEULRLXROAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 HNLYCUIGETT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 HNGRFNOIVIK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment FXNDQTIKJIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool RKAJSACNFRV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> AOOPUWETMYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> IIPZMGXRUNR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> IIJWBJQFNOU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> ACXTGNMBDIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD1E7D0", Offset = "0xD1D1D0", VA = "0x180D1E7D0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion DQNHZPWVLVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x102F2D0", Offset = "0x102DCD0", VA = "0x18102F2D0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ZXFIUDHFAAY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEFE760", Offset = "0xEFD160", VA = "0x180EFE760", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool QLIJWPKVGHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B33420", Offset = "0x2B31E20", VA = "0x182B33420", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool OOSXJTBVSVO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B33430", Offset = "0x2B31E30", VA = "0x182B33430", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool GRDFWJDJDNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xD17F80", Offset = "0xD16980", VA = "0x180D17F80", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B33660", Offset = "0x2B32060", VA = "0x182B33660")]
		public LBXHITMZCYD([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B33010", Offset = "0x2B31A10", VA = "0x182B33010", Slot = "9")]
		public bool PWJZJUDNPPW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10")]
		public static bool MGIFTADUJEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E50", Offset = "0x2B31850", VA = "0x182B32E50", Slot = "10")]
		public bool MEHJNWQTKBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public static void YJKLVLXIETS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF3A010", Offset = "0xF38A10", VA = "0x180F3A010", Slot = "11")]
		public void RYHMMLBXEZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BF0", Offset = "0x2B315F0", VA = "0x182B32BF0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DBKQUBKMRVU(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B33470", Offset = "0x2B31E70", VA = "0x182B33470", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> YSTPTLUJRHH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B33320", Offset = "0x2B31D20", VA = "0x182B33320")]
		private static IReadOnlyDictionary<Guid, int> STDDEQUCNYE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B32CD0", Offset = "0x2B316D0", VA = "0x182B32CD0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> HQZMEKNJOCL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C80", Offset = "0x2B31680", VA = "0x182B32C80")]
		private static IReadOnlyDictionary<int, Guid> HEWEKCLHVFW(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B33440", Offset = "0x2B31E40", VA = "0x182B33440", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> WPCLJJNPISH(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E20", Offset = "0x2B31820", VA = "0x182B32E20")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LVBSXTWFAVT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B28190", Offset = "0x2B26B90", VA = "0x182B28190", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZLKXMCOTBOY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B333A0", Offset = "0x2B31DA0", VA = "0x182B333A0")]
		private static IReadOnlyDictionary<Guid, int> THBRMAZVOXH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C20", Offset = "0x2B31620", VA = "0x182B32C20", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> DMLQPPZYERW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B32B80", Offset = "0x2B31580", VA = "0x182B32B80", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> AUTVXTIVNKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private static void RMERSEDXUZU(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B334A0", Offset = "0x2B31EA0", VA = "0x182B334A0", Slot = "18")]
		public void ZEOHHKOPPPD(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private static void QDHJUKLWULK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EC0", Offset = "0x2B318C0", VA = "0x182B32EC0", Slot = "19")]
		public void NFRYNSAQFTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10")]
		private static bool EDPYEZGNAFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C50", Offset = "0x2B31650", VA = "0x182B32C50", Slot = "20")]
		public bool EPRDFAXBTQG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10")]
		public static bool CFCCMAKZCLU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DF0", Offset = "0x2B317F0", VA = "0x182B32DF0", Slot = "21")]
		public bool LIDFODZMNZD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B33110", Offset = "0x2B31B10", VA = "0x182B33110", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SHYYZTIPCTY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> NONQWSTHOKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> YYIPUKQTISO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B32F80", Offset = "0x2B31980", VA = "0x182B32F80", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PQMMXFZMOHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> JUSARMRKSFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> OOBRTHRUFYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		public static void ROZSLQSTOQP(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B330D0", Offset = "0x2B31AD0", VA = "0x182B330D0", Slot = "29")]
		public void QUDMOXSEIQS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private static void SQOEWYALPLT(LYKEDRYMWQY a, RCFAQTSGIYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BC0", Offset = "0x2B315C0", VA = "0x182B32BC0", Slot = "35")]
		public void CEFPSYPTEKM(LYKEDRYMWQY a, RCFAQTSGIYC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "36")]
		public Dictionary<string, EnumChoiceData> XGZVTCEEHIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "37")]
		public Dictionary<string, EnumChoiceData> TWWAZQNDSLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private static void ECGSTOPIKFJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B32FB0", Offset = "0x2B319B0", VA = "0x182B32FB0")]
		private static Task<bool> PWIXBIQEPVZ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B33370", Offset = "0x2B31D70", VA = "0x182B33370", Slot = "38")]
		public Task<bool> TDQIDIPCLTQ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BB0", Offset = "0x2B315B0", VA = "0x182B32BB0")]
		private static bool BKBPBNTZBNN(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E80", Offset = "0x2B31880", VA = "0x182B32E80", Slot = "39")]
		public bool MTUHGYMLZOO(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private static void LBJMHOOYRRJ(Id32<PYGQCMVVAXX> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B333F0", Offset = "0x2B31DF0", VA = "0x182B333F0", Slot = "40")]
		public void VGFQTIAPRTQ(Id32<PYGQCMVVAXX> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D00", Offset = "0x2B31700", VA = "0x182B32D00")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, KXUOEYSOWHL>> IYKOLNQEELZ(Task<Result<None, KXUOEYSOWHL>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EF0", Offset = "0x2B318F0", VA = "0x182B32EF0", Slot = "41")]
		public Task<Result<None, KXUOEYSOWHL>> OHJUIRAGCVA(Task<Result<None, KXUOEYSOWHL>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B33230", Offset = "0x2B31C30", VA = "0x182B33230")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, KXUOEYSOWHL>> SIILBQDXNYD(Task<Result<MultiResult, KXUOEYSOWHL>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B32F50", Offset = "0x2B31950", VA = "0x182B32F50", Slot = "42")]
		public Task<Result<MultiResult, KXUOEYSOWHL>> OHJUIRAGCVA(Task<Result<MultiResult, KXUOEYSOWHL>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B33140", Offset = "0x2B31B40", VA = "0x182B33140")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> SIDEEJKAEMU(Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x2B32F20", Offset = "0x2B31920", VA = "0x182B32F20", Slot = "43")]
		public Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> OHJUIRAGCVA(Task<Result<Id32<JZROSXUIZUS>, KXUOEYSOWHL>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class EFDTPCKLAJY : YJGFPBUMEHT
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(XEQZGTZPMCK e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? HFYKQQUPBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly InteropDelegate LDJXGULUDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly InteropDelegate OQSGIWSZGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private InteropDelegate? HXLHXXVUNNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private InvokeStudioFunctionDelegate? XDFDDTVYPVK;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "5")]
		public LegacyCV2Result<None> LBBUVKQYAPG(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		private static LegacyCV2Result<None> Default(XEQZGTZPMCK _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "6")]
		public LegacyCV2Result<None> EFZHCUQMNXD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "7")]
		public LegacyCV2Result<None> XZLWRNIKXQO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "8")]
		public LegacyCV2Result<None> ZKQSILZKMZZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "9")]
		public LegacyCV2Result<None> FLQKOTUMTED(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "15")]
		public LegacyCV2Result<None> GFIQBGGZTHK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WRRRUGIFOIE(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KSDKVDXLSRC(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WQQGCUUFAXF(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VEHKUXIFBAW(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SRTTQTVPQKF(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TPQGOTRLWJT(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QIFTHXMOUZO(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "93")]
		public LegacyCV2Result<None> RHPLMHATCTX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "94")]
		public LegacyCV2Result<None> EFYWXSUBEEF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "95")]
		public LegacyCV2Result<None> TKMMVHIOSDM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XMZYVGVCVJI(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(XEQZGTZPMCK e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BXFUAIFFQQQ(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SDAVKKEQJNW(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CUTOYQGKOTR(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TZIDMCVSFSK(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IAVCGQJUMED(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QVCYTSUZOVL(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NOZIDJHBVVP(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ENIPHYNBWMA(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1546850", Offset = "0x1545250", VA = "0x181546850", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OGLCYXKQZSH(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BBOKSWXMPXO(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "119")]
		public LegacyCV2Result<None> JMHAUEGOVBG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LSIQIJUBBEN(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "121")]
		public LegacyCV2Result<None> VQYXJLNTPRL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "122")]
		public LegacyCV2Result<None> WJRXTEEOEKJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "123")]
		public LegacyCV2Result<None> CYVRFWLUFQZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "124")]
		public LegacyCV2Result<None> QIYSXAYOVTH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "125")]
		public LegacyCV2Result<None> VFINLHNJJWB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "126")]
		public LegacyCV2Result<None> SDPEDTEXBMW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "818")]
		public LegacyCV2Result<None> NRYGDYVXMWQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "819")]
		public LegacyCV2Result<None> ULOSYITQBUE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "147")]
		public LegacyCV2Result<None> PMNYNBOWUFC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "148")]
		public LegacyCV2Result<None> YRFTREWBDNK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "149")]
		public LegacyCV2Result<None> XAYRDWXRJFR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "150")]
		public LegacyCV2Result<None> URDCSLVJTLZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "151")]
		public LegacyCV2Result<None> WRSTLOLNWQS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(XEQZGTZPMCK e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(XEQZGTZPMCK e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(XEQZGTZPMCK e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, YJGFPBUMEHT.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(XEQZGTZPMCK e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, YJGFPBUMEHT.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "174")]
		public LegacyCV2Result<None> UQEHCYANTQH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "175")]
		public LegacyCV2Result<None> VOSOPELWGOU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "176")]
		public LegacyCV2Result<None> QYQEBYIETZW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "197")]
		public LegacyCV2Result<None> YURAEBHZIQS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "198")]
		public LegacyCV2Result<None> YGLSVYPDHZX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "199")]
		public LegacyCV2Result<None> BATYEGRFEDG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "200")]
		public LegacyCV2Result<None> ESWDQDPOZHW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "201")]
		public LegacyCV2Result<None> EBVSIQTCVGE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "202")]
		public LegacyCV2Result<None> EXPAHVJTMKF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "203")]
		public LegacyCV2Result<None> RDUCXDHDVCP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "204")]
		public LegacyCV2Result<None> MKFVLNSZCOV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "205")]
		public LegacyCV2Result<None> KQXWIOLHGNH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "206")]
		public LegacyCV2Result<None> KYDAPOCFTPD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "207")]
		public LegacyCV2Result<None> ETVQSMTGCCL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "208")]
		public LegacyCV2Result<None> VBHSSJTWMWH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "209")]
		public LegacyCV2Result<None> LBJQLSXAFBX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "210")]
		public LegacyCV2Result<None> GRJJMVNRXRC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "211")]
		public LegacyCV2Result<None> CAXSDSDFZDT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "212")]
		public LegacyCV2Result<None> TUPPJIYWMOU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "213")]
		public LegacyCV2Result<None> FGXXNWQCZKH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "214")]
		public LegacyCV2Result<None> PHUIKJDPOKA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "215")]
		public LegacyCV2Result<None> MRVQXAJMLFT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "274")]
		public LegacyCV2Result<None> HJCCSVRWAMJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "277")]
		public LegacyCV2Result<None> WEFJUQMBFCH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "279")]
		public LegacyCV2Result<None> QVWLTLLWHSW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "280")]
		public LegacyCV2Result<None> NPDWGAZJDTC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "281")]
		public LegacyCV2Result<None> ANASTBIHBQF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "282")]
		public LegacyCV2Result<None> ZWZFBPKUVRA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "283")]
		public LegacyCV2Result<None> KRKUJCHIJNV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "287")]
		public LegacyCV2Result<None> YNIYEEUCIAK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "288")]
		public LegacyCV2Result<None> RKVEQGOLIDV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "317")]
		public LegacyCV2Result<None> TJXMXOSPYXW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "406")]
		public LegacyCV2Result<None> ALQMMDQEPCD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YLKCMWOKPEG(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EHLDVVAQBZM(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HBLDQGYFZDW(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SPNBLFRNVJJ(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FZXTWIYERPO(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "416")]
		public LegacyCV2Result<QDXVDKSENJS.CV2DiscoverySectionType> JSDMCYPIDPB(XEQZGTZPMCK e, CircuitSignal a)
		{
			return default(LegacyCV2Result<QDXVDKSENJS.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "417")]
		public LegacyCV2Result<None> LBHVGLEANIT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(XEQZGTZPMCK e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ITWJLKHUAXF(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ULBIZMWIQYE(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SPEQSXTVZGV(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "462")]
		public LegacyCV2Result<None> KPTYXCICFWM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "463")]
		public LegacyCV2Result<None> JTTHNVZIKMV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "464")]
		public LegacyCV2Result<None> XPZJARSABCG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "465")]
		public LegacyCV2Result<None> KAVQCVAQDAH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "466")]
		public LegacyCV2Result<None> IIZYBPVEDPR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "467")]
		public LegacyCV2Result<None> GGDXRUPGIAR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "468")]
		public LegacyCV2Result<None> TPYSULLSLJY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "469")]
		public LegacyCV2Result<None> YWYUFKRTGCY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "474")]
		public LegacyCV2Result<None> OVQNLAJCWYS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "475")]
		public LegacyCV2Result<None> MJFOWCMPNLQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "476")]
		public LegacyCV2Result<None> HBBIDTXSDRN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "477")]
		public LegacyCV2Result<None> WFJABVXZWLA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "478")]
		public LegacyCV2Result<None> KVYTRXYZIDI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "479")]
		public LegacyCV2Result<None> TKQVCSUQRET(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(XEQZGTZPMCK executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(XEQZGTZPMCK executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "472")]
		public LegacyCV2Result<None> ZELROKLHBQR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "473")]
		public LegacyCV2Result<None> RFUMVOYAAYB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "480")]
		public LegacyCV2Result<None> CTHQQKQPDZD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "481")]
		public LegacyCV2Result<None> PHCQMZAMNXD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "482")]
		public LegacyCV2Result<None> SEQZOUOIYPE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "483")]
		public LegacyCV2Result<None> HZYFDRXIBBW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "484")]
		public LegacyCV2Result<None> DNOFAGICFYO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "485")]
		public LegacyCV2Result<None> TFGVIKEMBRQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "486")]
		public LegacyCV2Result<None> GKDLESOPHTK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "487")]
		public LegacyCV2Result<None> CESHUVGZRVI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "488")]
		public LegacyCV2Result<None> ISTMSBZTZOM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "489")]
		public LegacyCV2Result<None> WFDIZRMPETW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "490")]
		public LegacyCV2Result<None> CIALANEWXLQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "491")]
		public LegacyCV2Result<None> EJPIAJDAMBU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "492")]
		public LegacyCV2Result<None> MKQGWPXPOJK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "493")]
		public LegacyCV2Result<None> IVFYTILJEUA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "494")]
		public LegacyCV2Result<None> LUZURQDMCPC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "495")]
		public LegacyCV2Result<None> BJIZYWNVJNE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "496")]
		public LegacyCV2Result<None> DKIQXPSDHLI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "497")]
		public LegacyCV2Result<None> WLVYJSVVRRA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "498")]
		public LegacyCV2Result<None> EUQBEZNYZSQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "499")]
		public LegacyCV2Result<None> PTPHBKAPLMG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B31A60", Offset = "0x2B30460", VA = "0x182B31A60", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "507")]
		public LegacyCV2Result<None> EOQQPZDRTQA(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "508")]
		public LegacyCV2Result<None> GTXVFAZVCGS(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "509")]
		public LegacyCV2Result<None> PQCSROYYTMC(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "510")]
		public LegacyCV2Result<None> BDMIMKGAQOZ(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(XEQZGTZPMCK e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(XEQZGTZPMCK e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(XEQZGTZPMCK e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.UBYMGMZCJVK> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "522")]
		public LegacyCV2Result<None> IPRHTXMHZJJ(XEQZGTZPMCK e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "525")]
		public LegacyCV2Result<None> DMOQEUAHUWH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "527")]
		public LegacyCV2Result<None> GJLZRLCVCDS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "528")]
		public LegacyCV2Result<None> WCFEEEXUGAK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "530")]
		public LegacyCV2Result<None> MUCCDNKTLPM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "531")]
		public LegacyCV2Result<None> OAAVNVYAXBT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2B31940", Offset = "0x2B30340", VA = "0x182B31940", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "533")]
		public LegacyCV2Result<None> BIVYXQVHHCB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B31900", Offset = "0x2B30300", VA = "0x182B31900", Slot = "535")]
		public LegacyCV2Result<None> CPLHRNPPBOL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "534")]
		public LegacyCV2Result<None> EYZTFVOTYIE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "536")]
		public LegacyCV2Result<None> KGRSGWUHPZK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "537")]
		public LegacyCV2Result<None> DZJKMILPRSX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "538")]
		public LegacyCV2Result<None> XXIECKYHZPP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "539")]
		public LegacyCV2Result<None> FSDBXJELYAN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "540")]
		public LegacyCV2Result<None> GGNVIAUCXNJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "583")]
		public LegacyCV2Result<None> Raycast(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "584")]
		public LegacyCV2Result<None> XDSAIHEGFRO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "587")]
		public LegacyCV2Result<None> LUJXGTQGZLF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "591")]
		public LegacyCV2Result<None> DHDXFMFFBQS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "592")]
		public LegacyCV2Result<None> HYPILFBMGWB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "641")]
		public LegacyCV2Result<None> FWNLPAHFEFA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "642")]
		public LegacyCV2Result<None> BKDMCEEXKEC(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "643")]
		public LegacyCV2Result<None> GWQALTONSVB(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "644")]
		public LegacyCV2Result<None> RTVGDKSXWMU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "645")]
		public LegacyCV2Result<None> XWRGGKXEHBW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "646")]
		public LegacyCV2Result<None> EOGFZRJOLLL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "649")]
		public LegacyCV2Result<None> XIBXWHGQRJU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "650")]
		public LegacyCV2Result<None> ZLVYGHCPKHU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "651")]
		public LegacyCV2Result<None> FREDOOSOQQH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "661")]
		public LegacyCV2Result<None> UNKMSVYQXUE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "660")]
		public LegacyCV2Result<None> OBLTCYFIHHJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "662")]
		public LegacyCV2Result<None> JWZZQDEOXWK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "663")]
		public LegacyCV2Result<None> LROWOWENFFL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "670")]
		public LegacyCV2Result<None> LVLNVXIPPBA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "671")]
		public LegacyCV2Result<None> PHVLXKIYALH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "674")]
		public LegacyCV2Result<None> LMJDGJXQGJB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "675")]
		public LegacyCV2Result<None> CTYKTZOJYWC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(XEQZGTZPMCK e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "696")]
		public LegacyCV2Result<None> RUZMXLDRDKE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "697")]
		public LegacyCV2Result<None> YJICCSWCTOG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "698")]
		public LegacyCV2Result<None> WJTXWYZBNIW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "699")]
		public LegacyCV2Result<None> ZYUEHMOYHWN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "700")]
		public LegacyCV2Result<None> UOGKAZWKMMZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "676")]
		public LegacyCV2Result<None> JYCOZWCAWIS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "677")]
		public LegacyCV2Result<None> FLFYSZWRDSA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "678")]
		public LegacyCV2Result<None> POPGUXOWHIV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "679")]
		public LegacyCV2Result<None> CVGBBOAWAII(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "680")]
		public LegacyCV2Result<None> EWAOMTDMBVZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "681")]
		public LegacyCV2Result<None> ENQNZLIMKLM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "682")]
		public LegacyCV2Result<None> SNXCHJFHBVW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "683")]
		public LegacyCV2Result<None> AXJZYGZVJCF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "684")]
		public LegacyCV2Result<None> CVLIYKMFYVX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "685")]
		public LegacyCV2Result<None> JQRVPOIKNCQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "686")]
		public LegacyCV2Result<None> RZEKWLKXIKC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "687")]
		public LegacyCV2Result<None> EHQLUNYIXAT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "688")]
		public LegacyCV2Result<None> HJFKUQPEUDO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "689")]
		public LegacyCV2Result<None> JZMDTREKPYI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "690")]
		public LegacyCV2Result<None> ZCDGQWVCSTP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "691")]
		public LegacyCV2Result<None> HKEPCPYSIPV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "692")]
		public LegacyCV2Result<None> LRFQBZXNWZP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "693")]
		public LegacyCV2Result<None> OOBGOOJWZKK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "765")]
		public LegacyCV2Result<None> HJTOSDZGPQG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "711")]
		public LegacyCV2Result<None> IPUJOQRAIRV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "712")]
		public LegacyCV2Result<None> JTYRXSUXNZX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "713")]
		public LegacyCV2Result<None> IUCWFZADAWT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "714")]
		public LegacyCV2Result<None> YDKUSBZFSLT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "717")]
		public LegacyCV2Result<None> RXGNZPAVDKB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "721")]
		public LegacyCV2Result<None> ZRJYGXOIUQM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "722")]
		public LegacyCV2Result<None> NCEIOTUGVYO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "723")]
		public LegacyCV2Result<None> ZOKAENIJKND(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "724")]
		public LegacyCV2Result<None> THAZIPETKEP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "725")]
		public LegacyCV2Result<None> BKIBUKFCZTN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "726")]
		public LegacyCV2Result<None> HRQWFWWIMXY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "727")]
		public LegacyCV2Result<None> NRSTYVKBTOD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "728")]
		public LegacyCV2Result<None> KQVNBVEGKJQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "729")]
		public LegacyCV2Result<None> VMYXTTAGYEC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "730")]
		public LegacyCV2Result<None> SOUGWANYXLU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "731")]
		public LegacyCV2Result<None> DSJLXADRIZE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "732")]
		public LegacyCV2Result<None> DMOXGKQFTOO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "733")]
		public LegacyCV2Result<None> IAWGQJLBTOY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "734")]
		public LegacyCV2Result<None> IWSMJHSASCH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "735")]
		public LegacyCV2Result<None> YNROGYBCCDM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "736")]
		public LegacyCV2Result<None> EUAOGPYZTAU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "737")]
		public LegacyCV2Result<None> TABZTTGUYMT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "738")]
		public LegacyCV2Result<None> AIYAURVNNIU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "740")]
		public LegacyCV2Result<None> RLFLDVLWOIS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "739")]
		public LegacyCV2Result<None> EUSEDUAQLSI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "741")]
		public LegacyCV2Result<None> BTWONUQVGXP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "742")]
		public LegacyCV2Result<None> ZSGDOKBXFAU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "743")]
		public LegacyCV2Result<None> JXTHLSGWYYH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "744")]
		public LegacyCV2Result<None> MCFCSGXUHDJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "745")]
		public LegacyCV2Result<None> ITUWPQDGWCC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "746")]
		public LegacyCV2Result<None> VCMSXQYXCGD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "747")]
		public LegacyCV2Result<None> LKJWTYNETZB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "748")]
		public LegacyCV2Result<None> HYPYYTSEDBW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "749")]
		public LegacyCV2Result<None> JBMVFQWXIRQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "750")]
		public LegacyCV2Result<None> ZRTTRSPVIGY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "751")]
		public LegacyCV2Result<None> NLGHUPEDAOM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "752")]
		public LegacyCV2Result<None> WDSYFLWXQUS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "753")]
		public LegacyCV2Result<None> MGWNPMQTGTI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "754")]
		public LegacyCV2Result<None> XGONUBHUEFE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "755")]
		public LegacyCV2Result<None> GLFBDYLCBYX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "756")]
		public LegacyCV2Result<None> GTLCDDZYHDV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "757")]
		public LegacyCV2Result<None> IDFFDIBXBPL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "758")]
		public LegacyCV2Result<None> MUGZATNDKSL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "759")]
		public LegacyCV2Result<None> HVGOFQIRUEI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "760")]
		public LegacyCV2Result<None> EFZIMKJCUBO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "761")]
		public LegacyCV2Result<None> PRWVQLBBXDS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "762")]
		public LegacyCV2Result<None> TZCDLLGIUQB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "763")]
		public LegacyCV2Result<None> JYFBMKGGNCX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "764")]
		public LegacyCV2Result<None> PDOTUJFETPK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "771")]
		public LegacyCV2Result<None> DNRUXAOGHUY(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "772")]
		public LegacyCV2Result<None> JUXJMDLFKVI(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "773")]
		public LegacyCV2Result<None> UKNNGZMPZUD(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(XEQZGTZPMCK ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "775")]
		public LegacyCV2Result<None> IEXGAHTSGJT(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "776")]
		public LegacyCV2Result<None> WQVWKHOBVGH(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "777")]
		public LegacyCV2Result<None> KKYFACLIBDY(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "778")]
		public LegacyCV2Result<None> KWYJNNMRDZQ(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "779")]
		public LegacyCV2Result<None> UADUCGADDTK(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "707")]
		public LegacyCV2Result<None> AYVDORHAKJS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "801")]
		public LegacyCV2Result<None> PIKDOMZUFXC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "802")]
		public LegacyCV2Result<None> QWOSFJUHWVK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "803")]
		public LegacyCV2Result<None> WZMCKGFRRKE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "804")]
		public LegacyCV2Result<None> YOIIHGOIURM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "805")]
		public LegacyCV2Result<None> VYYFVONGSUI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "806")]
		public LegacyCV2Result<None> ZLFVIAGEISM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "807")]
		public LegacyCV2Result<None> UIRUSPRVNPW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "808")]
		public LegacyCV2Result<None> FWDGRPTNQUC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "809")]
		public LegacyCV2Result<None> GCKBBLQLDVW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "810")]
		public LegacyCV2Result<None> UJAJGNOJDBS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "811")]
		public LegacyCV2Result<None> AONKJAIIOOS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "812")]
		public LegacyCV2Result<None> EKQYMMPUQXL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "817")]
		public LegacyCV2Result<None> SZSGGLMCPRM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "821")]
		public LegacyCV2Result<None> HRCJCSFJFOR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "822")]
		public LegacyCV2Result<None> AXYJIIVCAYD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "823")]
		public LegacyCV2Result<None> ZCDXALTXRLF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "824")]
		public LegacyCV2Result<None> MRNHXMECYQR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "826")]
		public LegacyCV2Result<None> YKPWOBEUVXH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "827")]
		public LegacyCV2Result<None> RHFECYYUDJA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "828")]
		public LegacyCV2Result<None> RSZNLHYIIEQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "831")]
		public LegacyCV2Result<None> GSMLMAGAQDC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "832")]
		public LegacyCV2Result<None> ZCZTCSVHDKZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "833")]
		public LegacyCV2Result<None> TDKNVLEWPFO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(XEQZGTZPMCK e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "836")]
		public LegacyCV2Result<None> DBMXSYFLBFV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AFCNWCMNIKN(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NPRLAQASDXP(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DDCMPVEEKCE(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AKBBAEZCDQR(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TXUKYVBIJPQ(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(XEQZGTZPMCK e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(XEQZGTZPMCK e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(XEQZGTZPMCK e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "856")]
		public LegacyCV2Result<None> VNRJHSQTABZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "859")]
		public LegacyCV2Result<None> JTJYDOTTLBB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "860")]
		public LegacyCV2Result<None> YXVQYXFPCFH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "861")]
		public LegacyCV2Result<None> IYLFAQYNIAT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "862")]
		public LegacyCV2Result<None> AHOZBCVDTRE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "864")]
		public LegacyCV2Result<None> DTFXOFVZNQT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "865")]
		public LegacyCV2Result<None> GDGVKAQEUAL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(XEQZGTZPMCK e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "869")]
		public LegacyCV2Result<None> RKXVGJRQEZT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "879")]
		public LegacyCV2Result<None> JFGAOCKGHSL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "880")]
		public LegacyCV2Result<None> ZQZEPYLMANN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "881")]
		public LegacyCV2Result<None> GCRLZIVZXWG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "882")]
		public LegacyCV2Result<None> AMSXJVWVKLB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(XEQZGTZPMCK e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(XEQZGTZPMCK e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(XEQZGTZPMCK e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(XEQZGTZPMCK e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "889")]
		public LegacyCV2Result<None> VKSBOBMBNRP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "890")]
		public LegacyCV2Result<None> HMVRBBLVONY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "891")]
		public LegacyCV2Result<None> IWTEHZVFDPH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "892")]
		public LegacyCV2Result<None> NCAJRZPAJHH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "893")]
		public LegacyCV2Result<None> DXWZTBYAJFZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "897")]
		public LegacyCV2Result<None> NWSHQDXBFMM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "898")]
		public LegacyCV2Result<None> PXZGWMVFXFO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "899")]
		public LegacyCV2Result<None> PUPNKBYMAHF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "901")]
		public LegacyCV2Result<None> ZFAEUQSJZBJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "900")]
		public LegacyCV2Result<None> AZLNHAJBNMV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "902")]
		public LegacyCV2Result<None> GHNSGMKWGHG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "904")]
		public LegacyCV2Result<None> BCIJZRUMJLW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "903")]
		public LegacyCV2Result<None> JVZYOYFNNEQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "905")]
		public LegacyCV2Result<None> QORIIEEKRKF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "906")]
		public LegacyCV2Result<None> SILQMUEMBOB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "907")]
		public LegacyCV2Result<None> SKHUHSYFPMW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "908")]
		public LegacyCV2Result<None> VSKBQCNDGXS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "909")]
		public LegacyCV2Result<None> MFFIOOZOZZY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "910")]
		public LegacyCV2Result<None> BLJCZIOWATQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "911")]
		public LegacyCV2Result<None> YACKPEXYIXM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "918")]
		public LegacyCV2Result<None> ITGKWBWZDMA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "919")]
		public LegacyCV2Result<None> XALHAXRKFEG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(XEQZGTZPMCK e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "941")]
		public LegacyCV2Result<None> RQJAZKXGRRC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "942")]
		public LegacyCV2Result<None> NHVCIRSEZQW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "943")]
		public LegacyCV2Result<None> HTOLYEXSYGV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "944")]
		public LegacyCV2Result<None> GPBMZMSUAIZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "945")]
		public LegacyCV2Result<None> SHUJBXRLXAQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "946")]
		public LegacyCV2Result<None> VYPCJDIVWSU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "947")]
		public LegacyCV2Result<None> MTWKWICPWWL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "948")]
		public LegacyCV2Result<None> UAYEUQMEVFX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "949")]
		public LegacyCV2Result<None> TDELLMSPEST(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "950")]
		public LegacyCV2Result<None> QLIEJUTCSWC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "968")]
		public LegacyCV2Result<None> HRBSYQAYXOG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "967")]
		public LegacyCV2Result<None> SKFEUWNNIZD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "969")]
		public LegacyCV2Result<None> WWGYFLSGQDH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "970")]
		public LegacyCV2Result<None> LAPQHUEJDKI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "971")]
		public LegacyCV2Result<None> KGYGGGHVHDH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "972")]
		public LegacyCV2Result<None> DSJAANTCGFV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "973")]
		public LegacyCV2Result<None> AHJHQFGTUXW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "975")]
		public LegacyCV2Result<None> LXEKJOWKBGH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "982")]
		public LegacyCV2Result<None> HEZRJZRKKZE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "983")]
		public LegacyCV2Result<None> GRVZRXLQVBU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "991")]
		public LegacyCV2Result<None> DTHNFVNKNIN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "993")]
		public LegacyCV2Result<None> KVJGFUCPOYZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "994")]
		public LegacyCV2Result<None> TYFWKFFFUZN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "995")]
		public LegacyCV2Result<None> CYYVTKUSTBF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "996")]
		public LegacyCV2Result<None> GLQKIWDSCJD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "997")]
		public LegacyCV2Result<None> EXMIYCLWBYX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "998")]
		public LegacyCV2Result<None> ZESECPNCKTR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "999")]
		public LegacyCV2Result<None> PTWRIPSBYPL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1000")]
		public LegacyCV2Result<None> QDABYGULSQV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1001")]
		public LegacyCV2Result<None> ARYNZGKPDIZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1002")]
		public LegacyCV2Result<None> GBVWWZUULTX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1009")]
		public LegacyCV2Result<None> ASBZICUSPMR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1017")]
		public LegacyCV2Result<None> ULEQCRUXZSE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1018")]
		public LegacyCV2Result<None> GHAXANOYDKX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1019")]
		public LegacyCV2Result<None> LIZHYMOMFCY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1020")]
		public LegacyCV2Result<None> IHAGPWWAVAH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1021")]
		public LegacyCV2Result<None> ZLYQQTLJHQC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1022")]
		public LegacyCV2Result<None> TOPCGJTBORR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1023")]
		public LegacyCV2Result<None> VXRSPARRLMS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1024")]
		public LegacyCV2Result<None> IPJMRVWHWSW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1025")]
		public LegacyCV2Result<None> AEZMXZCITEJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1026")]
		public LegacyCV2Result<None> CCTWKSXKIWQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1027")]
		public LegacyCV2Result<None> NRVJHPTUKSG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1028")]
		public LegacyCV2Result<None> OEPZBGECVAH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1029")]
		public LegacyCV2Result<None> KDIJWPUHAYV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1030")]
		public LegacyCV2Result<None> LRCYCMMJEOC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1031")]
		public LegacyCV2Result<None> DZHMIJXOHCZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1032")]
		public LegacyCV2Result<None> NNMQNTJYJVU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1033")]
		public LegacyCV2Result<None> EHBNELKOGCW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1047")]
		public LegacyCV2Result<None> EFYFECNIMAO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1048")]
		public LegacyCV2Result<None> ECDSNBSTBJU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1049")]
		public LegacyCV2Result<None> UJZPHZIQXFK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1050")]
		public LegacyCV2Result<None> JDCASYSCIGI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1051")]
		public LegacyCV2Result<None> YEBVSDJPCIN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1052")]
		public LegacyCV2Result<None> ENIIQFERSTL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1053")]
		public LegacyCV2Result<None> NJYFYFWVZKQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1054")]
		public LegacyCV2Result<None> KGWHXTLQBTH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1055")]
		public LegacyCV2Result<None> WLHPVLFWNEM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1056")]
		public LegacyCV2Result<None> CDRGLYHHKSH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1057")]
		public LegacyCV2Result<None> GHYTFVTSEXX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1058")]
		public LegacyCV2Result<None> GIDMVSJNROI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1059")]
		public LegacyCV2Result<None> NSTJJTRYNNZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1060")]
		public LegacyCV2Result<None> KEVBOYRSPRL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1061")]
		public LegacyCV2Result<None> VOZTVEAYQUV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1062")]
		public LegacyCV2Result<None> ADAWSCTFGUV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1063")]
		public LegacyCV2Result<None> ANBITNQGTWZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1064")]
		public LegacyCV2Result<None> MYXTCCDBXCY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1065")]
		public LegacyCV2Result<None> DVAJUKGGWSI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1066")]
		public LegacyCV2Result<None> GVRPSZAJNCD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1067")]
		public LegacyCV2Result<None> QRZLXRLSUIH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1068")]
		public LegacyCV2Result<None> YEDZLTUUTFD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1069")]
		public LegacyCV2Result<None> ERISRQKIRWN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1070")]
		public LegacyCV2Result<None> JQYEPGPLKZK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1071")]
		public LegacyCV2Result<None> KVIZWJCTVCI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2B31980", Offset = "0x2B30380", VA = "0x182B31980", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(XEQZGTZPMCK e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(XEQZGTZPMCK e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1092")]
		public LegacyCV2Result<None> QAWKARVNBWF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1093")]
		public LegacyCV2Result<None> NMFHJFACTFK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1094")]
		public LegacyCV2Result<None> POTBPCULKNC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1095")]
		public LegacyCV2Result<None> UNTNPWBSLJO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1096")]
		public LegacyCV2Result<None> XWJOPDJRGMA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1097")]
		public LegacyCV2Result<None> KCXNGZGASME(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1098")]
		public LegacyCV2Result<None> RHQXJTABOSE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1099")]
		public LegacyCV2Result<None> JZSHMNWLVGK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1100")]
		public LegacyCV2Result<None> KQBOMFWMNLE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1101")]
		public LegacyCV2Result<None> XSHCDHFGXAG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1102")]
		public LegacyCV2Result<None> DCMDLMBBBLM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1103")]
		public LegacyCV2Result<None> PUKWGSUZNXL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1104")]
		public LegacyCV2Result<None> ZTENOFRSEGV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1105")]
		public LegacyCV2Result<None> JUSKVWKJPDL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1106")]
		public LegacyCV2Result<None> YGBVJWWQLTP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1107")]
		public LegacyCV2Result<None> NGICJONXEYE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1108")]
		public LegacyCV2Result<None> AXYZJVDXGQI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1109")]
		public LegacyCV2Result<None> MCMHEYQPIDB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1110")]
		public LegacyCV2Result<None> TBUSAVMXNTZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1111")]
		public LegacyCV2Result<None> IQJEHIDDCJT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1112")]
		public LegacyCV2Result<None> EFUHRXLMMZP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1113")]
		public LegacyCV2Result<None> LRRJUBKWRMQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1114")]
		public LegacyCV2Result<None> HUXVPYEWUXK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1115")]
		public LegacyCV2Result<None> KERWDPUXXDD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1116")]
		public LegacyCV2Result<None> AMBOVZCFNOJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1117")]
		public LegacyCV2Result<None> VAAXGVYJBTL(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1118")]
		public LegacyCV2Result<None> OJAGEJDWIWV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1119")]
		public LegacyCV2Result<None> NHLATCDEQDS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1120")]
		public LegacyCV2Result<None> FEVJHCMUDHT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1121")]
		public LegacyCV2Result<None> VAVZFPOLLVZ(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1122")]
		public LegacyCV2Result<None> SZFKBXSGALF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1123")]
		public LegacyCV2Result<None> MVPITKHWFUK(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1124")]
		public LegacyCV2Result<None> SIBQKTXMLOC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1125")]
		public LegacyCV2Result<None> WPDKUQMUIBS(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1126")]
		public LegacyCV2Result<None> ZWLPLXVJUGM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1127")]
		public LegacyCV2Result<None> SLQNTTCPLWG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1128")]
		public LegacyCV2Result<None> TFYAAOOHRRU(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1129")]
		public LegacyCV2Result<None> PALWLKPRAHA(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1130")]
		public LegacyCV2Result<None> SWCGJVKKLVZ(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1131")]
		public LegacyCV2Result<None> PYZOOOTPYUI(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1132")]
		public LegacyCV2Result<None> ERGSUXQOZCH(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1133")]
		public LegacyCV2Result<None> VVRTEPCFBUA(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1134")]
		public LegacyCV2Result<None> LZOQHZPFQLS(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1135")]
		public LegacyCV2Result<None> HDXOTAGFFRR(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1136")]
		public LegacyCV2Result<None> EBYJUTNHTZB(BHTKLEBSRSX e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1140")]
		public LegacyCV2Result<None> OVXMRHUTFKV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1166")]
		public LegacyCV2Result<None> AIHFLRVBBKT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1168")]
		public LegacyCV2Result<None> GOHQPUAZGNB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1169")]
		public LegacyCV2Result<None> ZHJNFHBUIPQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1170")]
		public LegacyCV2Result<None> MIGRNZEFOQV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1171")]
		public LegacyCV2Result<None> JZMNCFNZMTW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1182")]
		public LegacyCV2Result<None> EUFNQRDZHII(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1183")]
		public LegacyCV2Result<None> CQEWHFLJNIQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1184")]
		public LegacyCV2Result<None> XCVQKTVFNGK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1185")]
		public LegacyCV2Result<None> WCLXVZMRDXA(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1186")]
		public LegacyCV2Result<None> ATYZMFLCJVD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1187")]
		public LegacyCV2Result<None> NBTIXFFMPLZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1188")]
		public LegacyCV2Result<None> RXOMPLXKHPZ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1189")]
		public LegacyCV2Result<None> CQNECMLUWIN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1190")]
		public LegacyCV2Result<None> ULBWSJQEFOY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1191")]
		public LegacyCV2Result<None> STBRXHBOFEI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1192")]
		public LegacyCV2Result<None> BOMFABASGZB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1193")]
		public LegacyCV2Result<None> UISPIYWTRME(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "184")]
		public LegacyCV2Result<None> UNXPLTTRCXY(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B319C0", Offset = "0x2B303C0", VA = "0x182B319C0", Slot = "191")]
		public bool PCGUOCYTXPO(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1194")]
		public LegacyCV2Result<None> WNJVIHRFVLK(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1195")]
		public LegacyCV2Result<None> SSBHXVSNXEP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1196")]
		public LegacyCV2Result<None> GHLKZECTAUM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(XEQZGTZPMCK e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1205")]
		public LegacyCV2Result<None> ATUOQPVETDX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1206")]
		public LegacyCV2Result<None> KGXJWOYNTBX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(XEQZGTZPMCK e, InOut io, XEAHXVFCKON objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "250")]
		public LegacyCV2Result<None> MCBVIOWHELO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "251")]
		public LegacyCV2Result<None> VJYAVQWFELO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "252")]
		public LegacyCV2Result<None> XPFWLOFSAAI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "254")]
		public LegacyCV2Result<None> JUCANIBALBX(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "255")]
		public LegacyCV2Result<None> SSSOLIRMMUD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "256")]
		public LegacyCV2Result<None> OFQQECWJKJF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "257")]
		public LegacyCV2Result<None> NUFXXCNNNZO(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "258")]
		public LegacyCV2Result<None> XTZATQBMCAI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "259")]
		public LegacyCV2Result<None> TPYLQTAHTLD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "260")]
		public LegacyCV2Result<None> XBYDFEPEIQJ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "261")]
		public LegacyCV2Result<None> KKUEHDEMYMT(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "262")]
		public LegacyCV2Result<None> MEVIWFCYOVN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "263")]
		public LegacyCV2Result<None> ATFUKPNJEKM(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "264")]
		public LegacyCV2Result<None> BRXRZMNQVQQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "265")]
		public LegacyCV2Result<None> KADNDSVUSVS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "266")]
		public LegacyCV2Result<None> KYOVPBUYJMC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "267")]
		public LegacyCV2Result<None> MXGVNXDNFTI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "268")]
		public LegacyCV2Result<None> GPTEMGEYASI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "269")]
		public LegacyCV2Result<None> BNHVLZZWOOE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		private static LegacyCV2Result<None> Default(XEQZGTZPMCK e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B319D0", Offset = "0x2B303D0", VA = "0x182B319D0", Slot = "1209")]
		public LegacyCV2Result<None> QYPAAYWYXTV(XEQZGTZPMCK a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1212")]
		public LegacyCV2Result<None> AZIOEALGUYS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1213")]
		public LegacyCV2Result<None> OEOHHESILUI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1214")]
		public LegacyCV2Result<None> SVGGIHIWEQG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1215")]
		public LegacyCV2Result<None> GNQGNSCXMJV(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(XEQZGTZPMCK e, InOut io, UCPJKFNKWJB quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1036")]
		public LegacyCV2Result<None> ZTEVDWLEGKQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1037")]
		public LegacyCV2Result<None> SPZJFJFHEFW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1038")]
		public LegacyCV2Result<None> CVNHJWUSNTC(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1039")]
		public LegacyCV2Result<None> YCRTCUXASFW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1040")]
		public LegacyCV2Result<None> MZCURSHVVEW(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1041")]
		public LegacyCV2Result<None> YYQUVOGWWWS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1042")]
		public LegacyCV2Result<None> RTHGHLPLCEM(XEQZGTZPMCK a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1043")]
		public LegacyCV2Result<None> CYKZCLHGTZE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1044")]
		public LegacyCV2Result<None> OAVQTTNTKRE(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1045")]
		public LegacyCV2Result<None> TPTDQJPPURP(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1046")]
		public LegacyCV2Result<None> HSJXCDXIDMR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NNFOOLYYPNN(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1234")]
		public LegacyCV2Result<None> JAMZAFIYXVQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1236")]
		public LegacyCV2Result<None> GHYLRIABLPD(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1229")]
		public LegacyCV2Result<None> LWNFRLQZXBH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1241")]
		public LegacyCV2Result<None> ZWLVRMBYLMH(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1242")]
		public LegacyCV2Result<None> VKVADINWEZI(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1243")]
		public LegacyCV2Result<None> PJTGEBPOCJQ(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1244")]
		public LegacyCV2Result<None> NUQTVIZVXQG(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1245")]
		public LegacyCV2Result<None> QMSPPTKYVFR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EJMQURFRKXZ(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SSJJDATNMDN(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OZZRTZIRJZN(XEQZGTZPMCK a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1259")]
		public LegacyCV2Result<None> ICKWDSHUXWB(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1260")]
		public LegacyCV2Result<None> RSGOIRAFMLF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1261")]
		public LegacyCV2Result<None> YAKNIXOZLLF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1262")]
		public LegacyCV2Result<None> NNZDIAAKAIN(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x2B31AA0", Offset = "0x2B304A0", VA = "0x182B31AA0")]
		public EFDTPCKLAJY([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(XEQZGTZPMCK e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1280")]
		public LegacyCV2Result<None> OEAJUQMZZSS(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1281")]
		public LegacyCV2Result<None> AHDXIVDOSPR(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "599")]
		public LegacyCV2Result<None> ZTEGHIYSFRF(XEQZGTZPMCK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1293")]
		public LegacyCV2Result<None> SSAQRZLTRQI(BHTKLEBSRSX e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1294")]
		public LegacyCV2Result<None> VFINQCMCIDN(BHTKLEBSRSX e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1295")]
		public LegacyCV2Result<None> TWRAXHYUXNK(BHTKLEBSRSX e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1296")]
		public LegacyCV2Result<None> RCSCBMALWHS(BHTKLEBSRSX e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1297")]
		public LegacyCV2Result<None> MPUAULNITPV(BHTKLEBSRSX e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(XEQZGTZPMCK e, InOut io, [In] MYTZYNYMFBQ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(XEQZGTZPMCK e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> QESYPOMNKCX(XEQZGTZPMCK a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, YJGFPBUMEHT.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> EDTOFZOZXSN(XEQZGTZPMCK a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, YJGFPBUMEHT.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1207")]
		private LegacyCV2Result<None> UBWWUISQVLA(XEQZGTZPMCK a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1216")]
		private LegacyCV2Result<None> DCPFHSTUGDD(XEQZGTZPMCK a, InOut b, [In] MYTZYNYMFBQ storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x11223B0", Offset = "0x1120DB0", VA = "0x1811223B0", Slot = "1257")]
		private LegacyCV2Result<None> QUJPOXVVIMX(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class MGXLRQKGXDR : PWSVWEXBUOM
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(CEIACCWKIGH node);

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly MGXLRQKGXDR TXSURWIFJDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate RCXASGFGUBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate WASVXXVUVMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private bool IIKLEZXTEGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private bool MNJEUGVWFXM;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0", Slot = "4")]
		public Task<bool> NBNGRTNLGVX(CEIACCWKIGH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2B41150", Offset = "0x2B3FB50", VA = "0x182B41150", Slot = "5")]
		public Task<bool> SFUYKWQGTGM(CEIACCWKIGH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2B41200", Offset = "0x2B3FC00", VA = "0x182B41200")]
		public MGXLRQKGXDR([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2B41130", Offset = "0x2B3FB30", VA = "0x182B41130", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? MYHKODTYANR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950", Slot = "7")]
		public bool IFSWQRZIUYW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x1620000", Offset = "0x161EA00", VA = "0x181620000", Slot = "8")]
		public bool MHOMFLWUITI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class DKUCXITQOAJ : JWMVVHYQBPO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid JTBWLDJFKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
		public void Bind(STXDHHZHEBQ pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x111D590", Offset = "0x111BF90", VA = "0x18111D590")]
		public DKUCXITQOAJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2B40800", Offset = "0x2B3F200", VA = "0x182B40800")]
		public static DKUCXITQOAJ New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class YGONEUSUVED : LABJXPUMTYX
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<MIMXYJWAARO> nodeDefId, Id128<VFKNGTPUEMY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IsNodeRestrictedDelegate? SLUBODAMVRO;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ZXFIUDHFAAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool USJKCQQQZDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x2B478C0", Offset = "0x2B462C0", VA = "0x182B478C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VXRMWIGDFQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x113A7F0", Offset = "0x11391F0", VA = "0x18113A7F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "6")]
		public bool PCPJTXGNSAI(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "7")]
		public CanSaveObjectIntoInventionResultType FHYBNSAAEYR(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2B47870", Offset = "0x2B46270", VA = "0x182B47870", Slot = "8")]
		public bool LJUSLRRQUYA(Id128<MIMXYJWAARO> nodeDefId, Id128<VFKNGTPUEMY>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VFKNGTPUEMY>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "9")]
		public bool OLVAISCVFZN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "10")]
		public bool JPMABAPMGLN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2B478D0", Offset = "0x2B462D0", VA = "0x182B478D0")]
		public YGONEUSUVED(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class UIPLABHYMDB : RMNFFILVAMY
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly UIPLABHYMDB TXSURWIFJDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly ShouldLogEventSenderToMakerPenDelegate RUZLYUBVZJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate BIOFSHBHXHR;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ZSQGVYYAQMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x12DA5F0", Offset = "0x12D8FF0", VA = "0x1812DA5F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool SQPEKSZMULV
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x2B45740", Offset = "0x2B44140", VA = "0x182B45740", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2B457E0", Offset = "0x2B441E0", VA = "0x182B457E0")]
		public UIPLABHYMDB([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class NRMFTPOCNNV : FZTDTHLGFIN<SJTUWKSMSLH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class NUZQSTJOHMA : SJTUWKSMSLH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly NUZQSTJOHMA GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool FZGAKVDAFDU
			{
				[Cpp2IlInjected.Token(Token = "0x6000760")]
				[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2B42050", Offset = "0x2B40A50", VA = "0x182B42050", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			public void HZWJVHCTYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public NUZQSTJOHMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly NRMFTPOCNNV GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private NRMFTPOCNNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2B41F90", Offset = "0x2B40990", VA = "0x182B41F90", Slot = "4")]
		public SJTUWKSMSLH MYFQREYXOBW()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class HADKPPFWQVZ<a, b> : IDisposable, QJXQIKIKVWS where a : notnull where b : notnull, ICMRWMUYLUV.EXZIFHHHFWB<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly b BJEOXILCYDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly a QNEDICCFGWK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<QOLQCAXXJSV> RUKDXKNBBVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QOLQCAXXJSV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x6504420", Offset = "0x6502E20", VA = "0x186504420")]
		public HADKPPFWQVZ(b a, a b, Id32<QOLQCAXXJSV> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x6502280", Offset = "0x6500C80", VA = "0x186502280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x6503F80", Offset = "0x6502980", VA = "0x186503F80")]
		public Id32<KXSFMFRUWWC> ZBVJWZPVWHZ([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<KXSFMFRUWWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x6502A90", Offset = "0x6501490", VA = "0x186502A90", Slot = "6")]
		public void KQXYXULFOVC(Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x6503770", Offset = "0x6502170", VA = "0x186503770", Slot = "7")]
		public void XXMFVZJQNPM(Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x6502AD0", Offset = "0x65014D0", VA = "0x186502AD0", Slot = "8")]
		public void RJCLTCXTDMX(Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x6503250", Offset = "0x6501C50", VA = "0x186503250", Slot = "10")]
		public void SQTNMTCQIDC(Id32<KXSFMFRUWWC> objectId, Id32<QOLQCAXXJSV> clientId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x6503FE0", Offset = "0x65029E0", VA = "0x186503FE0", Slot = "9")]
		public void ZNDLLTQLNZM(Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x6503730", Offset = "0x6502130", VA = "0x186503730", Slot = "11")]
		public void XAELVQEHYMI(Id32<KXSFMFRUWWC> objectId, VJPPLTLUTFR? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x6503C40", Offset = "0x6502640", VA = "0x186503C40", Slot = "12")]
		public Id32<QOLQCAXXJSV> YHRZAFEFSDN(Id32<KXSFMFRUWWC> objectId)
		{
			return default(Id32<QOLQCAXXJSV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x6502560", Offset = "0x6500F60", VA = "0x186502560", Slot = "13")]
		public Id32<GAVLBTBZLWC> JZGONJCZZPL(Id32<KXSFMFRUWWC> objectId, string a, object b, bool c, ULTBGYHPOHE d, JAUKFLYXGQW e)
		{
			return default(Id32<GAVLBTBZLWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x6503210", Offset = "0x6501C10", VA = "0x186503210", Slot = "14")]
		public void RWDRTNORWZR(Id32<GAVLBTBZLWC> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x6502510", Offset = "0x6500F10", VA = "0x186502510", Slot = "15")]
		public void GRKOXTHEBXB(Id32<GAVLBTBZLWC> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class ICMRWMUYLUV
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface EXZIFHHHFWB<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void QHEAOUFKBDH(a a, Id32<QOLQCAXXJSV> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<QOLQCAXXJSV>? WEMAGWIUWFI(a a);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<KXSFMFRUWWC> ZBVJWZPVWHZ(a a, Id32<QOLQCAXXJSV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void KQXYXULFOVC(a a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void XXMFVZJQNPM(a a, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SQTNMTCQIDC(a a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void ZNDLLTQLNZM(a a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void XAELVQEHYMI(a a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, VJPPLTLUTFR? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<QOLQCAXXJSV>? YHRZAFEFSDN(a a, Id32<KXSFMFRUWWC> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<GAVLBTBZLWC> JZGONJCZZPL(a a, Id32<QOLQCAXXJSV> clientId, string b, object c, ULTBGYHPOHE d, JAUKFLYXGQW e);

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void RWDRTNORWZR(a a, Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void GRKOXTHEBXB(a a, Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class VXNPJFVOJFX
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly HashSet<Id32<KXSFMFRUWWC>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAId32Field<GAVLBTBZLWC, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public readonly Dictionary<Id32<GAVLBTBZLWC>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<GAVLBTBZLWC>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public SOAField<KXSFMFRUWWC, VJPPLTLUTFR?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2B41C30", Offset = "0x2B40630", VA = "0x182B41C30")]
			private MockCV2DynamicNetSys(HashSet<Id32<KXSFMFRUWWC>> authorityOf, [In] SOAId32Field<GAVLBTBZLWC, MockCV2SyncField> syncFields, Dictionary<Id32<GAVLBTBZLWC>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<GAVLBTBZLWC>> mockSyncFieldToSyncField, [In] SOAField<KXSFMFRUWWC, VJPPLTLUTFR?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2B41A70", Offset = "0x2B40470", VA = "0x182B41A70")]
			public static MockCV2DynamicNetSys New()
			{
				return default(MockCV2DynamicNetSys);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private struct MockCV2ObjectShared
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public Id32<QOLQCAXXJSV>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2B41CD0", Offset = "0x2B406D0", VA = "0x182B41CD0")]
			public MockCV2ObjectShared(Id32<QOLQCAXXJSV> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public JAUKFLYXGQW SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public ULTBGYHPOHE SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
			internal MockCV2SyncField(JAUKFLYXGQW syncField, ULTBGYHPOHE syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x2B41DF0", Offset = "0x2B407F0", VA = "0x182B41DF0")]
			public static MockCV2SyncField New(JAUKFLYXGQW syncField, ULTBGYHPOHE syncFieldChangeHandler)
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
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public object Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public int Uses;

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x2B41DA0", Offset = "0x2B407A0", VA = "0x182B41DA0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2B41D50", Offset = "0x2B40750", VA = "0x182B41D50")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<KXSFMFRUWWC, MockCV2ObjectShared> AJXONREMRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<KXSFMFRUWWC>> DFMMTILDITW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> OXCPNJQONWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> FNZMLYDDTRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private SOAField<QOLQCAXXJSV, MockCV2DynamicNetSys> AGHSJNYKMIG;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<KXSFMFRUWWC>? WTNSUQYWTXM
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xDE3320", Offset = "0xDE1D20", VA = "0x180DE3320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x12B3790", Offset = "0x12B2190", VA = "0x1812B3790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2B45F40", Offset = "0x2B44940", VA = "0x182B45F40")]
		public void Destroy([In] SOAId32<QOLQCAXXJSV> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2B45AE0", Offset = "0x2B444E0", VA = "0x182B45AE0")]
		public void CWSGNZHWRLF(Id32<QOLQCAXXJSV> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2B467D0", Offset = "0x2B451D0", VA = "0x182B467D0")]
		public void QHEAOUFKBDH(Id32<QOLQCAXXJSV> clientId, Id32<QOLQCAXXJSV>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2B470E0", Offset = "0x2B45AE0", VA = "0x182B470E0")]
		public Id32<KXSFMFRUWWC> ZBVJWZPVWHZ(Id32<QOLQCAXXJSV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<QOLQCAXXJSV> clientIds)
		{
			return default(Id32<KXSFMFRUWWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x2B464F0", Offset = "0x2B44EF0", VA = "0x182B464F0")]
		public Id32<GAVLBTBZLWC> JZGONJCZZPL(Id32<QOLQCAXXJSV> clientId, string a, object b, ULTBGYHPOHE c, JAUKFLYXGQW d)
		{
			return default(Id32<GAVLBTBZLWC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x2B46B20", Offset = "0x2B45520", VA = "0x182B46B20")]
		public void RWDRTNORWZR(Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2B46DB0", Offset = "0x2B457B0", VA = "0x182B46DB0")]
		public Id32<KXSFMFRUWWC>? TJJJWFWYALU([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2B46750", Offset = "0x2B45150", VA = "0x182B46750")]
		public void KQXYXULFOVC([In] SOAId32<QOLQCAXXJSV> clientIds, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2B46F50", Offset = "0x2B45950", VA = "0x182B46F50")]
		public void XXMFVZJQNPM(Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2B46CB0", Offset = "0x2B456B0", VA = "0x182B46CB0")]
		public void SQTNMTCQIDC(Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2B474F0", Offset = "0x2B45EF0", VA = "0x182B474F0")]
		public void ZNDLLTQLNZM([In] SOAId32<QOLQCAXXJSV> clientIds, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2B46E80", Offset = "0x2B45880", VA = "0x182B46E80")]
		public void XAELVQEHYMI(Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, VJPPLTLUTFR? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2B47090", Offset = "0x2B45A90", VA = "0x182B47090")]
		public Id32<QOLQCAXXJSV>? YHRZAFEFSDN(Id32<KXSFMFRUWWC> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2B46180", Offset = "0x2B44B80", VA = "0x182B46180")]
		public void GRKOXTHEBXB([In] SOAId32<QOLQCAXXJSV> clientIds, Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2B47670", Offset = "0x2B46070", VA = "0x182B47670")]
		public VXNPJFVOJFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class XWTOTMQVXLS
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x2B47810", Offset = "0x2B46210", VA = "0x182B47810")]
		public static void Destroy(this VXNPJFVOJFX.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class YHASUAUMSUG : GSDWEVUUWEW.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static YHASUAUMSUG LSIKWFBLHTZ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate RNZCITCZFQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate ZLYQFMGAJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public YHASUAUMSUG(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class ZIWGSIEKNOO : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : CACFZSSVVJB.QHUWUHZIAAI<JGWKKBUFZYH, ZIWGSIEKNOO>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public AsyncTaskMethodBuilder<Result<object, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public ZIWGSIEKNOO root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public Id32<QOLQCAXXJSV> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public JGWKKBUFZYH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0x2B44710", Offset = "0x2B43110", VA = "0x182B44710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0x2B44950", Offset = "0x2B43350", VA = "0x182B44950", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
			public int AMZRAALQQCS(ZIWGSIEKNOO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2B42660", Offset = "0x2B41060", VA = "0x182B42660", Slot = "5")]
			public int WOYOVDRSFGG(ZIWGSIEKNOO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B42640", Offset = "0x2B41040", VA = "0x182B42640", Slot = "6")]
			public int RZUZNWBZXRT(ZIWGSIEKNOO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2B42480", Offset = "0x2B40E80", VA = "0x182B42480", Slot = "7")]
			public int CMWKWEPXYAF(ZIWGSIEKNOO a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B425F0", Offset = "0x2B40FF0", VA = "0x182B425F0", Slot = "8")]
			public void PZDVVTGVBBS(ZIWGSIEKNOO a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "9")]
			public bool HTAFTXVFYIF(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> actorId, JGWKKBUFZYH[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "10")]
			public bool JJICXKGUYEX(ZIWGSIEKNOO a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2B424A0", Offset = "0x2B40EA0", VA = "0x182B424A0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> senderId, JGWKKBUFZYH b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : CACFZSSVVJB.EXOUKTTMMZJ<ActionDeps, LLXPXHNGEHC.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps TSKMQTSYGXD
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public LLXPXHNGEHC.StaticNetSysReceiverDeps DULRKHWZBMG
			{
				[Cpp2IlInjected.Token(Token = "0x60007AD")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "5")]
				get
				{
					return default(LLXPXHNGEHC.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps ABHRITSRZDR
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : SDZTLNETUVH.EXZIFHHHFWB<ZIWGSIEKNOO>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public ZIWGSIEKNOO root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public Id32<QOLQCAXXJSV> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public JGWKKBUFZYH action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0x2B443F0", Offset = "0x2B42DF0", VA = "0x182B443F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007B1")]
				[Cpp2IlInjected.Address(RVA = "0x2B446A0", Offset = "0x2B430A0", VA = "0x182B446A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x2B41E30", Offset = "0x2B40830", VA = "0x182B41E30", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, JGWKKBUFZYH b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : ICMRWMUYLUV.EXZIFHHHFWB<ZIWGSIEKNOO>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2B41530", Offset = "0x2B3FF30", VA = "0x182B41530", Slot = "4")]
			public void QHEAOUFKBDH(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xF8B8A0", Offset = "0xF8A2A0", VA = "0x180F8B8A0", Slot = "5")]
			public Id32<QOLQCAXXJSV>? WEMAGWIUWFI(ZIWGSIEKNOO a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2B41700", Offset = "0x2B40100", VA = "0x182B41700")]
			public Id32<KXSFMFRUWWC> ZBVJWZPVWHZ(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<KXSFMFRUWWC>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2B414A0", Offset = "0x2B3FEA0", VA = "0x182B414A0", Slot = "7")]
			public void KQXYXULFOVC(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B41880", Offset = "0x2B40280", VA = "0x182B41880", Slot = "8")]
			public void XXMFVZJQNPM(ZIWGSIEKNOO a, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2B41760", Offset = "0x2B40160", VA = "0x182B41760", Slot = "9")]
			public void SQTNMTCQIDC(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2B41A40", Offset = "0x2B40440", VA = "0x182B41A40", Slot = "10")]
			public void ZNDLLTQLNZM(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, BEONJKLMCWR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B417A0", Offset = "0x2B401A0", VA = "0x182B417A0", Slot = "11")]
			public void XAELVQEHYMI(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<KXSFMFRUWWC> objectId, VJPPLTLUTFR? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2B419E0", Offset = "0x2B403E0", VA = "0x182B419E0", Slot = "12")]
			public Id32<QOLQCAXXJSV>? YHRZAFEFSDN(ZIWGSIEKNOO a, Id32<KXSFMFRUWWC> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B41440", Offset = "0x2B3FE40", VA = "0x182B41440", Slot = "13")]
			public Id32<GAVLBTBZLWC> JZGONJCZZPL(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, string b, object c, ULTBGYHPOHE d, JAUKFLYXGQW e)
			{
				return default(Id32<GAVLBTBZLWC>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B41560", Offset = "0x2B3FF60", VA = "0x182B41560", Slot = "14")]
			public void RWDRTNORWZR(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2B41410", Offset = "0x2B3FE10", VA = "0x182B41410", Slot = "15")]
			public void GRKOXTHEBXB(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> clientId, Id32<GAVLBTBZLWC> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2B41700", Offset = "0x2B40100", VA = "0x182B41700", Slot = "6")]
			private Id32<KXSFMFRUWWC> SHNMFLWFPJX(ZIWGSIEKNOO a, Id32<QOLQCAXXJSV> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<KXSFMFRUWWC>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private struct <RetainClient>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public ZIWGSIEKNOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public Id32<KXSFMFRUWWC>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public ADMWIPYDBOF deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Id32<QOLQCAXXJSV> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private OHLNKQHDPWD<ZIWGSIEKNOO, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private HADKPPFWQVZ<ZIWGSIEKNOO, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private LLXPXHNGEHC <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x2B43D30", Offset = "0x2B42730", VA = "0x182B43D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0x2B44380", Offset = "0x2B42D80", VA = "0x182B44380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly NTEHWETUNNP<JGWKKBUFZYH, None, LLXPXHNGEHC, ActionDeps, LLXPXHNGEHC.StaticNetSysReceiverDeps, RootDeps, ZIWGSIEKNOO, Deps> KJNVGSEBMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly VXNPJFVOJFX TTTBYHRFKVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAId32<QOLQCAXXJSV> SGKZBCHNCNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private SOAField<QOLQCAXXJSV, None> AGHSJNYKMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private SOAField<QOLQCAXXJSV, LLXPXHNGEHC> LZDYGDSPVSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Id32<QOLQCAXXJSV>? ABZZGNJOTJJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate GTROAEBUUPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B60", Offset = "0xD10560", VA = "0x180D11B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2B48120", Offset = "0x2B46B20", VA = "0x182B48120")]
		public ZIWGSIEKNOO(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x2B47BE0", Offset = "0x2B465E0", VA = "0x182B47BE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2B47A60", Offset = "0x2B46460", VA = "0x182B47A60")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> CWSGNZHWRLF(ADMWIPYDBOF a, RegistryV2 b, Id32<KXSFMFRUWWC>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B47DB0", Offset = "0x2B467B0", VA = "0x182B47DB0")]
		private void QHEAOUFKBDH(Id32<QOLQCAXXJSV> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B48040", Offset = "0x2B46A40", VA = "0x182B48040")]
		[CompilerGenerated]
		private Id32<KXSFMFRUWWC>? TQHXTSSXIVX([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class DAVEJSZJSTV : CCKWHATKPBN.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<JIWOOULRLNI> DeserializeCircuitsJunctionAsyncDelegate(LLXPXHNGEHC circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder<JIWOOULRLNI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public DAVEJSZJSTV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public LLXPXHNGEHC circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			private TaskAwaiter<JIWOOULRLNI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x2B42A20", Offset = "0x2B41420", VA = "0x182B42A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x2B42C20", Offset = "0x2B41620", VA = "0x182B42C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate IPSIZQQMKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly LifecycleDidInitializeDelegate? TWYFMBYNTJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly LifecycleWillDestroyDelegate? RKNNLDGFTSP;

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B40240", Offset = "0x2B3EC40", VA = "0x182B40240", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<JIWOOULRLNI> HUGUCLXYAZV(LLXPXHNGEHC a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
		public void ORRSOQRQXDD(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x1020FA0", Offset = "0x101F9A0", VA = "0x181020FA0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x10B52C0", Offset = "0x10B3CC0", VA = "0x1810B52C0", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B403B0", Offset = "0x2B3EDB0", VA = "0x182B403B0")]
		public DAVEJSZJSTV([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ZMLNITREJWX : QMPJCTMUYTR.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate NGVEIXANPDZ GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<QQTMRMGIVHL> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<OLWPCSTJAJP> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<QMPJCTMUYTR.VAEKADQIRNQ.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate Task<StaticCircuitsConfig> GetStaticCircuitsConfigAsyncDelegate(CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private struct <GetCircuitGraphToolMappingAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public AsyncTaskMethodBuilder<QMPJCTMUYTR.VAEKADQIRNQ.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<QMPJCTMUYTR.VAEKADQIRNQ.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2B42C90", Offset = "0x2B41690", VA = "0x182B42C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x2B42E80", Offset = "0x2B41880", VA = "0x182B42E80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public AsyncTaskMethodBuilder<OLWPCSTJAJP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private TaskAwaiter<OLWPCSTJAJP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2B42EF0", Offset = "0x2B418F0", VA = "0x182B42EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2B430E0", Offset = "0x2B41AE0", VA = "0x182B430E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public AsyncTaskMethodBuilder<QQTMRMGIVHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private TaskAwaiter<QQTMRMGIVHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x2B43150", Offset = "0x2B41B50", VA = "0x182B43150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2B43340", Offset = "0x2B41D40", VA = "0x182B43340", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AsyncTaskMethodBuilder<CircuitRootData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2B433B0", Offset = "0x2B41DB0", VA = "0x182B433B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B435A0", Offset = "0x2B41FA0", VA = "0x182B435A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AsyncTaskMethodBuilder<StaticCircuitsConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2B43610", Offset = "0x2B42010", VA = "0x182B43610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2B43800", Offset = "0x2B42200", VA = "0x182B43800", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public AsyncTaskMethodBuilder<SuperRoomData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public ZMLNITREJWX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2B43870", Offset = "0x2B42270", VA = "0x182B43870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x2B43A60", Offset = "0x2B42460", VA = "0x182B43A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetCV2DependenciesDelegate TYMXDPUWRQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomDataAsyncDelegate IMYDWTMZOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetSuperRoomDataAsyncDelegate XSPHOYTHNWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetRoomAssetDataAsyncDelegate PMWFSNDVCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetPlayerSaveDataAsyncDelegate MTWQRFLHVDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate EWLFZQPOKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private readonly GetStaticCircuitsConfigAsyncDelegate GQNWNJHLOIZ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NGVEIXANPDZ NGVEIXANPDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x12DA5F0", Offset = "0x12D8FF0", VA = "0x1812DA5F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B487B0", Offset = "0x2B471B0", VA = "0x182B487B0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> IHSEPREMFWI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B48480", Offset = "0x2B46E80", VA = "0x182B48480", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> DLQHZUVIOOD(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B489D0", Offset = "0x2B473D0", VA = "0x182B489D0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<QQTMRMGIVHL> XYHFQGQTOYA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B488C0", Offset = "0x2B472C0", VA = "0x182B488C0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<OLWPCSTJAJP> RDBPHSTCAJH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B486A0", Offset = "0x2B470A0", VA = "0x182B486A0", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<QMPJCTMUYTR.VAEKADQIRNQ.CircuitGraphToolMapping> GTLZUYMLGFU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B48590", Offset = "0x2B46F90", VA = "0x182B48590", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> EHKSOMSWIFT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B48AE0", Offset = "0x2B474E0", VA = "0x182B48AE0")]
		public ZMLNITREJWX(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class UHEUUVCMDNR : CV2Request.VAEKADQIRNQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CV2Request.VAEKADQIRNQ GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly GetCanSendRequestsDelegate NKCPEGOBONN;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public UHEUUVCMDNR(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x12DA5F0", Offset = "0x12D8FF0", VA = "0x1812DA5F0", Slot = "4")]
		public bool BQHARXENRAL()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class HEKFUQKHLOA : XXFEIMFXUFV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, SEZYOHJZPUT> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly TryReportErrToUserDelegate VDYICWODTIR;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0")]
		public bool IWNMYVVYEFD([In] Result<None, SEZYOHJZPUT> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2B40CF0", Offset = "0x2B3F6F0", VA = "0x182B40CF0")]
		public HEKFUQKHLOA([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0", Slot = "4")]
		private bool NCIAUDPIQTU([In] Result<None, SEZYOHJZPUT> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class PLFWDSENJOF : UHFIXPZEGDI
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate XEQZGTZPMCK CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly PLFWDSENJOF GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly CurrentExecParamsDelegate? VIYTNLFRKVZ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public XEQZGTZPMCK OUWBNJXCEXD
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x12DA5F0", Offset = "0x12D8FF0", VA = "0x1812DA5F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public PLFWDSENJOF([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class TZNXPFOAZYR : VILOZUKICQY
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly VILOZUKICQY GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly GetGameColorFromIdDelegate DUZGWZTEMSJ;

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0", Slot = "4")]
		public CircuitsColor SUQDKOCKJGZ(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B42870", Offset = "0x2B41270", VA = "0x182B42870")]
		public TZNXPFOAZYR([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class GVHEVPHANRH : BFKKVPEWDDK
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public delegate Task<bool> IsStringPureAsyncDelegate(string value, string context);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private struct <IsStringPureAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public GVHEVPHANRH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x2B43AD0", Offset = "0x2B424D0", VA = "0x182B43AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2B43CC0", Offset = "0x2B426C0", VA = "0x182B43CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly IsStringPureAsyncDelegate ELGMZOBXBBO;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2B40940", Offset = "0x2B3F340", VA = "0x182B40940", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> EKXIVNPXIAG(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2B40A80", Offset = "0x2B3F480", VA = "0x182B40A80")]
		public GVHEVPHANRH([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class DDOYWDIOYKH : SULRVJJWMBY
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate YGCNPLXPMIO? GetNodeVisualizationConfigDelegate([In] Id128<MIMXYJWAARO> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly SULRVJJWMBY GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly GetNodeVisualizationConfigDelegate UTUJSJUNRNR;

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0")]
		public YGCNPLXPMIO? JNYGLPFDSYP([In] Id128<MIMXYJWAARO> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2B40640", Offset = "0x2B3F040", VA = "0x182B40640")]
		public DDOYWDIOYKH([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x2B405A0", Offset = "0x2B3EFA0", VA = "0x182B405A0", Slot = "4")]
		private YGCNPLXPMIO JIALYSDYFBL([In] Id128<MIMXYJWAARO> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class INZUWJYTHVI : XLCRJVDDJGZ
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2B40EB0", Offset = "0x2B3F8B0", VA = "0x182B40EB0", Slot = "4")]
		public KWTALZZMCKC AKGJYGLPFFQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public INZUWJYTHVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class REWKKKVBXXE : ADOZTPJQCJZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, bool> XNFLQIQDDRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, float> ZKVASOUDDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, double> DKZEUCQZOUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, int> AQXMQRVCAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, long> SQIELTUZLBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, string> IZEPISVPIEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private readonly Dictionary<string, uint> CYQCBJFDWMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private readonly Dictionary<string, ulong> VTEQXFHHTMQ;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2B42170", Offset = "0x2B40B70", VA = "0x182B42170", Slot = "4")]
		public bool? XOAGFSWMMMP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2B42210", Offset = "0x2B40C10", VA = "0x182B42210")]
		public REWKKKVBXXE()
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
