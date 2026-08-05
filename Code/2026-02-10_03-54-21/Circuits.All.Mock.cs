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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x2888240", Offset = "0x2887440", VA = "0x182888240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		internal sealed class SGSIGTBOUCM : VWEUPIINCCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public SGSIGTBOUCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810", Slot = "4")]
			public VWEUPIINCCP OKPCUYKBBPF(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810", Slot = "5")]
			public VWEUPIINCCP ZXIOQXNMDHY(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810", Slot = "6")]
			public VWEUPIINCCP CTGZSSWCFOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			public void QIOJAOPXSKN()
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
	public static class THDPOCZIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PWPEITYPPDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public DTXINBLHAUG VAONYYHMXPF;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PWPEITYPPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x288CAA0", Offset = "0x288BCA0", VA = "0x18288CAA0")]
			internal PZCZATDXERS IFZHLZIJXRQ(GetNetworkObjectDelegate a)
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
			public QGBMHGUBIHM dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public FLBRYQMQISN network;

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
			[Cpp2IlInjected.Address(RVA = "0x288FA50", Offset = "0x288EC50", VA = "0x18288FA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x28900F0", Offset = "0x288F2F0", VA = "0x1828900F0", Slot = "5")]
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
			public FLBRYQMQISN network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public QGBMHGUBIHM dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<EWGMMJRBQBF>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private RRHCIMKELZN <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2890160", Offset = "0x288F360", VA = "0x182890160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x28906F0", Offset = "0x288F8F0", VA = "0x1828906F0", Slot = "5")]
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
			public DTXINBLHAUG roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2890760", Offset = "0x288F960", VA = "0x182890760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2890C70", Offset = "0x288FE70", VA = "0x182890C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x288F0B0", Offset = "0x288E2B0", VA = "0x18288F0B0")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? OANIHXFTRCQ([Optional] DTXINBLHAUG? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x288F270", Offset = "0x288E470", VA = "0x18288F270")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> WWNYQTOWRRD(FLBRYQMQISN a, [Optional] QGBMHGUBIHM? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x288F3F0", Offset = "0x288E5F0", VA = "0x18288F3F0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> WWNYQTOWRRD(FLBRYQMQISN a, QGBMHGUBIHM b, RegistryV2 c, Id32<EWGMMJRBQBF>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x288F1A0", Offset = "0x288E3A0", VA = "0x18288F1A0")]
		public static (RuntimeFnRegistry, RuntimeFns) RRMHCWKDFDL()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x288EFB0", Offset = "0x288E1B0", VA = "0x18288EFB0")]
		public static (ExternalFnRegistry, ExternalFns) KLIIXAXOYOW()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x288EF30", Offset = "0x288E130", VA = "0x18288EF30")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static FLBRYQMQISN HWJCSATZJJR(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class SUGAXDJWFRL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate PZCZATDXERS CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public SUGAXDJWFRL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x288F660", Offset = "0x288E860", VA = "0x18288F660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x288F9E0", Offset = "0x288EBE0", VA = "0x18288F9E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly FLBRYQMQISN KPUGTCAUEAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? LBMEQUYOVOD;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		private SUGAXDJWFRL(FLBRYQMQISN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x288ED70", Offset = "0x288DF70", VA = "0x18288ED70")]
		public static SUGAXDJWFRL NEOQDMXJNFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x288EF10", Offset = "0x288E110", VA = "0x18288EF10")]
		public SUGAXDJWFRL UUMBMRLCBDK(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x288EE20", Offset = "0x288E020", VA = "0x18288EE20")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> QIOJAOPXSKN()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class UTJMOYWRTDR : RRHCIMKELZN.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate ZYKWBNETGNH NewCircuitsLifecycleDelegate(HXXVFCDUHKY.ELSNTWPCDON deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(RRHCIMKELZN circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(RRHCIMKELZN circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate GLIOHNZRALY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate BSLBGMHYHIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate NQOCVBCNRYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate GYQYQAVFTWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate HINNKCDEXET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate UPQBTGDITYW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TQOXMETRDYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x106A460", Offset = "0x1069660", VA = "0x18106A460", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2892070", Offset = "0x2891270", VA = "0x182892070", Slot = "6")]
		public void NWHVHMPYKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28920A0", Offset = "0x28912A0", VA = "0x1828920A0", Slot = "7")]
		public void QUIRETUARDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2892040", Offset = "0x2891240", VA = "0x182892040", Slot = "5")]
		public ZYKWBNETGNH NSYAKSTAQEO(HXXVFCDUHKY.ELSNTWPCDON a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCABD40", Offset = "0xCAAF40", VA = "0x180CABD40", Slot = "8")]
		public void TIVWYLEYFZZ(RRHCIMKELZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCABC20", Offset = "0xCAAE20", VA = "0x180CABC20", Slot = "9")]
		public void UHQCLFSSZKE(RRHCIMKELZN a, USPEKNRWVPE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28920D0", Offset = "0x28912D0", VA = "0x1828920D0")]
		public UTJMOYWRTDR([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly TYTYGWVULLU<FLBRYQMQISN, FLBRYQMQISN.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly UEZCSOSHWMK<FLBRYQMQISN, FLBRYQMQISN.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly RRHCIMKELZN CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<WBUFIROFFZC> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly FLBRYQMQISN Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2884800", Offset = "0x2883A00", VA = "0x182884800")]
		public EVCreationResult(TYTYGWVULLU<FLBRYQMQISN, FLBRYQMQISN.MockStaticNetSysDeps> staticNetSys, UEZCSOSHWMK<FLBRYQMQISN, FLBRYQMQISN.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, RRHCIMKELZN circuitsManager, Id32<WBUFIROFFZC> clientId, FLBRYQMQISN network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly RRHCIMKELZN _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 KFYYDMKAFYX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2888180", Offset = "0x2887380", VA = "0x182888180")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request LKRUMWVBRVX
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x28881B0", Offset = "0x28873B0", VA = "0x1828881B0")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public FCZEXSWNMQC? WRUAXHSBXJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2888090", Offset = "0x2887290", VA = "0x182888090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public YGDIPUPKRWC? VGVVQLSXQGB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x28881E0", Offset = "0x28873E0", VA = "0x1828881E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		internal LimitedCircuits(RRHCIMKELZN circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class HAMLWBTVAYP : QGBMHGUBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HGPMXBUUJUN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public PZCZATDXERS BSAOZWPVHDC;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public HGPMXBUUJUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			internal PZCZATDXERS QCFVRHLLYLM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public HXXVFCDUHKY.ELSNTWPCDON ISJJBPAZHRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RRHCIMKELZN.ELSNTWPCDON HLTAHUAHGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PTEMFAIRMBY.ELSNTWPCDON HZPVXQROKXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN> ZAOCERFTHHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ELSNTWPCDON BUISVEIYUDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BKQRFKBWSPS OOZAYYTADBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KCBFZEYCEZD OCFPZNPJYLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PUFXDFRADIJ YYONDGKDFLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public TWDSZOCCEPP WMWORLFYNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SPZWLQEAMOP BUXKODBFIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2885410", Offset = "0x2884610", VA = "0x182885410")]
		private HAMLWBTVAYP(HXXVFCDUHKY.ELSNTWPCDON a, RRHCIMKELZN.ELSNTWPCDON b, PTEMFAIRMBY.ELSNTWPCDON c, RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN> d, CV2Request.ELSNTWPCDON e, BKQRFKBWSPS f, KCBFZEYCEZD g, PUFXDFRADIJ h, TWDSZOCCEPP i, SPZWLQEAMOP j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28850C0", Offset = "0x28842C0", VA = "0x1828850C0")]
		public static HAMLWBTVAYP? ZHLRPRPPTGU(PTEMFAIRMBY.ELSNTWPCDON cv2RootSysDeps, [Optional] HXXVFCDUHKY.ELSNTWPCDON? a, [Optional] RRHCIMKELZN.ELSNTWPCDON? b, [Optional] RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>? reducerDeps, [Optional] CV2Request.ELSNTWPCDON? c, [Optional] BKQRFKBWSPS? d, [Optional] KCBFZEYCEZD? e, [Optional] PUFXDFRADIJ? f, [Optional] TWDSZOCCEPP? g, [Optional] SPZWLQEAMOP? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2884F70", Offset = "0x2884170", VA = "0x182884F70")]
		public static HAMLWBTVAYP OEMVMWSHOPW(PZCZATDXERS a, [Optional] HXXVFCDUHKY.ELSNTWPCDON? circuitsLifecycleDeps, [Optional] RRHCIMKELZN.ELSNTWPCDON? circuitsManagerDeps, [Optional] RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2884C00", Offset = "0x2883E00", VA = "0x182884C00")]
		public static HAMLWBTVAYP IIFXVWOLXLI(GetNetworkObjectDelegate a, [Optional] HXXVFCDUHKY.ELSNTWPCDON? circuitsLifecycleDeps, [Optional] RRHCIMKELZN.ELSNTWPCDON? circuitsManagerDeps, [Optional] RAUANHHVHKA.IRGRAGFCDUQ<ActionKind, USPEKNRWVPE, RRHCIMKELZN>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class PLRCHYRNZYO
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class UITEPKMAORH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GetNetworkObjectDelegate WSDJHWIJZBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int WBGLWSTXTTO;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UITEPKMAORH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2891FD0", Offset = "0x28911D0", VA = "0x182891FD0")]
			internal HYUPTAFTQGX IELSUNTMGFH(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2891E70", Offset = "0x2891070", VA = "0x182891E70")]
			internal HYUPTAFTQGX[] IDAWNSKESDW(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
			internal int UCYBZWJJRJG()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class UINXSDSDFFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public DynamicEnvironmentNetworkId FDWLZCREZGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public UITEPKMAORH BXOYYNWATYZ;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UINXSDSDFFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2891DC0", Offset = "0x2890FC0", VA = "0x182891DC0")]
			internal HYUPTAFTQGX OCZXDNBWZGP(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MMFRHKTHWJJ SWQZATMIDJO;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28889F0", Offset = "0x2887BF0", VA = "0x1828889F0")]
		public static HYUPTAFTQGX? TILRTDYRZJO(Id32<EWGMMJRBQBF>? networkObject, [Optional] OWYNAQPHOYS.SerializesIntoSavesDelegate? a, [Optional] OWYNAQPHOYS.SerializesIntoInventionsDelegate? b, [Optional] OWYNAQPHOYS.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2888A10", Offset = "0x2887C10", VA = "0x182888A10")]
		public static PZCZATDXERS? TODUMWCXLEF(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] IPREUGGLREP? b, [Optional] AWWUWPORMXN? c, [Optional] JBVFRZIXLOT? d, [Optional] DTXINBLHAUG? e, int f = 300000, bool g = false, bool h = false, [Optional] IOOLZJQPNCL? i, [Optional] GNRODNQUTWH? j, [Optional] RDWEUMIEPIM? k, [Optional] GARURFRBCYP? l, [Optional] UEIFDAUSEFS? m, [Optional] HHHRALSVMDJ? n, [Optional] DHWOCRSWHCF.ELSNTWPCDON? o, [Optional] EqualsNodeV2.ELSNTWPCDON? p, [Optional] ZFMOZXUXWVN? q, [Optional] PZCZATDXERS.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] PZCZATDXERS.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] PZCZATDXERS.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] PZCZATDXERS.GetLocalRoomIdDelegate? u, [Optional] PZCZATDXERS.GetLocalSubroomIdDelegate? v, [Optional] PZCZATDXERS.GetSubroomIdsForLocalRoomDelegate? w, [Optional] PZCZATDXERS.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] PZCZATDXERS.SaveRoomOnPlayerBehalfDelegate? z, [Optional] PZCZATDXERS.ReportCloudDataLedgerChangedDelegate? ba, [Optional] PZCZATDXERS.GetColorNameByIdDelegate? bb, [Optional] PZCZATDXERS.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] PZCZATDXERS.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] PZCZATDXERS.GetTaggableNameFromSignalDelegate? be, [Optional] PZCZATDXERS.GetAudioNameFromSignalDelegate? bf, [Optional] PZCZATDXERS.GetDestinationNameFromSignalDelegate? bg, [Optional] PZCZATDXERS.GetPlayerEventNameFromSignalDelegate? bh, [Optional] PZCZATDXERS.GetRoomKeyNameFromSignalDelegate? bi, [Optional] PZCZATDXERS.GetRewardNameFromSignalDelegate? bj, [Optional] PZCZATDXERS.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] PZCZATDXERS.ReportPreloadedAudioChangedDelegate? bl, [Optional] PZCZATDXERS.ReportRewardDataChangedDelegate? bm, [Optional] PZCZATDXERS.GetConsumableNameFromSignalDelegate? bn, [Optional] PZCZATDXERS.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] PZCZATDXERS.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] PZCZATDXERS.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] PZCZATDXERS.GetInventoryItemNameFromSignalDelegate? br, [Optional] PZCZATDXERS.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] PZCZATDXERS.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] PZCZATDXERS.GetRoomOfferNameFromSignalDelegate? bu, [Optional] PZCZATDXERS.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] PZCZATDXERS.GetObjectIdFromCreationObjectDelegate? bw, [Optional] PZCZATDXERS.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] PZCZATDXERS.GetCostInBytesDelegate? by, [Optional] PZCZATDXERS.GetAvatarItemNameFromSignalDelegate? bz, [Optional] PZCZATDXERS.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] PZCZATDXERS.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] PZCZATDXERS.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] PZCZATDXERS.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] PZCZATDXERS.GetStoreItemNameFromSignalDelegate? ce, [Optional] PZCZATDXERS.GetBodyPartNameFromSignalDelegate? cf, [Optional] PZCZATDXERS.GetDependenciesForGraphInstanceDelegate? cg, [Optional] PZCZATDXERS.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] PZCZATDXERS.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] PZCZATDXERS.GetRecNetImageNameFromSignalDelegate? cj, [Optional] PZCZATDXERS.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] PZCZATDXERS.IsFunctionValidForAIDelegate? cm, [Optional] PZCZATDXERS.GetAIFunctionNameFromSignalDelegate? cn)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<EWGMMJRBQBF>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class XJOKRIYGQRX : RDWEUMIEPIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly XJOKRIYGQRX DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GetLocalPlayerDelegate? RRTEPNILSUM;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2893040", Offset = "0x2892240", VA = "0x182893040", Slot = "4")]
		public (VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR) LFVEIYJQFGL(object a)
		{
			return default((VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR, VZFDXXMSFYR));
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2893010", Offset = "0x2892210", VA = "0x182893010", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "6")]
		public bool RCTUDDFBUHY(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xB1A1B0", Offset = "0xB193B0", VA = "0x180B1A1B0", Slot = "7")]
		public string UFZUMNHAJBK(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public XJOKRIYGQRX([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class OWYNAQPHOYS : HYUPTAFTQGX
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(OWYNAQPHOYS self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(OWYNAQPHOYS self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(OWYNAQPHOYS self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoSavesDelegate PDMERUCXEWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly SerializesIntoInventionsDelegate VMNMPTPNESA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly CanPublishInInventionsDelegate ZCFTWBCTMPJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GDMFHVUEJHP? IKQLLXWJVJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId NAXYADBSYFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD83350", Offset = "0xD82550", VA = "0x180D83350", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OCQDEIJTNWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x28889C0", Offset = "0x2887BC0", VA = "0x1828889C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JLGIAWEMVJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2888990", Offset = "0x2887B90", VA = "0x182888990", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GMIYKQHWYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2888960", Offset = "0x2887B60", VA = "0x182888960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public YMFXDQEVZCU? BIPBOUCJYNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<EWGMMJRBQBF>? FPJHSDUPXFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2888810", Offset = "0x2887A10", VA = "0x182888810", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x28882C0", Offset = "0x28874C0", VA = "0x1828882C0", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(MMFRHKTHWJJ e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470", Slot = "13")]
		public void Bind(GDMFHVUEJHP controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x28888B0", Offset = "0x2887AB0", VA = "0x1828888B0")]
		private OWYNAQPHOYS(Id32<EWGMMJRBQBF>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2888360", Offset = "0x2887560", VA = "0x182888360")]
		public static OWYNAQPHOYS? New(Id32<EWGMMJRBQBF>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class JNAHKKOSGMW : IOOLZJQPNCL
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
		public static readonly JNAHKKOSGMW DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly RoundToDecimalPlaceDelegate? WUWDVDEJGZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TruncateToDecimalPlaceDelegate? ICZLZVUUPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorLerpDelegate? ODQGTRBQZTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsColorInverseLerpDelegate? LOUSONYLABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetPositionDelegate? XAQIMDPLTBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4GetRotationDelegate? KFTIMXBWWGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4InverseDelegate? ZQDLYVVIHAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4MultiplyDelegate? KQDOEYJGOSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? IQCVGVCENTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatDotDelegate? PFULGPPHJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromAngleAxisDelegate? KUKNYKNJRLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? ATDYUPJACZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromFromToRotationDelegate? MXTHFORZHIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromLookRotationDelegate? RGBVDMGTLGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? DSSFOZXDZWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatInverseDelegate? MCVSNPVOPWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpDelegate? YHFEBPWPVVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatLerpUnclampedDelegate? PNOOCRJOSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatInverseLerpDelegate? VEHPPFWEIRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatMultiplyDelegate? ERJWBJGIBQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatNormalizeDelegate? WPJGKYRMNYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateTowardsDelegate? LMODCCDRYAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatRotateVectorDelegate? KLKKPNFQTBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatSlerpDelegate? GIZZRXLTLCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToAngleAxisDelegate? OZXOLARWESP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatToEulerAnglesDelegate? EEKENXRQJZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3AddDelegate? QHBEWWSUTYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? YZDNIYGPDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? IWSEFCUWWPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3CrossDelegate? TDVNAHWATFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3DotDelegate? EAGHZJBVKHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3AngleDelegate? GSSMLGIJBTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3GetMagnitudeDelegate? XXNWWMFYIZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpDelegate? NQQOTIPXLST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3LerpUnclampedDelegate? NRIFGQXOGFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3InverseLerpDelegate? AZUQXLJYLTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3MoveTowardsDelegate? HWGXWHVSGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NegateDelegate? NPIVSPAZSJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3NormalizeDelegate? WBDMCSDHQZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectDelegate? ITAESUTWFSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? HUNPEGHWHTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ScaleDelegate? ZMVFOKCRSWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SmoothDampDelegate? SCPTKWBYRCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SubtractDelegate? QWEGGNTOTSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SlerpDelegate? JEPRJPKSLQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3TransformDelegate? DTWVSGOLWDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3InverseTransformDelegate? XSYNQLCGYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly RealtimeSinceStartupDelegate? MXMYIHGYYIX;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2887BB0", Offset = "0x2886DB0", VA = "0x182887BB0")]
		public JNAHKKOSGMW([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2886F60", Offset = "0x2886160", VA = "0x182886F60")]
		public float OFQAJSAEIYX([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2887160", Offset = "0x2886360", VA = "0x182887160")]
		public float ZUEVOKFRFYJ([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28866E0", Offset = "0x28858E0", VA = "0x1828866E0")]
		public CircuitsColor HETZKSLSVRM([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2886850", Offset = "0x2885A50", VA = "0x182886850")]
		public float XAMDDBFKGBW([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2887990", Offset = "0x2886B90", VA = "0x182887990")]
		public CircuitsVec3 ZGPIBUWAEOI([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2887290", Offset = "0x2886490", VA = "0x182887290")]
		public CircuitsQuat QNDIXUHLRWR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2886030", Offset = "0x2885230", VA = "0x182886030")]
		public CircuitsMtx4x4 ECEFFXHLPXJ([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28862E0", Offset = "0x28854E0", VA = "0x1828862E0")]
		public CircuitsMtx4x4 GCNZNNBFRKF([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2886CE0", Offset = "0x2885EE0", VA = "0x182886CE0")]
		public CircuitsMtx4x4 MOHQUHXKBOB([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2886DC0", Offset = "0x2885FC0", VA = "0x182886DC0")]
		public float SDSLDNHWPGG([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2885AE0", Offset = "0x2884CE0", VA = "0x182885AE0")]
		public CircuitsQuat AMESUDSJASP(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2886E50", Offset = "0x2886050", VA = "0x182886E50")]
		public CircuitsQuat WQVCAWJTFBW([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2887060", Offset = "0x2886260", VA = "0x182887060")]
		public CircuitsQuat QMXYRKSZNLK([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2886610", Offset = "0x2885810", VA = "0x182886610")]
		public CircuitsQuat HCVLATMSIKO([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2886740", Offset = "0x2885940", VA = "0x182886740")]
		public CircuitsQuat HHKTSCLYEHP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2886350", Offset = "0x2885550", VA = "0x182886350")]
		public CircuitsQuat GDIDEOGPWUC([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2885F70", Offset = "0x2885170", VA = "0x182885F70")]
		public CircuitsQuat GGNTYTDKOTD([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28860A0", Offset = "0x28852A0", VA = "0x1828860A0")]
		public float EQRJLGNCKQA([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2885DD0", Offset = "0x2884FD0", VA = "0x182885DD0")]
		public CircuitsQuat ILZVALDMLEH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2887180", Offset = "0x2886380", VA = "0x182887180")]
		public CircuitsQuat PZKSPRCALRI([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2886470", Offset = "0x2885670", VA = "0x182886470")]
		public CircuitsQuat IWVWPAXDNSM([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28868A0", Offset = "0x2885AA0", VA = "0x1828868A0")]
		public CircuitsVec3 KEUNXETWSDJ([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28869D0", Offset = "0x2885BD0", VA = "0x1828869D0")]
		public CircuitsQuat LBGGAYYCAXD([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2885CE0", Offset = "0x2884EE0", VA = "0x182885CE0")]
		public void BHUEIXTSQDW([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28873C0", Offset = "0x28865C0", VA = "0x1828873C0")]
		public CircuitsVec3 SBTXFIMXFLN([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2886EF0", Offset = "0x28860F0", VA = "0x182886EF0")]
		public CircuitsVec3 NWZJBUTOTDQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2887350", Offset = "0x2886550", VA = "0x182887350")]
		public CircuitsVec3 QXAMPEKEPIE([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28867E0", Offset = "0x28859E0", VA = "0x1828867E0")]
		public CircuitsVec3 IRYLEAOIKQF([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2886FF0", Offset = "0x28861F0", VA = "0x182886FF0")]
		public CircuitsVec3 ONZKRDNOWKR([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28866C0", Offset = "0x28858C0", VA = "0x1828866C0")]
		public float HDSPLYFBOOO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2885DB0", Offset = "0x2884FB0", VA = "0x182885DB0")]
		public float BXDVLVHVVXE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2886880", Offset = "0x2885A80", VA = "0x182886880")]
		public float QFFMRCLQRND([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28865A0", Offset = "0x28857A0", VA = "0x1828865A0")]
		public CircuitsVec3 GXVUSNUEAFE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2887420", Offset = "0x2886620", VA = "0x182887420")]
		public CircuitsVec3 SDQPFZTZRVP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2885D80", Offset = "0x2884F80", VA = "0x182885D80")]
		public float BQAOCTFTQGY([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2886D50", Offset = "0x2885F50", VA = "0x182886D50")]
		public CircuitsVec3 MRDXKCJMVBQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2886BA0", Offset = "0x2885DA0", VA = "0x182886BA0")]
		public CircuitsVec3 LTKSYQCXZYR([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2887930", Offset = "0x2886B30", VA = "0x182887930")]
		public CircuitsVec3 ZDFFBTANBWS([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2885C70", Offset = "0x2884E70", VA = "0x182885C70")]
		public CircuitsVec3 BBYHPEEVOGQ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x28872E0", Offset = "0x28864E0", VA = "0x1828872E0")]
		public CircuitsVec3 QWBRHAQHUYN([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2887630", Offset = "0x2886830", VA = "0x182887630")]
		public CircuitsVec3 VVCNZVFFGTR([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x28861A0", Offset = "0x28853A0", VA = "0x1828861A0")]
		public CircuitsVec3 EZJWBEHHQAD([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x28877F0", Offset = "0x28869F0", VA = "0x1828877F0")]
		public CircuitsVec3 XOHQRBIWGBJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2887860", Offset = "0x2886A60", VA = "0x182887860")]
		public CircuitsVec3 XTTUIOPVKDP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x28875C0", Offset = "0x28867C0", VA = "0x1828875C0")]
		public CircuitsVec3 UVVMEBAUTLH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x28876A0", Offset = "0x28868A0", VA = "0x1828876A0")]
		public CircuitsVec3 WXXHIGMVYFV([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2885EE0", Offset = "0x28850E0", VA = "0x182885EE0", Slot = "50")]
		public Task CTTELQUAWRD(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "51")]
		public void WHXMTZURQNX([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2887110", Offset = "0x2886310", VA = "0x182887110", Slot = "52")]
		public MVSDGWXZBFC<IWSAOBCGBQA> PLOTQJWGBTT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2886B50", Offset = "0x2885D50", VA = "0x182886B50", Slot = "53")]
		public MVSDGWXZBFC<IWSAOBCGBQA> LPBKTYGHTMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2886250", Offset = "0x2885450", VA = "0x182886250", Slot = "54")]
		public float FFJPCJMJDVQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2886F60", Offset = "0x2886160", VA = "0x182886F60", Slot = "4")]
		private float RHDLPJFMIJL([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2887160", Offset = "0x2886360", VA = "0x182887160", Slot = "5")]
		private float PMRELPEYANF([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2886910", Offset = "0x2885B10", VA = "0x182886910", Slot = "6")]
		private CircuitsColor KGUYJQWJGIU([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2886850", Offset = "0x2885A50", VA = "0x182886850", Slot = "7")]
		private float IWDBUEREZZQ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2885E80", Offset = "0x2885080", VA = "0x182885E80", Slot = "8")]
		private CircuitsVec3 CKWMECMVDGG([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2887570", Offset = "0x2886770", VA = "0x182887570", Slot = "9")]
		private CircuitsQuat UIJOEBYGUKP([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2885D20", Offset = "0x2884F20", VA = "0x182885D20", Slot = "10")]
		private CircuitsMtx4x4 BKCAHNSWUIR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28878D0", Offset = "0x2886AD0", VA = "0x1828878D0", Slot = "11")]
		private CircuitsMtx4x4 YRCDGJXWWDR([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2886970", Offset = "0x2885B70", VA = "0x182886970", Slot = "12")]
		private CircuitsMtx4x4 KROAYDDKWKD([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2886DC0", Offset = "0x2885FC0", VA = "0x182886DC0", Slot = "13")]
		private float NLNCTXUWDWQ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2885AE0", Offset = "0x2884CE0", VA = "0x182885AE0", Slot = "14")]
		private CircuitsQuat MKBSJOEDLYN(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2886E50", Offset = "0x2886050", VA = "0x182886E50", Slot = "15")]
		private CircuitsQuat NUIXLRFGQRU([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2887060", Offset = "0x2886260", VA = "0x182887060", Slot = "16")]
		private CircuitsQuat PDOPICPYHJE([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2886610", Offset = "0x2885810", VA = "0x182886610", Slot = "17")]
		private CircuitsQuat RKWWPEWMOIM([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2886740", Offset = "0x2885940", VA = "0x182886740", Slot = "18")]
		private CircuitsQuat XBXKFFOSTYP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2886350", Offset = "0x2885550", VA = "0x182886350", Slot = "19")]
		private CircuitsQuat RLHVVGNCXBK([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2885F70", Offset = "0x2885170", VA = "0x182885F70", Slot = "20")]
		private CircuitsQuat DTWSLVBZWLF([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28860A0", Offset = "0x28852A0", VA = "0x1828860A0", Slot = "21")]
		private float KCOKCFNMFSK([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2885DD0", Offset = "0x2884FD0", VA = "0x182885DD0", Slot = "22")]
		private CircuitsQuat CBSHJNRCQMF([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2887180", Offset = "0x2886380", VA = "0x182887180", Slot = "23")]
		private CircuitsQuat WHQZCCXDNLK([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2886470", Offset = "0x2885670", VA = "0x182886470", Slot = "24")]
		private CircuitsQuat GUHZWIEFDHI([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2887710", Offset = "0x2886910", VA = "0x182887710", Slot = "25")]
		private CircuitsVec3 WZGJOBPSQHT([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28869D0", Offset = "0x2885BD0", VA = "0x1828869D0", Slot = "26")]
		private CircuitsQuat VPASVBUCVVZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2885CE0", Offset = "0x2884EE0", VA = "0x182885CE0", Slot = "27")]
		private void XWYELIJOXFU([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2886410", Offset = "0x2885610", VA = "0x182886410", Slot = "28")]
		private CircuitsVec3 GLXNLNWXNCR([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2887780", Offset = "0x2886980", VA = "0x182887780", Slot = "29")]
		private CircuitsVec3 XAAQLMQICFS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2886F80", Offset = "0x2886180", VA = "0x182886F80", Slot = "30")]
		private CircuitsVec3 ONIVJQDPMAK([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2886270", Offset = "0x2885470", VA = "0x182886270", Slot = "31")]
		private CircuitsVec3 FWYKBHDJRXJ([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2887490", Offset = "0x2886690", VA = "0x182887490", Slot = "32")]
		private CircuitsVec3 SQCKLAINCZZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2886DE0", Offset = "0x2885FE0", VA = "0x182886DE0", Slot = "33")]
		private CircuitsVec3 NQKYLVFQTJN([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2886C70", Offset = "0x2885E70", VA = "0x182886C70", Slot = "34")]
		private CircuitsVec3 MCWRAEFCQOR([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x28866C0", Offset = "0x28858C0", VA = "0x1828866C0", Slot = "35")]
		private float WOSLDXZQYYY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2885DB0", Offset = "0x2884FB0", VA = "0x182885DB0", Slot = "36")]
		private float MSNTSURHOQA([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2886880", Offset = "0x2885A80", VA = "0x182886880", Slot = "37")]
		private float JLKTGZJTVOT([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2886C00", Offset = "0x2885E00", VA = "0x182886C00", Slot = "38")]
		private CircuitsVec3 MASXCKMWNCY([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2886130", Offset = "0x2885330", VA = "0x182886130", Slot = "39")]
		private CircuitsVec3 EULNGJAUHTZ([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2885D80", Offset = "0x2884F80", VA = "0x182885D80", Slot = "40")]
		private float VVQXYHWLTKK([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2886530", Offset = "0x2885730", VA = "0x182886530", Slot = "41")]
		private CircuitsVec3 GVUTKOAZSQQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28860D0", Offset = "0x28852D0", VA = "0x1828860D0", Slot = "42")]
		private CircuitsVec3 EUGIIKWITSD([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2885F10", Offset = "0x2885110", VA = "0x182885F10", Slot = "43")]
		private CircuitsVec3 DBBWJPWEBIA([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2885B90", Offset = "0x2884D90", VA = "0x182885B90", Slot = "44")]
		private CircuitsVec3 BBHYKYRYCMW([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2885C00", Offset = "0x2884E00", VA = "0x182885C00", Slot = "45")]
		private CircuitsVec3 BBRZDMUGSUH([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2887500", Offset = "0x2886700", VA = "0x182887500", Slot = "46")]
		private CircuitsVec3 UBPHTCGUVCB([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2886A90", Offset = "0x2885C90", VA = "0x182886A90", Slot = "47")]
		private CircuitsVec3 LDCSJVRIFUR([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2887220", Offset = "0x2886420", VA = "0x182887220", Slot = "48")]
		private CircuitsVec3 QAYUDYPHLBL([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2885A70", Offset = "0x2884C70", VA = "0x182885A70", Slot = "49")]
		private CircuitsVec3 AIGJYTJWPEL([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class XWAVHTQSZLE : APHLVCSFFDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x10C6600", Offset = "0x10C5800", VA = "0x1810C6600", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA09C0", Offset = "0xF9FBC0", VA = "0x180FA09C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2893130", Offset = "0x2892330", VA = "0x182893130")]
		public XWAVHTQSZLE(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class XGFUVWRWBQK : GNRODNQUTWH
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(YSXOFHETLFK e, DDZDYXSTFKL invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly XGFUVWRWBQK DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetCircuitsColorFromColorIndexDelegate? XGEFXWHDXPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? ROOVHVJGJQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly InvisibleCollisionSetEnabledDelegate? CBUMKHMQOHE;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB5E4E0", Offset = "0xB5D6E0", VA = "0x180B5E4E0")]
		public XGFUVWRWBQK([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2892F20", Offset = "0x2892120", VA = "0x182892F20", Slot = "4")]
		public CircuitsColor VTUFKXBTSCS(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2892F00", Offset = "0x2892100", VA = "0x182892F00")]
		public int KCMYXHVEDEC([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2892F00", Offset = "0x2892100", VA = "0x182892F00", Slot = "5")]
		private int TKRGMHTCLLB([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class WAIEUHLRMYZ : QOSWAVGFASO
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class WLUGMSETEAS
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid QOWINCARNEW
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xCAA5E0", Offset = "0xCA97E0", VA = "0x180CAA5E0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long OREMPHMIUQH
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int HMYUXGJHGGV
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xABBC10", Offset = "0xABAE10", VA = "0x180ABBC10")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool PNMBWSJHHKA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1892BE0", Offset = "0x1891DE0", VA = "0x181892BE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool JQYIHRIXABS
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x1892EC0", Offset = "0x18920C0", VA = "0x181892EC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool SFPJEGAMYKZ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x2892E80", Offset = "0x2892080", VA = "0x182892E80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2892EA0", Offset = "0x28920A0", VA = "0x182892EA0")]
			public WLUGMSETEAS(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly Dictionary<Id128<FAVTMLJIUOX>, WLUGMSETEAS> JDQDKDBRKFF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2892CF0", Offset = "0x2891EF0", VA = "0x182892CF0")]
		public bool ZNXVFLUZFYS([In] Id128<FAVTMLJIUOX> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2892A50", Offset = "0x2891C50", VA = "0x182892A50")]
		public void HLAATISSFGK([In] Id128<FAVTMLJIUOX> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2892B20", Offset = "0x2891D20", VA = "0x182892B20")]
		public void HLAATISSFGK([In] Id128<FAVTMLJIUOX> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2892930", Offset = "0x2891B30", VA = "0x182892930")]
		public void DWGBDQEWBFN([In] Id128<FAVTMLJIUOX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2892C00", Offset = "0x2891E00", VA = "0x182892C00")]
		public void INBPOOZIWPO([In] Id128<FAVTMLJIUOX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2892C60", Offset = "0x2891E60", VA = "0x182892C60")]
		public bool PNMBWSJHHKA([In] Id128<FAVTMLJIUOX> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2892E00", Offset = "0x2892000", VA = "0x182892E00")]
		public WAIEUHLRMYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2892CF0", Offset = "0x2891EF0", VA = "0x182892CF0", Slot = "4")]
		private bool SDZUQGWCMOD([In] Id128<FAVTMLJIUOX> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2892A50", Offset = "0x2891C50", VA = "0x182892A50", Slot = "5")]
		private void HJVOOVDIGUL([In] Id128<FAVTMLJIUOX> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2892930", Offset = "0x2891B30", VA = "0x182892930", Slot = "6")]
		private void UNJPMZETZXA([In] Id128<FAVTMLJIUOX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2892C00", Offset = "0x2891E00", VA = "0x182892C00", Slot = "7")]
		private void ZSZYGRKRGPD([In] Id128<FAVTMLJIUOX> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2892C60", Offset = "0x2891E60", VA = "0x182892C60", Slot = "8")]
		private bool JRGWDXJDFPB([In] Id128<FAVTMLJIUOX> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class ARLUUNFENOW
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2883570", Offset = "0x2882770", VA = "0x182883570")]
		public static LogDeps QMEDFLDNOXP()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class EQKFZHOFERR : MeshLibrary.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
		public byte[]? ECUNRTGULDS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public void BXHBMBWNBOT(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public EQKFZHOFERR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class QIGSOKIBPOA : IPREUGGLREP
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
		public delegate void ConfigureAttachedObjectDelegate(FZXISYRTZOJ controlPanel, EVXNXIKLNWV staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<WVCLCRLTTZM> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, JDUFGOJEPGU>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, JDUFGOJEPGU>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, JDUFGOJEPGU>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, JDUFGOJEPGU>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Task<Result<MultiResult, JDUFGOJEPGU>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<Result<MultiResult, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2890CE0", Offset = "0x288FEE0", VA = "0x182890CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2890FA0", Offset = "0x28901A0", VA = "0x182890FA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private TaskAwaiter<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2891010", Offset = "0x2890210", VA = "0x182891010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x28912D0", Offset = "0x28904D0", VA = "0x1828912D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task<Result<None, JDUFGOJEPGU>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<Result<None, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2891340", Offset = "0x2890540", VA = "0x182891340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2891600", Offset = "0x2890800", VA = "0x182891600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<string, EnumChoiceData> LSMAPPNBAZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<int, string> DSUJHNCUUJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<object> ECJBZDOPQLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly List<Guid> BLKAENWTRDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly CanLocalPlayerCreateCurrencyDelegate KQVTDGADPUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ShowRoomCurrencyCreationUIDelegate SELXPPYBSHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipOptionsDelegate JEGQESZQFAV;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<Guid, int> HTZZFKJPJUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipGuidToIndexMapDelegate CAKDIVFDXMD;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<int, Guid> QENFXFZNNDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipIndexToGuidMapDelegate HLYUKZMLIJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipOptionsDelegate BMUPSWWCIWE;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<Guid, int> HDKGXOHDJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate HLPUEQVAGYI;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<int, Guid> YNUPIUJLEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate GTOXVSQAZNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly PlayAudioPreviewDelegate LTLOOHFCKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly StopAudioPreviewDelegate TTZDSFAIOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SubscriptionIsActiveDelegate DHTBAWNBAZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate MIUEKPKOFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, EnumChoiceData> DURSNXXAJVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly ShowQuickChatEditMenuDelegate MNJBJDGJLZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly ConfigureAttachedObjectDelegate MJUEWPKUXWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DisplayInvalidNameErrorMessageDelegate HWCDRCTLJSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly IsStringPureDelegate OPUSQJNVFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TryGetSpecificChipConfigSummaryDelegate MBPAEZMAJSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReleaseIconIdDelegate GAQVPHLMQES;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate BZIIAASOFVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 HFKDOUPFHAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 HFPKMBJCQMD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment EICDSRZNXYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool AERRQAUZCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> WKHQQWRAKYL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> KPDFLDUOBJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> GKHABJQCBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> COHEYLKQWGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB9330", Offset = "0xAB8530", VA = "0x180AB9330", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion RGDETNWWZRL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD89FE0", Offset = "0xD891E0", VA = "0x180D89FE0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool AXDPRMAFLGT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC92FC0", Offset = "0xC921C0", VA = "0x180C92FC0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool VYULZGNRAHW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x288D4E0", Offset = "0x288C6E0", VA = "0x18288D4E0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ECMXKXEDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x288D580", Offset = "0x288C780", VA = "0x18288D580", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool AXBZHYJIAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB70E0", Offset = "0xAB62E0", VA = "0x180AB70E0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x288D910", Offset = "0x288CB10", VA = "0x18288D910")]
		public QIGSOKIBPOA([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x288D5A0", Offset = "0x288C7A0", VA = "0x18288D5A0", Slot = "9")]
		public bool LRBJWXRDDLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0")]
		public static bool HFEFRQMNWNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x288D1F0", Offset = "0x288C3F0", VA = "0x18288D1F0", Slot = "10")]
		public bool DZEMDZRFXZZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public static void KKUHWXPSSVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCA1A40", Offset = "0xCA0C40", VA = "0x180CA1A40", Slot = "11")]
		public void NBXZVJJLIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x288D1C0", Offset = "0x288C3C0", VA = "0x18288D1C0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DOMQRDZSLXV(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x288D520", Offset = "0x288C720", VA = "0x18288D520", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KNGQEAUEKFA(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x288D720", Offset = "0x288C920", VA = "0x18288D720")]
		private static IReadOnlyDictionary<Guid, int> VWEBLEKHXLF(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x288D660", Offset = "0x288C860", VA = "0x18288D660", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> OCVWRLUGTJE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x288D170", Offset = "0x288C370", VA = "0x18288D170")]
		private static IReadOnlyDictionary<int, Guid> DHTPTUNRFTJ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x288D350", Offset = "0x288C550", VA = "0x18288D350", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> GTRZMDWKLYS(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x288D6C0", Offset = "0x288C8C0", VA = "0x18288D6C0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SPRDRBXBVLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x287A4B0", Offset = "0x28796B0", VA = "0x18287A4B0", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> LRAUBLFVJUF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x288CE40", Offset = "0x288C040", VA = "0x18288CE40")]
		private static IReadOnlyDictionary<Guid, int> ABGDYFIZVJS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x288D690", Offset = "0x288C890", VA = "0x18288D690", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> QIRRBNAEHZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x288D3F0", Offset = "0x288C5F0", VA = "0x18288D3F0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> IBHWPFYKCVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private static void NXRHTPNYMWN(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x288D310", Offset = "0x288C510", VA = "0x18288D310", Slot = "18")]
		public void GGIUHMZZNXS(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private static void NBLKZWUPBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x288D770", Offset = "0x288C970", VA = "0x18288D770", Slot = "19")]
		public void VWIJFFGIWSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0")]
		private static bool XBGIMMLJIUY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x288D4F0", Offset = "0x288C6F0", VA = "0x18288D4F0", Slot = "20")]
		public bool JVFUAAWYXRZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0")]
		public static bool CQYIPOYXHHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x288D6F0", Offset = "0x288C8F0", VA = "0x18288D6F0", Slot = "21")]
		public bool TKALMSHKSIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x288CEF0", Offset = "0x288C0F0", VA = "0x18288CEF0", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BLAWNWQDEAT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> BXLWQCQZBOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> HVWAZEZCSXH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x288D380", Offset = "0x288C580", VA = "0x18288D380", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> GURJJBONGGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> GJCQYXDDZOU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> WSMFGRFCCDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public static void KLPAHHJAHRE(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x288CF20", Offset = "0x288C120", VA = "0x18288CF20", Slot = "29")]
		public void BNQXCVOIKPL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private static void CLYQMRAQXDK(FZXISYRTZOJ a, EVXNXIKLNWV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x288D420", Offset = "0x288C620", VA = "0x18288D420", Slot = "35")]
		public void INOYFZPCYDV(FZXISYRTZOJ a, EVXNXIKLNWV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "36")]
		public Dictionary<string, EnumChoiceData> WNTLXKIPAAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "37")]
		public Dictionary<string, EnumChoiceData> OYEJTCPUEJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private static void WQTMMMPKBNO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x288CE90", Offset = "0x288C090", VA = "0x18288CE90")]
		private static Task<bool> AQTKXYTTPYA(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x288D550", Offset = "0x288C750", VA = "0x18288D550", Slot = "38")]
		public Task<bool> KQRCOVQVARB(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x288D590", Offset = "0x288C790", VA = "0x18288D590")]
		private static bool LKDRVTBCPAK(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x288D3B0", Offset = "0x288C5B0", VA = "0x18288D3B0", Slot = "39")]
		public bool IANEDVLCWOJ(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		private static void AWWZUXBVISG(Id32<WVCLCRLTTZM> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x288CF60", Offset = "0x288C160", VA = "0x18288CF60", Slot = "40")]
		public void CSEWXXPEIJH(Id32<WVCLCRLTTZM> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x288D220", Offset = "0x288C420", VA = "0x18288D220")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, JDUFGOJEPGU>> EWJMTGDMAEI(Task<Result<None, JDUFGOJEPGU>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x288D480", Offset = "0x288C680", VA = "0x18288D480", Slot = "41")]
		public Task<Result<None, JDUFGOJEPGU>> IPXIQCRCPNJ(Task<Result<None, JDUFGOJEPGU>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x288CF90", Offset = "0x288C190", VA = "0x18288CF90")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, JDUFGOJEPGU>> CXURDXLLHTE(Task<Result<MultiResult, JDUFGOJEPGU>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x288D4B0", Offset = "0x288C6B0", VA = "0x18288D4B0", Slot = "42")]
		public Task<Result<MultiResult, JDUFGOJEPGU>> IPXIQCRCPNJ(Task<Result<MultiResult, JDUFGOJEPGU>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x288D080", Offset = "0x288C280", VA = "0x18288D080")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> CXZYBEFIREN(Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x288D450", Offset = "0x288C650", VA = "0x18288D450", Slot = "43")]
		public Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> IPXIQCRCPNJ(Task<Result<Id32<WXMOLFBEQDB>, JDUFGOJEPGU>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class JBVFRZIXLOT : NMFYZWMULLA
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(MMFRHKTHWJJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? CHYJLZRGYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate AHEJTNYYJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly InteropDelegate VWLNXEXTFWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InteropDelegate? KYBEBBKPUIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private InvokeStudioFunctionDelegate? MPHPTIUXXNL;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "5")]
		public LegacyCV2Result<None> GYFAVFXAHJH(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		private static LegacyCV2Result<None> Default(MMFRHKTHWJJ _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "6")]
		public LegacyCV2Result<None> YKBSRULOKFC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "7")]
		public LegacyCV2Result<None> HPXICTBDABT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "8")]
		public LegacyCV2Result<None> ACNRAVWEWCA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "9")]
		public LegacyCV2Result<None> CHIXTSVJUGE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "15")]
		public LegacyCV2Result<None> HSNTHVLTZDP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CPTQCPUWLVZ(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IJBNURUWLKB(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRGDYYSBEPQ(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FULCUNRIMDF(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XTRBOWTDIQA(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XZACKIRWCZE(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TBESBFQCZCR(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "93")]
		public LegacyCV2Result<None> NUTTRCNRPFC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "94")]
		public LegacyCV2Result<None> JDQPMZYLMWG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "95")]
		public LegacyCV2Result<None> PDVKAPUZVYD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PYGYNYUQHWH(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(MMFRHKTHWJJ e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZEROTJUEBJH(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YBCRBHDQBND(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GOSBBJALFJU(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BRKCIVWECFV(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MKUWKIYHRWG(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QQBBAGVSZJC(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BODBOIHHYZS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XCZKPGIQAIV(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x12B4C50", Offset = "0x12B3E50", VA = "0x1812B4C50", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FOXDKTZYXZO(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WUNUCDPJPZZ(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "119")]
		public LegacyCV2Result<None> VAIPJMZAPCD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NSRVOJZZYKI(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "121")]
		public LegacyCV2Result<None> FTIENVPZDLW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "122")]
		public LegacyCV2Result<None> KLFTAAVCZRG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "123")]
		public LegacyCV2Result<None> OKRVEMTNSWM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "124")]
		public LegacyCV2Result<None> BDFNYSHDOKE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "125")]
		public LegacyCV2Result<None> VKETRHSSNSG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "126")]
		public LegacyCV2Result<None> GJNVVCINZAT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "818")]
		public LegacyCV2Result<None> DQGMBFLEBKV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "819")]
		public LegacyCV2Result<None> WOFIEWNAFFX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "147")]
		public LegacyCV2Result<None> EFTGZRYFVUD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "148")]
		public LegacyCV2Result<None> PMPQEOHUTDB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "149")]
		public LegacyCV2Result<None> DEMKXIREBAG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "150")]
		public LegacyCV2Result<None> WPGVSNYKUOC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "151")]
		public LegacyCV2Result<None> WUIITTDREML(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(MMFRHKTHWJJ e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(MMFRHKTHWJJ e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(MMFRHKTHWJJ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, NMFYZWMULLA.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(MMFRHKTHWJJ e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, NMFYZWMULLA.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "174")]
		public LegacyCV2Result<None> GSTFYEVVGEK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "175")]
		public LegacyCV2Result<None> ZJIYVNYXLRF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "176")]
		public LegacyCV2Result<None> XXXNYJJHDBB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "197")]
		public LegacyCV2Result<None> KVJRHNUZZUF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "198")]
		public LegacyCV2Result<None> UIHFAXJSOTG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "199")]
		public LegacyCV2Result<None> MYITZACKJCT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "200")]
		public LegacyCV2Result<None> TASIYBEAEDV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "201")]
		public LegacyCV2Result<None> GOTJFPSBXER(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "202")]
		public LegacyCV2Result<None> HZTLJRSROYI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "203")]
		public LegacyCV2Result<None> NCVGJLHPANQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "204")]
		public LegacyCV2Result<None> RYMIGYHIGMG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "205")]
		public LegacyCV2Result<None> WJVSMRZOYNY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "206")]
		public LegacyCV2Result<None> LLHIRRDHVVQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "207")]
		public LegacyCV2Result<None> YJCPWXGZPZE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "208")]
		public LegacyCV2Result<None> EKHBFRWLOPQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "209")]
		public LegacyCV2Result<None> PDKRTJFROJY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "210")]
		public LegacyCV2Result<None> OUWXQXRSKIZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "211")]
		public LegacyCV2Result<None> BVGNUUUAVCU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "212")]
		public LegacyCV2Result<None> HFRIMCPWJZX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "213")]
		public LegacyCV2Result<None> EJODRWYJPJI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "214")]
		public LegacyCV2Result<None> RIFHCZGORGP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "215")]
		public LegacyCV2Result<None> TPYCJYWKFJY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "274")]
		public LegacyCV2Result<None> CAWTZDVWQQG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "277")]
		public LegacyCV2Result<None> COAXEHNGTNW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "279")]
		public LegacyCV2Result<None> TLCKWGWYQHH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "280")]
		public LegacyCV2Result<None> XGQDEIEREDZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "281")]
		public LegacyCV2Result<None> NRONAIRQOGY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "282")]
		public LegacyCV2Result<None> AMSHKKKJGMR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "283")]
		public LegacyCV2Result<None> BJLXYJCYJAQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "287")]
		public LegacyCV2Result<None> GIRYYTIFAXX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "288")]
		public LegacyCV2Result<None> LEFJEHEKXFG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "317")]
		public LegacyCV2Result<None> OORUHVQDSNH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "406")]
		public LegacyCV2Result<None> VGHPTMIWFCQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FWTZDAIDIUL(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> WVUSVJCUJJV(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VPYXJKZVMTX(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OUOAJJMTUOW(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XYRZGJOWTUN(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "416")]
		public LegacyCV2Result<HOEJNPOPYWB.CV2DiscoverySectionType> NMIOQELJCXI(MMFRHKTHWJJ e, CircuitSignal a)
		{
			return default(LegacyCV2Result<HOEJNPOPYWB.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "417")]
		public LegacyCV2Result<None> VBPRQFBGYCS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(MMFRHKTHWJJ e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRPEMKLAQJI(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FQKGUWQGTOJ(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JAOTJYKUIGS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "462")]
		public LegacyCV2Result<None> FRPUURWYIIR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "463")]
		public LegacyCV2Result<None> CSHNDBEVVSE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "464")]
		public LegacyCV2Result<None> OZAQYISYLLR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "465")]
		public LegacyCV2Result<None> SOGBGGGHNPY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "466")]
		public LegacyCV2Result<None> LULZLAWDVWU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "467")]
		public LegacyCV2Result<None> VBTYASAEURG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "468")]
		public LegacyCV2Result<None> VRANDRPADXZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "469")]
		public LegacyCV2Result<None> PSCMNJQPMJX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "474")]
		public LegacyCV2Result<None> YCAFFYSHQJP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "475")]
		public LegacyCV2Result<None> RQGSECRTKAH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "476")]
		public LegacyCV2Result<None> SHJTGHJWLTC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "477")]
		public LegacyCV2Result<None> DOYCYHSWJIJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "478")]
		public LegacyCV2Result<None> VOWTAOWGSJR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "479")]
		public LegacyCV2Result<None> LCPMXNPMKYY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(MMFRHKTHWJJ executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(MMFRHKTHWJJ executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "472")]
		public LegacyCV2Result<None> XSJONPHYHRW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "473")]
		public LegacyCV2Result<None> AROVQAKWMWE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "480")]
		public LegacyCV2Result<None> VUNEMSLECAC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "481")]
		public LegacyCV2Result<None> NYZNOUZEDPK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "482")]
		public LegacyCV2Result<None> SGQTOONVWOF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "483")]
		public LegacyCV2Result<None> FYDTOJVIDTN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "484")]
		public LegacyCV2Result<None> OOAWOTSRHBZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "485")]
		public LegacyCV2Result<None> MCKBZSYRWSB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "486")]
		public LegacyCV2Result<None> SPZXFXJGGEP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "487")]
		public LegacyCV2Result<None> FBHPUBDAADD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "488")]
		public LegacyCV2Result<None> NXOHAOOKGJR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "489")]
		public LegacyCV2Result<None> BRVRFKHTZTZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "490")]
		public LegacyCV2Result<None> WLSUUSQMGVD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "491")]
		public LegacyCV2Result<None> XOCVAANOCXF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "492")]
		public LegacyCV2Result<None> JFOUXKEOPGZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "493")]
		public LegacyCV2Result<None> FJIXVPHCENV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "494")]
		public LegacyCV2Result<None> EUKWGPLTFVV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "495")]
		public LegacyCV2Result<None> UPIACTGWPBX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "496")]
		public LegacyCV2Result<None> MJDCZAYYBOB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "497")]
		public LegacyCV2Result<None> TKTBROLFLKV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "498")]
		public LegacyCV2Result<None> XHKIEWHUTSV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "499")]
		public LegacyCV2Result<None> CEGVEQYUSDR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x28857A0", Offset = "0x28849A0", VA = "0x1828857A0", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "507")]
		public LegacyCV2Result<None> PHWKWIQXSHF(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "508")]
		public LegacyCV2Result<None> FKFSNSRRLUZ(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "509")]
		public LegacyCV2Result<None> LSIGVMZGQQZ(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "510")]
		public LegacyCV2Result<None> COXYDYPWSIQ(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(MMFRHKTHWJJ e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(MMFRHKTHWJJ e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(MMFRHKTHWJJ e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.GGOGUSOVSIJ> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "522")]
		public LegacyCV2Result<None> QWOFTVECZOU(MMFRHKTHWJJ e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "525")]
		public LegacyCV2Result<None> GWDCGNSMAHC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "527")]
		public LegacyCV2Result<None> JJVQXTALDEJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "528")]
		public LegacyCV2Result<None> GIXQVSBLYVN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "530")]
		public LegacyCV2Result<None> TJIIJZABHQP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "531")]
		public LegacyCV2Result<None> ZAFHMCUILBU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2885720", Offset = "0x2884920", VA = "0x182885720", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "533")]
		public LegacyCV2Result<None> ODKCTPAFEBO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2885880", Offset = "0x2884A80", VA = "0x182885880", Slot = "535")]
		public LegacyCV2Result<None> YCLGOBWKALY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "534")]
		public LegacyCV2Result<None> IYOEZCIKUIL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "536")]
		public LegacyCV2Result<None> YAPHITRMXAZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "537")]
		public LegacyCV2Result<None> IFRKVWCJPFE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "538")]
		public LegacyCV2Result<None> LKQHHTWGMLC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "539")]
		public LegacyCV2Result<None> CGDYWZJYKFC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "540")]
		public LegacyCV2Result<None> VJCGROPZZQW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "583")]
		public LegacyCV2Result<None> Raycast(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "584")]
		public LegacyCV2Result<None> AJRSYKDZEED(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "587")]
		public LegacyCV2Result<None> BNWBQUMBTTY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "591")]
		public LegacyCV2Result<None> UBSFJZNSFXT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "592")]
		public LegacyCV2Result<None> NPUSDCDLYLE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "641")]
		public LegacyCV2Result<None> XBIUXJJEQZJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "642")]
		public LegacyCV2Result<None> QKHUPOPCGKL(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "643")]
		public LegacyCV2Result<None> AZKUUVVQOWC(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "644")]
		public LegacyCV2Result<None> ZOIKAZYLQFX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "645")]
		public LegacyCV2Result<None> IGAAZEUJNNX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "646")]
		public LegacyCV2Result<None> WWGNRHHHPMO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "649")]
		public LegacyCV2Result<None> MCRRLFUEKAV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "650")]
		public LegacyCV2Result<None> EWIXOEUEYJP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "651")]
		public LegacyCV2Result<None> HKFFKRMHUDI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "661")]
		public LegacyCV2Result<None> RTVRUTLMQCJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "660")]
		public LegacyCV2Result<None> SIYUWQHISYE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "662")]
		public LegacyCV2Result<None> FYRLESVUIVV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "663")]
		public LegacyCV2Result<None> BAALVCKONRQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "670")]
		public LegacyCV2Result<None> CBVNIKGBPRP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "671")]
		public LegacyCV2Result<None> KGQOIKMJMAU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "674")]
		public LegacyCV2Result<None> GHENIXOVIQC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "675")]
		public LegacyCV2Result<None> DOUKNXDGUSN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(MMFRHKTHWJJ e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "696")]
		public LegacyCV2Result<None> JHOBXCZZBUH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "697")]
		public LegacyCV2Result<None> YKEMTSNMLYB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "698")]
		public LegacyCV2Result<None> MVOLIXBQWFR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "699")]
		public LegacyCV2Result<None> NSEEPFLSUKY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "700")]
		public LegacyCV2Result<None> CFXKEOSGKPM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "676")]
		public LegacyCV2Result<None> FZPTWJBENFP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "677")]
		public LegacyCV2Result<None> ATRNOYYDOPB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "678")]
		public LegacyCV2Result<None> XWKANXXMNBQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "679")]
		public LegacyCV2Result<None> PYEUVBRTLRB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "680")]
		public LegacyCV2Result<None> FGTSZVEFJEM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "681")]
		public LegacyCV2Result<None> PVNKSZCNZIV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "682")]
		public LegacyCV2Result<None> JQPDDWGPKTJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "683")]
		public LegacyCV2Result<None> CZFFBZQHQXE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "684")]
		public LegacyCV2Result<None> MENRYFZUWKM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "685")]
		public LegacyCV2Result<None> TEPAMGVABAL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "686")]
		public LegacyCV2Result<None> SGRPYCTTMZV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "687")]
		public LegacyCV2Result<None> MLFHTEQPKXU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "688")]
		public LegacyCV2Result<None> WPHYAIDMNKN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "689")]
		public LegacyCV2Result<None> EVDUMSQGFZH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "690")]
		public LegacyCV2Result<None> HXZWTLBCYPY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "691")]
		public LegacyCV2Result<None> RXZWOMPZHJO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "692")]
		public LegacyCV2Result<None> UAUXHKAHQTU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "693")]
		public LegacyCV2Result<None> AQYQIDIFXIR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "765")]
		public LegacyCV2Result<None> QFSZZSQBAMX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "711")]
		public LegacyCV2Result<None> HMPBKFHMGSA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "712")]
		public LegacyCV2Result<None> THHDFAMNSIY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "713")]
		public LegacyCV2Result<None> PJVYTRIOYZM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "714")]
		public LegacyCV2Result<None> QYUXQHQFOMI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "717")]
		public LegacyCV2Result<None> DFMDTYNELRQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "721")]
		public LegacyCV2Result<None> SFEKTYARHLR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "722")]
		public LegacyCV2Result<None> YGBPXRIGLNL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "723")]
		public LegacyCV2Result<None> LSLZNEHOSSY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "724")]
		public LegacyCV2Result<None> CULIRPDDHZC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "725")]
		public LegacyCV2Result<None> WDMQOGPNDWU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "726")]
		public LegacyCV2Result<None> LLZTQDTRDTF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "727")]
		public LegacyCV2Result<None> AWJRVUFZVRM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "728")]
		public LegacyCV2Result<None> KTUELPAIDBT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "729")]
		public LegacyCV2Result<None> RSUYNMACCWT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "730")]
		public LegacyCV2Result<None> GATIJTMYLXD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "731")]
		public LegacyCV2Result<None> RUQOKBZUIOJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "732")]
		public LegacyCV2Result<None> POHHQAZVTUL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "733")]
		public LegacyCV2Result<None> FHYEQRNJTJN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "734")]
		public LegacyCV2Result<None> HWRVWPRPLLM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "735")]
		public LegacyCV2Result<None> HIUKSZHQPBJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "736")]
		public LegacyCV2Result<None> XGYAMVFKCWN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "737")]
		public LegacyCV2Result<None> UMGIUKTPKJO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "738")]
		public LegacyCV2Result<None> BBKLNHRWAID(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "740")]
		public LegacyCV2Result<None> QTKQHGRIBAR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "739")]
		public LegacyCV2Result<None> JWZXOZDCUPT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "741")]
		public LegacyCV2Result<None> IFTXVWLTHEU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "742")]
		public LegacyCV2Result<None> DPLECJGSRJB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "743")]
		public LegacyCV2Result<None> HDIYWPEJNJS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "744")]
		public LegacyCV2Result<None> XTBIARNKZWK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "745")]
		public LegacyCV2Result<None> SJXCYUCISRL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "746")]
		public LegacyCV2Result<None> NRRNAFMGGFO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "747")]
		public LegacyCV2Result<None> LQDYAMWQVMU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "748")]
		public LegacyCV2Result<None> VLTWGTILVBV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "749")]
		public LegacyCV2Result<None> HFBPQBDSPMF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "750")]
		public LegacyCV2Result<None> HBCNLVFNFOF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "751")]
		public LegacyCV2Result<None> KVUHGDWQPEL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "752")]
		public LegacyCV2Result<None> IDZDQTJJVST(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "753")]
		public LegacyCV2Result<None> TRBAEYEKWKH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "754")]
		public LegacyCV2Result<None> CUTKOYSCOYX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "755")]
		public LegacyCV2Result<None> KPCOEQLTYZA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "756")]
		public LegacyCV2Result<None> QCPYXMAAQSI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "757")]
		public LegacyCV2Result<None> SVZDCYGLARS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "758")]
		public LegacyCV2Result<None> PKARARUNFKA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "759")]
		public LegacyCV2Result<None> XXOZJNDFNJB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "760")]
		public LegacyCV2Result<None> PIDUIDENMIZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "761")]
		public LegacyCV2Result<None> NWUSWEBORWD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "762")]
		public LegacyCV2Result<None> JFBQTPSDRIE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "763")]
		public LegacyCV2Result<None> ZFLOQBRHHNI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "764")]
		public LegacyCV2Result<None> UJKUAGRINTZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "771")]
		public LegacyCV2Result<None> VDXMEWBGGUR(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "772")]
		public LegacyCV2Result<None> YMNJBQHJMRF(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "773")]
		public LegacyCV2Result<None> EMXCJRQNDLG(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(MMFRHKTHWJJ ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "775")]
		public LegacyCV2Result<None> CBAOMVXPXRE(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "776")]
		public LegacyCV2Result<None> UBYGCNFBJVI(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "777")]
		public LegacyCV2Result<None> HXBFTBLDZSJ(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "778")]
		public LegacyCV2Result<None> VSWFYFGGYHB(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "779")]
		public LegacyCV2Result<None> NPSXMUFIQVR(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "707")]
		public LegacyCV2Result<None> KTVPXKLHRPD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "801")]
		public LegacyCV2Result<None> NGPAALPVBSP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "802")]
		public LegacyCV2Result<None> IALMDEAAHUX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "803")]
		public LegacyCV2Result<None> UCFBOJSIWAV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "804")]
		public LegacyCV2Result<None> LSCQYIOUAYV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "805")]
		public LegacyCV2Result<None> KEYSXSHXCMX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "806")]
		public LegacyCV2Result<None> DXJFWQVLHSD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "807")]
		public LegacyCV2Result<None> QAYNUROWHMJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "808")]
		public LegacyCV2Result<None> ERZXPOIZNMR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "809")]
		public LegacyCV2Result<None> LSDCMBPJBZB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "810")]
		public LegacyCV2Result<None> CRHJLCFHBIF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "811")]
		public LegacyCV2Result<None> QNOYLUITZQB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "812")]
		public LegacyCV2Result<None> KQOHQLBOPCS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "817")]
		public LegacyCV2Result<None> MHSRTWDBREJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "821")]
		public LegacyCV2Result<None> SKLSWQVZTOS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "822")]
		public LegacyCV2Result<None> RYTAVNRVWNU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "823")]
		public LegacyCV2Result<None> MHCSCBYPKDO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "824")]
		public LegacyCV2Result<None> HMOYXFZELZK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "826")]
		public LegacyCV2Result<None> RLTGLVQXGTC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "827")]
		public LegacyCV2Result<None> LSAPSSESLQH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "828")]
		public LegacyCV2Result<None> XYGEUYANULT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "831")]
		public LegacyCV2Result<None> LZMFTTQRUOD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "832")]
		public LegacyCV2Result<None> FGLEMDCZWCY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "833")]
		public LegacyCV2Result<None> GFEABBANYPR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(MMFRHKTHWJJ e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "836")]
		public LegacyCV2Result<None> QDVNPYVLXRQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UOBBYRCOMHS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IBGONLWQNGW(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NQMAKLIKMQB(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QRKGYKHLNRQ(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CPQBJKWJHUD(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(MMFRHKTHWJJ e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(MMFRHKTHWJJ e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(MMFRHKTHWJJ e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "856")]
		public LegacyCV2Result<None> UAAZLFXAEJY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "859")]
		public LegacyCV2Result<None> GPBGDKIJUKS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "860")]
		public LegacyCV2Result<None> XOYPLOAAIWQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "861")]
		public LegacyCV2Result<None> ZQHFUVGUUMA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "862")]
		public LegacyCV2Result<None> QRXFNGPRQZH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "864")]
		public LegacyCV2Result<None> LMWJFNQSIDQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "865")]
		public LegacyCV2Result<None> GYMXLVJVYAA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(MMFRHKTHWJJ e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "869")]
		public LegacyCV2Result<None> QCEFBPAQHDO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "879")]
		public LegacyCV2Result<None> WTSTMWFWVCK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "880")]
		public LegacyCV2Result<None> ODMYHSBHPOU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "881")]
		public LegacyCV2Result<None> QGJEYOFVDLD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "882")]
		public LegacyCV2Result<None> VXCVJDTGZPW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(MMFRHKTHWJJ e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MMFRHKTHWJJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MMFRHKTHWJJ e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(MMFRHKTHWJJ e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "889")]
		public LegacyCV2Result<None> VINKCSPNTSQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "890")]
		public LegacyCV2Result<None> PYMVPMTCKDN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "891")]
		public LegacyCV2Result<None> PWWBKWUJRLE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "892")]
		public LegacyCV2Result<None> DKEBCBQNWUS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "893")]
		public LegacyCV2Result<None> NPENMDDIQRK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "897")]
		public LegacyCV2Result<None> CSHCHOVTQIV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "898")]
		public LegacyCV2Result<None> AGJIVKBQKPL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "899")]
		public LegacyCV2Result<None> XCDEUZIXKHC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "901")]
		public LegacyCV2Result<None> NRXQISDRXLC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "900")]
		public LegacyCV2Result<None> BNNIPXNZXVK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "902")]
		public LegacyCV2Result<None> ZMJVGGVDFEB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "904")]
		public LegacyCV2Result<None> VDUWWUNEKCF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "903")]
		public LegacyCV2Result<None> TEYDGXMFKXN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "905")]
		public LegacyCV2Result<None> ISMPLKSDVAQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "906")]
		public LegacyCV2Result<None> BUZCXRPLTBK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "907")]
		public LegacyCV2Result<None> ASVDOVBOGVH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "908")]
		public LegacyCV2Result<None> RDIPBUZDXCL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "909")]
		public LegacyCV2Result<None> DRBNHXDHHYP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "910")]
		public LegacyCV2Result<None> LYCJRGWVHQL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "911")]
		public LegacyCV2Result<None> AYICKLNALHB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "918")]
		public LegacyCV2Result<None> LYOBJPZFIUF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "919")]
		public LegacyCV2Result<None> VFJGXYXLSTP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(MMFRHKTHWJJ e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "941")]
		public LegacyCV2Result<None> BVTBMFLTWHJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "942")]
		public LegacyCV2Result<None> QIGXYLKUUBF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "943")]
		public LegacyCV2Result<None> ROZHQOALZXC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "944")]
		public LegacyCV2Result<None> FIOMTOEWHGW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "945")]
		public LegacyCV2Result<None> VJNLHGUEBZT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "946")]
		public LegacyCV2Result<None> JYWJXMVIWRJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "947")]
		public LegacyCV2Result<None> VDBAJQERGNI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "948")]
		public LegacyCV2Result<None> MUMVNNZKBVQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "949")]
		public LegacyCV2Result<None> SSQEFYYFGWW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "950")]
		public LegacyCV2Result<None> FUBWLKDUZWR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "968")]
		public LegacyCV2Result<None> CDENBETOYQB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "967")]
		public LegacyCV2Result<None> AGAVXCMUHES(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "969")]
		public LegacyCV2Result<None> LTZCPVOQEGY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "970")]
		public LegacyCV2Result<None> NENUXXTBWAN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "971")]
		public LegacyCV2Result<None> NWNKTECRMQS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "972")]
		public LegacyCV2Result<None> EGEOPVCACAM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "973")]
		public LegacyCV2Result<None> VECYDFLQSQN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "975")]
		public LegacyCV2Result<None> ZFNOLHGPAUS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "982")]
		public LegacyCV2Result<None> NDLUPEYBQEB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "983")]
		public LegacyCV2Result<None> SKBJBKGCBNV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "991")]
		public LegacyCV2Result<None> UFISNWWCDPI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "993")]
		public LegacyCV2Result<None> PCIHOKYROSG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "994")]
		public LegacyCV2Result<None> CIBQEVZPMHU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "995")]
		public LegacyCV2Result<None> PXNEZQBHNAQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "996")]
		public LegacyCV2Result<None> UVHVVVZFAUU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "997")]
		public LegacyCV2Result<None> APWYEKDFODU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "998")]
		public LegacyCV2Result<None> PGWCZFOGDUK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "999")]
		public LegacyCV2Result<None> DXAZYOWTAHK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1000")]
		public LegacyCV2Result<None> QRERMDCYNQA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1001")]
		public LegacyCV2Result<None> CCQGBQXVKEU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1002")]
		public LegacyCV2Result<None> WVNECJKJNKQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1009")]
		public LegacyCV2Result<None> WIMBCJTCCAS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1017")]
		public LegacyCV2Result<None> IEQPLVBETBT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1018")]
		public LegacyCV2Result<None> RKCTXOWLVAY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1019")]
		public LegacyCV2Result<None> UVWDQWTJZPT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1020")]
		public LegacyCV2Result<None> LKSLLXEQWDS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1021")]
		public LegacyCV2Result<None> PBIXAZWPAAZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1022")]
		public LegacyCV2Result<None> JTAQCQCZMGW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1023")]
		public LegacyCV2Result<None> VDQPCSQNDEX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1024")]
		public LegacyCV2Result<None> WMPROKBBKEH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1025")]
		public LegacyCV2Result<None> NMNCIAQTWAC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1026")]
		public LegacyCV2Result<None> EJMRGEGIKZD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1027")]
		public LegacyCV2Result<None> VNYAGJVYGRT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1028")]
		public LegacyCV2Result<None> UWZSEIUVGRI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1029")]
		public LegacyCV2Result<None> RLVSQLPAUJY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1030")]
		public LegacyCV2Result<None> UTBZCHQQEFH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1031")]
		public LegacyCV2Result<None> TOVFQLLPIAW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1032")]
		public LegacyCV2Result<None> DAUOFMHAUFL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1033")]
		public LegacyCV2Result<None> ZICOOHUYNON(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1047")]
		public LegacyCV2Result<None> WLEFZDJHSVV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1048")]
		public LegacyCV2Result<None> RTREZWLZLGD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1049")]
		public LegacyCV2Result<None> QOLUFCHLXQT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1050")]
		public LegacyCV2Result<None> GEQESYGFSQD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1051")]
		public LegacyCV2Result<None> NRPJMQCCUEI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1052")]
		public LegacyCV2Result<None> BDCCOZPZOBS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1053")]
		public LegacyCV2Result<None> WHQTITHPJBN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1054")]
		public LegacyCV2Result<None> XLJIORMODAO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1055")]
		public LegacyCV2Result<None> FPYSFLMWZYB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1056")]
		public LegacyCV2Result<None> KHKOCKPSIMC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1057")]
		public LegacyCV2Result<None> XEFWCBUFJGW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1058")]
		public LegacyCV2Result<None> OAFGUALADLF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1059")]
		public LegacyCV2Result<None> KSWGEHQPMXA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1060")]
		public LegacyCV2Result<None> MDGJNXBXXVS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1061")]
		public LegacyCV2Result<None> YAAZPLCUSWY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1062")]
		public LegacyCV2Result<None> SZNEXOFCWKY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1063")]
		public LegacyCV2Result<None> VTJNVAEOTXO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1064")]
		public LegacyCV2Result<None> FQREPEMLVUF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1065")]
		public LegacyCV2Result<None> TPRFSMRSVJX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1066")]
		public LegacyCV2Result<None> OTGRJAOEVXQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1067")]
		public LegacyCV2Result<None> XHSVFHCHQRE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1068")]
		public LegacyCV2Result<None> XKBBFUCYTNC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1069")]
		public LegacyCV2Result<None> CSDLLLWZBCU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1070")]
		public LegacyCV2Result<None> ILDFELHLWLL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1071")]
		public LegacyCV2Result<None> LECPIZBXQJT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2885760", Offset = "0x2884960", VA = "0x182885760", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(MMFRHKTHWJJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(MMFRHKTHWJJ e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1092")]
		public LegacyCV2Result<None> CMBXLHCXXLS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1093")]
		public LegacyCV2Result<None> UBAYSTEXIDV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1094")]
		public LegacyCV2Result<None> QBGQWDOVZTN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1095")]
		public LegacyCV2Result<None> UHEMHLSHIHJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1096")]
		public LegacyCV2Result<None> CLWOICSQTNN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1097")]
		public LegacyCV2Result<None> UPZFRBWVGIJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1098")]
		public LegacyCV2Result<None> KWKOGSCRCJT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1099")]
		public LegacyCV2Result<None> CCJZEVRDCIF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1100")]
		public LegacyCV2Result<None> FMAQAPJKGMJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1101")]
		public LegacyCV2Result<None> UULWLWPMGBL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1102")]
		public LegacyCV2Result<None> HXWNRCOWFSJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1103")]
		public LegacyCV2Result<None> ICUEJQVGXSG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1104")]
		public LegacyCV2Result<None> KLFAWKKSOJI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1105")]
		public LegacyCV2Result<None> AUSXGFHKDDM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1106")]
		public LegacyCV2Result<None> YXQKZSMGIZI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1107")]
		public LegacyCV2Result<None> YSWGBNDCZLH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1108")]
		public LegacyCV2Result<None> UWXXJLLXKVT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1109")]
		public LegacyCV2Result<None> IGAQONRAFTG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1110")]
		public LegacyCV2Result<None> CPBZSCLNPEY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1111")]
		public LegacyCV2Result<None> TAHDIHYCZGE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1112")]
		public LegacyCV2Result<None> GEASWTGMCXC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1113")]
		public LegacyCV2Result<None> TLENZKYDUOV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1114")]
		public LegacyCV2Result<None> UQUHDLDJAFD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1115")]
		public LegacyCV2Result<None> RJHDYBJVQLW(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1116")]
		public LegacyCV2Result<None> XJRSBXSPDNS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1117")]
		public LegacyCV2Result<None> DKRSTEOWTIA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1118")]
		public LegacyCV2Result<None> SIVFXHHHLIU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1119")]
		public LegacyCV2Result<None> QEYPAZNKWNH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1120")]
		public LegacyCV2Result<None> GZLRTEADFPM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1121")]
		public LegacyCV2Result<None> KWCKMRSUQTU(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1122")]
		public LegacyCV2Result<None> PUVURTPLLRQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1123")]
		public LegacyCV2Result<None> RXMJVOLICPL(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1124")]
		public LegacyCV2Result<None> FJVKEDTTGLH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1125")]
		public LegacyCV2Result<None> PMRSDPHAWFD(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1126")]
		public LegacyCV2Result<None> DGRLIMFSSUJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1127")]
		public LegacyCV2Result<None> RQCTWFXFTDT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1128")]
		public LegacyCV2Result<None> AHTQMUDIUQR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1129")]
		public LegacyCV2Result<None> BYRJPZQGLAX(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1130")]
		public LegacyCV2Result<None> WGMPHBSECTO(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1131")]
		public LegacyCV2Result<None> CPJFLPEQKSN(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1132")]
		public LegacyCV2Result<None> SAPOLWHSUNW(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1133")]
		public LegacyCV2Result<None> ZFTJHOOOMDP(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1134")]
		public LegacyCV2Result<None> YTZCJXMZOEJ(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1135")]
		public LegacyCV2Result<None> WANGBJNERFU(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1136")]
		public LegacyCV2Result<None> ZOCOTYQZCMK(YSXOFHETLFK e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1140")]
		public LegacyCV2Result<None> QRYEWYPNGOS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1166")]
		public LegacyCV2Result<None> MWNBQXWGYAU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1168")]
		public LegacyCV2Result<None> IDOVWIXJEPU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1169")]
		public LegacyCV2Result<None> MUNQMAOGHNP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1170")]
		public LegacyCV2Result<None> GGUIHBRNSFS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1171")]
		public LegacyCV2Result<None> IPQXOVTWZVX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1182")]
		public LegacyCV2Result<None> MPKJQFIBZKN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1183")]
		public LegacyCV2Result<None> YSDZNRRMTVJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1184")]
		public LegacyCV2Result<None> YPNILSWQVID(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1185")]
		public LegacyCV2Result<None> YKRTVDMQSXD(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1186")]
		public LegacyCV2Result<None> QRWTYALVLZQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1187")]
		public LegacyCV2Result<None> XCFLROGEKDQ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1188")]
		public LegacyCV2Result<None> REERODLNIXK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1189")]
		public LegacyCV2Result<None> ETTVLJTFFVK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1190")]
		public LegacyCV2Result<None> LJLUJWGUIBR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1191")]
		public LegacyCV2Result<None> ALUESVYJCMX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1192")]
		public LegacyCV2Result<None> YSTUTIFAEEY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1193")]
		public LegacyCV2Result<None> NLSRVNLTXGR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "184")]
		public LegacyCV2Result<None> EBCNETYOQRX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x2885870", Offset = "0x2884A70", VA = "0x182885870", Slot = "191")]
		public bool XNYBKXCFKEL(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1194")]
		public LegacyCV2Result<None> JJGVKVVGDSN(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1195")]
		public LegacyCV2Result<None> KELNQQGJSKY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1196")]
		public LegacyCV2Result<None> YMHOWFNTTTZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(MMFRHKTHWJJ e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1205")]
		public LegacyCV2Result<None> LQXOXXBZHAU(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1206")]
		public LegacyCV2Result<None> AZDBKXBPCUM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(MMFRHKTHWJJ e, InOut io, UMZPZXQDKSU objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "250")]
		public LegacyCV2Result<None> QIPXPYVXNMR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "251")]
		public LegacyCV2Result<None> PPNPLKHOWQL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "252")]
		public LegacyCV2Result<None> OPVXMZVNQZF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "254")]
		public LegacyCV2Result<None> TXGDYRUCBPC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "255")]
		public LegacyCV2Result<None> XFXMWNRXZAE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "256")]
		public LegacyCV2Result<None> PJMJAHDKXPC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "257")]
		public LegacyCV2Result<None> LCSVWUNJQEH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "258")]
		public LegacyCV2Result<None> FADDGVSMXDJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "259")]
		public LegacyCV2Result<None> DYCMKQAMRDG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "260")]
		public LegacyCV2Result<None> OQNQCFYODWE(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "261")]
		public LegacyCV2Result<None> RRIHJRTRKBM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "262")]
		public LegacyCV2Result<None> WZQHGCVBDSK(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "263")]
		public LegacyCV2Result<None> RMSQDRLLJMZ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "264")]
		public LegacyCV2Result<None> NEZTYZCITSJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "265")]
		public LegacyCV2Result<None> TBFXFFXSYPF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "266")]
		public LegacyCV2Result<None> GINJUYZYSSL(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "267")]
		public LegacyCV2Result<None> BCQZENVAMUT(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "268")]
		public LegacyCV2Result<None> UVMOWHRDVAR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "269")]
		public LegacyCV2Result<None> LTHWZAXFHAF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		private static LegacyCV2Result<None> Default(MMFRHKTHWJJ e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x28857E0", Offset = "0x28849E0", VA = "0x1828857E0", Slot = "1209")]
		public LegacyCV2Result<None> UOKSUAKUIGK(MMFRHKTHWJJ a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1212")]
		public LegacyCV2Result<None> FXYXESBFNOV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1213")]
		public LegacyCV2Result<None> QFWPIDXLMGH(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1214")]
		public LegacyCV2Result<None> IBHZRDMYGTF(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1215")]
		public LegacyCV2Result<None> IMLZRDJNCTC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(MMFRHKTHWJJ e, InOut io, IBQVWPZXDKQ quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1036")]
		public LegacyCV2Result<None> GBIBNDGIPKJ(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1037")]
		public LegacyCV2Result<None> KYQZZGZATGV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1038")]
		public LegacyCV2Result<None> ZJMSYSGAPAX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1039")]
		public LegacyCV2Result<None> OZZFPOEWMTB(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1040")]
		public LegacyCV2Result<None> CEMFANOHBEV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1041")]
		public LegacyCV2Result<None> MUNUTASAJQR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1042")]
		public LegacyCV2Result<None> CUFWBQSGKFL(MMFRHKTHWJJ a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1043")]
		public LegacyCV2Result<None> VYUZDUFIPWP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1044")]
		public LegacyCV2Result<None> HGOZAKDKERR(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1045")]
		public LegacyCV2Result<None> XJKPZPZGLKC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1046")]
		public LegacyCV2Result<None> SUCZYUHMKAO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XYMOPNQAVQS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1234")]
		public LegacyCV2Result<None> KOVIJPNRION(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1236")]
		public LegacyCV2Result<None> FQQYDZNGCAA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1229")]
		public LegacyCV2Result<None> RJNXRUORWEO(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1241")]
		public LegacyCV2Result<None> XEEIDNMWCZY(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1242")]
		public LegacyCV2Result<None> DDLMCAQVLND(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1243")]
		public LegacyCV2Result<None> URGUIYBRQFX(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1244")]
		public LegacyCV2Result<None> YNDYEONYLLV(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1245")]
		public LegacyCV2Result<None> ASIYSIMHLAA(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RLYEICMXKYS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YGPDJXMVQKS(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NDXVAOPBAOI(MMFRHKTHWJJ a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1259")]
		public LegacyCV2Result<None> IFIGIEXUQHS(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1260")]
		public LegacyCV2Result<None> AKFDCOIDBES(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1261")]
		public LegacyCV2Result<None> QDDCXZBWNHI(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1262")]
		public LegacyCV2Result<None> EFFAJUOYTYC(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x28858C0", Offset = "0x2884AC0", VA = "0x1828858C0")]
		public JBVFRZIXLOT([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(MMFRHKTHWJJ e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1280")]
		public LegacyCV2Result<None> QLEZYSTUBXP(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1281")]
		public LegacyCV2Result<None> LGTKSAJPJFG(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "599")]
		public LegacyCV2Result<None> RDLFNHNGTJM(MMFRHKTHWJJ e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1293")]
		public LegacyCV2Result<None> EKSQZVJLUVH(YSXOFHETLFK e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1294")]
		public LegacyCV2Result<None> HDHYPPBITQU(YSXOFHETLFK e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1295")]
		public LegacyCV2Result<None> ZSBXHKPCTMJ(YSXOFHETLFK e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1296")]
		public LegacyCV2Result<None> OBNCMWKXFBZ(YSXOFHETLFK e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1297")]
		public LegacyCV2Result<None> QBSVTFAILNU(YSXOFHETLFK e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LegacyCV2Result<None> ConstantStorefrontItem(MMFRHKTHWJJ e, InOut io, [In] RBZJEBYGYJX storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(MMFRHKTHWJJ e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> KMHDSWUVNKG(MMFRHKTHWJJ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, NMFYZWMULLA.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> LHKVBRTFPFS(MMFRHKTHWJJ a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, NMFYZWMULLA.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1207")]
		private LegacyCV2Result<None> UIVUGGCITAT(MMFRHKTHWJJ a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1216")]
		private LegacyCV2Result<None> BBKQZURSRTS(MMFRHKTHWJJ a, InOut b, [In] RBZJEBYGYJX storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860", Slot = "1257")]
		private LegacyCV2Result<None> PGPDTIFRVXW(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class UGONBQRALJY : AWWUWPORMXN
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(AWZLFQYUZEA node);

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly UGONBQRALJY WGTQXNAIYNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate HXBKZQPSGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate WGHQMABJJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool JSHTLOXEUOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool DXJJCNIILYN;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650", Slot = "4")]
		public Task<bool> UJLEVQAAZKU(AWZLFQYUZEA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x289B630", Offset = "0x289A830", VA = "0x18289B630", Slot = "5")]
		public Task<bool> CTJPQMXZGCD(AWZLFQYUZEA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x289B700", Offset = "0x289A900", VA = "0x18289B700")]
		public UGONBQRALJY([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x289B660", Offset = "0x289A860", VA = "0x18289B660", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? MTBYYCCMSNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xABE620", Offset = "0xABD820", VA = "0x180ABE620", Slot = "7")]
		public bool GBWMEXTKPNX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x136C8F0", Offset = "0x136BAF0", VA = "0x18136C8F0", Slot = "8")]
		public bool CIEGGHHNEHD()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class ECYASBOHHWG : FDJTTYTVEAZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid YSYNMOMNWIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xCAA5E0", Offset = "0xCA97E0", VA = "0x180CAA5E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public void Bind(QXVQHOXBWQJ pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xEC63F0", Offset = "0xEC55F0", VA = "0x180EC63F0")]
		public ECYASBOHHWG(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2893460", Offset = "0x2892660", VA = "0x182893460")]
		public static ECYASBOHHWG New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class WSUSRDAVGAU : DTXINBLHAUG
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<ZTTYPUHCXEP> nodeDefId, Id128<NZKBDZMUQMJ>? legacyInnerGraphId, IReadOnlyDictionary<Id128<NZKBDZMUQMJ>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IsNodeRestrictedDelegate? KIARERJYTNJ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool AXDPRMAFLGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool XMFSYREULRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x289BA00", Offset = "0x289AC00", VA = "0x18289BA00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool EWOIFIWDKZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xFA09C0", Offset = "0xF9FBC0", VA = "0x180FA09C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "6")]
		public bool ZBHLCSLYSHD(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "7")]
		public CanSaveObjectIntoInventionResultType GBZFVLTQBDU(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x289BA10", Offset = "0x289AC10", VA = "0x18289BA10", Slot = "8")]
		public bool ZYCGJHKZEJH(Id128<ZTTYPUHCXEP> nodeDefId, Id128<NZKBDZMUQMJ>? legacyInnerGraphId, IReadOnlyDictionary<Id128<NZKBDZMUQMJ>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "9")]
		public bool EANQRKGGPHA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "10")]
		public bool YRIPYAENARC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x289BA60", Offset = "0x289AC60", VA = "0x18289BA60")]
		public WSUSRDAVGAU(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class ZRRKXEFTTOK : ZFMOZXUXWVN
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly ZRRKXEFTTOK WGTQXNAIYNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventSenderToMakerPenDelegate LKQXTNTIQHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate GDZACFBVDGE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool VMKJGVRCAZY
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x106A460", Offset = "0x1069660", VA = "0x18106A460", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GNBWXRSJIJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x289BE60", Offset = "0x289B060", VA = "0x18289BE60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x289BF00", Offset = "0x289B100", VA = "0x18289BF00")]
		public ZRRKXEFTTOK([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class NWDDGBBGLRK : MVSDGWXZBFC<IWSAOBCGBQA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class PEBNRROGISL : IWSAOBCGBQA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly PEBNRROGISL DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool LOAQMDJTYTH
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x28969F0", Offset = "0x2895BF0", VA = "0x1828969F0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			public void EMXLEVZLMVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PEBNRROGISL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NWDDGBBGLRK DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private NWDDGBBGLRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2896930", Offset = "0x2895B30", VA = "0x182896930", Slot = "4")]
		public IWSAOBCGBQA XTUCPHPYGWR()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class UEZCSOSHWMK<a, b> : IDisposable, KDTPHZGDKFX where a : notnull where b : notnull, RUKMRQNSREQ.IRREUTSWWRI<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly b SNMLORCJSFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly a GTTHCKBKMAB;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<WBUFIROFFZC> SFCNOYKIGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WBUFIROFFZC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x608BCC0", Offset = "0x608AEC0", VA = "0x18608BCC0")]
		public UEZCSOSHWMK(b a, a b, Id32<WBUFIROFFZC> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x6268250", Offset = "0x6267450", VA = "0x186268250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x6268D60", Offset = "0x6267F60", VA = "0x186268D60")]
		public Id32<EWGMMJRBQBF> JKSHMJDUPXM([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<EWGMMJRBQBF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x626A400", Offset = "0x6269600", VA = "0x18626A400", Slot = "6")]
		public void ZXOGBJIVFHT(Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x6269A50", Offset = "0x6268C50", VA = "0x186269A50", Slot = "7")]
		public void QUFIGGIYNTV(Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x6269560", Offset = "0x6268760", VA = "0x186269560", Slot = "8")]
		public void QQVWDFMOAWA(Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x6269520", Offset = "0x6268720", VA = "0x186269520", Slot = "10")]
		public void OESUDQEJDIL(Id32<EWGMMJRBQBF> objectId, Id32<WBUFIROFFZC> clientId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x626A170", Offset = "0x6269370", VA = "0x18626A170", Slot = "9")]
		public void WFKQXGSMYIV(Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x6268800", Offset = "0x6267A00", VA = "0x186268800", Slot = "11")]
		public void JIBXTVCKECJ(Id32<EWGMMJRBQBF> objectId, UONXEOOHNDK? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x62684B0", Offset = "0x62676B0", VA = "0x1862684B0", Slot = "12")]
		public Id32<WBUFIROFFZC> GOEFGJWDJBA(Id32<EWGMMJRBQBF> objectId)
		{
			return default(Id32<WBUFIROFFZC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x6268D00", Offset = "0x6267F00", VA = "0x186268D00", Slot = "13")]
		public Id32<YEBAVXANZUR> JKRDGKHTGUS(Id32<EWGMMJRBQBF> objectId, string a, object b, bool c, SENDBEGBGCT d, OKDUMEVVPFL e)
		{
			return default(Id32<YEBAVXANZUR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x6269EE0", Offset = "0x62690E0", VA = "0x186269EE0", Slot = "14")]
		public void UKIWYYPDBJU(Id32<YEBAVXANZUR> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x6269030", Offset = "0x6268230", VA = "0x186269030", Slot = "15")]
		public void OBPCQLHPYMM(Id32<YEBAVXANZUR> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class RUKMRQNSREQ
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface IRREUTSWWRI<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HHRXNLUQEDM(a a, Id32<WBUFIROFFZC> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<WBUFIROFFZC>? ANZHLXYEZQJ(a a);

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<EWGMMJRBQBF> JKSHMJDUPXM(a a, Id32<WBUFIROFFZC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void ZXOGBJIVFHT(a a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void QUFIGGIYNTV(a a, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void OESUDQEJDIL(a a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void WFKQXGSMYIV(a a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void JIBXTVCKECJ(a a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, UONXEOOHNDK? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<WBUFIROFFZC>? GOEFGJWDJBA(a a, Id32<EWGMMJRBQBF> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<YEBAVXANZUR> JKRDGKHTGUS(a a, Id32<WBUFIROFFZC> clientId, string b, object c, SENDBEGBGCT d, OKDUMEVVPFL e);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void UKIWYYPDBJU(a a, Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void OBPCQLHPYMM(a a, Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class TMBSTJTMPTQ
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly HashSet<Id32<EWGMMJRBQBF>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SOAId32Field<YEBAVXANZUR, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly Dictionary<Id32<YEBAVXANZUR>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<YEBAVXANZUR>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public SOAField<EWGMMJRBQBF, UONXEOOHNDK?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x28965D0", Offset = "0x28957D0", VA = "0x1828965D0")]
			private MockCV2DynamicNetSys(HashSet<Id32<EWGMMJRBQBF>> authorityOf, [In] SOAId32Field<YEBAVXANZUR, MockCV2SyncField> syncFields, Dictionary<Id32<YEBAVXANZUR>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<YEBAVXANZUR>> mockSyncFieldToSyncField, [In] SOAField<EWGMMJRBQBF, UONXEOOHNDK?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x2896410", Offset = "0x2895610", VA = "0x182896410")]
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
			public Id32<WBUFIROFFZC>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2896670", Offset = "0x2895870", VA = "0x182896670")]
			public MockCV2ObjectShared(Id32<WBUFIROFFZC> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public OKDUMEVVPFL SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public SENDBEGBGCT SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
			internal MockCV2SyncField(OKDUMEVVPFL syncField, SENDBEGBGCT syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x2896790", Offset = "0x2895990", VA = "0x182896790")]
			public static MockCV2SyncField New(OKDUMEVVPFL syncField, SENDBEGBGCT syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x2896740", Offset = "0x2895940", VA = "0x182896740")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x28966F0", Offset = "0x28958F0", VA = "0x1828966F0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<EWGMMJRBQBF, MockCV2ObjectShared> DBCWBUQIZWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<EWGMMJRBQBF>> YDSYLVEAFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> WIWOVSXEYPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> ZILMDXSZOSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAField<WBUFIROFFZC, MockCV2DynamicNetSys> ZJAIVDJGZMH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<EWGMMJRBQBF>? FKDJHKKQAAL
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xB7B0F0", Offset = "0xB7A2F0", VA = "0x180B7B0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x101EEC0", Offset = "0x101E0C0", VA = "0x18101EEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x2896C90", Offset = "0x2895E90", VA = "0x182896C90")]
		public void Destroy([In] SOAId32<WBUFIROFFZC> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2898340", Offset = "0x2897540", VA = "0x182898340")]
		public void YTQZFOTVQGG(Id32<WBUFIROFFZC> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2896F20", Offset = "0x2896120", VA = "0x182896F20")]
		public void HHRXNLUQEDM(Id32<WBUFIROFFZC> clientId, Id32<WBUFIROFFZC>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x28975A0", Offset = "0x28967A0", VA = "0x1828975A0")]
		public Id32<EWGMMJRBQBF> JKSHMJDUPXM(Id32<WBUFIROFFZC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<WBUFIROFFZC> clientIds)
		{
			return default(Id32<EWGMMJRBQBF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2897340", Offset = "0x2896540", VA = "0x182897340")]
		public Id32<YEBAVXANZUR> JKRDGKHTGUS(Id32<WBUFIROFFZC> clientId, string a, object b, SENDBEGBGCT c, OKDUMEVVPFL d)
		{
			return default(Id32<YEBAVXANZUR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2898030", Offset = "0x2897230", VA = "0x182898030")]
		public void UKIWYYPDBJU(Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x28979B0", Offset = "0x2896BB0", VA = "0x1828979B0")]
		public Id32<EWGMMJRBQBF>? MSSVHWHMRYP([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x28987A0", Offset = "0x28979A0", VA = "0x1828987A0")]
		public void ZXOGBJIVFHT([In] SOAId32<WBUFIROFFZC> clientIds, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x2897EF0", Offset = "0x28970F0", VA = "0x182897EF0")]
		public void QUFIGGIYNTV(Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2897DF0", Offset = "0x2896FF0", VA = "0x182897DF0")]
		public void OESUDQEJDIL(Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x28981C0", Offset = "0x28973C0", VA = "0x1828981C0")]
		public void WFKQXGSMYIV([In] SOAId32<WBUFIROFFZC> clientIds, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2897270", Offset = "0x2896470", VA = "0x182897270")]
		public void JIBXTVCKECJ(Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, UONXEOOHNDK? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2896ED0", Offset = "0x28960D0", VA = "0x182896ED0")]
		public Id32<WBUFIROFFZC>? GOEFGJWDJBA(Id32<EWGMMJRBQBF> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2897A80", Offset = "0x2896C80", VA = "0x182897A80")]
		public void OBPCQLHPYMM([In] SOAId32<WBUFIROFFZC> clientIds, Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2898820", Offset = "0x2897A20", VA = "0x182898820")]
		public TMBSTJTMPTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class HPMHVLVIWBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x28945F0", Offset = "0x28937F0", VA = "0x1828945F0")]
		public static void Destroy(this TMBSTJTMPTQ.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class USAYTWLWUDX : DHWOCRSWHCF.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static USAYTWLWUDX NNHWYYTYYBM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate JAYBCWSBIQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate DBUHQGNCIWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xAC0190", VA = "0x180AC0F90")]
		public USAYTWLWUDX(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class FLBRYQMQISN : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : EFFEKHEHDBI.SPPQSEQBPDZ<USPEKNRWVPE, FLBRYQMQISN>
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
				public AsyncTaskMethodBuilder<Result<object, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public FLBRYQMQISN root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public Id32<WBUFIROFFZC> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public USPEKNRWVPE action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007A8")]
				[Cpp2IlInjected.Address(RVA = "0x289A700", Offset = "0x2899900", VA = "0x18289A700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A9")]
				[Cpp2IlInjected.Address(RVA = "0x289A940", Offset = "0x2899B40", VA = "0x18289A940", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
			public int OJMFVDRGOBB(FLBRYQMQISN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2896C20", Offset = "0x2895E20", VA = "0x182896C20", Slot = "5")]
			public int FMSITNXPEGZ(FLBRYQMQISN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2896A90", Offset = "0x2895C90", VA = "0x182896A90", Slot = "6")]
			public int DJXILAZTWKS(FLBRYQMQISN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2896C00", Offset = "0x2895E00", VA = "0x182896C00", Slot = "7")]
			public int DZYFWPRONGG(FLBRYQMQISN a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2896C40", Offset = "0x2895E40", VA = "0x182896C40", Slot = "8")]
			public void TMVLAUPQAPH(FLBRYQMQISN a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "9")]
			public bool TVUSOXTFEZQ(FLBRYQMQISN a, Id32<WBUFIROFFZC> actorId, USPEKNRWVPE[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "10")]
			public bool VTCUAOWZHAA(FLBRYQMQISN a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2896AB0", Offset = "0x2895CB0", VA = "0x182896AB0", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(FLBRYQMQISN a, Id32<WBUFIROFFZC> senderId, USPEKNRWVPE b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : EFFEKHEHDBI.IRGRAGFCDUQ<ActionDeps, RRHCIMKELZN.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps FZGUDAFCUUI
			{
				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public RRHCIMKELZN.StaticNetSysReceiverDeps URLACMZNMGP
			{
				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "5")]
				get
				{
					return default(RRHCIMKELZN.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps OEQZUDEYNPI
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : HSDFQCPFMJG.IRREUTSWWRI<FLBRYQMQISN>
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
				public AsyncTaskMethodBuilder<Result<object?, JDUFGOJEPGU>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public FLBRYQMQISN root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public Id32<WBUFIROFFZC> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public USPEKNRWVPE action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x289A3E0", Offset = "0x28995E0", VA = "0x18289A3E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x289A690", Offset = "0x2899890", VA = "0x18289A690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x28967D0", Offset = "0x28959D0", VA = "0x1828967D0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, USPEKNRWVPE b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : RUKMRQNSREQ.IRREUTSWWRI<FLBRYQMQISN>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x2895E70", Offset = "0x2895070", VA = "0x182895E70", Slot = "4")]
			public void HHRXNLUQEDM(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xD008A0", Offset = "0xCFFAA0", VA = "0x180D008A0", Slot = "5")]
			public Id32<WBUFIROFFZC>? ANZHLXYEZQJ(FLBRYQMQISN a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x2895DB0", Offset = "0x2894FB0", VA = "0x182895DB0")]
			public Id32<EWGMMJRBQBF> JKSHMJDUPXM(FLBRYQMQISN a, Id32<WBUFIROFFZC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<EWGMMJRBQBF>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x2896380", Offset = "0x2895580", VA = "0x182896380", Slot = "7")]
			public void ZXOGBJIVFHT(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2896050", Offset = "0x2895250", VA = "0x182896050", Slot = "8")]
			public void QUFIGGIYNTV(FLBRYQMQISN a, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2896010", Offset = "0x2895210", VA = "0x182896010", Slot = "9")]
			public void OESUDQEJDIL(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x2896350", Offset = "0x2895550", VA = "0x182896350", Slot = "10")]
			public void WFKQXGSMYIV(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, JTJUXJHUUIO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2895EA0", Offset = "0x28950A0", VA = "0x182895EA0", Slot = "11")]
			public void JIBXTVCKECJ(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<EWGMMJRBQBF> objectId, UONXEOOHNDK? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2895E10", Offset = "0x2895010", VA = "0x182895E10", Slot = "12")]
			public Id32<WBUFIROFFZC>? GOEFGJWDJBA(FLBRYQMQISN a, Id32<EWGMMJRBQBF> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2895F80", Offset = "0x2895180", VA = "0x182895F80", Slot = "13")]
			public Id32<YEBAVXANZUR> JKRDGKHTGUS(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, string b, object c, SENDBEGBGCT d, OKDUMEVVPFL e)
			{
				return default(Id32<YEBAVXANZUR>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x28961B0", Offset = "0x28953B0", VA = "0x1828961B0", Slot = "14")]
			public void UKIWYYPDBJU(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2895FE0", Offset = "0x28951E0", VA = "0x182895FE0", Slot = "15")]
			public void OBPCQLHPYMM(FLBRYQMQISN a, Id32<WBUFIROFFZC> clientId, Id32<YEBAVXANZUR> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x2895DB0", Offset = "0x2894FB0", VA = "0x182895DB0", Slot = "6")]
			private Id32<EWGMMJRBQBF> FUFGWIRVBLM(FLBRYQMQISN a, Id32<WBUFIROFFZC> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<EWGMMJRBQBF>);
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
			public FLBRYQMQISN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Id32<EWGMMJRBQBF>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public QGBMHGUBIHM deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Id32<WBUFIROFFZC> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private TYTYGWVULLU<FLBRYQMQISN, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private UEZCSOSHWMK<FLBRYQMQISN, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private RRHCIMKELZN <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2899D20", Offset = "0x2898F20", VA = "0x182899D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x289A370", Offset = "0x2899570", VA = "0x18289A370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly TMMPJYCAKEG<USPEKNRWVPE, None, RRHCIMKELZN, ActionDeps, RRHCIMKELZN.StaticNetSysReceiverDeps, RootDeps, FLBRYQMQISN, Deps> IZNZUPEBEJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly TMBSTJTMPTQ WNIGAJTBMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAId32<WBUFIROFFZC> GEZHWCUHICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<WBUFIROFFZC, None> ZJAIVDJGZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAField<WBUFIROFFZC, RRHCIMKELZN> FVMWZSFEAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Id32<WBUFIROFFZC>? HEPIERGISGM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate IIGUINYGNWS
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xABF5C0", Offset = "0xABE7C0", VA = "0x180ABF5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2893ED0", Offset = "0x28930D0", VA = "0x182893ED0")]
		public FLBRYQMQISN(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2893810", Offset = "0x2892A10", VA = "0x182893810", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x2893D50", Offset = "0x2892F50", VA = "0x182893D50")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> YTQZFOTVQGG(QGBMHGUBIHM a, RegistryV2 b, Id32<EWGMMJRBQBF>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x28939E0", Offset = "0x2892BE0", VA = "0x1828939E0")]
		private void HHRXNLUQEDM(Id32<WBUFIROFFZC> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x2893C70", Offset = "0x2892E70", VA = "0x182893C70")]
		[CompilerGenerated]
		private Id32<EWGMMJRBQBF>? KVCBGRESSJM([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class FFEAMARCNHO : HXXVFCDUHKY.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<BTDOGBIDVJH> DeserializeCircuitsJunctionAsyncDelegate(RRHCIMKELZN circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<BTDOGBIDVJH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public FFEAMARCNHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public RRHCIMKELZN circuitsManager;

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
			private TaskAwaiter<BTDOGBIDVJH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x2898A10", Offset = "0x2897C10", VA = "0x182898A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x2898C10", Offset = "0x2897E10", VA = "0x182898C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate HIQIQSMJGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleDidInitializeDelegate? ZHYOEEVNRAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LifecycleWillDestroyDelegate? IJZBXIERHWY;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x28934C0", Offset = "0x28926C0", VA = "0x1828934C0", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<BTDOGBIDVJH> JKDVPAMIYHK(RRHCIMKELZN a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public void BTUTCUGXTLW(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xD8CF60", Offset = "0xD8C160", VA = "0x180D8CF60", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xE43CC0", Offset = "0xE42EC0", VA = "0x180E43CC0", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2893630", Offset = "0x2892830", VA = "0x182893630")]
		public FFEAMARCNHO([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class IDPBGXKOXDE : PTEMFAIRMBY.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate PZCZATDXERS GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<NJNAUXVLGSU> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<VBVBJYMCJCU> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<PTEMFAIRMBY.ELSNTWPCDON.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<PTEMFAIRMBY.ELSNTWPCDON.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<PTEMFAIRMBY.ELSNTWPCDON.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x2898C80", Offset = "0x2897E80", VA = "0x182898C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x2898E70", Offset = "0x2898070", VA = "0x182898E70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<VBVBJYMCJCU> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<VBVBJYMCJCU> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x2898EE0", Offset = "0x28980E0", VA = "0x182898EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x28990D0", Offset = "0x28982D0", VA = "0x1828990D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<NJNAUXVLGSU> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private TaskAwaiter<NJNAUXVLGSU> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x2899140", Offset = "0x2898340", VA = "0x182899140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x2899330", Offset = "0x2898530", VA = "0x182899330", Slot = "5")]
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
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x28993A0", Offset = "0x28985A0", VA = "0x1828993A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x2899590", Offset = "0x2898790", VA = "0x182899590", Slot = "5")]
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
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x2899600", Offset = "0x2898800", VA = "0x182899600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x28997F0", Offset = "0x28989F0", VA = "0x1828997F0", Slot = "5")]
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
			public IDPBGXKOXDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x2899860", Offset = "0x2898A60", VA = "0x182899860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x2899A50", Offset = "0x2898C50", VA = "0x182899A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetCV2DependenciesDelegate PWVKPPWPILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetRoomDataAsyncDelegate DIASOBITWOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetSuperRoomDataAsyncDelegate DQZVZUOOZOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomAssetDataAsyncDelegate DUXLKGXTWGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetPlayerSaveDataAsyncDelegate ALEMDTQURPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate EEPTCOIAHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetStaticCircuitsConfigAsyncDelegate PSSCUHDENLY;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PZCZATDXERS PZCZATDXERS
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x106A460", Offset = "0x1069660", VA = "0x18106A460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2894830", Offset = "0x2893A30", VA = "0x182894830", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> GQZYFHICZDT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2894940", Offset = "0x2893B40", VA = "0x182894940", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> HXUWLQGTRBK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2894B60", Offset = "0x2893D60", VA = "0x182894B60", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<NJNAUXVLGSU> PBAYARRHHRJ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2894C70", Offset = "0x2893E70", VA = "0x182894C70", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<VBVBJYMCJCU> QNHQANGMPPK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2894A50", Offset = "0x2893C50", VA = "0x182894A50", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<PTEMFAIRMBY.ELSNTWPCDON.CircuitGraphToolMapping> OYWIEMATUXT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x2894D80", Offset = "0x2893F80", VA = "0x182894D80", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> ZSGLOLATFLK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2894E90", Offset = "0x2894090", VA = "0x182894E90")]
		public IDPBGXKOXDE(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class AQFQGQATZDM : CV2Request.ELSNTWPCDON
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CV2Request.ELSNTWPCDON DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly GetCanSendRequestsDelegate NWLFFMAEIRA;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public AQFQGQATZDM(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x106A460", Offset = "0x1069660", VA = "0x18106A460", Slot = "4")]
		public bool TRWLVHSLAVE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class HXSHKFHAMAV : BKQRFKBWSPS
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, WMUYMRHRYMC> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly TryReportErrToUserDelegate MQHPPSABDCS;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650")]
		public bool PJBGBUBJGRW([In] Result<None, WMUYMRHRYMC> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x2894680", Offset = "0x2893880", VA = "0x182894680")]
		public HXSHKFHAMAV([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650", Slot = "4")]
		private bool BAAKKMBUGMH([In] Result<None, WMUYMRHRYMC> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class UCORKPMPXVG : KCBFZEYCEZD
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate MMFRHKTHWJJ CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly UCORKPMPXVG DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly CurrentExecParamsDelegate? YWRTUGDZNCG;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MMFRHKTHWJJ WALCZQZNUCK
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0x106A460", Offset = "0x1069660", VA = "0x18106A460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public UCORKPMPXVG([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class YFKRAUYQKWW : PUFXDFRADIJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly PUFXDFRADIJ DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly GetGameColorFromIdDelegate NHLQWPOUYKC;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650", Slot = "4")]
		public CircuitsColor VJABFFGJREE(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x289BCC0", Offset = "0x289AEC0", VA = "0x18289BCC0")]
		public YFKRAUYQKWW([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class LWXAWFKRJLY : TWDSZOCCEPP
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
			public LWXAWFKRJLY <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x2899AC0", Offset = "0x2898CC0", VA = "0x182899AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x2899CB0", Offset = "0x2898EB0", VA = "0x182899CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly IsStringPureAsyncDelegate LKREVYLYHLP;

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2895AC0", Offset = "0x2894CC0", VA = "0x182895AC0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> WMLPFRLMGEV(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2895C00", Offset = "0x2894E00", VA = "0x182895C00")]
		public LWXAWFKRJLY([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class KJMKEELSJNC : SPZWLQEAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate XHIYDWWLCZB? GetNodeVisualizationConfigDelegate([In] Id128<ZTTYPUHCXEP> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly SPZWLQEAMOP DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly GetNodeVisualizationConfigDelegate GXUTYNWZYOE;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650")]
		public XHIYDWWLCZB? EODDZQCAGTI([In] Id128<ZTTYPUHCXEP> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2895910", Offset = "0x2894B10", VA = "0x182895910")]
		public KJMKEELSJNC([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893850", VA = "0x182894650", Slot = "4")]
		private XHIYDWWLCZB BKRMNAOILIO([In] Id128<ZTTYPUHCXEP> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class TVECNEPKRGX : FTTHWDAOFXU
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x28989C0", Offset = "0x2897BC0", VA = "0x1828989C0", Slot = "4")]
		public VWEUPIINCCP MGYFTFTIGOX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public TVECNEPKRGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class HCNRNOCDOZL : ITZIBLWYZOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, bool> TGOAAUIMTKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, float> XQFCZWRDCRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, double> HCAEGZMSCBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, int> NDGJAVXUFVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, long> YFWSAFSMQZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, string> NSRASWGUZBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, uint> XUOQOWPIDKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, ulong> BUSUQKMEPFB;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x28942E0", Offset = "0x28934E0", VA = "0x1828942E0", Slot = "4")]
		public bool? OLNNBCXKKBS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2894380", Offset = "0x2893580", VA = "0x182894380")]
		public HCNRNOCDOZL()
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
