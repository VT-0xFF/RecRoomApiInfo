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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A6E2B0", Offset = "0x2A6D0B0", VA = "0x182A6E2B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		internal sealed class MCIEETVCPZH : ICIPOMWZVOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MCIEETVCPZH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440", Slot = "4")]
			public ICIPOMWZVOI HSRBOZZXENY(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440", Slot = "5")]
			public ICIPOMWZVOI YSZJSJNVAGF(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440", Slot = "6")]
			public ICIPOMWZVOI EYCVNLMWIRP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			public void WSFNWRHTUQM()
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
	public static class YOOOKBYVHZS
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public YSQLFCEEYAV TQRUALUTMLI;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A71750", Offset = "0x2A70550", VA = "0x182A71750")]
			internal KLWLFKHUOPD ZKLDXSWWEXX(GetNetworkObjectDelegate a)
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
			public GMJPGHKCHRR dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public YSDFEASZWFK network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2A6F3E0", Offset = "0x2A6E1E0", VA = "0x182A6F3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FA80", Offset = "0x2A6E880", VA = "0x182A6FA80", Slot = "5")]
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
			public YSDFEASZWFK network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GMJPGHKCHRR dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EA8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<DMDLWDYEPPG>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private SQESMBBMMXQ <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2A6FAF0", Offset = "0x2A6E8F0", VA = "0x182A6FAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A70080", Offset = "0x2A6EE80", VA = "0x182A70080", Slot = "5")]
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
			public YSQLFCEEYAV roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2A700F0", Offset = "0x2A6EEF0", VA = "0x182A700F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A70600", Offset = "0x2A6F400", VA = "0x182A70600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A72EF0", Offset = "0x2A71CF0", VA = "0x182A72EF0")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? TCSYCOKLETV([Optional] YSQLFCEEYAV? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A72990", Offset = "0x2A71790", VA = "0x182A72990")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> BYYYWWJQADC(YSDFEASZWFK a, [Optional] GMJPGHKCHRR? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A72B10", Offset = "0x2A71910", VA = "0x182A72B10")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> BYYYWWJQADC(YSDFEASZWFK a, GMJPGHKCHRR b, RegistryV2 c, Id32<DMDLWDYEPPG>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A72DA0", Offset = "0x2A71BA0", VA = "0x182A72DA0")]
		public static (RuntimeFnRegistry, RuntimeFns) PAANFKFTXEO()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A72CA0", Offset = "0x2A71AA0", VA = "0x182A72CA0")]
		public static (ExternalFnRegistry, ExternalFns) JLRFUXGFGPR()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A72E70", Offset = "0x2A71C70", VA = "0x182A72E70")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static YSDFEASZWFK PLFZWIXMFQI(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class WFHISLNQYNO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate KLWLFKHUOPD CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public WFHISLNQYNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2A6EFF0", Offset = "0x2A6DDF0", VA = "0x182A6EFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A6F370", Offset = "0x2A6E170", VA = "0x182A6F370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly YSDFEASZWFK UGNBCYHSDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? UGBYEHBZNPY;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		private WFHISLNQYNO(YSDFEASZWFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A72280", Offset = "0x2A71080", VA = "0x182A72280")]
		public static WFHISLNQYNO FXMFIGIXULC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A72330", Offset = "0x2A71130", VA = "0x182A72330")]
		public WFHISLNQYNO QFLFDGIOSSN(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A72350", Offset = "0x2A71150", VA = "0x182A72350")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> WSFNWRHTUQM()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class VLACOQSJXWW : SQESMBBMMXQ.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate AYIPZYLYXPE NewCircuitsLifecycleDelegate(LPFVMTQVGRX.ZLOMSCLYJNW deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(SQESMBBMMXQ circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(SQESMBBMMXQ circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate FCSNGBVOWWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate MCTEEVTDVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate JVAGPQIYORY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate MGMMWVZWCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate BSMCDFOFUCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate NLTGKQTGAGD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int QJFIYCRSYNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BCBF0", VA = "0x1812BDDF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A71990", Offset = "0x2A70790", VA = "0x182A71990", Slot = "6")]
		public void LBFWZBIRKUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A719C0", Offset = "0x2A707C0", VA = "0x182A719C0", Slot = "7")]
		public void XLBIPLINQXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A719F0", Offset = "0x2A707F0", VA = "0x182A719F0", Slot = "5")]
		public AYIPZYLYXPE YFVRDXGDPHH(LPFVMTQVGRX.ZLOMSCLYJNW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF27500", Offset = "0xF26300", VA = "0x180F27500", Slot = "8")]
		public void OXMGBAFQAVM(SQESMBBMMXQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF27410", Offset = "0xF26210", VA = "0x180F27410", Slot = "9")]
		public void QSCVNXFRFIP(SQESMBBMMXQ a, TWGQWHZWPAR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A71A20", Offset = "0x2A70820", VA = "0x182A71A20")]
		public VLACOQSJXWW([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly CPMALVBEJKV<YSDFEASZWFK, YSDFEASZWFK.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly IBRXNUHZXBT<YSDFEASZWFK, YSDFEASZWFK.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly SQESMBBMMXQ CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<YCAINYDNLEL> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly YSDFEASZWFK Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2A695B0", Offset = "0x2A683B0", VA = "0x182A695B0")]
		public EVCreationResult(CPMALVBEJKV<YSDFEASZWFK, YSDFEASZWFK.MockStaticNetSysDeps> staticNetSys, IBRXNUHZXBT<YSDFEASZWFK, YSDFEASZWFK.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, SQESMBBMMXQ circuitsManager, Id32<YCAINYDNLEL> clientId, YSDFEASZWFK network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly SQESMBBMMXQ _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 NJAWOJNILDG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A6E280", Offset = "0x2A6D080", VA = "0x182A6E280")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request OBLLNKKDQTC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A6E0F0", Offset = "0x2A6CEF0", VA = "0x182A6E0F0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QCQTPBNJHXP? EPWSAQFNDSA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A6E120", Offset = "0x2A6CF20", VA = "0x182A6E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public LCNHFLDFADN? VHVTYYKGQWO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2A6E220", Offset = "0x2A6D020", VA = "0x182A6E220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		internal LimitedCircuits(SQESMBBMMXQ circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class ADSSXHDWZNG : GMJPGHKCHRR
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class VBZDFZLFUJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public KLWLFKHUOPD WEUBENTSRAN;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VBZDFZLFUJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			internal KLWLFKHUOPD XDKEXLOFJBZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LPFVMTQVGRX.ZLOMSCLYJNW CGAUFAQGAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SQESMBBMMXQ.ZLOMSCLYJNW ASIJCYYYTEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public TJDAFASHBMR.ZLOMSCLYJNW GKLYXYZYSVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ> BNOHTPALDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ZLOMSCLYJNW TFCUKQZSBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EMOXSDWCFKN TWTJQHHARIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public VADHWBRYBMQ BNJTVCTNMZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OBAYIOUBMIS WHTCTRONSTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HJJZQHCBFAG CKWNRKHWSIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CNVYILPYZTW PYMUGAXKGMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A66510", Offset = "0x2A65310", VA = "0x182A66510")]
		private ADSSXHDWZNG(LPFVMTQVGRX.ZLOMSCLYJNW a, SQESMBBMMXQ.ZLOMSCLYJNW b, TJDAFASHBMR.ZLOMSCLYJNW c, JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ> d, CV2Request.ZLOMSCLYJNW e, EMOXSDWCFKN f, VADHWBRYBMQ g, OBAYIOUBMIS h, HJJZQHCBFAG i, CNVYILPYZTW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A661C0", Offset = "0x2A64FC0", VA = "0x182A661C0")]
		public static ADSSXHDWZNG? NZMNYIYPJGL(TJDAFASHBMR.ZLOMSCLYJNW cv2RootSysDeps, [Optional] LPFVMTQVGRX.ZLOMSCLYJNW? a, [Optional] SQESMBBMMXQ.ZLOMSCLYJNW? b, [Optional] JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>? reducerDeps, [Optional] CV2Request.ZLOMSCLYJNW? c, [Optional] EMOXSDWCFKN? d, [Optional] VADHWBRYBMQ? e, [Optional] OBAYIOUBMIS? f, [Optional] HJJZQHCBFAG? g, [Optional] CNVYILPYZTW? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2A65DC0", Offset = "0x2A64BC0", VA = "0x182A65DC0")]
		public static ADSSXHDWZNG EXOOZKGYDVH(KLWLFKHUOPD a, [Optional] LPFVMTQVGRX.ZLOMSCLYJNW? circuitsLifecycleDeps, [Optional] SQESMBBMMXQ.ZLOMSCLYJNW? circuitsManagerDeps, [Optional] JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A65F10", Offset = "0x2A64D10", VA = "0x182A65F10")]
		public static ADSSXHDWZNG JPZYYGNJEVT(GetNetworkObjectDelegate a, [Optional] LPFVMTQVGRX.ZLOMSCLYJNW? circuitsLifecycleDeps, [Optional] SQESMBBMMXQ.ZLOMSCLYJNW? circuitsManagerDeps, [Optional] JMDEHFIMFKJ.XZMMFITJJKF<ActionKind, TWGQWHZWPAR, SQESMBBMMXQ>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IBAMUAVPDXL
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate MHNKFWUYKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int EXDWCOOTIXX;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2A667B0", Offset = "0x2A655B0", VA = "0x182A667B0")]
			internal JZUQHNZNXWS PCMFVAVEFSJ(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2A66650", Offset = "0x2A65450", VA = "0x182A66650")]
			internal JZUQHNZNXWS[] PCGYXUBGWHA(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
			internal int AFCUDSEGATA()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CFCMCYVGPQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DynamicEnvironmentNetworkId XMSOQSRXUYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CEXFFSBJGFA YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CFCMCYVGPQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2A66820", Offset = "0x2A65620", VA = "0x182A66820")]
			internal JZUQHNZNXWS HFJLHWYNXOR(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly BWRMFYYLKFG AWKLPVYGCGB;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DDC0", Offset = "0x2A6CBC0", VA = "0x182A6DDC0")]
		public static JZUQHNZNXWS? WGROBVMCPZP(Id32<DMDLWDYEPPG>? networkObject, [Optional] SPNFHBDUGUV.SerializesIntoSavesDelegate? a, [Optional] SPNFHBDUGUV.SerializesIntoInventionsDelegate? b, [Optional] SPNFHBDUGUV.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A010", Offset = "0x2A68E10", VA = "0x182A6A010")]
		public static KLWLFKHUOPD? PCUSIKOLEGY(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] PCBXNHFFHWA? b, [Optional] VEDDNCWIPBI? c, [Optional] TWSRNVOLSJK? d, [Optional] YSQLFCEEYAV? e, int f = 300000, bool g = false, bool h = false, [Optional] VXZPAMFQWGS? i, [Optional] HQKBGNJMNXU? j, [Optional] BEDOFCEUHSR? k, [Optional] ZGSVNOAAFOA? l, [Optional] WDWUPVKMEIB? m, [Optional] ZYBERJGGIGA? n, [Optional] RGYBKVXVHBK.ZLOMSCLYJNW? o, [Optional] EqualsNodeV2.ZLOMSCLYJNW? p, [Optional] AWORASTHAQC? q, [Optional] KLWLFKHUOPD.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] KLWLFKHUOPD.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] KLWLFKHUOPD.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] KLWLFKHUOPD.GetLocalRoomIdDelegate? u, [Optional] KLWLFKHUOPD.GetLocalSubroomIdDelegate? v, [Optional] KLWLFKHUOPD.GetSubroomIdsForLocalRoomDelegate? w, [Optional] KLWLFKHUOPD.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] KLWLFKHUOPD.SaveRoomOnPlayerBehalfDelegate? z, [Optional] KLWLFKHUOPD.ReportCloudDataLedgerChangedDelegate? ba, [Optional] KLWLFKHUOPD.GetColorNameByIdDelegate? bb, [Optional] KLWLFKHUOPD.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] KLWLFKHUOPD.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] KLWLFKHUOPD.GetTaggableNameFromSignalDelegate? be, [Optional] KLWLFKHUOPD.GetAudioNameFromSignalDelegate? bf, [Optional] KLWLFKHUOPD.GetDestinationNameFromSignalDelegate? bg, [Optional] KLWLFKHUOPD.GetPlayerEventNameFromSignalDelegate? bh, [Optional] KLWLFKHUOPD.GetRoomKeyNameFromSignalDelegate? bi, [Optional] KLWLFKHUOPD.GetRewardNameFromSignalDelegate? bj, [Optional] KLWLFKHUOPD.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] KLWLFKHUOPD.ReportPreloadedAudioChangedDelegate? bl, [Optional] KLWLFKHUOPD.ReportRewardDataChangedDelegate? bm, [Optional] KLWLFKHUOPD.GetConsumableNameFromSignalDelegate? bn, [Optional] KLWLFKHUOPD.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] KLWLFKHUOPD.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] KLWLFKHUOPD.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] KLWLFKHUOPD.GetInventoryItemNameFromSignalDelegate? br, [Optional] KLWLFKHUOPD.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] KLWLFKHUOPD.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] KLWLFKHUOPD.GetRoomOfferNameFromSignalDelegate? bu, [Optional] KLWLFKHUOPD.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] KLWLFKHUOPD.GetObjectIdFromCreationObjectDelegate? bw, [Optional] KLWLFKHUOPD.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] KLWLFKHUOPD.GetCostInBytesDelegate? by, [Optional] KLWLFKHUOPD.GetAvatarItemNameFromSignalDelegate? bz, [Optional] KLWLFKHUOPD.PersistenceViewExistsAsReplicatorWithGraphDelegate? ca, [Optional] KLWLFKHUOPD.DownloadCircuitTemplateRootDataDelegate? cb, [Optional] KLWLFKHUOPD.GetDiscoverySectionNameFromSignalDelegate? cc, [Optional] KLWLFKHUOPD.GetStoreItemNameFromSignalDelegate? cd, [Optional] KLWLFKHUOPD.GetBodyPartNameFromSignalDelegate? ce, [Optional] KLWLFKHUOPD.GetDependenciesForGraphInstanceDelegate? cf, [Optional] KLWLFKHUOPD.GetAllDependenciesForEnvironmentDelegate? cg, [Optional] KLWLFKHUOPD.GetPlayerAccountNameFromSignalDelegate? ch, [Optional] KLWLFKHUOPD.GetRecNetImageNameFromSignalDelegate? ci, [Optional] KLWLFKHUOPD.GetRecNetMeshNameFromSignalDelegate? cj, [Optional] KLWLFKHUOPD.IsFunctionValidForAIDelegate? ck, [Optional] KLWLFKHUOPD.GetAIFunctionNameFromSignalDelegate? cl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<DMDLWDYEPPG>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class FXLJKOAXMXE : BEDOFCEUHSR
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly FXLJKOAXMXE GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly GetLocalPlayerDelegate? EOWGSZDOYSV;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A69620", Offset = "0x2A68420", VA = "0x182A69620", Slot = "4")]
		public (DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ) FRZKDLLEPDO(object a)
		{
			return default((DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ, DLUADCWLXSQ));
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A69690", Offset = "0x2A68490", VA = "0x182A69690", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "6")]
		public bool QMJEJQMQHET(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB1F070", Offset = "0xB1DE70", VA = "0x180B1F070", Slot = "7")]
		public string VRCYNZLPIBZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public FXLJKOAXMXE([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class SPNFHBDUGUV : JZUQHNZNXWS
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(SPNFHBDUGUV self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(SPNFHBDUGUV self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(SPNFHBDUGUV self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoSavesDelegate FPCXOFHQYMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoInventionsDelegate BDZWGGLCNWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly CanPublishInInventionsDelegate ANOBJEGEPNA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private YVCSBHMHJZA? JNTJRESPXLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId QGDTYTCSXYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xFDBD80", Offset = "0xFDAB80", VA = "0x180FDBD80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SIIDZKJICRK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A6EB90", Offset = "0x2A6D990", VA = "0x182A6EB90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool VTWWLZJSQYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A6EB60", Offset = "0x2A6D960", VA = "0x182A6EB60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool CVJPMKLNCWG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A6EB30", Offset = "0x2A6D930", VA = "0x182A6EB30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IBCQCAYDOWV? KJFFIPTXTPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<DMDLWDYEPPG>? AYBGBXRAMVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E9E0", Offset = "0x2A6D7E0", VA = "0x182A6E9E0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E490", Offset = "0x2A6D290", VA = "0x182A6E490", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(BWRMFYYLKFG e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10", Slot = "13")]
		public void Bind(YVCSBHMHJZA controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EA80", Offset = "0x2A6D880", VA = "0x182A6EA80")]
		private SPNFHBDUGUV(Id32<DMDLWDYEPPG>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E530", Offset = "0x2A6D330", VA = "0x182A6E530")]
		public static SPNFHBDUGUV? New(Id32<DMDLWDYEPPG>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class YUBULFCMEWZ : VXZPAMFQWGS
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

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly YUBULFCMEWZ GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly RoundToDecimalPlaceDelegate? ZIQTXXVFGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly TruncateToDecimalPlaceDelegate? KPCGIQYBUQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorLerpDelegate? TSRRUVAGVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorInverseLerpDelegate? VMWNZEQQZOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetPositionDelegate? VYFLNUMUVOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetRotationDelegate? LVYEHIFUIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4InverseDelegate? JYCOBQRKWZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4MultiplyDelegate? WPVPWEIXFTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? YHUOJIRIWYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatDotDelegate? QQRTKAQRAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromAngleAxisDelegate? OENKRPWHLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? YLFGRCIJCQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromFromToRotationDelegate? ELGOXEVBUGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromLookRotationDelegate? DJIWULTWCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? CFSNGEYCNIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatInverseDelegate? WXUWLYXBBJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpDelegate? OOLTYCTEUVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpUnclampedDelegate? SAKYMMLZFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseLerpDelegate? UMJQMONVEQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatMultiplyDelegate? DFCVNJZUULR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatNormalizeDelegate? DGBEUCQGSSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateTowardsDelegate? ZZQAKAFHMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateVectorDelegate? UFBVXXQZFQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatSlerpDelegate? PWMOIUNBPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToAngleAxisDelegate? ZFLQYBRQRDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToEulerAnglesDelegate? PDXJSWIYGRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3AddDelegate? CQESPUCUQWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? SWCXSJGEYTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? CROGFJSMEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3CrossDelegate? NJWOTDMKARP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3DotDelegate? RUACPOUZNWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3AngleDelegate? URPEIDJUCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3GetMagnitudeDelegate? HNOAYWAGWJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpDelegate? MWQEMOYNSNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpUnclampedDelegate? KUAZVMAZGTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3InverseLerpDelegate? LVUEEKDBRDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3MoveTowardsDelegate? AHYWTRXVCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NegateDelegate? TBPMWZLFSBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NormalizeDelegate? FQTXXKKDIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectDelegate? VGDQPUTVVWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? GAVJLNWIAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ScaleDelegate? LJHADQIOHQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SmoothDampDelegate? SKEGGOALYRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SubtractDelegate? PPESSKNKGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SlerpDelegate? VLDHIBLSEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3TransformDelegate? LLXVIKPCAXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3InverseTransformDelegate? GPLABBUMITF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RealtimeSinceStartupDelegate? TMHXCVAXGLE;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A75120", Offset = "0x2A73F20", VA = "0x182A75120")]
		public YUBULFCMEWZ([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A74870", Offset = "0x2A73670", VA = "0x182A74870")]
		public float UCCDETKJDYG([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A74010", Offset = "0x2A72E10", VA = "0x182A74010")]
		public float JUQVMATJQJQ([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A73B20", Offset = "0x2A72920", VA = "0x182A73B20")]
		public CircuitsColor HIJDZVSBZTJ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A73CA0", Offset = "0x2A72AA0", VA = "0x182A73CA0")]
		public float LTDPEPAQQBJ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A74E90", Offset = "0x2A73C90", VA = "0x182A74E90")]
		public CircuitsVec3 YZRPQIITHON([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A73770", Offset = "0x2A72570", VA = "0x182A73770")]
		public CircuitsQuat EHRGUAGXNAU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A73410", Offset = "0x2A72210", VA = "0x182A73410")]
		public CircuitsMtx4x4 CDGHUKYIHQK([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A73A40", Offset = "0x2A72840", VA = "0x182A73A40")]
		public CircuitsMtx4x4 GZNKROCINOO([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A74AF0", Offset = "0x2A738F0", VA = "0x182A74AF0")]
		public CircuitsMtx4x4 VZNYWXPMXRY([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A74140", Offset = "0x2A72F40", VA = "0x182A74140")]
		public float KCFDQHBLWKT([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A738B0", Offset = "0x2A726B0", VA = "0x182A738B0")]
		public CircuitsQuat WHBFPMBIVJA(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A730B0", Offset = "0x2A71EB0", VA = "0x182A730B0")]
		public CircuitsQuat ZWCLCSXYGKR([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A74030", Offset = "0x2A72E30", VA = "0x182A74030")]
		public CircuitsQuat JUZQXASEFAX([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A73B80", Offset = "0x2A72980", VA = "0x182A73B80")]
		public CircuitsQuat KFXGQXJGGZL([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A73150", Offset = "0x2A71F50", VA = "0x182A73150")]
		public CircuitsQuat DPKOHVNWXBW([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A73CD0", Offset = "0x2A72AD0", VA = "0x182A73CD0")]
		public CircuitsQuat IJZEBBZDJLP([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A74DD0", Offset = "0x2A73BD0", VA = "0x182A74DD0")]
		public CircuitsQuat YOZJSFENDCU([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A73F50", Offset = "0x2A72D50", VA = "0x182A73F50")]
		public float JEVNIJSGMKB([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A73D90", Offset = "0x2A72B90", VA = "0x182A73D90")]
		public CircuitsQuat IMHGSWKGPVC([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A746B0", Offset = "0x2A734B0", VA = "0x182A746B0")]
		public CircuitsQuat VSTJJXCRTAX([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A74380", Offset = "0x2A73180", VA = "0x182A74380")]
		public CircuitsQuat MRYXYSRNTXD([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A73560", Offset = "0x2A72360", VA = "0x182A73560")]
		public CircuitsVec3 DJKAYEKGXMY([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A736B0", Offset = "0x2A724B0", VA = "0x182A736B0")]
		public CircuitsQuat TBFOZGQATQA([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A73280", Offset = "0x2A72080", VA = "0x182A73280")]
		public void BIKIFOZYQQF([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A74750", Offset = "0x2A73550", VA = "0x182A74750")]
		public CircuitsVec3 TQPEKKTWLSS([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A74580", Offset = "0x2A73380", VA = "0x182A74580")]
		public CircuitsVec3 TCEQYODKZGL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A73040", Offset = "0x2A71E40", VA = "0x182A73040")]
		public CircuitsVec3 ARPGBCZUBJV([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A742A0", Offset = "0x2A730A0", VA = "0x182A742A0")]
		public CircuitsVec3 MIEXPZOBUPC([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A74310", Offset = "0x2A73110", VA = "0x182A74310")]
		public CircuitsVec3 MJXDJBKCLBK([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A731F0", Offset = "0x2A71FF0", VA = "0x182A731F0")]
		public float AVELTKPOQUH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A73F80", Offset = "0x2A72D80", VA = "0x182A73F80")]
		public float XVAEJEYKEPV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A737C0", Offset = "0x2A725C0", VA = "0x182A737C0")]
		public float EIXBWDGIFXY([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A737E0", Offset = "0x2A725E0", VA = "0x182A737E0")]
		public CircuitsVec3 EPQCJZZTFHP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A73E40", Offset = "0x2A72C40", VA = "0x182A73E40")]
		public CircuitsVec3 ISZOHMOKADG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A73960", Offset = "0x2A72760", VA = "0x182A73960")]
		public float FPNLEKINWEV([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A73C30", Offset = "0x2A72A30", VA = "0x182A73C30")]
		public CircuitsVec3 HLXVIWNQCFN([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A741D0", Offset = "0x2A72FD0", VA = "0x182A741D0")]
		public CircuitsVec3 LIPMIUYQBGS([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A72FE0", Offset = "0x2A71DE0", VA = "0x182A72FE0")]
		public CircuitsVec3 ARDGQRNZJVV([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A74440", Offset = "0x2A73240", VA = "0x182A74440")]
		public CircuitsVec3 MUODATKBNFP([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A735D0", Offset = "0x2A723D0", VA = "0x182A735D0")]
		public CircuitsVec3 DQPNXMEELEW([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A74B60", Offset = "0x2A73960", VA = "0x182A74B60")]
		public CircuitsVec3 WNKCJXVBQWG([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A74BD0", Offset = "0x2A739D0", VA = "0x182A74BD0")]
		public CircuitsVec3 WTMZOPDDYIQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A73FA0", Offset = "0x2A72DA0", VA = "0x182A73FA0")]
		public CircuitsVec3 JMQVYBMLLAQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A73EE0", Offset = "0x2A72CE0", VA = "0x182A73EE0")]
		public CircuitsVec3 JDLSBKXZKDW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A74510", Offset = "0x2A73310", VA = "0x182A74510")]
		public CircuitsVec3 RYYOKVXDONS([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A733A0", Offset = "0x2A721A0", VA = "0x182A733A0")]
		public CircuitsVec3 CCVJJOUPCHK([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A73EB0", Offset = "0x2A72CB0", VA = "0x182A73EB0", Slot = "50")]
		public Task IXRXNIEUNOU(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "51")]
		public void YQVVXDFRDWE([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A74660", Offset = "0x2A73460", VA = "0x182A74660", Slot = "52")]
		public NHOYZCPQYWI TNWBLSZPNQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A739F0", Offset = "0x2A727F0", VA = "0x182A739F0", Slot = "53")]
		public NHOYZCPQYWI GWOBMSOQTFV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A73540", Offset = "0x2A72340", VA = "0x182A73540", Slot = "54")]
		public float DFBNQKMZLER()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A74870", Offset = "0x2A73670", VA = "0x182A74870", Slot = "4")]
		private float UUPRZNDWHFW([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A74010", Offset = "0x2A72E10", VA = "0x182A74010", Slot = "5")]
		private float VIIIXOIWKYY([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A740E0", Offset = "0x2A72EE0", VA = "0x182A740E0", Slot = "6")]
		private CircuitsColor JWTMKNPHYGF([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A73CA0", Offset = "0x2A72AA0", VA = "0x182A73CA0", Slot = "7")]
		private float HURGYSWIIEN([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A73850", Offset = "0x2A72650", VA = "0x182A73850", Slot = "8")]
		private CircuitsVec3 FGADPRFHWJR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A749C0", Offset = "0x2A737C0", VA = "0x182A749C0", Slot = "9")]
		private CircuitsQuat UZCXVFADBJI([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A73480", Offset = "0x2A72280", VA = "0x182A73480", Slot = "10")]
		private CircuitsMtx4x4 CLUGIRYRZPO([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A73990", Offset = "0x2A72790", VA = "0x182A73990", Slot = "11")]
		private CircuitsMtx4x4 GDBZFEHHBII([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A74810", Offset = "0x2A73610", VA = "0x182A74810", Slot = "12")]
		private CircuitsMtx4x4 UBKTNXWNFUE([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A74140", Offset = "0x2A72F40", VA = "0x182A74140", Slot = "13")]
		private float LESSOXVTGSJ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A738B0", Offset = "0x2A726B0", VA = "0x182A738B0", Slot = "14")]
		private CircuitsQuat FJKOXVEURSI(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A730B0", Offset = "0x2A71EB0", VA = "0x182A730B0", Slot = "15")]
		private CircuitsQuat ARTIVBJLTTR([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A74030", Offset = "0x2A72E30", VA = "0x182A74030", Slot = "16")]
		private CircuitsQuat MSYARNSXTOV([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2A73B80", Offset = "0x2A72980", VA = "0x182A73B80", Slot = "17")]
		private CircuitsQuat HJZCQXTZYTN([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2A73150", Offset = "0x2A71F50", VA = "0x182A73150", Slot = "18")]
		private CircuitsQuat ASTIFDQWKZE([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A73CD0", Offset = "0x2A72AD0", VA = "0x182A73CD0", Slot = "19")]
		private CircuitsQuat MZAKLVJMIRB([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2A74DD0", Offset = "0x2A73BD0", VA = "0x182A74DD0", Slot = "20")]
		private CircuitsQuat ZJUJHVYJQSG([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A73F50", Offset = "0x2A72D50", VA = "0x182A73F50", Slot = "21")]
		private float KVUDQAGPZNN([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A73D90", Offset = "0x2A72B90", VA = "0x182A73D90", Slot = "22")]
		private CircuitsQuat IOPLVBGBLUS([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A746B0", Offset = "0x2A734B0", VA = "0x182A746B0", Slot = "23")]
		private CircuitsQuat TQGHUVEPAJL([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A74380", Offset = "0x2A73180", VA = "0x182A74380", Slot = "24")]
		private CircuitsQuat PPLDMEAATNJ([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A74160", Offset = "0x2A72F60", VA = "0x182A74160", Slot = "25")]
		private CircuitsVec3 KMEFVOKQTJM([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A736B0", Offset = "0x2A724B0", VA = "0x182A736B0", Slot = "26")]
		private CircuitsQuat DYZAHPWLBDM([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A73280", Offset = "0x2A72080", VA = "0x182A73280", Slot = "27")]
		private void JEFJLBEFAYH([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A734E0", Offset = "0x2A722E0", VA = "0x182A734E0", Slot = "28")]
		private CircuitsVec3 CVDDQOTCLXO([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2A732C0", Offset = "0x2A720C0", VA = "0x182A732C0", Slot = "29")]
		private CircuitsVec3 BLXTJYYGECN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2A74950", Offset = "0x2A73750", VA = "0x182A74950", Slot = "30")]
		private CircuitsVec3 UVFJZTPEDGR([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A74A80", Offset = "0x2A73880", VA = "0x182A74A80", Slot = "31")]
		private CircuitsVec3 VNPDVRJPKAK([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A745F0", Offset = "0x2A733F0", VA = "0x182A745F0", Slot = "32")]
		private CircuitsVec3 TLCOCRUNGSG([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2A74230", Offset = "0x2A73030", VA = "0x182A74230", Slot = "33")]
		private CircuitsVec3 LXIERCNVAJA([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2A74EF0", Offset = "0x2A73CF0", VA = "0x182A74EF0", Slot = "34")]
		private CircuitsVec3 ZXLEXTXLRDA([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A731F0", Offset = "0x2A71FF0", VA = "0x182A731F0", Slot = "35")]
		private float VZVEALAQSXD([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A73F80", Offset = "0x2A72D80", VA = "0x182A73F80", Slot = "36")]
		private float JMFBRKOHCVX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A737C0", Offset = "0x2A725C0", VA = "0x182A737C0", Slot = "37")]
		private float UCQEELZWCPC([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A73640", Offset = "0x2A72440", VA = "0x182A73640", Slot = "38")]
		private CircuitsVec3 DROFPDMNCZF([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A74D60", Offset = "0x2A73B60", VA = "0x182A74D60", Slot = "39")]
		private CircuitsVec3 YMVFLXXEKYW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A73960", Offset = "0x2A72760", VA = "0x182A73960", Slot = "40")]
		private float RRKIZRSAQMP([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A73AB0", Offset = "0x2A728B0", VA = "0x182A73AB0", Slot = "41")]
		private CircuitsVec3 HAXCHAZLEJT([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A744B0", Offset = "0x2A732B0", VA = "0x182A744B0", Slot = "42")]
		private CircuitsVec3 PAYJGDJPZOU([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A747B0", Offset = "0x2A735B0", VA = "0x182A747B0", Slot = "43")]
		private CircuitsVec3 TWLIWMVASZP([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A74CF0", Offset = "0x2A73AF0", VA = "0x182A74CF0", Slot = "44")]
		private CircuitsVec3 XUDIBGCFMYD([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A74A10", Offset = "0x2A73810", VA = "0x182A74A10", Slot = "45")]
		private CircuitsVec3 VEPVUPOWHZC([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A73210", Offset = "0x2A72010", VA = "0x182A73210", Slot = "46")]
		private CircuitsVec3 BACFIUFRQQY([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A74890", Offset = "0x2A73690", VA = "0x182A74890", Slot = "47")]
		private CircuitsVec3 ULYJSRHBARM([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A74C80", Offset = "0x2A73A80", VA = "0x182A74C80", Slot = "48")]
		private CircuitsVec3 XIGEHHXUQBU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A73330", Offset = "0x2A72130", VA = "0x182A73330", Slot = "49")]
		private CircuitsVec3 BUZCFNBWHKS([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class BOCABMIMYSF : KHACXVHRPFA
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1324960", Offset = "0x1323760", VA = "0x181324960", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool StopEventExecutionAfterSingleFailure
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x209AB00", Offset = "0x2099900", VA = "0x18209AB00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A66600", Offset = "0x2A65400", VA = "0x182A66600")]
		public BOCABMIMYSF(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class HHVCVAFEXLX : HQKBGNJMNXU
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(DUFJLFQSONL e, FOTXYDDGZOY invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly HHVCVAFEXLX GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetCircuitsColorFromColorIndexDelegate? JOZVGFTVNPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? OFEEHBHBJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly InvisibleCollisionSetEnabledDelegate? JELKKCPLSNF;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xDF2D50", Offset = "0xDF1B50", VA = "0x180DF2D50")]
		public HHVCVAFEXLX([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A69AF0", Offset = "0x2A688F0", VA = "0x182A69AF0", Slot = "4")]
		public CircuitsColor YBHQDPQMFOZ(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A69AD0", Offset = "0x2A688D0", VA = "0x182A69AD0")]
		public int KXDKZYWHGRR([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A69AD0", Offset = "0x2A688D0", VA = "0x182A69AD0", Slot = "5")]
		private int SXPFNQBRMYQ([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class XQAYVTBEJTO : MRNHHXVSMOV
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class IKNJFWAJEDT
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid VYGDDYXKXLP
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long YUFPYFZLUYK
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int ZGHTNYKOBDC
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool OXJVJHOIDZL
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x1ADD440", Offset = "0x1ADC240", VA = "0x181ADD440")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool ZWMESXLKZVV
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1ADD430", Offset = "0x1ADC230", VA = "0x181ADD430")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool LIOCARLOXTC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x2A6DE60", Offset = "0x2A6CC60", VA = "0x182A6DE60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A6DE80", Offset = "0x2A6CC80", VA = "0x182A6DE80")]
			public IKNJFWAJEDT(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Dictionary<Id128<KSHTGNRFKHE>, IKNJFWAJEDT> DAMGGPSNGIM;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A72800", Offset = "0x2A71600", VA = "0x182A72800")]
		public bool XZFSSKHGWKN([In] Id128<KSHTGNRFKHE> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A72560", Offset = "0x2A71360", VA = "0x182A72560")]
		public void KBDMXELWWHH([In] Id128<KSHTGNRFKHE> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A726C0", Offset = "0x2A714C0", VA = "0x182A726C0")]
		public void KBDMXELWWHH([In] Id128<KSHTGNRFKHE> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A72440", Offset = "0x2A71240", VA = "0x182A72440")]
		public void BNXJCCVAGPG([In] Id128<KSHTGNRFKHE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A727A0", Offset = "0x2A715A0", VA = "0x182A727A0")]
		public void QDAYKDLEXOL([In] Id128<KSHTGNRFKHE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A72630", Offset = "0x2A71430", VA = "0x182A72630")]
		public bool OXJVJHOIDZL([In] Id128<KSHTGNRFKHE> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A72910", Offset = "0x2A71710", VA = "0x182A72910")]
		public XQAYVTBEJTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A72800", Offset = "0x2A71600", VA = "0x182A72800", Slot = "4")]
		private bool UWUHHAJFHNY([In] Id128<KSHTGNRFKHE> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A72560", Offset = "0x2A71360", VA = "0x182A72560", Slot = "5")]
		private void FQWZXEIDUFA([In] Id128<KSHTGNRFKHE> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A72440", Offset = "0x2A71240", VA = "0x182A72440", Slot = "6")]
		private void ANJOYZMLETN([In] Id128<KSHTGNRFKHE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A727A0", Offset = "0x2A715A0", VA = "0x182A727A0", Slot = "7")]
		private void RRNOARQSFFW([In] Id128<KSHTGNRFKHE> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A72630", Offset = "0x2A71430", VA = "0x182A72630", Slot = "8")]
		private bool JRNQGOZUGUY([In] Id128<KSHTGNRFKHE> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class HMYRNWVFUUH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A69BE0", Offset = "0x2A689E0", VA = "0x182A69BE0")]
		public static LogDeps WRMMXDEFPRG()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class PIPSRMKAKOK : MeshLibrary.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
		public byte[]? QHBGZOLVJIX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void OIKEPLXRYBM(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PIPSRMKAKOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class ENCUDSRVPUJ : PCBXNHFFHWA
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
		public delegate void ConfigureAttachedObjectDelegate(XTCGAQPRURU controlPanel, QDPJHBURBMQ staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<PSZMTIJLKYP> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, IGWAJAWUKJF>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, IGWAJAWUKJF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, IGWAJAWUKJF>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, IGWAJAWUKJF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> task);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <ReportCreationErrorToUserAsyncDefault2>d__132 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public AsyncTaskMethodBuilder<Result<MultiResult, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Task<Result<MultiResult, IGWAJAWUKJF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<Result<MultiResult, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2A70670", Offset = "0x2A6F470", VA = "0x182A70670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2A70930", Offset = "0x2A6F730", VA = "0x182A70930", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AsyncTaskMethodBuilder<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2A709A0", Offset = "0x2A6F7A0", VA = "0x182A709A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2A70C60", Offset = "0x2A6FA60", VA = "0x182A70C60", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncTaskMethodBuilder<Result<None, IGWAJAWUKJF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Task<Result<None, IGWAJAWUKJF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<Result<None, IGWAJAWUKJF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2A70CD0", Offset = "0x2A6FAD0", VA = "0x182A70CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2A70F90", Offset = "0x2A6FD90", VA = "0x182A70F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<string, EnumChoiceData> BAVGERAPTCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<int, string> ALKOATGEPJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<object> IQYCOSUAZVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<Guid> AFKDJCPCZTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CanLocalPlayerCreateCurrencyDelegate CXZNWXBFSBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ShowRoomCurrencyCreationUIDelegate URIUSYWZMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly GetAudioClipOptionsDelegate KSEYFAPIEQW;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly IReadOnlyDictionary<Guid, int> YYXEZQDGGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly GetAudioClipGuidToIndexMapDelegate PCAHYIZCNAC;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly IReadOnlyDictionary<int, Guid> QQIUVJWMUMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAudioClipIndexToGuidMapDelegate BJNIAGHQZLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAllAudioClipOptionsDelegate PUASIBWCSWZ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<Guid, int> UXUCLYPYSSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate GWQKAWVPCXN;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly IReadOnlyDictionary<int, Guid> KJFCGXUJKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate QQTRXAPCOOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly PlayAudioPreviewDelegate VLWVHWELKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly StopAudioPreviewDelegate NNMNTTVKLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly SubscriptionIsActiveDelegate EQDGJHGCIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate PERVJQQPVHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Dictionary<string, EnumChoiceData> JPSRWVULATF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly ShowQuickChatEditMenuDelegate HRNBNXRAWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ConfigureAttachedObjectDelegate XUDPUUFYLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly DisplayInvalidNameErrorMessageDelegate GOYBZZWSHFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IsStringPureDelegate HIKEYGBDSPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TryGetSpecificChipConfigSummaryDelegate SYLLFCXNSHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReleaseIconIdDelegate PLRBKQPJNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate ZHFGYGFCQTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 OVGOLXOUFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 OVBHOQUWWAY;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment FYRGSFECHTE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool PKAXTYGMRQV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> UPKOLCMLMGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> KYVIXLFGKJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> MYPGKATWFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> CDFOBDIDPSC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion SXLMMPSJSWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xB88090", Offset = "0xB86E90", VA = "0x180B88090", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ARVEKWCDSCW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB88120", Offset = "0xB86F20", VA = "0x180B88120", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool VRQAIUGXHRH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A67C20", Offset = "0x2A66A20", VA = "0x182A67C20", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool CQICKHILHSW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A67970", Offset = "0x2A66770", VA = "0x182A67970", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ZDIGANEKWCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4890", Offset = "0xAC3690", VA = "0x180AC4890", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A68200", Offset = "0x2A67000", VA = "0x182A68200")]
		public ENCUDSRVPUJ([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A67730", Offset = "0x2A66530", VA = "0x182A67730", Slot = "9")]
		public bool AFVQNHSPJHU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		public static bool GHBUCJHBDEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A67DD0", Offset = "0x2A66BD0", VA = "0x182A67DD0", Slot = "10")]
		public bool QKMJBTJOZPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void UGSYPHLQSYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xF217C0", Offset = "0xF205C0", VA = "0x180F217C0", Slot = "11")]
		public void FNLBEELMETT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A68060", Offset = "0x2A66E60", VA = "0x182A68060")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> ZLDAXEDRBMU(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A67F20", Offset = "0x2A66D20", VA = "0x182A67F20", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SJTMOKVOPQD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A67D50", Offset = "0x2A66B50", VA = "0x182A67D50")]
		private static IReadOnlyDictionary<Guid, int> OXKNGOSXZRY(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A67FB0", Offset = "0x2A66DB0", VA = "0x182A67FB0", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> UMXDYYHMHNX(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A67FE0", Offset = "0x2A66DE0", VA = "0x182A67FE0")]
		private static IReadOnlyDictionary<int, Guid> VEEGPODIWVQ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A67C60", Offset = "0x2A66A60", VA = "0x182A67C60", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> JWOELSVMMUB(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A67E00", Offset = "0x2A66C00", VA = "0x182A67E00")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> QRXGBEYQLVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A5CD10", Offset = "0x2A5BB10", VA = "0x182A5CD10", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SVVETRSBGRQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A67CF0", Offset = "0x2A66AF0", VA = "0x182A67CF0")]
		private static IReadOnlyDictionary<Guid, int> NRCJZCVSYXB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A677F0", Offset = "0x2A665F0", VA = "0x182A677F0", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> BGGMBMTETGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A67F80", Offset = "0x2A66D80", VA = "0x182A67F80", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> TXCOWEVILWG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void ZCYRQLRLAOQ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A67E70", Offset = "0x2A66C70", VA = "0x182A67E70", Slot = "18")]
		public void RCOKMSDIZTR(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void EJBJRJQGOLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A67DA0", Offset = "0x2A66BA0", VA = "0x182A67DA0", Slot = "19")]
		public void QKAFVLKNBLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		private static bool DXZJYNZHLUJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A67C30", Offset = "0x2A66A30", VA = "0x182A67C30", Slot = "20")]
		public bool JCGFRKQFWHS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		public static bool YAXGWYNPJRC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A67EB0", Offset = "0x2A66CB0", VA = "0x182A67EB0", Slot = "21")]
		public bool RMJBLJCXELZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A68030", Offset = "0x2A66E30", VA = "0x182A68030", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XRQJXQEZTRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> HUJBKUEGOTK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> HCIFBVZHHII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A67A10", Offset = "0x2A66810", VA = "0x182A67A10", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> IGYRTALAUIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> QCIJLFJKTFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> NMIPAXNXMGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public static void NAZVIFRFGKJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A67EE0", Offset = "0x2A66CE0", VA = "0x182A67EE0", Slot = "29")]
		public void SHDATFGICZO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void IIXDUAOEBAX(XTCGAQPRURU a, QDPJHBURBMQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A67940", Offset = "0x2A66740", VA = "0x182A67940", Slot = "35")]
		public void ETSMHNVHPWW(XTCGAQPRURU a, QDPJHBURBMQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> BOXNPAZQQUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> UHZXTIEFKQV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void NWWWOVZTLOV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A67C90", Offset = "0x2A66A90", VA = "0x182A67C90")]
		private static Task<bool> LXPZCAZNWUN(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A67F50", Offset = "0x2A66D50", VA = "0x182A67F50", Slot = "38")]
		public Task<bool> SOMCVDVRNSI(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A67D40", Offset = "0x2A66B40", VA = "0x182A67D40")]
		private static bool OQBAZFVJFSV(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A67E30", Offset = "0x2A66C30", VA = "0x182A67E30", Slot = "39")]
		public bool QYPIEJOSMXC(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void DXSRGWWIYXP(Id32<PSZMTIJLKYP> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A67910", Offset = "0x2A66710", VA = "0x182A67910", Slot = "40")]
		public void CEWDHQJRKKE(Id32<PSZMTIJLKYP> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A67820", Offset = "0x2A66620", VA = "0x182A67820")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, IGWAJAWUKJF>> CDRAYTWPNMF(Task<Result<None, IGWAJAWUKJF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A679B0", Offset = "0x2A667B0", VA = "0x182A679B0", Slot = "41")]
		public Task<Result<None, IGWAJAWUKJF>> HPZKQTZQTNG(Task<Result<None, IGWAJAWUKJF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A67B30", Offset = "0x2A66930", VA = "0x182A67B30")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, IGWAJAWUKJF>> IQMPPYYLKAB(Task<Result<MultiResult, IGWAJAWUKJF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A679E0", Offset = "0x2A667E0", VA = "0x182A679E0", Slot = "42")]
		public Task<Result<MultiResult, IGWAJAWUKJF>> HPZKQTZQTNG(Task<Result<MultiResult, IGWAJAWUKJF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A67A40", Offset = "0x2A66840", VA = "0x182A67A40")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> IQHISSEOAOS(Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A67980", Offset = "0x2A66780", VA = "0x182A67980", Slot = "43")]
		public Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> HPZKQTZQTNG(Task<Result<Id32<TDADSARCMWU>, IGWAJAWUKJF>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class TWSRNVOLSJK : GGAHRULMFTR
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(BWRMFYYLKFG e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private InteropDelegate? UXQPHOMJJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly InteropDelegate HMPUHGAUMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate VSXBEJKATYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? SCNDBIWUULT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InvokeStudioFunctionDelegate? MAFOQYZXHMC;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "5")]
		public LegacyCV2Result<None> NEPQKXQBICG(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		private static LegacyCV2Result<None> Default(BWRMFYYLKFG _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "6")]
		public LegacyCV2Result<None> XNMVZFRQEDV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "7")]
		public LegacyCV2Result<None> BIEKRFDPAFG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "8")]
		public LegacyCV2Result<None> BPLBYQYTCVL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "9")]
		public LegacyCV2Result<None> HVGSKPHATWJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "15")]
		public LegacyCV2Result<None> TNVMQLIMTNQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PPOWKVQFTWS(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TDURFPPEVBI(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VWUOFZUYUCR(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GJSCCUWUDPS(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JLJWGRZBYOX(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TPAWBPOQPBB(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FEOMNUIXMRY(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "93")]
		public LegacyCV2Result<None> HEGUAULGDBB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "94")]
		public LegacyCV2Result<None> BWLQISVOBWL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "95")]
		public LegacyCV2Result<None> MLUTQPORGRW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KMVHPHHDWWA(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(BWRMFYYLKFG e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QSUVPVWUTMG(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NVKBEYMWWHI(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FAGRALJFHKN(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OMLYZVNJBGE(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RXFWKHBXNKR(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FMQMQZLJDVN(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IWXGDNVTVKX(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FYIKMWIWDKO(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1238")]
		public LegacyCV2Result<None> MakeChatAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1239")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1240")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1241")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1243")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1242")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1244")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1245")]
		public LegacyCV2Result<None> GetAIFunction(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x15096A0", Offset = "0x15084A0", VA = "0x1815096A0", Slot = "1247")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UPCVCMYSXBT(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BZBGIBJATVQ(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "119")]
		public LegacyCV2Result<None> QZBLRKLNDWO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FIUXLZMCQMX(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "121")]
		public LegacyCV2Result<None> SEHEDBDJXVF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "122")]
		public LegacyCV2Result<None> CAAHUMQVWHB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "123")]
		public LegacyCV2Result<None> JBYVDEVUHWL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "124")]
		public LegacyCV2Result<None> WQPMJTJZIXN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "125")]
		public LegacyCV2Result<None> YGBRJWQQQJR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "126")]
		public LegacyCV2Result<None> SNINGECVMKY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "809")]
		public LegacyCV2Result<None> OUJJQRRFKXU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "810")]
		public LegacyCV2Result<None> UUNNGSMPRIK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "147")]
		public LegacyCV2Result<None> ZFHHRVGSCWO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "148")]
		public LegacyCV2Result<None> PGWUUTYIEFU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "149")]
		public LegacyCV2Result<None> FLRADXLOFRT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "150")]
		public LegacyCV2Result<None> GUCUEEHCTIZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "151")]
		public LegacyCV2Result<None> UAKJNOGQMDO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(BWRMFYYLKFG e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "153")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "154")]
		public LegacyCV2Result<None> EquipAvatarItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "155")]
		public LegacyCV2Result<None> UnequipAvatarItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "156")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "157")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "158")]
		public LegacyCV2Result<None> MotionTrailSetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailGetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "164")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "165")]
		public LegacyCV2Result<None> BeaconSetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "166")]
		public LegacyCV2Result<None> BeaconGetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "167")]
		public LegacyCV2Result<None> BeaconSetHeight(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "168")]
		public LegacyCV2Result<None> BeaconGetHeight(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "169")]
		public LegacyCV2Result<None> BeaconSetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "170")]
		public LegacyCV2Result<None> BeaconGetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "171")]
		public LegacyCV2Result<None> UYYOFZUWLFD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "172")]
		public LegacyCV2Result<None> JDWYTKECPSC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "173")]
		public LegacyCV2Result<None> VDXWABQEHRQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "174")]
		public LegacyCV2Result<None> GetLocalCameraForward(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "175")]
		public LegacyCV2Result<None> GetLocalCameraUp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "176")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "178")]
		public LegacyCV2Result<None> SetCameraShake(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "179")]
		public LegacyCV2Result<None> StopCameraShake(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "180")]
		public LegacyCV2Result<None> SnapCameraImage(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "189")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "190")]
		public LegacyCV2Result<None> CollisionDataGetObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "191")]
		public LegacyCV2Result<None> CollisionDataGetDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetNormal(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "194")]
		public LegacyCV2Result<None> OKYWCFYKLJC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "195")]
		public LegacyCV2Result<None> RBYAAJCWIQD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "196")]
		public LegacyCV2Result<None> AERLOZGMZQC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "197")]
		public LegacyCV2Result<None> KPDBJTHABRU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "198")]
		public LegacyCV2Result<None> YWRSXNKXXHI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "199")]
		public LegacyCV2Result<None> PCTHZRFFCXF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "200")]
		public LegacyCV2Result<None> FUJAHSQEHIB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "201")]
		public LegacyCV2Result<None> UXUQTUKVQZZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "202")]
		public LegacyCV2Result<None> ZLTYJBNFDCD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "203")]
		public LegacyCV2Result<None> NKBZSYNLFBR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "204")]
		public LegacyCV2Result<None> ZCZUTAJZVEF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "205")]
		public LegacyCV2Result<None> IBYSJMLDRKJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "206")]
		public LegacyCV2Result<None> ENNCMSZTNHV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "207")]
		public LegacyCV2Result<None> FJVVKKBJDNA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "208")]
		public LegacyCV2Result<None> PNAMPEFJNLV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "209")]
		public LegacyCV2Result<None> OCFXFCJGQGO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "210")]
		public LegacyCV2Result<None> XSWSVYLEJYB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "211")]
		public LegacyCV2Result<None> PRFUQNSMRNE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "212")]
		public LegacyCV2Result<None> EQSTWZWZLUP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetHealthAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "216")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "217")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "218")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "225")]
		public LegacyCV2Result<None> CombatantSetHealthAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "226")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "227")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "231")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "232")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "233")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "239")]
		public LegacyCV2Result<None> CombatantToCombatantAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "240")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "241")]
		public LegacyCV2Result<None> CombatantSplit(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "242")]
		public LegacyCV2Result<None> CostumeEquip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "243")]
		public LegacyCV2Result<None> CostumeUnEquip(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "244")]
		public LegacyCV2Result<None> CostumeGetWearer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "245")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "271")]
		public LegacyCV2Result<None> MXFAHEJNVMD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "272")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "273")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "274")]
		public LegacyCV2Result<None> SCJNFNLFLBL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "276")]
		public LegacyCV2Result<None> KOQNKKESWFO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "277")]
		public LegacyCV2Result<None> ZFXPIWGXYMK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "278")]
		public LegacyCV2Result<None> CXEKYLIKYRV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "279")]
		public LegacyCV2Result<None> WGEASOJWRAM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "280")]
		public LegacyCV2Result<None> KBGBXFOZVCN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "281")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "282")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "283")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "284")]
		public LegacyCV2Result<None> IPVSHRBAKGU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "285")]
		public LegacyCV2Result<None> AZDGTOSXSNL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectButton(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectContainer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectRotator(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectPiston(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectSeat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectDice(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectCostume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "314")]
		public LegacyCV2Result<None> BNRSASLENRI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectButton(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectContainer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectDie(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectPiston(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRotator(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectText(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectSeat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectCostume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "399")]
		public LegacyCV2Result<None> WHUZHUYJRLH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QXBQGQANKJK(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "401")]
		public LegacyCV2Result<None> DiceRollFinished(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "402")]
		public LegacyCV2Result<None> DiceResult(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "403")]
		public LegacyCV2Result<None> DicePlayerRolled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "404")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LBTJOXXCSJO(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "406")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FKJRODBYWNI(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TMFYBDUZJEZ(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "408")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HXKLCVSFXPE(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "409")]
		public LegacyCV2Result<KLQEOTFHRHU.CV2DiscoverySectionType> SFLHNTKIWGF(BWRMFYYLKFG e, CircuitSignal a)
		{
			return default(LegacyCV2Result<KLQEOTFHRHU.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "410")]
		public LegacyCV2Result<None> KBYBXKQSWQR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "411")]
		public LegacyCV2Result<None> EmitterStart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "412")]
		public LegacyCV2Result<None> EmitterStop(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "413")]
		public LegacyCV2Result<None> EmitterSetLooping(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "414")]
		public LegacyCV2Result<None> EmitterSetSize(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "415")]
		public LegacyCV2Result<None> EmitterSetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "416")]
		public LegacyCV2Result<None> EmitterSetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "417")]
		public LegacyCV2Result<None> EmitterSetColorNew(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "418")]
		public LegacyCV2Result<None> EmitterGetLooping(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "419")]
		public LegacyCV2Result<None> EmitterGetSize(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "420")]
		public LegacyCV2Result<None> EmitterGetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "421")]
		public LegacyCV2Result<None> EmitterGetPlaying(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "422")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(BWRMFYYLKFG e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "423")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SKKGOTUFMXD(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "424")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JSVWCKDUJLM(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "425")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> KEKVOAZFJEP(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "426")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "427")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "428")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "429")]
		public LegacyCV2Result<None> GetFriendlyNameAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "430")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "182")]
		public LegacyCV2Result<None> GetFriendlyNameColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "434")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "431")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "432")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "433")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "435")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameReward(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "453")]
		public LegacyCV2Result<None> KLHHZXGXCVM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "454")]
		public LegacyCV2Result<None> RIQALABWUQH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "455")]
		public LegacyCV2Result<None> DWQZUPLEFNW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "456")]
		public LegacyCV2Result<None> EPPJCCEFIPD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "457")]
		public LegacyCV2Result<None> VGUCKJXCQEN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "458")]
		public LegacyCV2Result<None> PIBYZOBZYEL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "459")]
		public LegacyCV2Result<None> GQROIOXVIVK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "460")]
		public LegacyCV2Result<None> VOPJTWBPKWK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "465")]
		public LegacyCV2Result<None> QDFSMRJDQEI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "466")]
		public LegacyCV2Result<None> CTCTNQLHSEI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "467")]
		public LegacyCV2Result<None> MQTKFLNUCWZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "468")]
		public LegacyCV2Result<None> YYVMWAIGVPS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "469")]
		public LegacyCV2Result<None> LBFIVGECWPW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "470")]
		public LegacyCV2Result<None> XUUIXSNVCCF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "461")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(BWRMFYYLKFG executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "462")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(BWRMFYYLKFG executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "463")]
		public LegacyCV2Result<None> WNMTSOIMWFF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "464")]
		public LegacyCV2Result<None> JHOUIRBATMP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "471")]
		public LegacyCV2Result<None> PORWAVPBXXN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "472")]
		public LegacyCV2Result<None> KANKQKFASVB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "473")]
		public LegacyCV2Result<None> OFYHUGJDNUI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "474")]
		public LegacyCV2Result<None> LPGUMEXWTJQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "475")]
		public LegacyCV2Result<None> LSCLFMFNBCA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "476")]
		public LegacyCV2Result<None> AYNKRNPTFRW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "477")]
		public LegacyCV2Result<None> YMCZJVSXFGS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "478")]
		public LegacyCV2Result<None> NESRGSDTYHW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "479")]
		public LegacyCV2Result<None> PNEOYXSDOCO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "480")]
		public LegacyCV2Result<None> ZMZZZONTCMW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "481")]
		public LegacyCV2Result<None> OBHIAQMHCIM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "482")]
		public LegacyCV2Result<None> PUQAMKQEYGQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "483")]
		public LegacyCV2Result<None> YNLTOTFGDYS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "484")]
		public LegacyCV2Result<None> KHCKRASWGPU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "485")]
		public LegacyCV2Result<None> KOGHNHHYQQS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "486")]
		public LegacyCV2Result<None> CUMRSUIQHOY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "487")]
		public LegacyCV2Result<None> DVZZDKGTRJS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "488")]
		public LegacyCV2Result<None> XMSZMPNBPFC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "489")]
		public LegacyCV2Result<None> AKAGWPMXVJM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "490")]
		public LegacyCV2Result<None> TTDILYRXOZW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ECD0", Offset = "0x2A6DAD0", VA = "0x182A6ECD0", Slot = "491")]
		public LegacyCV2Result<None> SendLogString(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "492")]
		public LegacyCV2Result<None> LerpColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "493")]
		public LegacyCV2Result<None> LerpUnclampedColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "494")]
		public LegacyCV2Result<None> InverseLerpVec3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "495")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "496")]
		public LegacyCV2Result<None> InverseLerpColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "497")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "498")]
		public LegacyCV2Result<None> WRKPZYFATAG(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "499")]
		public LegacyCV2Result<None> LQSKNNOUYMU(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "500")]
		public LegacyCV2Result<None> IBDJVHTTYEI(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "501")]
		public LegacyCV2Result<None> SWHLARKNSZN(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "502")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "503")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "504")]
		public LegacyCV2Result<None> FogConstantValues(BWRMFYYLKFG e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "505")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "506")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "507")]
		public LegacyCV2Result<None> SunConstantValues(BWRMFYYLKFG e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "508")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "509")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "510")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(BWRMFYYLKFG e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.SDCBLCFFBFU> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "511")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "512")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "513")]
		public LegacyCV2Result<None> XBBHZYKFYMB(BWRMFYYLKFG e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "516")]
		public LegacyCV2Result<None> HAFLNXKCMVH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "517")]
		public LegacyCV2Result<None> TextScreenClearScreen(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "518")]
		public LegacyCV2Result<None> MUXRXMPFPYC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "519")]
		public LegacyCV2Result<None> VDVPHFLZDYA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "520")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "521")]
		public LegacyCV2Result<None> BFEYRANDPUM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "522")]
		public LegacyCV2Result<None> MXAJLPUDSFF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EBC0", Offset = "0x2A6D9C0", VA = "0x182A6EBC0", Slot = "523")]
		public LegacyCV2Result<None> GetLocalPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "524")]
		public LegacyCV2Result<None> ZIUVYCGWLLJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ED10", Offset = "0x2A6DB10", VA = "0x182A6ED10", Slot = "526")]
		public LegacyCV2Result<None> TVQACZMMJVX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "525")]
		public LegacyCV2Result<None> DEXNSINDBHE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "527")]
		public LegacyCV2Result<None> IULOUAIYWKS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "528")]
		public LegacyCV2Result<None> RPKJHPMGTJP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "529")]
		public LegacyCV2Result<None> QYRHOODKNBJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "530")]
		public LegacyCV2Result<None> PJWPKUQJHZZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "531")]
		public LegacyCV2Result<None> JOBTCBIPRXP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "532")]
		public LegacyCV2Result<None> DistanceAI_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "533")]
		public LegacyCV2Result<None> DistanceAI_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "534")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "535")]
		public LegacyCV2Result<None> DistanceAI_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "536")]
		public LegacyCV2Result<None> DistanceAI_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "537")]
		public LegacyCV2Result<None> DistanceCombatant_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "538")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "539")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "540")]
		public LegacyCV2Result<None> DistanceCombatant_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "541")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "542")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "543")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "544")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "545")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "546")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "547")]
		public LegacyCV2Result<None> DistancePlayer_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "548")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "549")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "550")]
		public LegacyCV2Result<None> DistancePlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "551")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "552")]
		public LegacyCV2Result<None> DistanceVector3_AI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "553")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "554")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "555")]
		public LegacyCV2Result<None> DistanceVector3_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "556")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "557")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "558")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "559")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "560")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "561")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "562")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "563")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "564")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "565")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "566")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "567")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "568")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "569")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "570")]
		public LegacyCV2Result<None> GetPositionAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "571")]
		public LegacyCV2Result<None> GetPositionCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "572")]
		public LegacyCV2Result<None> GetPositionCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "573")]
		public LegacyCV2Result<None> GetPositionPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "574")]
		public LegacyCV2Result<None> Raycast(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "575")]
		public LegacyCV2Result<None> GVGSFDWZNSS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "576")]
		public LegacyCV2Result<None> RaycastAll(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "577")]
		public LegacyCV2Result<None> Spherecast(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "578")]
		public LegacyCV2Result<None> BAIJZIPGQTX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "579")]
		public LegacyCV2Result<None> SpherecastAll(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "580")]
		public LegacyCV2Result<None> OverlapSphere(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "581")]
		public LegacyCV2Result<None> OverlapBox(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "582")]
		public LegacyCV2Result<None> SRZEYIAMJGE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "583")]
		public LegacyCV2Result<None> WIIXSMKGHAH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "584")]
		public LegacyCV2Result<None> SetPositionPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "585")]
		public LegacyCV2Result<None> SetPositionCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "586")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "587")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "588")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "589")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "591")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "592")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "593")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "594")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "595")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "596")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "597")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "598")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "599")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "600")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "601")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "602")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "603")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "604")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "605")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "606")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "607")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "608")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "609")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "610")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "611")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "612")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "613")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "614")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "615")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "616")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "617")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "618")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "619")]
		public LegacyCV2Result<None> PistonGetDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "620")]
		public LegacyCV2Result<None> PistonSetDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "621")]
		public LegacyCV2Result<None> PistonGetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "622")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "623")]
		public LegacyCV2Result<None> PistonSetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "624")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "625")]
		public LegacyCV2Result<None> PistonGetAcceleration(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "626")]
		public LegacyCV2Result<None> PistonSetAcceleration(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "627")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "628")]
		public LegacyCV2Result<None> PistonGetMaxDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "629")]
		public LegacyCV2Result<None> PistonSetMaxDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "630")]
		public LegacyCV2Result<None> PistonGetTargetDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "631")]
		public LegacyCV2Result<None> PistonSetTargetDistance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "632")]
		public LegacyCV2Result<None> GTKYYZMGFVS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "633")]
		public LegacyCV2Result<None> TIPRTENXBSY(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "634")]
		public LegacyCV2Result<None> PAGOGAJVRGR(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "635")]
		public LegacyCV2Result<None> GRTZCUBWPMW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "636")]
		public LegacyCV2Result<None> LEORWDIZZHU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "637")]
		public LegacyCV2Result<None> BVPQDVFBREX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "638")]
		public LegacyCV2Result<None> PlayerAddRole(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "639")]
		public LegacyCV2Result<None> PlayerRemoveRole(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "640")]
		public LegacyCV2Result<None> INXDQCADQBC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "641")]
		public LegacyCV2Result<None> PNFOYBRWKYE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "642")]
		public LegacyCV2Result<None> ZQUVMWTINCR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "643")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "644")]
		public LegacyCV2Result<None> PlayerRightHandPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "645")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "646")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "647")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "648")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "649")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "650")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "652")]
		public LegacyCV2Result<None> NSPTVRLUEPE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "651")]
		public LegacyCV2Result<None> GHIFDTTRBNP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "653")]
		public LegacyCV2Result<None> LNDBHAFJRHG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "654")]
		public LegacyCV2Result<None> DLFRSXSWMFV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "655")]
		public LegacyCV2Result<None> PlayerHeadPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "656")]
		public LegacyCV2Result<None> PlayerHeadOrientation(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "657")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "658")]
		public LegacyCV2Result<None> PlayerHeadUpVector(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "659")]
		public LegacyCV2Result<None> PlayerHeadVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "660")]
		public LegacyCV2Result<None> PlayerHeadHeight(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "661")]
		public LegacyCV2Result<None> CIISKMHLQQM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "662")]
		public LegacyCV2Result<None> SNKGPICCTXV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "663")]
		public LegacyCV2Result<None> PlayerBodyPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "664")]
		public LegacyCV2Result<None> PlayerBodyOrientation(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "665")]
		public LegacyCV2Result<None> LIDRBJDMJDT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "666")]
		public LegacyCV2Result<None> YATROOBWASU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "694")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "699")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(BWRMFYYLKFG e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "685")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "686")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "687")]
		public LegacyCV2Result<None> CTGFAXXISXY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "688")]
		public LegacyCV2Result<None> UPFYDNGCZOY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "689")]
		public LegacyCV2Result<None> LJOCTFFTDSM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "690")]
		public LegacyCV2Result<None> JRTOQVMPMUH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "691")]
		public LegacyCV2Result<None> CHKIUGYDWDZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "692")]
		public LegacyCV2Result<None> PlayerGetCostume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "693")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "667")]
		public LegacyCV2Result<None> HAFIAQAMZZO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "668")]
		public LegacyCV2Result<None> BCJHDLJMTRU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "669")]
		public LegacyCV2Result<None> ZROBNNBZCWD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "670")]
		public LegacyCV2Result<None> NKIVVRWXXEO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "671")]
		public LegacyCV2Result<None> WIJIXGFTFUZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "672")]
		public LegacyCV2Result<None> HDPBDDKGRDO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "673")]
		public LegacyCV2Result<None> UMOWWRIIEXQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "674")]
		public LegacyCV2Result<None> YQWLEQNPUMH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "675")]
		public LegacyCV2Result<None> WYGYGDCXCQT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "676")]
		public LegacyCV2Result<None> ECKLUYGESZU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "677")]
		public LegacyCV2Result<None> VNTEJTIRXRC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "678")]
		public LegacyCV2Result<None> ENFLBOZHZEJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "679")]
		public LegacyCV2Result<None> NXWSZHJDSQO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "680")]
		public LegacyCV2Result<None> GLOZEUFJDYK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "681")]
		public LegacyCV2Result<None> QMECEQWTWHR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "682")]
		public LegacyCV2Result<None> QUYYUHZTUAV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "683")]
		public LegacyCV2Result<None> LDTBQJEHAQD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "684")]
		public LegacyCV2Result<None> BDYNXDNYIEY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "695")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "696")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "756")]
		public LegacyCV2Result<None> LTRJNVFBHSQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "757")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "758")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "700")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "702")]
		public LegacyCV2Result<None> CPCSSATDYOR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "703")]
		public LegacyCV2Result<None> AGSXQQNSWXB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "704")]
		public LegacyCV2Result<None> THRRRPLFBUF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "705")]
		public LegacyCV2Result<None> IMLFHBOQGAT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "707")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "708")]
		public LegacyCV2Result<None> OSIVRTHLSHV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "709")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "710")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "711")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "712")]
		public LegacyCV2Result<None> OJHPVILDTOW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "713")]
		public LegacyCV2Result<None> QROARYKAVRO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "714")]
		public LegacyCV2Result<None> XLMANTOOCRJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "715")]
		public LegacyCV2Result<None> ZBXCWCDFGJP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "716")]
		public LegacyCV2Result<None> AEMVWPKCYKV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "717")]
		public LegacyCV2Result<None> BFEKZYFUGCQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "718")]
		public LegacyCV2Result<None> SOSWALDINGJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "719")]
		public LegacyCV2Result<None> ZYXMACPIXAY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "720")]
		public LegacyCV2Result<None> OZFYHYOBGUA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "721")]
		public LegacyCV2Result<None> QFVCUQMDZAM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "722")]
		public LegacyCV2Result<None> QEEEFUSDOMA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "723")]
		public LegacyCV2Result<None> RIEKSOQINII(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "724")]
		public LegacyCV2Result<None> AXABVJNXQBE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "725")]
		public LegacyCV2Result<None> JTTCAUGXLHD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "726")]
		public LegacyCV2Result<None> JQNSIDTSHOI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "727")]
		public LegacyCV2Result<None> CNVYTHYQOMK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "728")]
		public LegacyCV2Result<None> KMUVEQYYZKN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "729")]
		public LegacyCV2Result<None> LPDLHXATXUW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "731")]
		public LegacyCV2Result<None> STLMJBKIHGY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "730")]
		public LegacyCV2Result<None> RMOXPJKTVDY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "732")]
		public LegacyCV2Result<None> YJZBAKDBLJJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "733")]
		public LegacyCV2Result<None> OJWOJKSMFMW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "734")]
		public LegacyCV2Result<None> FJAONGQRMUZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "735")]
		public LegacyCV2Result<None> MYPXREQOVRX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "736")]
		public LegacyCV2Result<None> ZCHBRZGWQWQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "737")]
		public LegacyCV2Result<None> NXYEYFWTRWZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "738")]
		public LegacyCV2Result<None> JWHHXDTHKUZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "739")]
		public LegacyCV2Result<None> NFHBJNDXREO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "740")]
		public LegacyCV2Result<None> YSYWXYILCHK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "741")]
		public LegacyCV2Result<None> WLBOGIOSDGS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "742")]
		public LegacyCV2Result<None> BBJPSTOERYS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "743")]
		public LegacyCV2Result<None> UZKWRFSUPUY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "744")]
		public LegacyCV2Result<None> NEDEUITIDRW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "745")]
		public LegacyCV2Result<None> WCXVVBFMDBO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "746")]
		public LegacyCV2Result<None> OLWFBFPEAYV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "747")]
		public LegacyCV2Result<None> KTIUZQRAJRT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "748")]
		public LegacyCV2Result<None> QVDVBHKFJFN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "749")]
		public LegacyCV2Result<None> EFHNZUEJXOZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "750")]
		public LegacyCV2Result<None> EJCVZZCCHRA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "751")]
		public LegacyCV2Result<None> YIQCSAKHSLU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "752")]
		public LegacyCV2Result<None> LOBPMRRFNYK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "753")]
		public LegacyCV2Result<None> IMRCDRRDZVR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "754")]
		public LegacyCV2Result<None> BJCGFTAHZUZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "755")]
		public LegacyCV2Result<None> BIUMMQSFHRQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "759")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "760")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "761")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "762")]
		public LegacyCV2Result<None> URMJQUSHAXM(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "763")]
		public LegacyCV2Result<None> RSZDGQRIHBW(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "764")]
		public LegacyCV2Result<None> QZKITWJEHCB(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "765")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(BWRMFYYLKFG ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "766")]
		public LegacyCV2Result<None> BTAOGHBPTNB(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "767")]
		public LegacyCV2Result<None> BFLTFQMODPP(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "768")]
		public LegacyCV2Result<None> RNGZZOFUGCM(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "769")]
		public LegacyCV2Result<None> WQTJGLLLHTS(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "770")]
		public LegacyCV2Result<None> ROKZETYWFJI(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "697")]
		public LegacyCV2Result<None> PlayerGetProfileImage(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "698")]
		public LegacyCV2Result<None> SXXTWUGWNFA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "771")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "772")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "773")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "774")]
		public LegacyCV2Result<None> ShowPlayerProfile(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "775")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "776")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "777")]
		public LegacyCV2Result<None> RequestPostGameRewards(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "778")]
		public LegacyCV2Result<None> SetPlayerWorldUI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "779")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "781")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "782")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "783")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "784")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "785")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "786")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "788")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "791")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "792")]
		public LegacyCV2Result<None> MNRBFZLICSG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "793")]
		public LegacyCV2Result<None> DDRBMEZSWVM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "794")]
		public LegacyCV2Result<None> NADRIBWIDAG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "795")]
		public LegacyCV2Result<None> FQIWSJUFAOI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "796")]
		public LegacyCV2Result<None> ELPVHXGUOVQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "797")]
		public LegacyCV2Result<None> VPFJBECYAMW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "798")]
		public LegacyCV2Result<None> PEJHUOJGFLY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "799")]
		public LegacyCV2Result<None> GMGBYETNKKA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "800")]
		public LegacyCV2Result<None> MPJUWUVDXVU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "801")]
		public LegacyCV2Result<None> RCJMEVWGZUG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "802")]
		public LegacyCV2Result<None> LGPMSHCYOME(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "803")]
		public LegacyCV2Result<None> EKJUYEDPJXV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "804")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "805")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "806")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "807")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "808")]
		public LegacyCV2Result<None> ONHZLVABGPO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "811")]
		public LegacyCV2Result<None> GetProjectile(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "812")]
		public LegacyCV2Result<None> MLVTTHQSPQL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "813")]
		public LegacyCV2Result<None> IIBYAJIINND(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "814")]
		public LegacyCV2Result<None> IYMGRQOJKVL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "815")]
		public LegacyCV2Result<None> OQAIPXUEACL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "817")]
		public LegacyCV2Result<None> QNAXBZBNZKL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "818")]
		public LegacyCV2Result<None> VAKNSJWGHMQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "819")]
		public LegacyCV2Result<None> GTVSSFCTAHI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "820")]
		public LegacyCV2Result<None> ResetRoom(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "821")]
		public LegacyCV2Result<None> ResetObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "822")]
		public LegacyCV2Result<None> XFRLEAODFPA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "823")]
		public LegacyCV2Result<None> VBTYZSRQDAX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "824")]
		public LegacyCV2Result<None> XROFOPLEYRE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "825")]
		public LegacyCV2Result<None> ConstantReward(BWRMFYYLKFG e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "826")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "827")]
		public LegacyCV2Result<None> POUMBFOIVWF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "828")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HDOVGGMCIUL(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BJSZZKGKYET(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VJVSZVFWFAS(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DXGNBAQBFKL(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "832")]
		public LegacyCV2Result<None> ActivateConsumable(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "833")]
		public LegacyCV2Result<None> DeactivateConsumable(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "834")]
		public LegacyCV2Result<None> ConstantConsumable(BWRMFYYLKFG e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "836")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "839")]
		public LegacyCV2Result<None> ConstantRoomKey(BWRMFYYLKFG e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "842")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "843")]
		public LegacyCV2Result<None> ConstantInventoryItem(BWRMFYYLKFG e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "844")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "846")]
		public LegacyCV2Result<None> AIAVEAWOSGN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "849")]
		public LegacyCV2Result<None> UHIMOEIWMUF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "850")]
		public LegacyCV2Result<None> HZYDZXKJTRZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "851")]
		public LegacyCV2Result<None> GGJKAQHHFJL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "852")]
		public LegacyCV2Result<None> GDJNDXXGIMQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "853")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "854")]
		public LegacyCV2Result<None> CEYYGLVAJIB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "855")]
		public LegacyCV2Result<None> CGPVLZJZIMN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "856")]
		public LegacyCV2Result<None> ConstantRoomOffer(BWRMFYYLKFG e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "857")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "859")]
		public LegacyCV2Result<None> FUJNBJPZHLZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "860")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "861")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "862")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "863")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "864")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "865")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "866")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "867")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "868")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "869")]
		public LegacyCV2Result<None> UUOOYTPOQXD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "870")]
		public LegacyCV2Result<None> DTORKNDNZHT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "871")]
		public LegacyCV2Result<None> ULKAUXRWEFK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "872")]
		public LegacyCV2Result<None> XXEZINAMIXH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "873")]
		public LegacyCV2Result<None> ConstantRoomCurrency(BWRMFYYLKFG e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "874")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(BWRMFYYLKFG e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "875")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "876")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(BWRMFYYLKFG e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "877")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(BWRMFYYLKFG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "878")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "879")]
		public LegacyCV2Result<None> VWBEYLHHSZJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "880")]
		public LegacyCV2Result<None> VNCOECTETRC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "881")]
		public LegacyCV2Result<None> OVIWYWTTYRJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "882")]
		public LegacyCV2Result<None> FZFWBUYIVZV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "883")]
		public LegacyCV2Result<None> JUDSLSQKUDX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "887")]
		public LegacyCV2Result<None> ARWZYZQPOBA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "888")]
		public LegacyCV2Result<None> RSVDIYNHXRI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "889")]
		public LegacyCV2Result<None> KKIXWVSFFYB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "891")]
		public LegacyCV2Result<None> YEBIIHASEQZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "890")]
		public LegacyCV2Result<None> UVLVVNHSJHB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "892")]
		public LegacyCV2Result<None> MWOJKNCSSFQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "894")]
		public LegacyCV2Result<None> VMHYVAWQCRU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "893")]
		public LegacyCV2Result<None> EYRMINBYRLA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "895")]
		public LegacyCV2Result<None> BECOPNODGDR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "896")]
		public LegacyCV2Result<None> LCPZFCPGIAL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "897")]
		public LegacyCV2Result<None> VDTNJDFMUWA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "898")]
		public LegacyCV2Result<None> YMOYRZQMJQG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "899")]
		public LegacyCV2Result<None> URAFASRKVPG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "900")]
		public LegacyCV2Result<None> PHHQVBXVPEE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "901")]
		public LegacyCV2Result<None> VPXHKPKGELG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "902")]
		public LegacyCV2Result<None> AllowDressUp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "903")]
		public LegacyCV2Result<None> ForbidDressUp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "904")]
		public LegacyCV2Result<None> OpenStore(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "905")]
		public LegacyCV2Result<None> OpenCheckout(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "906")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "907")]
		public LegacyCV2Result<None> GetTrialItemQuantity(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "908")]
		public LegacyCV2Result<None> KEYIXBNNOEO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "909")]
		public LegacyCV2Result<None> WMDRUHPBPFO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "910")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "911")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "912")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "913")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "914")]
		public LegacyCV2Result<None> StorefrontGetOffersList(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "915")]
		public LegacyCV2Result<None> StorefrontSetOffersList(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "916")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "917")]
		public LegacyCV2Result<None> GetStoreItemDetails(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "918")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "919")]
		public LegacyCV2Result<None> MannequinSetStoreItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "920")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "921")]
		public LegacyCV2Result<None> RaiseStudioEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "922")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "923")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "924")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "925")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "926")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "927")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "928")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "929")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(BWRMFYYLKFG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "930")]
		public LegacyCV2Result<None> JJPQDWVZRCS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "931")]
		public LegacyCV2Result<None> QRZWZQAXWNC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "932")]
		public LegacyCV2Result<None> FMYRFAMGSPB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "933")]
		public LegacyCV2Result<None> KVNZAFERMST(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "934")]
		public LegacyCV2Result<None> WSDJRNDRRTY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "935")]
		public LegacyCV2Result<None> TTZANGRKQFU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "936")]
		public LegacyCV2Result<None> RKTONBDWQLT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "937")]
		public LegacyCV2Result<None> RRFJTUMVEWX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "938")]
		public LegacyCV2Result<None> MFABCXDYQJL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "939")]
		public LegacyCV2Result<None> SBNXXFOWGHS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "940")]
		public LegacyCV2Result<None> GetFromSyncIdAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "941")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "942")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "943")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "944")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "945")]
		public LegacyCV2Result<None> GetSyncIdAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "946")]
		public LegacyCV2Result<None> GetSyncIdCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "947")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "948")]
		public LegacyCV2Result<None> GetSyncIdPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "949")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "957")]
		public LegacyCV2Result<None> CXFXQUSDNDS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "956")]
		public LegacyCV2Result<None> WFIZIQWKMZZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "958")]
		public LegacyCV2Result<None> TJRMJHULVAX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "959")]
		public LegacyCV2Result<None> BZCLMTJFQLE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "960")]
		public LegacyCV2Result<None> CSGOGBMNSTN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "961")]
		public LegacyCV2Result<None> HDGBLUOCKOF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "962")]
		public LegacyCV2Result<None> BYCUOEHTLUS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "950")]
		public LegacyCV2Result<None> TextToolGetText(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "951")]
		public LegacyCV2Result<None> TextToolSetText(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "952")]
		public LegacyCV2Result<None> TextToolSetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "953")]
		public LegacyCV2Result<None> TextToolSetColorNew(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "954")]
		public LegacyCV2Result<None> TextToolSetMaterial(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "955")]
		public LegacyCV2Result<None> TextToolGetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "963")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "964")]
		public LegacyCV2Result<None> IRSKZWVWDJL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "970")]
		public LegacyCV2Result<None> GetParticleVfx(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "971")]
		public LegacyCV2Result<None> HNRPNPYPWZG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "972")]
		public LegacyCV2Result<None> RUCHVILTWNK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "973")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "974")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "975")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "976")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "977")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "978")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "979")]
		public LegacyCV2Result<None> GoToRoom(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "980")]
		public LegacyCV2Result<None> YWFWFWPSDDR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "965")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "966")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "967")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "968")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "969")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "981")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "982")]
		public LegacyCV2Result<None> GVJHTMZVVHR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "983")]
		public LegacyCV2Result<None> CHBZZHPEDBD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "984")]
		public LegacyCV2Result<None> FBOJGNVAOVH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "985")]
		public LegacyCV2Result<None> UKRPMYHHHDJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "986")]
		public LegacyCV2Result<None> FDWDBVAVZRP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "987")]
		public LegacyCV2Result<None> GMAVDPDUGHT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "988")]
		public LegacyCV2Result<None> DXPPHLAOBFF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "989")]
		public LegacyCV2Result<None> BCMUGDRDSTJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "990")]
		public LegacyCV2Result<None> TZAKXISKKOP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "991")]
		public LegacyCV2Result<None> DTOAPNNYAIX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "995")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "996")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "992")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "993")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "994")]
		public LegacyCV2Result<None> PlayerGetXp(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "997")]
		public LegacyCV2Result<None> PerlinNoise(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "998")]
		public LegacyCV2Result<None> ZHTGGHKNIRJ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "999")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1000")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1001")]
		public LegacyCV2Result<None> SeatSetLockOut(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1002")]
		public LegacyCV2Result<None> SeatSetLockIn(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1003")]
		public LegacyCV2Result<None> SeatUnseatPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1004")]
		public LegacyCV2Result<None> SeatGetLockIn(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1005")]
		public LegacyCV2Result<None> SeatGetLockOut(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1006")]
		public LegacyCV2Result<None> SPHBYPAMBDQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1007")]
		public LegacyCV2Result<None> XQEZBVHWIVX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1008")]
		public LegacyCV2Result<None> POXTDYEODDE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1009")]
		public LegacyCV2Result<None> BAWJUCXMUCZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1010")]
		public LegacyCV2Result<None> DYYSJBNTMZS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1011")]
		public LegacyCV2Result<None> MZQXRZJAOCV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1012")]
		public LegacyCV2Result<None> JNLBTSGTFBS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1013")]
		public LegacyCV2Result<None> KTSPMVCOPRO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1014")]
		public LegacyCV2Result<None> YVMGWQINRMX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1015")]
		public LegacyCV2Result<None> OORLVFGFOFE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1016")]
		public LegacyCV2Result<None> ACJQWJZLVSA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1017")]
		public LegacyCV2Result<None> PTJNKIDRMZT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1018")]
		public LegacyCV2Result<None> FLVYSQPTDEH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1019")]
		public LegacyCV2Result<None> QLYNCGGMIYE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1020")]
		public LegacyCV2Result<None> SKDZSUBKZET(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1021")]
		public LegacyCV2Result<None> KQHKLFJVBGQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1022")]
		public LegacyCV2Result<None> PLDEZVIQFQM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1023")]
		public LegacyCV2Result<None> NavMeshSamplePosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1024")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1036")]
		public LegacyCV2Result<None> FOZOREMVYRO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1037")]
		public LegacyCV2Result<None> YSAPFABJMJS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1038")]
		public LegacyCV2Result<None> LVJHHBLXRIO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1039")]
		public LegacyCV2Result<None> DZTZXYZEZKG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1040")]
		public LegacyCV2Result<None> RFRFNMFRMQP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1041")]
		public LegacyCV2Result<None> QJMMFMTZAOX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1042")]
		public LegacyCV2Result<None> QQJHNLRUYPI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1043")]
		public LegacyCV2Result<None> WGWONCRAROD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1044")]
		public LegacyCV2Result<None> DUZJOJNOUMC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1045")]
		public LegacyCV2Result<None> SGHSVULKWZT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1046")]
		public LegacyCV2Result<None> GCDQIVBOPAP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1047")]
		public LegacyCV2Result<None> LSSRSRQDIUO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1048")]
		public LegacyCV2Result<None> YRNQYGQPGSN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1049")]
		public LegacyCV2Result<None> JGEPKWXYMNB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1050")]
		public LegacyCV2Result<None> ROTELZUTDQT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1051")]
		public LegacyCV2Result<None> INEISBUVURR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1052")]
		public LegacyCV2Result<None> QFLWWPLRUCD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1053")]
		public LegacyCV2Result<None> VRLXBHLBKZQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1054")]
		public LegacyCV2Result<None> KEDKCOEAYTI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1055")]
		public LegacyCV2Result<None> ZLKXOLDVQWB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1056")]
		public LegacyCV2Result<None> DJFRBQFYNMV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1057")]
		public LegacyCV2Result<None> BQCFHLUUNWX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1058")]
		public LegacyCV2Result<None> SOHYCVGAFIP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1059")]
		public LegacyCV2Result<None> UCUHKJDMJIK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1060")]
		public LegacyCV2Result<None> QTRJNLCSGES(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1061")]
		public LegacyCV2Result<None> IsValidAI(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1062")]
		public LegacyCV2Result<None> IsValidCombatant(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EC90", Offset = "0x2A6DA90", VA = "0x182A6EC90", Slot = "1063")]
		public LegacyCV2Result<None> IsValidPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1064")]
		public LegacyCV2Result<None> IsValidReward(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1065")]
		public LegacyCV2Result<None> IsValidAudio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1066")]
		public LegacyCV2Result<None> IsValidRecNetMesh(BWRMFYYLKFG e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1067")]
		public LegacyCV2Result<None> ValidIfNotNull(BWRMFYYLKFG e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1068")]
		public LegacyCV2Result<None> GetVelocityCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1069")]
		public LegacyCV2Result<None> GetVelocityPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1070")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1071")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1072")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1073")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1074")]
		public LegacyCV2Result<None> GetUpVectorPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1075")]
		public LegacyCV2Result<None> GetOrientationCreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1076")]
		public LegacyCV2Result<None> GetOrientationPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1077")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1078")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1079")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1080")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1081")]
		public LegacyCV2Result<None> CCOGDUODGNV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1082")]
		public LegacyCV2Result<None> HCRXJNFBPOO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1083")]
		public LegacyCV2Result<None> LVBETAKATXA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1084")]
		public LegacyCV2Result<None> JEFUSIPQIUO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1085")]
		public LegacyCV2Result<None> SCZVSPJPYLE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1086")]
		public LegacyCV2Result<None> AGJTZJJDFXI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1087")]
		public LegacyCV2Result<None> CPOEWOJDYXQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1088")]
		public LegacyCV2Result<None> LZQEXUQYAFS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1089")]
		public LegacyCV2Result<None> FSLXVRUNLFC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1090")]
		public LegacyCV2Result<None> XNUUSHKUZSU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1091")]
		public LegacyCV2Result<None> RKHTVODTSMI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1092")]
		public LegacyCV2Result<None> LSMVBAUGXZB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1093")]
		public LegacyCV2Result<None> CTAUPJYQWZR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1094")]
		public LegacyCV2Result<None> DWBDRIVMJTF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1095")]
		public LegacyCV2Result<None> OFZFLZRTFFV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1096")]
		public LegacyCV2Result<None> RTUBWDTIMPM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1097")]
		public LegacyCV2Result<None> IGQDBUITGMW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1098")]
		public LegacyCV2Result<None> FUXJRYMXQTH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1099")]
		public LegacyCV2Result<None> OUJIHQHGPBD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1100")]
		public LegacyCV2Result<None> FFQAGLUXJLV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1101")]
		public LegacyCV2Result<None> DDJBGQLTPDZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1102")]
		public LegacyCV2Result<None> KIRGGZRHJCO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1103")]
		public LegacyCV2Result<None> SJQEDUTPOKO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1104")]
		public LegacyCV2Result<None> KNMAKKAFATZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1105")]
		public LegacyCV2Result<None> OSONXERLZCL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1106")]
		public LegacyCV2Result<None> KBENDSSVLOH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1107")]
		public LegacyCV2Result<None> IMPFZSCASWH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1108")]
		public LegacyCV2Result<None> OQVPDOHSZMC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1109")]
		public LegacyCV2Result<None> DVTYRNHCWXR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1110")]
		public LegacyCV2Result<None> YVEXZGXDFKV(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1111")]
		public LegacyCV2Result<None> GNADHFBEJTX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1112")]
		public LegacyCV2Result<None> JGTMPAMSIPK(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1113")]
		public LegacyCV2Result<None> VNROMDFWRCM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1114")]
		public LegacyCV2Result<None> AFLNBHDNUGS(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1115")]
		public LegacyCV2Result<None> RMACRTHINXQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1116")]
		public LegacyCV2Result<None> OLERHGKNQHC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1117")]
		public LegacyCV2Result<None> UYHMLWOXTCM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1118")]
		public LegacyCV2Result<None> LRRLOIGBCIY(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1119")]
		public LegacyCV2Result<None> YOZPPVWQFOR(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1120")]
		public LegacyCV2Result<None> YPBVZBXCJPA(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1121")]
		public LegacyCV2Result<None> KMXATTLUKVD(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1122")]
		public LegacyCV2Result<None> TEJOKOYVSDQ(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1123")]
		public LegacyCV2Result<None> AXGMLHVCMRQ(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1124")]
		public LegacyCV2Result<None> ROLCUYFGZMN(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1125")]
		public LegacyCV2Result<None> YFXNRSTGPFT(DUFJLFQSONL e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1126")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1127")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1128")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1129")]
		public LegacyCV2Result<None> FEJAFQZZAKP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1130")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1131")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1132")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1133")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1134")]
		public LegacyCV2Result<None> HolotarProjectorPlay(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1135")]
		public LegacyCV2Result<None> HolotarProjectorResume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1136")]
		public LegacyCV2Result<None> HolotarProjectorPause(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1137")]
		public LegacyCV2Result<None> HolotarProjectorStop(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1138")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1139")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1140")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1141")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1142")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1143")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1144")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1145")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1146")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1147")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1148")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1149")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1150")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1151")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1152")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1153")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1154")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1155")]
		public LegacyCV2Result<None> LPUNPXNFTLT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1156")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1157")]
		public LegacyCV2Result<None> YGROXPGCHJT(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1158")]
		public LegacyCV2Result<None> FZJLUTCXPZS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1159")]
		public LegacyCV2Result<None> AODZMJRPMIP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1160")]
		public LegacyCV2Result<None> GYWFHCKFWFY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1161")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1166")]
		public LegacyCV2Result<None> GunHandleGetCanReload(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetCanReload(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1168")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1169")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1170")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1171")]
		public LegacyCV2Result<None> NHJWBXEJWNA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1172")]
		public LegacyCV2Result<None> FMCHMFIGPBE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1173")]
		public LegacyCV2Result<None> POWFAYYMEDW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1174")]
		public LegacyCV2Result<None> WJUYMDLTSEM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1175")]
		public LegacyCV2Result<None> AUZSHUTADPV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1176")]
		public LegacyCV2Result<None> BPIYOQFVTXX(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1177")]
		public LegacyCV2Result<None> GZZCXVYZREB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1178")]
		public LegacyCV2Result<None> UVTMEMLLCYP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1179")]
		public LegacyCV2Result<None> HUOMMGSIPCC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1180")]
		public LegacyCV2Result<None> UERIDSTCNOG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1181")]
		public LegacyCV2Result<None> MGJQBQJYQRL(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1182")]
		public LegacyCV2Result<None> FOMSLUSZBSO(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "181")]
		public LegacyCV2Result<None> UNOEZRJUXGY(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "183")]
		public LegacyCV2Result<None> GetIntFromRROColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "184")]
		public LegacyCV2Result<None> GetColorFromRGB(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "185")]
		public LegacyCV2Result<None> GetColorFromHSV(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "186")]
		public LegacyCV2Result<None> GetRGBFromColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "187")]
		public LegacyCV2Result<None> GetHSVFromColor(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ED50", Offset = "0x2A6DB50", VA = "0x182A6ED50", Slot = "188")]
		public bool ZYDXNDVSENE(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1183")]
		public LegacyCV2Result<None> RTWEPUBTLVA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1184")]
		public LegacyCV2Result<None> NMSEUMDLHGZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1185")]
		public LegacyCV2Result<None> XDYXRHZTNWW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(BWRMFYYLKFG e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1197")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1186")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1187")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1188")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1189")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1190")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1191")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1192")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1193")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1194")]
		public LegacyCV2Result<None> BYOZGAVFZDV(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1195")]
		public LegacyCV2Result<None> MFSWVDBNLBN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "246")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(BWRMFYYLKFG e, InOut io, JPLRNGKETFJ objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "247")]
		public LegacyCV2Result<None> ZNPFDYIFLVA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "248")]
		public LegacyCV2Result<None> CSBDBCFEXKG(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "249")]
		public LegacyCV2Result<None> DGLETGJVXCK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "250")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "251")]
		public LegacyCV2Result<None> AVDESDBHSCD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "252")]
		public LegacyCV2Result<None> CBVNCVDCTAN(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "253")]
		public LegacyCV2Result<None> UYEMWMADXYR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "254")]
		public LegacyCV2Result<None> XWHASDPEAIS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "255")]
		public LegacyCV2Result<None> RJHAYYSBGFU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "256")]
		public LegacyCV2Result<None> GUZBVSDZMHF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "257")]
		public LegacyCV2Result<None> XJIIGUIHQDZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "258")]
		public LegacyCV2Result<None> IPHFJUOKGAB(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "259")]
		public LegacyCV2Result<None> QLPLPFRZLZP(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "260")]
		public LegacyCV2Result<None> MBETQAFWTNU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "261")]
		public LegacyCV2Result<None> GROHQQSJXLU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "262")]
		public LegacyCV2Result<None> VHRCLBYYJCW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "263")]
		public LegacyCV2Result<None> PIPRUMPPBDC(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "264")]
		public LegacyCV2Result<None> IPCGIUIWFIE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "265")]
		public LegacyCV2Result<None> GUXXZDITRWW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "266")]
		public LegacyCV2Result<None> PKAIHGUGDFU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "267")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "268")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "269")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		private static LegacyCV2Result<None> Default(BWRMFYYLKFG e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A6EC00", Offset = "0x2A6DA00", VA = "0x182A6EC00", Slot = "1198")]
		public LegacyCV2Result<None> HPKISCKGAFP(BWRMFYYLKFG a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1201")]
		public LegacyCV2Result<None> EPQOSYDBKRS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1202")]
		public LegacyCV2Result<None> ADUKKDEMZQK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1203")]
		public LegacyCV2Result<None> IYXQBHOSIGU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1204")]
		public LegacyCV2Result<None> VPSBVRHHBZD(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1199")]
		public LegacyCV2Result<None> ConstantQuickChatTable(BWRMFYYLKFG e, InOut io, LRDAIBJOUPH quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1200")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1025")]
		public LegacyCV2Result<None> WCROAJSIDXM(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1026")]
		public LegacyCV2Result<None> VVUXZDYIUBA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1027")]
		public LegacyCV2Result<None> BLDVCITVOPI(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1028")]
		public LegacyCV2Result<None> YRSMLRTVCFA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1029")]
		public LegacyCV2Result<None> HBGRNYKPRFS(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1030")]
		public LegacyCV2Result<None> VUQLVJETQOQ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1031")]
		public LegacyCV2Result<None> JMMSREXHDOO(BWRMFYYLKFG a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1032")]
		public LegacyCV2Result<None> MKFLCNALASA(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1033")]
		public LegacyCV2Result<None> FNZXVPBCFTW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1034")]
		public LegacyCV2Result<None> SZNFRUEVIQH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1035")]
		public LegacyCV2Result<None> EKKNJBGINIH(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1208")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1209")]
		public LegacyCV2Result<None> HandleSetControlLabel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1210")]
		public LegacyCV2Result<None> HandleGetControlLabel(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1211")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1212")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1213")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1214")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1215")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RCPENMCKVVD(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1222")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1223")]
		public LegacyCV2Result<None> EUOOTJUOGFW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1224")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1225")]
		public LegacyCV2Result<None> DXAXRLYASDF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1226")]
		public LegacyCV2Result<None> ElementSnapToElement(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1227")]
		public LegacyCV2Result<None> ElementUnsnap(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1228")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1229")]
		public LegacyCV2Result<None> SnapPointUnsnap(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1216")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1217")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1218")]
		public LegacyCV2Result<None> ILIPDKMHLST(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1219")]
		public LegacyCV2Result<None> GetTexture(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1220")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1221")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1230")]
		public LegacyCV2Result<None> YSCLOWAGOCZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1231")]
		public LegacyCV2Result<None> VVDODKURHSE(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1232")]
		public LegacyCV2Result<None> NMPOFBBAOZK(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1233")]
		public LegacyCV2Result<None> PHNOHFNIDQU(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1234")]
		public LegacyCV2Result<None> OPKXYADVKAZ(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1235")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RGNEDTIAOKR(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1236")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RLBGYOMWFQF(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1237")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MEVNAEQHSCJ(BWRMFYYLKFG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A6ED60", Offset = "0x2A6DB60", VA = "0x182A6ED60")]
		public TWSRNVOLSJK([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1249")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1256")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1257")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1258")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1259")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1260")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1261")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1262")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1264")]
		public LegacyCV2Result<None> ConstantBodyPart(BWRMFYYLKFG e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1265")]
		public LegacyCV2Result<None> TIHKWLFTDVW(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1266")]
		public LegacyCV2Result<None> WKQFNJVDRUF(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1267")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "590")]
		public LegacyCV2Result<None> SLUORTYBYOR(BWRMFYYLKFG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1268")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1269")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1270")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1271")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1272")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1273")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1274")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1275")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1276")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1277")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1278")]
		public LegacyCV2Result<None> JDFPTGCEQWS(DUFJLFQSONL e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1279")]
		public LegacyCV2Result<None> ZGRBYZXUCLH(DUFJLFQSONL e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1280")]
		public LegacyCV2Result<None> WMJEDUGXFXQ(DUFJLFQSONL e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1281")]
		public LegacyCV2Result<None> XCJWEHKTFFM(DUFJLFQSONL e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1282")]
		public LegacyCV2Result<None> IIWXIQMZYNL(DUFJLFQSONL e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		public LegacyCV2Result<None> ConstantStorefrontItem(BWRMFYYLKFG e, InOut io, [In] CLQVSPAUGTW storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1206")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1207")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(BWRMFYYLKFG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1196")]
		private LegacyCV2Result<None> TMQEJPPRHQE(BWRMFYYLKFG a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1205")]
		private LegacyCV2Result<None> RANYVUNUKUL(BWRMFYYLKFG a, InOut b, [In] CLQVSPAUGTW storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "1246")]
		private LegacyCV2Result<None> BYPWJWRIKDD(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class WKWYXSLTTGZ : VEDDNCWIPBI
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(MVSWGLQBHFH node);

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly WKWYXSLTTGZ VSOKYOXGMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate NXDZAOAAQDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate HRMZWUEQDGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool JTAUKFYLCTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool EGWSGEBYHBK;

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00", Slot = "4")]
		public Task<bool> NTOVLDNYCFV(MVSWGLQBHFH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D870", Offset = "0x2A7C670", VA = "0x182A7D870", Slot = "5")]
		public Task<bool> RWNIRMMTKRA(MVSWGLQBHFH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D920", Offset = "0x2A7C720", VA = "0x182A7D920")]
		public WKWYXSLTTGZ([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D850", Offset = "0x2A7C650", VA = "0x182A7D850", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? PORHPCQLRSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360", Slot = "7")]
		public bool HSCVNHIHJIE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x15CB330", Offset = "0x15CA130", VA = "0x1815CB330", Slot = "8")]
		public bool BNOGDATYTFO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class QDLNYWPPJED : KWQQACIVYJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid BXKTEAVDGGX
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xEC6860", Offset = "0xEC5660", VA = "0x180EC6860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void Bind(CIHPXHRNCEU pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x10F2410", Offset = "0x10F1210", VA = "0x1810F2410")]
		public QDLNYWPPJED(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A4B0", Offset = "0x2A792B0", VA = "0x182A7A4B0")]
		public static QDLNYWPPJED New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class UTPZHHYPOSJ : YSQLFCEEYAV
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<ANEJQQKWRHI> nodeDefId, Id128<DINEWLJZVXU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<DINEWLJZVXU>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private IsNodeRestrictedDelegate? FDCRELDSIBI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ARVEKWCDSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool NGMYJPXQQQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D6B0", Offset = "0x2A7C4B0", VA = "0x182A7D6B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool APHMBLXTWWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x209AB00", Offset = "0x2099900", VA = "0x18209AB00", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "6")]
		public bool IEBRPMWRXAS(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType MDODTJZHDXV(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D6C0", Offset = "0x2A7C4C0", VA = "0x182A7D6C0", Slot = "8")]
		public bool QNLEXRHLPAW(Id128<ANEJQQKWRHI> nodeDefId, Id128<DINEWLJZVXU>? legacyInnerGraphId, IReadOnlyDictionary<Id128<DINEWLJZVXU>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
		public bool OEJPSGEHGDT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "10")]
		public bool DOUKJKOERDT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D710", Offset = "0x2A7C510", VA = "0x182A7D710")]
		public UTPZHHYPOSJ(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class DBDLOXQFJZT : AWORASTHAQC
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly DBDLOXQFJZT VSOKYOXGMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ShouldLogEventSenderToMakerPenDelegate WIJPZYLQHZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate XJSAFHOONEB;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ITWHRZMCYDL
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BCBF0", VA = "0x1812BDDF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool VKMSJFCNSIB
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x2A75680", Offset = "0x2A74480", VA = "0x182A75680", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x2A75720", Offset = "0x2A74520", VA = "0x182A75720")]
		public DBDLOXQFJZT([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class WGPNFPJRDPD : NHOYZCPQYWI
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class RPLMRSOQDLU : PCBETNOGNXB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly RPLMRSOQDLU GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool ZGWVPPYLWBK
			{
				[Cpp2IlInjected.Token(Token = "0x600074C")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A510", Offset = "0x2A79310", VA = "0x182A7A510", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			public void BPZXAXKNMSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RPLMRSOQDLU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly WGPNFPJRDPD GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private WGPNFPJRDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D790", Offset = "0x2A7C590", VA = "0x182A7D790", Slot = "4")]
		public PCBETNOGNXB RMUULWGIHOS()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class IBRXNUHZXBT<a, b> : IDisposable, OYPORLQHLJO where a : notnull where b : notnull, BLFPTQUQJQP.XZBYKVFOQNN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly b JGLYIVPXDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly a GJDPHSBKQPK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<YCAINYDNLEL> NVSFGYYCCSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YCAINYDNLEL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x52C99F0", Offset = "0x52C87F0", VA = "0x1852C99F0")]
		public IBRXNUHZXBT(b a, a b, Id32<YCAINYDNLEL> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x52C7B60", Offset = "0x52C6960", VA = "0x1852C7B60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x52C8FC0", Offset = "0x52C7DC0", VA = "0x1852C8FC0")]
		public Id32<DMDLWDYEPPG> TVLRBCBVJDL([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<DMDLWDYEPPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x52C95C0", Offset = "0x52C83C0", VA = "0x1852C95C0", Slot = "6")]
		public void ZOKTQDCGBEO(Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x52C9370", Offset = "0x52C8170", VA = "0x1852C9370", Slot = "7")]
		public void XSEICIBOPTC(Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x52C8440", Offset = "0x52C7240", VA = "0x1852C8440", Slot = "8")]
		public void LSIEPYXSRLD(Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x52C8D10", Offset = "0x52C7B10", VA = "0x1852C8D10", Slot = "10")]
		public void PPKGUPWEOWK(Id32<DMDLWDYEPPG> objectId, Id32<YCAINYDNLEL> clientId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x52C7B20", Offset = "0x52C6920", VA = "0x1852C7B20", Slot = "9")]
		public void DLZDNUXSOWE(Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x52C7DC0", Offset = "0x52C6BC0", VA = "0x1852C7DC0", Slot = "11")]
		public void GQIUOEXFVBU(Id32<DMDLWDYEPPG> objectId, OCOZJWLZQSN? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x52C92A0", Offset = "0x52C80A0", VA = "0x1852C92A0", Slot = "12")]
		public Id32<YCAINYDNLEL> XKQCIOLUVWF(Id32<DMDLWDYEPPG> objectId)
		{
			return default(Id32<YCAINYDNLEL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x52C8A50", Offset = "0x52C7850", VA = "0x1852C8A50", Slot = "13")]
		public Id32<RJRZNMVKEWM> PIYTJJWZYBV(Id32<DMDLWDYEPPG> objectId, string a, object b, bool c, QSDFVRLZKQI d, KMEMKTPISBC e)
		{
			return default(Id32<RJRZNMVKEWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x52C7890", Offset = "0x52C6690", VA = "0x1852C7890", Slot = "14")]
		public void ATVKYEUEJJD(Id32<RJRZNMVKEWM> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x52C8790", Offset = "0x52C7590", VA = "0x1852C8790", Slot = "15")]
		public void OLGNAWMGTFP(Id32<RJRZNMVKEWM> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class BLFPTQUQJQP
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface XZBYKVFOQNN<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PECEAHSDULF(a a, Id32<YCAINYDNLEL> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<YCAINYDNLEL>? CECQCIINPAE(a a);

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<DMDLWDYEPPG> TVLRBCBVJDL(a a, Id32<YCAINYDNLEL> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZOKTQDCGBEO(a a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b);

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void XSEICIBOPTC(a a, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b);

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void PPKGUPWEOWK(a a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b);

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void DLZDNUXSOWE(a a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b);

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void GQIUOEXFVBU(a a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, OCOZJWLZQSN? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<YCAINYDNLEL>? XKQCIOLUVWF(a a, Id32<DMDLWDYEPPG> objectId);

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<RJRZNMVKEWM> PIYTJJWZYBV(a a, Id32<YCAINYDNLEL> clientId, string b, object c, QSDFVRLZKQI d, KMEMKTPISBC e);

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void ATVKYEUEJJD(a a, Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void OLGNAWMGTFP(a a, Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class DBSTUGVXXUP
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly HashSet<Id32<DMDLWDYEPPG>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public SOAId32Field<RJRZNMVKEWM, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly Dictionary<Id32<RJRZNMVKEWM>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<RJRZNMVKEWM>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAField<DMDLWDYEPPG, OCOZJWLZQSN?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A150", Offset = "0x2A78F50", VA = "0x182A7A150")]
			private MockCV2DynamicNetSys(HashSet<Id32<DMDLWDYEPPG>> authorityOf, [In] SOAId32Field<RJRZNMVKEWM, MockCV2SyncField> syncFields, Dictionary<Id32<RJRZNMVKEWM>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<RJRZNMVKEWM>> mockSyncFieldToSyncField, [In] SOAField<DMDLWDYEPPG, OCOZJWLZQSN?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x2A79F90", Offset = "0x2A78D90", VA = "0x182A79F90")]
			public static MockCV2DynamicNetSys New()
			{
				return default(MockCV2DynamicNetSys);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private struct MockCV2ObjectShared
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public Id32<YCAINYDNLEL>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A1F0", Offset = "0x2A78FF0", VA = "0x182A7A1F0")]
			public MockCV2ObjectShared(Id32<YCAINYDNLEL> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public KMEMKTPISBC SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public QSDFVRLZKQI SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			internal MockCV2SyncField(KMEMKTPISBC syncField, QSDFVRLZKQI syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A310", Offset = "0x2A79110", VA = "0x182A7A310")]
			public static MockCV2SyncField New(KMEMKTPISBC syncField, QSDFVRLZKQI syncFieldChangeHandler)
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
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public object Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public int Uses;

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A2C0", Offset = "0x2A790C0", VA = "0x182A7A2C0")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A270", Offset = "0x2A79070", VA = "0x182A7A270")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private SOAId32Field<DMDLWDYEPPG, MockCV2ObjectShared> CQELMJDTJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<DMDLWDYEPPG>> PLSQVSEGVBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> FGWABBILQAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> KGUWVHFFOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private SOAField<YCAINYDNLEL, MockCV2DynamicNetSys> WLLYMFZFBAQ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<DMDLWDYEPPG>? ZHUNNQRALZK
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x1276900", Offset = "0x1275700", VA = "0x181276900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2A75D20", Offset = "0x2A74B20", VA = "0x182A75D20")]
		public void Destroy([In] SOAId32<YCAINYDNLEL> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2A76030", Offset = "0x2A74E30", VA = "0x182A76030")]
		public void KRJZETGSIEN(Id32<YCAINYDNLEL> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2A76800", Offset = "0x2A75600", VA = "0x182A76800")]
		public void PECEAHSDULF(Id32<YCAINYDNLEL> clientId, Id32<YCAINYDNLEL>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2A76EB0", Offset = "0x2A75CB0", VA = "0x182A76EB0")]
		public Id32<DMDLWDYEPPG> TVLRBCBVJDL(Id32<YCAINYDNLEL> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<YCAINYDNLEL> clientIds)
		{
			return default(Id32<DMDLWDYEPPG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2A76B50", Offset = "0x2A75950", VA = "0x182A76B50")]
		public Id32<RJRZNMVKEWM> PIYTJJWZYBV(Id32<YCAINYDNLEL> clientId, string a, object b, QSDFVRLZKQI c, KMEMKTPISBC d)
		{
			return default(Id32<RJRZNMVKEWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2A75A10", Offset = "0x2A74810", VA = "0x182A75A10")]
		public void ATVKYEUEJJD(Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2A772C0", Offset = "0x2A760C0", VA = "0x182A772C0")]
		public Id32<DMDLWDYEPPG>? WGLNHMCFBHW([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2A77520", Offset = "0x2A76320", VA = "0x182A77520")]
		public void ZOKTQDCGBEO([In] SOAId32<YCAINYDNLEL> clientIds, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2A773E0", Offset = "0x2A761E0", VA = "0x182A773E0")]
		public void XSEICIBOPTC(Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2A76DB0", Offset = "0x2A75BB0", VA = "0x182A76DB0")]
		public void PPKGUPWEOWK(Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2A75BA0", Offset = "0x2A749A0", VA = "0x182A75BA0")]
		public void DLZDNUXSOWE([In] SOAId32<YCAINYDNLEL> clientIds, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2A75F60", Offset = "0x2A74D60", VA = "0x182A75F60")]
		public void GQIUOEXFVBU(Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, OCOZJWLZQSN? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2A77390", Offset = "0x2A76190", VA = "0x182A77390")]
		public Id32<YCAINYDNLEL>? XKQCIOLUVWF(Id32<DMDLWDYEPPG> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2A76490", Offset = "0x2A75290", VA = "0x182A76490")]
		public void OLGNAWMGTFP([In] SOAId32<YCAINYDNLEL> clientIds, Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2A775A0", Offset = "0x2A763A0", VA = "0x182A775A0")]
		public DBSTUGVXXUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class MNRMZICOGQK
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2A798D0", Offset = "0x2A786D0", VA = "0x182A798D0")]
		public static void Destroy(this DBSTUGVXXUP.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ZNVGQMXGQWU : RGYBKVXVHBK.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static ZNVGQMXGQWU PFLKCBKVJMJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate XQQJRZJWEDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate QAMUMAJPQBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public ZNVGQMXGQWU(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class YSDFEASZWFK : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : XQXZMUBXLZL.QFLDHTOWAFU<TWGQWHZWPAR, YSDFEASZWFK>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000096")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public AsyncTaskMethodBuilder<Result<object, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public YSDFEASZWFK root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public Id32<YCAINYDNLEL> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public TWGQWHZWPAR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private TaskAwaiter<Result<object, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x2A7C480", Offset = "0x2A7B280", VA = "0x182A7C480", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x2A7C6C0", Offset = "0x2A7B4C0", VA = "0x182A7C6C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
			public int TKJQFCXPDOU(YSDFEASZWFK a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A700", Offset = "0x2A79500", VA = "0x182A7A700", Slot = "5")]
			public int NFMPCAPEQJK(YSDFEASZWFK a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A720", Offset = "0x2A79520", VA = "0x182A7A720", Slot = "6")]
			public int UZAFVYNSNKT(YSDFEASZWFK a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xF81430", Offset = "0xF80230", VA = "0x180F81430", Slot = "7")]
			public int BSHILDBKITZ(YSDFEASZWFK a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A740", Offset = "0x2A79540", VA = "0x182A7A740", Slot = "8")]
			public void YWJTXHAPEPI(YSDFEASZWFK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
			public bool JPVFAMKTODJ(YSDFEASZWFK a, Id32<YCAINYDNLEL> actorId, TWGQWHZWPAR[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "10")]
			public bool UNIXUYNVGAN(YSDFEASZWFK a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A5B0", Offset = "0x2A793B0", VA = "0x182A7A5B0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, IGWAJAWUKJF>> LPHQPRKRJUZ(YSDFEASZWFK a, Id32<YCAINYDNLEL> senderId, TWGQWHZWPAR b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : XQXZMUBXLZL.XZMMFITJJKF<ActionDeps, SQESMBBMMXQ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps DVNQKRUYLUT
			{
				[Cpp2IlInjected.Token(Token = "0x6000798")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public SQESMBBMMXQ.StaticNetSysReceiverDeps GDJIGDISKVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "5")]
				get
				{
					return default(SQESMBBMMXQ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps ZMLMIOGTBQV
			{
				[Cpp2IlInjected.Token(Token = "0x600079A")]
				[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : OWELNGOUXAD.XZBYKVFOQNN<YSDFEASZWFK>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			[CompilerGenerated]
			private struct <SendActionToAll>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public AsyncTaskMethodBuilder<Result<object?, IGWAJAWUKJF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public YSDFEASZWFK root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public Id32<YCAINYDNLEL> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public TWGQWHZWPAR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private TaskAwaiter<Result<object?, IGWAJAWUKJF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600079C")]
				[Cpp2IlInjected.Address(RVA = "0x2A7C160", Offset = "0x2A7AF60", VA = "0x182A7C160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x2A7C410", Offset = "0x2A7B210", VA = "0x182A7C410", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A350", Offset = "0x2A79150", VA = "0x182A7A350", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, IGWAJAWUKJF>> LPHQPRKRJUZ(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, TWGQWHZWPAR b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : BLFPTQUQJQP.XZBYKVFOQNN<YSDFEASZWFK>
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C10", Offset = "0x2A78A10", VA = "0x182A79C10", Slot = "4")]
			public void PECEAHSDULF(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0xF814D0", Offset = "0xF802D0", VA = "0x180F814D0", Slot = "5")]
			public Id32<YCAINYDNLEL>? CECQCIINPAE(YSDFEASZWFK a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x2A79CE0", Offset = "0x2A78AE0", VA = "0x182A79CE0")]
			public Id32<DMDLWDYEPPG> TVLRBCBVJDL(YSDFEASZWFK a, Id32<YCAINYDNLEL> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<DMDLWDYEPPG>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A79F00", Offset = "0x2A78D00", VA = "0x182A79F00", Slot = "7")]
			public void ZOKTQDCGBEO(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A79DA0", Offset = "0x2A78BA0", VA = "0x182A79DA0", Slot = "8")]
			public void XSEICIBOPTC(YSDFEASZWFK a, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A79CA0", Offset = "0x2A78AA0", VA = "0x182A79CA0", Slot = "9")]
			public void PPKGUPWEOWK(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A79AD0", Offset = "0x2A788D0", VA = "0x182A79AD0", Slot = "10")]
			public void DLZDNUXSOWE(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, AONVCVTLWUL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A79B00", Offset = "0x2A78900", VA = "0x182A79B00", Slot = "11")]
			public void GQIUOEXFVBU(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<DMDLWDYEPPG> objectId, OCOZJWLZQSN? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A79D40", Offset = "0x2A78B40", VA = "0x182A79D40", Slot = "12")]
			public Id32<YCAINYDNLEL>? XKQCIOLUVWF(YSDFEASZWFK a, Id32<DMDLWDYEPPG> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A79C40", Offset = "0x2A78A40", VA = "0x182A79C40", Slot = "13")]
			public Id32<RJRZNMVKEWM> PIYTJJWZYBV(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, string b, object c, QSDFVRLZKQI d, KMEMKTPISBC e)
			{
				return default(Id32<RJRZNMVKEWM>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A79930", Offset = "0x2A78730", VA = "0x182A79930", Slot = "14")]
			public void ATVKYEUEJJD(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A79BE0", Offset = "0x2A789E0", VA = "0x182A79BE0", Slot = "15")]
			public void OLGNAWMGTFP(YSDFEASZWFK a, Id32<YCAINYDNLEL> clientId, Id32<RJRZNMVKEWM> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A79CE0", Offset = "0x2A78AE0", VA = "0x182A79CE0", Slot = "6")]
			private Id32<DMDLWDYEPPG> VVSTYLBWUWH(YSDFEASZWFK a, Id32<YCAINYDNLEL> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<DMDLWDYEPPG>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private struct <RetainClient>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public AsyncTaskMethodBuilder<EVCreationResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public YSDFEASZWFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Id32<DMDLWDYEPPG>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public GMJPGHKCHRR deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<YCAINYDNLEL> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private CPMALVBEJKV<YSDFEASZWFK, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private IBRXNUHZXBT<YSDFEASZWFK, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private SQESMBBMMXQ <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BAA0", Offset = "0x2A7A8A0", VA = "0x182A7BAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A7C0F0", Offset = "0x2A7AEF0", VA = "0x182A7C0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly LGQVLHNBNBJ<TWGQWHZWPAR, None, SQESMBBMMXQ, ActionDeps, SQESMBBMMXQ.StaticNetSysReceiverDeps, RootDeps, YSDFEASZWFK, Deps> RHWXUWVLBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly DBSTUGVXXUP MIKAWBHQOUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAId32<YCAINYDNLEL> SSFNVTBQXIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<YCAINYDNLEL, None> WLLYMFZFBAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<YCAINYDNLEL, SQESMBBMMXQ> YNZZGNMHJQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Id32<YCAINYDNLEL>? WOVQZVLCSBL;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate BGBYNKKYGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2A7E1E0", Offset = "0x2A7CFE0", VA = "0x182A7E1E0")]
		public YSDFEASZWFK(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DB20", Offset = "0x2A7C920", VA = "0x182A7DB20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DDD0", Offset = "0x2A7CBD0", VA = "0x182A7DDD0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> KRJZETGSIEN(GMJPGHKCHRR a, RegistryV2 b, Id32<DMDLWDYEPPG>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DF50", Offset = "0x2A7CD50", VA = "0x182A7DF50")]
		private void PECEAHSDULF(Id32<YCAINYDNLEL> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DCF0", Offset = "0x2A7CAF0", VA = "0x182A7DCF0")]
		[CompilerGenerated]
		private Id32<DMDLWDYEPPG>? IOGQBZSNNNJ([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class EEOQCCLKSMR : LPFVMTQVGRX.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<YOFTFORYWYQ> DeserializeCircuitsJunctionAsyncDelegate(SQESMBBMMXQ circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public AsyncTaskMethodBuilder<YOFTFORYWYQ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public EEOQCCLKSMR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public SQESMBBMMXQ circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private TaskAwaiter<YOFTFORYWYQ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A790", Offset = "0x2A79590", VA = "0x182A7A790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A990", Offset = "0x2A79790", VA = "0x182A7A990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate EUBCZFXTZMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? HHJIQJULXKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? XRKDEPSHIPH;

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A786B0", Offset = "0x2A774B0", VA = "0x182A786B0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<YOFTFORYWYQ> KEXERYEUZMZ(SQESMBBMMXQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xFF9A20", Offset = "0xFF8820", VA = "0x180FF9A20", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x10AD800", Offset = "0x10AC600", VA = "0x1810AD800", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A78820", Offset = "0x2A77620", VA = "0x182A78820")]
		public EEOQCCLKSMR([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class DJQIZOURKZD : TJDAFASHBMR.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate KLWLFKHUOPD GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<OMPJFSIDVZF> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<MMCRDVBAEMD> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<TJDAFASHBMR.ZLOMSCLYJNW.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate Task<StaticCircuitsConfig> GetStaticCircuitsConfigAsyncDelegate(CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private struct <GetCircuitGraphToolMappingAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public AsyncTaskMethodBuilder<TJDAFASHBMR.ZLOMSCLYJNW.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<TJDAFASHBMR.ZLOMSCLYJNW.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AA00", Offset = "0x2A79800", VA = "0x182A7AA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0x2A7ABF0", Offset = "0x2A799F0", VA = "0x182A7ABF0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public AsyncTaskMethodBuilder<MMCRDVBAEMD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter<MMCRDVBAEMD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AC60", Offset = "0x2A79A60", VA = "0x182A7AC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AE50", Offset = "0x2A79C50", VA = "0x182A7AE50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public AsyncTaskMethodBuilder<OMPJFSIDVZF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<OMPJFSIDVZF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2A7AEC0", Offset = "0x2A79CC0", VA = "0x182A7AEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B0B0", Offset = "0x2A79EB0", VA = "0x182A7B0B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AsyncTaskMethodBuilder<CircuitRootData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B120", Offset = "0x2A79F20", VA = "0x182A7B120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B310", Offset = "0x2A7A110", VA = "0x182A7B310", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AsyncTaskMethodBuilder<StaticCircuitsConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B380", Offset = "0x2A7A180", VA = "0x182A7B380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B570", Offset = "0x2A7A370", VA = "0x182A7B570", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AsyncTaskMethodBuilder<SuperRoomData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public DJQIZOURKZD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B5E0", Offset = "0x2A7A3E0", VA = "0x182A7B5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B7D0", Offset = "0x2A7A5D0", VA = "0x182A7B7D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly GetCV2DependenciesDelegate KLLCOREYBDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetRoomDataAsyncDelegate HSEPIHCBJBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetSuperRoomDataAsyncDelegate UMMOCIULTCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomAssetDataAsyncDelegate UPNMPYOILAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetPlayerSaveDataAsyncDelegate ZWXXYRPCVXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate MNZNUAROFHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetStaticCircuitsConfigAsyncDelegate UGAMLFTIKIP;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KLWLFKHUOPD KLWLFKHUOPD
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BCBF0", VA = "0x1812BDDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A77740", Offset = "0x2A76540", VA = "0x182A77740", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> EDSKYKCEVZE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A77C90", Offset = "0x2A76A90", VA = "0x182A77C90", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> XWKBEBJDVXT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A77A70", Offset = "0x2A76870", VA = "0x182A77A70", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<OMPJFSIDVZF> TQJQNJPYCEO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A77960", Offset = "0x2A76760", VA = "0x182A77960", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<MMCRDVBAEMD> RNCYVNNSMAT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A77B80", Offset = "0x2A76980", VA = "0x182A77B80", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<TJDAFASHBMR.ZLOMSCLYJNW.CircuitGraphToolMapping> VYUXAAZINPC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A77850", Offset = "0x2A76650", VA = "0x182A77850", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> MPQBQBQSXSH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A77DA0", Offset = "0x2A76BA0", VA = "0x182A77DA0")]
		public DJQIZOURKZD(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class FTOBHOTZSMJ : CV2Request.ZLOMSCLYJNW
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CV2Request.ZLOMSCLYJNW GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly GetCanSendRequestsDelegate YJRKYKUEFDX;

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public FTOBHOTZSMJ(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BCBF0", VA = "0x1812BDDF0", Slot = "4")]
		public bool JJXRCYYBILX()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class EMAFYROTSSK : EMOXSDWCFKN
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, XDRQUNZRUHP> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly TryReportErrToUserDelegate MGUCCHWXTOT;

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00")]
		public bool HXHYXAIYMXB([In] Result<None, XDRQUNZRUHP> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A30", Offset = "0x2A77830", VA = "0x182A78A30")]
		public EMAFYROTSSK([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00", Slot = "4")]
		private bool UCPRTOIGCJG([In] Result<None, XDRQUNZRUHP> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class IEWGCYAAWFB : VADHWBRYBMQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate BWRMFYYLKFG CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly IEWGCYAAWFB GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CurrentExecParamsDelegate? YFSOZPTEWXX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public BWRMFYYLKFG JPYOYELUYJN
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x12BDDF0", Offset = "0x12BCBF0", VA = "0x1812BDDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public IEWGCYAAWFB([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class UOOHUQRLBSH : OBAYIOUBMIS
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly OBAYIOUBMIS GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly GetGameColorFromIdDelegate LSMZWWYGZDZ;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00", Slot = "4")]
		public CircuitsColor KMDJSLCIOTN(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D510", Offset = "0x2A7C310", VA = "0x182A7D510")]
		public UOOHUQRLBSH([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class LZSKSHQWLOT : HJJZQHCBFAG
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public delegate Task<bool> IsStringPureAsyncDelegate(string value, string context);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private struct <IsStringPureAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public LZSKSHQWLOT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7B840", Offset = "0x2A7A640", VA = "0x182A7B840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BA30", Offset = "0x2A7A830", VA = "0x182A7BA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly IsStringPureAsyncDelegate RHKDKZHXZCW;

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2A795E0", Offset = "0x2A783E0", VA = "0x182A795E0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> BOCUIDZLYIE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2A79720", Offset = "0x2A78520", VA = "0x182A79720")]
		public LZSKSHQWLOT([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class KPHEBDDQBXX : CNVYILPYZTW
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate YHYTRIRIJPC? GetNodeVisualizationConfigDelegate([In] Id128<ANEJQQKWRHI> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly CNVYILPYZTW GUIRZRNRSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly GetNodeVisualizationConfigDelegate QLFUFFOXSRL;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00")]
		public YHYTRIRIJPC? KPWRLXBQWAR([In] Id128<ANEJQQKWRHI> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2A79120", Offset = "0x2A77F20", VA = "0x182A79120")]
		public KPHEBDDQBXX([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2A78A00", Offset = "0x2A77800", VA = "0x182A78A00", Slot = "4")]
		private YHYTRIRIJPC MYYEAFCXIYH([In] Id128<ANEJQQKWRHI> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class DOZEDKXMALW : QKASVDEMKQP
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x2A78580", Offset = "0x2A77380", VA = "0x182A78580", Slot = "4")]
		public ICIPOMWZVOI TJRCTBXCGZO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DOZEDKXMALW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class LSRNOPZOSUY : BGNXQNLAHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly Dictionary<string, bool> OLZJCVQQKZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, float> HGEKZMKXOMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, double> EYUBBECCVTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, int> DJULAPVRXBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, long> EXGJKQJTGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, string> KEBDVBAOZBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, uint> CQQLWWNEQUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, ulong> VKKYUFFVTLA;

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2A792D0", Offset = "0x2A780D0", VA = "0x182A792D0", Slot = "4")]
		public bool? UGLAWNIISIN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2A79370", Offset = "0x2A78170", VA = "0x182A79370")]
		public LSRNOPZOSUY()
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
