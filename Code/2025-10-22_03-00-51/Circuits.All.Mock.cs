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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A8BCA0", Offset = "0x2A8A2A0", VA = "0x182A8BCA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		internal sealed class LHOWDVIOSHO : VWLNCMIYRQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LHOWDVIOSHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "4")]
			public VWLNCMIYRQD UFOBQLPYKRZ(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "5")]
			public VWLNCMIYRQD XCTNHSETELQ(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "6")]
			public VWLNCMIYRQD JJELXSMJFVY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			public void BESFLJVUAJT()
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
	public static class WYPPLICQMKV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public ASSELTRXPVM TPSADPOHKNZ;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2A82B70", Offset = "0x2A81170", VA = "0x182A82B70")]
			internal XXXVQBZACHC RUDKKLPKWJI(GetNetworkObjectDelegate a)
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
			public SVUOYNNHAFU dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public ASKJDRVYIOB network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public RegistryV2? registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D530", Offset = "0x2A8BB30", VA = "0x182A8D530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A8DBD0", Offset = "0x2A8C1D0", VA = "0x182A8DBD0", Slot = "5")]
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
			public ASKJDRVYIOB network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public SVUOYNNHAFU dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<VFXBTZQLZOD>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private GCFTXZUHCVV <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2A8DC40", Offset = "0x2A8C240", VA = "0x182A8DC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E1D0", Offset = "0x2A8C7D0", VA = "0x182A8E1D0", Slot = "5")]
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
			public ASSELTRXPVM roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E240", Offset = "0x2A8C840", VA = "0x182A8E240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E750", Offset = "0x2A8CD50", VA = "0x182A8E750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A92530", Offset = "0x2A90B30", VA = "0x182A92530")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? ZIYGNUSKHLS([Optional] ASSELTRXPVM? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A92160", Offset = "0x2A90760", VA = "0x182A92160")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> DIGCIXBQJPD(ASKJDRVYIOB a, [Optional] SVUOYNNHAFU? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A91FD0", Offset = "0x2A905D0", VA = "0x182A91FD0")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> DIGCIXBQJPD(ASKJDRVYIOB a, SVUOYNNHAFU b, RegistryV2 c, Id32<VFXBTZQLZOD>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A922E0", Offset = "0x2A908E0", VA = "0x182A922E0")]
		public static (RuntimeFnRegistry, RuntimeFns) FKMTNTNJWUB()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A923B0", Offset = "0x2A909B0", VA = "0x182A923B0")]
		public static (ExternalFnRegistry, ExternalFns) WFGHYLHIWVU()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A924B0", Offset = "0x2A90AB0", VA = "0x182A924B0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static ASKJDRVYIOB YCZSEZHKROT(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class KHOFYFWRAJD
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate XXXVQBZACHC CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public KHOFYFWRAJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D140", Offset = "0x2A8B740", VA = "0x182A8D140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D4C0", Offset = "0x2A8BAC0", VA = "0x182A8D4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ASKJDRVYIOB JTMFLQFFBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? CFBIDKENHTV;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		private KHOFYFWRAJD(ASKJDRVYIOB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A89940", Offset = "0x2A87F40", VA = "0x182A89940")]
		public static KHOFYFWRAJD MMOZYBUGEIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A89830", Offset = "0x2A87E30", VA = "0x182A89830")]
		public KHOFYFWRAJD ABMKSYCWQZO(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A89850", Offset = "0x2A87E50", VA = "0x182A89850")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> BESFLJVUAJT()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class SIGDPHTXRMT : GCFTXZUHCVV.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate UHKYITKHAZL NewCircuitsLifecycleDelegate(NSYQZFEHSAE.ETPODEKPKCV deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(GCFTXZUHCVV circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(GCFTXZUHCVV circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate OPWCGOGKEYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate IDDAQNUNRTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate YTERXWKZZPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate FHNWQMLYQIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate SNPIGRJXUSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate CAJHSWZEYDY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int VZVRXWXIHFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130AFA0", VA = "0x18130C9A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C480", Offset = "0x2A8AA80", VA = "0x182A8C480", Slot = "6")]
		public void SKOXYMLXRLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C420", Offset = "0x2A8AA20", VA = "0x182A8C420", Slot = "7")]
		public void FSGFCDYIJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C450", Offset = "0x2A8AA50", VA = "0x182A8C450", Slot = "5")]
		public UHKYITKHAZL RXGNKYXJKIC(NSYQZFEHSAE.ETPODEKPKCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF7D3B0", Offset = "0xF7B9B0", VA = "0x180F7D3B0", Slot = "8")]
		public void HUSHVTDZFPR(GCFTXZUHCVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF7D410", Offset = "0xF7BA10", VA = "0x180F7D410", Slot = "9")]
		public void TFOEHDFCOGU(GCFTXZUHCVV a, LOHJEAGYXDY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C4B0", Offset = "0x2A8AAB0", VA = "0x182A8C4B0")]
		public SIGDPHTXRMT([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly HDNLXSMDIFI<ASKJDRVYIOB, ASKJDRVYIOB.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly HNVVLXUNLMK<ASKJDRVYIOB, ASKJDRVYIOB.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly GCFTXZUHCVV CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<CYNSIGMASWI> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly ASKJDRVYIOB Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2A89210", Offset = "0x2A87810", VA = "0x182A89210")]
		public EVCreationResult(HDNLXSMDIFI<ASKJDRVYIOB, ASKJDRVYIOB.MockStaticNetSysDeps> staticNetSys, HNVVLXUNLMK<ASKJDRVYIOB, ASKJDRVYIOB.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, GCFTXZUHCVV circuitsManager, Id32<CYNSIGMASWI> clientId, ASKJDRVYIOB network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly GCFTXZUHCVV _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 MYBZADTWQQP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B990", Offset = "0x2A89F90", VA = "0x182A8B990")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request DWHUSIKYOHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B870", Offset = "0x2A89E70", VA = "0x182A8B870")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public QFPJTZRYEHQ? UMKZFYAKISJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B8A0", Offset = "0x2A89EA0", VA = "0x182A8B8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OIGOTMLEWKK? ILTKTHFNKWF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8B9C0", Offset = "0x2A89FC0", VA = "0x182A8B9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		internal LimitedCircuits(GCFTXZUHCVV circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class DOLCCOEIWZR : SVUOYNNHAFU
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DGWFRGWFTEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public XXXVQBZACHC MFAFQYNBZVS;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DGWFRGWFTEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			internal XXXVQBZACHC GENHGYQMOYO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NSYQZFEHSAE.ETPODEKPKCV AJJBGENQMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GCFTXZUHCVV.ETPODEKPKCV TAMVWCNWDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IXJRKHRRWZM.ETPODEKPKCV KKWGCFWANYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV> HNQJNNXCKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.ETPODEKPKCV KKRRWLHBOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GNHUSEXYYOY BVEQRGODZUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public XKMIIYNPIFP VOIUHUXOAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WBTIGOWHAUR XVOEQIEJWDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AATAVYXKSWN KTBLMYHBMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OYLYGLUJTWX DMLXLIZEOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A88BD0", Offset = "0x2A871D0", VA = "0x182A88BD0")]
		private DOLCCOEIWZR(NSYQZFEHSAE.ETPODEKPKCV a, GCFTXZUHCVV.ETPODEKPKCV b, IXJRKHRRWZM.ETPODEKPKCV c, WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV> d, CV2Request.ETPODEKPKCV e, GNHUSEXYYOY f, XKMIIYNPIFP g, WBTIGOWHAUR h, AATAVYXKSWN i, OYLYGLUJTWX j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A88730", Offset = "0x2A86D30", VA = "0x182A88730")]
		public static DOLCCOEIWZR? NVNIEHLXZUE(IXJRKHRRWZM.ETPODEKPKCV cv2RootSysDeps, [Optional] NSYQZFEHSAE.ETPODEKPKCV? a, [Optional] GCFTXZUHCVV.ETPODEKPKCV? b, [Optional] WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>? reducerDeps, [Optional] CV2Request.ETPODEKPKCV? c, [Optional] GNHUSEXYYOY? d, [Optional] XKMIIYNPIFP? e, [Optional] WBTIGOWHAUR? f, [Optional] AATAVYXKSWN? g, [Optional] OYLYGLUJTWX? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2A88A80", Offset = "0x2A87080", VA = "0x182A88A80")]
		public static DOLCCOEIWZR XVABEDBPBTG(XXXVQBZACHC a, [Optional] NSYQZFEHSAE.ETPODEKPKCV? circuitsLifecycleDeps, [Optional] GCFTXZUHCVV.ETPODEKPKCV? circuitsManagerDeps, [Optional] WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A883D0", Offset = "0x2A869D0", VA = "0x182A883D0")]
		public static DOLCCOEIWZR BNGEFZEOOTY(GetNetworkObjectDelegate a, [Optional] NSYQZFEHSAE.ETPODEKPKCV? circuitsLifecycleDeps, [Optional] GCFTXZUHCVV.ETPODEKPKCV? circuitsManagerDeps, [Optional] WBBSASUOFLK.UWEOGEPSJXO<ActionKind, LOHJEAGYXDY, GCFTXZUHCVV>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class BQKZANCLQZU
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public GetNetworkObjectDelegate NGZDBHRIHEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int GQWNRQTJWUM;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2A8BAD0", Offset = "0x2A8A0D0", VA = "0x182A8BAD0")]
			internal QIIJQLZWJRR VLVCPTHEFRM(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2A8BB40", Offset = "0x2A8A140", VA = "0x182A8BB40")]
			internal QIIJQLZWJRR[] VMAJNABBPCV(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			internal int KIJMSAWMYXL()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class MVUFAWQIRUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DynamicEnvironmentNetworkId FWAJDMZCJAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MVZLYDKGBFP GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVUFAWQIRUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2A8BA20", Offset = "0x2A8A020", VA = "0x182A8BA20")]
			internal QIIJQLZWJRR DGMSJTZAEPA(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly GYYCSYOYAST JFWIEAUNLFS;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2A82E60", Offset = "0x2A81460", VA = "0x182A82E60")]
		public static QIIJQLZWJRR? AGNYQMNSYLS(Id32<VFXBTZQLZOD>? networkObject, [Optional] CSOJLXZIXDU.SerializesIntoSavesDelegate? a, [Optional] CSOJLXZIXDU.SerializesIntoInventionsDelegate? b, [Optional] CSOJLXZIXDU.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A82E80", Offset = "0x2A81480", VA = "0x182A82E80")]
		public static XXXVQBZACHC? JNMVLPHCSLH(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] TNLURBVFQWD? b, [Optional] NXPBYZDUWHR? c, [Optional] SJGQYUFNORV? d, [Optional] ASSELTRXPVM? e, int f = 300000, bool g = false, bool h = false, [Optional] TNFASMSDJPF? i, [Optional] YTQIBUMCHZV? j, [Optional] HRZSZFUCEVK? k, [Optional] HYPBKAJTXLJ? l, [Optional] NHMEHIKTRAU? m, [Optional] ALSAFOPABCT? n, [Optional] ELJFDCEXYNX.ETPODEKPKCV? o, [Optional] EqualsNodeV2.ETPODEKPKCV? p, [Optional] GBKBVARMRDZ? q, [Optional] XXXVQBZACHC.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] XXXVQBZACHC.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] XXXVQBZACHC.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] XXXVQBZACHC.GetLocalRoomIdDelegate? u, [Optional] XXXVQBZACHC.GetLocalSubroomIdDelegate? v, [Optional] XXXVQBZACHC.GetSubroomIdsForLocalRoomDelegate? w, [Optional] XXXVQBZACHC.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] XXXVQBZACHC.SaveRoomOnPlayerBehalfDelegate? z, [Optional] XXXVQBZACHC.ReportCloudDataLedgerChangedDelegate? ba, [Optional] XXXVQBZACHC.GetColorNameByIdDelegate? bb, [Optional] XXXVQBZACHC.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] XXXVQBZACHC.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] XXXVQBZACHC.GetTaggableNameFromSignalDelegate? be, [Optional] XXXVQBZACHC.GetAudioNameFromSignalDelegate? bf, [Optional] XXXVQBZACHC.GetDestinationNameFromSignalDelegate? bg, [Optional] XXXVQBZACHC.GetPlayerEventNameFromSignalDelegate? bh, [Optional] XXXVQBZACHC.GetRoomKeyNameFromSignalDelegate? bi, [Optional] XXXVQBZACHC.GetRewardNameFromSignalDelegate? bj, [Optional] XXXVQBZACHC.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] XXXVQBZACHC.ReportPreloadedAudioChangedDelegate? bl, [Optional] XXXVQBZACHC.ReportRewardDataChangedDelegate? bm, [Optional] XXXVQBZACHC.GetConsumableNameFromSignalDelegate? bn, [Optional] XXXVQBZACHC.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] XXXVQBZACHC.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] XXXVQBZACHC.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] XXXVQBZACHC.GetInventoryItemNameFromSignalDelegate? br, [Optional] XXXVQBZACHC.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] XXXVQBZACHC.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] XXXVQBZACHC.GetRoomOfferNameFromSignalDelegate? bu, [Optional] XXXVQBZACHC.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] XXXVQBZACHC.GetObjectIdFromCreationObjectDelegate? bw, [Optional] XXXVQBZACHC.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] XXXVQBZACHC.GetCostInBytesDelegate? by, [Optional] XXXVQBZACHC.GetAvatarItemNameFromSignalDelegate? bz, [Optional] XXXVQBZACHC.PersistenceViewExistsAsReplicatorWithGraphDelegate? ca, [Optional] XXXVQBZACHC.DownloadCircuitTemplateRootDataDelegate? cb, [Optional] XXXVQBZACHC.GetDiscoverySectionNameFromSignalDelegate? cc, [Optional] XXXVQBZACHC.GetStoreItemNameFromSignalDelegate? cd, [Optional] XXXVQBZACHC.GetBodyPartNameFromSignalDelegate? ce, [Optional] XXXVQBZACHC.GetDependenciesForGraphInstanceDelegate? cf, [Optional] XXXVQBZACHC.GetAllDependenciesForEnvironmentDelegate? cg, [Optional] XXXVQBZACHC.GetPlayerAccountNameFromSignalDelegate? ch, [Optional] XXXVQBZACHC.GetRecNetImageNameFromSignalDelegate? ci, [Optional] XXXVQBZACHC.GetRecNetMeshNameFromSignalDelegate? cj, [Optional] LogDeps? ck, [Optional] XXXVQBZACHC.IsFunctionValidForAIDelegate? cl, [Optional] XXXVQBZACHC.GetAIFunctionNameFromSignalDelegate? cm)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<VFXBTZQLZOD>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class QFDMXTGNNGF : HRZSZFUCEVK
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly QFDMXTGNNGF ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly GetLocalPlayerDelegate? RZZDIMTPFJC;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C230", Offset = "0x2A8A830", VA = "0x182A8C230", Slot = "4")]
		public (ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH) UCMOAKJVLRJ(object a)
		{
			return default((ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH, ZVIRIZIDPXH));
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C200", Offset = "0x2A8A800", VA = "0x182A8C200", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "6")]
		public bool HFYUEIOIRYO(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB07DF0", Offset = "0xB063F0", VA = "0x180B07DF0", Slot = "7")]
		public string UIVTQJMHANS(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public QFDMXTGNNGF([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class CSOJLXZIXDU : QIIJQLZWJRR
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(CSOJLXZIXDU self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(CSOJLXZIXDU self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(CSOJLXZIXDU self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly SerializesIntoSavesDelegate WDDRPDHZNZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoInventionsDelegate YPKCXMKICVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly CanPublishInInventionsDelegate FDMDQZAVIVZ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private VYNMMJSGBGV? AWPKXBXDTCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId PBKDJYRFBRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x102BC40", Offset = "0x102A240", VA = "0x18102BC40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SOVLIYXLJKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A87540", Offset = "0x2A85B40", VA = "0x182A87540", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool CPRQADSULLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A87510", Offset = "0x2A85B10", VA = "0x182A87510", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HWWTHJNMVXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A874E0", Offset = "0x2A85AE0", VA = "0x182A874E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public WSMIHHJIXCQ? RFQHYQNHJTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<VFXBTZQLZOD>? WUZAPTSYVXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2A87390", Offset = "0x2A85990", VA = "0x182A87390", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A86E40", Offset = "0x2A85440", VA = "0x182A86E40", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(GYYCSYOYAST e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70", Slot = "13")]
		public void Bind(VYNMMJSGBGV controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A87430", Offset = "0x2A85A30", VA = "0x182A87430")]
		private CSOJLXZIXDU(Id32<VFXBTZQLZOD>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A86EE0", Offset = "0x2A854E0", VA = "0x182A86EE0")]
		public static CSOJLXZIXDU? New(Id32<VFXBTZQLZOD>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class WYLPZQPNGEC : TNFASMSDJPF
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
		public static readonly WYLPZQPNGEC ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly RoundToDecimalPlaceDelegate? EPVNKBGSNQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly TruncateToDecimalPlaceDelegate? GXUHTIFJKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly CircuitsColorLerpDelegate? OHTTZSNZMQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorInverseLerpDelegate? HHLCDPJWDRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsMtx4x4GetPositionDelegate? JHDXBXBVPMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetRotationDelegate? BCRAYDDZRPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4InverseDelegate? DMDYUHGLTHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4MultiplyDelegate? GJBCRUTVLXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? PWQXGYHADWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsQuatDotDelegate? IYTDHUSPULP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatFromAngleAxisDelegate? EBJEVUIIWEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? EKYRUZNKSWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromFromToRotationDelegate? REUMWVSAETP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromLookRotationDelegate? IPKXMJLIVFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? NFINKGASVHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatInverseDelegate? CDQQAWYUKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatLerpDelegate? YUNPJSZBYUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpUnclampedDelegate? REMWCKTPMZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatInverseLerpDelegate? SRUGVFMDSJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatMultiplyDelegate? WHYCQOJGLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatNormalizeDelegate? HQRJRHQBRVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatRotateTowardsDelegate? DYPIURHOQEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateVectorDelegate? WCNZBHUPFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatSlerpDelegate? HRADXBLGWUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatToAngleAxisDelegate? FGXXPSOXONV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToEulerAnglesDelegate? ISCERFKSVZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsVec3AddDelegate? TORSABNFBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? LMXWYSWLOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? DZRNPDLNSWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3CrossDelegate? CJGYMSFVSAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3DotDelegate? TUSEHKWHEMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3AngleDelegate? YMWAHMVQNTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3GetMagnitudeDelegate? MZSZYCXKZPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3LerpDelegate? XWLYZJGOXVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpUnclampedDelegate? NKORSCOLXVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3InverseLerpDelegate? FORCCEJORBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3MoveTowardsDelegate? RLXOFVIMZSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3NegateDelegate? NWTLKGGMLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NormalizeDelegate? EFCOWWVLWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3ProjectDelegate? MEODRIHFKLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? SSDRBTQGKQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ScaleDelegate? UKYDSJEONFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3SmoothDampDelegate? JHWRRFMQKTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SubtractDelegate? DLNXRAKATMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SlerpDelegate? QKMJLSBDGRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3TransformDelegate? PCERLHTJTJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3InverseTransformDelegate? GSYLMCMXMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RealtimeSinceStartupDelegate? RXMCLVKFAED;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A91AF0", Offset = "0x2A900F0", VA = "0x182A91AF0")]
		public WYLPZQPNGEC([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A90220", Offset = "0x2A8E820", VA = "0x182A90220")]
		public float SQWSHJFKEXV([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A90310", Offset = "0x2A8E910", VA = "0x182A90310")]
		public float LOJVBWNPUDT([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A902B0", Offset = "0x2A8E8B0", VA = "0x182A902B0")]
		public CircuitsColor GWMZZBESANU([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FF80", Offset = "0x2A8E580", VA = "0x182A8FF80")]
		public float EWHJPXDWVEQ([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A91420", Offset = "0x2A8FA20", VA = "0x182A91420")]
		public CircuitsVec3 UMNWYJDMUUY([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A916F0", Offset = "0x2A8FCF0", VA = "0x182A916F0")]
		public CircuitsQuat ZAZYZADNNOV([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A903F0", Offset = "0x2A8E9F0", VA = "0x182A903F0")]
		public CircuitsMtx4x4 HHUZIPZSQPR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A90740", Offset = "0x2A8ED40", VA = "0x182A90740")]
		public CircuitsMtx4x4 IUXFLGBBUUZ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2A90460", Offset = "0x2A8EA60", VA = "0x182A90460")]
		public CircuitsMtx4x4 HPRXCPNCGMF([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DF0", Offset = "0x2A8F3F0", VA = "0x182A90DF0")]
		public float XMGDBUSJWFY([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A91040", Offset = "0x2A8F640", VA = "0x182A91040")]
		public CircuitsQuat SZJPMSVEWAP(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F9B0", Offset = "0x2A8DFB0", VA = "0x182A8F9B0")]
		public CircuitsQuat AMYKVXSPHRK([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A90890", Offset = "0x2A8EE90", VA = "0x182A90890")]
		public CircuitsQuat JXVYRWOLITS([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FB70", Offset = "0x2A8E170", VA = "0x182A8FB70")]
		public CircuitsQuat BMYIEQFCVWW([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A909B0", Offset = "0x2A8EFB0", VA = "0x182A909B0")]
		public CircuitsQuat SMLCOKDHZJT([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FAB0", Offset = "0x2A8E0B0", VA = "0x182A8FAB0")]
		public CircuitsQuat LHLPUEPGCJE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A90680", Offset = "0x2A8EC80", VA = "0x182A90680")]
		public CircuitsQuat IJMFXLVYRXT([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DA0", Offset = "0x2A8F3A0", VA = "0x182A90DA0")]
		public float PCFAEEAKHIQ([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A91520", Offset = "0x2A8FB20", VA = "0x182A91520")]
		public CircuitsQuat VLBQMEDRVZJ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A911D0", Offset = "0x2A8F7D0", VA = "0x182A911D0")]
		public CircuitsQuat TFRDZWJZJMW([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A90330", Offset = "0x2A8E930", VA = "0x182A90330")]
		public CircuitsQuat QNFFWWEPYVG([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E80", Offset = "0x2A8F480", VA = "0x182A90E80")]
		public CircuitsVec3 PPAYYVUZTTZ([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FEC0", Offset = "0x2A8E4C0", VA = "0x182A8FEC0")]
		public CircuitsQuat EQKFZIQCMCZ([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A90120", Offset = "0x2A8E720", VA = "0x182A90120")]
		public void NPDEQDUPWBO([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A90F70", Offset = "0x2A8F570", VA = "0x182A90F70")]
		public CircuitsVec3 QAPQJCRCCJJ([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A910F0", Offset = "0x2A8F6F0", VA = "0x182A910F0")]
		public CircuitsVec3 TDGFMOQQURE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A91340", Offset = "0x2A8F940", VA = "0x182A91340")]
		public CircuitsVec3 TXRNFPRTXUY([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2A90940", Offset = "0x2A8EF40", VA = "0x182A90940")]
		public CircuitsVec3 JYNSSSTJQFX([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2A90E10", Offset = "0x2A8F410", VA = "0x182A90E10")]
		public CircuitsVec3 POGGPPPYKOF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A90020", Offset = "0x2A8E620", VA = "0x182A90020")]
		public float FDOPTTUWOJE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A90100", Offset = "0x2A8E700", VA = "0x182A90100")]
		public float LMJOHSLBAAS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A90F50", Offset = "0x2A8F550", VA = "0x182A90F50")]
		public float TQNRPTEWRWV([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A91680", Offset = "0x2A8FC80", VA = "0x182A91680")]
		public CircuitsVec3 YBFJEMPRHAO([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A91160", Offset = "0x2A8F760", VA = "0x182A91160")]
		public CircuitsVec3 TFKOAVCCPLH([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A91480", Offset = "0x2A8FA80", VA = "0x182A91480")]
		public float XTWAFUMZEMQ([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A90610", Offset = "0x2A8EC10", VA = "0x182A90610")]
		public CircuitsVec3 IDKWGLRGGJQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FCC0", Offset = "0x2A8E2C0", VA = "0x182A8FCC0")]
		public CircuitsVec3 CTSXYGJLHRT([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A91270", Offset = "0x2A8F870", VA = "0x182A91270")]
		public CircuitsVec3 TOFKJHFTPRY([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A90CD0", Offset = "0x2A8F2D0", VA = "0x182A90CD0")]
		public CircuitsVec3 OOOAWWHUUHS([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FFB0", Offset = "0x2A8E5B0", VA = "0x182A8FFB0")]
		public CircuitsVec3 EXSBSCRVVUN([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A913B0", Offset = "0x2A8F9B0", VA = "0x182A913B0")]
		public CircuitsVec3 UGBZKAHINHZ([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2A91740", Offset = "0x2A8FD40", VA = "0x182A91740")]
		public CircuitsVec3 ZECKQGDCSNN([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FC20", Offset = "0x2A8E220", VA = "0x182A8FC20")]
		public CircuitsVec3 BPIQVFIZUTJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2A914B0", Offset = "0x2A8FAB0", VA = "0x182A914B0")]
		public CircuitsVec3 VFHQVNIKIVP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2A904D0", Offset = "0x2A8EAD0", VA = "0x182A904D0")]
		public CircuitsVec3 HQLRMRJESFT([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A90B10", Offset = "0x2A8F110", VA = "0x182A90B10")]
		public CircuitsVec3 MIEVTQOKHOL([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FC90", Offset = "0x2A8E290", VA = "0x182A8FC90", Slot = "50")]
		public Task CMNKBYAAOON(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "51")]
		public void QZXCUADONKN([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A900B0", Offset = "0x2A8E6B0", VA = "0x182A900B0", Slot = "52")]
		public FAHXEUAJZBB FNLYLYYSRYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FE00", Offset = "0x2A8E400", VA = "0x182A8FE00", Slot = "53")]
		public FAHXEUAJZBB DIWZFEDDZPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DD0", Offset = "0x2A8F3D0", VA = "0x182A90DD0", Slot = "54")]
		public float PEDIUXVUTYW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A90220", Offset = "0x2A8E820", VA = "0x182A90220", Slot = "4")]
		private float GJSOLGAFHKJ([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A90310", Offset = "0x2A8E910", VA = "0x182A90310", Slot = "5")]
		private float GYSGNIWFYXF([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2A91620", Offset = "0x2A8FC20", VA = "0x182A91620", Slot = "6")]
		private CircuitsColor XEKOZYUIMEQ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FF80", Offset = "0x2A8E580", VA = "0x182A8FF80", Slot = "7")]
		private float TWCVPTDSOAC([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FA50", Offset = "0x2A8E050", VA = "0x182A8FA50", Slot = "8")]
		private CircuitsVec3 AXNUIYFVCEC([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A915D0", Offset = "0x2A8FBD0", VA = "0x182A915D0", Slot = "9")]
		private CircuitsQuat VUYZFMNTPJR([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A905B0", Offset = "0x2A8EBB0", VA = "0x182A905B0", Slot = "10")]
		private CircuitsMtx4x4 IBTUIGUFHJP([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2A901C0", Offset = "0x2A8E7C0", VA = "0x182A901C0", Slot = "11")]
		private CircuitsMtx4x4 GFYAYMZSRHJ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A90160", Offset = "0x2A8E760", VA = "0x182A90160", Slot = "12")]
		private CircuitsMtx4x4 GDFXCIOMXTR([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DF0", Offset = "0x2A8F3F0", VA = "0x182A90DF0", Slot = "13")]
		private float PNPNDVQBSLO([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A91040", Offset = "0x2A8F640", VA = "0x182A91040", Slot = "14")]
		private CircuitsQuat WUAPADIZVVX(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F9B0", Offset = "0x2A8DFB0", VA = "0x182A8F9B0", Slot = "15")]
		private CircuitsQuat XBNFYDOMMCO([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2A90890", Offset = "0x2A8EE90", VA = "0x182A90890", Slot = "16")]
		private CircuitsQuat QIORAKMKYIG([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FB70", Offset = "0x2A8E170", VA = "0x182A8FB70", Slot = "17")]
		private CircuitsQuat EUHSJSRUXAU([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2A909B0", Offset = "0x2A8EFB0", VA = "0x182A909B0", Slot = "18")]
		private CircuitsQuat KHYEDXVCXGP([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FAB0", Offset = "0x2A8E0B0", VA = "0x182A8FAB0", Slot = "19")]
		private CircuitsQuat AZSXCXCIFBW([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2A90680", Offset = "0x2A8EC80", VA = "0x182A90680", Slot = "20")]
		private CircuitsQuat NFFFURFMWGL([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2A90DA0", Offset = "0x2A8F3A0", VA = "0x182A90DA0", Slot = "21")]
		private float PGLQFIOIFSG([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2A91520", Offset = "0x2A8FB20", VA = "0x182A91520", Slot = "22")]
		private CircuitsQuat YQUYFOXVPLH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2A911D0", Offset = "0x2A8F7D0", VA = "0x182A911D0", Slot = "23")]
		private CircuitsQuat YQIXJMZDRSI([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2A90330", Offset = "0x2A8E930", VA = "0x182A90330", Slot = "24")]
		private CircuitsQuat HEHTYHCTKSK([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A90040", Offset = "0x2A8E640", VA = "0x182A90040", Slot = "25")]
		private CircuitsVec3 FIATCVBRHUB([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FEC0", Offset = "0x2A8E4C0", VA = "0x182A8FEC0", Slot = "26")]
		private CircuitsQuat XMREXEUQAMD([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A90120", Offset = "0x2A8E720", VA = "0x182A90120", Slot = "27")]
		private void FRRFKBTABRA([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2A90EF0", Offset = "0x2A8F4F0", VA = "0x182A90EF0", Slot = "28")]
		private CircuitsVec3 PTKNERLYCWJ([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FD20", Offset = "0x2A8E320", VA = "0x182A8FD20", Slot = "29")]
		private CircuitsVec3 CXRXTCHMPTO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FD90", Offset = "0x2A8E390", VA = "0x182A8FD90", Slot = "30")]
		private CircuitsVec3 DHPEACCWCCS([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A90C60", Offset = "0x2A8F260", VA = "0x182A90C60", Slot = "31")]
		private CircuitsVec3 NYVXNBFSJTV([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2A90540", Offset = "0x2A8EB40", VA = "0x182A90540", Slot = "32")]
		private CircuitsVec3 IAKXGMSJHPN([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2A90FD0", Offset = "0x2A8F5D0", VA = "0x182A90FD0", Slot = "33")]
		private CircuitsVec3 QLGQJYCDNHV([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2A90820", Offset = "0x2A8EE20", VA = "0x182A90820", Slot = "34")]
		private CircuitsVec3 JWWBQUMSEBP([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2A90020", Offset = "0x2A8E620", VA = "0x182A90020", Slot = "35")]
		private float LENABETGECY([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2A90100", Offset = "0x2A8E700", VA = "0x182A90100", Slot = "36")]
		private float FQKNXCRCQPW([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A90F50", Offset = "0x2A8F550", VA = "0x182A90F50", Slot = "37")]
		private float QAJFMVMBJGX([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2A91850", Offset = "0x2A8FE50", VA = "0x182A91850", Slot = "38")]
		private CircuitsVec3 ZWSFIHTUDKE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2A918C0", Offset = "0x2A8FEC0", VA = "0x182A918C0", Slot = "39")]
		private CircuitsVec3 ZXMAUYNOITB([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2A91480", Offset = "0x2A8FA80", VA = "0x182A91480", Slot = "40")]
		private float UTCJKWHYBSG([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2A90BF0", Offset = "0x2A8F1F0", VA = "0x182A90BF0", Slot = "41")]
		private CircuitsVec3 NNOVILTLICA([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2A917F0", Offset = "0x2A8FDF0", VA = "0x182A917F0", Slot = "42")]
		private CircuitsVec3 ZSOCQAXFGDR([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2A90D40", Offset = "0x2A8F340", VA = "0x182A90D40", Slot = "43")]
		private CircuitsVec3 OVEGBCUHAVO([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FE50", Offset = "0x2A8E450", VA = "0x182A8FE50", Slot = "44")]
		private CircuitsVec3 DLOJJNMPALE([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A912D0", Offset = "0x2A8F8D0", VA = "0x182A912D0", Slot = "45")]
		private CircuitsVec3 TOXTBTYVFOD([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2A90B80", Offset = "0x2A8F180", VA = "0x182A90B80", Slot = "46")]
		private CircuitsVec3 NMQZSVUEUTH([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2A90A50", Offset = "0x2A8F050", VA = "0x182A90A50", Slot = "47")]
		private CircuitsVec3 KLHOVFQEBMV([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2A90240", Offset = "0x2A8E840", VA = "0x182A90240", Slot = "48")]
		private CircuitsVec3 GOIYEUIPNKV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2A907B0", Offset = "0x2A8EDB0", VA = "0x182A907B0", Slot = "49")]
		private CircuitsVec3 JGGHGKTPYPN([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class RTXJFRELSES : KIDNOZSASOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x138D000", Offset = "0x138B600", VA = "0x18138D000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x20F2690", Offset = "0x20F0C90", VA = "0x1820F2690", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C320", Offset = "0x2A8A920", VA = "0x182A8C320")]
		public RTXJFRELSES(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class WBMBQLXCIJI : YTQIBUMCHZV
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(TKGEPSVKNZO e, TNPIOOLYLAL invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly WBMBQLXCIJI ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly GetCircuitsColorFromColorIndexDelegate? SPAFLCTEYJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? TFPLOQFKDRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly InvisibleCollisionSetEnabledDelegate? TBKRLQZGQKS;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xE38300", Offset = "0xE36900", VA = "0x180E38300")]
		public WBMBQLXCIJI([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F8A0", Offset = "0x2A8DEA0", VA = "0x182A8F8A0", Slot = "4")]
		public CircuitsColor LEVQIWYGENI(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F8F0", Offset = "0x2A8DEF0", VA = "0x182A8F8F0")]
		public int MQAEAXTVQOO([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F8F0", Offset = "0x2A8DEF0", VA = "0x182A8F8F0", Slot = "5")]
		private int RSLLBWTFAPZ([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class DRRZSZRNPPL : SUBGXSZKYFE
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class XGCTYBURUMO
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid JBWLLZYUXGG
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long CYYRSHTRTFV
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int BEXBBISUEZL
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool DJSEERNIZJO
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x1B24590", Offset = "0x1B22B90", VA = "0x181B24590")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool DQJGKTTMLEM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x1B24120", Offset = "0x1B22720", VA = "0x181B24120")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool ANKJZYYIKAJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x2A92620", Offset = "0x2A90C20", VA = "0x182A92620")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A92640", Offset = "0x2A90C40", VA = "0x182A92640")]
			public XGCTYBURUMO(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Dictionary<Id128<BZFRCGZKOVF>, XGCTYBURUMO> KMYFCBLSAVZ;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A88CC0", Offset = "0x2A872C0", VA = "0x182A88CC0")]
		public bool BGHSOVYDNLQ([In] Id128<BZFRCGZKOVF> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2A89060", Offset = "0x2A87660", VA = "0x182A89060")]
		public void MGKRGLIYPBY([In] Id128<BZFRCGZKOVF> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2A88F80", Offset = "0x2A87580", VA = "0x182A88F80")]
		public void MGKRGLIYPBY([In] Id128<BZFRCGZKOVF> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2A88DD0", Offset = "0x2A873D0", VA = "0x182A88DD0")]
		public void MONSOGRZOIX([In] Id128<BZFRCGZKOVF> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2A89130", Offset = "0x2A87730", VA = "0x182A89130")]
		public void ORHTLSPREPC([In] Id128<BZFRCGZKOVF> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2A88EF0", Offset = "0x2A874F0", VA = "0x182A88EF0")]
		public bool DJSEERNIZJO([In] Id128<BZFRCGZKOVF> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2A89190", Offset = "0x2A87790", VA = "0x182A89190")]
		public DRRZSZRNPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A88CC0", Offset = "0x2A872C0", VA = "0x182A88CC0", Slot = "4")]
		private bool IUQMDAYMGOP([In] Id128<BZFRCGZKOVF> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2A89060", Offset = "0x2A87660", VA = "0x182A89060", Slot = "5")]
		private void WHARMHUNKLZ([In] Id128<BZFRCGZKOVF> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2A88DD0", Offset = "0x2A873D0", VA = "0x182A88DD0", Slot = "6")]
		private void BHHBHVAJMKC([In] Id128<BZFRCGZKOVF> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2A89130", Offset = "0x2A87730", VA = "0x182A89130", Slot = "7")]
		private void UEEMUVNUUIF([In] Id128<BZFRCGZKOVF> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2A88EF0", Offset = "0x2A874F0", VA = "0x182A88EF0", Slot = "8")]
		private bool PBFEQMFGURF([In] Id128<BZFRCGZKOVF> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class PHVSEZAJPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BD20", Offset = "0x2A8A320", VA = "0x182A8BD20")]
		public static LogDeps XSGBHEHOTAV()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class HUKOVEYTZWH : MeshLibrary.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
		public byte[]? ZHENCJOXQII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public void VHNPPRDXHNJ(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HUKOVEYTZWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class LWCZQRLDTOM : TNLURBVFQWD
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
		public delegate void ConfigureAttachedObjectDelegate(ECWMIXYRRQB controlPanel, LTLVYHVMHDH staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<NRLXJRHPDTU> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, IQRQYBTPXGA>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, IQRQYBTPXGA>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, IQRQYBTPXGA>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, IQRQYBTPXGA>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Task<Result<MultiResult, IQRQYBTPXGA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter<Result<MultiResult, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2A8E7C0", Offset = "0x2A8CDC0", VA = "0x182A8E7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EA80", Offset = "0x2A8D080", VA = "0x182A8EA80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EAF0", Offset = "0x2A8D0F0", VA = "0x182A8EAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EDB0", Offset = "0x2A8D3B0", VA = "0x182A8EDB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, IQRQYBTPXGA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Task<Result<None, IQRQYBTPXGA>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<Result<None, IQRQYBTPXGA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2A8EE20", Offset = "0x2A8D420", VA = "0x182A8EE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2A8F0E0", Offset = "0x2A8D6E0", VA = "0x182A8F0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<string, EnumChoiceData> VJPYFOJFZIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<int, string> RYTCZSAIVWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly List<object> EGOJKTWOJYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<Guid> MKVUPUKYVCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly CanLocalPlayerCreateCurrencyDelegate WXZGSJNUWWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ShowRoomCurrencyCreationUIDelegate ZQMEJDBFLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly GetAudioClipOptionsDelegate HXJHHVMERQR;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly IReadOnlyDictionary<Guid, int> AJTMVLXYXIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly GetAudioClipGuidToIndexMapDelegate LRUIGXOSITN;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly IReadOnlyDictionary<int, Guid> WXWMSRIUVMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GetAudioClipIndexToGuidMapDelegate NTDGHOUAQMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAllAudioClipOptionsDelegate HHQETPBKTUQ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly IReadOnlyDictionary<Guid, int> NPZYQGJKFUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate WWFCRKIFOKA;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly IReadOnlyDictionary<int, Guid> VRSVAPPRBPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate FGSJJFYDRTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly PlayAudioPreviewDelegate KJDCZZSKCUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly StopAudioPreviewDelegate JHZSBMMVPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly SubscriptionIsActiveDelegate LAXZHJQVBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate AULHSLVCPKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Dictionary<string, EnumChoiceData> BCYAQCOILTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly ShowQuickChatEditMenuDelegate ZZOONRGUVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ConfigureAttachedObjectDelegate GSADQDCPTZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly DisplayInvalidNameErrorMessageDelegate XOZKZEEWNJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly IsStringPureDelegate XAHXTTNPTBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TryGetSpecificChipConfigSummaryDelegate YVNRANXWYDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly ReleaseIconIdDelegate TLHCFIWGLVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReportCreationErrorToUserAsyncDelegate QITGBYZVBSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 TPAZGXPWCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 TPGGEEJTLMT;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment NDVTIDCETLT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GSXXITLBPWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> OOETCPNDSSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> SJIUXXJLWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> LNKWBXAETXL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> DFDOFOXQRWL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A30", Offset = "0xAB3030", VA = "0x180AB4A30", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion GVTICIBHFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xBD1380", Offset = "0xBCF980", VA = "0x180BD1380", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool FDJXZTKKGMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBD12C0", Offset = "0xBCF8C0", VA = "0x180BD12C0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool YVLQJPYNNCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2A89BC0", Offset = "0x2A881C0", VA = "0x182A89BC0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool FDLSTJFKRHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2A89B80", Offset = "0x2A88180", VA = "0x182A89B80", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool XUAJBKVLTRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA8EF0", Offset = "0xAA74F0", VA = "0x180AA8EF0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A4C0", Offset = "0x2A88AC0", VA = "0x182A8A4C0")]
		public LWCZQRLDTOM([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A89A20", Offset = "0x2A88020", VA = "0x182A89A20", Slot = "9")]
		public bool BDGAFKMXVMR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public static bool IVTWLIJMYWY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A89CC0", Offset = "0x2A882C0", VA = "0x182A89CC0", Slot = "10")]
		public bool LLDRERSXXDR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void ODNEWGTNOYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xF6CD90", Offset = "0xF6B390", VA = "0x180F6CD90", Slot = "11")]
		public void GASJONNKMDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B50", Offset = "0x2A88150", VA = "0x182A89B50")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> DFJEZTINJWD(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FC0", Offset = "0x2A885C0", VA = "0x182A89FC0", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SPEGYIGLVVY(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A170", Offset = "0x2A88770", VA = "0x182A8A170")]
		private static IReadOnlyDictionary<Guid, int> WCLTTKSMKJZ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A320", Offset = "0x2A88920", VA = "0x182A8A320", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> YZLNPAYVWNU(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A1C0", Offset = "0x2A887C0", VA = "0x182A8A1C0")]
		private static IReadOnlyDictionary<int, Guid> WGZLWZDXPFB(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C90", Offset = "0x2A88290", VA = "0x182A89C90", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> KJGMMSWHQWG(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FF0", Offset = "0x2A885F0", VA = "0x182A89FF0")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> SQNMPGEBBLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2A79B00", Offset = "0x2A78100", VA = "0x182A79B00", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> JBZDQWMETPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A2D0", Offset = "0x2A888D0", VA = "0x182A8A2D0")]
		private static IReadOnlyDictionary<Guid, int> XTJGXBFHLOU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B20", Offset = "0x2A88120", VA = "0x182A89B20", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> CWUZHITZMVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C60", Offset = "0x2A88260", VA = "0x182A89C60", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> KFDTPJFYXYL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void AWDLEFTHPFX(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A89D20", Offset = "0x2A88320", VA = "0x182A89D20", Slot = "18")]
		public void PZTQJSZYFKY(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void BVYFCWJVVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A89F80", Offset = "0x2A88580", VA = "0x182A89F80", Slot = "19")]
		public void SIJLNETKBRI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private static bool RXBDSQNWSSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2A89CF0", Offset = "0x2A882F0", VA = "0x182A89CF0", Slot = "20")]
		public bool OIJMGYUAUZZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public static bool EOVNGWAFYWX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A020", Offset = "0x2A88620", VA = "0x182A8A020", Slot = "21")]
		public bool ULELYWYSPPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A050", Offset = "0x2A88650", VA = "0x182A8A050", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> VXHTGVYDITR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> JUDEYQLSOSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> EIPHWRGEQDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A2A0", Offset = "0x2A888A0", VA = "0x182A8A2A0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> XBAZOMJNTDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> SBNSZRGPMQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> OPQSWWRLKTO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void JFNTUWAPERM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2A89D60", Offset = "0x2A88360", VA = "0x182A89D60", Slot = "29")]
		public void QZZWCLMHJAZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void WDTCPOQWNWY(ECWMIXYRRQB a, LTLVYHVMHDH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A89BD0", Offset = "0x2A881D0", VA = "0x182A89BD0", Slot = "35")]
		public void HYTGCMEWLLV(ECWMIXYRRQB a, LTLVYHVMHDH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "36")]
		public Dictionary<string, EnumChoiceData> MPOPXQHHQSB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "37")]
		public Dictionary<string, EnumChoiceData> PXTJYOPLTZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void GQNOKCVKUYA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C00", Offset = "0x2A88200", VA = "0x182A89C00")]
		private static Task<bool> IDEXFKIDRCQ(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B90", Offset = "0x2A88190", VA = "0x182A89B90", Slot = "38")]
		public Task<bool> EIUZUKMYFYT(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FB0", Offset = "0x2A885B0", VA = "0x182A89FB0")]
		private static bool SIZVYCNQBCC(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A89AE0", Offset = "0x2A880E0", VA = "0x182A89AE0", Slot = "39")]
		public bool CLAPWOJRGSV(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void THNEEBGAUOK(Id32<NRLXJRHPDTU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A899F0", Offset = "0x2A87FF0", VA = "0x182A899F0", Slot = "40")]
		public void ANOQNFRLRRH(Id32<NRLXJRHPDTU> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A080", Offset = "0x2A88680", VA = "0x182A8A080")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, IQRQYBTPXGA>> VZZRRQNFOGI(Task<Result<None, IQRQYBTPXGA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A240", Offset = "0x2A88840", VA = "0x182A8A240", Slot = "41")]
		public Task<Result<None, IQRQYBTPXGA>> WMIAXAZLRHB(Task<Result<None, IQRQYBTPXGA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A89DA0", Offset = "0x2A883A0", VA = "0x182A89DA0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, IQRQYBTPXGA>> RDSQQRDTUIK(Task<Result<MultiResult, IQRQYBTPXGA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A210", Offset = "0x2A88810", VA = "0x182A8A210", Slot = "42")]
		public Task<Result<MultiResult, IQRQYBTPXGA>> WMIAXAZLRHB(Task<Result<MultiResult, IQRQYBTPXGA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A89E90", Offset = "0x2A88490", VA = "0x182A89E90")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> RDXXNXXRDTT(Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A270", Offset = "0x2A88870", VA = "0x182A8A270", Slot = "43")]
		public Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> WMIAXAZLRHB(Task<Result<Id32<QKZKTYBWUBB>, IQRQYBTPXGA>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class SJGQYUFNORV : ABXTGTDIJOO
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(GYYCSYOYAST e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private InteropDelegate? WBHRJDVZOQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly InteropDelegate NNCOBDTPLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate TOOJQFPPOYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private InteropDelegate? UGYUMHOPUCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InvokeStudioFunctionDelegate? VIQCDWTRIYN;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "5")]
		public LegacyCV2Result<None> ZWZFPANSSER(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		private static LegacyCV2Result<None> Default(GYYCSYOYAST _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "6")]
		public LegacyCV2Result<None> XDKSUTPHTCQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "7")]
		public LegacyCV2Result<None> WGDLYBZFDLP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "8")]
		public LegacyCV2Result<None> YPKFSUBMEKM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "9")]
		public LegacyCV2Result<None> QPWYLHJRKFS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "15")]
		public LegacyCV2Result<None> SDDDJHVEUDX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QDQJSRBQEPF(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZRMDTLKZWGR(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CXKTDAZWWZY(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XPSRJHCGNRZ(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EQHMSJYUVYI(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JRNFQRYNXXY(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HSPOOUESHMZ(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "93")]
		public LegacyCV2Result<None> GXZLMVKNTQA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "94")]
		public LegacyCV2Result<None> KOCLMTTOOPY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "95")]
		public LegacyCV2Result<None> FIHRVXFXJPZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XXNXPPDTDSL(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(GYYCSYOYAST e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XPQNQMRXAZP(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VSWZEHRPCMF(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JDJKJBLGSYO(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BLSPQINWJKD(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NNOCUQGKZYO(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NFJZZNWLPDK(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VCGHZEHJAHK(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YDVCUSBVCYJ(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1239")]
		public LegacyCV2Result<None> MakeChatAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1240")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1241")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1242")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1244")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1243")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1245")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1246")]
		public LegacyCV2Result<None> GetAIFunction(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1569690", Offset = "0x1567C90", VA = "0x181569690", Slot = "1248")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YTAKODOSDPG(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PCKWGQRXHBN(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "119")]
		public LegacyCV2Result<None> BURSEECMVXN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OLUWJNDWSRO(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "121")]
		public LegacyCV2Result<None> BBESCAWKIWI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "122")]
		public LegacyCV2Result<None> AAMUJOHLHRK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "123")]
		public LegacyCV2Result<None> ZRCXYRMAEVS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "124")]
		public LegacyCV2Result<None> XZUAPZGKJEY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "125")]
		public LegacyCV2Result<None> IZEIVVNRZFM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "126")]
		public LegacyCV2Result<None> KTVACZWFBGL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "809")]
		public LegacyCV2Result<None> RLNCVXXBTQF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "810")]
		public LegacyCV2Result<None> FJNYQDWYXIN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "147")]
		public LegacyCV2Result<None> JIVSCUJOLIP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "148")]
		public LegacyCV2Result<None> DWCUNUZBVZR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "149")]
		public LegacyCV2Result<None> NCALZPSAIEG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "150")]
		public LegacyCV2Result<None> HJOVAIREODE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "151")]
		public LegacyCV2Result<None> EKCVUFXJRAL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(GYYCSYOYAST e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "153")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "154")]
		public LegacyCV2Result<None> EquipAvatarItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "155")]
		public LegacyCV2Result<None> UnequipAvatarItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "156")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "157")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "158")]
		public LegacyCV2Result<None> MotionTrailSetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailGetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "164")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "165")]
		public LegacyCV2Result<None> BeaconSetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "166")]
		public LegacyCV2Result<None> BeaconGetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "167")]
		public LegacyCV2Result<None> BeaconSetHeight(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "168")]
		public LegacyCV2Result<None> BeaconGetHeight(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "169")]
		public LegacyCV2Result<None> BeaconSetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "170")]
		public LegacyCV2Result<None> BeaconGetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "171")]
		public LegacyCV2Result<None> PKIMJSMSYPA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "172")]
		public LegacyCV2Result<None> UBJMNQGECTZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "173")]
		public LegacyCV2Result<None> QQMVYUEMEWX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "174")]
		public LegacyCV2Result<None> GetLocalCameraForward(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "175")]
		public LegacyCV2Result<None> GetLocalCameraUp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "176")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "178")]
		public LegacyCV2Result<None> SetCameraShake(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "179")]
		public LegacyCV2Result<None> StopCameraShake(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "180")]
		public LegacyCV2Result<None> SnapCameraImage(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "189")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "190")]
		public LegacyCV2Result<None> CollisionDataGetObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "191")]
		public LegacyCV2Result<None> CollisionDataGetDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetNormal(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "194")]
		public LegacyCV2Result<None> NXUEHUXQRXL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "195")]
		public LegacyCV2Result<None> BNEILJYBBEU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "196")]
		public LegacyCV2Result<None> BWJVCDFEAXR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "197")]
		public LegacyCV2Result<None> DEYWMOELRWH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "198")]
		public LegacyCV2Result<None> DREOIHUYLYF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "199")]
		public LegacyCV2Result<None> CJURJZTKFAY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "200")]
		public LegacyCV2Result<None> XFEQPVONYEG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "201")]
		public LegacyCV2Result<None> OONGDKGPFVU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "202")]
		public LegacyCV2Result<None> QMNQTUHSBYC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "203")]
		public LegacyCV2Result<None> JZLSJGBVGMS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "204")]
		public LegacyCV2Result<None> IENNPMCCCHA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "205")]
		public LegacyCV2Result<None> OYPBTUXNCMC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "206")]
		public LegacyCV2Result<None> QEGPSIEFJVI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "207")]
		public LegacyCV2Result<None> UXWKHMZGIVL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "208")]
		public LegacyCV2Result<None> VSGWPYZHELS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "209")]
		public LegacyCV2Result<None> KZNFSNHFKBH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "210")]
		public LegacyCV2Result<None> NDBYUUVLRTQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "211")]
		public LegacyCV2Result<None> HVGRYLGALUX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "212")]
		public LegacyCV2Result<None> ZCKBMBAETVU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "213")]
		public LegacyCV2Result<None> CombatantGetHealthAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "214")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "215")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "216")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "217")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "218")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "225")]
		public LegacyCV2Result<None> CombatantSetHealthAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "226")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "227")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "231")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "232")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "233")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "239")]
		public LegacyCV2Result<None> CombatantToCombatantAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "240")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "241")]
		public LegacyCV2Result<None> CombatantSplit(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "242")]
		public LegacyCV2Result<None> CostumeEquip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "243")]
		public LegacyCV2Result<None> CostumeUnEquip(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "244")]
		public LegacyCV2Result<None> CostumeGetWearer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "245")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "271")]
		public LegacyCV2Result<None> AAFMYLREVFU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "272")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "273")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "274")]
		public LegacyCV2Result<None> WQDCNIHWNRK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "276")]
		public LegacyCV2Result<None> VJUDFVWEDLX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "277")]
		public LegacyCV2Result<None> OVCBUWWHHVF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "278")]
		public LegacyCV2Result<None> TFPBCZSQSFO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "279")]
		public LegacyCV2Result<None> WKEKETCJVDT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "280")]
		public LegacyCV2Result<None> XJKANSHSTIU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "281")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "282")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "283")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "284")]
		public LegacyCV2Result<None> VTVTXLSUDQN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "285")]
		public LegacyCV2Result<None> SEKNFEAAXWI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "286")]
		public LegacyCV2Result<None> ToCreationObjectAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "287")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "288")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectButton(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectContainer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectRotator(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectPiston(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectSeat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectDice(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectCostume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "314")]
		public LegacyCV2Result<None> VTLXEJSPJWN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "317")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "342")]
		public LegacyCV2Result<None> FromCreationObjectAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "343")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "344")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "345")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "346")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectButton(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectContainer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectDie(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectPiston(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRotator(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectText(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectSeat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectCostume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "399")]
		public LegacyCV2Result<None> ULUPYVBQODO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "400")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JSFKOBRASHZ(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "401")]
		public LegacyCV2Result<None> DiceRollFinished(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "402")]
		public LegacyCV2Result<None> DiceResult(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "403")]
		public LegacyCV2Result<None> DicePlayerRolled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "404")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "405")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LLMCAYMTWIH(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "406")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UFYCNEIFRIV(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JSLQDPYHGYO(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "408")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HWINNCOSMFT(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "409")]
		public LegacyCV2Result<DTJJVKBJAGN.CV2DiscoverySectionType> MFSKMARPSLU(GYYCSYOYAST e, CircuitSignal a)
		{
			return default(LegacyCV2Result<DTJJVKBJAGN.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "410")]
		public LegacyCV2Result<None> BXWWATIXKOW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "411")]
		public LegacyCV2Result<None> EmitterStart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "412")]
		public LegacyCV2Result<None> EmitterStop(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "413")]
		public LegacyCV2Result<None> EmitterSetLooping(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "414")]
		public LegacyCV2Result<None> EmitterSetSize(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "415")]
		public LegacyCV2Result<None> EmitterSetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "416")]
		public LegacyCV2Result<None> EmitterSetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "417")]
		public LegacyCV2Result<None> EmitterSetColorNew(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "418")]
		public LegacyCV2Result<None> EmitterGetLooping(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "419")]
		public LegacyCV2Result<None> EmitterGetSize(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "420")]
		public LegacyCV2Result<None> EmitterGetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "421")]
		public LegacyCV2Result<None> EmitterGetPlaying(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "422")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(GYYCSYOYAST e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "423")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SOOYLLVFYDA(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "424")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GHNTQNWYPPT(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "425")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VAZSRVIXGEK(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "426")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "427")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "428")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "429")]
		public LegacyCV2Result<None> GetFriendlyNameAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "430")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "182")]
		public LegacyCV2Result<None> GetFriendlyNameColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "434")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "431")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "432")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "433")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "435")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameReward(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "453")]
		public LegacyCV2Result<None> LAVZNDZMCSB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "454")]
		public LegacyCV2Result<None> UVXUEPMBTCA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "455")]
		public LegacyCV2Result<None> QASOFOKKNAL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "456")]
		public LegacyCV2Result<None> VQPRWJWMCOS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "457")]
		public LegacyCV2Result<None> VOBXTJKSITS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "458")]
		public LegacyCV2Result<None> YINIFAMGZVO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "459")]
		public LegacyCV2Result<None> PFODCDARYHB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "460")]
		public LegacyCV2Result<None> TBUUJXVOEYV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "465")]
		public LegacyCV2Result<None> EFRQNZBUDEZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "466")]
		public LegacyCV2Result<None> JCYUKGFTNHR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "467")]
		public LegacyCV2Result<None> DLTBQMEAPQU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "468")]
		public LegacyCV2Result<None> CIHJJZZKBZT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "469")]
		public LegacyCV2Result<None> MFODQYVXQTR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "470")]
		public LegacyCV2Result<None> CKWVZIGRNZG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "461")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(GYYCSYOYAST executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "462")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(GYYCSYOYAST executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "463")]
		public LegacyCV2Result<None> GCXBQIBSVOA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "464")]
		public LegacyCV2Result<None> ZPWWVDXZRAA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "471")]
		public LegacyCV2Result<None> FEUGOFSEFPE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "472")]
		public LegacyCV2Result<None> LVSLECWOLCQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "473")]
		public LegacyCV2Result<None> HHKMMMRYBTT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "474")]
		public LegacyCV2Result<None> MNPPAEPYXQP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "475")]
		public LegacyCV2Result<None> EKSLDJQREVR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "476")]
		public LegacyCV2Result<None> NRRFNZXNWLL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "477")]
		public LegacyCV2Result<None> YFKLOZZWNVV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "478")]
		public LegacyCV2Result<None> FBIREMXABWV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "479")]
		public LegacyCV2Result<None> PJQRFYCALPN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "480")]
		public LegacyCV2Result<None> IYBFNUJUSSD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "481")]
		public LegacyCV2Result<None> GTZYVNTVIHT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "482")]
		public LegacyCV2Result<None> GCSRPQSATOX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "483")]
		public LegacyCV2Result<None> MFWVWCKVGIN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "484")]
		public LegacyCV2Result<None> OUOVZJFWBCT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "485")]
		public LegacyCV2Result<None> HIKXXECMGNV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "486")]
		public LegacyCV2Result<None> QTXWCGZQLUF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "487")]
		public LegacyCV2Result<None> CIZPALDDHFX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "488")]
		public LegacyCV2Result<None> RVYYBLGARVT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "489")]
		public LegacyCV2Result<None> PQHKOVSJMHL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "490")]
		public LegacyCV2Result<None> XZPUSYXXDXB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CE60", Offset = "0x2A8B460", VA = "0x182A8CE60", Slot = "491")]
		public LegacyCV2Result<None> SendLogString(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "492")]
		public LegacyCV2Result<None> LerpColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "493")]
		public LegacyCV2Result<None> LerpUnclampedColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "494")]
		public LegacyCV2Result<None> InverseLerpVec3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "495")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "496")]
		public LegacyCV2Result<None> InverseLerpColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "497")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "498")]
		public LegacyCV2Result<None> UXEBMVVXEXJ(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "499")]
		public LegacyCV2Result<None> RGWBXLRIWHT(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "500")]
		public LegacyCV2Result<None> IJDFRAAAFKF(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "501")]
		public LegacyCV2Result<None> EBEPFLGJLMY(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "502")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "503")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "504")]
		public LegacyCV2Result<None> FogConstantValues(GYYCSYOYAST e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "505")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "506")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "507")]
		public LegacyCV2Result<None> SunConstantValues(GYYCSYOYAST e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "508")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "509")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "510")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(GYYCSYOYAST e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.UWUISCKTQZL> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "511")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "512")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "513")]
		public LegacyCV2Result<None> KHEBLNKQDLW(GYYCSYOYAST e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "516")]
		public LegacyCV2Result<None> NBUQXSSPTWM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "517")]
		public LegacyCV2Result<None> TextScreenClearScreen(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "518")]
		public LegacyCV2Result<None> GWIDBGNPNQV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "519")]
		public LegacyCV2Result<None> JJKYAFIYQDF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "520")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "521")]
		public LegacyCV2Result<None> DWMQQMZYBVB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "522")]
		public LegacyCV2Result<None> JQIIMVDHRHU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CDE0", Offset = "0x2A8B3E0", VA = "0x182A8CDE0", Slot = "523")]
		public LegacyCV2Result<None> GetLocalPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "524")]
		public LegacyCV2Result<None> BQGTHMOSBCM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CDA0", Offset = "0x2A8B3A0", VA = "0x182A8CDA0", Slot = "526")]
		public LegacyCV2Result<None> GVGLGMUIDVE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "525")]
		public LegacyCV2Result<None> QKPCPFKZSRF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "527")]
		public LegacyCV2Result<None> JABMHODPGER(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "528")]
		public LegacyCV2Result<None> HUMNYNUKSHA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "529")]
		public LegacyCV2Result<None> KOECIBKSDEY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "530")]
		public LegacyCV2Result<None> SYUKKAQBWQI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "531")]
		public LegacyCV2Result<None> WNQIAEPWVFA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "532")]
		public LegacyCV2Result<None> DistanceAI_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "533")]
		public LegacyCV2Result<None> DistanceAI_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "534")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "535")]
		public LegacyCV2Result<None> DistanceAI_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "536")]
		public LegacyCV2Result<None> DistanceAI_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "537")]
		public LegacyCV2Result<None> DistanceCombatant_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "538")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "539")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "540")]
		public LegacyCV2Result<None> DistanceCombatant_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "541")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "542")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "543")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "544")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "545")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "546")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "547")]
		public LegacyCV2Result<None> DistancePlayer_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "548")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "549")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "550")]
		public LegacyCV2Result<None> DistancePlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "551")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "552")]
		public LegacyCV2Result<None> DistanceVector3_AI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "553")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "554")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "555")]
		public LegacyCV2Result<None> DistanceVector3_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "556")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "557")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "558")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "559")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "560")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "561")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "562")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "563")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "564")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "565")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "566")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "567")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "568")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "569")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "570")]
		public LegacyCV2Result<None> GetPositionAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "571")]
		public LegacyCV2Result<None> GetPositionCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "572")]
		public LegacyCV2Result<None> GetPositionCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "573")]
		public LegacyCV2Result<None> GetPositionPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "574")]
		public LegacyCV2Result<None> Raycast(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "575")]
		public LegacyCV2Result<None> POTLZPMWZAT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "576")]
		public LegacyCV2Result<None> RaycastAll(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "577")]
		public LegacyCV2Result<None> Spherecast(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "578")]
		public LegacyCV2Result<None> PCZRNKLGDYK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "579")]
		public LegacyCV2Result<None> SpherecastAll(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "580")]
		public LegacyCV2Result<None> OverlapSphere(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "581")]
		public LegacyCV2Result<None> OverlapBox(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "582")]
		public LegacyCV2Result<None> YZAFEHIOWEZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "583")]
		public LegacyCV2Result<None> CNJBMYHJLHE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "584")]
		public LegacyCV2Result<None> SetPositionPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "585")]
		public LegacyCV2Result<None> SetPositionCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "586")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "587")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "588")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "589")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "591")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "592")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "593")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "594")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "595")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "596")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "597")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "598")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "599")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "600")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "601")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "602")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "603")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "604")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "605")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "606")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "607")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "608")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "609")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "610")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "611")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "612")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "613")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "614")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "615")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "616")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "617")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "618")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "619")]
		public LegacyCV2Result<None> PistonGetDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "620")]
		public LegacyCV2Result<None> PistonSetDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "621")]
		public LegacyCV2Result<None> PistonGetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "622")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "623")]
		public LegacyCV2Result<None> PistonSetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "624")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "625")]
		public LegacyCV2Result<None> PistonGetAcceleration(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "626")]
		public LegacyCV2Result<None> PistonSetAcceleration(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "627")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "628")]
		public LegacyCV2Result<None> PistonGetMaxDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "629")]
		public LegacyCV2Result<None> PistonSetMaxDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "630")]
		public LegacyCV2Result<None> PistonGetTargetDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "631")]
		public LegacyCV2Result<None> PistonSetTargetDistance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "632")]
		public LegacyCV2Result<None> XHMSYREGPCP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "633")]
		public LegacyCV2Result<None> EKCWKRSJYXN(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "634")]
		public LegacyCV2Result<None> GTKCIUDGOJI(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "635")]
		public LegacyCV2Result<None> NOMRMPIOUAN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "636")]
		public LegacyCV2Result<None> ZUCFLRDXCMZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "637")]
		public LegacyCV2Result<None> DONYSMRGVHU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "638")]
		public LegacyCV2Result<None> PlayerAddRole(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "639")]
		public LegacyCV2Result<None> PlayerRemoveRole(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "640")]
		public LegacyCV2Result<None> DQNDVFNQUNP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "641")]
		public LegacyCV2Result<None> EWFCCLZIWAN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "642")]
		public LegacyCV2Result<None> TNBSBNXFGNA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "643")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "644")]
		public LegacyCV2Result<None> PlayerRightHandPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "645")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "646")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "647")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "648")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "649")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "650")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "652")]
		public LegacyCV2Result<None> JHEDJUGZNEV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "651")]
		public LegacyCV2Result<None> GELACKSJIAY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "653")]
		public LegacyCV2Result<None> VMRTCQHIRPB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "654")]
		public LegacyCV2Result<None> INCPOMFPZHY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "655")]
		public LegacyCV2Result<None> PlayerHeadPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "656")]
		public LegacyCV2Result<None> PlayerHeadOrientation(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "657")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "658")]
		public LegacyCV2Result<None> PlayerHeadUpVector(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "659")]
		public LegacyCV2Result<None> PlayerHeadVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "660")]
		public LegacyCV2Result<None> PlayerHeadHeight(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "661")]
		public LegacyCV2Result<None> GNWGJLVPUHT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "662")]
		public LegacyCV2Result<None> THWFQWUYMUQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "663")]
		public LegacyCV2Result<None> PlayerBodyPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "664")]
		public LegacyCV2Result<None> PlayerBodyOrientation(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "665")]
		public LegacyCV2Result<None> PFEGFSANMJU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "666")]
		public LegacyCV2Result<None> JRRLYWUXQQN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "694")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "699")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(GYYCSYOYAST e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "685")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "686")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "687")]
		public LegacyCV2Result<None> DIDAENTETED(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "688")]
		public LegacyCV2Result<None> ZGWVMJVFVOB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "689")]
		public LegacyCV2Result<None> DQORVWCQNBB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "690")]
		public LegacyCV2Result<None> VVZODJWWIYA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "691")]
		public LegacyCV2Result<None> GOWWGRDMLWO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "692")]
		public LegacyCV2Result<None> PlayerGetCostume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "693")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "667")]
		public LegacyCV2Result<None> LFACIUJREYZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "668")]
		public LegacyCV2Result<None> WCBTCHHNBSD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "669")]
		public LegacyCV2Result<None> NBMJTQYEPTY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "670")]
		public LegacyCV2Result<None> PIMEFUYWDKD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "671")]
		public LegacyCV2Result<None> VQNFCFYWPII(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "672")]
		public LegacyCV2Result<None> JJMHYPLBVEJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "673")]
		public LegacyCV2Result<None> SRUVXIDSGGP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "674")]
		public LegacyCV2Result<None> CKGRPTGPODY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "675")]
		public LegacyCV2Result<None> XWUDDJKTJDC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "676")]
		public LegacyCV2Result<None> THJQVXQKDTJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "677")]
		public LegacyCV2Result<None> DROTASPCPWL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "678")]
		public LegacyCV2Result<None> EZFEAAVVTDE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "679")]
		public LegacyCV2Result<None> COWHLYQTQUR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "680")]
		public LegacyCV2Result<None> ISHNXFOHQTL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "681")]
		public LegacyCV2Result<None> LHXJOZFRKHM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "682")]
		public LegacyCV2Result<None> ZXDPJQIQFSI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "683")]
		public LegacyCV2Result<None> MRMIOXUVXTU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "684")]
		public LegacyCV2Result<None> AYIVSUOJCLT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "695")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "696")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "756")]
		public LegacyCV2Result<None> VKGAFTFXVYP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "757")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "758")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "700")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "702")]
		public LegacyCV2Result<None> WAKTTJLCJAM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "703")]
		public LegacyCV2Result<None> RWTRRXLHHBW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "704")]
		public LegacyCV2Result<None> HEJCLOMQCFQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "705")]
		public LegacyCV2Result<None> DGGEGAQFLFG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "707")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "708")]
		public LegacyCV2Result<None> QDGWWWRRHLY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "709")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "710")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "711")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "712")]
		public LegacyCV2Result<None> GJNXONDLLVR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "713")]
		public LegacyCV2Result<None> BLVABVWZTQZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "714")]
		public LegacyCV2Result<None> SXQZHRHQISM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "715")]
		public LegacyCV2Result<None> MZSEUDJIGPG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "716")]
		public LegacyCV2Result<None> RUCHATMRTKA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "717")]
		public LegacyCV2Result<None> ZGSZOQVKGAT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "718")]
		public LegacyCV2Result<None> KOBZVMXHFCO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "719")]
		public LegacyCV2Result<None> KOKVRDJZEVL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "720")]
		public LegacyCV2Result<None> LNCJLWDTOWP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "721")]
		public LegacyCV2Result<None> LTKMNVBXPNT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "722")]
		public LegacyCV2Result<None> WBIGECYMEUJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "723")]
		public LegacyCV2Result<None> DZKVFYKOXRV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "724")]
		public LegacyCV2Result<None> FURPBLHVZQD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "725")]
		public LegacyCV2Result<None> EXQUVTWZUUC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "726")]
		public LegacyCV2Result<None> PUXRBCENYPF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "727")]
		public LegacyCV2Result<None> EEJCMJXHPDT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "728")]
		public LegacyCV2Result<None> PTNXZRSGIIM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "729")]
		public LegacyCV2Result<None> KPZYJFPUECD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "731")]
		public LegacyCV2Result<None> ADKLROMGLMV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "730")]
		public LegacyCV2Result<None> OBBBJOYXFYR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "732")]
		public LegacyCV2Result<None> UNNUKUWAOFK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "733")]
		public LegacyCV2Result<None> HBFYQPABUFR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "734")]
		public LegacyCV2Result<None> HOGIKMZUXCE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "735")]
		public LegacyCV2Result<None> FKJTTUZBIJE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "736")]
		public LegacyCV2Result<None> PCWWMHBUTTH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "737")]
		public LegacyCV2Result<None> FWCTTOAYSWY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "738")]
		public LegacyCV2Result<None> MIFUSDPKFEY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "739")]
		public LegacyCV2Result<None> JNCLXMYVPIT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "740")]
		public LegacyCV2Result<None> HTICNTDIXKN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "741")]
		public LegacyCV2Result<None> YSEYOFOONJT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "742")]
		public LegacyCV2Result<None> JRQYIURPHDB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "743")]
		public LegacyCV2Result<None> RSXELVXQQHB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "744")]
		public LegacyCV2Result<None> VDGYOSCMUOL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "745")]
		public LegacyCV2Result<None> QMQSTFATWZR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "746")]
		public LegacyCV2Result<None> PBXNAGXNMBU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "747")]
		public LegacyCV2Result<None> ESVQBZDKUQI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "748")]
		public LegacyCV2Result<None> WLHDJULOWIA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "749")]
		public LegacyCV2Result<None> KFYSBGGAKSQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "750")]
		public LegacyCV2Result<None> WWZPHZLJHEH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "751")]
		public LegacyCV2Result<None> RLNSKAOBSRL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "752")]
		public LegacyCV2Result<None> QYASLYSOUTZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "753")]
		public LegacyCV2Result<None> OKFCSRYQCWI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "754")]
		public LegacyCV2Result<None> YMAEPTRDRIW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "755")]
		public LegacyCV2Result<None> GNNIBRTAEOT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "759")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "760")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "761")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "762")]
		public LegacyCV2Result<None> IYQWHAMIJQR(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "763")]
		public LegacyCV2Result<None> NFQOJEQNWUL(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "764")]
		public LegacyCV2Result<None> CGFMTGHAWLO(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "765")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(GYYCSYOYAST ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "766")]
		public LegacyCV2Result<None> FFSFYBAREBE(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "767")]
		public LegacyCV2Result<None> KWSZAWHKCZY(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "768")]
		public LegacyCV2Result<None> CAYOHFERDGV(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "769")]
		public LegacyCV2Result<None> IYCXKAMBPST(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "770")]
		public LegacyCV2Result<None> KIVLJELQEPR(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "697")]
		public LegacyCV2Result<None> PlayerGetProfileImage(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "698")]
		public LegacyCV2Result<None> PRIJNNSPYYJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "771")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "772")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "773")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "774")]
		public LegacyCV2Result<None> ShowPlayerProfile(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "775")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "776")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "777")]
		public LegacyCV2Result<None> RequestPostGameRewards(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "778")]
		public LegacyCV2Result<None> SetPlayerWorldUI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "779")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "780")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "781")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "782")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "783")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "784")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "785")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "786")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "788")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "791")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "792")]
		public LegacyCV2Result<None> BTWCPJSMPRN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "793")]
		public LegacyCV2Result<None> QZYHBDWCLBB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "794")]
		public LegacyCV2Result<None> GDWMQNMUTUF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "795")]
		public LegacyCV2Result<None> DZZOGUOPCKV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "796")]
		public LegacyCV2Result<None> AVKBGFCPDHB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "797")]
		public LegacyCV2Result<None> HOFFQAPEVKX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "798")]
		public LegacyCV2Result<None> ZIIWNGYNZCR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "799")]
		public LegacyCV2Result<None> OAINNKWHYLL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "800")]
		public LegacyCV2Result<None> LSJOHLGQRUP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "801")]
		public LegacyCV2Result<None> RCLFDNERFYR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "802")]
		public LegacyCV2Result<None> NNAXSZHSFBT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "803")]
		public LegacyCV2Result<None> URCWOXYKOKS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "804")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "805")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "806")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "807")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "808")]
		public LegacyCV2Result<None> GWGQYILJHXP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "811")]
		public LegacyCV2Result<None> GetProjectile(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "812")]
		public LegacyCV2Result<None> GWZOAHADUPI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "813")]
		public LegacyCV2Result<None> UISHHZRHVCC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "814")]
		public LegacyCV2Result<None> AUEYWZCXFXG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "815")]
		public LegacyCV2Result<None> WETGZHMQROU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "816")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "817")]
		public LegacyCV2Result<None> OTVWJTWKANC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "818")]
		public LegacyCV2Result<None> WLVZXJMTCJN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "819")]
		public LegacyCV2Result<None> BNPHIZODLVX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "820")]
		public LegacyCV2Result<None> ResetRoom(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "821")]
		public LegacyCV2Result<None> ResetObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "822")]
		public LegacyCV2Result<None> UMPPTQEEWCH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "823")]
		public LegacyCV2Result<None> XHIILDBKRWA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "824")]
		public LegacyCV2Result<None> IZGIAZVZQVR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "825")]
		public LegacyCV2Result<None> ConstantReward(GYYCSYOYAST e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "826")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "827")]
		public LegacyCV2Result<None> HRCDKTREFIO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "828")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HXETFZEHWIM(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "829")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ETSESLGIJKC(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "830")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SXDDSINVTGF(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "831")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XWEMWRXHKDE(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "832")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SIUNENTOSIL(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "833")]
		public LegacyCV2Result<None> ActivateConsumable(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "834")]
		public LegacyCV2Result<None> DeactivateConsumable(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "835")]
		public LegacyCV2Result<None> ConstantConsumable(GYYCSYOYAST e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "836")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "837")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "840")]
		public LegacyCV2Result<None> ConstantRoomKey(GYYCSYOYAST e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "842")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "843")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "844")]
		public LegacyCV2Result<None> ConstantInventoryItem(GYYCSYOYAST e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "846")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "847")]
		public LegacyCV2Result<None> GYQUOCYWFPM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "849")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "850")]
		public LegacyCV2Result<None> SZAZPQJSHVE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "851")]
		public LegacyCV2Result<None> SURKEQNRILS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "852")]
		public LegacyCV2Result<None> MNHCAGQHPDS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "853")]
		public LegacyCV2Result<None> KFEUODWRJYZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "854")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "855")]
		public LegacyCV2Result<None> JBKNYKMXTYW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "856")]
		public LegacyCV2Result<None> OVAAFVYKOPW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "857")]
		public LegacyCV2Result<None> ConstantRoomOffer(GYYCSYOYAST e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "858")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "859")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "860")]
		public LegacyCV2Result<None> AHCAUCYVPYQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "861")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "862")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "863")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "864")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "865")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "866")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "867")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "868")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "869")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "870")]
		public LegacyCV2Result<None> YOOLRMZODFY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "871")]
		public LegacyCV2Result<None> ZUZDNNSQAEI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "872")]
		public LegacyCV2Result<None> XKTINDJZQER(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "873")]
		public LegacyCV2Result<None> TFOHYEPVJEY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "874")]
		public LegacyCV2Result<None> ConstantRoomCurrency(GYYCSYOYAST e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "875")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(GYYCSYOYAST e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "876")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "877")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(GYYCSYOYAST e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "878")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(GYYCSYOYAST e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "879")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "880")]
		public LegacyCV2Result<None> MCTMDKIOJAQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "881")]
		public LegacyCV2Result<None> TTJDQDITWCL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "882")]
		public LegacyCV2Result<None> XOTSWSEZDUG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "883")]
		public LegacyCV2Result<None> FYTQMGLIIFU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "884")]
		public LegacyCV2Result<None> GALAOAMOCKU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "888")]
		public LegacyCV2Result<None> INHWLRKNQMJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "889")]
		public LegacyCV2Result<None> KZFPXWEQWFT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "890")]
		public LegacyCV2Result<None> NXTNIDZJDGU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "892")]
		public LegacyCV2Result<None> AEZOWSFUDME(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "891")]
		public LegacyCV2Result<None> KERMIWATUCI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "893")]
		public LegacyCV2Result<None> QGKSJALRSOF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "895")]
		public LegacyCV2Result<None> XMADUTUWAZL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "894")]
		public LegacyCV2Result<None> IWLUBMNRJJR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "896")]
		public LegacyCV2Result<None> CVHVXRTTAWU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "897")]
		public LegacyCV2Result<None> GVUVJDVFPMQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "898")]
		public LegacyCV2Result<None> STWIAMMHBER(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "899")]
		public LegacyCV2Result<None> GPUKYRNGCZN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "900")]
		public LegacyCV2Result<None> CZWJOZQYTIT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "901")]
		public LegacyCV2Result<None> PFDEMUYLKFZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "902")]
		public LegacyCV2Result<None> RZMZHLZOBLV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "903")]
		public LegacyCV2Result<None> AllowDressUp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "904")]
		public LegacyCV2Result<None> ForbidDressUp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "905")]
		public LegacyCV2Result<None> OpenStore(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "906")]
		public LegacyCV2Result<None> OpenCheckout(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "907")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "908")]
		public LegacyCV2Result<None> GetTrialItemQuantity(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "909")]
		public LegacyCV2Result<None> KROABQQXWTL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "910")]
		public LegacyCV2Result<None> MGOGKIQHCHT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "911")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "912")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "913")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "914")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "915")]
		public LegacyCV2Result<None> StorefrontGetOffersList(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "916")]
		public LegacyCV2Result<None> StorefrontSetOffersList(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "917")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "918")]
		public LegacyCV2Result<None> GetStoreItemDetails(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "919")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "920")]
		public LegacyCV2Result<None> MannequinSetStoreItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "921")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "922")]
		public LegacyCV2Result<None> RaiseStudioEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "923")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "924")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "925")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "926")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "927")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "928")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "929")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "930")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(GYYCSYOYAST e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "931")]
		public LegacyCV2Result<None> AOIJIQCDDBN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "932")]
		public LegacyCV2Result<None> ZMUKNXGPPAH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "933")]
		public LegacyCV2Result<None> ZXYHAJACCPC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "934")]
		public LegacyCV2Result<None> WBUMFWKZQNA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "935")]
		public LegacyCV2Result<None> NYNBMRUORXD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "936")]
		public LegacyCV2Result<None> BELWBVOCKPR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "937")]
		public LegacyCV2Result<None> ICWPXJMFDRQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "938")]
		public LegacyCV2Result<None> CGUHVDXEFHY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "939")]
		public LegacyCV2Result<None> SMONJLFUJBY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "940")]
		public LegacyCV2Result<None> UYMFXKIIBIJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "941")]
		public LegacyCV2Result<None> GetFromSyncIdAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "942")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "943")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "944")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "945")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "946")]
		public LegacyCV2Result<None> GetSyncIdAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "947")]
		public LegacyCV2Result<None> GetSyncIdCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "948")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "949")]
		public LegacyCV2Result<None> GetSyncIdPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "950")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "958")]
		public LegacyCV2Result<None> WRQTEEMQISJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "957")]
		public LegacyCV2Result<None> QNRJQZHINUG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "959")]
		public LegacyCV2Result<None> HPMFOYSWGNG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "960")]
		public LegacyCV2Result<None> WDBVPFHXGLL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "961")]
		public LegacyCV2Result<None> LTDVZFAITDU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "962")]
		public LegacyCV2Result<None> NZYHJFUJOUI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "963")]
		public LegacyCV2Result<None> OTIVMJSFMAB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "951")]
		public LegacyCV2Result<None> TextToolGetText(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "952")]
		public LegacyCV2Result<None> TextToolSetText(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "953")]
		public LegacyCV2Result<None> TextToolSetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "954")]
		public LegacyCV2Result<None> TextToolSetColorNew(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "955")]
		public LegacyCV2Result<None> TextToolSetMaterial(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "956")]
		public LegacyCV2Result<None> TextToolGetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "964")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "965")]
		public LegacyCV2Result<None> PHOGBCUQWNE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "971")]
		public LegacyCV2Result<None> GetParticleVfx(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "972")]
		public LegacyCV2Result<None> NJHEWDVNGWJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "973")]
		public LegacyCV2Result<None> STTIZTPFIHJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "974")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "975")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "976")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "977")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "978")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "979")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "980")]
		public LegacyCV2Result<None> GoToRoom(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "981")]
		public LegacyCV2Result<None> ZZKTVPYDHCO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "966")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "967")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "968")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "969")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "970")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "982")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "983")]
		public LegacyCV2Result<None> ZINTWOAEOSC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "984")]
		public LegacyCV2Result<None> RRMJFIVIVYS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "985")]
		public LegacyCV2Result<None> OQDVLXNNXIE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "986")]
		public LegacyCV2Result<None> VRJDPAVPXYM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "987")]
		public LegacyCV2Result<None> IUOQTQAHWWC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "988")]
		public LegacyCV2Result<None> UDPLYUPHHFM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "989")]
		public LegacyCV2Result<None> SKRLLXFYSEU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "990")]
		public LegacyCV2Result<None> FQNTYIZTEWE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "991")]
		public LegacyCV2Result<None> TGGEZAXQTVS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "992")]
		public LegacyCV2Result<None> YNJGYILCQPW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "996")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "997")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "993")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "994")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "995")]
		public LegacyCV2Result<None> PlayerGetXp(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "998")]
		public LegacyCV2Result<None> PerlinNoise(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "999")]
		public LegacyCV2Result<None> TZUSHIWBTUS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1000")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1001")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1002")]
		public LegacyCV2Result<None> SeatSetLockOut(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1003")]
		public LegacyCV2Result<None> SeatSetLockIn(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1004")]
		public LegacyCV2Result<None> SeatUnseatPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1005")]
		public LegacyCV2Result<None> SeatGetLockIn(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1006")]
		public LegacyCV2Result<None> SeatGetLockOut(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1007")]
		public LegacyCV2Result<None> XMTCNWXQYVT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1008")]
		public LegacyCV2Result<None> RFWVCZTYDGQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1009")]
		public LegacyCV2Result<None> MTTRCFCTNAN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1010")]
		public LegacyCV2Result<None> BKREGPBMXUA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1011")]
		public LegacyCV2Result<None> JVHZPMHUWCB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1012")]
		public LegacyCV2Result<None> KYBISXZBQGC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1013")]
		public LegacyCV2Result<None> VCLDVSVAYLR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1014")]
		public LegacyCV2Result<None> FORQXAVHCVR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1015")]
		public LegacyCV2Result<None> FFMBMDSDQXQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1016")]
		public LegacyCV2Result<None> KWBMWUATLVT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1017")]
		public LegacyCV2Result<None> XLTUAEGGBQN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1018")]
		public LegacyCV2Result<None> BHWMKSHCRJI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1019")]
		public LegacyCV2Result<None> JIBRLOIGUBU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1020")]
		public LegacyCV2Result<None> FDJLFIIJGHH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1021")]
		public LegacyCV2Result<None> XKBKNOJVJCC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1022")]
		public LegacyCV2Result<None> BFDGMURCZGJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1023")]
		public LegacyCV2Result<None> GNSCZQWPCRH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1024")]
		public LegacyCV2Result<None> NavMeshSamplePosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1025")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1037")]
		public LegacyCV2Result<None> WOSPOMQZCTF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1038")]
		public LegacyCV2Result<None> FNPIYNNGRVB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1039")]
		public LegacyCV2Result<None> OKRSZBRBBVV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1040")]
		public LegacyCV2Result<None> WMHPAJZJDQT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1041")]
		public LegacyCV2Result<None> GMULISJVDHC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1042")]
		public LegacyCV2Result<None> EDPLPATLRRK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1043")]
		public LegacyCV2Result<None> VJZBWIHDTYD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1044")]
		public LegacyCV2Result<None> NEUTBGGWRAC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1045")]
		public LegacyCV2Result<None> MKQJHZFQKCF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1046")]
		public LegacyCV2Result<None> FGGIGLPPIXA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1047")]
		public LegacyCV2Result<None> BAVVEKFQRVU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1048")]
		public LegacyCV2Result<None> VDSWULZISXV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1049")]
		public LegacyCV2Result<None> WWIBXENBMWW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1050")]
		public LegacyCV2Result<None> MWEXJLADBHS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1051")]
		public LegacyCV2Result<None> HODXUOCHCZW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1052")]
		public LegacyCV2Result<None> WHNOGJQXQAQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1053")]
		public LegacyCV2Result<None> MQMGNHFYVPS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1054")]
		public LegacyCV2Result<None> MAIMUFRQRJP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1055")]
		public LegacyCV2Result<None> EPOIAVAKXIV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1056")]
		public LegacyCV2Result<None> FWNMRRPMPWW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1057")]
		public LegacyCV2Result<None> MHSREWYQSRA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1058")]
		public LegacyCV2Result<None> GWJJOUHMJLC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1059")]
		public LegacyCV2Result<None> KWARPTSPOOE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1060")]
		public LegacyCV2Result<None> PCANPDPQRBX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1061")]
		public LegacyCV2Result<None> EKORBQUNDTH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1062")]
		public LegacyCV2Result<None> IsValidAI(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1063")]
		public LegacyCV2Result<None> IsValidCombatant(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CE20", Offset = "0x2A8B420", VA = "0x182A8CE20", Slot = "1064")]
		public LegacyCV2Result<None> IsValidPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1065")]
		public LegacyCV2Result<None> IsValidReward(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1066")]
		public LegacyCV2Result<None> IsValidAudio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1067")]
		public LegacyCV2Result<None> IsValidRecNetMesh(GYYCSYOYAST e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1068")]
		public LegacyCV2Result<None> ValidIfNotNull(GYYCSYOYAST e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1069")]
		public LegacyCV2Result<None> GetVelocityCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1070")]
		public LegacyCV2Result<None> GetVelocityPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1071")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1072")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1073")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1074")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1075")]
		public LegacyCV2Result<None> GetUpVectorPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1076")]
		public LegacyCV2Result<None> GetOrientationCreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1077")]
		public LegacyCV2Result<None> GetOrientationPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1078")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1079")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1080")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1081")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1082")]
		public LegacyCV2Result<None> GTQNERBKROQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1083")]
		public LegacyCV2Result<None> YFBEMGIFHAT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1084")]
		public LegacyCV2Result<None> WBZKORCJFWT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1085")]
		public LegacyCV2Result<None> MEZJBOWFRXZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1086")]
		public LegacyCV2Result<None> HXOCWXOPAAP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1087")]
		public LegacyCV2Result<None> IVNARREEXUZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1088")]
		public LegacyCV2Result<None> BFIQKZFWHUF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1089")]
		public LegacyCV2Result<None> IPXGGNJVPND(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1090")]
		public LegacyCV2Result<None> LBLXNPSYGGB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1091")]
		public LegacyCV2Result<None> CXEXYVYSTJL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1092")]
		public LegacyCV2Result<None> AMUDWEDNZDT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1093")]
		public LegacyCV2Result<None> MJKOKCDCGJI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1094")]
		public LegacyCV2Result<None> UXKGBCVQMXQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1095")]
		public LegacyCV2Result<None> GNTOMEHSUIS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1096")]
		public LegacyCV2Result<None> SNHMMMZJSDI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1097")]
		public LegacyCV2Result<None> EIFTICDOUQF(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1098")]
		public LegacyCV2Result<None> AXUAWFNATIN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1099")]
		public LegacyCV2Result<None> KYHPRDZVIRS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1100")]
		public LegacyCV2Result<None> IUPPQXSZLFS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1101")]
		public LegacyCV2Result<None> OXGAXSKJDGA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1102")]
		public LegacyCV2Result<None> UNOVZZMKJIA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1103")]
		public LegacyCV2Result<None> EAADBJOOKDH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1104")]
		public LegacyCV2Result<None> FPSVGSQSUYJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1105")]
		public LegacyCV2Result<None> CICEKARMXRS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1106")]
		public LegacyCV2Result<None> TPGRCDELPEA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1107")]
		public LegacyCV2Result<None> QYQQTDGJCII(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1108")]
		public LegacyCV2Result<None> JHOANHAMOXO(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1109")]
		public LegacyCV2Result<None> WUZREKROPXL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1110")]
		public LegacyCV2Result<None> SBUSCFRKICW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1111")]
		public LegacyCV2Result<None> PJBBFINXABM(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1112")]
		public LegacyCV2Result<None> RRCJWGLQPGK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1113")]
		public LegacyCV2Result<None> RAHGPDEJVJP(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1114")]
		public LegacyCV2Result<None> AAHKPHDFBDP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1115")]
		public LegacyCV2Result<None> MUBMZNNUHTP(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1116")]
		public LegacyCV2Result<None> CPVUCLPICHP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1117")]
		public LegacyCV2Result<None> STYLSJYTMPT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1118")]
		public LegacyCV2Result<None> IFJMDRKYRAR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1119")]
		public LegacyCV2Result<None> YLGJRIGHXKP(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1120")]
		public LegacyCV2Result<None> XKHJIDYYMFO(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1121")]
		public LegacyCV2Result<None> LHBTRUBTGSZ(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1122")]
		public LegacyCV2Result<None> JTJGJNPOZXK(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1123")]
		public LegacyCV2Result<None> ZGXFCDSAJVT(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1124")]
		public LegacyCV2Result<None> NTSPTTOARMZ(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1125")]
		public LegacyCV2Result<None> CSWMWCWVSJE(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1126")]
		public LegacyCV2Result<None> OUTZWPURIYG(TKGEPSVKNZO e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1127")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1128")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1129")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1130")]
		public LegacyCV2Result<None> PCKFCYDSXDQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1131")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1132")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1133")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1134")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1135")]
		public LegacyCV2Result<None> HolotarProjectorPlay(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1136")]
		public LegacyCV2Result<None> HolotarProjectorResume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1137")]
		public LegacyCV2Result<None> HolotarProjectorPause(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1138")]
		public LegacyCV2Result<None> HolotarProjectorStop(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1139")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1140")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1141")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1142")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1143")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1144")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1145")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1146")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1147")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1148")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1149")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1150")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1151")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1152")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1153")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1154")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1155")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1156")]
		public LegacyCV2Result<None> KYBCFZRUYTK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1157")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1158")]
		public LegacyCV2Result<None> GVPNONOLRCW(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1159")]
		public LegacyCV2Result<None> PBTEYUUANZT(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1160")]
		public LegacyCV2Result<None> CHMFJZXSVKQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1161")]
		public LegacyCV2Result<None> CZJTQHMMQAZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1166")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleGetCanReload(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1168")]
		public LegacyCV2Result<None> GunHandleSetCanReload(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1169")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1170")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1171")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1172")]
		public LegacyCV2Result<None> FELYRPTHTCJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1173")]
		public LegacyCV2Result<None> HXZJQDWFQRZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1174")]
		public LegacyCV2Result<None> WDLXELCWVDB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1175")]
		public LegacyCV2Result<None> GQIBZIOOHYR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1176")]
		public LegacyCV2Result<None> CQVJQVOYKBQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1177")]
		public LegacyCV2Result<None> SVVXOLTZDFE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1178")]
		public LegacyCV2Result<None> BKARWXYKBDS(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1179")]
		public LegacyCV2Result<None> LYPBZHPOJLC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1180")]
		public LegacyCV2Result<None> DUSWFIPARMD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1181")]
		public LegacyCV2Result<None> AQCUUWHTDRN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1182")]
		public LegacyCV2Result<None> LAVIZSSKZMA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1183")]
		public LegacyCV2Result<None> IIEPSTIQXYJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "181")]
		public LegacyCV2Result<None> DXVEALPITAZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "183")]
		public LegacyCV2Result<None> GetIntFromRROColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "184")]
		public LegacyCV2Result<None> GetColorFromRGB(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "185")]
		public LegacyCV2Result<None> GetColorFromHSV(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "186")]
		public LegacyCV2Result<None> GetRGBFromColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "187")]
		public LegacyCV2Result<None> GetHSVFromColor(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CEA0", Offset = "0x2A8B4A0", VA = "0x182A8CEA0", Slot = "188")]
		public bool VGOVLAKFDBB(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1184")]
		public LegacyCV2Result<None> YACGVIZKLGJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1185")]
		public LegacyCV2Result<None> DQHIQOMKRKI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1186")]
		public LegacyCV2Result<None> MEICZMTNCEP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(GYYCSYOYAST e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1198")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1187")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1188")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1189")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1190")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1191")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1192")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1193")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1194")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1195")]
		public LegacyCV2Result<None> WQQDMOYZLQQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1196")]
		public LegacyCV2Result<None> NMSKGGQWPUU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "246")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(GYYCSYOYAST e, InOut io, JRGTEGCTGRS objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "247")]
		public LegacyCV2Result<None> BEJUGGBOHQV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "248")]
		public LegacyCV2Result<None> JFAPIMRXSIX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "249")]
		public LegacyCV2Result<None> CBNOQFTAHWL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "250")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "251")]
		public LegacyCV2Result<None> AVEBGIDGISE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "252")]
		public LegacyCV2Result<None> HFDVOHGIEIU(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "253")]
		public LegacyCV2Result<None> BXBLIPMHWTC(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "254")]
		public LegacyCV2Result<None> NIUMTJWANKL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "255")]
		public LegacyCV2Result<None> KPKMHVSCRAD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "256")]
		public LegacyCV2Result<None> AGDFKVEHPDK(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "257")]
		public LegacyCV2Result<None> HCJLNCEMUQY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "258")]
		public LegacyCV2Result<None> UKOCELYCTIG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "259")]
		public LegacyCV2Result<None> PRIFTKBDNTM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "260")]
		public LegacyCV2Result<None> FESJLCGGJGJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "261")]
		public LegacyCV2Result<None> WJCQHYJJJTD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "262")]
		public LegacyCV2Result<None> QFUWNJFHHKH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "263")]
		public LegacyCV2Result<None> WSFVPAJOCSP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "264")]
		public LegacyCV2Result<None> XIYKUMCLZBR(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "265")]
		public LegacyCV2Result<None> NWHHWLJXXVD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "266")]
		public LegacyCV2Result<None> SBFQXPABELH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "267")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "268")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "269")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		private static LegacyCV2Result<None> Default(GYYCSYOYAST e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CD10", Offset = "0x2A8B310", VA = "0x182A8CD10", Slot = "1199")]
		public LegacyCV2Result<None> CHWRNTLSIYS(GYYCSYOYAST a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1202")]
		public LegacyCV2Result<None> OMVRMTGZQBH(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1203")]
		public LegacyCV2Result<None> EROAKPPIQYP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1204")]
		public LegacyCV2Result<None> NEPIZSHPRGP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1205")]
		public LegacyCV2Result<None> CQXLKYWCFNG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1200")]
		public LegacyCV2Result<None> ConstantQuickChatTable(GYYCSYOYAST e, InOut io, UOGSNRWBLTS quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1201")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1026")]
		public LegacyCV2Result<None> KFFHOMMXNSV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1027")]
		public LegacyCV2Result<None> TDWTZNPKCGN(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1028")]
		public LegacyCV2Result<None> YVVVOANXXJZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1029")]
		public LegacyCV2Result<None> ZJKIGXRPOFJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1030")]
		public LegacyCV2Result<None> IIAXLKFLHIJ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1031")]
		public LegacyCV2Result<None> KYEYYAULIRP(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1032")]
		public LegacyCV2Result<None> VVDUFRJPSMR(GYYCSYOYAST a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1033")]
		public LegacyCV2Result<None> JFNUSVMNPGD(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1034")]
		public LegacyCV2Result<None> ELZKBVWTQPB(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1035")]
		public LegacyCV2Result<None> ILVYFAMQVBQ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1036")]
		public LegacyCV2Result<None> ESEKGJVSAFI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1209")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1210")]
		public LegacyCV2Result<None> HandleSetControlLabel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1211")]
		public LegacyCV2Result<None> HandleGetControlLabel(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1212")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1213")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1214")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1215")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1216")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QQRRPETBITE(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1223")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1224")]
		public LegacyCV2Result<None> HRMMDZDPBFX(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1225")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1226")]
		public LegacyCV2Result<None> XQRGLFCOUQE(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1227")]
		public LegacyCV2Result<None> ElementSnapToElement(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1228")]
		public LegacyCV2Result<None> ElementUnsnap(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1229")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1230")]
		public LegacyCV2Result<None> SnapPointUnsnap(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1217")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1218")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1219")]
		public LegacyCV2Result<None> RXWRDYSBIRI(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1220")]
		public LegacyCV2Result<None> GetTexture(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1221")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1222")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1231")]
		public LegacyCV2Result<None> JKKWBOITZBY(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1232")]
		public LegacyCV2Result<None> JXZIZIBIQCZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1233")]
		public LegacyCV2Result<None> LQXTMZSNLDL(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1234")]
		public LegacyCV2Result<None> PBFNYXRTVZV(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1235")]
		public LegacyCV2Result<None> VKVKWVHJNMM(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1236")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SBMUFVEWZSG(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1237")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> MKGXJMHMEXM(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1238")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QOJFVILHEAA(GYYCSYOYAST a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CEB0", Offset = "0x2A8B4B0", VA = "0x182A8CEB0")]
		public SJGQYUFNORV([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1249")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1256")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1257")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1258")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1259")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1260")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1261")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1262")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1265")]
		public LegacyCV2Result<None> ConstantBodyPart(GYYCSYOYAST e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1266")]
		public LegacyCV2Result<None> OPDNTQIJKSZ(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1267")]
		public LegacyCV2Result<None> RVKNUUMOFCA(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1268")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "590")]
		public LegacyCV2Result<None> PWZWVKFQSEG(GYYCSYOYAST e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1269")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1270")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1271")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1272")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1273")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1274")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1275")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1276")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1277")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1278")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1279")]
		public LegacyCV2Result<None> JTKLIEAXZAJ(TKGEPSVKNZO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1280")]
		public LegacyCV2Result<None> VPFUITUFXNW(TKGEPSVKNZO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1281")]
		public LegacyCV2Result<None> PULWLGOMPXH(TKGEPSVKNZO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1282")]
		public LegacyCV2Result<None> HVHEEZTFTAX(TKGEPSVKNZO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1283")]
		public LegacyCV2Result<None> RHPPVDUDZUS(TKGEPSVKNZO e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		public LegacyCV2Result<None> ConstantStorefrontItem(GYYCSYOYAST e, InOut io, [In] ENJYKGLCDRX storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1207")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(GYYCSYOYAST e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1197")]
		private LegacyCV2Result<None> YERTFJKLNRV(GYYCSYOYAST a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1206")]
		private LegacyCV2Result<None> NLFUQVYYUYY(GYYCSYOYAST a, InOut b, [In] ENJYKGLCDRX storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "1247")]
		private LegacyCV2Result<None> UIKHYNHWMNK(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class WJVDSKAMEMS : NXPBYZDUWHR
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(WTXDNBTDAYA node);

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static readonly WJVDSKAMEMS KJBYLZEBJTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate UUNERPUETOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate FVNYLTSVCVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool XAJBYGTVGOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool NSEFUXHVUDH;

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70", Slot = "4")]
		public Task<bool> ZYUCCARPYSE(WTXDNBTDAYA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B140", Offset = "0x2A99740", VA = "0x182A9B140", Slot = "5")]
		public Task<bool> BZWCXSNOVPB(WTXDNBTDAYA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B210", Offset = "0x2A99810", VA = "0x182A9B210")]
		public WJVDSKAMEMS([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B170", Offset = "0x2A99770", VA = "0x182A9B170", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? FJWXNTAVHVC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xAB0F20", Offset = "0xAAF520", VA = "0x180AB0F20", Slot = "7")]
		public bool XPKBNVJLCNX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x16395D0", Offset = "0x1637BD0", VA = "0x1816395D0", Slot = "8")]
		public bool KVCLETWNJUB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class WEMKBGJVNWK : HOBQRQNQPWN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid YFMLMOBQSBK
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public void Bind(OANZGJNQRBH pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x11625E0", Offset = "0x1160BE0", VA = "0x1811625E0")]
		public WEMKBGJVNWK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B0E0", Offset = "0x2A996E0", VA = "0x182A9B0E0")]
		public static WEMKBGJVNWK New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class LIKBMPBQAZW : ASSELTRXPVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<KJWLGRGGWLZ> nodeDefId, Id128<YRJDGOUPWNL>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YRJDGOUPWNL>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private IsNodeRestrictedDelegate? MULIOBSIKUT;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool FDJXZTKKGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EJKNLNHDXWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x2A956F0", Offset = "0x2A93CF0", VA = "0x182A956F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool PVFAJXEHXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x20F2690", Offset = "0x20F0C90", VA = "0x1820F2690", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "6")]
		public bool OHFBBAIETUZ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "7")]
		public CanSaveObjectIntoInventionResultType WJLRLCAMTIG(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2A95700", Offset = "0x2A93D00", VA = "0x182A95700", Slot = "8")]
		public bool OAVCXJPZZZX(Id128<KJWLGRGGWLZ> nodeDefId, Id128<YRJDGOUPWNL>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YRJDGOUPWNL>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
		public bool FKJJMTYPKHI(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
		public bool HVIMZRXJYGU(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2A95750", Offset = "0x2A93D50", VA = "0x182A95750")]
		public LIKBMPBQAZW(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class AXZRWJJPAQW : GBKBVARMRDZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly AXZRWJJPAQW KJBYLZEBJTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ShouldLogEventSenderToMakerPenDelegate LQBCOSTWOQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate VHFXUGTUNLG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HTQMECRKNHU
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130AFA0", VA = "0x18130C9A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool QEUIQPRBGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x2A94270", Offset = "0x2A92870", VA = "0x182A94270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2A94310", Offset = "0x2A92910", VA = "0x182A94310")]
		public AXZRWJJPAQW([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class VVYDNJGIQEE : FAHXEUAJZBB
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class HTSDRRRGWXV : AHOFSAAQNGI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly HTSDRRRGWXV ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool WFQPOOLMCWV
			{
				[Cpp2IlInjected.Token(Token = "0x600074D")]
				[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x2A94AA0", Offset = "0x2A930A0", VA = "0x182A94AA0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			public void NPEEMGAJFGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HTSDRRRGWXV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly VVYDNJGIQEE ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private VVYDNJGIQEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B020", Offset = "0x2A99620", VA = "0x182A9B020", Slot = "4")]
		public AHOFSAAQNGI RKOJMYXYBOB()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class HNVVLXUNLMK<a, b> : IDisposable, BPLYXASFEBT where a : notnull where b : notnull, LTKMZEPLWZW.UWPCASDNCUG<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private readonly b KUPOYFERZJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly a IKGSZDANXIB;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<CYNSIGMASWI> YWMWMQAZOSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CYNSIGMASWI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x511A5D0", Offset = "0x5118BD0", VA = "0x18511A5D0")]
		public HNVVLXUNLMK(b a, a b, Id32<CYNSIGMASWI> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x5120BA0", Offset = "0x511F1A0", VA = "0x185120BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x5120800", Offset = "0x511EE00", VA = "0x185120800")]
		public Id32<VFXBTZQLZOD> DGGUSDOWYQK([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<VFXBTZQLZOD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x5122120", Offset = "0x5120720", VA = "0x185122120", Slot = "6")]
		public void XUYZJIAWPUV(Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x51220E0", Offset = "0x51206E0", VA = "0x1851220E0", Slot = "7")]
		public void WLKFXURVFSL(Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x51212C0", Offset = "0x511F8C0", VA = "0x1851212C0", Slot = "8")]
		public void LQHBXWKSBOQ(Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x5121C60", Offset = "0x5120260", VA = "0x185121C60", Slot = "10")]
		public void SLAQZMJJDLJ(Id32<VFXBTZQLZOD> objectId, Id32<CYNSIGMASWI> clientId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x51219F0", Offset = "0x511FFF0", VA = "0x1851219F0", Slot = "9")]
		public void MRXVYOAXJJT(Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x5121280", Offset = "0x511F880", VA = "0x185121280", Slot = "11")]
		public void JRUXEVRDPHH(Id32<VFXBTZQLZOD> objectId, NTHATILQXOY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x5120860", Offset = "0x511EE60", VA = "0x185120860", Slot = "12")]
		public Id32<CYNSIGMASWI> DTPRYTGELEO(Id32<VFXBTZQLZOD> objectId)
		{
			return default(Id32<CYNSIGMASWI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x51202F0", Offset = "0x511E8F0", VA = "0x1851202F0", Slot = "13")]
		public Id32<FDFCSQHAOQZ> CVWPAUHIXGG(Id32<VFXBTZQLZOD> objectId, string a, object b, bool c, QLZWKPYXAEL d, HAJHCLIAJAB e)
		{
			return default(Id32<FDFCSQHAOQZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x51219B0", Offset = "0x511FFB0", VA = "0x1851219B0", Slot = "14")]
		public void MDKRCKWDWSK(Id32<FDFCSQHAOQZ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x5120DE0", Offset = "0x511F3E0", VA = "0x185120DE0", Slot = "15")]
		public void JBWIYMPGMQY(Id32<FDFCSQHAOQZ> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class LTKMZEPLWZW
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface UWPCASDNCUG<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void AIKZCIVXELI(a a, Id32<CYNSIGMASWI> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<CYNSIGMASWI>? MATCDNRTJRL(a a);

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<VFXBTZQLZOD> DGGUSDOWYQK(a a, Id32<CYNSIGMASWI> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void XUYZJIAWPUV(a a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b);

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void WLKFXURVFSL(a a, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b);

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SLAQZMJJDLJ(a a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b);

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void MRXVYOAXJJT(a a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b);

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void JRUXEVRDPHH(a a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, NTHATILQXOY? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<CYNSIGMASWI>? DTPRYTGELEO(a a, Id32<VFXBTZQLZOD> objectId);

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<FDFCSQHAOQZ> CVWPAUHIXGG(a a, Id32<CYNSIGMASWI> clientId, string b, object c, QLZWKPYXAEL d, HAJHCLIAJAB e);

			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void MDKRCKWDWSK(a a, Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void JBWIYMPGMQY(a a, Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class VERJPHELVFI
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly HashSet<Id32<VFXBTZQLZOD>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public SOAId32Field<FDFCSQHAOQZ, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly Dictionary<Id32<FDFCSQHAOQZ>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<FDFCSQHAOQZ>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public SOAField<VFXBTZQLZOD, NTHATILQXOY?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x2A961A0", Offset = "0x2A947A0", VA = "0x182A961A0")]
			private MockCV2DynamicNetSys(HashSet<Id32<VFXBTZQLZOD>> authorityOf, [In] SOAId32Field<FDFCSQHAOQZ, MockCV2SyncField> syncFields, Dictionary<Id32<FDFCSQHAOQZ>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<FDFCSQHAOQZ>> mockSyncFieldToSyncField, [In] SOAField<VFXBTZQLZOD, NTHATILQXOY?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x2A95FE0", Offset = "0x2A945E0", VA = "0x182A95FE0")]
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
			public Id32<CYNSIGMASWI>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x2A96240", Offset = "0x2A94840", VA = "0x182A96240")]
			public MockCV2ObjectShared(Id32<CYNSIGMASWI> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public HAJHCLIAJAB SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public QLZWKPYXAEL SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			internal MockCV2SyncField(HAJHCLIAJAB syncField, QLZWKPYXAEL syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x2A96360", Offset = "0x2A94960", VA = "0x182A96360")]
			public static MockCV2SyncField New(HAJHCLIAJAB syncField, QLZWKPYXAEL syncFieldChangeHandler)
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

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x2A96310", Offset = "0x2A94910", VA = "0x182A96310")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x2A962C0", Offset = "0x2A948C0", VA = "0x182A962C0")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private SOAId32Field<VFXBTZQLZOD, MockCV2ObjectShared> WGVGVUUVDNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<VFXBTZQLZOD>> DWRSKZOQUHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> OROGWWDPMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> HVLCDFGCUAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private SOAField<CYNSIGMASWI, MockCV2DynamicNetSys> OXBYNUEDTIT;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<VFXBTZQLZOD>? MBRZYWFEZOX
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xBD1370", Offset = "0xBCF970", VA = "0x180BD1370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x12DFB70", Offset = "0x12DE170", VA = "0x1812DFB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D00", Offset = "0x2A98300", VA = "0x182A99D00")]
		public void Destroy([In] SOAId32<CYNSIGMASWI> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A2B0", Offset = "0x2A988B0", VA = "0x182A9A2B0")]
		public void JRQWQOQGAJE(Id32<CYNSIGMASWI> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2A99300", Offset = "0x2A97900", VA = "0x182A99300")]
		public void AIKZCIVXELI(Id32<CYNSIGMASWI> clientId, Id32<CYNSIGMASWI>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2A998A0", Offset = "0x2A97EA0", VA = "0x182A998A0")]
		public Id32<VFXBTZQLZOD> DGGUSDOWYQK(Id32<CYNSIGMASWI> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<CYNSIGMASWI> clientIds)
		{
			return default(Id32<VFXBTZQLZOD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2A99640", Offset = "0x2A97C40", VA = "0x182A99640")]
		public Id32<FDFCSQHAOQZ> CVWPAUHIXGG(Id32<CYNSIGMASWI> clientId, string a, object b, QLZWKPYXAEL c, HAJHCLIAJAB d)
		{
			return default(Id32<FDFCSQHAOQZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A7E0", Offset = "0x2A98DE0", VA = "0x182A9A7E0")]
		public void MDKRCKWDWSK(Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AD30", Offset = "0x2A99330", VA = "0x182A9AD30")]
		public Id32<VFXBTZQLZOD>? XIRVXGXTGQP([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AE00", Offset = "0x2A99400", VA = "0x182A9AE00")]
		public void XUYZJIAWPUV([In] SOAId32<CYNSIGMASWI> clientIds, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ABF0", Offset = "0x2A991F0", VA = "0x182A9ABF0")]
		public void WLKFXURVFSL(Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AAF0", Offset = "0x2A990F0", VA = "0x182A9AAF0")]
		public void SLAQZMJJDLJ(Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A970", Offset = "0x2A98F70", VA = "0x182A9A970")]
		public void MRXVYOAXJJT([In] SOAId32<CYNSIGMASWI> clientIds, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A710", Offset = "0x2A98D10", VA = "0x182A9A710")]
		public void JRUXEVRDPHH(Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, NTHATILQXOY? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2A99CB0", Offset = "0x2A982B0", VA = "0x182A99CB0")]
		public Id32<CYNSIGMASWI>? DTPRYTGELEO(Id32<VFXBTZQLZOD> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2A99F40", Offset = "0x2A98540", VA = "0x182A99F40")]
		public void JBWIYMPGMQY([In] SOAId32<CYNSIGMASWI> clientIds, Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AE80", Offset = "0x2A99480", VA = "0x182A9AE80")]
		public VERJPHELVFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class KETCODYXHFT
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x2A95120", Offset = "0x2A93720", VA = "0x182A95120")]
		public static void Destroy(this VERJPHELVFI.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ZDLLEXHDPFL : ELJFDCEXYNX.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static ZDLLEXHDPFL PVNSSGESEOW;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate FOGWQSEVEMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate IJRIVCGOAPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public ZDLLEXHDPFL(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class ASKJDRVYIOB : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : ZHESUVALAPM.IDSLKDTIAJN<LOHJEAGYXDY, ASKJDRVYIOB>
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
				public AsyncTaskMethodBuilder<Result<object, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public ASKJDRVYIOB root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public Id32<CYNSIGMASWI> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public LOHJEAGYXDY action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private TaskAwaiter<Result<object, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x2A983D0", Offset = "0x2A969D0", VA = "0x182A983D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000798")]
				[Cpp2IlInjected.Address(RVA = "0x2A98610", Offset = "0x2A96C10", VA = "0x182A98610", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
			public int EZRVIQTMGMP(ASKJDRVYIOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x2A96500", Offset = "0x2A94B00", VA = "0x182A96500", Slot = "5")]
			public int AOTCMPGPJCJ(ASKJDRVYIOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x2A966C0", Offset = "0x2A94CC0", VA = "0x182A966C0", Slot = "6")]
			public int UFYLWAPWHZU(ASKJDRVYIOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0xFD9850", Offset = "0xFD7E50", VA = "0x180FD9850", Slot = "7")]
			public int WOMENCSEJCK(ASKJDRVYIOB a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x2A96670", Offset = "0x2A94C70", VA = "0x182A96670", Slot = "8")]
			public void KEQXOPDDHIN(ASKJDRVYIOB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
			public bool ODMBGFVNIPY(ASKJDRVYIOB a, Id32<CYNSIGMASWI> actorId, LOHJEAGYXDY[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			public bool YHXDRLICZKA(ASKJDRVYIOB a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2A96520", Offset = "0x2A94B20", VA = "0x182A96520", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, IQRQYBTPXGA>> BSXHMYMHCVC(ASKJDRVYIOB a, Id32<CYNSIGMASWI> senderId, LOHJEAGYXDY b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : ZHESUVALAPM.UWEOGEPSJXO<ActionDeps, GCFTXZUHCVV.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps QYBEHTLOOOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public GCFTXZUHCVV.StaticNetSysReceiverDeps KSZGRJVSPTF
			{
				[Cpp2IlInjected.Token(Token = "0x600079A")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "5")]
				get
				{
					return default(GCFTXZUHCVV.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps TYEEAFXGCBU
			{
				[Cpp2IlInjected.Token(Token = "0x600079B")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : PKRUIJMNVMY.UWPCASDNCUG<ASKJDRVYIOB>
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
				public AsyncTaskMethodBuilder<Result<object?, IQRQYBTPXGA>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public ASKJDRVYIOB root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public Id32<CYNSIGMASWI> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public LOHJEAGYXDY action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private TaskAwaiter<Result<object?, IQRQYBTPXGA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x2A980B0", Offset = "0x2A966B0", VA = "0x182A980B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x2A98360", Offset = "0x2A96960", VA = "0x182A98360", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x2A963A0", Offset = "0x2A949A0", VA = "0x182A963A0", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, IQRQYBTPXGA>> BSXHMYMHCVC(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, LOHJEAGYXDY b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : LTKMZEPLWZW.UWPCASDNCUG<ASKJDRVYIOB>
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x2A95980", Offset = "0x2A93F80", VA = "0x182A95980", Slot = "4")]
			public void AIKZCIVXELI(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xFD9730", Offset = "0xFD7D30", VA = "0x180FD9730", Slot = "5")]
			public Id32<CYNSIGMASWI>? MATCDNRTJRL(ASKJDRVYIOB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x2A95A10", Offset = "0x2A94010", VA = "0x182A95A10")]
			public Id32<VFXBTZQLZOD> DGGUSDOWYQK(ASKJDRVYIOB a, Id32<CYNSIGMASWI> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<VFXBTZQLZOD>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x2A95F50", Offset = "0x2A94550", VA = "0x182A95F50", Slot = "7")]
			public void XUYZJIAWPUV(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A95DF0", Offset = "0x2A943F0", VA = "0x182A95DF0", Slot = "8")]
			public void WLKFXURVFSL(ASKJDRVYIOB a, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x2A95DB0", Offset = "0x2A943B0", VA = "0x182A95DB0", Slot = "9")]
			public void SLAQZMJJDLJ(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x2A95D80", Offset = "0x2A94380", VA = "0x182A95D80", Slot = "10")]
			public void MRXVYOAXJJT(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, VAKNOBNOFZU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x2A95B00", Offset = "0x2A94100", VA = "0x182A95B00", Slot = "11")]
			public void JRUXEVRDPHH(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<VFXBTZQLZOD> objectId, NTHATILQXOY? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x2A95A70", Offset = "0x2A94070", VA = "0x182A95A70", Slot = "12")]
			public Id32<CYNSIGMASWI>? DTPRYTGELEO(ASKJDRVYIOB a, Id32<VFXBTZQLZOD> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x2A959B0", Offset = "0x2A93FB0", VA = "0x182A959B0", Slot = "13")]
			public Id32<FDFCSQHAOQZ> CVWPAUHIXGG(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, string b, object c, QLZWKPYXAEL d, HAJHCLIAJAB e)
			{
				return default(Id32<FDFCSQHAOQZ>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x2A95BE0", Offset = "0x2A941E0", VA = "0x182A95BE0", Slot = "14")]
			public void MDKRCKWDWSK(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x2A95AD0", Offset = "0x2A940D0", VA = "0x182A95AD0", Slot = "15")]
			public void JBWIYMPGMQY(ASKJDRVYIOB a, Id32<CYNSIGMASWI> clientId, Id32<FDFCSQHAOQZ> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x2A95A10", Offset = "0x2A94010", VA = "0x182A95A10", Slot = "6")]
			private Id32<VFXBTZQLZOD> HVTHHSKCUEC(ASKJDRVYIOB a, Id32<CYNSIGMASWI> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<VFXBTZQLZOD>);
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
			public ASKJDRVYIOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Id32<VFXBTZQLZOD>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public SVUOYNNHAFU deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EB8")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private Id32<CYNSIGMASWI> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private HDNLXSMDIFI<ASKJDRVYIOB, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EC8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private HNVVLXUNLMK<ASKJDRVYIOB, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private GCFTXZUHCVV <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x2A979F0", Offset = "0x2A95FF0", VA = "0x182A979F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x2A98040", Offset = "0x2A96640", VA = "0x182A98040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly TSRNEHRKJSK<LOHJEAGYXDY, None, GCFTXZUHCVV, ActionDeps, GCFTXZUHCVV.StaticNetSysReceiverDeps, RootDeps, ASKJDRVYIOB, Deps> LFINVJRVYCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly VERJPHELVFI AJTDCVJIPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private SOAId32<CYNSIGMASWI> SPZGEKPIXQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAField<CYNSIGMASWI, None> OXBYNUEDTIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<CYNSIGMASWI, GCFTXZUHCVV> GYZNDRBGKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Id32<CYNSIGMASWI>? JDWMXGEKYGI;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate EIVZBUUMLWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2A93F10", Offset = "0x2A92510", VA = "0x182A93F10")]
		public ASKJDRVYIOB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x2A93AE0", Offset = "0x2A920E0", VA = "0x182A93AE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x2A93D90", Offset = "0x2A92390", VA = "0x182A93D90")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> JRQWQOQGAJE(SVUOYNNHAFU a, RegistryV2 b, Id32<VFXBTZQLZOD>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2A93850", Offset = "0x2A91E50", VA = "0x182A93850")]
		private void AIKZCIVXELI(Id32<CYNSIGMASWI> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2A93CB0", Offset = "0x2A922B0", VA = "0x182A93CB0")]
		[CompilerGenerated]
		private Id32<VFXBTZQLZOD>? JJSFZWAZBOK([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class LECCVNVGALW : NSYQZFEHSAE.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<IJTKDTMSILD> DeserializeCircuitsJunctionAsyncDelegate(GCFTXZUHCVV circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<IJTKDTMSILD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public LECCVNVGALW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GCFTXZUHCVV circuitsManager;

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
			private TaskAwaiter<IJTKDTMSILD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2A966E0", Offset = "0x2A94CE0", VA = "0x182A966E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x2A968E0", Offset = "0x2A94EE0", VA = "0x182A968E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate SZLUHGVWLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly LifecycleDidInitializeDelegate? QAALKVECBHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleWillDestroyDelegate? XGRMJNMXSJC;

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A95180", Offset = "0x2A93780", VA = "0x182A95180", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<IJTKDTMSILD> OBRSYXGIIPW(GCFTXZUHCVV a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x10645C0", Offset = "0x1062BC0", VA = "0x1810645C0", Slot = "5")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x10F93C0", Offset = "0x10F79C0", VA = "0x1810F93C0", Slot = "6")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A952F0", Offset = "0x2A938F0", VA = "0x182A952F0")]
		public LECCVNVGALW([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class AIIDEDFSHZU : IXJRKHRRWZM.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate XXXVQBZACHC GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<SYHYWDYRXRO> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<UFGPJUQJOWM> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<IXJRKHRRWZM.ETPODEKPKCV.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<IXJRKHRRWZM.ETPODEKPKCV.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<IXJRKHRRWZM.ETPODEKPKCV.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0x2A96950", Offset = "0x2A94F50", VA = "0x182A96950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A96B40", Offset = "0x2A95140", VA = "0x182A96B40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<UFGPJUQJOWM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter<UFGPJUQJOWM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0x2A96BB0", Offset = "0x2A951B0", VA = "0x182A96BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x2A96DA0", Offset = "0x2A953A0", VA = "0x182A96DA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<SYHYWDYRXRO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<SYHYWDYRXRO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x2A96E10", Offset = "0x2A95410", VA = "0x182A96E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x2A97000", Offset = "0x2A95600", VA = "0x182A97000", Slot = "5")]
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
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A97070", Offset = "0x2A95670", VA = "0x182A97070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x2A97260", Offset = "0x2A95860", VA = "0x182A97260", Slot = "5")]
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
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x2A972D0", Offset = "0x2A958D0", VA = "0x182A972D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x2A974C0", Offset = "0x2A95AC0", VA = "0x182A974C0", Slot = "5")]
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
			public AIIDEDFSHZU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x2A97530", Offset = "0x2A95B30", VA = "0x182A97530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x2A97720", Offset = "0x2A95D20", VA = "0x182A97720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly GetCV2DependenciesDelegate PJBFCKIRILY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetRoomDataAsyncDelegate JFKGTKJFWAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetSuperRoomDataAsyncDelegate BSNHWMGQBQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetRoomAssetDataAsyncDelegate IEKJYJZHNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetPlayerSaveDataAsyncDelegate RTBSQFTHWDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate SLAVEIPPALX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetStaticCircuitsConfigAsyncDelegate PBORDTOIJQK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public XXXVQBZACHC XXXVQBZACHC
		{
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130AFA0", VA = "0x18130C9A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x2A92B20", Offset = "0x2A91120", VA = "0x182A92B20", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> CSXYRKXOFFD(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x2A92D40", Offset = "0x2A91340", VA = "0x182A92D40", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> PUCCWNLORKU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A92A10", Offset = "0x2A91010", VA = "0x182A92A10", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<SYHYWDYRXRO> CISKTSGDCML(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A92E50", Offset = "0x2A91450", VA = "0x182A92E50", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<UFGPJUQJOWM> QHFVGUDMWPK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A92C30", Offset = "0x2A91230", VA = "0x182A92C30", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<IXJRKHRRWZM.ETPODEKPKCV.CircuitGraphToolMapping> DQXWRCJPDYB(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A92F60", Offset = "0x2A91560", VA = "0x182A92F60", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> UBBNAHQMADC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x2A93070", Offset = "0x2A91670", VA = "0x182A93070")]
		public AIIDEDFSHZU(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class ZWWYYXTKTEW : CV2Request.ETPODEKPKCV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly CV2Request.ETPODEKPKCV ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly GetCanSendRequestsDelegate TQVMCEIZIPI;

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public ZWWYYXTKTEW(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130AFA0", VA = "0x18130C9A0", Slot = "4")]
		public bool CEIHVOBWXFU()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class LIKXPLHAFTP : GNHUSEXYYOY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, OYBEQJHIRPM> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly TryReportErrToUserDelegate KOFPTTLBXIC;

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70")]
		public bool XNWJJMCAOHG([In] Result<None, OYBEQJHIRPM> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A957D0", Offset = "0x2A93DD0", VA = "0x182A957D0")]
		public LIKXPLHAFTP([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70", Slot = "4")]
		private bool BWXQWIRXGFR([In] Result<None, OYBEQJHIRPM> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class UCFFSHNZLSI : XKMIIYNPIFP
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate GYYCSYOYAST CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly UCFFSHNZLSI ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly CurrentExecParamsDelegate? SQTQLFSPPPA;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public GYYCSYOYAST DPIKKLHIITU
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130AFA0", VA = "0x18130C9A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public UCFFSHNZLSI([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class JGURKIWBHBA : WBTIGOWHAUR
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly WBTIGOWHAUR ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private readonly GetGameColorFromIdDelegate IAHBVKHVPJE;

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70", Slot = "4")]
		public CircuitsColor HOEENHCUGQE(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2A94F80", Offset = "0x2A93580", VA = "0x182A94F80")]
		public JGURKIWBHBA([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class AHBCBTKGJRI : AATAVYXKSWN
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
			public AHBCBTKGJRI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public string context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x2A97790", Offset = "0x2A95D90", VA = "0x182A97790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0x2A97980", Offset = "0x2A95F80", VA = "0x182A97980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly IsStringPureAsyncDelegate WZKXBGHNGPP;

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x2A92720", Offset = "0x2A90D20", VA = "0x182A92720", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> HNZTTXKWHBT(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x2A92860", Offset = "0x2A90E60", VA = "0x182A92860")]
		public AHBCBTKGJRI([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class LEJCYMLWDEY : OYLYGLUJTWX
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate GYSERZIXQTR? GetNodeVisualizationConfigDelegate([In] Id128<KJWLGRGGWLZ> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly OYLYGLUJTWX ZQTZABWNUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly GetNodeVisualizationConfigDelegate ADMYZDNVRMQ;

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70")]
		public GYSERZIXQTR? BQTQWTERKBY([In] Id128<KJWLGRGGWLZ> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2A95540", Offset = "0x2A93B40", VA = "0x182A95540")]
		public LEJCYMLWDEY([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2A94D70", Offset = "0x2A93370", VA = "0x182A94D70", Slot = "4")]
		private GYSERZIXQTR XFCQNKBIFJQ([In] Id128<KJWLGRGGWLZ> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class YOOLNPCADSL : UPEVSDLKQCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B410", Offset = "0x2A99A10", VA = "0x182A9B410", Slot = "4")]
		public VWLNCMIYRQD PSJFMYROFAD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public YOOLNPCADSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class FBJLWJQGJLH : AMTRPXQSZYW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly Dictionary<string, bool> HQLOLBNXFOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, float> DIDYQBMPTNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, double> XNXACBXHSGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, int> WROJTYTRKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, long> ARSNVMQNWEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, string> VEECVVMHZGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, uint> AGGRPEDQQTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, ulong> ZZWYHOYBLJF;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x2A946E0", Offset = "0x2A92CE0", VA = "0x182A946E0", Slot = "4")]
		public bool? CAVFEERDXZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2A94780", Offset = "0x2A92D80", VA = "0x182A94780")]
		public FBJLWJQGJLH()
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
