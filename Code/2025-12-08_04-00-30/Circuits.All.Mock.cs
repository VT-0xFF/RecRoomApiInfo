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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2843FD0", Offset = "0x28427D0", VA = "0x182843FD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		internal sealed class DBIQHMWLASN : YRIRYJIPQVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public DBIQHMWLASN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0", Slot = "4")]
			public YRIRYJIPQVK KMMQDNBCODQ(string a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0", Slot = "5")]
			public YRIRYJIPQVK IHYFSRXQPHT(string a, string[] b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0", Slot = "6")]
			public YRIRYJIPQVK EZOLNKIYKKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
			public void KYZXWOEKWKU()
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
	public static class LVWPPOBRCPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public FWQHNCKMARH UORYHEQNMFY;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x283CFF0", Offset = "0x283B7F0", VA = "0x18283CFF0")]
			internal ICVLDVBXLIZ KJPGSXGPFPH(GetNetworkObjectDelegate a)
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
			public IWKODKJRCUD dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public QKFNWZERSCU network;

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
			[Cpp2IlInjected.Address(RVA = "0x2845190", Offset = "0x2843990", VA = "0x182845190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2845830", Offset = "0x2844030", VA = "0x182845830", Slot = "5")]
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
			public QKFNWZERSCU network;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IWKODKJRCUD dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1ED8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Id32<XMKDLRJXOXG>? rootObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public bool autoInitialize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private EVCreationResult <creationArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private VFRMMNWEYJQ <root>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x28458A0", Offset = "0x28440A0", VA = "0x1828458A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2845E30", Offset = "0x2844630", VA = "0x182845E30", Slot = "5")]
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
			public FWQHNCKMARH roomRestrictionsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskAwaiter<DisposableOwned<EVCreationResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2845EA0", Offset = "0x28446A0", VA = "0x182845EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x28463B0", Offset = "0x2844BB0", VA = "0x1828463B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2843D30", Offset = "0x2842530", VA = "0x182843D30")]
		[AsyncStateMachine(typeof(<NewLimitedCircuits>d__2))]
		public static Task<DisposableOwned<LimitedCircuits>>? KFGXVCRLLQD([Optional] FWQHNCKMARH? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2843BB0", Offset = "0x28423B0", VA = "0x182843BB0")]
		[AsyncStateMachine(typeof(<NewEV>d__7))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> ILNXTZIYQHW(QKFNWZERSCU a, [Optional] IWKODKJRCUD? dependencies, [Optional] RegistryV2? b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2843A20", Offset = "0x2842220", VA = "0x182843A20")]
		[AsyncStateMachine(typeof(<NewEV>d__8))]
		[WillBeRenamedTo("NewCircuits")]
		public static Task<EVCreationResult> ILNXTZIYQHW(QKFNWZERSCU a, IWKODKJRCUD b, RegistryV2 c, Id32<XMKDLRJXOXG>? rootObject, bool d = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2843950", Offset = "0x2842150", VA = "0x182843950")]
		public static (RuntimeFnRegistry, RuntimeFns) EEQIHQNSVBQ()
		{
			return default((RuntimeFnRegistry, RuntimeFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2843850", Offset = "0x2842050", VA = "0x182843850")]
		public static (ExternalFnRegistry, ExternalFns) AYCWGDOOFWD()
		{
			return default((ExternalFnRegistry, ExternalFns));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28437D0", Offset = "0x2841FD0", VA = "0x1828437D0")]
		[WillBeRenamedTo("NewCircuitsNetwork")]
		public static QKFNWZERSCU AEKIPNJUUCU(int a = 10240, int b = 204800, int c = 358400)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class QSZWBDWLZTS
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate ICVLDVBXLIZ CV2DependenciesDelegate(GetNetworkObjectDelegate getNetwork);

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
			public QSZWBDWLZTS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private TaskAwaiter<EVCreationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2844DA0", Offset = "0x28435A0", VA = "0x182844DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2845120", Offset = "0x2843920", VA = "0x182845120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly QKFNWZERSCU HMLDIDEPYQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CV2DependenciesDelegate? GILEXCMZNOG;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		private QSZWBDWLZTS(QKFNWZERSCU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2844B60", Offset = "0x2843360", VA = "0x182844B60")]
		public static QSZWBDWLZTS PBVLPMCLPSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2844A50", Offset = "0x2843250", VA = "0x182844A50")]
		public QSZWBDWLZTS HRLOMTNXEJD(CV2DependenciesDelegate a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2844A70", Offset = "0x2843270", VA = "0x182844A70")]
		[AsyncStateMachine(typeof(<End>d__6))]
		public Task<DisposableOwned<EVCreationResult>> KYZXWOEKWKU()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class KDHETAYFWZQ : VFRMMNWEYJQ.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate int GetRpcMessageSplitSizeBytesDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void CircuitsWillDestroyDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void LifecycleDidCreateDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate GKFZNRSBOFI NewCircuitsLifecycleDelegate(LXRXVSRSSBL.HYKMXKQCBUU deps);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void PreReduceDelegate(VFRMMNWEYJQ circuitsManager);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void PostReduceDelegate(VFRMMNWEYJQ circuitsManager);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly GetRpcMessageSplitSizeBytesDelegate VNKWTSSJTXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CircuitsWillDestroyDelegate UMDGXJPYZIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LifecycleDidCreateDelegate JZNNSMPCEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NewCircuitsLifecycleDelegate YCDPKOCNWIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly PreReduceDelegate TIGLPJGNSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly PostReduceDelegate CXDFQYTIXCD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int JVXHRXWYDGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xFEF370", Offset = "0xFEDB70", VA = "0x180FEF370", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x283E510", Offset = "0x283CD10", VA = "0x18283E510", Slot = "6")]
		public void QSTZUQODPJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x283E540", Offset = "0x283CD40", VA = "0x18283E540", Slot = "7")]
		public void UTUBYZUYSJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x283E570", Offset = "0x283CD70", VA = "0x18283E570", Slot = "5")]
		public GKFZNRSBOFI ZLDGXRCHJLD(LXRXVSRSSBL.HYKMXKQCBUU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC29C80", Offset = "0xC28480", VA = "0x180C29C80", Slot = "8")]
		public void IZWWVVTFWHE(VFRMMNWEYJQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC29DD0", Offset = "0xC285D0", VA = "0x180C29DD0", Slot = "9")]
		public void ENKXTYPOTCX(VFRMMNWEYJQ a, LPVLEQQBKYR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x283E5A0", Offset = "0x283CDA0", VA = "0x18283E5A0")]
		public KDHETAYFWZQ([Optional] GetRpcMessageSplitSizeBytesDelegate? a, [Optional] CircuitsWillDestroyDelegate? b, [Optional] LifecycleDidCreateDelegate? c, [Optional] NewCircuitsLifecycleDelegate? d, [Optional] PreReduceDelegate? e, [Optional] PostReduceDelegate? f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[WillBeRenamedTo("CircuitsCreationResult")]
	public readonly struct EVCreationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly YIOIHAOHSAR<QKFNWZERSCU, QKFNWZERSCU.MockStaticNetSysDeps> StaticNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly YEBTSXMREUF<QKFNWZERSCU, QKFNWZERSCU.MockCV2DynamicNetSysDeps> CV2DynamicNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly VFRMMNWEYJQ CircuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly Id32<KQPBKUZCJXR> ClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly QKFNWZERSCU Network;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x283CF80", Offset = "0x283B780", VA = "0x18283CF80")]
		public EVCreationResult(YIOIHAOHSAR<QKFNWZERSCU, QKFNWZERSCU.MockStaticNetSysDeps> staticNetSys, YEBTSXMREUF<QKFNWZERSCU, QKFNWZERSCU.MockCV2DynamicNetSysDeps> cv2DynamicNetSys, VFRMMNWEYJQ circuitsManager, Id32<KQPBKUZCJXR> clientId, QKFNWZERSCU network)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LimitedCircuits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly VFRMMNWEYJQ _circuitsManager;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RegistryV2 BPVVTXQLNKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2843FA0", Offset = "0x28427A0", VA = "0x182843FA0")]
			get
			{
				return default(RegistryV2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CV2Request GHTSRHMEYLO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2843E80", Offset = "0x2842680", VA = "0x182843E80")]
			get
			{
				return default(CV2Request);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GPBTXMACABL? FEAWRYYBLUI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2843EB0", Offset = "0x28426B0", VA = "0x182843EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UPTKEAZFDLV? KFYMZQGFLSO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2843E20", Offset = "0x2842620", VA = "0x182843E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal LimitedCircuits(VFRMMNWEYJQ circuitsManager)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class PFNXITPXXOY : IWKODKJRCUD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HXGPKBFCMYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ICVLDVBXLIZ WJXVERPZIXP;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public HXGPKBFCMYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			internal ICVLDVBXLIZ RWQEPLRWMYT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LXRXVSRSSBL.HYKMXKQCBUU SPGCNLXRGOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public VFRMMNWEYJQ.HYKMXKQCBUU DFKAIAZXODO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NIRKESMUPUN.HYKMXKQCBUU RDGZTTBDOET
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public QHYPLTOUNZH.AGLKOFUJYKN<ActionKind, LPVLEQQBKYR, VFRMMNWEYJQ> EDJLQNFDHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public CV2Request.HYKMXKQCBUU PWLFOHQGORJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SYPUBXDNQDT QERKCKQLCLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LSBMFTSHOAY UWWSLKWUDZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TIQDQKXZXGW GAGWKONLAQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public VWXKZSHWOTI JWWZAGRPFKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HKNCCPTDAZS PJZJGCJFYJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E400", Offset = "0xA9CC00", VA = "0x180A9E400", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x28448B0", Offset = "0x28430B0", VA = "0x1828448B0")]
		private PFNXITPXXOY(LXRXVSRSSBL.HYKMXKQCBUU a, VFRMMNWEYJQ.HYKMXKQCBUU b, NIRKESMUPUN.HYKMXKQCBUU c, QHYPLTOUNZH.AGLKOFUJYKN<ActionKind, LPVLEQQBKYR, VFRMMNWEYJQ> d, CV2Request.HYKMXKQCBUU e, SYPUBXDNQDT f, LSBMFTSHOAY g, TIQDQKXZXGW h, VWXKZSHWOTI i, HKNCCPTDAZS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x28440A0", Offset = "0x28428A0", VA = "0x1828440A0")]
		public static PFNXITPXXOY? MXFIJKAACPZ(NIRKESMUPUN.HYKMXKQCBUU cv2RootSysDeps, [Optional] LXRXVSRSSBL.HYKMXKQCBUU? a, [Optional] VFRMMNWEYJQ.HYKMXKQCBUU? b, [Optional] QHYPLTOUNZH.AGLKOFUJYKN<ActionKind, LPVLEQQBKYR, VFRMMNWEYJQ>? reducerDeps, [Optional] CV2Request.HYKMXKQCBUU? c, [Optional] SYPUBXDNQDT? d, [Optional] LSBMFTSHOAY? e, [Optional] TIQDQKXZXGW? f, [Optional] VWXKZSHWOTI? g, [Optional] HKNCCPTDAZS? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28443F0", Offset = "0x2842BF0", VA = "0x1828443F0")]
		public static PFNXITPXXOY TRDCANCSHMF(ICVLDVBXLIZ a, [Optional] LXRXVSRSSBL.HYKMXKQCBUU? circuitsLifecycleDeps, [Optional] VFRMMNWEYJQ.HYKMXKQCBUU? circuitsManagerDeps, [Optional] QHYPLTOUNZH.AGLKOFUJYKN<ActionKind, LPVLEQQBKYR, VFRMMNWEYJQ>? reducerDeps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2844540", Offset = "0x2842D40", VA = "0x182844540")]
		public static PFNXITPXXOY XSDICXCKUWV(GetNetworkObjectDelegate a, [Optional] LXRXVSRSSBL.HYKMXKQCBUU? circuitsLifecycleDeps, [Optional] VFRMMNWEYJQ.HYKMXKQCBUU? circuitsManagerDeps, [Optional] QHYPLTOUNZH.AGLKOFUJYKN<ActionKind, LPVLEQQBKYR, VFRMMNWEYJQ>? reducerDeps)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class LRKOYVOCPFT
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CGPLWVDWZDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GetNetworkObjectDelegate IPPQBLXFZBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int YFYZBCJSRWJ;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x28399E0", Offset = "0x28381E0", VA = "0x1828399E0")]
			internal OVYKMERUCFM ZZCWEVQUVLI(Guid a, DynamicEnvironmentNetworkId b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2839880", Offset = "0x2838080", VA = "0x182839880")]
			internal OVYKMERUCFM[] ZWMKOLSDCTV(DynamicEnvironmentNetworkId a, Guid[] b, bool c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180")]
			internal int MZCLICYSAYH()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CGUSUBXUIOV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public DynamicEnvironmentNetworkId VICJEVPSWUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CGPLWVDWZDM MNSDRRJEMWM;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGUSUBXUIOV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2839A50", Offset = "0x2838250", VA = "0x182839A50")]
			internal OVYKMERUCFM TUCFFNVQMKY(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly FOGDBIUGYXG DAHQCGMWZOZ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28436B0", Offset = "0x2841EB0", VA = "0x1828436B0")]
		public static OVYKMERUCFM? URMSBVHGFTP(Id32<XMKDLRJXOXG>? networkObject, [Optional] HASYKMYOMRH.SerializesIntoSavesDelegate? a, [Optional] HASYKMYOMRH.SerializesIntoInventionsDelegate? b, [Optional] HASYKMYOMRH.CanPublishInInventionsDelegate? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x283F6A0", Offset = "0x283DEA0", VA = "0x18283F6A0")]
		public static ICVLDVBXLIZ? DIELNAGQKAQ(GetNetworkObjectDelegate getNetworkObjectDelegate, bool a = true, [Optional] CRUJDYEPPSM? b, [Optional] BAFVFEYEPEO? c, [Optional] KNBSBNJAIKM? d, [Optional] FWQHNCKMARH? e, int f = 300000, bool g = false, bool h = false, [Optional] JIZXHTKSSHE? i, [Optional] QWBDOQKLEWG? j, [Optional] PVOQAWFVXFP? k, [Optional] EOZAANGJUTW? l, [Optional] VGMMSOAVDMB? m, [Optional] RWPPFRNAGMI? n, [Optional] FATSTGCXBEA.HYKMXKQCBUU? o, [Optional] EqualsNodeV2.HYKMXKQCBUU? p, [Optional] IIWSQEGIHZQ? q, [Optional] ICVLDVBXLIZ.HasPlayerReferenceBoardDependenciesDelegate? r, [Optional] ICVLDVBXLIZ.GetPlayerReferenceBoardDependenciesDelegate? s, [Optional] ICVLDVBXLIZ.GetPlayerDefinitionBoardDependenciesDelegate? t, [Optional] ICVLDVBXLIZ.GetLocalRoomIdDelegate? u, [Optional] ICVLDVBXLIZ.GetLocalSubroomIdDelegate? v, [Optional] ICVLDVBXLIZ.GetSubroomIdsForLocalRoomDelegate? w, [Optional] ICVLDVBXLIZ.SaveMyPlayerRoomDataDelegate? x, int y = 100, [Optional] ICVLDVBXLIZ.SaveRoomOnPlayerBehalfDelegate? z, [Optional] ICVLDVBXLIZ.ReportCloudDataLedgerChangedDelegate? ba, [Optional] ICVLDVBXLIZ.GetColorNameByIdDelegate? bb, [Optional] ICVLDVBXLIZ.GetPlayerDisplayNameFromSignalDelegate? bc, [Optional] ICVLDVBXLIZ.GetCreationObjectFriendlyNameFromSignalDelegate? bd, [Optional] ICVLDVBXLIZ.GetTaggableNameFromSignalDelegate? be, [Optional] ICVLDVBXLIZ.GetAudioNameFromSignalDelegate? bf, [Optional] ICVLDVBXLIZ.GetDestinationNameFromSignalDelegate? bg, [Optional] ICVLDVBXLIZ.GetPlayerEventNameFromSignalDelegate? bh, [Optional] ICVLDVBXLIZ.GetRoomKeyNameFromSignalDelegate? bi, [Optional] ICVLDVBXLIZ.GetRewardNameFromSignalDelegate? bj, [Optional] ICVLDVBXLIZ.GetRoomCurrencyNameFromSignalDelegate? bk, [Optional] ICVLDVBXLIZ.ReportPreloadedAudioChangedDelegate? bl, [Optional] ICVLDVBXLIZ.ReportRewardDataChangedDelegate? bm, [Optional] ICVLDVBXLIZ.GetConsumableNameFromSignalDelegate? bn, [Optional] ICVLDVBXLIZ.GetGiftDropShopItemNameFromSignalDelegate? bo, [Optional] ICVLDVBXLIZ.GetObjectiveMarkerNameFromSignalDelegate? bp, [Optional] ICVLDVBXLIZ.GetFriendlyLocalPlayerNameDelegate? bq, [Optional] ICVLDVBXLIZ.GetInventoryItemNameFromSignalDelegate? br, [Optional] ICVLDVBXLIZ.GetGetQuickChatTableNameFromSignalDelegate? bs, [Optional] ICVLDVBXLIZ.GetStateMachineStateNameFromSignalDelegate? bt, [Optional] ICVLDVBXLIZ.GetRoomOfferNameFromSignalDelegate? bu, [Optional] ICVLDVBXLIZ.GetStorefrontItemNameFromSignalDelegate? bv, [Optional] ICVLDVBXLIZ.GetObjectIdFromCreationObjectDelegate? bw, [Optional] ICVLDVBXLIZ.GetPropertyEntityFromIdOrNullDelegate? bx, [Optional] ICVLDVBXLIZ.GetCostInBytesDelegate? by, [Optional] ICVLDVBXLIZ.GetAvatarItemNameFromSignalDelegate? bz, [Optional] ICVLDVBXLIZ.GetRoomBadgeNameFromSignalDelegate? ca, [Optional] ICVLDVBXLIZ.PersistenceViewExistsAsReplicatorWithGraphDelegate? cb, [Optional] ICVLDVBXLIZ.DownloadCircuitTemplateRootDataDelegate? cc, [Optional] ICVLDVBXLIZ.GetDiscoverySectionNameFromSignalDelegate? cd, [Optional] ICVLDVBXLIZ.GetStoreItemNameFromSignalDelegate? ce, [Optional] ICVLDVBXLIZ.GetBodyPartNameFromSignalDelegate? cf, [Optional] ICVLDVBXLIZ.GetDependenciesForGraphInstanceDelegate? cg, [Optional] ICVLDVBXLIZ.GetAllDependenciesForEnvironmentDelegate? ch, [Optional] ICVLDVBXLIZ.GetPlayerAccountNameFromSignalDelegate? ci, [Optional] ICVLDVBXLIZ.GetRecNetImageNameFromSignalDelegate? cj, [Optional] ICVLDVBXLIZ.GetRecNetMeshNameFromSignalDelegate? ck, [Optional] LogDeps? cl, [Optional] ICVLDVBXLIZ.IsFunctionValidForAIDelegate? cm, [Optional] ICVLDVBXLIZ.GetAIFunctionNameFromSignalDelegate? cn)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate Id32<XMKDLRJXOXG>? GetNetworkObjectDelegate([In] Guid graphId, DynamicEnvironmentNetworkId networkId);
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class KDPPLKBZAPQ : PVOQAWFVXFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate object GetLocalPlayerDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly KDPPLKBZAPQ GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GetLocalPlayerDelegate? EKUGZMQKIRD;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x283EE00", Offset = "0x283D600", VA = "0x18283EE00", Slot = "4")]
		public (GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE) BTSOPMIGPVG(object a)
		{
			return default((GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE, GHCRFPRDTWE));
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x283EE70", Offset = "0x283D670", VA = "0x18283EE70", Slot = "5")]
		public object GetLocalPlayer()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "6")]
		public bool TUHKJRTAHJN(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xB01280", Offset = "0xAFFA80", VA = "0x180B01280", Slot = "7")]
		public string HMFSIWGYSAH(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public KDPPLKBZAPQ([Optional] GetLocalPlayerDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class HASYKMYOMRH : OVYKMERUCFM
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public delegate bool SerializesIntoSavesDelegate(HASYKMYOMRH self);

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool SerializesIntoInventionsDelegate(HASYKMYOMRH self);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public delegate bool CanPublishInInventionsDelegate(HASYKMYOMRH self);

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly SerializesIntoSavesDelegate OWGZLQXAUEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly SerializesIntoInventionsDelegate RTEMWJSEWBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly CanPublishInInventionsDelegate OWXVEQOCJUO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string? NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ZPREAHTJXHI? XNKXYWETGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DynamicEnvironmentNetworkId XCZYWVLCSCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCFA690", Offset = "0xCF8E90", VA = "0x180CFA690", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(DynamicEnvironmentNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool WSWXGCFKHBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x283DD70", Offset = "0x283C570", VA = "0x18283DD70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LLQVVMPRPMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x283DD40", Offset = "0x283C540", VA = "0x18283DD40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool PMQKZEUOBBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x283DD10", Offset = "0x283C510", VA = "0x18283DD10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PTANQQDYFCF? MZLMWEYGBTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Id32<XMKDLRJXOXG>? UPFNOWQLTKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x283DBC0", Offset = "0x283C3C0", VA = "0x18283DBC0", Slot = "11")]
		public LegacyCV2Result<CircuitSignal> Self()
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x283D670", Offset = "0x283BE70", VA = "0x18283D670", Slot = "12")]
		public LegacyCV2Result<CircuitSignal> GetRootObject(FOGDBIUGYXG e)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640", Slot = "13")]
		public void Bind(ZPREAHTJXHI controlPanelGraph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "14")]
		public void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x283DC60", Offset = "0x283C460", VA = "0x18283DC60")]
		private HASYKMYOMRH(Id32<XMKDLRJXOXG>? networkObject, SerializesIntoSavesDelegate a, SerializesIntoInventionsDelegate b, CanPublishInInventionsDelegate c, string? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "15")]
		public void ConfigureAttachedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "16")]
		public void RemoveAITracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x283D710", Offset = "0x283BF10", VA = "0x18283D710")]
		public static HASYKMYOMRH? New(Id32<XMKDLRJXOXG>? networkObject, [Optional] SerializesIntoSavesDelegate? serializesIntoSavesDelegate, [Optional] SerializesIntoInventionsDelegate? serializesIntoInventionsDelegate, [Optional] CanPublishInInventionsDelegate? canPublishInInventionsDelegate, bool useNullName = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class ERAPNOFUNTH : JIZXHTKSSHE
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
		public static readonly ERAPNOFUNTH GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly RoundToDecimalPlaceDelegate? YGVZMKXJHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TruncateToDecimalPlaceDelegate? NCCNUQVORER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly CircuitsColorLerpDelegate? GHOAMCYFUMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CircuitsColorInverseLerpDelegate? IYBSUXQEEGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly CircuitsMtx4x4GetPositionDelegate? JDGOUFBKTBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly CircuitsMtx4x4GetRotationDelegate? HGKWTJTJFYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly CircuitsMtx4x4InverseDelegate? DCNOJVDKSHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CircuitsMtx4x4MultiplyDelegate? LFHPRRRCRJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CircuitsRigidTransformGetTranslateRotateMatrixDelegate? OHDADLPMSRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly CircuitsQuatDotDelegate? SLQLSHPNYJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly CircuitsQuatFromAngleAxisDelegate? QMYSKZUZJCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly CircuitsQuatFromEulerAnglesDelegate? TCCTXHYGBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CircuitsQuatFromFromToRotationDelegate? SCOGIDUSELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CircuitsQuatFromLookRotationDelegate? EQOBNRATISO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly CircuitsQuatGetAngleBetweenDelegate? QGZILQLASWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly CircuitsQuatInverseDelegate? WQZDFDIJAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CircuitsQuatLerpDelegate? ACPJATCWOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly CircuitsQuatLerpUnclampedDelegate? JUPQEHEZXUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CircuitsQuatInverseLerpDelegate? DQPUNXEVNCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly CircuitsQuatMultiplyDelegate? SAWHGLVWBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly CircuitsQuatNormalizeDelegate? FHOUXTHAGXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly CircuitsQuatRotateTowardsDelegate? ABYGLNQJWYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly CircuitsQuatRotateVectorDelegate? CXXKIYGXMWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CircuitsQuatSlerpDelegate? RRYDHXXNWTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CircuitsQuatToAngleAxisDelegate? YAMVYHBZLTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly CircuitsQuatToEulerAnglesDelegate? XHPZAWEDMFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly CircuitsVec3AddDelegate? AJUFGAOAUNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly CircuitsVec3ClampMagnitudeDelegate? FKLYYEUMYXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CircuitsVec3ClosestPointOnPlaneDelegate? YNPRQLEBUBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly CircuitsVec3CrossDelegate? DNOVHAOEPXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly CircuitsVec3DotDelegate? SWCDLJJMDIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly CircuitsVec3AngleDelegate? JROIMWEHEXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly CircuitsVec3GetMagnitudeDelegate? RGMOBTWYKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly CircuitsVec3LerpDelegate? VYNWGCBYAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CircuitsVec3LerpUnclampedDelegate? UIAUIXRWENT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly CircuitsVec3InverseLerpDelegate? VMZZTZINMJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly CircuitsVec3MoveTowardsDelegate? VQARHMJOLRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly CircuitsVec3NegateDelegate? KRTMSDZKAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly CircuitsVec3NormalizeDelegate? ZHEWOGNOOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly CircuitsVec3ProjectDelegate? AYXUJOSIHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CircuitsVec3ProjectOnPlaneDelegate? CJKLQHINJVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CircuitsVec3ScaleDelegate? GDOFJDEOLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly CircuitsVec3SmoothDampDelegate? CLEVYNRLMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly CircuitsVec3SubtractDelegate? SHGGYSNXUWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly CircuitsVec3SlerpDelegate? VPVPVZAIIRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly CircuitsVec3TransformDelegate? LRDEKJRYIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly CircuitsVec3InverseTransformDelegate? RGWVUQPXLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly RealtimeSinceStartupDelegate? ENTDQCKYQFM;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x283CAA0", Offset = "0x283B2A0", VA = "0x18283CAA0")]
		public ERAPNOFUNTH([Optional] CircuitsColorLerpDelegate? a, [Optional] CircuitsColorInverseLerpDelegate? b, [Optional] CircuitsMtx4x4GetPositionDelegate? c, [Optional] CircuitsMtx4x4GetRotationDelegate? d, [Optional] CircuitsMtx4x4InverseDelegate? e, [Optional] CircuitsMtx4x4MultiplyDelegate? f, [Optional] CircuitsRigidTransformGetTranslateRotateMatrixDelegate? g, [Optional] CircuitsQuatDotDelegate? h, [Optional] CircuitsQuatFromAngleAxisDelegate? i, [Optional] CircuitsQuatFromEulerAnglesDelegate? j, [Optional] CircuitsQuatFromFromToRotationDelegate? k, [Optional] CircuitsQuatFromLookRotationDelegate? l, [Optional] CircuitsQuatGetAngleBetweenDelegate? m, [Optional] CircuitsQuatInverseDelegate? n, [Optional] CircuitsQuatLerpDelegate? o, [Optional] CircuitsQuatLerpUnclampedDelegate? p, [Optional] CircuitsQuatInverseLerpDelegate? q, [Optional] CircuitsQuatMultiplyDelegate? r, [Optional] CircuitsQuatNormalizeDelegate? s, [Optional] CircuitsQuatRotateTowardsDelegate? t, [Optional] CircuitsQuatRotateVectorDelegate? u, [Optional] CircuitsQuatSlerpDelegate? v, [Optional] CircuitsQuatToAngleAxisDelegate? w, [Optional] CircuitsQuatToEulerAnglesDelegate? x, [Optional] CircuitsVec3AddDelegate? y, [Optional] CircuitsVec3ClampMagnitudeDelegate? z, [Optional] CircuitsVec3ClosestPointOnPlaneDelegate? ba, [Optional] CircuitsVec3CrossDelegate? bb, [Optional] CircuitsVec3DotDelegate? bc, [Optional] CircuitsVec3AngleDelegate? bd, [Optional] CircuitsVec3GetMagnitudeDelegate? be, [Optional] CircuitsVec3LerpDelegate? bf, [Optional] CircuitsVec3LerpUnclampedDelegate? bg, [Optional] CircuitsVec3InverseLerpDelegate? bh, [Optional] CircuitsVec3MoveTowardsDelegate? bi, [Optional] CircuitsVec3NegateDelegate? bj, [Optional] CircuitsVec3NormalizeDelegate? bk, [Optional] CircuitsVec3ProjectDelegate? bl, [Optional] CircuitsVec3ProjectOnPlaneDelegate? bm, [Optional] CircuitsVec3ScaleDelegate? bn, [Optional] CircuitsVec3SmoothDampDelegate? bo, [Optional] CircuitsVec3SubtractDelegate? bp, [Optional] CircuitsVec3SlerpDelegate? bq, [Optional] CircuitsVec3TransformDelegate? br, [Optional] CircuitsVec3InverseTransformDelegate? bs, [Optional] RealtimeSinceStartupDelegate? bt, [Optional] RoundToDecimalPlaceDelegate? bu, [Optional] TruncateToDecimalPlaceDelegate? bv)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x283B700", Offset = "0x2839F00", VA = "0x18283B700")]
		public float VMENPPAGJLM([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x283AFA0", Offset = "0x28397A0", VA = "0x18283AFA0")]
		public float FQYCKGVNWYW([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x283C440", Offset = "0x283AC40", VA = "0x18283C440")]
		public CircuitsColor UAKFZBUGRPF([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x283C410", Offset = "0x283AC10", VA = "0x18283C410")]
		public float TRQLECVKPKH([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x283B830", Offset = "0x283A030", VA = "0x18283B830")]
		public CircuitsVec3 KGAPTTXXXKB([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x283C550", Offset = "0x283AD50", VA = "0x18283C550")]
		public CircuitsQuat WDMCWAWOUEM([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x283C610", Offset = "0x283AE10", VA = "0x18283C610")]
		public CircuitsMtx4x4 XELZGTQUBNU([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x283B030", Offset = "0x2839830", VA = "0x18283B030")]
		public CircuitsMtx4x4 GBPEXFWQEFA([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x283A9D0", Offset = "0x28391D0", VA = "0x18283A9D0")]
		public CircuitsMtx4x4 APBAUGNMVTA([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x283AD30", Offset = "0x2839530", VA = "0x18283AD30")]
		public float HCCZDQSJRNV([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x283B580", Offset = "0x2839D80", VA = "0x18283B580")]
		public CircuitsQuat RPFWVETUHLQ(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x283AE90", Offset = "0x2839690", VA = "0x18283AE90")]
		public CircuitsQuat FBBVFLRPVHX([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x283B110", Offset = "0x2839910", VA = "0x18283B110")]
		public CircuitsQuat HPFBLYCAFRB([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x283B1C0", Offset = "0x28399C0", VA = "0x18283B1C0")]
		public CircuitsQuat HSZREEMGWEB([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x283B720", Offset = "0x2839F20", VA = "0x18283B720")]
		public CircuitsQuat JUJPACXOSWM([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x283B270", Offset = "0x2839A70", VA = "0x18283B270")]
		public CircuitsQuat IEHRBHLGNLT([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x283BF80", Offset = "0x283A780", VA = "0x18283BF80")]
		public CircuitsQuat OPILEZFEVRC([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x283C4A0", Offset = "0x283ACA0", VA = "0x18283C4A0")]
		public float XNGUQZMUGLT([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x283B460", Offset = "0x2839C60", VA = "0x18283B460")]
		public CircuitsQuat IPSNVPDBMEE([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x283B8F0", Offset = "0x283A0F0", VA = "0x18283B8F0")]
		public CircuitsQuat QOUGKAMHGIH([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x283AC10", Offset = "0x2839410", VA = "0x18283AC10")]
		public CircuitsQuat ZSQYIQKEZHX([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x283BC00", Offset = "0x283A400", VA = "0x18283BC00")]
		public CircuitsVec3 MUDGHFRWQEA([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x283BEC0", Offset = "0x283A6C0", VA = "0x18283BEC0")]
		public CircuitsQuat WYYMJUFMRKI([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x283C300", Offset = "0x283AB00", VA = "0x18283C300")]
		public void YPTZQTDUIGN([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x283B890", Offset = "0x283A090", VA = "0x18283B890")]
		public CircuitsVec3 LHQZPLBZFCW([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x283B7C0", Offset = "0x2839FC0", VA = "0x18283B7C0")]
		public CircuitsVec3 KDGEZYSGPDV([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x283BCE0", Offset = "0x283A4E0", VA = "0x18283BCE0")]
		public CircuitsVec3 NKBGQEZYVOX([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x283AF30", Offset = "0x2839730", VA = "0x18283AF30")]
		public CircuitsVec3 FMFELMPUFJW([In] CircuitsVec3 self, [In] CircuitsVec3 pointOnPlane, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x283AFC0", Offset = "0x28397C0", VA = "0x18283AFC0")]
		public CircuitsVec3 FRFDIAUXEWI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x283AB10", Offset = "0x2839310", VA = "0x18283AB10")]
		public float BPYQBNTTKVJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x283C530", Offset = "0x283AD30", VA = "0x18283C530")]
		public float WASRZVPHUNF([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x283C100", Offset = "0x283A900", VA = "0x18283C100")]
		public float PLYFHTXANPE([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x283BC70", Offset = "0x283A470", VA = "0x18283BC70")]
		public CircuitsVec3 NIZOJWIIDTD([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x283A960", Offset = "0x2839160", VA = "0x18283A960")]
		public CircuitsVec3 AELIYEAQMFG([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x283AD50", Offset = "0x2839550", VA = "0x18283AD50")]
		public float EGKYCEEXEHT([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x283AD80", Offset = "0x2839580", VA = "0x18283AD80")]
		public CircuitsVec3 EQFBPMOZEIT([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x283B630", Offset = "0x2839E30", VA = "0x18283B630")]
		public CircuitsVec3 JFWYTPHRVHU([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x283C4D0", Offset = "0x283ACD0", VA = "0x18283C4D0")]
		public CircuitsVec3 VZYMFNMLOMX([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x283C220", Offset = "0x283AA20", VA = "0x18283C220")]
		public CircuitsVec3 RHCFNKUNNBD([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x283C1B0", Offset = "0x283A9B0", VA = "0x18283C1B0")]
		public CircuitsVec3 QZCQLHNKFYS([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x283C5A0", Offset = "0x283ADA0", VA = "0x18283C5A0")]
		public CircuitsVec3 XCJZRJEWCUO([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x283C7C0", Offset = "0x283AFC0", VA = "0x18283C7C0")]
		public CircuitsVec3 ZIKYUQKLZNW([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x283B0A0", Offset = "0x28398A0", VA = "0x18283B0A0")]
		public CircuitsVec3 GLKOOSPDBME([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x283C3A0", Offset = "0x283ABA0", VA = "0x18283C3A0")]
		public CircuitsVec3 SZRSBPEHCCU([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x283C750", Offset = "0x283AF50", VA = "0x18283C750")]
		public CircuitsVec3 ZBWASVKQJDO([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x283BA60", Offset = "0x283A260", VA = "0x18283BA60")]
		public CircuitsVec3 MMCMNJISFYA([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x283ADF0", Offset = "0x28395F0", VA = "0x18283ADF0", Slot = "50")]
		public Task EZHTLXTJMFW(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "51")]
		public void EBBFYAAZENO([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x283BE00", Offset = "0x283A600", VA = "0x18283BE00", Slot = "52")]
		public PDZCNDGPMJR<NSOJHEXWUKL> ODOCBVFBVXA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x283C0B0", Offset = "0x283A8B0", VA = "0x18283C0B0", Slot = "53")]
		public PDZCNDGPMJR<NSOJHEXWUKL> PBNCGYKJZET()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x283C190", Offset = "0x283A990", VA = "0x18283C190", Slot = "54")]
		public float QRAIJYHXFEF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x283B700", Offset = "0x2839F00", VA = "0x18283B700", Slot = "4")]
		private float JLPAEDYNOMI([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x283AFA0", Offset = "0x28397A0", VA = "0x18283AFA0", Slot = "5")]
		private float XYKSAVPRSGA([In] float value, [In] int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x283BBA0", Offset = "0x283A3A0", VA = "0x18283BBA0", Slot = "6")]
		private CircuitsColor MRKIURBFNUZ([In] CircuitsColor a, [In] CircuitsColor b, float a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x283C410", Offset = "0x283AC10", VA = "0x18283C410", Slot = "7")]
		private float TSJTZGMAQJX([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x283BB40", Offset = "0x283A340", VA = "0x18283BB40", Slot = "8")]
		private CircuitsVec3 MRDSCDSMNWP([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x283BDB0", Offset = "0x283A5B0", VA = "0x18283BDB0", Slot = "9")]
		private CircuitsQuat NZCTRVLWISG([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x283C6F0", Offset = "0x283AEF0", VA = "0x18283C6F0", Slot = "10")]
		private CircuitsMtx4x4 YAGOMRCTGYM([In] CircuitsMtx4x4 self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x283BD50", Offset = "0x283A550", VA = "0x18283BD50", Slot = "11")]
		private CircuitsMtx4x4 NPREUFSTDXW([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x283AA40", Offset = "0x2839240", VA = "0x18283AA40", Slot = "12")]
		private CircuitsMtx4x4 AXZZVENZMKI([In] CircuitsRigidTransform self)
		{
			return default(CircuitsMtx4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x283AD30", Offset = "0x2839530", VA = "0x18283AD30", Slot = "13")]
		private float DRMQYWYQRGR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x283B580", Offset = "0x2839D80", VA = "0x18283B580", Slot = "14")]
		private CircuitsQuat IVYMOEVUXPS(float a, [In] CircuitsVec3 axis)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x283AE90", Offset = "0x2839690", VA = "0x18283AE90", Slot = "15")]
		private CircuitsQuat NSISGDJXGIH([In] CircuitsVec3 euler)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x283B110", Offset = "0x2839910", VA = "0x18283B110", Slot = "16")]
		private CircuitsQuat UZKJXXMSSPT([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x283B1C0", Offset = "0x28399C0", VA = "0x18283B1C0", Slot = "17")]
		private CircuitsQuat SATEZYLXEGL([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x283B720", Offset = "0x2839F20", VA = "0x18283B720", Slot = "18")]
		private CircuitsQuat REOZNJYTGYC([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x283B270", Offset = "0x2839A70", VA = "0x18283B270", Slot = "19")]
		private CircuitsQuat JZBYWMBWBQL([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x283BF80", Offset = "0x283A780", VA = "0x18283BF80", Slot = "20")]
		private CircuitsQuat RVBOZTKEVMC([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x283C4A0", Offset = "0x283ACA0", VA = "0x18283C4A0", Slot = "21")]
		private float UWEBXBWGEDJ([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x283B460", Offset = "0x2839C60", VA = "0x18283B460", Slot = "22")]
		private CircuitsQuat YEQZEIKQOTE([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x283B8F0", Offset = "0x283A0F0", VA = "0x18283B8F0", Slot = "23")]
		private CircuitsQuat LIFKRFWPCWF([In] CircuitsQuat self)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x283AC10", Offset = "0x2839410", VA = "0x18283AC10", Slot = "24")]
		private CircuitsQuat DITFNOMNDRV([In] CircuitsQuat from, [In] CircuitsQuat to, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x283BE50", Offset = "0x283A650", VA = "0x18283BE50", Slot = "25")]
		private CircuitsVec3 OFPZYDXSKFM([In] CircuitsQuat self, [In] CircuitsVec3 vector)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x283BEC0", Offset = "0x283A6C0", VA = "0x18283BEC0", Slot = "26")]
		private CircuitsQuat OOYFJRGFIXE([In] CircuitsQuat a, [In] CircuitsQuat b, float a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x283C300", Offset = "0x283AB00", VA = "0x18283C300", Slot = "27")]
		private void SQOUVAMVITF([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x283B990", Offset = "0x283A190", VA = "0x18283B990", Slot = "28")]
		private CircuitsVec3 LOCDNUQCHKM([In] CircuitsQuat self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x283AAA0", Offset = "0x28392A0", VA = "0x18283AAA0", Slot = "29")]
		private CircuitsVec3 BBSGZSGOXJX([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x283C040", Offset = "0x283A840", VA = "0x18283C040", Slot = "30")]
		private CircuitsVec3 OQSXOYWYOZT([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x283C120", Offset = "0x283A920", VA = "0x18283C120", Slot = "31")]
		private CircuitsVec3 PXTUWXYWOKK([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x283C680", Offset = "0x283AE80", VA = "0x18283C680", Slot = "32")]
		private CircuitsVec3 XQHPIKTKIJU([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x283AE20", Offset = "0x2839620", VA = "0x18283AE20", Slot = "33")]
		private CircuitsVec3 FAKDXTYKJTE([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x283BAD0", Offset = "0x283A2D0", VA = "0x18283BAD0", Slot = "34")]
		private CircuitsVec3 MQTVCDZPPNQ([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x283AB10", Offset = "0x2839310", VA = "0x18283AB10", Slot = "35")]
		private float HZYPCNKJKLH([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x283C530", Offset = "0x283AD30", VA = "0x18283C530", Slot = "36")]
		private float ZXGUISCDVIZ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x283C100", Offset = "0x283A900", VA = "0x18283C100", Slot = "37")]
		private float RCVRBXETBLK([In] CircuitsVec3 self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x283B9F0", Offset = "0x283A1F0", VA = "0x18283B9F0", Slot = "38")]
		private CircuitsVec3 LQXGTBDBHYP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x283B510", Offset = "0x2839D10", VA = "0x18283B510", Slot = "39")]
		private CircuitsVec3 ISURHDJVEYS([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x283AD50", Offset = "0x2839550", VA = "0x18283AD50", Slot = "40")]
		private float RRYIWWJOSPF([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x283AB30", Offset = "0x2839330", VA = "0x18283AB30", Slot = "41")]
		private CircuitsVec3 BZZUARSQWYJ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x283C340", Offset = "0x283AB40", VA = "0x18283C340", Slot = "42")]
		private CircuitsVec3 STJKOGLPSKE([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x283ACD0", Offset = "0x28394D0", VA = "0x18283ACD0", Slot = "43")]
		private CircuitsVec3 DMLNFOPZQMF([In] CircuitsVec3 self)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x283ABA0", Offset = "0x28393A0", VA = "0x18283ABA0", Slot = "44")]
		private CircuitsVec3 CWYKAMEPIQX([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x283B3F0", Offset = "0x2839BF0", VA = "0x18283B3F0", Slot = "45")]
		private CircuitsVec3 INOGXYVGRUQ([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x283B690", Offset = "0x2839E90", VA = "0x18283B690", Slot = "46")]
		private CircuitsVec3 JJWUUMUEVTK([In] CircuitsVec3 self, float a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x283B330", Offset = "0x2839B30", VA = "0x18283B330", Slot = "47")]
		private CircuitsVec3 IJKWTIDQVLQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x283C290", Offset = "0x283AA90", VA = "0x18283C290", Slot = "48")]
		private CircuitsVec3 SKHETPCUKZI([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x283C870", Offset = "0x283B070", VA = "0x18283C870", Slot = "49")]
		private CircuitsVec3 ZSIYXSGMBSW([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a)
		{
			return default(CircuitsVec3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class OPMFIPMRCCZ : HTAQCRXZXXY
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UseCheapReplicas
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x105ED50", Offset = "0x105D550", VA = "0x18105ED50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xFA7A60", Offset = "0xFA6260", VA = "0x180FA7A60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2844050", Offset = "0x2842850", VA = "0x182844050")]
		public OPMFIPMRCCZ(int a, bool b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class WRPMDLYRNON : QWBDOQKLEWG
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public delegate CircuitsColor GetCircuitsColorFromColorIndexDelegate(int colorIndex);

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate int GetNearestColorIndexFromCircuitsColorDelegate([In] CircuitsColor circuitsColor);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate LegacyCV2Result<None> InvisibleCollisionSetEnabledDelegate(UDMGTDTZRVD e, YIBPXMUYWTO invisibleCollision, bool setEnabled);

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly WRPMDLYRNON GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly GetCircuitsColorFromColorIndexDelegate? QZFHRENKHQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly GetNearestColorIndexFromCircuitsColorDelegate? BVSTDTCGKZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly InvisibleCollisionSetEnabledDelegate? IVQGRIXTWHF;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB28F10", Offset = "0xB27710", VA = "0x180B28F10")]
		public WRPMDLYRNON([Optional] GetCircuitsColorFromColorIndexDelegate? a, [Optional] GetNearestColorIndexFromCircuitsColorDelegate? b, [Optional] InvisibleCollisionSetEnabledDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2847520", Offset = "0x2845D20", VA = "0x182847520", Slot = "4")]
		public CircuitsColor VPCOGPTIAFL(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2847500", Offset = "0x2845D00", VA = "0x182847500")]
		public int FLOLVQJKLUD([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2847500", Offset = "0x2845D00", VA = "0x182847500", Slot = "5")]
		private int SZYMLHUKLHS([In] CircuitsColor circuitsColor)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class JAGEKNAJKUM : XWRBSDSQLYR
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private class LSJLOXHIYMV
		{
			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Guid GMVNZYNURXD
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xC27030", Offset = "0xC25830", VA = "0x180C27030")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public long TTMJPBPLXRY
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public int BIBYNZPQUGM
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xAA4E00", Offset = "0xAA3600", VA = "0x180AA4E00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool QMYOFCJEUFT
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x181DE50", Offset = "0x181C650", VA = "0x18181DE50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool JLSQQWLFVED
			{
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x181DE60", Offset = "0x181C660", VA = "0x18181DE60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool GWPDPMCKWSE
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x2843750", Offset = "0x2841F50", VA = "0x182843750")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2843770", Offset = "0x2841F70", VA = "0x182843770")]
			public LSJLOXHIYMV(Guid a, long b, int c, bool d, bool e = false)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly Dictionary<Id128<XEUKGISKBDU>, LSJLOXHIYMV> HZJQSDHOTIU;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x283E0F0", Offset = "0x283C8F0", VA = "0x18283E0F0")]
		public bool QUFPYOIGULH([In] Id128<XEUKGISKBDU> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x283E020", Offset = "0x283C820", VA = "0x18283E020")]
		public void HJCILKQEJLX([In] Id128<XEUKGISKBDU> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x283E200", Offset = "0x283CA00", VA = "0x18283E200")]
		public void HJCILKQEJLX([In] Id128<XEUKGISKBDU> key, Guid a, long b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x283E370", Offset = "0x283CB70", VA = "0x18283E370")]
		public void YZMPRWNSKTC([In] Id128<XEUKGISKBDU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x283DFC0", Offset = "0x283C7C0", VA = "0x18283DFC0")]
		public void DJHFZODKYIX([In] Id128<XEUKGISKBDU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x283E2E0", Offset = "0x283CAE0", VA = "0x18283E2E0")]
		public bool QMYOFCJEUFT([In] Id128<XEUKGISKBDU> key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x283E490", Offset = "0x283CC90", VA = "0x18283E490")]
		public JAGEKNAJKUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x283E0F0", Offset = "0x283C8F0", VA = "0x18283E0F0", Slot = "4")]
		private bool EGKQGXJHMSG([In] Id128<XEUKGISKBDU> key, [Out] Guid a, [Out] long b, [Out] int c, [Out] bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x283E020", Offset = "0x283C820", VA = "0x18283E020", Slot = "5")]
		private void EAYTHTASSGS([In] Id128<XEUKGISKBDU> key, Guid a, long b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x283E370", Offset = "0x283CB70", VA = "0x18283E370", Slot = "6")]
		private void LSLOIBMBXWP([In] Id128<XEUKGISKBDU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x283DFC0", Offset = "0x283C7C0", VA = "0x18283DFC0", Slot = "7")]
		private void NXCJLAGZNZS([In] Id128<XEUKGISKBDU> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x283E2E0", Offset = "0x283CAE0", VA = "0x18283E2E0", Slot = "8")]
		private bool KLLTTGBWJKM([In] Id128<XEUKGISKBDU> key)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class LQASMMQUCVZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x283F270", Offset = "0x283DA70", VA = "0x18283F270")]
		public static LogDeps YXQAHLUTWDC()
		{
			return default(LogDeps);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class VTPAFLDETXY : MeshLibrary.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
		public byte[]? NMSHHVXRUFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void MSZAGPKXVPQ(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public VTPAFLDETXY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class ABCDAFQOZKJ : CRUJDYEPPSM
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
		public delegate void ConfigureAttachedObjectDelegate(VAUZTSPLNIW controlPanel, CWRBORGFPZK staticNode);

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate void DisplayInvalidNameErrorMessageDelegate(string errorMessage);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate Task<bool> IsStringPureDelegate(string? stringValue, string context);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate bool TryGetSpecificChipConfigSummaryDelegate(Guid nodeTypeId, [Out] SpecificChipConfigSummary chipConfigSummary);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void ReleaseIconIdDelegate(Id32<VISMDLBISYT> iconId);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public delegate Task<Result<None, AGEZPYTJJRF>> ReportCreationErrorToUserAsyncDelegate(Task<Result<None, AGEZPYTJJRF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public delegate Task<Result<MultiResult, AGEZPYTJJRF>> ReportCreationErrorToUserAsyncDelegate2(Task<Result<MultiResult, AGEZPYTJJRF>> task);

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public delegate Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> ReportCreationErrorToUserAsyncDelegate3(Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> task);

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
			public AsyncTaskMethodBuilder<Result<MultiResult, AGEZPYTJJRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Task<Result<MultiResult, AGEZPYTJJRF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<Result<MultiResult, AGEZPYTJJRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2846420", Offset = "0x2844C20", VA = "0x182846420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x28466E0", Offset = "0x2844EE0", VA = "0x1828466E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private TaskAwaiter<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2846750", Offset = "0x2844F50", VA = "0x182846750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2846A10", Offset = "0x2845210", VA = "0x182846A10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<None, AGEZPYTJJRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task<Result<None, AGEZPYTJJRF>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<Result<None, AGEZPYTJJRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2846A80", Offset = "0x2845280", VA = "0x182846A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x2846D40", Offset = "0x2845540", VA = "0x182846D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<string, EnumChoiceData> ZJFBFPMXJTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<int, string> UVFXFJVDEZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly List<object> UTASIMKEKUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly List<Guid> GNGVIIQSMWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly CanLocalPlayerCreateCurrencyDelegate GAXEJWCXBRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ShowRoomCurrencyCreationUIDelegate PNOXFBJCBXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GetAudioClipOptionsDelegate UHWKXMRAXDY;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly IReadOnlyDictionary<Guid, int> XQXANHMEGYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly GetAudioClipGuidToIndexMapDelegate TQYVDEQSTBM;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly IReadOnlyDictionary<int, Guid> TABTABQVSSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly GetAudioClipIndexToGuidMapDelegate JCJUYDVDKIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly GetAllAudioClipOptionsDelegate LSAEFNKTKZX;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly IReadOnlyDictionary<Guid, int> XRLBKWRDXEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly GetAllAudioClipGuidToIndexMapDelegate OTGLSJVISPZ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly IReadOnlyDictionary<int, Guid> POPUTUOMRMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly GetAllAudioClipIndexToGuidMapDelegate MTOPOBIGVMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly PlayAudioPreviewDelegate LYPSBBZCTTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly StopAudioPreviewDelegate VQLUIBSRMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SubscriptionIsActiveDelegate QVMZRQZBAZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly CanAffordToConvertVariableToCloudVariableDelegate NINASMNPIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Dictionary<string, EnumChoiceData> OVBUGNCZZRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly ShowQuickChatEditMenuDelegate BSPZLSGPINX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly ConfigureAttachedObjectDelegate DTQZHQQWYUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DisplayInvalidNameErrorMessageDelegate HRFIAUMVSJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly IsStringPureDelegate NCRKNRKVSFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TryGetSpecificChipConfigSummaryDelegate YBGWEIGITQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly ReleaseIconIdDelegate BXZKLDNDXQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ReportCreationErrorToUserAsyncDelegate OFMCAOYBGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly ReportCreationErrorToUserAsyncDelegate2 VKQOLFIEHHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly ReportCreationErrorToUserAsyncDelegate3 VKLHNYOGXWM;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RuntimeEnvironment JWCCLEOWNPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			get
			{
				return default(RuntimeEnvironment);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VGWRAMEQEFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xAF3180", Offset = "0xAF1980", VA = "0x180AF3180", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyDictionary<int, string> QNBJOXUEVYO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<object> LAEPWIESAHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<Guid> UIDVEJNXAPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IReadOnlyDictionary<string, EnumChoiceData> MROKJTBSAJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3910", Offset = "0xAA2110", VA = "0x180AA3910", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RoomVersion BZRKOJSLCEQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD27610", Offset = "0xD25E10", VA = "0x180D27610", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return default(RoomVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HJGTSRVFTYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xBF0290", Offset = "0xBEEA90", VA = "0x180BF0290", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool BHRIGIGSHJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x28381E0", Offset = "0x28369E0", VA = "0x1828381E0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ELPMQLGOJEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2837DA0", Offset = "0x28365A0", VA = "0x182837DA0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool SFHVKMSPTOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAA77F0", Offset = "0xAA5FF0", VA = "0x180AA77F0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x28384D0", Offset = "0x2836CD0", VA = "0x1828384D0")]
		public ABCDAFQOZKJ([Optional] Dictionary<string, EnumChoiceData>? cachedCurrencyFriendlyNameDict, [Optional] Dictionary<int, string>? cachedCurrencyReverseLookup, [Optional] List<object>? cachedCurrencyItemList, [Optional] List<Guid>? a, [Optional] CanLocalPlayerCreateCurrencyDelegate? b, [Optional] ShowRoomCurrencyCreationUIDelegate? c, [Optional] GetAudioClipOptionsDelegate? d, [Optional] GetAudioClipGuidToIndexMapDelegate? e, [Optional] GetAudioClipIndexToGuidMapDelegate? f, [Optional] GetAllAudioClipOptionsDelegate? g, [Optional] GetAllAudioClipGuidToIndexMapDelegate? h, [Optional] GetAllAudioClipIndexToGuidMapDelegate? i, [Optional] PlayAudioPreviewDelegate? j, [Optional] StopAudioPreviewDelegate? k, [Optional] SubscriptionIsActiveDelegate? l, [Optional] CanAffordToConvertVariableToCloudVariableDelegate? m, [Optional] Dictionary<string, EnumChoiceData>? cachedPlayerOutfitSlotFlagsDict, [Optional] ShowQuickChatEditMenuDelegate? n, [Optional] ConfigureAttachedObjectDelegate? o, [Optional] DisplayInvalidNameErrorMessageDelegate? p, [Optional] IsStringPureDelegate? q, [Optional] TryGetSpecificChipConfigSummaryDelegate? r, [Optional] ReleaseIconIdDelegate? s, [Optional] ReportCreationErrorToUserAsyncDelegate? t, [Optional] ReportCreationErrorToUserAsyncDelegate2? u, [Optional] ReportCreationErrorToUserAsyncDelegate3? v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2837AD0", Offset = "0x28362D0", VA = "0x182837AD0", Slot = "9")]
		public bool DGBJRMARVSS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
		public static bool IXBNVTHHDIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2837FE0", Offset = "0x28367E0", VA = "0x182837FE0", Slot = "10")]
		public bool PHRZBOGWPUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static void DSIBAZZWTBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xC1B2B0", Offset = "0xC19AB0", VA = "0x180C1B2B0", Slot = "11")]
		public void EHNYIVDVPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2838150", Offset = "0x2836950", VA = "0x182838150")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> UMONDXVXEEM(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2838010", Offset = "0x2836810", VA = "0x182838010", Slot = "12")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PMVUMPCYVFF(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x28382B0", Offset = "0x2836AB0", VA = "0x1828382B0")]
		private static IReadOnlyDictionary<Guid, int> ZQKYTGCXAZQ(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2838280", Offset = "0x2836A80", VA = "0x182838280", Slot = "13")]
		public IReadOnlyDictionary<Guid, int> ZIEPVBDCMPL(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2838230", Offset = "0x2836A30", VA = "0x182838230")]
		private static IReadOnlyDictionary<int, Guid> VWJLYRQOMBE(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x28380F0", Offset = "0x28368F0", VA = "0x1828380F0", Slot = "14")]
		public IReadOnlyDictionary<int, Guid> TWDTFSZUXER(AudioClipType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2837E40", Offset = "0x2836640", VA = "0x182837E40")]
		private static IReadOnlyList<KeyValuePair<string, EnumChoiceData>> KHYSDIVWXRN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x282E940", Offset = "0x282D140", VA = "0x18282E940", Slot = "15")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> PFWYSHYMGQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2837E70", Offset = "0x2836670", VA = "0x182837E70")]
		private static IReadOnlyDictionary<Guid, int> KYCAJYDWNTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2838300", Offset = "0x2836B00", VA = "0x182838300", Slot = "16")]
		public IReadOnlyDictionary<Guid, int> ZXARZVPXROW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2837DB0", Offset = "0x28365B0", VA = "0x182837DB0", Slot = "17")]
		public IReadOnlyDictionary<int, Guid> ISKCCMZGGAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private static void WOQBPIHTGMA(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x28381F0", Offset = "0x28369F0", VA = "0x1828381F0", Slot = "18")]
		public void VMJHQFDKKTZ(AudioClipType a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private static void WCCCCSOLSNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2838330", Offset = "0x2836B30", VA = "0x182838330", Slot = "19")]
		public void ZXYQJSSGWKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
		private static bool ALCLBYWSAAR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2838180", Offset = "0x2836980", VA = "0x182838180", Slot = "20")]
		public bool URGISYCVOPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
		public static bool UJVWEDBBLMY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x28381B0", Offset = "0x28369B0", VA = "0x1828381B0", Slot = "21")]
		public bool USHZFBXGTHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2837A10", Offset = "0x2836210", VA = "0x182837A10", Slot = "23")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BOMVIBDIBIY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "24")]
		public IReadOnlyDictionary<Guid, int> ESBIHIIFTJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "25")]
		public IReadOnlyDictionary<int, Guid> FLBQVPEKSYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2837FB0", Offset = "0x28367B0", VA = "0x182837FB0", Slot = "26")]
		public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> MCFTDCDKPSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "27")]
		public IReadOnlyDictionary<Guid, int> ARUXIWHKKQD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "28")]
		public IReadOnlyDictionary<int, Guid> RYSIIXVDBQD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static void PVNQFGTIEUZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x28380B0", Offset = "0x28368B0", VA = "0x1828380B0", Slot = "29")]
		public void TMMZWCOUCRK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private static void EUQUTGGREDJ(VAUZTSPLNIW a, CWRBORGFPZK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2838040", Offset = "0x2836840", VA = "0x182838040", Slot = "35")]
		public void SYJSVWQNLOC(VAUZTSPLNIW a, CWRBORGFPZK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "36")]
		public Dictionary<string, EnumChoiceData> WJQWIYBBDFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "37")]
		public Dictionary<string, EnumChoiceData> TBTBGFCLKWV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private static void TCSJNBCOCAZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2837DE0", Offset = "0x28365E0", VA = "0x182837DE0")]
		private static Task<bool> KEDRFQNEQJH(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2837B90", Offset = "0x2836390", VA = "0x182837B90", Slot = "38")]
		public Task<bool> FZYRYVYHUTW(string? stringValue, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2837A00", Offset = "0x2836200", VA = "0x182837A00")]
		private static bool AQYWTMETJEV(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2838070", Offset = "0x2836870", VA = "0x182838070", Slot = "39")]
		public bool TEPSXMMBVAI(Guid a, [Out] SpecificChipConfigSummary b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private static void HMAKQFHZMHL(Id32<VISMDLBISYT> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2838120", Offset = "0x2836920", VA = "0x182838120", Slot = "40")]
		public void UMHRXAJBSLW(Id32<VISMDLBISYT> iconId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2837EC0", Offset = "0x28366C0", VA = "0x182837EC0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault>d__128))]
		private static Task<Result<None, AGEZPYTJJRF>> LPTVKSICIFL(Task<Result<None, AGEZPYTJJRF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2837AA0", Offset = "0x28362A0", VA = "0x182837AA0", Slot = "41")]
		public Task<Result<None, AGEZPYTJJRF>> CRRYPABFTCI(Task<Result<None, AGEZPYTJJRF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2837CB0", Offset = "0x28364B0", VA = "0x182837CB0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault2>d__132))]
		private static Task<Result<MultiResult, AGEZPYTJJRF>> GBXWBNFYAFL(Task<Result<MultiResult, AGEZPYTJJRF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2837A40", Offset = "0x2836240", VA = "0x182837A40", Slot = "42")]
		public Task<Result<MultiResult, AGEZPYTJJRF>> CRRYPABFTCI(Task<Result<MultiResult, AGEZPYTJJRF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2837BC0", Offset = "0x28363C0", VA = "0x182837BC0")]
		[AsyncStateMachine(typeof(<ReportCreationErrorToUserAsyncDefault3>d__136))]
		private static Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> GBSPEGMAQUC(Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> task)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2837A70", Offset = "0x2836270", VA = "0x182837A70", Slot = "43")]
		public Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> CRRYPABFTCI(Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class KNBSBNJAIKM : XEFIJRFQQCT
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public delegate LegacyCV2Result<None> InvokeStudioFunctionDelegate(FOGDBIUGYXG e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private InteropDelegate? ZVRVASQFSUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly InteropDelegate FXSTBUJRMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly InteropDelegate DCESXZFHMQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private InteropDelegate? QJGNBXAMIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private InvokeStudioFunctionDelegate? CUBNWHZYYAC;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "4")]
		public LegacyCV2Result<None> CloudDataWipeLocalData(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "5")]
		public LegacyCV2Result<None> JFKTCHTNIOS(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		private static LegacyCV2Result<None> Default(FOGDBIUGYXG _, InOut __)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "6")]
		public LegacyCV2Result<None> TKKOHHNKXNR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "7")]
		public LegacyCV2Result<None> LABDDQFDKGQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "8")]
		public LegacyCV2Result<None> FGDNPYCYSUB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "9")]
		public LegacyCV2Result<None> ITSLFKFZVUJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "10")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyBool(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "11")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyFloat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "12")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyInt(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "13")]
		public LegacyCV2Result<None> AddAnalyticsEventPropertyString(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "14")]
		public LegacyCV2Result<None> CreateAnalyticsPayload(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "15")]
		public LegacyCV2Result<None> LOFPQTANHYG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "16")]
		public LegacyCV2Result<None> LogAnalyticsPayload(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "17")]
		public LegacyCV2Result<None> AngularVelocitySetChip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "18")]
		public LegacyCV2Result<None> AngularVelocityAddChip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "19")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "20")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocitySetChipQuaternion(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "21")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "22")]
		public LegacyCV2Result<None> DEPRECATEDAngularVelocityAddChipQuaternion(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "23")]
		public LegacyCV2Result<None> DEPRECATEDGetPositionPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "24")]
		public LegacyCV2Result<None> DEPRECATEDGetForwardVectorPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "25")]
		public LegacyCV2Result<None> DEPRECATEDGetUpVectorPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "26")]
		public LegacyCV2Result<None> DEPRECATEDGetOrientationPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "27")]
		public LegacyCV2Result<None> DEPRECATEDGetVelocityPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "28")]
		public LegacyCV2Result<None> DEPRECATEDDistanceAI_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "29")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCombatant_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "30")]
		public LegacyCV2Result<None> DEPRECATEDDistanceCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "31")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "32")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "33")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "34")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "35")]
		public LegacyCV2Result<None> DEPRECATEDDistancePlayer_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "36")]
		public LegacyCV2Result<None> DEPRECATEDDistanceVector3_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "37")]
		public LegacyCV2Result<None> AIGetTarget(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "38")]
		public LegacyCV2Result<None> AISetTarget(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "39")]
		public LegacyCV2Result<None> AIStartCombatBehavior(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "40")]
		public LegacyCV2Result<None> AIStopCombatBehavior(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "41")]
		public LegacyCV2Result<None> AISetPatrolPath(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "42")]
		public LegacyCV2Result<None> AIPathToAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "43")]
		public LegacyCV2Result<None> AIPathToCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "44")]
		public LegacyCV2Result<None> AIPathToCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "45")]
		public LegacyCV2Result<None> AIPathToPatrolPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "46")]
		public LegacyCV2Result<None> AIPathToPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "47")]
		public LegacyCV2Result<None> AIPathToVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "48")]
		public LegacyCV2Result<None> AISetLineOfSightParameters(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "49")]
		public LegacyCV2Result<None> AIGetLineOfSightParameters(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "50")]
		public LegacyCV2Result<None> AILookAtAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "51")]
		public LegacyCV2Result<None> AILookAtCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "52")]
		public LegacyCV2Result<None> AILookAtCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "53")]
		public LegacyCV2Result<None> AILookAtPatrolPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "54")]
		public LegacyCV2Result<None> AILookAtPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "55")]
		public LegacyCV2Result<None> AILookAtVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "56")]
		public LegacyCV2Result<None> AISetPathingSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "57")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "58")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "59")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "60")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPatrolPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "61")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "62")]
		public LegacyCV2Result<None> AIHasLineOfSightToTargetVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "63")]
		public LegacyCV2Result<None> AIRotateFloat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "64")]
		public LegacyCV2Result<None> AIRotateInt(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "65")]
		public LegacyCV2Result<None> AIRotateVector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "66")]
		public LegacyCV2Result<None> AIStopLooking(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "67")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZKPAZSCCVVA(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "68")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> USBENBHFIDM(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "69")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> OPQVRPXRFPP(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "70")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EHDNHLCYWJG(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "71")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BGPIJGGEUUH(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "72")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QRXESRHJJXB(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "73")]
		public LegacyCV2Result<None> GameAIGetIsSubtitleOutputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "74")]
		public LegacyCV2Result<None> GameAISetIsSubtitleOutputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "75")]
		public LegacyCV2Result<None> GameAIGetIsVoiceOutputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "76")]
		public LegacyCV2Result<None> GameAISetIsVoiceOutputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "77")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZYBWOSTZIFE(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "78")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIClearContext(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "79")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAISendUserPromptWithStructuredResponse(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "80")]
		public LegacyCV2Result<None> GameAIGetMaxRolloffDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "81")]
		public LegacyCV2Result<None> GameAISetMaxRolloffDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "82")]
		public LegacyCV2Result<None> GameAIGetIsVoiceInputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "83")]
		public LegacyCV2Result<None> GameAISetIsVoiceInputEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "84")]
		public LegacyCV2Result<None> GameAIGetUse3DAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "85")]
		public LegacyCV2Result<None> GameAISetUseSpatialAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "86")]
		public LegacyCV2Result<None> GameAIGetIsDopplerEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "87")]
		public LegacyCV2Result<None> GameAISetIsDopplerEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "88")]
		public LegacyCV2Result<None> GameAIGetAreVoiceAndSubtitlesSynced(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "89")]
		public LegacyCV2Result<None> GameAISetAreVoiceAndSubtitlesSynced(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "90")]
		public LegacyCV2Result<None> GameAIGetInstructions(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "91")]
		public LegacyCV2Result<None> GameAIGetWackiness(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "92")]
		public LegacyCV2Result<None> GameAIGetVoice(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "93")]
		public LegacyCV2Result<None> GZUZWRFCTWL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "94")]
		public LegacyCV2Result<None> CCRQUKZEDGP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "95")]
		public LegacyCV2Result<None> NEXRRMQKKVS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "96")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> LEHMYPCIEOE(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "97")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetInstructions(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "98")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetWackiness(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "99")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRequestSetVoiceAndClearContext(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "100")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GameAIRemoveConversationItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "101")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TextToSpeech(FOGDBIUGYXG e, CancellationToken cancellationToken, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "102")]
		public LegacyCV2Result<None> SharedGameAIGetIsSingleSpeakerModeEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "103")]
		public LegacyCV2Result<None> SharedGameAIGetSingleSpeakerModeAudioThreshold(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "104")]
		public LegacyCV2Result<None> SharedGameAISetIsSingleSpeakerModeEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "105")]
		public LegacyCV2Result<None> SharedGameAISetSingleSpeakerModeAudioThreshold(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "106")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ASTPTHYCYXQ(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "107")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> NDRZSWMUYBQ(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "108")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> UWZSPMQNGTT(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "109")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PQEKBAVHMFO(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "110")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JPOZTNHBTTT(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "111")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateTranscriptForAudioRecording(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "112")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AFTNQMBYMHZ(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "113")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateSFX(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "114")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GenAIGenerateMusic(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "115")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> DBFANSKKAUT(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "116")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TRAMNSQNOZI(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1249")]
		public LegacyCV2Result<None> MakeChatAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1250")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestAudioResponse(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1251")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestTextResponse(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1252")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendSystemPrompt(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1254")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserAudioPrompt(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1253")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAISendUserPrompt(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1255")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ChatAIRequestStructuredResponse(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1256")]
		public LegacyCV2Result<None> GetAIFunction(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		public LegacyCV2Result<None> SerializeAIFunctionToStream(Stream stream, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1248120", Offset = "0x1246920", VA = "0x181248120", Slot = "1258")]
		public LegacyCV2Result<CircuitSignal> DeserializeAIFunctionFromStream(Stream stream)
		{
			return default(LegacyCV2Result<CircuitSignal>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "117")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YWETTKRVEPP(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "118")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EDRGEAWNZSS(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "119")]
		public LegacyCV2Result<None> NKYOCTPGVTQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "120")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ZQLMMLNDBDR(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "121")]
		public LegacyCV2Result<None> NHCXYJLEZOX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "122")]
		public LegacyCV2Result<None> NQBWWMULCTN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "123")]
		public LegacyCV2Result<None> QHTSCEJOUUH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "124")]
		public LegacyCV2Result<None> DQKVDEFYUBN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "125")]
		public LegacyCV2Result<None> XMDBNQYBDRZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "126")]
		public LegacyCV2Result<None> UQXTRICLKIY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "128")]
		public LegacyCV2Result<None> GetSampleAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "129")]
		public LegacyCV2Result<None> GetRecRoomAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "130")]
		public LegacyCV2Result<None> GetGenAIAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "131")]
		public LegacyCV2Result<None> AudioGetLength(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "132")]
		public LegacyCV2Result<None> AudioPlayerPlayAudioClip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "133")]
		public LegacyCV2Result<None> AudioPlayerStopAudioClip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "134")]
		public LegacyCV2Result<None> AudioPlayerPauseAudioClip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "135")]
		public LegacyCV2Result<None> AudioPlayerSetVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "136")]
		public LegacyCV2Result<None> AudioPlayerSetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "137")]
		public LegacyCV2Result<None> AudioPlayerSetMaxRolloffDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "138")]
		public LegacyCV2Result<None> AudioPlayerSetTimeStamp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "139")]
		public LegacyCV2Result<None> AudioPlayerGetTimeStamp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "140")]
		public LegacyCV2Result<None> AudioPlayerGetVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "141")]
		public LegacyCV2Result<None> AudioPlayerGetPlaying(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "142")]
		public LegacyCV2Result<None> AudioPlayerGetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "143")]
		public LegacyCV2Result<None> AudioPlayerGetMaxRolloffDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "144")]
		public LegacyCV2Result<None> AudioPlayerGetAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "145")]
		public LegacyCV2Result<None> AudioPlayerGetCurrentVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "146")]
		public LegacyCV2Result<None> PlayAudioAtPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "818")]
		public LegacyCV2Result<None> CBSROQWCCEG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "819")]
		public LegacyCV2Result<None> LXLLNZMHTFM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "147")]
		public LegacyCV2Result<None> WQVFABGKKHY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "148")]
		public LegacyCV2Result<None> GPFRXCOUIYS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "149")]
		public LegacyCV2Result<None> AKELYVNQPWN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "150")]
		public LegacyCV2Result<None> BYTFAVTHPOR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "151")]
		public LegacyCV2Result<None> CZCGRQHYAEQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "152")]
		public LegacyCV2Result<None> ConstantAvatarItem(FOGDBIUGYXG e, InOut io, Guid avatarItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "153")]
		public LegacyCV2Result<None> ConstantRoomBadge(FOGDBIUGYXG e, InOut io, Guid roomBadgeId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "154")]
		public LegacyCV2Result<None> ShowAvatarItemDetails(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "155")]
		public LegacyCV2Result<None> EquipAvatarItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "156")]
		public LegacyCV2Result<None> UnequipAvatarItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomBadge(FOGDBIUGYXG e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, XEFIJRFQQCT.AwardRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasRoomBadge(FOGDBIUGYXG e, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, XEFIJRFQQCT.PlayerHasRoomBadgeReturnOutputMethod outputMethod, CancellationToken cancellation)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "159")]
		public LegacyCV2Result<None> MotionTrailSetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "160")]
		public LegacyCV2Result<None> MotionTrailGetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "161")]
		public LegacyCV2Result<None> MotionTrailSetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "162")]
		public LegacyCV2Result<None> MotionTrailGetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "163")]
		public LegacyCV2Result<None> MotionTrailSetLifetime(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "164")]
		public LegacyCV2Result<None> MotionTrailGetLifetime(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "165")]
		public LegacyCV2Result<None> MotionTrailSetMaxOpacity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "166")]
		public LegacyCV2Result<None> MotionTrailGetMaxOpacity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "167")]
		public LegacyCV2Result<None> ShowUGCBannerNotification(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "168")]
		public LegacyCV2Result<None> BeaconSetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "169")]
		public LegacyCV2Result<None> BeaconGetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "170")]
		public LegacyCV2Result<None> BeaconSetHeight(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "171")]
		public LegacyCV2Result<None> BeaconGetHeight(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "172")]
		public LegacyCV2Result<None> BeaconSetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "173")]
		public LegacyCV2Result<None> BeaconGetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "174")]
		public LegacyCV2Result<None> WNCALBQGDWN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "175")]
		public LegacyCV2Result<None> WKXGWHQPTSW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "176")]
		public LegacyCV2Result<None> HNBTLGFLGCW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "177")]
		public LegacyCV2Result<None> GetLocalCameraForward(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "178")]
		public LegacyCV2Result<None> GetLocalCameraUp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "179")]
		public LegacyCV2Result<None> GetLocalCameraOrientation(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "180")]
		public LegacyCV2Result<None> GetLocalCameraPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "181")]
		public LegacyCV2Result<None> SetCameraShake(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "182")]
		public LegacyCV2Result<None> StopCameraShake(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "183")]
		public LegacyCV2Result<None> SnapCameraImage(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "192")]
		public LegacyCV2Result<None> CollisionDataGetPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "193")]
		public LegacyCV2Result<None> CollisionDataGetObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "194")]
		public LegacyCV2Result<None> CollisionDataGetDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "195")]
		public LegacyCV2Result<None> CollisionDataGetPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "196")]
		public LegacyCV2Result<None> CollisionDataGetNormal(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "197")]
		public LegacyCV2Result<None> EEMTRMFRYHW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "198")]
		public LegacyCV2Result<None> IGROWVUOBHF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "199")]
		public LegacyCV2Result<None> SWVSGNZKUZY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "200")]
		public LegacyCV2Result<None> XROKKQZBVTU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "201")]
		public LegacyCV2Result<None> ZTZXBSZIHBA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "202")]
		public LegacyCV2Result<None> WRBJKLAXBTF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "203")]
		public LegacyCV2Result<None> MDNMMNUBCON(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "204")]
		public LegacyCV2Result<None> QZSDLDZTYDB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "205")]
		public LegacyCV2Result<None> BWVGQUMWWLB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "206")]
		public LegacyCV2Result<None> EDTPXNGBNHR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "207")]
		public LegacyCV2Result<None> DVLCNXPDCQV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "208")]
		public LegacyCV2Result<None> BJJWETHNHVH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "209")]
		public LegacyCV2Result<None> AHOBKCYIMQL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "210")]
		public LegacyCV2Result<None> GLMLJBMMWHU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "211")]
		public LegacyCV2Result<None> UFENNXCIKDV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "212")]
		public LegacyCV2Result<None> KNUHYNAZSDI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "213")]
		public LegacyCV2Result<None> EAUDDPVWGXL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "214")]
		public LegacyCV2Result<None> KYHYGYKJFBA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "215")]
		public LegacyCV2Result<None> AAOIFTMOSNN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "216")]
		public LegacyCV2Result<None> CombatantGetHealthAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "217")]
		public LegacyCV2Result<None> CombatantGetHealthCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "218")]
		public LegacyCV2Result<None> CombatantGetHealthPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "219")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "220")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "221")]
		public LegacyCV2Result<None> CombatantReceiveDamageAI_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "222")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "223")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "224")]
		public LegacyCV2Result<None> CombatantReceiveDamageCombatant_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "225")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "226")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "227")]
		public LegacyCV2Result<None> CombatantReceiveDamagePlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "228")]
		public LegacyCV2Result<None> CombatantSetHealthAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "229")]
		public LegacyCV2Result<None> CombatantSetHealthCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "230")]
		public LegacyCV2Result<None> CombatantSetHealthPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "231")]
		public LegacyCV2Result<None> CombatantSetMaxHealthAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "232")]
		public LegacyCV2Result<None> CombatantSetMaxHealthCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "233")]
		public LegacyCV2Result<None> CombatantSetMaxHealthPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "234")]
		public LegacyCV2Result<None> CombatantGetIsAliveAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "235")]
		public LegacyCV2Result<None> CombatantGetIsAliveCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "236")]
		public LegacyCV2Result<None> CombatantGetIsAlivePlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "237")]
		public LegacyCV2Result<None> CombatantGetGroundPositionAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "238")]
		public LegacyCV2Result<None> CombatantGetGroundPositionCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "239")]
		public LegacyCV2Result<None> CombatantGetVelocityAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "240")]
		public LegacyCV2Result<None> CombatantGetVelocityCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "241")]
		public LegacyCV2Result<None> CombatantGetVelocityPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "242")]
		public LegacyCV2Result<None> CombatantToCombatantAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "243")]
		public LegacyCV2Result<None> CombatantToCombatantPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "244")]
		public LegacyCV2Result<None> CombatantSplit(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "245")]
		public LegacyCV2Result<None> CostumeEquip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "246")]
		public LegacyCV2Result<None> CostumeUnEquip(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "247")]
		public LegacyCV2Result<None> CostumeGetWearer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "248")]
		public LegacyCV2Result<None> STNMonsterCostumeSetMaterial(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "274")]
		public LegacyCV2Result<None> CCMNQRSAIBR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "275")]
		public LegacyCV2Result<None> CreationObjectGetAllWithTagV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "276")]
		public LegacyCV2Result<None> CreationObjectGetAllOfTypeWithTag(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "277")]
		public LegacyCV2Result<None> NJYPLICZPKV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "278")]
		public LegacyCV2Result<None> CreationObjectGetAllChildrenWithTag(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "279")]
		public LegacyCV2Result<None> UWMOTKTOVRO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "280")]
		public LegacyCV2Result<None> AYVYZJWBWPQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "281")]
		public LegacyCV2Result<None> HNPPPAQMFYH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "282")]
		public LegacyCV2Result<None> YNKZSEGGISQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "283")]
		public LegacyCV2Result<None> EDSDXKPTZOB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "284")]
		public LegacyCV2Result<None> IsRecRoomObjectOfType(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "285")]
		public LegacyCV2Result<None> CreationObjectGetLocalScale(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "286")]
		public LegacyCV2Result<None> CreationObjectGetWorldScale(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "287")]
		public LegacyCV2Result<None> ZMTIACEGCLW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "288")]
		public LegacyCV2Result<None> OBTXAKYRNNL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "289")]
		public LegacyCV2Result<None> ToCreationObjectAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "292")]
		public LegacyCV2Result<None> ToCreationObjectAnimationGizmoV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "290")]
		public LegacyCV2Result<None> ToCreationObjectAudioPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "291")]
		public LegacyCV2Result<None> ToCreationObjectAudioFXZone(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "293")]
		public LegacyCV2Result<None> ToCreationObjectMotionTrail(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "294")]
		public LegacyCV2Result<None> ToCreationObjectBeacon(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "295")]
		public LegacyCV2Result<None> ToCreationObjectButton(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "296")]
		public LegacyCV2Result<None> ToCreationObjectContainer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "312")]
		public LegacyCV2Result<None> ToCreationObjectPatrolPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "335")]
		public LegacyCV2Result<None> ToCreationObjectToggleButton(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "337")]
		public LegacyCV2Result<None> ToCreationObjectTriggerVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "321")]
		public LegacyCV2Result<None> ToCreationObjectRoomDoorV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "322")]
		public LegacyCV2Result<None> ToCreationObjectRotator(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "313")]
		public LegacyCV2Result<None> ToCreationObjectPiston(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "339")]
		public LegacyCV2Result<None> ToCreationObjectWelcomeMatV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "328")]
		public LegacyCV2Result<None> ToCreationObjectStudioObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "329")]
		public LegacyCV2Result<None> ToCreationObjectSunDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "304")]
		public LegacyCV2Result<None> ToCreationObjectGroundVehicle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "305")]
		public LegacyCV2Result<None> ToCreationObjectGunHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "307")]
		public LegacyCV2Result<None> ToCreationObjectInteractionVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "314")]
		public LegacyCV2Result<None> ToCreationObjectProjectileLauncher(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "315")]
		public LegacyCV2Result<None> ToCreationObjectPropContainer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "302")]
		public LegacyCV2Result<None> ToCreationObjectExplosionEmitter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "308")]
		public LegacyCV2Result<None> ToCreationObjectInvisibleCollision(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "323")]
		public LegacyCV2Result<None> ToCreationObjectSeat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "324")]
		public LegacyCV2Result<None> ToCreationObjectSnapPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "325")]
		public LegacyCV2Result<None> ToCreationObjectSteeringEngine(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "299")]
		public LegacyCV2Result<None> ToCreationObjectDynamicLight(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "298")]
		public LegacyCV2Result<None> ToCreationObjectDice(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "301")]
		public LegacyCV2Result<None> ToCreationObjectEmitter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "309")]
		public LegacyCV2Result<None> ToCreationObjectLaserPointer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "310")]
		public LegacyCV2Result<None> ToCreationObjectLogScreen(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "311")]
		public LegacyCV2Result<None> ToCreationObjectCollisionDetectionVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "326")]
		public LegacyCV2Result<None> ToCreationObjectSoundEffectGizmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "330")]
		public LegacyCV2Result<None> ToCreationObjectSwingHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "331")]
		public LegacyCV2Result<None> ToCreationObjectTextScreen(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "332")]
		public LegacyCV2Result<None> ToCreationObjectTextTool(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "333")]
		public LegacyCV2Result<None> ToCreationObjectThrowHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "334")]
		public LegacyCV2Result<None> ToCreationObjectTouchpad(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "336")]
		public LegacyCV2Result<None> ToCreationObjectTriggerHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "338")]
		public LegacyCV2Result<None> ToCreationObjectVectorGadget(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "297")]
		public LegacyCV2Result<None> ToCreationObjectCostume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "316")]
		public LegacyCV2Result<None> ToCreationObjectRangedWeapon(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "317")]
		public LegacyCV2Result<None> VXHNXTJEVDQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "318")]
		public LegacyCV2Result<None> ToCreationObjectRemoteVideoPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "319")]
		public LegacyCV2Result<None> ToCreationObjectReplicator(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "306")]
		public LegacyCV2Result<None> ToCreationObjectHolotarProjector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "320")]
		public LegacyCV2Result<None> ToCreationObjectRespawnPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "303")]
		public LegacyCV2Result<None> ToCreationObjectGrabber(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "300")]
		public LegacyCV2Result<None> ToCreationObjectDialogueUI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "327")]
		public LegacyCV2Result<None> ToCreationObjectStorefront(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "340")]
		public LegacyCV2Result<None> ToCreationObjectLeaderboardProjector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "341")]
		public LegacyCV2Result<None> ToCreationObjectGameAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "342")]
		public LegacyCV2Result<None> ToCreationObjectTexturedQuad(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "343")]
		public LegacyCV2Result<None> ToCreationObjectArtCanvas(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "344")]
		public LegacyCV2Result<None> ToCreationObjectMeshPresenter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "345")]
		public LegacyCV2Result<None> ToCreationObjectAvatarItemDisplay(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "346")]
		public LegacyCV2Result<None> ToCreationObjectWearableHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "347")]
		public LegacyCV2Result<None> FromCreationObjectAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "348")]
		public LegacyCV2Result<None> FromCreationObjectAnimationGizmoV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "349")]
		public LegacyCV2Result<None> FromCreationObjectAudioPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "350")]
		public LegacyCV2Result<None> FromCreationObjectAudioFXZone(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "351")]
		public LegacyCV2Result<None> FromCreationObjectMotionTrail(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "352")]
		public LegacyCV2Result<None> FromCreationObjectBeacon(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "353")]
		public LegacyCV2Result<None> FromCreationObjectButton(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "355")]
		public LegacyCV2Result<None> FromCreationObjectContainer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "356")]
		public LegacyCV2Result<None> FromCreationObjectCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "357")]
		public LegacyCV2Result<None> FromCreationObjectDie(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "359")]
		public LegacyCV2Result<None> FromCreationObjectEmitter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "358")]
		public LegacyCV2Result<None> FromCreationObjectDynamicLight(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "367")]
		public LegacyCV2Result<None> FromCreationObjectLaserPointer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "368")]
		public LegacyCV2Result<None> FromCreationObjectLogScreen(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "369")]
		public LegacyCV2Result<None> FromCreationObjectCollisionDetectionVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "370")]
		public LegacyCV2Result<None> FromCreationObjectPatrolPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "371")]
		public LegacyCV2Result<None> FromCreationObjectPiston(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "373")]
		public LegacyCV2Result<None> FromCreationObjectPropContainer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "379")]
		public LegacyCV2Result<None> FromCreationObjectRoomDoorV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "380")]
		public LegacyCV2Result<None> FromCreationObjectRotator(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "384")]
		public LegacyCV2Result<None> FromCreationObjectSoundEffectGizmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "388")]
		public LegacyCV2Result<None> FromCreationObjectSwingHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "389")]
		public LegacyCV2Result<None> FromCreationObjectText(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "390")]
		public LegacyCV2Result<None> FromCreationObjectTextScreen(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "391")]
		public LegacyCV2Result<None> FromCreationObjectThrowHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "392")]
		public LegacyCV2Result<None> FromCreationObjectTouchpad(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "393")]
		public LegacyCV2Result<None> FromCreationObjectToggleButton(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "394")]
		public LegacyCV2Result<None> FromCreationObjectTriggerHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "395")]
		public LegacyCV2Result<None> FromCreationObjectTriggerVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "396")]
		public LegacyCV2Result<None> FromCreationObjectVectorGadget(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "397")]
		public LegacyCV2Result<None> FromCreationObjectWelcomeMatV2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "386")]
		public LegacyCV2Result<None> FromCreationObjectStudioObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "387")]
		public LegacyCV2Result<None> FromCreationObjectSunDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "362")]
		public LegacyCV2Result<None> FromCreationObjectGroundVehicle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "363")]
		public LegacyCV2Result<None> FromCreationObjectGunHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "365")]
		public LegacyCV2Result<None> FromCreationObjectInteractionVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "372")]
		public LegacyCV2Result<None> FromCreationObjectProjectileLauncher(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "360")]
		public LegacyCV2Result<None> FromCreationObjectExplosionEmitter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "366")]
		public LegacyCV2Result<None> FromCreationObjectInvisibleCollision(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "381")]
		public LegacyCV2Result<None> FromCreationObjectSeat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "382")]
		public LegacyCV2Result<None> FromCreationObjectSnapPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "383")]
		public LegacyCV2Result<None> FromCreationObjectSteeringEngine(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "354")]
		public LegacyCV2Result<None> FromCreationObjectCostume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "374")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeapon(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "375")]
		public LegacyCV2Result<None> FromCreationObjectRangedWeaponProp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "376")]
		public LegacyCV2Result<None> FromCreationObjectRemoteVideoPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "377")]
		public LegacyCV2Result<None> FromCreationObjectReplicator(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "364")]
		public LegacyCV2Result<None> FromCreationObjectHolotarProjector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "378")]
		public LegacyCV2Result<None> FromCreationObjectRespawnPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "361")]
		public LegacyCV2Result<None> FromCreationObjectGrabber(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "398")]
		public LegacyCV2Result<None> FromCreationObjectDialogueUI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "385")]
		public LegacyCV2Result<None> FromCreationObjectStorefront(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "399")]
		public LegacyCV2Result<None> FromCreationObjectLeaderboardProjector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "400")]
		public LegacyCV2Result<None> FromCreationObjectGameAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "401")]
		public LegacyCV2Result<None> FromCreationObjectTexturedQuad(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "402")]
		public LegacyCV2Result<None> FromCreationObjectArtCanvas(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "403")]
		public LegacyCV2Result<None> FromCreationObjectMeshPresenter(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "404")]
		public LegacyCV2Result<None> FromCreationObjectAvatarItemDisplay(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "405")]
		public LegacyCV2Result<None> FromCreationObjectWearableHandle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "406")]
		public LegacyCV2Result<None> KCXVTUASVPT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "407")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> BRLAUMNDOZW(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "408")]
		public LegacyCV2Result<None> DiceRollFinished(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "409")]
		public LegacyCV2Result<None> DiceResult(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "410")]
		public LegacyCV2Result<None> DicePlayerRolled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "411")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetDiscoverySectionListFromSource(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "412")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XYUXVAJBJSU(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "413")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> IADCJXDCJOW(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "414")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ECVCTTYVISV(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "415")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FGMOVDPCZSK(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "416")]
		public LegacyCV2Result<RHHVJWXXSEK.CV2DiscoverySectionType> FWCFQPTYXOF(FOGDBIUGYXG e, CircuitSignal a)
		{
			return default(LegacyCV2Result<RHHVJWXXSEK.CV2DiscoverySectionType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "417")]
		public LegacyCV2Result<None> CCGOMCCJVCV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "418")]
		public LegacyCV2Result<None> EmitterStart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "419")]
		public LegacyCV2Result<None> EmitterStop(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "420")]
		public LegacyCV2Result<None> EmitterSetLooping(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "421")]
		public LegacyCV2Result<None> EmitterSetSize(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "422")]
		public LegacyCV2Result<None> EmitterSetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "423")]
		public LegacyCV2Result<None> EmitterSetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "424")]
		public LegacyCV2Result<None> EmitterSetColorNew(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "425")]
		public LegacyCV2Result<None> EmitterGetLooping(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "426")]
		public LegacyCV2Result<None> EmitterGetSize(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "427")]
		public LegacyCV2Result<None> EmitterGetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "428")]
		public LegacyCV2Result<None> EmitterGetPlaying(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "429")]
		public LegacyCV2Result<None> ConstantEquipmentSlot(FOGDBIUGYXG e, InOut io, int slotNumber)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "430")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> VXYXTHWMEMN(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "431")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HRAJAOMKJFM(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "432")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QMVWBHNOYWL(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "433")]
		public LegacyCV2Result<None> PlayerSetEquipmentSlotEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "434")]
		public LegacyCV2Result<None> PlayerGetEquipmentSlotIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "435")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EquipmentSlotEmphasize(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "436")]
		public LegacyCV2Result<None> GetFriendlyNameAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "437")]
		public LegacyCV2Result<None> GetFriendlyNameAIFunction(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "438")]
		public LegacyCV2Result<None> GetFriendlyNameAvatarItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "185")]
		public LegacyCV2Result<None> GetFriendlyNameColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "442")]
		public LegacyCV2Result<None> GetFriendlyNameConsumable(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "439")]
		public LegacyCV2Result<None> GetFriendlyNameCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "440")]
		public LegacyCV2Result<None> GetFriendlyNameCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "441")]
		public LegacyCV2Result<None> GetFriendlyNamePlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "443")]
		public LegacyCV2Result<None> GetFriendlyNameDestination(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "444")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerEvent(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "445")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerOutfitSlotFlag(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "446")]
		public LegacyCV2Result<None> GetFriendlyNameRoomKey(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "447")]
		public LegacyCV2Result<None> GetFriendlyNameAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "448")]
		public LegacyCV2Result<None> GetFriendlyNameReward(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "449")]
		public LegacyCV2Result<None> GetFriendlyNameGiftDropShopItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "450")]
		public LegacyCV2Result<None> GetFriendlyNameRoomCurrency(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "451")]
		public LegacyCV2Result<None> GetFriendlyNameInventoryItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "452")]
		public LegacyCV2Result<None> GetFriendlyNameQuickChatTable(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "453")]
		public LegacyCV2Result<None> GetFriendlyNameRoomBadge(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "454")]
		public LegacyCV2Result<None> GetFriendlyNameRoomOffer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "455")]
		public LegacyCV2Result<None> GetFriendlyNameDiscoverySection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "456")]
		public LegacyCV2Result<None> GetFriendlyNameStoreItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "457")]
		public LegacyCV2Result<None> GetFriendlyNameProjectile(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "458")]
		public LegacyCV2Result<None> GetFriendlyNameCollisionData(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "459")]
		public LegacyCV2Result<None> GetFriendlyNameParticleVfx(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "460")]
		public LegacyCV2Result<None> GetFriendlyNameBodyPart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "461")]
		public LegacyCV2Result<None> GetFriendlyNamePlayerAccount(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "462")]
		public LegacyCV2Result<None> HLJWNPIQNHA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "463")]
		public LegacyCV2Result<None> WNCHTBDXSTN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "464")]
		public LegacyCV2Result<None> JYXTIBCNUII(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "465")]
		public LegacyCV2Result<None> BPEGZIOGTIR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "466")]
		public LegacyCV2Result<None> WWVUJLPIHSJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "467")]
		public LegacyCV2Result<None> YCKWGGCMWGL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "468")]
		public LegacyCV2Result<None> GAAVAKESVAU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "469")]
		public LegacyCV2Result<None> MUYWYWQCSYK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "474")]
		public LegacyCV2Result<None> DYYUDVXBNSU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "475")]
		public LegacyCV2Result<None> GRNBIEMGNEA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "476")]
		public LegacyCV2Result<None> VGNGKDPFENX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "477")]
		public LegacyCV2Result<None> YIMSZZDQQOU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "478")]
		public LegacyCV2Result<None> MRXPMAVAAFW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "479")]
		public LegacyCV2Result<None> JEGTIIGBYDP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "470")]
		public LegacyCV2Result<None> SetLocalPlayerLeaderboardStat(FOGDBIUGYXG executionScope, InOut io, int setMode)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "471")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerLeaderboardStat(FOGDBIUGYXG executionScope, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "472")]
		public LegacyCV2Result<None> VGUJHBZGHCT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "473")]
		public LegacyCV2Result<None> IMSIQZGSJVJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "480")]
		public LegacyCV2Result<None> ISXUDQQJTXR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "481")]
		public LegacyCV2Result<None> PPRNJQMTEVV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "482")]
		public LegacyCV2Result<None> GDJGJVVVDKI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "483")]
		public LegacyCV2Result<None> FKHVBNDQIRA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "484")]
		public LegacyCV2Result<None> ZLDBPACKBUY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "485")]
		public LegacyCV2Result<None> ACUHKKBNXBS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "486")]
		public LegacyCV2Result<None> KUGUIXWKSWC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "487")]
		public LegacyCV2Result<None> CNNDNZDGQIY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "488")]
		public LegacyCV2Result<None> QUXHJXDLHQK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "489")]
		public LegacyCV2Result<None> MJPDAVYKKGG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "490")]
		public LegacyCV2Result<None> AQKUAAYBYNW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "491")]
		public LegacyCV2Result<None> EDVVOTWVRME(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "492")]
		public LegacyCV2Result<None> ELGUIPOIGGG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "493")]
		public LegacyCV2Result<None> MDVVXSZJQPY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "494")]
		public LegacyCV2Result<None> FXOQSYXRSDA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "495")]
		public LegacyCV2Result<None> AHXFFKQJIUM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "496")]
		public LegacyCV2Result<None> NHLYSASEFYQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "497")]
		public LegacyCV2Result<None> MJDHDQRQMTW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "498")]
		public LegacyCV2Result<None> HQUKAENNKFE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "499")]
		public LegacyCV2Result<None> IVUWZDIYYCA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x283F040", Offset = "0x283D840", VA = "0x18283F040", Slot = "500")]
		public LegacyCV2Result<None> SendLogString(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "501")]
		public LegacyCV2Result<None> LerpColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "502")]
		public LegacyCV2Result<None> LerpUnclampedColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "503")]
		public LegacyCV2Result<None> InverseLerpVec3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "504")]
		public LegacyCV2Result<None> InverseLerpUnclampedVec3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "505")]
		public LegacyCV2Result<None> InverseLerpColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "506")]
		public LegacyCV2Result<None> InverseLerpUnclampedColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "507")]
		public LegacyCV2Result<None> NVUOBCXCWWK(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "508")]
		public LegacyCV2Result<None> IVIBAQMNPLG(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "509")]
		public LegacyCV2Result<None> QFRNDXRRNLS(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "510")]
		public LegacyCV2Result<None> ODXAPWMXAOP(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "511")]
		public LegacyCV2Result<None> CollisionDetectionVolumeSetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "512")]
		public LegacyCV2Result<None> CollisionDetectionVolumeGetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "513")]
		public LegacyCV2Result<None> FogConstantValues(FOGDBIUGYXG e, InOut io, int color, float startDistance, float fadeDistance)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "514")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModify(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "515")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogReset(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "516")]
		public LegacyCV2Result<None> SunConstantValues(FOGDBIUGYXG e, InOut io, int sunColor, float sunIntensity, float shadowStrength, float discSize, float reflectionIntensity, int glowColor, float glowSize, float glowStrength, float glowHorizon, bool clipHorizon)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "517")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModify(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "518")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunReset(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "519")]
		public LegacyCV2Result<None> BackgroundObjectsConstantValues(FOGDBIUGYXG e, InOut io, IReadOnlyList<BackgroundObjectsConstantNode.ANHBYRFHALA> configs)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "520")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModify(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "521")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsReset(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "522")]
		public LegacyCV2Result<None> BKSWUIVDGPH(FOGDBIUGYXG e, InOut a, int b, int c, int d, int e, int f, float g, float h)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "523")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModify(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "524")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeReset(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "525")]
		public LegacyCV2Result<None> VVXYJQSUGCB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "526")]
		public LegacyCV2Result<None> TextScreenClearScreen(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "527")]
		public LegacyCV2Result<None> KGFXJFXXGXM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "528")]
		public LegacyCV2Result<None> YVVZITVAYZG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "529")]
		public LegacyCV2Result<None> CreationObjectGetIsLocalPlayerAuthority(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "530")]
		public LegacyCV2Result<None> JKIXLELWGBK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "531")]
		public LegacyCV2Result<None> TWSEVHYUFWD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x283EF20", Offset = "0x283D720", VA = "0x18283EF20", Slot = "532")]
		public LegacyCV2Result<None> GetLocalPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "533")]
		public LegacyCV2Result<None> EMOQHWKSRXN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x283F080", Offset = "0x283D880", VA = "0x18283F080", Slot = "535")]
		public LegacyCV2Result<None> VPVOEPXBAXL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "534")]
		public LegacyCV2Result<None> VCULQURDJGC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "536")]
		public LegacyCV2Result<None> NBMSDJAGQBY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "537")]
		public LegacyCV2Result<None> PGLQUDUBKGN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "538")]
		public LegacyCV2Result<None> UTSSJHSKQYT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "539")]
		public LegacyCV2Result<None> EZKCLFBOHMP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "540")]
		public LegacyCV2Result<None> BXSOBRKKSDP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "541")]
		public LegacyCV2Result<None> DistanceAI_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "542")]
		public LegacyCV2Result<None> DistanceAI_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "543")]
		public LegacyCV2Result<None> DistanceAI_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "544")]
		public LegacyCV2Result<None> DistanceAI_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "545")]
		public LegacyCV2Result<None> DistanceAI_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "546")]
		public LegacyCV2Result<None> DistanceCombatant_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "547")]
		public LegacyCV2Result<None> DistanceCombatant_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "548")]
		public LegacyCV2Result<None> DistanceCombatant_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "549")]
		public LegacyCV2Result<None> DistanceCombatant_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "550")]
		public LegacyCV2Result<None> DistanceCombatant_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "551")]
		public LegacyCV2Result<None> DistanceCreationObject_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "552")]
		public LegacyCV2Result<None> DistanceCreationObject_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "553")]
		public LegacyCV2Result<None> DistanceCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "554")]
		public LegacyCV2Result<None> DistanceCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "555")]
		public LegacyCV2Result<None> DistanceCreationObject_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "556")]
		public LegacyCV2Result<None> DistancePlayer_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "557")]
		public LegacyCV2Result<None> DistancePlayer_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "558")]
		public LegacyCV2Result<None> DistancePlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "559")]
		public LegacyCV2Result<None> DistancePlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "560")]
		public LegacyCV2Result<None> DistancePlayer_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "561")]
		public LegacyCV2Result<None> DistanceVector3_AI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "562")]
		public LegacyCV2Result<None> DistanceVector3_Combatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "563")]
		public LegacyCV2Result<None> DistanceVector3_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "564")]
		public LegacyCV2Result<None> DistanceVector3_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "565")]
		public LegacyCV2Result<None> DistanceVector3_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "566")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "567")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "568")]
		public LegacyCV2Result<None> GetClosestOrFarthest_CreationObject_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "569")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "570")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "571")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Player_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "572")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "573")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "574")]
		public LegacyCV2Result<None> GetClosestOrFarthest_Vector3_Vector3(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "575")]
		public LegacyCV2Result<None> GetPositionCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "576")]
		public LegacyCV2Result<None> GetPositionCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "577")]
		public LegacyCV2Result<None> GetPositionPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "578")]
		public LegacyCV2Result<None> GetPositionPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "579")]
		public LegacyCV2Result<None> GetPositionAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "580")]
		public LegacyCV2Result<None> GetPositionCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "581")]
		public LegacyCV2Result<None> GetPositionCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "582")]
		public LegacyCV2Result<None> GetPositionPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "583")]
		public LegacyCV2Result<None> Raycast(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "584")]
		public LegacyCV2Result<None> JNDDJGOBQHI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "585")]
		public LegacyCV2Result<None> RaycastAll(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "586")]
		public LegacyCV2Result<None> Spherecast(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "587")]
		public LegacyCV2Result<None> ARSZNZTYLYF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "588")]
		public LegacyCV2Result<None> SpherecastAll(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "589")]
		public LegacyCV2Result<None> OverlapSphere(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "590")]
		public LegacyCV2Result<None> OverlapBox(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "591")]
		public LegacyCV2Result<None> WRJKSQOAKYI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "592")]
		public LegacyCV2Result<None> MGJDATWZCCT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "593")]
		public LegacyCV2Result<None> SetPositionPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "594")]
		public LegacyCV2Result<None> SetPositionCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "595")]
		public LegacyCV2Result<None> SetPositionPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "596")]
		public LegacyCV2Result<None> SetPositionPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "597")]
		public LegacyCV2Result<None> SetPositionCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "598")]
		public LegacyCV2Result<None> SetPositionCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "600")]
		public LegacyCV2Result<None> RespawnPlayerRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "601")]
		public LegacyCV2Result<None> RespawnPlayerRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "602")]
		public LegacyCV2Result<None> RespawnCreationObjectRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "603")]
		public LegacyCV2Result<None> RespawnCreationObjectRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "604")]
		public LegacyCV2Result<None> SetRotationPlayerRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "605")]
		public LegacyCV2Result<None> SetRotationPlayerRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "606")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "607")]
		public LegacyCV2Result<None> SetRotationCreationObjectRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "608")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "609")]
		public LegacyCV2Result<None> SetRotationRotQuatPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "610")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "611")]
		public LegacyCV2Result<None> SetRotationRotVecPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "612")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "613")]
		public LegacyCV2Result<None> SetRotationRotQuatCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "614")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "615")]
		public LegacyCV2Result<None> SetRotationRotVecCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "616")]
		public LegacyCV2Result<None> SetTransformPlayerRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "617")]
		public LegacyCV2Result<None> SetTransformPlayerRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "618")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotQuat(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "619")]
		public LegacyCV2Result<None> SetTransformCreationObjectRotVec(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "620")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "621")]
		public LegacyCV2Result<None> SetTransformRotQuatPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "622")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "623")]
		public LegacyCV2Result<None> SetTransformRotVecPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "624")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "625")]
		public LegacyCV2Result<None> SetTransformRotQuatCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "626")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "627")]
		public LegacyCV2Result<None> SetTransformRotVecCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "628")]
		public LegacyCV2Result<None> PistonGetDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "629")]
		public LegacyCV2Result<None> PistonSetDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "630")]
		public LegacyCV2Result<None> PistonGetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "631")]
		public LegacyCV2Result<None> PistonGetSpeed_DEPRECATED(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "632")]
		public LegacyCV2Result<None> PistonSetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "633")]
		public LegacyCV2Result<None> PistonSetSpeed_DEPRECATED(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "634")]
		public LegacyCV2Result<None> PistonGetAcceleration(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "635")]
		public LegacyCV2Result<None> PistonSetAcceleration(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "636")]
		public LegacyCV2Result<None> PistonSetAcceleration_DEPRECATED(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "637")]
		public LegacyCV2Result<None> PistonGetMaxDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "638")]
		public LegacyCV2Result<None> PistonSetMaxDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "639")]
		public LegacyCV2Result<None> PistonGetTargetDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "640")]
		public LegacyCV2Result<None> PistonSetTargetDistance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "641")]
		public LegacyCV2Result<None> TMOXEODIFUY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "642")]
		public LegacyCV2Result<None> GEAJABTSEGA(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "643")]
		public LegacyCV2Result<None> FCFTWICIVUB(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "644")]
		public LegacyCV2Result<None> CSWOHOKVQJU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "645")]
		public LegacyCV2Result<None> VDZOUVIMWAK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "646")]
		public LegacyCV2Result<None> KCIGUVSWVYL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "647")]
		public LegacyCV2Result<None> PlayerAddRole(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "648")]
		public LegacyCV2Result<None> PlayerRemoveRole(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "649")]
		public LegacyCV2Result<None> QJXYMAGYJOY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "650")]
		public LegacyCV2Result<None> XLRXUOQBBKI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "651")]
		public LegacyCV2Result<None> WSRAACNZONL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "652")]
		public LegacyCV2Result<None> PlayerLeftHandPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "653")]
		public LegacyCV2Result<None> PlayerRightHandPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "654")]
		public LegacyCV2Result<None> PlayerLeftHandFingerDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "655")]
		public LegacyCV2Result<None> PlayerLeftHandThumbDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "656")]
		public LegacyCV2Result<None> PlayerRightHandFingerDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "657")]
		public LegacyCV2Result<None> PlayerRightHandThumbDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "658")]
		public LegacyCV2Result<None> PlayerLeftHandVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "659")]
		public LegacyCV2Result<None> PlayerRightHandVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "661")]
		public LegacyCV2Result<None> ELCDXYLNBDM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "660")]
		public LegacyCV2Result<None> VMXPANPRPDP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "662")]
		public LegacyCV2Result<None> USJLREWZRGU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "663")]
		public LegacyCV2Result<None> MYAUIDTTTTB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "664")]
		public LegacyCV2Result<None> PlayerHeadPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "665")]
		public LegacyCV2Result<None> PlayerHeadOrientation(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "666")]
		public LegacyCV2Result<None> PlayerHeadForwardVector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "667")]
		public LegacyCV2Result<None> PlayerHeadUpVector(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "668")]
		public LegacyCV2Result<None> PlayerHeadVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "669")]
		public LegacyCV2Result<None> PlayerHeadHeight(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "670")]
		public LegacyCV2Result<None> IAZHWDPPHQE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "671")]
		public LegacyCV2Result<None> FSYXTFKFYIL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "672")]
		public LegacyCV2Result<None> PlayerBodyPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "673")]
		public LegacyCV2Result<None> PlayerBodyOrientation(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "674")]
		public LegacyCV2Result<None> YEEZWAVSLJL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "675")]
		public LegacyCV2Result<None> LFVANUTERBO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "703")]
		public LegacyCV2Result<None> LocalPlayerDisableInteractionWithTargetPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "708")]
		public LegacyCV2Result<None> ConstantPlayerOutfitSlotFlag(FOGDBIUGYXG e, InOut io, int outfitSlotFlag)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "694")]
		public LegacyCV2Result<None> PlayerEquipObjectDominantHand(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "695")]
		public LegacyCV2Result<None> PlayerEquipObjectOffHand(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "696")]
		public LegacyCV2Result<None> CSNTSPYOIJI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "697")]
		public LegacyCV2Result<None> WEOWTCXXPMI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "698")]
		public LegacyCV2Result<None> OYXYAACHAGE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "699")]
		public LegacyCV2Result<None> IQGIFHEGFSD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "700")]
		public LegacyCV2Result<None> AYKRLFLGSPV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "701")]
		public LegacyCV2Result<None> PlayerGetCostume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "702")]
		public LegacyCV2Result<None> LocalPlayerEnableInteractionWithTargetPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "676")]
		public LegacyCV2Result<None> KNALMKXFAAA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "677")]
		public LegacyCV2Result<None> BFZCSCDJWEO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "678")]
		public LegacyCV2Result<None> UCQVZHGQBWD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "679")]
		public LegacyCV2Result<None> AGBODDBFSLA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "680")]
		public LegacyCV2Result<None> NJAEEGJMVKJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "681")]
		public LegacyCV2Result<None> DAFXDVRZLYY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "682")]
		public LegacyCV2Result<None> GAPACFNJEZQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "683")]
		public LegacyCV2Result<None> ARWULOBXFBF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "684")]
		public LegacyCV2Result<None> JJDBWDBWLSX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "685")]
		public LegacyCV2Result<None> WUIICJTNSBQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "686")]
		public LegacyCV2Result<None> CXHSZTYZRYQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "687")]
		public LegacyCV2Result<None> VBBUSWQAJGJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "688")]
		public LegacyCV2Result<None> SQXBIUVIDHY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "689")]
		public LegacyCV2Result<None> DKUSXIHXWHE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "690")]
		public LegacyCV2Result<None> OUCVFGOFLBN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "691")]
		public LegacyCV2Result<None> XENCVAMZATL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "692")]
		public LegacyCV2Result<None> XEZKPPSLCJN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "693")]
		public LegacyCV2Result<None> DEFKUTOLKQM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "704")]
		public LegacyCV2Result<None> PlayerGetRoomIndex(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "705")]
		public LegacyCV2Result<None> RoomIndexGetPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "765")]
		public LegacyCV2Result<None> VBVSBKUMNII(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "766")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptTextDialog(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "767")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerSendPromptMultipleChoiceDialog(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "709")]
		public LegacyCV2Result<None> PlayerEquipShareCameraDominantHand(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "710")]
		public LegacyCV2Result<None> PlayerGetShareCameraIsSpawned(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "711")]
		public LegacyCV2Result<None> YBBWWLQOKSN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "712")]
		public LegacyCV2Result<None> TYSQVXJHBSL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "713")]
		public LegacyCV2Result<None> UCCQFACXKUF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "714")]
		public LegacyCV2Result<None> FGGKMOORBRB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "715")]
		public LegacyCV2Result<None> PlayerGetSteeringDirection(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "716")]
		public LegacyCV2Result<None> PlayerGetSteeringSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "717")]
		public LegacyCV2Result<None> RWZMHIVLPHF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "718")]
		public LegacyCV2Result<None> PlayerGetPhysicsVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "719")]
		public LegacyCV2Result<None> PlayerSetPhysicsVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "720")]
		public LegacyCV2Result<None> PlayerSetSteeringVelocity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "721")]
		public LegacyCV2Result<None> WMQOLHTZQTE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "722")]
		public LegacyCV2Result<None> BVEPFDRQQVO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "723")]
		public LegacyCV2Result<None> CWUIQPWPRZR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "724")]
		public LegacyCV2Result<None> WKZSAOEXINT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "725")]
		public LegacyCV2Result<None> KGNDIUPOXIR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "726")]
		public LegacyCV2Result<None> XYXTFAISCCE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "727")]
		public LegacyCV2Result<None> QFUHDKUIBGF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "728")]
		public LegacyCV2Result<None> UVRURTHDVLG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "729")]
		public LegacyCV2Result<None> JGYDNMQGOLG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "730")]
		public LegacyCV2Result<None> COLVDRFHBDC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "731")]
		public LegacyCV2Result<None> BLUOFTSTRKE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "732")]
		public LegacyCV2Result<None> RYBNBJJSAGE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "733")]
		public LegacyCV2Result<None> UHGWVSEWWZY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "734")]
		public LegacyCV2Result<None> SKOHAWXIIUZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "735")]
		public LegacyCV2Result<None> TTPSILDDKLW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "736")]
		public LegacyCV2Result<None> LKHKZUJYFFI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "737")]
		public LegacyCV2Result<None> APJHQKMITPX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "738")]
		public LegacyCV2Result<None> ZMPBCOKLZES(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "740")]
		public LegacyCV2Result<None> EBQTXFMYXWM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "739")]
		public LegacyCV2Result<None> HCHUOTWCWUW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "741")]
		public LegacyCV2Result<None> HSJQFEIOPLB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "742")]
		public LegacyCV2Result<None> FWTRNHZUQKK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "743")]
		public LegacyCV2Result<None> KPIPBVCATHD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "744")]
		public LegacyCV2Result<None> ZQOYSBOTEVX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "745")]
		public LegacyCV2Result<None> ERETEEONJXO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "746")]
		public LegacyCV2Result<None> BKLPXQWUOPH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "747")]
		public LegacyCV2Result<None> LWQKJYBDZHD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "748")]
		public LegacyCV2Result<None> GADVGHZIOTI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "749")]
		public LegacyCV2Result<None> WSDTQQSVRQY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "750")]
		public LegacyCV2Result<None> GNAWFPBJHNY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "751")]
		public LegacyCV2Result<None> GFAUOTBBKCG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "752")]
		public LegacyCV2Result<None> EAUKZRBMHIE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "753")]
		public LegacyCV2Result<None> GLWCBKQSTAE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "754")]
		public LegacyCV2Result<None> SHTAFHJDHWQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "755")]
		public LegacyCV2Result<None> DNQEAYPRZKJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "756")]
		public LegacyCV2Result<None> KNVGGIUSSIV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "757")]
		public LegacyCV2Result<None> PSAOHHZPQXB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "758")]
		public LegacyCV2Result<None> LBWDQAUXXBX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "759")]
		public LegacyCV2Result<None> ZVPRZMORCQC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "760")]
		public LegacyCV2Result<None> GKVPTNOCNOG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "761")]
		public LegacyCV2Result<None> XKPYDPSVRWS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "762")]
		public LegacyCV2Result<None> NMGSXSBKSAT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "763")]
		public LegacyCV2Result<None> ADNLISDBIVX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "764")]
		public LegacyCV2Result<None> MCISBZDIVTA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "768")]
		public LegacyCV2Result<None> PlayerGetIsCustomFootstepAudioActive(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "769")]
		public LegacyCV2Result<None> LocalPlayerGetRRPlusStatus(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "770")]
		public LegacyCV2Result<None> LocalPlayerSetPlayerNametagVisibility(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "771")]
		public LegacyCV2Result<None> HEQFPJZJFPM(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "772")]
		public LegacyCV2Result<None> RBMQJIILOFW(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "773")]
		public LegacyCV2Result<None> UCRYPNXXEUN(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "774")]
		public LegacyCV2Result<None> LocalPlayerGetTokenBalance(FOGDBIUGYXG ek, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "775")]
		public LegacyCV2Result<None> BLANMOKUSFR(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "776")]
		public LegacyCV2Result<None> UOWIZEMYJWF(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "777")]
		public LegacyCV2Result<None> ANAXSUGIYDW(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "778")]
		public LegacyCV2Result<None> EZUERSCIERO(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "779")]
		public LegacyCV2Result<None> NCBWLXQEHEW(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "706")]
		public LegacyCV2Result<None> PlayerGetProfileImage(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "707")]
		public LegacyCV2Result<None> DGFENCUDGTU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "780")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountByName(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "781")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerAccountFromPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "782")]
		public LegacyCV2Result<None> PlayerAccountGetDetails(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "783")]
		public LegacyCV2Result<None> ShowPlayerProfile(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "784")]
		public LegacyCV2Result<None> ShowPlayerPortfolio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "785")]
		public LegacyCV2Result<None> GetBroadcastingAttendance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "786")]
		public LegacyCV2Result<None> RequestPostGameRewards(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "787")]
		public LegacyCV2Result<None> SetPlayerWorldUI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "788")]
		public LegacyCV2Result<None> ClearPlayerWorldUI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "789")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "790")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "791")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarValue(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "792")]
		public LegacyCV2Result<None> SetPlayerWorldUIPrimaryBarMaxValue(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "793")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "794")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "795")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarValue(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "796")]
		public LegacyCV2Result<None> SetPlayerWorldUISecondaryBarMaxValue(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "797")]
		public LegacyCV2Result<None> SetPlayerWorldUITextEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "798")]
		public LegacyCV2Result<None> SetPlayerWorldUITextText(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "799")]
		public LegacyCV2Result<None> SetPlayerWorldUITextColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "800")]
		public LegacyCV2Result<None> ResetPlayerWorldUI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "801")]
		public LegacyCV2Result<None> GRCLBLYWJIS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "802")]
		public LegacyCV2Result<None> WXAGLTTCRXY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "803")]
		public LegacyCV2Result<None> PBLMVZIFKHY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "804")]
		public LegacyCV2Result<None> YTMHQFEYFMU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "805")]
		public LegacyCV2Result<None> RWZCMWCFIIO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "806")]
		public LegacyCV2Result<None> YBLDHLLOPHQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "807")]
		public LegacyCV2Result<None> CMDYRKHVXBA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "808")]
		public LegacyCV2Result<None> DMAGFCHBLPG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "809")]
		public LegacyCV2Result<None> LHEFEYKTXVI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "810")]
		public LegacyCV2Result<None> RUITVWAWEDQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "811")]
		public LegacyCV2Result<None> VWKYOUDGVYU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "812")]
		public LegacyCV2Result<None> SVQQDRRPTDB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "813")]
		public LegacyCV2Result<None> SetPlayerRadioChannel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "814")]
		public LegacyCV2Result<None> RemovePlayerFromRadioChannel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "815")]
		public LegacyCV2Result<None> GetPlayerRadioChannel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "816")]
		public LegacyCV2Result<None> GetPlayersInRadioChannel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "817")]
		public LegacyCV2Result<None> URKPHDCDMAI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "820")]
		public LegacyCV2Result<None> GetProjectile(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "821")]
		public LegacyCV2Result<None> TJZGXSBFYGX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "822")]
		public LegacyCV2Result<None> DDFDDYEPEZD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "823")]
		public LegacyCV2Result<None> JGGYHQQWYER(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "824")]
		public LegacyCV2Result<None> TISXCAPBBVV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "825")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> ReplicatorSpawnNextObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "826")]
		public LegacyCV2Result<None> EGJCLUQKOIX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "827")]
		public LegacyCV2Result<None> HODLFXKJIOU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "828")]
		public LegacyCV2Result<None> SVMNVGSPSZQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "829")]
		public LegacyCV2Result<None> ResetRoom(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "830")]
		public LegacyCV2Result<None> ResetObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "831")]
		public LegacyCV2Result<None> VQJPHVZVTAK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "832")]
		public LegacyCV2Result<None> HXORXTQQWBF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "833")]
		public LegacyCV2Result<None> ASLZDFXQSNA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "834")]
		public LegacyCV2Result<None> ConstantReward(FOGDBIUGYXG e, InOut io, Guid rewardId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "835")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardReward(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "127")]
		public LegacyCV2Result<None> RoomieAIQueueRequestResponse(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "836")]
		public LegacyCV2Result<None> CJDLUSWJHFD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "837")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> HDUBENHCFJJ(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "838")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> JGGEEXBMROP(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "839")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> FHIOOSOWKLE(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "840")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> TEJJEDQSPSX(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "841")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> EXVDAJVEJCE(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "842")]
		public LegacyCV2Result<None> ActivateConsumable(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "843")]
		public LegacyCV2Result<None> DeactivateConsumable(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "844")]
		public LegacyCV2Result<None> ConstantConsumable(FOGDBIUGYXG e, InOut io, Guid consumableId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "845")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomConsumable(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "846")]
		public LegacyCV2Result<None> ShowPurchasePromptConsumable(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "847")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateCostumeForLocalPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "848")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CustomConsumableCreateTrinketForLocalPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "849")]
		public LegacyCV2Result<None> ConstantRoomKey(FOGDBIUGYXG e, InOut io, Guid roomKeyId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "850")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsRoomKey(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "851")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardRoomKey(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "852")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomKey(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "853")]
		public LegacyCV2Result<None> ConstantInventoryItem(FOGDBIUGYXG e, InOut io, Guid inventoryItemId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "854")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AddInventoryItem(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "855")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RemoveInventoryItem(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "856")]
		public LegacyCV2Result<None> HQJTIJZJJHD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "857")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerOwnsInventoryItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "858")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetInventoryItemCount(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "859")]
		public LegacyCV2Result<None> JWITSXIXMGN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "860")]
		public LegacyCV2Result<None> JPQDFJAGCJB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "861")]
		public LegacyCV2Result<None> DJSFAKMBINT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "862")]
		public LegacyCV2Result<None> OPREEVRWJAA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "863")]
		public LegacyCV2Result<None> GetAllInventoryItemsWithTagNode(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "864")]
		public LegacyCV2Result<None> QYHWWLZFLJT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "865")]
		public LegacyCV2Result<None> AEPXGOIDOXD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "866")]
		public LegacyCV2Result<None> ConstantRoomOffer(FOGDBIUGYXG e, InOut io, Guid roomOfferId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "867")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomOffer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "868")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerHasPurchasedRoomOffer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "869")]
		public LegacyCV2Result<None> ZAXFAVMPKAX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "870")]
		public LegacyCV2Result<None> GetRoomOfferDynamicPriceValues(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "871")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferImageOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "872")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferImageOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "873")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferDescriptionOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "874")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferDescriptionOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "875")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferPriceOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "876")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferPriceOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "877")]
		public LegacyCV2Result<None> LocalPlayerSetRoomOfferNameOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "878")]
		public LegacyCV2Result<None> LocalPlayerClearRoomOfferNameOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "879")]
		public LegacyCV2Result<None> VEALQLGGBBP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "880")]
		public LegacyCV2Result<None> RXTSAXWZION(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "881")]
		public LegacyCV2Result<None> YFXYOOEUPQM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "882")]
		public LegacyCV2Result<None> WAQRTPAPKUR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "883")]
		public LegacyCV2Result<None> ConstantRoomCurrency(FOGDBIUGYXG e, InOut io, Guid currencyReplicationId)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "884")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(FOGDBIUGYXG e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "885")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> AwardCurrency(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "886")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(FOGDBIUGYXG e, InOut io, Guid currencyReplicationId, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "887")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetBalance(FOGDBIUGYXG e, InOut io, bool logOutput)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "888")]
		public LegacyCV2Result<None> ShowPurchasePromptRoomCurrency(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "889")]
		public LegacyCV2Result<None> DBLZZAXPSFN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "890")]
		public LegacyCV2Result<None> YNRIFNAMUPO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "891")]
		public LegacyCV2Result<None> LPWRRLUKTID(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "892")]
		public LegacyCV2Result<None> ITVCPJTBHIL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "893")]
		public LegacyCV2Result<None> SADHHQZYQHL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "894")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> SetIsRoomInstanceMatchmakingAllowed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "895")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> QueueNotification(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "896")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> CancelNotification(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "897")]
		public LegacyCV2Result<None> XLVZSXFEANE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "898")]
		public LegacyCV2Result<None> TYHQLYHYJZM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "899")]
		public LegacyCV2Result<None> GNCKLUQQYFX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "901")]
		public LegacyCV2Result<None> ENKIUCVSAAN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "900")]
		public LegacyCV2Result<None> GSBFHQEBZTF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "902")]
		public LegacyCV2Result<None> HTRVIRSPUZE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "904")]
		public LegacyCV2Result<None> WOBXSYORNAO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "903")]
		public LegacyCV2Result<None> EVJJAVHQQLY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "905")]
		public LegacyCV2Result<None> MWAZABZZBZF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "906")]
		public LegacyCV2Result<None> GPMCYKBQXZZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "907")]
		public LegacyCV2Result<None> AYVPUDYZEAY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "908")]
		public LegacyCV2Result<None> TAJBHEXBILA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "909")]
		public LegacyCV2Result<None> HIOSLOSJFHK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "910")]
		public LegacyCV2Result<None> VDHFOBIWWFS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "911")]
		public LegacyCV2Result<None> PDGOYAVSVVC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "912")]
		public LegacyCV2Result<None> AllowDressUp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "913")]
		public LegacyCV2Result<None> ForbidDressUp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "914")]
		public LegacyCV2Result<None> OpenStore(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "915")]
		public LegacyCV2Result<None> OpenCheckout(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "916")]
		public LegacyCV2Result<None> GetShoppingBagQuantity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "917")]
		public LegacyCV2Result<None> GetTrialItemQuantity(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "918")]
		public LegacyCV2Result<None> ODYDHILWXIO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "919")]
		public LegacyCV2Result<None> DPVWJGOTLWA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "920")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerPurchaseGiftDropForRROCurrencyNode(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "921")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GetPlayerRROCurrencyBalance(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "922")]
		public LegacyCV2Result<None> StorefrontGetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "923")]
		public LegacyCV2Result<None> StorefrontSetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "924")]
		public LegacyCV2Result<None> StorefrontGetOffersList(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "925")]
		public LegacyCV2Result<None> StorefrontSetOffersList(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "926")]
		public LegacyCV2Result<None> SetDiscoveryStorefrontItems(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "927")]
		public LegacyCV2Result<None> ShowPurchasePromptStoreItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "928")]
		public LegacyCV2Result<None> GetStoreItemDetails(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "929")]
		public LegacyCV2Result<None> LocalPlayerGetStoreItemOwned(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "930")]
		public LegacyCV2Result<None> MannequinSetStoreItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "931")]
		public LegacyCV2Result<None> ShowWatchStoreRoute(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "932")]
		public LegacyCV2Result<None> RaiseStudioEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "933")]
		public LegacyCV2Result<None> RaiseStudioBooleanEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "934")]
		public LegacyCV2Result<None> RaiseStudioFloatEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "935")]
		public LegacyCV2Result<None> RaiseStudioIntEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "936")]
		public LegacyCV2Result<None> RaiseStudioStringEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "937")]
		public LegacyCV2Result<None> RaiseStudioStringBooleanEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "938")]
		public LegacyCV2Result<None> RaiseStudioStringFloatEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "939")]
		public LegacyCV2Result<None> RaiseStudioStringIntEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "940")]
		public LegacyCV2Result<None> RaiseStudioStringStringEvent(FOGDBIUGYXG e, InOut io, RpcTarget rpcTarget)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "941")]
		public LegacyCV2Result<None> NMRHUCPCOZM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "942")]
		public LegacyCV2Result<None> RZKLVMSZRZK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "943")]
		public LegacyCV2Result<None> ANPZJILDWZR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "944")]
		public LegacyCV2Result<None> VPXDYFLQAXV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "945")]
		public LegacyCV2Result<None> THPDQWFWDOW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "946")]
		public LegacyCV2Result<None> BCVYKPUNLLY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "947")]
		public LegacyCV2Result<None> QCFPTUGKVRX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "948")]
		public LegacyCV2Result<None> JSJJQWNFQNN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "949")]
		public LegacyCV2Result<None> PIYFULMRCHT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "950")]
		public LegacyCV2Result<None> VOUXRLLZSWQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "951")]
		public LegacyCV2Result<None> GetFromSyncIdAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "952")]
		public LegacyCV2Result<None> GetFromSyncIdCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "953")]
		public LegacyCV2Result<None> GetFromSyncIdCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "954")]
		public LegacyCV2Result<None> GetFromSyncIdPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "955")]
		public LegacyCV2Result<None> DEPRECATEDGetFromSyncIdPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "956")]
		public LegacyCV2Result<None> GetSyncIdAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "957")]
		public LegacyCV2Result<None> GetSyncIdCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "958")]
		public LegacyCV2Result<None> GetSyncIdCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "959")]
		public LegacyCV2Result<None> GetSyncIdPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "960")]
		public LegacyCV2Result<None> DEPRECATEDGetSyncIdPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "968")]
		public LegacyCV2Result<None> WACNDHZRILC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "967")]
		public LegacyCV2Result<None> IDOVBZVVOKL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "969")]
		public LegacyCV2Result<None> NZWMZJPFPMD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "970")]
		public LegacyCV2Result<None> SZIPCDTMNXM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "971")]
		public LegacyCV2Result<None> WZMYKHJWBXV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "972")]
		public LegacyCV2Result<None> ODXYUNSCEZL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "973")]
		public LegacyCV2Result<None> DFLZSRZYHAG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "961")]
		public LegacyCV2Result<None> TextToolGetText(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "962")]
		public LegacyCV2Result<None> TextToolSetText(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "963")]
		public LegacyCV2Result<None> TextToolSetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "964")]
		public LegacyCV2Result<None> TextToolSetColorNew(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "965")]
		public LegacyCV2Result<None> TextToolSetMaterial(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "966")]
		public LegacyCV2Result<None> TextToolGetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "974")]
		public LegacyCV2Result<None> ToggleButtonGetIsPressed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "975")]
		public LegacyCV2Result<None> AARXGXLUIIN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "981")]
		public LegacyCV2Result<None> GetParticleVfx(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "982")]
		public LegacyCV2Result<None> RIADHEUHDVO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "983")]
		public LegacyCV2Result<None> YTWTGOPCEXC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "984")]
		public LegacyCV2Result<None> WelcomeMatV2GetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "985")]
		public LegacyCV2Result<None> WelcomeMatV2SetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "986")]
		public LegacyCV2Result<None> DoorsV2DoorGetLocked(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "987")]
		public LegacyCV2Result<None> DoorsV2DoorSetLocked(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "988")]
		public LegacyCV2Result<None> DoorsV2DoorGetDestination(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "989")]
		public LegacyCV2Result<None> DoorsV2DoorSetDestination(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "990")]
		public LegacyCV2Result<None> GoToRoom(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "991")]
		public LegacyCV2Result<None> DOOCKAMGMAH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "976")]
		public LegacyCV2Result<None> TouchpadComponentGetActiveTouch(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "977")]
		public LegacyCV2Result<None> TouchpadComponentGetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "978")]
		public LegacyCV2Result<None> TouchpadComponentSetIsEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "979")]
		public LegacyCV2Result<None> TouchpadComponentGetInteractionLabel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "980")]
		public LegacyCV2Result<None> TouchpadComponentSetInteractionLabel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "992")]
		public LegacyCV2Result<None> TriggerHandleGetPrimaryActionHeld(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "993")]
		public LegacyCV2Result<None> QYFUHICIRFR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "994")]
		public LegacyCV2Result<None> XCREEYKIJPD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "995")]
		public LegacyCV2Result<None> IYXPBSMCDYB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "996")]
		public LegacyCV2Result<None> QWUOUPDAEIX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "997")]
		public LegacyCV2Result<None> TFYTXEQAWXT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "998")]
		public LegacyCV2Result<None> NPDXBXPROFT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "999")]
		public LegacyCV2Result<None> BPUESJBHDDV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1000")]
		public LegacyCV2Result<None> HVZBOWBTPBN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1001")]
		public LegacyCV2Result<None> ESJDVSDJSGL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1002")]
		public LegacyCV2Result<None> YEVLOBDMSLN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1006")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationSingle(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1007")]
		public LegacyCV2Result<None> ShowUGCRewardNotificationMultiple(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1003")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> PlayerAwardXp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1004")]
		public LegacyCV2Result<None> PlayerGetRoomLevel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1005")]
		public LegacyCV2Result<None> PlayerGetXp(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1008")]
		public LegacyCV2Result<None> PerlinNoise(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1009")]
		public LegacyCV2Result<None> WTGKXVAGPID(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1010")]
		public LegacyCV2Result<None> SeatGetSeatedPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1011")]
		public LegacyCV2Result<None> SeatSetSeatedPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1012")]
		public LegacyCV2Result<None> SeatSetLockOut(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1013")]
		public LegacyCV2Result<None> SeatSetLockIn(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1014")]
		public LegacyCV2Result<None> SeatUnseatPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1015")]
		public LegacyCV2Result<None> SeatGetLockIn(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1016")]
		public LegacyCV2Result<None> SeatGetLockOut(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1017")]
		public LegacyCV2Result<None> JSWZGJTWWIW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1018")]
		public LegacyCV2Result<None> IRPIICHFSYN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1019")]
		public LegacyCV2Result<None> REPWRJPDVHA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1020")]
		public LegacyCV2Result<None> EPPENBXPFEF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1021")]
		public LegacyCV2Result<None> JGTGCKUXYTK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1022")]
		public LegacyCV2Result<None> IEUDGNFTWHH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1023")]
		public LegacyCV2Result<None> BGMJADTIJDC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1024")]
		public LegacyCV2Result<None> GNEYBFDOBYU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1025")]
		public LegacyCV2Result<None> NPARUBVYBJZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1026")]
		public LegacyCV2Result<None> XFOMSGKAAFI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1027")]
		public LegacyCV2Result<None> OMGISNUYSWY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1028")]
		public LegacyCV2Result<None> ZONBLLBXRZT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1029")]
		public LegacyCV2Result<None> NFMVDIVFUYX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1030")]
		public LegacyCV2Result<None> RDLUXPNVOWM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1031")]
		public LegacyCV2Result<None> TKOLKTRQSET(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1032")]
		public LegacyCV2Result<None> INFWQMQZQWA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1033")]
		public LegacyCV2Result<None> PHNIKEQGHXC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1034")]
		public LegacyCV2Result<None> NavMeshSamplePosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1035")]
		public LegacyCV2Result<None> NavMeshCanPathBetween(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1047")]
		public LegacyCV2Result<None> OOKOBMQWEUU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1048")]
		public LegacyCV2Result<None> IFQQMULCCEY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1049")]
		public LegacyCV2Result<None> TUULFDFOOBU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1050")]
		public LegacyCV2Result<None> BLDAIUDJPHI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1051")]
		public LegacyCV2Result<None> GIKZSRCAYJJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1052")]
		public LegacyCV2Result<None> NIWTWJZYZRB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1053")]
		public LegacyCV2Result<None> BHMPWJNXCBI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1054")]
		public LegacyCV2Result<None> RFTTQMETJDV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1055")]
		public LegacyCV2Result<None> IXSLYUEKUOK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1056")]
		public LegacyCV2Result<None> GDYVBYIPHNT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1057")]
		public LegacyCV2Result<None> FOVFHXCFXSP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1058")]
		public LegacyCV2Result<None> BRBWTTXYARI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1059")]
		public LegacyCV2Result<None> PPDPKGJLZBX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1060")]
		public LegacyCV2Result<None> KQUAMJRBOXJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1061")]
		public LegacyCV2Result<None> EFRBIIZINGL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1062")]
		public LegacyCV2Result<None> WQKFLZNPYOD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1063")]
		public LegacyCV2Result<None> YSBMYCWUXYP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1064")]
		public LegacyCV2Result<None> CUTAWBGZUGK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1065")]
		public LegacyCV2Result<None> IKIJTUXNCSO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1066")]
		public LegacyCV2Result<None> EUENUSCFQXL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1067")]
		public LegacyCV2Result<None> GDDBBYNXPXT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1068")]
		public LegacyCV2Result<None> HWMIXVHEUNJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1069")]
		public LegacyCV2Result<None> VIEGJRCPHBB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1070")]
		public LegacyCV2Result<None> FAJCFNARBVM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1071")]
		public LegacyCV2Result<None> SYQBGPKWFLE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1072")]
		public LegacyCV2Result<None> IsValidAI(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1073")]
		public LegacyCV2Result<None> IsValidCombatant(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x283EF60", Offset = "0x283D760", VA = "0x18283EF60", Slot = "1074")]
		public LegacyCV2Result<None> IsValidPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1075")]
		public LegacyCV2Result<None> IsValidReward(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1076")]
		public LegacyCV2Result<None> IsValidAudio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1077")]
		public LegacyCV2Result<None> IsValidRecNetMesh(FOGDBIUGYXG e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1078")]
		public LegacyCV2Result<None> ValidIfNotNull(FOGDBIUGYXG e, InOut inOut)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1079")]
		public LegacyCV2Result<None> GetVelocityCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1080")]
		public LegacyCV2Result<None> GetVelocityPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1081")]
		public LegacyCV2Result<None> GetAngularVelocityCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1082")]
		public LegacyCV2Result<None> GetForwardVectorCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1083")]
		public LegacyCV2Result<None> GetForwardVectorPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1084")]
		public LegacyCV2Result<None> GetUpVectorCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1085")]
		public LegacyCV2Result<None> GetUpVectorPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1086")]
		public LegacyCV2Result<None> GetOrientationCreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1087")]
		public LegacyCV2Result<None> GetOrientationPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1088")]
		public LegacyCV2Result<None> GetOrientationPlayer_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1089")]
		public LegacyCV2Result<None> GetOrientationPlayer_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1090")]
		public LegacyCV2Result<None> GetOrientationCreationObject_Player(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1091")]
		public LegacyCV2Result<None> GetOrientationCreationObject_CreationObject(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1092")]
		public LegacyCV2Result<None> KBMTMKMGCRB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1093")]
		public LegacyCV2Result<None> JUTANEPXJTA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1094")]
		public LegacyCV2Result<None> PJPUOBLFQJE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1095")]
		public LegacyCV2Result<None> GQPCIDFWYDM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1096")]
		public LegacyCV2Result<None> KKTUVYQLRVY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1097")]
		public LegacyCV2Result<None> RKXFNIMJXTM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1098")]
		public LegacyCV2Result<None> UGQWLLRAXOS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1099")]
		public LegacyCV2Result<None> UVEQROAJJKY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1100")]
		public LegacyCV2Result<None> JEYSRHAWZJG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1101")]
		public LegacyCV2Result<None> RTQMGAOHQLK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1102")]
		public LegacyCV2Result<None> VWDKRBHKZCE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1103")]
		public LegacyCV2Result<None> CEFVGMLFFJF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1104")]
		public LegacyCV2Result<None> GDCYXWPMGZN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1105")]
		public LegacyCV2Result<None> KZXTKOWHFKT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1106")]
		public LegacyCV2Result<None> KDTRJRIHHVB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1107")]
		public LegacyCV2Result<None> TJQRKWGMQQO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1108")]
		public LegacyCV2Result<None> CRGQMSLZCDU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1109")]
		public LegacyCV2Result<None> XWWPOSPLMZH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1110")]
		public LegacyCV2Result<None> CYZZXMOCAUF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1111")]
		public LegacyCV2Result<None> FRDLNKDDARZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1112")]
		public LegacyCV2Result<None> JASSAANGCAX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1113")]
		public LegacyCV2Result<None> GWIKQRTZLHI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1114")]
		public LegacyCV2Result<None> OCSEKMHQNIK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1115")]
		public LegacyCV2Result<None> BPMXOJQBCFJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1116")]
		public LegacyCV2Result<None> ZHITNQDTYLZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1117")]
		public LegacyCV2Result<None> EGRJSQNSOGP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1118")]
		public LegacyCV2Result<None> MRGJLPRVRRJ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1119")]
		public LegacyCV2Result<None> AJEUKOUGCGG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1120")]
		public LegacyCV2Result<None> KTCQBIQVVUH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1121")]
		public LegacyCV2Result<None> OSHSHJPXGJX(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1122")]
		public LegacyCV2Result<None> QDZBADEMPJX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1123")]
		public LegacyCV2Result<None> YCJCHWWJZIA(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1124")]
		public LegacyCV2Result<None> KINMNOCAVLG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1125")]
		public LegacyCV2Result<None> QJKAOLGSVWC(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1126")]
		public LegacyCV2Result<None> KXVIRTPDGZE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1127")]
		public LegacyCV2Result<None> UYLUMCEWPTS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1128")]
		public LegacyCV2Result<None> RZYOXKANDFS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1129")]
		public LegacyCV2Result<None> VLVXECAZUDG(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1130")]
		public LegacyCV2Result<None> KSSDKRJSKSB(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1131")]
		public LegacyCV2Result<None> YVUSFSQSVKG(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1132")]
		public LegacyCV2Result<None> WQZRSGCTKIJ(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1133")]
		public LegacyCV2Result<None> VYNJCRVSXWS(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1134")]
		public LegacyCV2Result<None> KEYJSKNBRFQ(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1135")]
		public LegacyCV2Result<None> ADFFSOSSXWV(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1136")]
		public LegacyCV2Result<None> YEXALDBNPMB(UDMGTDTZRVD e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1137")]
		public LegacyCV2Result<None> RemoteVideoPlayerPlayVideo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1138")]
		public LegacyCV2Result<None> RemoteVideoPlayerPauseVideo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1139")]
		public LegacyCV2Result<None> RemoteVideoPlayerStopVideo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1140")]
		public LegacyCV2Result<None> PSLFRDBNJHV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1141")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetVideoUrl(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1142")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetVideoUrl(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1143")]
		public LegacyCV2Result<None> RemoteVideoPlayerSetCurrentFrame(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1144")]
		public LegacyCV2Result<None> RemoteVideoPlayerGetCurrentFrame(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1145")]
		public LegacyCV2Result<None> HolotarProjectorPlay(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1146")]
		public LegacyCV2Result<None> HolotarProjectorResume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1147")]
		public LegacyCV2Result<None> HolotarProjectorPause(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1148")]
		public LegacyCV2Result<None> HolotarProjectorStop(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1149")]
		public LegacyCV2Result<None> HolotarProjectorSetCurrentTime(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1150")]
		public LegacyCV2Result<None> HolotarProjectorGetCurrentTime(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1151")]
		public LegacyCV2Result<None> HolotarProjectorSetVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1152")]
		public LegacyCV2Result<None> HolotarProjectorGetVolume(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1153")]
		public LegacyCV2Result<None> ExplosionEmitterExplode(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1154")]
		public LegacyCV2Result<None> ExplosionEmitterGetFiringPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1155")]
		public LegacyCV2Result<None> ExplosionEmitterSetFiringPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1156")]
		public LegacyCV2Result<None> ExplosionEmitterGetRadius(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1157")]
		public LegacyCV2Result<None> ExplosionEmitterSetRadius(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1158")]
		public LegacyCV2Result<None> ExplosionEmitterGetDamage(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1159")]
		public LegacyCV2Result<None> ExplosionEmitterSetDamage(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1160")]
		public LegacyCV2Result<None> ExplosionEmitterGetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1161")]
		public LegacyCV2Result<None> ExplosionEmitterSetColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1162")]
		public LegacyCV2Result<None> GunHandleGetCurrentAmmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1163")]
		public LegacyCV2Result<None> GunHandleGetMaxAmmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1164")]
		public LegacyCV2Result<None> GunHandleSetCurrentAmmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1165")]
		public LegacyCV2Result<None> GunHandleSetMaxAmmo(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1166")]
		public LegacyCV2Result<None> ISVNJBFOUDL(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1167")]
		public LegacyCV2Result<None> GunHandleSetADSEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1168")]
		public LegacyCV2Result<None> YUCEZTVCLQB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1169")]
		public LegacyCV2Result<None> SHHUADQDKQU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1170")]
		public LegacyCV2Result<None> AUEIOMCYRXR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1171")]
		public LegacyCV2Result<None> RVGMHZQDBOO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1172")]
		public LegacyCV2Result<None> GunHandleSetRateOfFire(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1173")]
		public LegacyCV2Result<None> GunHandleGetRateOfFire(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1174")]
		public LegacyCV2Result<None> GunHandleSetReloadDuration(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1175")]
		public LegacyCV2Result<None> GunHandleGetReloadDuration(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1176")]
		public LegacyCV2Result<None> GunHandleGetIsReloading(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1177")]
		public LegacyCV2Result<None> GunHandleGetCanReload(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1178")]
		public LegacyCV2Result<None> GunHandleSetCanReload(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1179")]
		public LegacyCV2Result<None> GunHandleGetContinuousFire(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1180")]
		public LegacyCV2Result<None> GunHandleSetContinuousFire(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1181")]
		public LegacyCV2Result<None> SwingHandleGetIsSwinging(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1182")]
		public LegacyCV2Result<None> VLFRSKXQNJI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1183")]
		public LegacyCV2Result<None> AFTZCNTKYHY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1184")]
		public LegacyCV2Result<None> ABTWDIRJYHS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1185")]
		public LegacyCV2Result<None> FKJVPDKVRHO(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1186")]
		public LegacyCV2Result<None> FYZBQUELNLR(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1187")]
		public LegacyCV2Result<None> HYALQFKYRBH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1188")]
		public LegacyCV2Result<None> YFOOJWAUPYV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1189")]
		public LegacyCV2Result<None> BLQVTEHJZAP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1190")]
		public LegacyCV2Result<None> GAGBUNYSISC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1191")]
		public LegacyCV2Result<None> QOGUMPZCKSW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1192")]
		public LegacyCV2Result<None> FQVIOADNHIN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1193")]
		public LegacyCV2Result<None> CZSZDOBYFZU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "184")]
		public LegacyCV2Result<None> BFIEONGWGFK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "186")]
		public LegacyCV2Result<None> GetIntFromRROColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "187")]
		public LegacyCV2Result<None> GetColorFromRGB(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "188")]
		public LegacyCV2Result<None> GetColorFromHSV(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "189")]
		public LegacyCV2Result<None> GetRGBFromColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "190")]
		public LegacyCV2Result<None> GetHSVFromColor(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x283EFA0", Offset = "0x283D7A0", VA = "0x18283EFA0", Slot = "191")]
		public bool JNIXENDMNPY(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1194")]
		public LegacyCV2Result<None> WHSJFXQNDHA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1195")]
		public LegacyCV2Result<None> RPFYBLDROMF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1196")]
		public LegacyCV2Result<None> GGNKQDEIXRU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		public LegacyCV2Result<None> ConstantGiftDropShopItem(FOGDBIUGYXG e, InOut io, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1208")]
		public LegacyCV2Result<None> ShowPurchaseGiftDropShopItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1197")]
		public LegacyCV2Result<None> AnimationGizmoV2IsPlaying(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1198")]
		public LegacyCV2Result<None> AnimationGizmoV2Pause(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1199")]
		public LegacyCV2Result<None> AnimationGizmoV2Play(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1200")]
		public LegacyCV2Result<None> AnimationGizmoV2SetFrame(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1201")]
		public LegacyCV2Result<None> AnimationGizmoV2GetFrame(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1202")]
		public LegacyCV2Result<None> AnimationGizmoV2SetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1203")]
		public LegacyCV2Result<None> AnimationGizmoV2GetSpeed(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1204")]
		public LegacyCV2Result<None> AnimationGizmoV2Stop(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1205")]
		public LegacyCV2Result<None> EWVMEJFPYML(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1206")]
		public LegacyCV2Result<None> XMSBROANZYD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "249")]
		public LegacyCV2Result<None> ConstantObjectiveMarker(FOGDBIUGYXG e, InOut io, BZHQOOWTUWX objectiveMarker)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "250")]
		public LegacyCV2Result<None> PAIFPGLWIAC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "251")]
		public LegacyCV2Result<None> AICOFKOEUHE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "252")]
		public LegacyCV2Result<None> XXQICIBYMZE(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "253")]
		public LegacyCV2Result<None> ObjectiveMarkerSetPosition(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "254")]
		public LegacyCV2Result<None> IYMGFTYKGJB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "255")]
		public LegacyCV2Result<None> AMMLADMYJKF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "256")]
		public LegacyCV2Result<None> NYBEJVELEBP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "257")]
		public LegacyCV2Result<None> WJOLEQGQUXI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "258")]
		public LegacyCV2Result<None> NVBNNIISLXY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "259")]
		public LegacyCV2Result<None> WHYDBXJVSST(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "260")]
		public LegacyCV2Result<None> WTWRNXXBADF(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "261")]
		public LegacyCV2Result<None> CJQMZRQZVSV(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "262")]
		public LegacyCV2Result<None> SHFLXQDEUKN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "263")]
		public LegacyCV2Result<None> CBIZQDOIZMC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "264")]
		public LegacyCV2Result<None> DGYUXGLIXHY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "265")]
		public LegacyCV2Result<None> MBVKLGQMHXA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "266")]
		public LegacyCV2Result<None> ENUWEJRQSVG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "267")]
		public LegacyCV2Result<None> AVZKPXLFHRW(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "268")]
		public LegacyCV2Result<None> VQQKMDMRJFM(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "269")]
		public LegacyCV2Result<None> FQRGWRMIETY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "270")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "271")]
		public LegacyCV2Result<None> LocalPlayerSetObjectiveLogContent(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "272")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "273")]
		public LegacyCV2Result<None> LocalPlayerGetObjectiveLogContent(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		private static LegacyCV2Result<None> Default(FOGDBIUGYXG e, object studioObject, StudioFunctionRegistration registration, IReadOnlyList<CircuitSignal> inMulti, IList<CircuitSignal> outMulti)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x283EFB0", Offset = "0x283D7B0", VA = "0x18283EFB0", Slot = "1209")]
		public LegacyCV2Result<None> SWWVYVWANRP(FOGDBIUGYXG a, object b, StudioFunctionRegistration c, IReadOnlyList<CircuitSignal> d, IList<CircuitSignal> e)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1212")]
		public LegacyCV2Result<None> CMXMCNLSQEA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1213")]
		public LegacyCV2Result<None> TMZZQJLBDOC(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1214")]
		public LegacyCV2Result<None> QKDHGDRKLYA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1215")]
		public LegacyCV2Result<None> IOPBUBLTHJH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1210")]
		public LegacyCV2Result<None> ConstantQuickChatTable(FOGDBIUGYXG e, InOut io, NPRHJPISLRD quickChatTable)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1211")]
		public LegacyCV2Result<None> QuickChatTableSetEnabled(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1036")]
		public LegacyCV2Result<None> LAKNKWZDBWS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1037")]
		public LegacyCV2Result<None> ADMQFKBNZJY(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1038")]
		public LegacyCV2Result<None> FKTLDPQAIQS(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1039")]
		public LegacyCV2Result<None> VQGKTPQLUAG(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1040")]
		public LegacyCV2Result<None> PYJODWYKRIA(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1041")]
		public LegacyCV2Result<None> XMHTDABDOHK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1042")]
		public LegacyCV2Result<None> FYVMDPYEPJM(FOGDBIUGYXG a, IReadOnlyList<CircuitSignal> b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1043")]
		public LegacyCV2Result<None> SONWUVEXEMI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1044")]
		public LegacyCV2Result<None> TOZPYLKELQQ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1045")]
		public LegacyCV2Result<None> UFSVLLKPXKD(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1046")]
		public LegacyCV2Result<None> BQJGFPFGKZN(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1219")]
		public LegacyCV2Result<None> HandlePlayHandleHaptics(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1220")]
		public LegacyCV2Result<None> HandleSetControlLabel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1221")]
		public LegacyCV2Result<None> HandleGetControlLabel(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1222")]
		public LegacyCV2Result<None> HandleGetInteractionFilterTags(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1223")]
		public LegacyCV2Result<None> HandleSetInteractionFilterTags(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1224")]
		public LegacyCV2Result<None> FullBodyPuppetPropSetWornAvatarItems(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1225")]
		public LegacyCV2Result<None> FullBodyPuppetPropTakeWornAvatarItems(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1226")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> COYKKOVGZDL(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1233")]
		public LegacyCV2Result<None> CreationObjectGetDirectlySnappedElements(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1234")]
		public LegacyCV2Result<None> OMJPXIDSCVK(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1235")]
		public LegacyCV2Result<None> SnapPointGetSnappedSnapPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1236")]
		public LegacyCV2Result<None> ROGIDFCBMAP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1237")]
		public LegacyCV2Result<None> ElementSnapToElement(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1238")]
		public LegacyCV2Result<None> ElementUnsnap(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1239")]
		public LegacyCV2Result<None> SnapPointSnapToSnapPoint(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1240")]
		public LegacyCV2Result<None> SnapPointUnsnap(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1227")]
		public LegacyCV2Result<None> CreateRenderTexture_Deprecated(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1228")]
		public LegacyCV2Result<None> ResizeRenderTexture_Deprecated(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1229")]
		public LegacyCV2Result<None> OTQIFYEQTOX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1230")]
		public LegacyCV2Result<None> GetTexture(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1231")]
		public LegacyCV2Result<None> TexturedQuadSetTexture(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1232")]
		public LegacyCV2Result<None> TexturedQuadSetAspectRatio(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1241")]
		public LegacyCV2Result<None> BWVSTSRSVXP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1242")]
		public LegacyCV2Result<None> UNSVDVTUVME(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1243")]
		public LegacyCV2Result<None> OSBNITWXCSU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1244")]
		public LegacyCV2Result<None> SQFODFFTQQU(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1245")]
		public LegacyCV2Result<None> MWLOMBCAWJT(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1246")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> GFSIMWFYOYB(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1247")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> XFHEGGBTASB(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1248")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> YVTRUYUXPPP(FOGDBIUGYXG a, InOut b)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1259")]
		public LegacyCV2Result<None> IJAMSTOOXMX(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1260")]
		public LegacyCV2Result<None> YZHJTLOWHAZ(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1261")]
		public LegacyCV2Result<None> FXWTQRLWAEB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1262")]
		public LegacyCV2Result<None> DCSRSVUXWUP(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x283F0C0", Offset = "0x283D8C0", VA = "0x18283F0C0")]
		public KNBSBNJAIKM([Optional] InteropDelegate? a, [Optional] InteropDelegate? b, [Optional] InteropDelegate? c, [Optional] InteropDelegate? d, [Optional] InvokeStudioFunctionDelegate? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1263")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogModifyR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1264")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1265")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogResetR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1266")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomFogClearPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1267")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunModifyR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1268")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1269")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunResetR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1270")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSunClearPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1271")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeModifyR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1272")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomePlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1273")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeResetR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1274")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomSkydomeClearPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1275")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsModifyR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1276")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1277")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsResetR2(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1278")]
		public LegacyCV2Result<Task<LegacyCV2Result<Out>>> RoomBackgroundObjectsClearPlayerOverride(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1279")]
		public LegacyCV2Result<None> ConstantBodyPart(FOGDBIUGYXG e, InOut io, int bodyPart)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1280")]
		public LegacyCV2Result<None> VTNEYTBXOUI(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1281")]
		public LegacyCV2Result<None> JPVKNENFQDH(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1282")]
		public LegacyCV2Result<None> LocalPlayerRequestFOVMultiplier(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "599")]
		public LegacyCV2Result<None> KGXAJIGNVWB(FOGDBIUGYXG e, InOut a)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1283")]
		public LegacyCV2Result<None> LEGACY_PlayerAttachObjectToTorso(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1284")]
		public LegacyCV2Result<None> LEGACY_PlayerDetachObjectFromTorso(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1285")]
		public LegacyCV2Result<None> CreationObjectAttachToBodyPart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1286")]
		public LegacyCV2Result<None> CreationObjectDetachFromPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1287")]
		public LegacyCV2Result<None> CreationObjectGetAttachedBodyPart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1288")]
		public LegacyCV2Result<None> CreationObjectGetIsAttachedToAPlayer(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1289")]
		public LegacyCV2Result<None> PlayerDetachAllObjects(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1290")]
		public LegacyCV2Result<None> PlayerDetachObjectsFromBodyPart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1291")]
		public LegacyCV2Result<None> PlayerGetAllAttachedObjects(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1292")]
		public LegacyCV2Result<None> PlayerGetObjectsAttachedToBodyPart(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1293")]
		public LegacyCV2Result<None> RNZRKVQITSS(UDMGTDTZRVD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1294")]
		public LegacyCV2Result<None> EHILQXCPUZH(UDMGTDTZRVD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1295")]
		public LegacyCV2Result<None> EEWDAHLQERU(UDMGTDTZRVD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1296")]
		public LegacyCV2Result<None> JUMFZBJAINU(UDMGTDTZRVD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1297")]
		public LegacyCV2Result<None> OTQDNRMDGHD(UDMGTDTZRVD e, InOut a, PlayerTraitType b)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90")]
		public LegacyCV2Result<None> ConstantStorefrontItem(FOGDBIUGYXG e, InOut io, [In] OHHDYBBSLZS storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1217")]
		public LegacyCV2Result<None> ShowPurchasePromptStorefrontItem(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1218")]
		public LegacyCV2Result<None> ShowPurchasePromptPurchaseReminder(FOGDBIUGYXG e, InOut io)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "157")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> CXXQGYKMKUN(FOGDBIUGYXG a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, [In] CircuitSignal giftPackageMessageOverrideInput, XEFIJRFQQCT.AwardRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "158")]
		private LegacyCV2Result<Task<LegacyCV2Result<Out>>> YBQYPDFKUYX(FOGDBIUGYXG a, [In] CircuitSignal roomBadgeInput, [In] CircuitSignal playerInput, XEFIJRFQQCT.PlayerHasRoomBadgeReturnOutputMethod b, CancellationToken c)
		{
			return default(LegacyCV2Result<Task<LegacyCV2Result<Out>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1207")]
		private LegacyCV2Result<None> AFMFGFZGIKQ(FOGDBIUGYXG a, InOut b, [In] string shopName, [In] int itemIndex)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1216")]
		private LegacyCV2Result<None> OAMJBXGMQPJ(FOGDBIUGYXG a, InOut b, [In] OHHDYBBSLZS storefrontItem)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xE1BA90", Offset = "0xE1A290", VA = "0x180E1BA90", Slot = "1257")]
		private LegacyCV2Result<None> VUIVJIUSPWF(Stream a, [In] CircuitSignal signal)
		{
			return default(LegacyCV2Result<None>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class HZUCOLRTYZT : BAFVFEYEPEO
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public delegate Task<bool> OnPlayerDefinitionBoardSpawnDefaultChipsDelegate(GOWLLZHWQWN node);

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly HZUCOLRTYZT ZVPUUHTUYEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate PPMWXXGLIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly OnPlayerDefinitionBoardSpawnDefaultChipsDelegate MCRIXDCKBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool QRSVVNQRVWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool YYKMPJXZLLS;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "4")]
		public Task<bool> NVGSYSOGMVR(GOWLLZHWQWN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2847FE0", Offset = "0x28467E0", VA = "0x182847FE0", Slot = "5")]
		public Task<bool> BRBECDXAYYO(GOWLLZHWQWN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x28480B0", Offset = "0x28468B0", VA = "0x1828480B0")]
		public HZUCOLRTYZT([Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? a, [Optional] OnPlayerDefinitionBoardSpawnDefaultChipsDelegate? b, bool c = false, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2848010", Offset = "0x2846810", VA = "0x182848010", Slot = "6")]
		public (CircuitTemplateRootData, Guid, Guid)? WVUYZOYJWQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAA8640", Offset = "0xAA6E40", VA = "0x180AA8640", Slot = "7")]
		public bool VWDWGMBDEWQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x1301040", Offset = "0x12FF840", VA = "0x181301040", Slot = "8")]
		public bool TSQDZLZPAJO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[Obsolete]
	public sealed class REZUXECYFGT : DGWAEYDKDHY
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid TGQGYDYDEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xC27030", Offset = "0xC25830", VA = "0x180C27030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void Bind(XDOJWDDWSQA pcc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xE55140", Offset = "0xE53940", VA = "0x180E55140")]
		public REZUXECYFGT(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x284B200", Offset = "0x2849A00", VA = "0x18284B200")]
		public static REZUXECYFGT New(Guid guid)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class MAPLHTMSYIJ : FWQHNCKMARH
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public delegate bool IsNodeRestrictedDelegate(Id128<PYVBRMOVXVY> nodeDefId, Id128<HGNGXYZABBE>? legacyInnerGraphId, IReadOnlyDictionary<Id128<HGNGXYZABBE>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private IsNodeRestrictedDelegate? HIUNAEMJYHA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool HJGTSRVFTYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0xAF3180", Offset = "0xAF1980", VA = "0x180AF3180", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ZWDGIBXOXJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x2849760", Offset = "0x2847F60", VA = "0x182849760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KSIYMMBCNOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xFA7A60", Offset = "0xFA6260", VA = "0x180FA7A60", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "6")]
		public bool FOZMZQFJJXA(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "7")]
		public CanSaveObjectIntoInventionResultType WCNGMWKOWDF(Guid a)
		{
			return default(CanSaveObjectIntoInventionResultType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2849710", Offset = "0x2847F10", VA = "0x182849710", Slot = "8")]
		public bool BFVUHSTQQRU(Id128<PYVBRMOVXVY> nodeDefId, Id128<HGNGXYZABBE>? legacyInnerGraphId, IReadOnlyDictionary<Id128<HGNGXYZABBE>, Guid>? graphToToolMappings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
		public bool ZJRHLTUWUTP(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "10")]
		public bool MNSIVOSNBKZ(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2849770", Offset = "0x2847F70", VA = "0x182849770")]
		public MAPLHTMSYIJ(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, [Optional] IsNodeRestrictedDelegate? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class DNXGKOOCBMR : IIWSQEGIHZQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public delegate bool ShouldLogEventSenderToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public delegate bool ShouldLogEventReceiverToMakerPenDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly DNXGKOOCBMR ZVPUUHTUYEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly ShouldLogEventSenderToMakerPenDelegate INYZHHNAXDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly ShouldLogEventReceiverToMakerPenDelegate OSQKFCFFTQN;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool XFTJZGYXDXL
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xFEF370", Offset = "0xFEDB70", VA = "0x180FEF370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WPUMUPKUIZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x2847710", Offset = "0x2845F10", VA = "0x182847710", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x28477B0", Offset = "0x2845FB0", VA = "0x1828477B0")]
		public DNXGKOOCBMR([Optional] ShouldLogEventSenderToMakerPenDelegate? a, [Optional] ShouldLogEventReceiverToMakerPenDelegate? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class NMYFWGVBRCZ : PDZCNDGPMJR<NSOJHEXWUKL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public sealed class ZWQJFTMDRVU : NSOJHEXWUKL, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly ZWQJFTMDRVU GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public bool BRHRKHOCZMU
			{
				[Cpp2IlInjected.Token(Token = "0x600075E")]
				[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x28505B0", Offset = "0x284EDB0", VA = "0x1828505B0", Slot = "6")]
			public void OnCompleted(Action continuation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			public void UIBMINFWSGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZWQJFTMDRVU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NMYFWGVBRCZ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private NMYFWGVBRCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x284A370", Offset = "0x2848B70", VA = "0x18284A370", Slot = "4")]
		public NSOJHEXWUKL EWBVATDWNDU()
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class YEBTSXMREUF<a, b> : IDisposable, IDYIPMVXRGA where a : notnull where b : notnull, ZKJPTCVHIZF.AGAWTSGPFNV<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly b EONMVLIXIRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly a IUQWPOFPFTK;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Id32<KQPBKUZCJXR> ZIFBBETZDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Id32<KQPBKUZCJXR>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8210", Offset = "0x3DE6A10", VA = "0x183DE8210")]
		public YEBTSXMREUF(b a, a b, Id32<KQPBKUZCJXR> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6410", Offset = "0x3DE4C10", VA = "0x183DE6410", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5F40", Offset = "0x3DE4740", VA = "0x183DE5F40")]
		public Id32<XMKDLRJXOXG> AELXWYBUGSV([In] Guid? graphId, DynamicEnvironmentNetworkId a)
		{
			return default(Id32<XMKDLRJXOXG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x3DE78B0", Offset = "0x3DE60B0", VA = "0x183DE78B0", Slot = "6")]
		public void WTVJTSMZFHM(Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6B20", Offset = "0x3DE5320", VA = "0x183DE6B20", Slot = "7")]
		public void JRYSRZTSXFC(Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6F40", Offset = "0x3DE5740", VA = "0x183DE6F40", Slot = "8")]
		public void KBUOHYGCGEZ(Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7380", Offset = "0x3DE5B80", VA = "0x183DE7380", Slot = "10")]
		public void QSUHWYQTPHA(Id32<XMKDLRJXOXG> objectId, Id32<KQPBKUZCJXR> clientId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE66A0", Offset = "0x3DE4EA0", VA = "0x183DE66A0", Slot = "9")]
		public void FEEHZNZNFVO(Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7D70", Offset = "0x3DE6570", VA = "0x183DE7D70", Slot = "11")]
		public void XNGHNUGCMHY(Id32<XMKDLRJXOXG> objectId, LDIAONDUDJP? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE72B0", Offset = "0x3DE5AB0", VA = "0x183DE72B0", Slot = "12")]
		public Id32<KQPBKUZCJXR> NXVRBGFPEMB(Id32<XMKDLRJXOXG> objectId)
		{
			return default(Id32<KQPBKUZCJXR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8010", Offset = "0x3DE6810", VA = "0x183DE8010", Slot = "13")]
		public Id32<OTODRBWJKCQ> YGFXLXDKIOP(Id32<XMKDLRJXOXG> objectId, string a, object b, bool c, EXLPNTVNDUA d, FJPWASEVZWQ e)
		{
			return default(Id32<OTODRBWJKCQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6660", Offset = "0x3DE4E60", VA = "0x183DE6660", Slot = "14")]
		public void EOERINMXIKJ(Id32<OTODRBWJKCQ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7870", Offset = "0x3DE6070", VA = "0x183DE7870", Slot = "15")]
		public void RJUTEYMQMQZ(Id32<OTODRBWJKCQ> syncFieldId, object a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public static class ZKJPTCVHIZF
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public interface AGAWTSGPFNV<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void WKRYTDBZETZ(a a, Id32<KQPBKUZCJXR> clientId);

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Id32<KQPBKUZCJXR>? FGHYUWSPNKM(a a);

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Id32<XMKDLRJXOXG> AELXWYBUGSV(a a, Id32<KQPBKUZCJXR> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b);

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void WTVJTSMZFHM(a a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b);

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void JRYSRZTSXFC(a a, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b);

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void QSUHWYQTPHA(a a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b);

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void FEEHZNZNFVO(a a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b);

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(Slot = "7")]
			void XNGHNUGCMHY(a a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, LDIAONDUDJP? dynamicNetSysReceiver);

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(Slot = "8")]
			Id32<KQPBKUZCJXR>? NXVRBGFPEMB(a a, Id32<XMKDLRJXOXG> objectId);

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			Id32<OTODRBWJKCQ> YGFXLXDKIOP(a a, Id32<KQPBKUZCJXR> clientId, string b, object c, EXLPNTVNDUA d, FJPWASEVZWQ e);

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			void EOERINMXIKJ(a a, Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId);

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			void RJUTEYMQMQZ(a a, Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId, object b);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal sealed class UINIOAUVUPZ
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		internal struct MockCV2DynamicNetSys
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly HashSet<Id32<XMKDLRJXOXG>> AuthorityOf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SOAId32Field<OTODRBWJKCQ, MockCV2SyncField> SyncFields;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public readonly Dictionary<Id32<OTODRBWJKCQ>, Id32<MockCV2SyncFieldShared.M>> SyncFieldToMockSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<OTODRBWJKCQ>> MockSyncFieldToSyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public SOAField<XMKDLRJXOXG, LDIAONDUDJP?> Receivers;

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x284A010", Offset = "0x2848810", VA = "0x18284A010")]
			private MockCV2DynamicNetSys(HashSet<Id32<XMKDLRJXOXG>> authorityOf, [In] SOAId32Field<OTODRBWJKCQ, MockCV2SyncField> syncFields, Dictionary<Id32<OTODRBWJKCQ>, Id32<MockCV2SyncFieldShared.M>> syncFieldToMockSyncField, Dictionary<Id32<MockCV2SyncFieldShared.M>, Id32<OTODRBWJKCQ>> mockSyncFieldToSyncField, [In] SOAField<XMKDLRJXOXG, LDIAONDUDJP?> receivers)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x2849E50", Offset = "0x2848650", VA = "0x182849E50")]
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
			public Id32<KQPBKUZCJXR>? Authority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly Guid? GraphId;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x284A0B0", Offset = "0x28488B0", VA = "0x18284A0B0")]
			public MockCV2ObjectShared(Id32<KQPBKUZCJXR> authority, [In] Guid? graphId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		internal struct MockCV2SyncField
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public FJPWASEVZWQ SyncField;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public EXLPNTVNDUA SyncFieldChangeHandler;

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
			internal MockCV2SyncField(FJPWASEVZWQ syncField, EXLPNTVNDUA syncFieldChangeHandler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x284A1D0", Offset = "0x28489D0", VA = "0x18284A1D0")]
			public static MockCV2SyncField New(FJPWASEVZWQ syncField, EXLPNTVNDUA syncFieldChangeHandler)
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
			[Cpp2IlInjected.Address(RVA = "0x284A180", Offset = "0x2848980", VA = "0x18284A180")]
			internal MockCV2SyncFieldShared(string name, object value, int uses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x284A130", Offset = "0x2848930", VA = "0x18284A130")]
			public static MockCV2SyncFieldShared New(string name, object value)
			{
				return default(MockCV2SyncFieldShared);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private SOAId32Field<XMKDLRJXOXG, MockCV2ObjectShared> VXDPVVOAQOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<(Guid, DynamicEnvironmentNetworkId), Id32<XMKDLRJXOXG>> WKPHKXPZXBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private SOAId32Field<MockCV2SyncFieldShared.M, MockCV2SyncFieldShared> PDGVGWHNSBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Dictionary<string, Id32<MockCV2SyncFieldShared.M>> FNPZVGSAGKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SOAField<KQPBKUZCJXR, MockCV2DynamicNetSys> EIZMAANDQFW;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Id32<XMKDLRJXOXG>? YBDSJBMPFWE
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xBB29C0", Offset = "0xBB11C0", VA = "0x180BB29C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xFB0DD0", Offset = "0xFAF5D0", VA = "0x180FB0DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x284E900", Offset = "0x284D100", VA = "0x18284E900")]
		public void Destroy([In] SOAId32<KQPBKUZCJXR> clientIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x284F520", Offset = "0x284DD20", VA = "0x18284F520")]
		public void UHTJNHOPVQN(Id32<KQPBKUZCJXR> clientId, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x284F980", Offset = "0x284E180", VA = "0x18284F980")]
		public void WKRYTDBZETZ(Id32<KQPBKUZCJXR> clientId, Id32<KQPBKUZCJXR>? masterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x284E4F0", Offset = "0x284CCF0", VA = "0x18284E4F0")]
		public Id32<XMKDLRJXOXG> AELXWYBUGSV(Id32<KQPBKUZCJXR> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId a, [In] SOAId32<KQPBKUZCJXR> clientIds)
		{
			return default(Id32<XMKDLRJXOXG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x284FE10", Offset = "0x284E610", VA = "0x18284FE10")]
		public Id32<OTODRBWJKCQ> YGFXLXDKIOP(Id32<KQPBKUZCJXR> clientId, string a, object b, EXLPNTVNDUA c, FJPWASEVZWQ d)
		{
			return default(Id32<OTODRBWJKCQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x284EC10", Offset = "0x284D410", VA = "0x18284EC10")]
		public void EOERINMXIKJ(Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x284EB40", Offset = "0x284D340", VA = "0x18284EB40")]
		public Id32<XMKDLRJXOXG>? EBMZXZICIRK([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x284FCC0", Offset = "0x284E4C0", VA = "0x18284FCC0")]
		public void WTVJTSMZFHM([In] SOAId32<KQPBKUZCJXR> clientIds, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x284EF20", Offset = "0x284D720", VA = "0x18284EF20")]
		public void JRYSRZTSXFC(Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x284F0B0", Offset = "0x284D8B0", VA = "0x18284F0B0")]
		public void QSUHWYQTPHA(Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x284EDA0", Offset = "0x284D5A0", VA = "0x18284EDA0")]
		public void FEEHZNZNFVO([In] SOAId32<KQPBKUZCJXR> clientIds, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x284FD40", Offset = "0x284E540", VA = "0x18284FD40")]
		public void XNGHNUGCMHY(Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, LDIAONDUDJP? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x284F060", Offset = "0x284D860", VA = "0x18284F060")]
		public Id32<KQPBKUZCJXR>? NXVRBGFPEMB(Id32<XMKDLRJXOXG> objectId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x284F1B0", Offset = "0x284D9B0", VA = "0x18284F1B0")]
		public void RJUTEYMQMQZ([In] SOAId32<KQPBKUZCJXR> clientIds, Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId, object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2850070", Offset = "0x284E870", VA = "0x182850070")]
		public UINIOAUVUPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal static class PRHTKDFAMLQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x284A780", Offset = "0x2848F80", VA = "0x18284A780")]
		public static void Destroy(this UINIOAUVUPZ.MockCV2DynamicNetSys self)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.V2.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class LEKTEJOGFYI : FATSTGCXBEA.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static LEKTEJOGFYI BFXFVJQJCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ComparisonDelegate KCVQBDKJJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ComparisonDelegate WCOATPUARLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xAA71B0", Offset = "0xAA59B0", VA = "0x180AA71B0")]
		public LEKTEJOGFYI(ComparisonDelegate a, ComparisonDelegate b)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[WillBeRenamedTo("MockCircuitsNetwork")]
	public sealed class QKFNWZERSCU : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private readonly struct RootDeps : NRKRHHBELOV.FNDZURQZCIS<LPVLEQQBKYR, QKFNWZERSCU>
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
				public AsyncTaskMethodBuilder<Result<object, AGEZPYTJJRF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public QKFNWZERSCU root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public Id32<KQPBKUZCJXR> senderId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public LPVLEQQBKYR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public RootDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter<Result<object, AGEZPYTJJRF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007A8")]
				[Cpp2IlInjected.Address(RVA = "0x284D640", Offset = "0x284BE40", VA = "0x18284D640", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A9")]
				[Cpp2IlInjected.Address(RVA = "0x284D880", Offset = "0x284C080", VA = "0x18284D880", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			public int VPHMZSLMVHW(QKFNWZERSCU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x284B260", Offset = "0x2849A60", VA = "0x18284B260", Slot = "5")]
			public int JPAEUDOPCFO(QKFNWZERSCU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x284B420", Offset = "0x2849C20", VA = "0x18284B420", Slot = "6")]
			public int ZJDSVGWEYOT(QKFNWZERSCU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xCA1BC0", Offset = "0xCA03C0", VA = "0x180CA1BC0", Slot = "7")]
			public int DXHOFZAPIJB(QKFNWZERSCU a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x284B3D0", Offset = "0x2849BD0", VA = "0x18284B3D0", Slot = "8")]
			public void VGUKRHLEOQS(QKFNWZERSCU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
			public bool IXQFEAGUHSL(QKFNWZERSCU a, Id32<KQPBKUZCJXR> actorId, LPVLEQQBKYR[] b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "10")]
			public bool SEWGPPCUKWN(QKFNWZERSCU a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0x284B280", Offset = "0x2849A80", VA = "0x18284B280", Slot = "11")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__7))]
			public Task<Result<object, AGEZPYTJJRF>> ONLJJASTUMB(QKFNWZERSCU a, Id32<KQPBKUZCJXR> senderId, LPVLEQQBKYR b, bool c = true)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private readonly struct Deps : NRKRHHBELOV.AGLKOFUJYKN<ActionDeps, VFRMMNWEYJQ.StaticNetSysReceiverDeps, RootDeps>
		{
			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public ActionDeps XFCHQEZDBNN
			{
				[Cpp2IlInjected.Token(Token = "0x60007AA")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "4")]
				get
				{
					return default(ActionDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public VFRMMNWEYJQ.StaticNetSysReceiverDeps HODMCQRGIFW
			{
				[Cpp2IlInjected.Token(Token = "0x60007AB")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "5")]
				get
				{
					return default(VFRMMNWEYJQ.StaticNetSysReceiverDeps);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public RootDeps DLPYXPIZNYJ
			{
				[Cpp2IlInjected.Token(Token = "0x60007AC")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "6")]
				get
				{
					return default(RootDeps);
				}
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		public readonly struct MockStaticNetSysDeps : LQBDQRVWKNJ.AGAWTSGPFNV<QKFNWZERSCU>
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
				public AsyncTaskMethodBuilder<Result<object?, AGEZPYTJJRF>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public QKFNWZERSCU root;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public Id32<KQPBKUZCJXR> clientId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public LPVLEQQBKYR action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public bool clearBufferedRpcs;

				[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public MockStaticNetSysDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private TaskAwaiter<Result<object?, AGEZPYTJJRF>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x284D320", Offset = "0x284BB20", VA = "0x18284D320", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007AF")]
				[Cpp2IlInjected.Address(RVA = "0x284D5D0", Offset = "0x284BDD0", VA = "0x18284D5D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x284A210", Offset = "0x2848A10", VA = "0x18284A210", Slot = "4")]
			[AsyncStateMachine(typeof(<SendActionToAll>d__0))]
			public Task<Result<object, AGEZPYTJJRF>> ONLJJASTUMB(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, LPVLEQQBKYR b, bool c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public readonly struct MockCV2DynamicNetSysDeps : ZKJPTCVHIZF.AGAWTSGPFNV<QKFNWZERSCU>
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x2849C50", Offset = "0x2848450", VA = "0x182849C50", Slot = "4")]
			public void WKRYTDBZETZ(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xCA1C90", Offset = "0xCA0490", VA = "0x180CA1C90", Slot = "5")]
			public Id32<KQPBKUZCJXR>? FGHYUWSPNKM(QKFNWZERSCU a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0x28497F0", Offset = "0x2847FF0", VA = "0x1828497F0")]
			public Id32<XMKDLRJXOXG> AELXWYBUGSV(QKFNWZERSCU a, Id32<KQPBKUZCJXR> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<XMKDLRJXOXG>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x2849C80", Offset = "0x2848480", VA = "0x182849C80", Slot = "7")]
			public void WTVJTSMZFHM(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0x2849A20", Offset = "0x2848220", VA = "0x182849A20", Slot = "8")]
			public void JRYSRZTSXFC(QKFNWZERSCU a, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x2849BE0", Offset = "0x28483E0", VA = "0x182849BE0", Slot = "9")]
			public void QSUHWYQTPHA(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x28499F0", Offset = "0x28481F0", VA = "0x1828499F0", Slot = "10")]
			public void FEEHZNZNFVO(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, NPSRPKJGUTZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x2849D10", Offset = "0x2848510", VA = "0x182849D10", Slot = "11")]
			public void XNGHNUGCMHY(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<XMKDLRJXOXG> objectId, LDIAONDUDJP? dynamicNetSysReceiver)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x2849B80", Offset = "0x2848380", VA = "0x182849B80", Slot = "12")]
			public Id32<KQPBKUZCJXR>? NXVRBGFPEMB(QKFNWZERSCU a, Id32<XMKDLRJXOXG> objectId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x2849DF0", Offset = "0x28485F0", VA = "0x182849DF0", Slot = "13")]
			public Id32<OTODRBWJKCQ> YGFXLXDKIOP(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, string b, object c, EXLPNTVNDUA d, FJPWASEVZWQ e)
			{
				return default(Id32<OTODRBWJKCQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x2849850", Offset = "0x2848050", VA = "0x182849850", Slot = "14")]
			public void EOERINMXIKJ(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2849C20", Offset = "0x2848420", VA = "0x182849C20", Slot = "15")]
			public void RJUTEYMQMQZ(QKFNWZERSCU a, Id32<KQPBKUZCJXR> clientId, Id32<OTODRBWJKCQ> syncFieldId, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x28497F0", Offset = "0x2847FF0", VA = "0x1828497F0", Slot = "6")]
			private Id32<XMKDLRJXOXG> DBLWBLRINNB(QKFNWZERSCU a, Id32<KQPBKUZCJXR> creatorId, [In] Guid? graphId, DynamicEnvironmentNetworkId b)
			{
				return default(Id32<XMKDLRJXOXG>);
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
			public QKFNWZERSCU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public Id32<XMKDLRJXOXG>? rootCV2Object;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public IWKODKJRCUD deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RegistryV2 registryV2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Id32<KQPBKUZCJXR> <clientId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EE8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private YIOIHAOHSAR<QKFNWZERSCU, MockStaticNetSysDeps> <staticNetSys>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private YEBTSXMREUF<QKFNWZERSCU, MockCV2DynamicNetSysDeps> <dynamicNetSys>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1EF8")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private VFRMMNWEYJQ <circuitsManager>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1F00")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x284CC60", Offset = "0x284B460", VA = "0x18284CC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x284D2B0", Offset = "0x284BAB0", VA = "0x18284D2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly JPHYPEABVQP<LPVLEQQBKYR, None, VFRMMNWEYJQ, ActionDeps, VFRMMNWEYJQ.StaticNetSysReceiverDeps, RootDeps, QKFNWZERSCU, Deps> DPTQACMMHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly UINIOAUVUPZ LCDPOJUIXHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private SOAId32<KQPBKUZCJXR> YTPTZEEVLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private SOAField<KQPBKUZCJXR, None> EIZMAANDQFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private SOAField<KQPBKUZCJXR, VFRMMNWEYJQ> NYLMTUTVTBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Id32<KQPBKUZCJXR>? URMQQXEPBQF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GetNetworkObjectDelegate UVFGGMIOKMV
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x284AEA0", Offset = "0x28496A0", VA = "0x18284AEA0")]
		public QKFNWZERSCU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x284A7E0", Offset = "0x2848FE0", VA = "0x18284A7E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x284A9B0", Offset = "0x28491B0", VA = "0x18284A9B0")]
		[AsyncStateMachine(typeof(<RetainClient>d__11))]
		public Task<EVCreationResult> UHTJNHOPVQN(IWKODKJRCUD a, RegistryV2 b, Id32<XMKDLRJXOXG>? rootCV2Object)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x284AB30", Offset = "0x2849330", VA = "0x18284AB30")]
		private void WKRYTDBZETZ(Id32<KQPBKUZCJXR> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x284ADC0", Offset = "0x28495C0", VA = "0x18284ADC0")]
		[CompilerGenerated]
		private Id32<XMKDLRJXOXG>? ZBWMGVGJHVF([In] Guid graphId, DynamicEnvironmentNetworkId a)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class OKFSTJUBCXX : LXRXVSRSSBL.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public delegate Task<AOQTISSDBAQ> DeserializeCircuitsJunctionAsyncDelegate(VFRMMNWEYJQ circuitsManager, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<AOQTISSDBAQ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public OKFSTJUBCXX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public VFRMMNWEYJQ circuitsManager;

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
			private TaskAwaiter<AOQTISSDBAQ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x284B950", Offset = "0x284A150", VA = "0x18284B950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x284BB50", Offset = "0x284A350", VA = "0x18284BB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly DeserializeCircuitsJunctionAsyncDelegate WSSJUJPAZES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly LifecycleDidInitializeDelegate? PYCTWADRMIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LifecycleWillDestroyDelegate? SYKHINSARSR;

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x284A430", Offset = "0x2848C30", VA = "0x18284A430", Slot = "4")]
		[AsyncStateMachine(typeof(<DeserializeInstance>d__2))]
		public Task<AOQTISSDBAQ> HGWIROWOHDX(VFRMMNWEYJQ a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void VKWNOOHUFCL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xD192D0", Offset = "0xD17AD0", VA = "0x180D192D0", Slot = "6")]
		public void LifecycleDidInitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xDDE2E0", Offset = "0xDDCAE0", VA = "0x180DDE2E0", Slot = "7")]
		public void LifecycleWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x284A5A0", Offset = "0x2848DA0", VA = "0x18284A5A0")]
		public OKFSTJUBCXX([Optional] DeserializeCircuitsJunctionAsyncDelegate? a, [Optional] LifecycleDidInitializeDelegate? b, [Optional] LifecycleWillDestroyDelegate? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class KMVMVYDHCQZ : NIRKESMUPUN.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate ICVLDVBXLIZ GetCV2DependenciesDelegate();

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate Task<CircuitRootData> GetRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate Task<SuperRoomData> GetSuperRoomDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate Task<EYDEHTQPKPZ> GetRoomAssetDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate Task<SYNWNGHNLWX> GetPlayerSaveDataAsyncDelegate(CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate Task<NIRKESMUPUN.HYKMXKQCBUU.CircuitGraphToolMapping> GetCircuitGraphToolMappingAsyncDelegate(CancellationToken cancellationToken);

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
			public AsyncTaskMethodBuilder<NIRKESMUPUN.HYKMXKQCBUU.CircuitGraphToolMapping> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<NIRKESMUPUN.HYKMXKQCBUU.CircuitGraphToolMapping> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x284BBC0", Offset = "0x284A3C0", VA = "0x18284BBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x284BDB0", Offset = "0x284A5B0", VA = "0x18284BDB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<SYNWNGHNLWX> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<SYNWNGHNLWX> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x284BE20", Offset = "0x284A620", VA = "0x18284BE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x284C010", Offset = "0x284A810", VA = "0x18284C010", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EYDEHTQPKPZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			private TaskAwaiter<EYDEHTQPKPZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x284C080", Offset = "0x284A880", VA = "0x18284C080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x284C270", Offset = "0x284AA70", VA = "0x18284C270", Slot = "5")]
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
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x284C2E0", Offset = "0x284AAE0", VA = "0x18284C2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x284C4D0", Offset = "0x284ACD0", VA = "0x18284C4D0", Slot = "5")]
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
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x284C540", Offset = "0x284AD40", VA = "0x18284C540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x284C730", Offset = "0x284AF30", VA = "0x18284C730", Slot = "5")]
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
			public KMVMVYDHCQZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<SuperRoomData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x284C7A0", Offset = "0x284AFA0", VA = "0x18284C7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x284C990", Offset = "0x284B190", VA = "0x18284C990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private readonly GetCV2DependenciesDelegate TIRUQDBSKTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private readonly GetRoomDataAsyncDelegate ABEYGVUDZPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly GetSuperRoomDataAsyncDelegate XAOVIKVAUUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private readonly GetRoomAssetDataAsyncDelegate PNHOSPGGRWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly GetPlayerSaveDataAsyncDelegate CLHVAIJALMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly GetCircuitGraphToolMappingAsyncDelegate QFNBGUMAACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly GetStaticCircuitsConfigAsyncDelegate QWUITXPFJYP;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ICVLDVBXLIZ ICVLDVBXLIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xFEF370", Offset = "0xFEDB70", VA = "0x180FEF370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2848D20", Offset = "0x2847520", VA = "0x182848D20", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoomDataAsync>d__6))]
		public Task<CircuitRootData> RYZWTBKASPY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x28487D0", Offset = "0x2846FD0", VA = "0x1828487D0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetSuperRoomDataAsync>d__9))]
		public Task<SuperRoomData> AEVSEVIFNYV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2848C10", Offset = "0x2847410", VA = "0x182848C10", Slot = "7")]
		[AsyncStateMachine(typeof(<GetRoomAssetDataAsync>d__12))]
		public Task<EYDEHTQPKPZ> HCVCIPHPXPQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x28489F0", Offset = "0x28471F0", VA = "0x1828489F0", Slot = "8")]
		[AsyncStateMachine(typeof(<GetPlayerSaveDataAsync>d__15))]
		public Task<SYNWNGHNLWX> DGYNDMDLIFV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x2848B00", Offset = "0x2847300", VA = "0x182848B00", Slot = "9")]
		[AsyncStateMachine(typeof(<GetCircuitGraphToolMappingAsync>d__18))]
		public Task<NIRKESMUPUN.HYKMXKQCBUU.CircuitGraphToolMapping> FIHOYYNQXIU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x28488E0", Offset = "0x28470E0", VA = "0x1828488E0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetStaticCircuitsConfigAsync>d__21))]
		public Task<StaticCircuitsConfig> CNIFVULOBBF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x2848E30", Offset = "0x2847630", VA = "0x182848E30")]
		public KMVMVYDHCQZ(GetCV2DependenciesDelegate getCV2DependenciesDelegate, [Optional] GetRoomDataAsyncDelegate? a, [Optional] GetSuperRoomDataAsyncDelegate? b, [Optional] GetRoomAssetDataAsyncDelegate? c, [Optional] GetPlayerSaveDataAsyncDelegate? d, [Optional] GetCircuitGraphToolMappingAsyncDelegate? e, [Optional] GetStaticCircuitsConfigAsyncDelegate? f)
		{
		}
	}
}
namespace Circuits.All.Mock.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public sealed class XAPKTBLWDPD : CV2Request.HYKMXKQCBUU
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public delegate bool GetCanSendRequestsDelegate();

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly CV2Request.HYKMXKQCBUU GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private readonly GetCanSendRequestsDelegate QJQCPNKDJER;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public XAPKTBLWDPD(GetCanSendRequestsDelegate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xFEF370", Offset = "0xFEDB70", VA = "0x180FEF370", Slot = "4")]
		public bool WUEFILNQHCB()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class TWXFFDAYPSK : SYPUBXDNQDT
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		public delegate bool TryReportErrToUserDelegate([In] Result<None, PWKRFVXRRZL> result);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly TryReportErrToUserDelegate LKCPLSVVXOP;

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80")]
		public bool WAIIFSZKMRB([In] Result<None, PWKRFVXRRZL> result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x284B7A0", Offset = "0x2849FA0", VA = "0x18284B7A0")]
		public TWXFFDAYPSK([Optional] TryReportErrToUserDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "4")]
		private bool YFWAKZDMUNC([In] Result<None, PWKRFVXRRZL> result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class CPFXLQVGPWH : LSBMFTSHOAY
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public delegate FOGDBIUGYXG CurrentExecParamsDelegate();

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly CPFXLQVGPWH GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly CurrentExecParamsDelegate? JYSICBQWTXH;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public FOGDBIUGYXG CUKVXYCMJBF
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0xFEF370", Offset = "0xFEDB70", VA = "0x180FEF370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public CPFXLQVGPWH([Optional] CurrentExecParamsDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class EWEOSTEYPLB : TIQDQKXZXGW
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public delegate CircuitsColor GetGameColorFromIdDelegate(int colorId);

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly TIQDQKXZXGW GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly GetGameColorFromIdDelegate IVVDNLAUPOP;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "4")]
		public CircuitsColor QTYFRISMRBZ(int a)
		{
			return default(CircuitsColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2847D90", Offset = "0x2846590", VA = "0x182847D90")]
		public EWEOSTEYPLB([Optional] GetGameColorFromIdDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class KEOXHNMHXFZ : VWXKZSHWOTI
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
			public KEOXHNMHXFZ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x284CA00", Offset = "0x284B200", VA = "0x18284CA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x284CBF0", Offset = "0x284B3F0", VA = "0x18284CBF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly IsStringPureAsyncDelegate COFHJGNFWQC;

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x28484E0", Offset = "0x2846CE0", VA = "0x1828484E0", Slot = "4")]
		[AsyncStateMachine(typeof(<IsStringPureAsync>d__2))]
		public Task<bool> ESUWZVSMRLO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2848620", Offset = "0x2846E20", VA = "0x182848620")]
		public KEOXHNMHXFZ([Optional] IsStringPureAsyncDelegate? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class UNDAPXIGWSJ : HKNCCPTDAZS
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public delegate TLUYCCORJJC? GetNodeVisualizationConfigDelegate([In] Id128<PYVBRMOVXVY> nodeDefId);

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly HKNCCPTDAZS GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly GetNodeVisualizationConfigDelegate DWKSXXOHBQV;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80")]
		public TLUYCCORJJC? ODPJDWUVLKF([In] Id128<PYVBRMOVXVY> nodeDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x2850280", Offset = "0x284EA80", VA = "0x182850280")]
		public UNDAPXIGWSJ([Optional] GetNodeVisualizationConfigDelegate? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x2847B80", Offset = "0x2846380", VA = "0x182847B80", Slot = "4")]
		private TLUYCCORJJC GWJFPUHZZFF([In] Id128<PYVBRMOVXVY> nodeDefId)
		{
			return null;
		}
	}
}
namespace Circuits.All.Mock.Api.Shared
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class TGRTQMIXLCA : MTYFAQDZYHV
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x284B750", Offset = "0x2849F50", VA = "0x18284B750", Slot = "4")]
		public YRIRYJIPQVK GZDBTLOGXDS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public TGRTQMIXLCA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class TAGGREUWQKY : WCHWBGPTGBX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private readonly Dictionary<string, bool> AUSXBXZGFVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private readonly Dictionary<string, float> FTDOCINIQAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private readonly Dictionary<string, double> EHHSWKCMEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private readonly Dictionary<string, int> IXXJLMFYCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private readonly Dictionary<string, long> BRRWIUYPFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<string, string> HGTBWCPXGJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly Dictionary<string, uint> MOBVRMPQWDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private readonly Dictionary<string, ulong> OBNUBNDSFFA;

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x284B440", Offset = "0x2849C40", VA = "0x18284B440", Slot = "4")]
		public bool? FMEQEDEASIZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x284B4E0", Offset = "0x2849CE0", VA = "0x18284B4E0")]
		public TAGGREUWQKY()
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
